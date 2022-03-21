using CP_CW_8392.UI.SwipeCollection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_CW_8392.UI
{
    public partial class Form1 : Form
    {
        //list of terminals and their statuses displayed in data grid view
        private List<Terminal> _terminalStatuses = new List<Terminal>();
        private SwipeCollectionServiceClient _client = new SwipeCollectionServiceClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //if there are already swipes in the db, populate data grid view
            PopulateSwipesTable();
            terminals_dgv.DataMember = "";
            terminals_dgv.DataSource = null;
        }
        //button click event that starts swipe collection
        private void Start_btn_Click(object sender, EventArgs e)
        {

                //invoke collection method on separate thread
                var startCollectionThread = new Thread(_client.StartCollectingSwipes);
                //invoke get status method on separate thread
                var getStatusThread = new Thread(GetStatus);
                startCollectionThread.Start();
            //little delay to start consuming statuses after swipe retrieval method is called
            Thread.Sleep(100);
            getStatusThread.Start();
               
        }
        //get statuses for each terminal
        private void GetStatus()
        {
            var shouldGetStatus = true;

            while (shouldGetStatus)
            {
                //disable button while retrieval is in progress
                this.Invoke(new MethodInvoker(() =>
                {
                    Start_btn.Enabled = false;
                }));
                var currentStatuses =_client.GetStatus();
                if(currentStatuses.Count()>0)
                {
                    //for each retrieved terminal, check if terminal with the same IP address
                    //exists in the list 
                    foreach (var item in currentStatuses)
                    {
                        var terminal = _terminalStatuses.Find(x => x?.IPAddress == item.IPAddress);
                        //if no terminal is found, add it to the list
                        if (terminal == null)
                        {
                            _terminalStatuses.Add(item);
                        }
                        //if terminal is already in the list, update its status
                        else
                        {
                            terminal.Status = item.Status;
                        }
                    }
                    //update data grid view to display statuses
                    this.Invoke(new MethodInvoker(() =>
                    {
                        //refreshing the data
                        terminals_dgv.DataMember = "";
                        terminals_dgv.DataSource = null;
                        terminals_dgv.DataSource = _terminalStatuses;
                    }));
                    //check if all terminals finished execution
                    if (currentStatuses.All(x => x.Status == Status.Finished))
                    {
                        //if so, stop calling GetStatus method
                        shouldGetStatus = false;
                        //enable button while retrieval is finished
                        this.Invoke(new MethodInvoker(() =>
                        {
                            Start_btn.Enabled = true;
                        }));
                        //retrieve all swipes from the database and display in data grid view
                        PopulateSwipesTable();
                    }
                }
                //iterate through this loop every 2 seconds
                Thread.Sleep(1000);
            }
        }
        //format rows color based on status
        private void swipes_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in terminals_dgv.Rows)
            {
                if(row.Cells[1].Value!=null)
                {
                    //if terminal is waiting, then row color is light gray
                    if ((Status)row.Cells[1].Value == Status.Waiting)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    //if terminal is processing, then row color is red
                    else if ((Status)row.Cells[1]?.Value == Status.InProcess)
                    {
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    //if terminal is finished, then row color is green
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                    }
                }

            }
        }
        //retrieve all swipes from the db
        private void PopulateSwipesTable()
        {
            try
            {
                //retrieve all swipes from the database and display in data grid view
                var swipes = _client.GetAllSwipes().ToList();
                this.Invoke(new MethodInvoker(() =>
                {
                    //refreshing the data
                    swipes_dgv.DataMember = "";
                    swipes_dgv.DataSource = null;
                    swipes_dgv.DataSource = swipes;
                }));
            } catch(CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

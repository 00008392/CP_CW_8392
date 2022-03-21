using CP_CW_8392.BLL.Contracts;
using CP_CW_8392.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynConnectDLL;
using System.Threading;

namespace CP_CW_8392.BLL.Services
{
    public class SwipeService : ISwipeService
    {
        private readonly ISwipeRepository _repository;
        //list of terminals swipes are retrieved from
        private List<Terminal> _terminals = new List<Terminal>();
        //semaphore object to control number of terminals processing swipes
        private Semaphore semaphore = new Semaphore(3, 3);
        //inject repository into service
        public SwipeService(ISwipeRepository repository)
        {
            _repository = repository;
        }

        public void CollectAndSaveSwipes()
        {
            //clear terminals list 
            _terminals.Clear();
            var threads = new Thread[6];
                //assume that there are 6 terminals in total
                //each thread is a terminal
                for (int i = 0; i < 6; i++)
                {
                    var thread = new Thread(ProcessSwipesFromTerminal);
                threads[i] = thread;
                    //start swipe collection
                    thread.Start($"192.168.1.{i}");
                }
             //wait for all terminals to finish their work
            foreach (var item in threads)
            {
                item.Join();
            }
        }
        //retrieve all swipes from the database
        public ICollection<Swipe> GetAllSwipes()
        {
            return _repository.GetSwipes();
        }
        //retrieve statuses of all terminals
        public ICollection<Terminal> GetStatus()
        {
            return _terminals;
        }

        //parse string with swipes into swipes collection
        private ICollection<Swipe> ParseSwipeData(string data, string IPAddress)
        {
            //split swipe items by new line character
            var swipeListStr = data.Split(new string[] { "\n" },
                StringSplitOptions.None);
            var swipeList = new List<Swipe>();
            //convert each string item into swipe object
            foreach (var item in swipeListStr)
            {
                //split string by comma 
                //array contains values for swipe properties
                string[] splittedSwipe = item.Split(',');
                //convert strings to property values
                var swipe = new Swipe
                {
                    PersonId = int.Parse(splittedSwipe[0]),
                    SwipeDateTime = DateTime.Parse(splittedSwipe[1]),
                    Direction = splittedSwipe[2], 
                    IPAdddress = IPAddress
                };
                swipeList.Add(swipe);
            }
            return swipeList;
        }
        //retrieve swipes from terminal and save in the db
        private void ProcessSwipesFromTerminal(object IPAddressObj)
        {
            var IPAddress = IPAddressObj.ToString();
            //find terminal in list of terminals or create new if it does not exist
            var terminal = _terminals.Find(x => string.Equals(IPAddress, x.IPAddress));
            if (terminal == null)
            {
                terminal = new Terminal()
                {
                    IPAddress = IPAddress
                };
                _terminals.Add(terminal);
            }
            //before going into critical section, put terminal into waiting state
            terminal.Status = Status.Waiting;
            //enter critical section
            semaphore.WaitOne();
            //indicate in status that terminal entered into critical section
            terminal.Status = Status.InProcess;
            //retrieve swipes from terminal
            var swipesStr = SynConnection.GetInstance().RetrieveSwipes(IPAddress);
            //parse string into swipes collection 
            var swipes = ParseSwipeData(swipesStr, IPAddress);
            //insert swipes into database
            _repository.InsertSwipes(swipes);
            //in the end, change status
            terminal.Status = Status.Finished;
            //exit from critical section
            semaphore.Release();
        }
    }
}

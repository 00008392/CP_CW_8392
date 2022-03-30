
namespace CP_CW_8392.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.terminals_dgv = new System.Windows.Forms.DataGridView();
            this.Start_btn = new System.Windows.Forms.Button();
            this.swipes_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAdddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.terminals_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipes_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // terminals_dgv
            // 
            this.terminals_dgv.AutoGenerateColumns = false;
            this.terminals_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminals_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iPAddressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.terminals_dgv.DataSource = this.terminalBindingSource;
            this.terminals_dgv.Location = new System.Drawing.Point(29, 43);
            this.terminals_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.terminals_dgv.Name = "terminals_dgv";
            this.terminals_dgv.RowHeadersWidth = 51;
            this.terminals_dgv.RowTemplate.Height = 24;
            this.terminals_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.terminals_dgv.Size = new System.Drawing.Size(409, 274);
            this.terminals_dgv.TabIndex = 0;
            this.terminals_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.swipes_dgv_CellFormatting);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(483, 43);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(163, 47);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start swipe collection";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // swipes_dgv
            // 
            this.swipes_dgv.AutoGenerateColumns = false;
            this.swipes_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.swipes_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directionDataGridViewTextBoxColumn,
            this.iPAdddressDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn,
            this.swipeDateTimeDataGridViewTextBoxColumn});
            this.swipes_dgv.DataSource = this.swipeBindingSource;
            this.swipes_dgv.Location = new System.Drawing.Point(29, 358);
            this.swipes_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swipes_dgv.Name = "swipes_dgv";
            this.swipes_dgv.RowHeadersWidth = 51;
            this.swipes_dgv.RowTemplate.Height = 24;
            this.swipes_dgv.Size = new System.Drawing.Size(717, 274);
            this.swipes_dgv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progress of terminals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Swipes";
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            this.directionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iPAdddressDataGridViewTextBoxColumn
            // 
            this.iPAdddressDataGridViewTextBoxColumn.DataPropertyName = "IPAdddress";
            this.iPAdddressDataGridViewTextBoxColumn.HeaderText = "IPAdddress";
            this.iPAdddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iPAdddressDataGridViewTextBoxColumn.Name = "iPAdddressDataGridViewTextBoxColumn";
            this.iPAdddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // swipeDateTimeDataGridViewTextBoxColumn
            // 
            this.swipeDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SwipeDateTime";
            this.swipeDateTimeDataGridViewTextBoxColumn.HeaderText = "SwipeDateTime";
            this.swipeDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.swipeDateTimeDataGridViewTextBoxColumn.Name = "swipeDateTimeDataGridViewTextBoxColumn";
            this.swipeDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // swipeBindingSource
            // 
            this.swipeBindingSource.DataSource = typeof(CP_CW_8392.UI.SwipeCollection.Swipe);
            // 
            // iPAddressDataGridViewTextBoxColumn
            // 
            this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IPAddress";
            this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IPAddress";
            this.iPAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
            this.iPAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminalBindingSource
            // 
            this.terminalBindingSource.DataSource = typeof(CP_CW_8392.UI.SwipeCollection.Terminal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swipes_dgv);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.terminals_dgv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terminals_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipes_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView terminals_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource terminalBindingSource;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.DataGridView swipes_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAdddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource swipeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


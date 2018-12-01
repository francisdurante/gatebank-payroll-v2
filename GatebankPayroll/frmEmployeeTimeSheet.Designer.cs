namespace GatebankPayroll
{
    partial class frmEmployeeTimeSheet
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
            this.lvTimeSheet = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.brtSearch = new System.Windows.Forms.Button();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTimeSheet
            // 
            this.lvTimeSheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chDate,
            this.chTimeIn,
            this.chTimeOut,
            this.chRemarks});
            this.lvTimeSheet.FullRowSelect = true;
            this.lvTimeSheet.GridLines = true;
            this.lvTimeSheet.Location = new System.Drawing.Point(12, 54);
            this.lvTimeSheet.Name = "lvTimeSheet";
            this.lvTimeSheet.Size = new System.Drawing.Size(689, 399);
            this.lvTimeSheet.TabIndex = 0;
            this.lvTimeSheet.UseCompatibleStateImageBehavior = false;
            this.lvTimeSheet.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chDate
            // 
            this.chDate.Text = "DATE";
            this.chDate.Width = 150;
            // 
            // chTimeIn
            // 
            this.chTimeIn.Text = "TIME IN";
            this.chTimeIn.Width = 120;
            // 
            // chTimeOut
            // 
            this.chTimeOut.Text = "TIME OUT";
            this.chTimeOut.Width = 120;
            // 
            // chRemarks
            // 
            this.chRemarks.Text = "REMARKS";
            this.chRemarks.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 63);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GatebankPayroll.Properties.Resources.Picture11;
            this.pictureBox1.Location = new System.Drawing.Point(465, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(9, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 16);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search";
            // 
            // brtSearch
            // 
            this.brtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brtSearch.Location = new System.Drawing.Point(316, 9);
            this.brtSearch.Name = "brtSearch";
            this.brtSearch.Size = new System.Drawing.Size(112, 40);
            this.brtSearch.TabIndex = 23;
            this.brtSearch.Text = "SEARCH";
            this.brtSearch.UseVisualStyleBackColor = true;
            this.brtSearch.Click += new System.EventHandler(this.brtSearch_Click);
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.Location = new System.Drawing.Point(13, 29);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(297, 20);
            this.dtpDateSearch.TabIndex = 24;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(434, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 40);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmEmployeeTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GatebankPayroll.Properties.Resources.thumb16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 534);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpDateSearch);
            this.Controls.Add(this.brtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvTimeSheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeTimeSheet";
            this.Text = "frmEmployeeTimeSheet";
            this.Load += new System.EventHandler(this.frmEmployeeTimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTimeSheet;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chTimeIn;
        private System.Windows.Forms.ColumnHeader chTimeOut;
        private System.Windows.Forms.ColumnHeader chRemarks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button brtSearch;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}
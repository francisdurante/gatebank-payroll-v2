namespace GatebankPayroll
{
    partial class frmShowPayrollList
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
            this.lvPayrollList = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPayrollDateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTakeHomePay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenratePayroll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPayrollList
            // 
            this.lvPayrollList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chDateFrom,
            this.chPayrollDateTo,
            this.chTakeHomePay});
            this.lvPayrollList.FullRowSelect = true;
            this.lvPayrollList.GridLines = true;
            this.lvPayrollList.Location = new System.Drawing.Point(12, 12);
            this.lvPayrollList.Name = "lvPayrollList";
            this.lvPayrollList.Size = new System.Drawing.Size(466, 296);
            this.lvPayrollList.TabIndex = 0;
            this.lvPayrollList.UseCompatibleStateImageBehavior = false;
            this.lvPayrollList.View = System.Windows.Forms.View.Details;
            this.lvPayrollList.DoubleClick += new System.EventHandler(this.lvPayrollList_DoubleClick);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chDateFrom
            // 
            this.chDateFrom.Text = "Payroll Date From";
            this.chDateFrom.Width = 120;
            // 
            // chPayrollDateTo
            // 
            this.chPayrollDateTo.Text = "Payroll Date To";
            this.chPayrollDateTo.Width = 120;
            // 
            // chTakeHomePay
            // 
            this.chTakeHomePay.Text = "Total Take Home Pay";
            this.chTakeHomePay.Width = 150;
            // 
            // btnGenratePayroll
            // 
            this.btnGenratePayroll.Location = new System.Drawing.Point(485, 12);
            this.btnGenratePayroll.Name = "btnGenratePayroll";
            this.btnGenratePayroll.Size = new System.Drawing.Size(97, 69);
            this.btnGenratePayroll.TabIndex = 1;
            this.btnGenratePayroll.Text = "GENERATE PAYROLL";
            this.btnGenratePayroll.UseVisualStyleBackColor = true;
            this.btnGenratePayroll.Click += new System.EventHandler(this.btnGenratePayroll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 69);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GatebankPayroll.Properties.Resources.Picture11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowPayrollList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GatebankPayroll.Properties.Resources.gradient_series___light_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenratePayroll);
            this.Controls.Add(this.lvPayrollList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowPayrollList";
            this.Text = "frmShowPayrollList";
            this.Load += new System.EventHandler(this.frmShowPayrollList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPayrollList;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chDateFrom;
        private System.Windows.Forms.ColumnHeader chPayrollDateTo;
        private System.Windows.Forms.ColumnHeader chTakeHomePay;
        private System.Windows.Forms.Button btnGenratePayroll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
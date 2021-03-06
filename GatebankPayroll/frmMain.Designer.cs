﻿namespace GatebankPayroll
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssAccessLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.payrollMS = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollMaintenanceMS = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseParollUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPayrollMS = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeSheetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssUserID,
            this.ssFullname,
            this.ssAccessLevel,
            this.ssDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(234, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(726, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssUserID
            // 
            this.ssUserID.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssUserID.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.ssUserID.Name = "ssUserID";
            this.ssUserID.Size = new System.Drawing.Size(43, 19);
            this.ssUserID.Text = "userId";
            // 
            // ssFullname
            // 
            this.ssFullname.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssFullname.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.ssFullname.Name = "ssFullname";
            this.ssFullname.Size = new System.Drawing.Size(60, 19);
            this.ssFullname.Text = "fullName";
            // 
            // ssAccessLevel
            // 
            this.ssAccessLevel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssAccessLevel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.ssAccessLevel.Name = "ssAccessLevel";
            this.ssAccessLevel.Size = new System.Drawing.Size(74, 19);
            this.ssAccessLevel.Text = "AccessLevel";
            // 
            // ssDateTime
            // 
            this.ssDateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ssDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.ssDateTime.Name = "ssDateTime";
            this.ssDateTime.Size = new System.Drawing.Size(61, 19);
            this.ssDateTime.Text = "dateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msMain
            // 
            this.msMain.BackgroundImage = global::GatebankPayroll.Properties.Resources.thumb16;
            this.msMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollMS,
            this.payrollMaintenanceMS,
            this.showPayrollMS,
            this.TimeSheetMS,
            this.lOGOUTToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(234, 677);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // payrollMS
            // 
            this.payrollMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.payrollMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePayrollToolStripMenuItem});
            this.payrollMS.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollMS.Image = global::GatebankPayroll.Properties.Resources.if_408_Money_21245121;
            this.payrollMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payrollMS.Name = "payrollMS";
            this.payrollMS.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.payrollMS.Size = new System.Drawing.Size(221, 117);
            this.payrollMS.Text = "Generate Payroll";
            this.payrollMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // generatePayrollToolStripMenuItem
            // 
            this.generatePayrollToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePayrollToolStripMenuItem.Name = "generatePayrollToolStripMenuItem";
            this.generatePayrollToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.generatePayrollToolStripMenuItem.Text = "Generate Payroll";
            this.generatePayrollToolStripMenuItem.Click += new System.EventHandler(this.generatePayrollToolStripMenuItem_Click);
            // 
            // payrollMaintenanceMS
            // 
            this.payrollMaintenanceMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.browseParollUsersToolStripMenuItem});
            this.payrollMaintenanceMS.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollMaintenanceMS.Image = global::GatebankPayroll.Properties.Resources.if_maintenance_repair_service_Gear_3853928;
            this.payrollMaintenanceMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payrollMaintenanceMS.Name = "payrollMaintenanceMS";
            this.payrollMaintenanceMS.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.payrollMaintenanceMS.Size = new System.Drawing.Size(221, 117);
            this.payrollMaintenanceMS.Text = "Payroll Maintenance";
            this.payrollMaintenanceMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // browseParollUsersToolStripMenuItem
            // 
            this.browseParollUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.browseParollUsersToolStripMenuItem.Name = "browseParollUsersToolStripMenuItem";
            this.browseParollUsersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.browseParollUsersToolStripMenuItem.Text = "Browse Payroll Users";
            this.browseParollUsersToolStripMenuItem.Click += new System.EventHandler(this.browseParollUsersToolStripMenuItem_Click);
            // 
            // showPayrollMS
            // 
            this.showPayrollMS.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.showPayrollMS.Image = global::GatebankPayroll.Properties.Resources.iconfinder_list_unordered_298815;
            this.showPayrollMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPayrollMS.Name = "showPayrollMS";
            this.showPayrollMS.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.showPayrollMS.Size = new System.Drawing.Size(221, 133);
            this.showPayrollMS.Text = "Show Payroll";
            this.showPayrollMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showPayrollMS.Click += new System.EventHandler(this.showPayrollMS_Click);
            // 
            // TimeSheetMS
            // 
            this.TimeSheetMS.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.TimeSheetMS.Image = global::GatebankPayroll.Properties.Resources.iconfinder_10_171505;
            this.TimeSheetMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TimeSheetMS.Name = "TimeSheetMS";
            this.TimeSheetMS.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TimeSheetMS.Size = new System.Drawing.Size(221, 117);
            this.TimeSheetMS.Text = "Show Time Sheet";
            this.TimeSheetMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TimeSheetMS.Click += new System.EventHandler(this.TimeSheetMS_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOUTToolStripMenuItem.Image = global::GatebankPayroll.Properties.Resources.if_icons_exit2_1564506;
            this.lOGOUTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(221, 77);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GatebankPayroll.Properties.Resources.Picture11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(960, 677);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Gatebank Payroll Version 2.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssUserID;
        private System.Windows.Forms.ToolStripStatusLabel ssFullname;
        private System.Windows.Forms.ToolStripStatusLabel ssAccessLevel;
        private System.Windows.Forms.ToolStripStatusLabel ssDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem payrollMS;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollMaintenanceMS;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseParollUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPayrollMS;
        private System.Windows.Forms.ToolStripMenuItem TimeSheetMS;
    }
}
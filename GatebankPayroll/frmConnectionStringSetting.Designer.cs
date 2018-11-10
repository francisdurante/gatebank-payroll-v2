namespace GatebankPayroll
{
    partial class frmConnectionStringSetting
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
            this.lbDbUsername = new System.Windows.Forms.Label();
            this.lbldbPassword = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDbUsername = new System.Windows.Forms.TextBox();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDbUsername
            // 
            this.lbDbUsername.AutoSize = true;
            this.lbDbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbDbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDbUsername.Location = new System.Drawing.Point(12, 49);
            this.lbDbUsername.Name = "lbDbUsername";
            this.lbDbUsername.Size = new System.Drawing.Size(163, 16);
            this.lbDbUsername.TabIndex = 0;
            this.lbDbUsername.Text = "Database Username : ";
            // 
            // lbldbPassword
            // 
            this.lbldbPassword.AutoSize = true;
            this.lbldbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbldbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldbPassword.Location = new System.Drawing.Point(12, 75);
            this.lbldbPassword.Name = "lbldbPassword";
            this.lbldbPassword.Size = new System.Drawing.Size(160, 16);
            this.lbldbPassword.TabIndex = 1;
            this.lbldbPassword.Text = "Database Password : ";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.Color.Transparent;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(12, 23);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(138, 16);
            this.lblServerName.TabIndex = 2;
            this.lblServerName.Text = "Database Server : ";
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.BackColor = System.Drawing.Color.Transparent;
            this.lblDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbName.Location = new System.Drawing.Point(12, 101);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(133, 16);
            this.lblDbName.TabIndex = 3;
            this.lblDbName.Text = "Database Name : ";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(188, 22);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(266, 20);
            this.txtServer.TabIndex = 4;
            // 
            // txtDbUsername
            // 
            this.txtDbUsername.Location = new System.Drawing.Point(188, 48);
            this.txtDbUsername.Name = "txtDbUsername";
            this.txtDbUsername.Size = new System.Drawing.Size(266, 20);
            this.txtDbUsername.TabIndex = 5;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(188, 74);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '*';
            this.txtDbPassword.Size = new System.Drawing.Size(266, 20);
            this.txtDbPassword.TabIndex = 6;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(188, 100);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(266, 20);
            this.txtDbName.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConnectionStringSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GatebankPayroll.Properties.Resources.thumb16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtDbPassword);
            this.Controls.Add(this.txtDbUsername);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblDbName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.lbldbPassword);
            this.Controls.Add(this.lbDbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnectionStringSetting";
            this.Text = "frmConnectionStringSetting";
            this.Load += new System.EventHandler(this.frmConnectionStringSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionString_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDbUsername;
        private System.Windows.Forms.Label lbldbPassword;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDbUsername;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}
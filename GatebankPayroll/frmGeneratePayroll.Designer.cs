namespace GatebankPayroll
{
    partial class frmGeneratePayroll
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
            this.gbDeductions = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOthers = new System.Windows.Forms.Label();
            this.txtArHCard = new System.Windows.Forms.TextBox();
            this.lblARCard = new System.Windows.Forms.Label();
            this.txtSMCard = new System.Windows.Forms.TextBox();
            this.lblSMcard = new System.Windows.Forms.Label();
            this.txtProviFund = new System.Windows.Forms.TextBox();
            this.lblProvident = new System.Windows.Forms.Label();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.lblLate = new System.Windows.Forms.Label();
            this.txtAbsent = new System.Windows.Forms.TextBox();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.gbLoanDeductions = new System.Windows.Forms.GroupBox();
            this.txtProviLoan = new System.Windows.Forms.TextBox();
            this.lblProviLoan = new System.Windows.Forms.Label();
            this.txtPagIbigLoan = new System.Windows.Forms.TextBox();
            this.pagIbigLoan = new System.Windows.Forms.Label();
            this.txtSSSLoanD = new System.Windows.Forms.TextBox();
            this.lblSSSLoan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWTaxD = new System.Windows.Forms.TextBox();
            this.lblWTax = new System.Windows.Forms.Label();
            this.txtPHD = new System.Windows.Forms.TextBox();
            this.lblPH = new System.Windows.Forms.Label();
            this.txtPagIbigD = new System.Windows.Forms.TextBox();
            this.lblPagIbig = new System.Windows.Forms.Label();
            this.txtSSSD = new System.Windows.Forms.TextBox();
            this.lblSSS = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOther3Txt = new System.Windows.Forms.TextBox();
            this.txtOther3 = new System.Windows.Forms.TextBox();
            this.txtOther2Txt = new System.Windows.Forms.TextBox();
            this.txtOther2 = new System.Windows.Forms.TextBox();
            this.txtOther1Txt = new System.Windows.Forms.TextBox();
            this.txtOther1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtIncentives = new System.Windows.Forms.TextBox();
            this.lblIncentives = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.lblBasicSalaryContent = new System.Windows.Forms.Label();
            this.lblbasicSalary = new System.Windows.Forms.Label();
            this.lblPositionContent = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblpayrollDate = new System.Windows.Forms.Label();
            this.cnEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDeductions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbLoanDeductions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDeductions
            // 
            this.gbDeductions.BackColor = System.Drawing.Color.Transparent;
            this.gbDeductions.Controls.Add(this.groupBox2);
            this.gbDeductions.Controls.Add(this.gbLoanDeductions);
            this.gbDeductions.Controls.Add(this.groupBox1);
            this.gbDeductions.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeductions.Location = new System.Drawing.Point(14, 137);
            this.gbDeductions.Name = "gbDeductions";
            this.gbDeductions.Size = new System.Drawing.Size(355, 558);
            this.gbDeductions.TabIndex = 1;
            this.gbDeductions.TabStop = false;
            this.gbDeductions.Text = "DEDUCTIONS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtOther);
            this.groupBox2.Controls.Add(this.lblOthers);
            this.groupBox2.Controls.Add(this.txtArHCard);
            this.groupBox2.Controls.Add(this.lblARCard);
            this.groupBox2.Controls.Add(this.txtSMCard);
            this.groupBox2.Controls.Add(this.lblSMcard);
            this.groupBox2.Controls.Add(this.txtProviFund);
            this.groupBox2.Controls.Add(this.lblProvident);
            this.groupBox2.Controls.Add(this.txtLate);
            this.groupBox2.Controls.Add(this.lblLate);
            this.groupBox2.Controls.Add(this.txtAbsent);
            this.groupBox2.Controls.Add(this.lblAbsent);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 239);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Deductions";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(145, 167);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(188, 23);
            this.txtOther.TabIndex = 14;
            this.txtOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(16, 170);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(69, 15);
            this.lblOthers.TabIndex = 14;
            this.lblOthers.Text = "OTHERS : ";
            // 
            // txtArHCard
            // 
            this.txtArHCard.Location = new System.Drawing.Point(145, 138);
            this.txtArHCard.Name = "txtArHCard";
            this.txtArHCard.Size = new System.Drawing.Size(188, 23);
            this.txtArHCard.TabIndex = 13;
            this.txtArHCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblARCard
            // 
            this.lblARCard.AutoSize = true;
            this.lblARCard.Location = new System.Drawing.Point(16, 141);
            this.lblARCard.Name = "lblARCard";
            this.lblARCard.Size = new System.Drawing.Size(130, 15);
            this.lblARCard.TabIndex = 12;
            this.lblARCard.Text = "AR HEALTH CARD : ";
            // 
            // txtSMCard
            // 
            this.txtSMCard.Location = new System.Drawing.Point(145, 109);
            this.txtSMCard.Name = "txtSMCard";
            this.txtSMCard.Size = new System.Drawing.Size(188, 23);
            this.txtSMCard.TabIndex = 12;
            this.txtSMCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblSMcard
            // 
            this.lblSMcard.AutoSize = true;
            this.lblSMcard.Location = new System.Drawing.Point(16, 112);
            this.lblSMcard.Name = "lblSMcard";
            this.lblSMcard.Size = new System.Drawing.Size(77, 15);
            this.lblSMcard.TabIndex = 10;
            this.lblSMcard.Text = "SM CARD : ";
            // 
            // txtProviFund
            // 
            this.txtProviFund.Location = new System.Drawing.Point(145, 80);
            this.txtProviFund.Name = "txtProviFund";
            this.txtProviFund.Size = new System.Drawing.Size(188, 23);
            this.txtProviFund.TabIndex = 11;
            this.txtProviFund.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblProvident
            // 
            this.lblProvident.AutoSize = true;
            this.lblProvident.Location = new System.Drawing.Point(16, 83);
            this.lblProvident.Name = "lblProvident";
            this.lblProvident.Size = new System.Drawing.Size(130, 15);
            this.lblProvident.TabIndex = 6;
            this.lblProvident.Text = "PROVIDENT FUND : ";
            // 
            // txtLate
            // 
            this.txtLate.Location = new System.Drawing.Point(145, 51);
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(188, 23);
            this.txtLate.TabIndex = 9;
            this.txtLate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(16, 54);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(57, 15);
            this.lblLate.TabIndex = 2;
            this.lblLate.Text = "LATES : ";
            // 
            // txtAbsent
            // 
            this.txtAbsent.Location = new System.Drawing.Point(145, 22);
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(188, 23);
            this.txtAbsent.TabIndex = 8;
            this.txtAbsent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.Location = new System.Drawing.Point(16, 25);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(75, 15);
            this.lblAbsent.TabIndex = 0;
            this.lblAbsent.Text = "ABSENTS : ";
            // 
            // gbLoanDeductions
            // 
            this.gbLoanDeductions.BackColor = System.Drawing.Color.Transparent;
            this.gbLoanDeductions.Controls.Add(this.txtProviLoan);
            this.gbLoanDeductions.Controls.Add(this.lblProviLoan);
            this.gbLoanDeductions.Controls.Add(this.txtPagIbigLoan);
            this.gbLoanDeductions.Controls.Add(this.pagIbigLoan);
            this.gbLoanDeductions.Controls.Add(this.txtSSSLoanD);
            this.gbLoanDeductions.Controls.Add(this.lblSSSLoan);
            this.gbLoanDeductions.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoanDeductions.Location = new System.Drawing.Point(6, 172);
            this.gbLoanDeductions.Name = "gbLoanDeductions";
            this.gbLoanDeductions.Size = new System.Drawing.Size(339, 124);
            this.gbLoanDeductions.TabIndex = 6;
            this.gbLoanDeductions.TabStop = false;
            this.gbLoanDeductions.Text = "Loan Deductions";
            // 
            // txtProviLoan
            // 
            this.txtProviLoan.Location = new System.Drawing.Point(145, 80);
            this.txtProviLoan.Name = "txtProviLoan";
            this.txtProviLoan.Size = new System.Drawing.Size(188, 23);
            this.txtProviLoan.TabIndex = 7;
            this.txtProviLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblProviLoan
            // 
            this.lblProviLoan.AutoSize = true;
            this.lblProviLoan.Location = new System.Drawing.Point(16, 83);
            this.lblProviLoan.Name = "lblProviLoan";
            this.lblProviLoan.Size = new System.Drawing.Size(127, 15);
            this.lblProviLoan.TabIndex = 4;
            this.lblProviLoan.Text = "PROVIDENT LOAN :";
            // 
            // txtPagIbigLoan
            // 
            this.txtPagIbigLoan.Location = new System.Drawing.Point(145, 51);
            this.txtPagIbigLoan.Name = "txtPagIbigLoan";
            this.txtPagIbigLoan.Size = new System.Drawing.Size(188, 23);
            this.txtPagIbigLoan.TabIndex = 6;
            this.txtPagIbigLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // pagIbigLoan
            // 
            this.pagIbigLoan.AutoSize = true;
            this.pagIbigLoan.Location = new System.Drawing.Point(16, 54);
            this.pagIbigLoan.Name = "pagIbigLoan";
            this.pagIbigLoan.Size = new System.Drawing.Size(110, 15);
            this.pagIbigLoan.TabIndex = 2;
            this.pagIbigLoan.Text = "PAGIBIG LOAN : ";
            // 
            // txtSSSLoanD
            // 
            this.txtSSSLoanD.Location = new System.Drawing.Point(145, 22);
            this.txtSSSLoanD.Name = "txtSSSLoanD";
            this.txtSSSLoanD.Size = new System.Drawing.Size(188, 23);
            this.txtSSSLoanD.TabIndex = 5;
            this.txtSSSLoanD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblSSSLoan
            // 
            this.lblSSSLoan.AutoSize = true;
            this.lblSSSLoan.Location = new System.Drawing.Point(16, 25);
            this.lblSSSLoan.Name = "lblSSSLoan";
            this.lblSSSLoan.Size = new System.Drawing.Size(80, 15);
            this.lblSSSLoan.TabIndex = 0;
            this.lblSSSLoan.Text = "SSS LOAN : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtWTaxD);
            this.groupBox1.Controls.Add(this.lblWTax);
            this.groupBox1.Controls.Add(this.txtPHD);
            this.groupBox1.Controls.Add(this.lblPH);
            this.groupBox1.Controls.Add(this.txtPagIbigD);
            this.groupBox1.Controls.Add(this.lblPagIbig);
            this.groupBox1.Controls.Add(this.txtSSSD);
            this.groupBox1.Controls.Add(this.lblSSS);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Government Deductions";
            // 
            // txtWTaxD
            // 
            this.txtWTaxD.Location = new System.Drawing.Point(145, 109);
            this.txtWTaxD.Name = "txtWTaxD";
            this.txtWTaxD.Size = new System.Drawing.Size(188, 23);
            this.txtWTaxD.TabIndex = 4;
            this.txtWTaxD.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.txtWTaxD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblWTax
            // 
            this.lblWTax.AutoSize = true;
            this.lblWTax.Location = new System.Drawing.Point(16, 112);
            this.lblWTax.Name = "lblWTax";
            this.lblWTax.Size = new System.Drawing.Size(62, 15);
            this.lblWTax.TabIndex = 10;
            this.lblWTax.Text = "W/TAX : ";
            // 
            // txtPHD
            // 
            this.txtPHD.Location = new System.Drawing.Point(145, 80);
            this.txtPHD.Name = "txtPHD";
            this.txtPHD.Size = new System.Drawing.Size(188, 23);
            this.txtPHD.TabIndex = 3;
            this.txtPHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblPH
            // 
            this.lblPH.AutoSize = true;
            this.lblPH.Location = new System.Drawing.Point(16, 83);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(95, 15);
            this.lblPH.TabIndex = 4;
            this.lblPH.Text = "PHILHEALTH :";
            // 
            // txtPagIbigD
            // 
            this.txtPagIbigD.Location = new System.Drawing.Point(145, 51);
            this.txtPagIbigD.Name = "txtPagIbigD";
            this.txtPagIbigD.Size = new System.Drawing.Size(188, 23);
            this.txtPagIbigD.TabIndex = 2;
            this.txtPagIbigD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblPagIbig
            // 
            this.lblPagIbig.AutoSize = true;
            this.lblPagIbig.Location = new System.Drawing.Point(16, 54);
            this.lblPagIbig.Name = "lblPagIbig";
            this.lblPagIbig.Size = new System.Drawing.Size(74, 15);
            this.lblPagIbig.TabIndex = 2;
            this.lblPagIbig.Text = "PAG IBIG : ";
            // 
            // txtSSSD
            // 
            this.txtSSSD.Location = new System.Drawing.Point(145, 22);
            this.txtSSSD.Name = "txtSSSD";
            this.txtSSSD.Size = new System.Drawing.Size(188, 23);
            this.txtSSSD.TabIndex = 1;
            this.txtSSSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Location = new System.Drawing.Point(16, 25);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(40, 15);
            this.lblSSS.TabIndex = 0;
            this.lblSSS.Text = "SSS : ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtOther3Txt);
            this.groupBox3.Controls.Add(this.txtOther3);
            this.groupBox3.Controls.Add(this.txtOther2Txt);
            this.groupBox3.Controls.Add(this.txtOther2);
            this.groupBox3.Controls.Add(this.txtOther1Txt);
            this.groupBox3.Controls.Add(this.txtOther1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtBonus);
            this.groupBox3.Controls.Add(this.lblBonus);
            this.groupBox3.Controls.Add(this.txtIncentives);
            this.groupBox3.Controls.Add(this.lblIncentives);
            this.groupBox3.Controls.Add(this.txtAllowance);
            this.groupBox3.Controls.Add(this.lblAllowance);
            this.groupBox3.Controls.Add(this.txtOT);
            this.groupBox3.Controls.Add(this.lblOT);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(375, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 296);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADDITIONALS";
            // 
            // txtOther3Txt
            // 
            this.txtOther3Txt.Location = new System.Drawing.Point(17, 230);
            this.txtOther3Txt.Name = "txtOther3Txt";
            this.txtOther3Txt.Size = new System.Drawing.Size(99, 23);
            this.txtOther3Txt.TabIndex = 23;
            // 
            // txtOther3
            // 
            this.txtOther3.Location = new System.Drawing.Point(146, 230);
            this.txtOther3.Name = "txtOther3";
            this.txtOther3.Size = new System.Drawing.Size(188, 23);
            this.txtOther3.TabIndex = 24;
            this.txtOther3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // txtOther2Txt
            // 
            this.txtOther2Txt.Location = new System.Drawing.Point(17, 201);
            this.txtOther2Txt.Name = "txtOther2Txt";
            this.txtOther2Txt.Size = new System.Drawing.Size(99, 23);
            this.txtOther2Txt.TabIndex = 21;
            // 
            // txtOther2
            // 
            this.txtOther2.Location = new System.Drawing.Point(146, 201);
            this.txtOther2.Name = "txtOther2";
            this.txtOther2.Size = new System.Drawing.Size(188, 23);
            this.txtOther2.TabIndex = 22;
            this.txtOther2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // txtOther1Txt
            // 
            this.txtOther1Txt.Location = new System.Drawing.Point(17, 172);
            this.txtOther1Txt.Name = "txtOther1Txt";
            this.txtOther1Txt.Size = new System.Drawing.Size(99, 23);
            this.txtOther1Txt.TabIndex = 19;
            // 
            // txtOther1
            // 
            this.txtOther1.Location = new System.Drawing.Point(146, 172);
            this.txtOther1.Name = "txtOther1";
            this.txtOther1.Size = new System.Drawing.Size(188, 23);
            this.txtOther1.TabIndex = 20;
            this.txtOther1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(122, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "OTHERS : ";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(146, 109);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(188, 23);
            this.txtBonus.TabIndex = 18;
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(17, 112);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(63, 15);
            this.lblBonus.TabIndex = 18;
            this.lblBonus.Text = "BONUS : ";
            // 
            // txtIncentives
            // 
            this.txtIncentives.Location = new System.Drawing.Point(146, 80);
            this.txtIncentives.Name = "txtIncentives";
            this.txtIncentives.Size = new System.Drawing.Size(188, 23);
            this.txtIncentives.TabIndex = 17;
            this.txtIncentives.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblIncentives
            // 
            this.lblIncentives.AutoSize = true;
            this.lblIncentives.Location = new System.Drawing.Point(17, 83);
            this.lblIncentives.Name = "lblIncentives";
            this.lblIncentives.Size = new System.Drawing.Size(93, 15);
            this.lblIncentives.TabIndex = 16;
            this.lblIncentives.Text = "INCENTIVES : ";
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(146, 51);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(188, 23);
            this.txtAllowance.TabIndex = 16;
            this.txtAllowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(17, 54);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(99, 15);
            this.lblAllowance.TabIndex = 14;
            this.lblAllowance.Text = "ALLOWANCE : ";
            // 
            // txtOT
            // 
            this.txtOT.Location = new System.Drawing.Point(146, 22);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(188, 23);
            this.txtOT.TabIndex = 15;
            this.txtOT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_keypress);
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Location = new System.Drawing.Point(17, 25);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(45, 15);
            this.lblOT.TabIndex = 12;
            this.lblOT.Text = "O.T. : ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtRemarks);
            this.groupBox4.Controls.Add(this.lblRemarks);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(375, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 256);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REMARKS";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(20, 46);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(314, 193);
            this.txtRemarks.TabIndex = 25;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(17, 25);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(78, 15);
            this.lblRemarks.TabIndex = 12;
            this.lblRemarks.Text = "REMARKS : ";
            // 
            // gbEmployee
            // 
            this.gbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.gbEmployee.Controls.Add(this.lblBasicSalaryContent);
            this.gbEmployee.Controls.Add(this.lblbasicSalary);
            this.gbEmployee.Controls.Add(this.lblPositionContent);
            this.gbEmployee.Controls.Add(this.lblPosition);
            this.gbEmployee.Controls.Add(this.label24);
            this.gbEmployee.Controls.Add(this.lblDateTo);
            this.gbEmployee.Controls.Add(this.dtpTo);
            this.gbEmployee.Controls.Add(this.lblDateFrom);
            this.gbEmployee.Controls.Add(this.dtpFrom);
            this.gbEmployee.Controls.Add(this.lblpayrollDate);
            this.gbEmployee.Controls.Add(this.cnEmployeeName);
            this.gbEmployee.Controls.Add(this.lblEmployeeName);
            this.gbEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployee.Location = new System.Drawing.Point(20, 13);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(710, 118);
            this.gbEmployee.TabIndex = 28;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "EMPLOYEE INFORMATION";
            this.gbEmployee.Enter += new System.EventHandler(this.gbEmployee_Enter);
            // 
            // lblBasicSalaryContent
            // 
            this.lblBasicSalaryContent.AutoSize = true;
            this.lblBasicSalaryContent.Location = new System.Drawing.Point(552, 48);
            this.lblBasicSalaryContent.Name = "lblBasicSalaryContent";
            this.lblBasicSalaryContent.Size = new System.Drawing.Size(49, 15);
            this.lblBasicSalaryContent.TabIndex = 23;
            this.lblBasicSalaryContent.Text = "######";
            // 
            // lblbasicSalary
            // 
            this.lblbasicSalary.AutoSize = true;
            this.lblbasicSalary.Location = new System.Drawing.Point(449, 48);
            this.lblbasicSalary.Name = "lblbasicSalary";
            this.lblbasicSalary.Size = new System.Drawing.Size(97, 15);
            this.lblbasicSalary.TabIndex = 22;
            this.lblbasicSalary.Text = "BASIC SALARY : ";
            // 
            // lblPositionContent
            // 
            this.lblPositionContent.AutoSize = true;
            this.lblPositionContent.Location = new System.Drawing.Point(552, 19);
            this.lblPositionContent.Name = "lblPositionContent";
            this.lblPositionContent.Size = new System.Drawing.Size(49, 15);
            this.lblPositionContent.TabIndex = 21;
            this.lblPositionContent.Text = "######";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(449, 19);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 15);
            this.lblPosition.TabIndex = 20;
            this.lblPosition.Text = "POSITION : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(246, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 15);
            this.label24.TabIndex = 19;
            this.label24.Text = "-";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(304, 71);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(23, 15);
            this.lblDateTo.TabIndex = 18;
            this.lblDateTo.Text = "TO";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(274, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(112, 23);
            this.dtpTo.TabIndex = 17;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(153, 71);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(41, 15);
            this.lblDateFrom.TabIndex = 16;
            this.lblDateFrom.Text = "FROM";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(123, 45);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(112, 23);
            this.dtpFrom.TabIndex = 15;
            // 
            // lblpayrollDate
            // 
            this.lblpayrollDate.AutoSize = true;
            this.lblpayrollDate.Location = new System.Drawing.Point(6, 51);
            this.lblpayrollDate.Name = "lblpayrollDate";
            this.lblpayrollDate.Size = new System.Drawing.Size(100, 15);
            this.lblpayrollDate.TabIndex = 14;
            this.lblpayrollDate.Text = "PAYROLL DATE : ";
            // 
            // cnEmployeeName
            // 
            this.cnEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cnEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cnEmployeeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnEmployeeName.FormattingEnabled = true;
            this.cnEmployeeName.Location = new System.Drawing.Point(123, 16);
            this.cnEmployeeName.Name = "cnEmployeeName";
            this.cnEmployeeName.Size = new System.Drawing.Size(263, 23);
            this.cnEmployeeName.TabIndex = 0;
            this.cnEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cnEmployeeName_SelectedIndexChanged);
            this.cnEmployeeName.Leave += new System.EventHandler(this.cnEmployeeName_Leave);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 19);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(111, 15);
            this.lblEmployeeName.TabIndex = 12;
            this.lblEmployeeName.Text = "EMPLOYEE NAME : ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(748, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 86);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(748, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 86);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GatebankPayroll.Properties.Resources.Picture11;
            this.pictureBox1.Location = new System.Drawing.Point(744, 645);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmGeneratePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GatebankPayroll.Properties.Resources.thumb16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDeductions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneratePayroll";
            this.Text = "frmGeneratePayroll";
            this.Load += new System.EventHandler(this.frmGeneratePayroll_Load);
            this.gbDeductions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbLoanDeductions.ResumeLayout(false);
            this.gbLoanDeductions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeductions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArHCard;
        private System.Windows.Forms.Label lblARCard;
        private System.Windows.Forms.TextBox txtSMCard;
        private System.Windows.Forms.Label lblSMcard;
        private System.Windows.Forms.TextBox txtProviFund;
        private System.Windows.Forms.Label lblProvident;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.TextBox txtAbsent;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.GroupBox gbLoanDeductions;
        private System.Windows.Forms.TextBox txtProviLoan;
        private System.Windows.Forms.Label lblProviLoan;
        private System.Windows.Forms.TextBox txtPagIbigLoan;
        private System.Windows.Forms.Label pagIbigLoan;
        private System.Windows.Forms.TextBox txtSSSLoanD;
        private System.Windows.Forms.Label lblSSSLoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWTaxD;
        private System.Windows.Forms.Label lblWTax;
        private System.Windows.Forms.TextBox txtPHD;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.TextBox txtPagIbigD;
        private System.Windows.Forms.Label lblPagIbig;
        private System.Windows.Forms.TextBox txtSSSD;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOther3Txt;
        private System.Windows.Forms.TextBox txtOther3;
        private System.Windows.Forms.TextBox txtOther2Txt;
        private System.Windows.Forms.TextBox txtOther2;
        private System.Windows.Forms.TextBox txtOther1Txt;
        private System.Windows.Forms.TextBox txtOther1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtIncentives;
        private System.Windows.Forms.Label lblIncentives;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.TextBox txtOT;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.ComboBox cnEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblBasicSalaryContent;
        private System.Windows.Forms.Label lblbasicSalary;
        private System.Windows.Forms.Label lblPositionContent;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblpayrollDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
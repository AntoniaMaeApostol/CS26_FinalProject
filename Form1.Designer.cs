namespace Garage_Door_Services
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabAddJob = new TabPage();
            tabAddJob_ControlTabs = new TabControl();
            tabAddJob_Job = new TabPage();
            pictureBox1 = new PictureBox();
            txtCity = new TextBox();
            groupBox3 = new GroupBox();
            btnClose = new Button();
            btnRecPayment = new Button();
            txtBalance = new TextBox();
            txtTotalPaid = new TextBox();
            label27 = new Label();
            label26 = new Label();
            txtTotal = new TextBox();
            label25 = new Label();
            txtPartCost = new TextBox();
            label24 = new Label();
            txtAddCharge = new TextBox();
            label23 = new Label();
            comboPayMethod = new ComboBox();
            textBox6 = new TextBox();
            label12 = new Label();
            label22 = new Label();
            groupBox2 = new GroupBox();
            txtReasonCancel = new TextBox();
            comboWho = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSaveJob = new Button();
            dateTimeJobCreated = new DateTimePicker();
            groupBox1 = new GroupBox();
            comboEndTIme = new ComboBox();
            comboStartTime = new ComboBox();
            btnClearAppt = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            dateTimeAppt = new DateTimePicker();
            comboJobDesc = new ComboBox();
            label16 = new Label();
            chckEmail = new CheckBox();
            chckSMS = new CheckBox();
            comboTech = new ComboBox();
            label15 = new Label();
            comboAdSource = new ComboBox();
            label14 = new Label();
            comboStatus = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            textBox4 = new TextBox();
            comboState = new ComboBox();
            comboCountry = new ComboBox();
            cboTimezone = new ComboBox();
            btnMapIt = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            txtZip = new TextBox();
            txtAddress = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblPhone2 = new Label();
            txtMetro = new TextBox();
            txtEmail = new TextBox();
            txtPhone2 = new TextBox();
            txtPhone = new TextBox();
            lblAddJob_Job_Phone = new Label();
            txtName = new TextBox();
            lblAddJob_Job_Name = new Label();
            txtCompany = new TextBox();
            lblAddJob_Job_Company = new Label();
            webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            picWebView = new PictureBox();
            tabAddJob_Log = new TabPage();
            tabJobs = new TabPage();
            tabJobs_ControlTabs = new TabControl();
            tabJobs_JobList = new TabPage();
            tabJobs_Calendar = new TabPage();
            tabMessages = new TabPage();
            tabMessages_ControlTabs = new TabControl();
            tabMessages_Messages = new TabPage();
            tabSearch = new TabPage();
            tabSearch_ControlTabs = new TabControl();
            tabSearch_Search = new TabPage();
            tabReports = new TabPage();
            tabReports_ControlTabs = new TabControl();
            tabReoprts_Payments = new TabPage();
            tabReports_Technicians = new TabPage();
            tabSettings = new TabPage();
            tabSettings_ControlTabs = new TabControl();
            tabSettings_Companies = new TabPage();
            tabSettings_Technicians = new TabPage();
            tabSettings_Jobs = new TabPage();
            tabSettings_User = new TabPage();
            tabSettings_System = new TabPage();
            tabSettings_Reports = new TabPage();
            tabSettings_Integrations = new TabPage();
            pnlUser = new Panel();
            btnLogout = new Button();
            lblUserName = new Label();
            tabMain.SuspendLayout();
            tabAddJob.SuspendLayout();
            tabAddJob_ControlTabs.SuspendLayout();
            tabAddJob_Job.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWebView).BeginInit();
            tabJobs.SuspendLayout();
            tabJobs_ControlTabs.SuspendLayout();
            tabMessages.SuspendLayout();
            tabMessages_ControlTabs.SuspendLayout();
            tabSearch.SuspendLayout();
            tabSearch_ControlTabs.SuspendLayout();
            tabReports.SuspendLayout();
            tabReports_ControlTabs.SuspendLayout();
            tabSettings.SuspendLayout();
            tabSettings_ControlTabs.SuspendLayout();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabAddJob);
            tabMain.Controls.Add(tabJobs);
            tabMain.Controls.Add(tabMessages);
            tabMain.Controls.Add(tabSearch);
            tabMain.Controls.Add(tabReports);
            tabMain.Controls.Add(tabSettings);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1095, 964);
            tabMain.TabIndex = 0;
            // 
            // tabAddJob
            // 
            tabAddJob.BackColor = Color.Transparent;
            tabAddJob.Controls.Add(tabAddJob_ControlTabs);
            tabAddJob.ForeColor = SystemColors.ActiveCaptionText;
            tabAddJob.Location = new Point(4, 24);
            tabAddJob.Name = "tabAddJob";
            tabAddJob.Padding = new Padding(3);
            tabAddJob.Size = new Size(1087, 936);
            tabAddJob.TabIndex = 0;
            tabAddJob.Text = "Add Job";
            // 
            // tabAddJob_ControlTabs
            // 
            tabAddJob_ControlTabs.Controls.Add(tabAddJob_Job);
            tabAddJob_ControlTabs.Controls.Add(tabAddJob_Log);
            tabAddJob_ControlTabs.Dock = DockStyle.Fill;
            tabAddJob_ControlTabs.Location = new Point(3, 3);
            tabAddJob_ControlTabs.Name = "tabAddJob_ControlTabs";
            tabAddJob_ControlTabs.SelectedIndex = 0;
            tabAddJob_ControlTabs.Size = new Size(1081, 930);
            tabAddJob_ControlTabs.TabIndex = 0;
            // 
            // tabAddJob_Job
            // 
            tabAddJob_Job.BackColor = Color.FromArgb(212, 208, 200);
            tabAddJob_Job.Controls.Add(pictureBox1);
            tabAddJob_Job.Controls.Add(txtCity);
            tabAddJob_Job.Controls.Add(groupBox3);
            tabAddJob_Job.Controls.Add(groupBox2);
            tabAddJob_Job.Controls.Add(radioButton8);
            tabAddJob_Job.Controls.Add(radioButton7);
            tabAddJob_Job.Controls.Add(radioButton6);
            tabAddJob_Job.Controls.Add(radioButton5);
            tabAddJob_Job.Controls.Add(radioButton4);
            tabAddJob_Job.Controls.Add(radioButton3);
            tabAddJob_Job.Controls.Add(radioButton2);
            tabAddJob_Job.Controls.Add(radioButton1);
            tabAddJob_Job.Controls.Add(btnSaveJob);
            tabAddJob_Job.Controls.Add(dateTimeJobCreated);
            tabAddJob_Job.Controls.Add(groupBox1);
            tabAddJob_Job.Controls.Add(comboJobDesc);
            tabAddJob_Job.Controls.Add(label16);
            tabAddJob_Job.Controls.Add(chckEmail);
            tabAddJob_Job.Controls.Add(chckSMS);
            tabAddJob_Job.Controls.Add(comboTech);
            tabAddJob_Job.Controls.Add(label15);
            tabAddJob_Job.Controls.Add(comboAdSource);
            tabAddJob_Job.Controls.Add(label14);
            tabAddJob_Job.Controls.Add(comboStatus);
            tabAddJob_Job.Controls.Add(label13);
            tabAddJob_Job.Controls.Add(label11);
            tabAddJob_Job.Controls.Add(textBox4);
            tabAddJob_Job.Controls.Add(comboState);
            tabAddJob_Job.Controls.Add(comboCountry);
            tabAddJob_Job.Controls.Add(cboTimezone);
            tabAddJob_Job.Controls.Add(btnMapIt);
            tabAddJob_Job.Controls.Add(label10);
            tabAddJob_Job.Controls.Add(label9);
            tabAddJob_Job.Controls.Add(label8);
            tabAddJob_Job.Controls.Add(label7);
            tabAddJob_Job.Controls.Add(label6);
            tabAddJob_Job.Controls.Add(textBox11);
            tabAddJob_Job.Controls.Add(textBox10);
            tabAddJob_Job.Controls.Add(txtZip);
            tabAddJob_Job.Controls.Add(txtAddress);
            tabAddJob_Job.Controls.Add(label5);
            tabAddJob_Job.Controls.Add(label1);
            tabAddJob_Job.Controls.Add(label4);
            tabAddJob_Job.Controls.Add(label3);
            tabAddJob_Job.Controls.Add(label2);
            tabAddJob_Job.Controls.Add(lblPhone2);
            tabAddJob_Job.Controls.Add(txtMetro);
            tabAddJob_Job.Controls.Add(txtEmail);
            tabAddJob_Job.Controls.Add(txtPhone2);
            tabAddJob_Job.Controls.Add(txtPhone);
            tabAddJob_Job.Controls.Add(lblAddJob_Job_Phone);
            tabAddJob_Job.Controls.Add(txtName);
            tabAddJob_Job.Controls.Add(lblAddJob_Job_Name);
            tabAddJob_Job.Controls.Add(txtCompany);
            tabAddJob_Job.Controls.Add(lblAddJob_Job_Company);
            tabAddJob_Job.Controls.Add(webViewMap);
            tabAddJob_Job.Controls.Add(picWebView);
            tabAddJob_Job.ForeColor = SystemColors.InfoText;
            tabAddJob_Job.Location = new Point(4, 24);
            tabAddJob_Job.Name = "tabAddJob_Job";
            tabAddJob_Job.Padding = new Padding(3);
            tabAddJob_Job.Size = new Size(1073, 902);
            tabAddJob_Job.TabIndex = 0;
            tabAddJob_Job.Text = "Job";
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Image = Properties.Resources._29853149_665d_4065_8474_c7665c93e8be;
            pictureBox1.Location = new Point(912, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(447, 111);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(179, 23);
            txtCity.TabIndex = 68;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClose);
            groupBox3.Controls.Add(btnRecPayment);
            groupBox3.Controls.Add(txtBalance);
            groupBox3.Controls.Add(txtTotalPaid);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(txtPartCost);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(txtAddCharge);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(comboPayMethod);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label22);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 686);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1037, 168);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pending Close Info";
            // 
            // btnClose
            // 
            btnClose.ForeColor = SystemColors.InfoText;
            btnClose.Location = new Point(827, 139);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(74, 23);
            btnClose.TabIndex = 78;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRecPayment
            // 
            btnRecPayment.ForeColor = SystemColors.InfoText;
            btnRecPayment.Location = new Point(907, 139);
            btnRecPayment.Name = "btnRecPayment";
            btnRecPayment.Size = new Size(124, 23);
            btnRecPayment.TabIndex = 67;
            btnRecPayment.Text = "Record Payment";
            btnRecPayment.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(567, 93);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(189, 23);
            txtBalance.TabIndex = 77;
            // 
            // txtTotalPaid
            // 
            txtTotalPaid.Location = new Point(567, 57);
            txtTotalPaid.Name = "txtTotalPaid";
            txtTotalPaid.Size = new Size(189, 23);
            txtTotalPaid.TabIndex = 76;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.InfoText;
            label27.Location = new Point(498, 96);
            label27.Name = "label27";
            label27.Size = new Size(53, 15);
            label27.TabIndex = 75;
            label27.Text = "Balance:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.InfoText;
            label26.Location = new Point(489, 60);
            label26.Name = "label26";
            label26.Size = new Size(63, 15);
            label26.TabIndex = 74;
            label26.Text = "Total Paid:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(135, 125);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(189, 23);
            txtTotal.TabIndex = 73;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.InfoText;
            label25.Location = new Point(80, 128);
            label25.Name = "label25";
            label25.Size = new Size(37, 15);
            label25.TabIndex = 72;
            label25.Text = "Total:";
            // 
            // txtPartCost
            // 
            txtPartCost.Location = new Point(135, 93);
            txtPartCost.Name = "txtPartCost";
            txtPartCost.Size = new Size(189, 23);
            txtPartCost.TabIndex = 71;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.InfoText;
            label24.Location = new Point(57, 96);
            label24.Name = "label24";
            label24.Size = new Size(60, 15);
            label24.TabIndex = 70;
            label24.Text = "Part Cost:";
            // 
            // txtAddCharge
            // 
            txtAddCharge.Location = new Point(135, 57);
            txtAddCharge.Name = "txtAddCharge";
            txtAddCharge.Size = new Size(189, 23);
            txtAddCharge.TabIndex = 69;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.InfoText;
            label23.Location = new Point(9, 60);
            label23.Name = "label23";
            label23.Size = new Size(108, 15);
            label23.TabIndex = 68;
            label23.Text = "Additional Charge:";
            // 
            // comboPayMethod
            // 
            comboPayMethod.FormattingEnabled = true;
            comboPayMethod.Items.AddRange(new object[] { "Cash", "Gcash", "Paypal", "Maya", "Card" });
            comboPayMethod.Location = new Point(567, 22);
            comboPayMethod.Name = "comboPayMethod";
            comboPayMethod.Size = new Size(151, 23);
            comboPayMethod.TabIndex = 67;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(135, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 23);
            textBox6.TabIndex = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.InfoText;
            label12.Location = new Point(441, 28);
            label12.Name = "label12";
            label12.Size = new Size(111, 15);
            label12.TabIndex = 54;
            label12.Text = "Payment Methods:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.InfoText;
            label22.Location = new Point(21, 25);
            label22.Name = "label22";
            label22.Size = new Size(96, 15);
            label22.TabIndex = 53;
            label22.Text = "Payment Billing:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtReasonCancel);
            groupBox2.Controls.Add(comboWho);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label21);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.MenuHighlight;
            groupBox2.Location = new Point(17, 621);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1037, 59);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cancelled";
            // 
            // txtReasonCancel
            // 
            txtReasonCancel.Location = new Point(371, 25);
            txtReasonCancel.Name = "txtReasonCancel";
            txtReasonCancel.Size = new Size(365, 23);
            txtReasonCancel.TabIndex = 67;
            // 
            // comboWho
            // 
            comboWho.Font = new Font("Segoe UI", 9F);
            comboWho.ForeColor = Color.FromArgb(150, 150, 150);
            comboWho.FormattingEnabled = true;
            comboWho.Items.AddRange(new object[] { "Client", "Office", "Technician" });
            comboWho.Location = new Point(65, 25);
            comboWho.Name = "comboWho";
            comboWho.Size = new Size(151, 23);
            comboWho.TabIndex = 66;
            comboWho.Text = "Who Canceled?";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.InfoText;
            label20.Location = new Point(325, 28);
            label20.Name = "label20";
            label20.Size = new Size(37, 15);
            label20.TabIndex = 54;
            label20.Text = "Why?";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.InfoText;
            label21.Location = new Point(21, 28);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 53;
            label21.Text = "Who?";
            // 
            // radioButton8
            // 
            radioButton8.Appearance = Appearance.Button;
            radioButton8.BackColor = Color.FromArgb(192, 255, 255);
            radioButton8.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            radioButton8.FlatStyle = FlatStyle.Flat;
            radioButton8.Location = new Point(986, 472);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(24, 24);
            radioButton8.TabIndex = 64;
            radioButton8.TabStop = true;
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.Appearance = Appearance.Button;
            radioButton7.BackColor = Color.FromArgb(255, 224, 192);
            radioButton7.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            radioButton7.FlatStyle = FlatStyle.Flat;
            radioButton7.Location = new Point(945, 472);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(24, 24);
            radioButton7.TabIndex = 63;
            radioButton7.TabStop = true;
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackColor = Color.FromArgb(255, 192, 255);
            radioButton6.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            radioButton6.FlatStyle = FlatStyle.Flat;
            radioButton6.Location = new Point(903, 472);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(24, 24);
            radioButton6.TabIndex = 62;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.FromArgb(255, 255, 192);
            radioButton5.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Location = new Point(858, 471);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(24, 24);
            radioButton5.TabIndex = 61;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.FromArgb(192, 192, 255);
            radioButton4.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Location = new Point(815, 471);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(24, 24);
            radioButton4.TabIndex = 60;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(192, 255, 192);
            radioButton3.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Location = new Point(772, 471);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(24, 24);
            radioButton3.TabIndex = 59;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(255, 192, 192);
            radioButton2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            radioButton2.FlatAppearance.CheckedBackColor = Color.Black;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Black;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.ForeColor = Color.FromArgb(255, 192, 192);
            radioButton2.Location = new Point(729, 471);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(24, 24);
            radioButton2.TabIndex = 58;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.White;
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Location = new Point(688, 471);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(24, 24);
            radioButton1.TabIndex = 57;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // btnSaveJob
            // 
            btnSaveJob.CausesValidation = false;
            btnSaveJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveJob.ForeColor = Color.FromArgb(0, 192, 0);
            btnSaveJob.Location = new Point(960, 860);
            btnSaveJob.Name = "btnSaveJob";
            btnSaveJob.Size = new Size(107, 36);
            btnSaveJob.TabIndex = 53;
            btnSaveJob.Text = "Save Job";
            btnSaveJob.UseVisualStyleBackColor = true;
            // 
            // dateTimeJobCreated
            // 
            dateTimeJobCreated.Format = DateTimePickerFormat.Short;
            dateTimeJobCreated.Location = new Point(92, 375);
            dateTimeJobCreated.Name = "dateTimeJobCreated";
            dateTimeJobCreated.Size = new Size(122, 23);
            dateTimeJobCreated.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboEndTIme);
            groupBox1.Controls.Add(comboStartTime);
            groupBox1.Controls.Add(btnClearAppt);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(dateTimeAppt);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(17, 556);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 59);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment";
            // 
            // comboEndTIme
            // 
            comboEndTIme.FormattingEnabled = true;
            comboEndTIme.Items.AddRange(new object[] { "7:00am", "7:30am", "8:00am", "8:30am", "9:00am", "9:30am", "10:00am", "10:30am", "11:00am", "11:30am", "12:00pm", "12:30pm", "1:00pm", "1:30pm", "2:00pm", "2:30pm", "3:00pm", "3:30pm", "4:00pm", "4:30pm", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm" });
            comboEndTIme.Location = new Point(585, 22);
            comboEndTIme.Name = "comboEndTIme";
            comboEndTIme.Size = new Size(151, 23);
            comboEndTIme.TabIndex = 66;
            // 
            // comboStartTime
            // 
            comboStartTime.FormattingEnabled = true;
            comboStartTime.Items.AddRange(new object[] { "7:00am", "7:30am", "8:00am", "8:30am", "9:00am", "9:30am", "10:00am", "10:30am", "11:00am", "11:30am", "12:00pm", "12:30pm", "1:00pm", "1:30pm", "2:00pm", "2:30pm", "3:00pm", "3:30pm", "4:00pm", "4:30pm", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm" });
            comboStartTime.Location = new Point(393, 23);
            comboStartTime.Name = "comboStartTime";
            comboStartTime.Size = new Size(151, 23);
            comboStartTime.TabIndex = 65;
            // 
            // btnClearAppt
            // 
            btnClearAppt.ForeColor = SystemColors.InfoText;
            btnClearAppt.Location = new Point(907, 22);
            btnClearAppt.Name = "btnClearAppt";
            btnClearAppt.Size = new Size(124, 23);
            btnClearAppt.TabIndex = 58;
            btnClearAppt.Text = "Clear Appointment\r\n";
            btnClearAppt.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.InfoText;
            label19.Location = new Point(552, 28);
            label19.Name = "label19";
            label19.Size = new Size(27, 15);
            label19.TabIndex = 56;
            label19.Text = "and";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.InfoText;
            label18.Location = new Point(325, 28);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 54;
            label18.Text = "Between:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.InfoText;
            label17.Location = new Point(21, 28);
            label17.Name = "label17";
            label17.Size = new Size(37, 15);
            label17.TabIndex = 53;
            label17.Text = "Date:";
            // 
            // dateTimeAppt
            // 
            dateTimeAppt.Location = new Point(64, 22);
            dateTimeAppt.Name = "dateTimeAppt";
            dateTimeAppt.Size = new Size(193, 23);
            dateTimeAppt.TabIndex = 0;
            // 
            // comboJobDesc
            // 
            comboJobDesc.ForeColor = Color.FromArgb(150, 150, 150);
            comboJobDesc.FormattingEnabled = true;
            comboJobDesc.Items.AddRange(new object[] { "Installation and Replacement", "Repairs", "Routine Maintenance", "Emergency and Commercial Services" });
            comboJobDesc.Location = new Point(419, 503);
            comboJobDesc.Name = "comboJobDesc";
            comboJobDesc.Size = new Size(207, 23);
            comboJobDesc.TabIndex = 51;
            comboJobDesc.Text = "Select Description";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(315, 506);
            label16.Name = "label16";
            label16.Size = new Size(96, 15);
            label16.TabIndex = 50;
            label16.Text = "Job Description:";
            // 
            // chckEmail
            // 
            chckEmail.AutoSize = true;
            chckEmail.Location = new Point(429, 456);
            chckEmail.Name = "chckEmail";
            chckEmail.Size = new Size(60, 19);
            chckEmail.TabIndex = 48;
            chckEmail.Text = "E-mail";
            chckEmail.UseVisualStyleBackColor = true;
            // 
            // chckSMS
            // 
            chckSMS.AutoSize = true;
            chckSMS.Location = new Point(429, 431);
            chckSMS.Name = "chckSMS";
            chckSMS.Size = new Size(49, 19);
            chckSMS.TabIndex = 46;
            chckSMS.Text = "SMS";
            chckSMS.UseVisualStyleBackColor = true;
            // 
            // comboTech
            // 
            comboTech.ForeColor = Color.FromArgb(150, 150, 150);
            comboTech.FormattingEnabled = true;
            comboTech.Location = new Point(419, 397);
            comboTech.Name = "comboTech";
            comboTech.Size = new Size(207, 23);
            comboTech.TabIndex = 45;
            comboTech.Text = "Select a Technician";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(315, 400);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 44;
            label15.Text = "Technician:";
            // 
            // comboAdSource
            // 
            comboAdSource.ForeColor = Color.FromArgb(150, 150, 150);
            comboAdSource.FormattingEnabled = true;
            comboAdSource.Items.AddRange(new object[] { "Google Ads", "Website Ticket", "Referral", "Other" });
            comboAdSource.Location = new Point(92, 502);
            comboAdSource.Name = "comboAdSource";
            comboAdSource.Size = new Size(196, 23);
            comboAdSource.TabIndex = 43;
            comboAdSource.Text = "Select an Ad Source";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 505);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 42;
            label14.Text = "Ad Source:";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Accepted", "In Progress", "Cancelled", "Pending close", "Closed" });
            comboStatus.Location = new Point(92, 437);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(151, 23);
            comboStatus.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(17, 441);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 40;
            label13.Text = "Status:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(16, 381);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 36;
            label11.Text = "Job Date:";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.FromArgb(150, 150, 150);
            textBox4.Location = new Point(12, 250);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(614, 105);
            textBox4.TabIndex = 35;
            textBox4.Text = "Enter job notes here.";
            // 
            // comboState
            // 
            comboState.ForeColor = Color.FromArgb(150, 150, 150);
            comboState.FormattingEnabled = true;
            comboState.Location = new Point(448, 53);
            comboState.Name = "comboState";
            comboState.Size = new Size(177, 23);
            comboState.TabIndex = 33;
            comboState.Text = "Select State";
            // 
            // comboCountry
            // 
            comboCountry.ForeColor = Color.FromArgb(150, 150, 150);
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(449, 23);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(177, 23);
            comboCountry.TabIndex = 32;
            comboCountry.Text = "Select Country";
            // 
            // cboTimezone
            // 
            cboTimezone.FormattingEnabled = true;
            cboTimezone.Location = new Point(83, 201);
            cboTimezone.Name = "cboTimezone";
            cboTimezone.Size = new Size(177, 23);
            cboTimezone.TabIndex = 31;
            // 
            // btnMapIt
            // 
            btnMapIt.Location = new Point(569, 140);
            btnMapIt.Name = "btnMapIt";
            btnMapIt.Size = new Size(57, 23);
            btnMapIt.TabIndex = 30;
            btnMapIt.Text = "Map it";
            btnMapIt.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(404, 201);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 29;
            label10.Text = "Item:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(358, 172);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 28;
            label9.Text = "Cross Streets:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(414, 143);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 27;
            label8.Text = "Zip:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(410, 114);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 26;
            label7.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(388, 85);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 25;
            label6.Text = "Address:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(447, 198);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(178, 23);
            textBox11.TabIndex = 24;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(448, 169);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(178, 23);
            textBox10.TabIndex = 23;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(447, 140);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(116, 23);
            txtZip.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(448, 82);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(178, 23);
            txtAddress.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(342, 56);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 19;
            label5.Text = "State / Province:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(388, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 15;
            label4.Text = "Timezone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "Metro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 143);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Email:";
            // 
            // lblPhone2
            // 
            lblPhone2.AutoSize = true;
            lblPhone2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone2.Location = new Point(22, 114);
            lblPhone2.Name = "lblPhone2";
            lblPhone2.Size = new Size(55, 15);
            lblPhone2.TabIndex = 11;
            lblPhone2.Text = "Phone 2:";
            // 
            // txtMetro
            // 
            txtMetro.Location = new Point(82, 169);
            txtMetro.Name = "txtMetro";
            txtMetro.Size = new Size(178, 23);
            txtMetro.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(83, 111);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(177, 23);
            txtPhone2.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(83, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(177, 23);
            txtPhone.TabIndex = 5;
            // 
            // lblAddJob_Job_Phone
            // 
            lblAddJob_Job_Phone.AutoSize = true;
            lblAddJob_Job_Phone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddJob_Job_Phone.ForeColor = Color.Red;
            lblAddJob_Job_Phone.Location = new Point(30, 85);
            lblAddJob_Job_Phone.Name = "lblAddJob_Job_Phone";
            lblAddJob_Job_Phone.Size = new Size(45, 15);
            lblAddJob_Job_Phone.TabIndex = 4;
            lblAddJob_Job_Phone.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 23);
            txtName.TabIndex = 3;
            // 
            // lblAddJob_Job_Name
            // 
            lblAddJob_Job_Name.AutoSize = true;
            lblAddJob_Job_Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddJob_Job_Name.Location = new Point(32, 53);
            lblAddJob_Job_Name.Name = "lblAddJob_Job_Name";
            lblAddJob_Job_Name.Size = new Size(43, 15);
            lblAddJob_Job_Name.TabIndex = 2;
            lblAddJob_Job_Name.Text = "Name:";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(83, 23);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(178, 23);
            txtCompany.TabIndex = 1;
            // 
            // lblAddJob_Job_Company
            // 
            lblAddJob_Job_Company.AutoSize = true;
            lblAddJob_Job_Company.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddJob_Job_Company.Location = new Point(16, 26);
            lblAddJob_Job_Company.Name = "lblAddJob_Job_Company";
            lblAddJob_Job_Company.Size = new Size(61, 15);
            lblAddJob_Job_Company.TabIndex = 0;
            lblAddJob_Job_Company.Text = "Company:";
            // 
            // webViewMap
            // 
            webViewMap.AllowExternalDrop = true;
            webViewMap.CreationProperties = null;
            webViewMap.DefaultBackgroundColor = Color.White;
            webViewMap.Location = new Point(661, 23);
            webViewMap.Name = "webViewMap";
            webViewMap.Size = new Size(369, 329);
            webViewMap.TabIndex = 69;
            webViewMap.ZoomFactor = 1D;
            // 
            // picWebView
            // 
            picWebView.AccessibleRole = AccessibleRole.None;
            picWebView.Location = new Point(661, 23);
            picWebView.Name = "picWebView";
            picWebView.Size = new Size(369, 329);
            picWebView.TabIndex = 67;
            picWebView.TabStop = false;
            // 
            // tabAddJob_Log
            // 
            tabAddJob_Log.Location = new Point(4, 24);
            tabAddJob_Log.Name = "tabAddJob_Log";
            tabAddJob_Log.Padding = new Padding(3);
            tabAddJob_Log.Size = new Size(1073, 902);
            tabAddJob_Log.TabIndex = 1;
            tabAddJob_Log.Text = "Log";
            tabAddJob_Log.UseVisualStyleBackColor = true;
            // 
            // tabJobs
            // 
            tabJobs.BackColor = Color.Transparent;
            tabJobs.Controls.Add(tabJobs_ControlTabs);
            tabJobs.Location = new Point(4, 24);
            tabJobs.Name = "tabJobs";
            tabJobs.Padding = new Padding(3);
            tabJobs.Size = new Size(1087, 936);
            tabJobs.TabIndex = 1;
            tabJobs.Text = "Jobs";
            // 
            // tabJobs_ControlTabs
            // 
            tabJobs_ControlTabs.Controls.Add(tabJobs_JobList);
            tabJobs_ControlTabs.Controls.Add(tabJobs_Calendar);
            tabJobs_ControlTabs.Dock = DockStyle.Fill;
            tabJobs_ControlTabs.Location = new Point(3, 3);
            tabJobs_ControlTabs.Name = "tabJobs_ControlTabs";
            tabJobs_ControlTabs.SelectedIndex = 0;
            tabJobs_ControlTabs.Size = new Size(1081, 930);
            tabJobs_ControlTabs.TabIndex = 0;
            // 
            // tabJobs_JobList
            // 
            tabJobs_JobList.BackColor = Color.Transparent;
            tabJobs_JobList.Location = new Point(4, 24);
            tabJobs_JobList.Name = "tabJobs_JobList";
            tabJobs_JobList.Padding = new Padding(3);
            tabJobs_JobList.Size = new Size(1073, 902);
            tabJobs_JobList.TabIndex = 0;
            tabJobs_JobList.Text = "Jobs List";
            // 
            // tabJobs_Calendar
            // 
            tabJobs_Calendar.Location = new Point(4, 24);
            tabJobs_Calendar.Name = "tabJobs_Calendar";
            tabJobs_Calendar.Padding = new Padding(3);
            tabJobs_Calendar.Size = new Size(1073, 902);
            tabJobs_Calendar.TabIndex = 1;
            tabJobs_Calendar.Text = "Calendar";
            tabJobs_Calendar.UseVisualStyleBackColor = true;
            // 
            // tabMessages
            // 
            tabMessages.Controls.Add(tabMessages_ControlTabs);
            tabMessages.Location = new Point(4, 24);
            tabMessages.Name = "tabMessages";
            tabMessages.Padding = new Padding(3);
            tabMessages.Size = new Size(1087, 936);
            tabMessages.TabIndex = 2;
            tabMessages.Text = "Messages";
            tabMessages.UseVisualStyleBackColor = true;
            // 
            // tabMessages_ControlTabs
            // 
            tabMessages_ControlTabs.Controls.Add(tabMessages_Messages);
            tabMessages_ControlTabs.Dock = DockStyle.Fill;
            tabMessages_ControlTabs.Location = new Point(3, 3);
            tabMessages_ControlTabs.Name = "tabMessages_ControlTabs";
            tabMessages_ControlTabs.SelectedIndex = 0;
            tabMessages_ControlTabs.Size = new Size(1081, 930);
            tabMessages_ControlTabs.TabIndex = 0;
            // 
            // tabMessages_Messages
            // 
            tabMessages_Messages.Location = new Point(4, 24);
            tabMessages_Messages.Name = "tabMessages_Messages";
            tabMessages_Messages.Padding = new Padding(3);
            tabMessages_Messages.Size = new Size(1073, 902);
            tabMessages_Messages.TabIndex = 0;
            tabMessages_Messages.Text = "Messages";
            tabMessages_Messages.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            tabSearch.Controls.Add(tabSearch_ControlTabs);
            tabSearch.Location = new Point(4, 24);
            tabSearch.Name = "tabSearch";
            tabSearch.Padding = new Padding(3);
            tabSearch.Size = new Size(1087, 936);
            tabSearch.TabIndex = 3;
            tabSearch.Text = "Search";
            tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabSearch_ControlTabs
            // 
            tabSearch_ControlTabs.Controls.Add(tabSearch_Search);
            tabSearch_ControlTabs.Dock = DockStyle.Fill;
            tabSearch_ControlTabs.Location = new Point(3, 3);
            tabSearch_ControlTabs.Name = "tabSearch_ControlTabs";
            tabSearch_ControlTabs.SelectedIndex = 0;
            tabSearch_ControlTabs.Size = new Size(1081, 930);
            tabSearch_ControlTabs.TabIndex = 0;
            // 
            // tabSearch_Search
            // 
            tabSearch_Search.BackColor = Color.Transparent;
            tabSearch_Search.Location = new Point(4, 24);
            tabSearch_Search.Name = "tabSearch_Search";
            tabSearch_Search.Padding = new Padding(3);
            tabSearch_Search.Size = new Size(1073, 902);
            tabSearch_Search.TabIndex = 0;
            tabSearch_Search.Text = "Search";
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabReports_ControlTabs);
            tabReports.Location = new Point(4, 24);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(3);
            tabReports.Size = new Size(1087, 936);
            tabReports.TabIndex = 4;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // tabReports_ControlTabs
            // 
            tabReports_ControlTabs.Controls.Add(tabReoprts_Payments);
            tabReports_ControlTabs.Controls.Add(tabReports_Technicians);
            tabReports_ControlTabs.Dock = DockStyle.Fill;
            tabReports_ControlTabs.Location = new Point(3, 3);
            tabReports_ControlTabs.Name = "tabReports_ControlTabs";
            tabReports_ControlTabs.SelectedIndex = 0;
            tabReports_ControlTabs.Size = new Size(1081, 930);
            tabReports_ControlTabs.TabIndex = 0;
            // 
            // tabReoprts_Payments
            // 
            tabReoprts_Payments.Location = new Point(4, 24);
            tabReoprts_Payments.Name = "tabReoprts_Payments";
            tabReoprts_Payments.Padding = new Padding(3);
            tabReoprts_Payments.Size = new Size(1073, 902);
            tabReoprts_Payments.TabIndex = 0;
            tabReoprts_Payments.Text = "Payments";
            tabReoprts_Payments.UseVisualStyleBackColor = true;
            // 
            // tabReports_Technicians
            // 
            tabReports_Technicians.Location = new Point(4, 24);
            tabReports_Technicians.Name = "tabReports_Technicians";
            tabReports_Technicians.Padding = new Padding(3);
            tabReports_Technicians.Size = new Size(1073, 902);
            tabReports_Technicians.TabIndex = 2;
            tabReports_Technicians.Text = "Technicians";
            tabReports_Technicians.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabSettings_ControlTabs);
            tabSettings.Location = new Point(4, 24);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3);
            tabSettings.Size = new Size(1087, 936);
            tabSettings.TabIndex = 5;
            tabSettings.Text = "Settings";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabSettings_ControlTabs
            // 
            tabSettings_ControlTabs.Controls.Add(tabSettings_Companies);
            tabSettings_ControlTabs.Controls.Add(tabSettings_Technicians);
            tabSettings_ControlTabs.Controls.Add(tabSettings_Jobs);
            tabSettings_ControlTabs.Controls.Add(tabSettings_User);
            tabSettings_ControlTabs.Controls.Add(tabSettings_System);
            tabSettings_ControlTabs.Controls.Add(tabSettings_Reports);
            tabSettings_ControlTabs.Controls.Add(tabSettings_Integrations);
            tabSettings_ControlTabs.Dock = DockStyle.Fill;
            tabSettings_ControlTabs.Location = new Point(3, 3);
            tabSettings_ControlTabs.Name = "tabSettings_ControlTabs";
            tabSettings_ControlTabs.SelectedIndex = 0;
            tabSettings_ControlTabs.Size = new Size(1081, 930);
            tabSettings_ControlTabs.TabIndex = 0;
            // 
            // tabSettings_Companies
            // 
            tabSettings_Companies.Location = new Point(4, 24);
            tabSettings_Companies.Name = "tabSettings_Companies";
            tabSettings_Companies.Padding = new Padding(3);
            tabSettings_Companies.Size = new Size(1073, 902);
            tabSettings_Companies.TabIndex = 0;
            tabSettings_Companies.Text = "Companies";
            tabSettings_Companies.UseVisualStyleBackColor = true;
            // 
            // tabSettings_Technicians
            // 
            tabSettings_Technicians.Location = new Point(4, 24);
            tabSettings_Technicians.Name = "tabSettings_Technicians";
            tabSettings_Technicians.Padding = new Padding(3);
            tabSettings_Technicians.Size = new Size(1073, 902);
            tabSettings_Technicians.TabIndex = 1;
            tabSettings_Technicians.Text = "Technicians";
            tabSettings_Technicians.UseVisualStyleBackColor = true;
            // 
            // tabSettings_Jobs
            // 
            tabSettings_Jobs.Location = new Point(4, 24);
            tabSettings_Jobs.Name = "tabSettings_Jobs";
            tabSettings_Jobs.Padding = new Padding(3);
            tabSettings_Jobs.Size = new Size(1073, 902);
            tabSettings_Jobs.TabIndex = 2;
            tabSettings_Jobs.Text = "Jobs";
            tabSettings_Jobs.UseVisualStyleBackColor = true;
            // 
            // tabSettings_User
            // 
            tabSettings_User.Location = new Point(4, 24);
            tabSettings_User.Name = "tabSettings_User";
            tabSettings_User.Padding = new Padding(3);
            tabSettings_User.Size = new Size(1073, 902);
            tabSettings_User.TabIndex = 3;
            tabSettings_User.Text = "Users";
            tabSettings_User.UseVisualStyleBackColor = true;
            // 
            // tabSettings_System
            // 
            tabSettings_System.Location = new Point(4, 24);
            tabSettings_System.Name = "tabSettings_System";
            tabSettings_System.Padding = new Padding(3);
            tabSettings_System.Size = new Size(1073, 902);
            tabSettings_System.TabIndex = 4;
            tabSettings_System.Text = "System";
            tabSettings_System.UseVisualStyleBackColor = true;
            // 
            // tabSettings_Reports
            // 
            tabSettings_Reports.Location = new Point(4, 24);
            tabSettings_Reports.Name = "tabSettings_Reports";
            tabSettings_Reports.Padding = new Padding(3);
            tabSettings_Reports.Size = new Size(1073, 902);
            tabSettings_Reports.TabIndex = 5;
            tabSettings_Reports.Text = "Reports";
            tabSettings_Reports.UseVisualStyleBackColor = true;
            // 
            // tabSettings_Integrations
            // 
            tabSettings_Integrations.Location = new Point(4, 24);
            tabSettings_Integrations.Name = "tabSettings_Integrations";
            tabSettings_Integrations.Padding = new Padding(3);
            tabSettings_Integrations.Size = new Size(1073, 902);
            tabSettings_Integrations.TabIndex = 6;
            tabSettings_Integrations.Text = "Integrations";
            tabSettings_Integrations.UseVisualStyleBackColor = true;
            // 
            // pnlUser
            // 
            pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUser.Controls.Add(btnLogout);
            pnlUser.Controls.Add(lblUserName);
            pnlUser.Location = new Point(896, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(199, 54);
            pnlUser.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.HighlightText;
            btnLogout.Location = new Point(0, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(199, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(75, 3);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(39, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1095, 964);
            Controls.Add(pnlUser);
            Controls.Add(tabMain);
            Name = "Form1";
            Text = "Garage Door Services";
            Load += Form1_Load;
            tabMain.ResumeLayout(false);
            tabAddJob.ResumeLayout(false);
            tabAddJob_ControlTabs.ResumeLayout(false);
            tabAddJob_Job.ResumeLayout(false);
            tabAddJob_Job.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webViewMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWebView).EndInit();
            tabJobs.ResumeLayout(false);
            tabJobs_ControlTabs.ResumeLayout(false);
            tabMessages.ResumeLayout(false);
            tabMessages_ControlTabs.ResumeLayout(false);
            tabSearch.ResumeLayout(false);
            tabSearch_ControlTabs.ResumeLayout(false);
            tabReports.ResumeLayout(false);
            tabReports_ControlTabs.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            tabSettings_ControlTabs.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabAddJob;
        private TabPage tabJobs;
        private TabPage tabMessages;
        private TabPage tabSearch;
        private TabPage tabReports;
        private TabPage tabSettings;
        private TabControl tabAddJob_ControlTabs;
        private TabPage tabAddJob_Job;
        private TabPage tabAddJob_Log;
        private TabControl tabJobs_ControlTabs;
        private TabPage tabJobs_JobList;
        private TabPage tabJobs_Calendar;
        private TabControl tabMessages_ControlTabs;
        private TabPage tabMessages_Messages;
        private TabControl tabSearch_ControlTabs;
        private TabPage tabSearch_Search;
        private TabControl tabReports_ControlTabs;
        private TabPage tabReoprts_Payments;
        private TabPage tabReports_Technicians;
        private TabControl tabSettings_ControlTabs;
        private TabPage tabSettings_Companies;
        private TabPage tabSettings_Technicians;
        private TabPage tabSettings_Jobs;
        private TabPage tabSettings_User;
        private TabPage tabSettings_System;
        private TabPage tabSettings_Reports;
        private TabPage tabSettings_Integrations;
        private TextBox txtName;
        private Label lblAddJob_Job_Name;
        private TextBox txtCompany;
        private Label lblAddJob_Job_Company;
        private TextBox txtPhone;
        private Label lblAddJob_Job_Phone;
        private Panel pnlUser;
        private Label lblUserName;
        private Button btnLogout;
        private Label lblPhone2;
        private TextBox txtMetro;
        private TextBox txtEmail;
        private TextBox txtPhone2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private Button btnMapIt;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox txtZip;
        private TextBox txtAddress;
        private Label label5;
        private ComboBox cboTimezone;
        private TextBox textBox4;
        private ComboBox comboState;
        private ComboBox comboCountry;
        private Label label11;
        private ComboBox comboAdSource;
        private Label label14;
        private ComboBox comboStatus;
        private Label label13;
        private ComboBox comboJobDesc;
        private Label label16;
        private CheckBox chckEmail;
        private CheckBox chckSMS;
        private ComboBox comboTech;
        private Label label15;
        private DateTimePicker dateTimeJobCreated;
        private GroupBox groupBox1;
        private DateTimePicker dateTimeAppt;
        private Label label17;
        private Button btnClearAppt;
        private Label label19;
        private Label label18;
        private Button button3;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton8;
        private ComboBox comboStartTime;
        private ComboBox comboEndTIme;
        private GroupBox groupBox2;
        private TextBox txtReasonCancel;
        private ComboBox comboWho;
        private Label label20;
        private Label label21;
        private GroupBox groupBox3;
        private Button btnClose;
        private ComboBox comboBox4;
        private TextBox textBox6;
        private Label label12;
        private Label label22;
        private TextBox txtAddCharge;
        private Label label23;
        private ComboBox comboPayMethod;
        private Label label27;
        private Label label26;
        private TextBox txtTotal;
        private Label label25;
        private TextBox txtPartCost;
        private Label label24;
        private Button button5;
        private Button btnRecPayment;
        private TextBox txtBalance;
        private TextBox txtTotalPaid;
        private Button btnSaveJob;
        private PictureBox picWebView;
        private TextBox txtCity;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
    }
}

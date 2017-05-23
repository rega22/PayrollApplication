namespace PayrollApplication
{
    partial class Payroll_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll_form));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployeeDetails = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxHoursWorked = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxOvertime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxOvertimeRate = new System.Windows.Forms.TextBox();
            this.txtboxSalesReceipts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxOtherEarnings1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDeductions = new System.Windows.Forms.Panel();
            this.cmbPRSI_Class = new System.Windows.Forms.ComboBox();
            this.cmbOtherDeductions3 = new System.Windows.Forms.ComboBox();
            this.txtboxOtherDeductions3 = new System.Windows.Forms.TextBox();
            this.cmbOtherDeductions2 = new System.Windows.Forms.ComboBox();
            this.txtboxOtherDeductions2 = new System.Windows.Forms.TextBox();
            this.cmbOtherDeductions1 = new System.Windows.Forms.ComboBox();
            this.txtboxOtherDeductions1 = new System.Windows.Forms.TextBox();
            this.cmbCalculationBasis = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtboxTotalDeductions = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtboxPRSI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtboxUSC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtboxPAYE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtboxEmployeeID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtboxPPSNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtboxRateHours = new System.Windows.Forms.TextBox();
            this.pnlHourlyEmployees = new System.Windows.Forms.Panel();
            this.txtboxGrossPayHourly = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbPayType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlSalariedEmployees = new System.Windows.Forms.Panel();
            this.lblCommissionPercentage = new System.Windows.Forms.Label();
            this.txtBoxCommissionPercentage = new System.Windows.Forms.TextBox();
            this.txtboxGrossPaySalaried_Commission = new System.Windows.Forms.TextBox();
            this.rbCommissions = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtboxBasicPaySalary = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtboxCommissions = new System.Windows.Forms.TextBox();
            this.cmbOtherEarnings1 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbOtherEarnings2 = new System.Windows.Forms.ComboBox();
            this.txtboxOtherEarnings2 = new System.Windows.Forms.TextBox();
            this.cmbOtherEarnings3 = new System.Windows.Forms.ComboBox();
            this.txtboxOtherEarnings3 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxTotalGrossPay = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtboxNetPay = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlOtherEarnings = new System.Windows.Forms.Panel();
            this.pnlDeductions.SuspendLayout();
            this.pnlHourlyEmployees.SuspendLayout();
            this.pnlSalariedEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlOtherEarnings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // cmbEmployeeDetails
            // 
            this.cmbEmployeeDetails.FormattingEnabled = true;
            this.cmbEmployeeDetails.Location = new System.Drawing.Point(127, 59);
            this.cmbEmployeeDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmployeeDetails.Name = "cmbEmployeeDetails";
            this.cmbEmployeeDetails.Size = new System.Drawing.Size(289, 24);
            this.cmbEmployeeDetails.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pay From:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 144);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(399, 144);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours Worked";
            // 
            // txtboxHoursWorked
            // 
            this.txtboxHoursWorked.Location = new System.Drawing.Point(164, 65);
            this.txtboxHoursWorked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxHoursWorked.Name = "txtboxHoursWorked";
            this.txtboxHoursWorked.Size = new System.Drawing.Size(132, 22);
            this.txtboxHoursWorked.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate:";
            // 
            // txtboxOvertime
            // 
            this.txtboxOvertime.Location = new System.Drawing.Point(164, 111);
            this.txtboxOvertime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOvertime.Name = "txtboxOvertime";
            this.txtboxOvertime.Size = new System.Drawing.Size(132, 22);
            this.txtboxOvertime.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Overtime";
            // 
            // txtboxOvertimeRate
            // 
            this.txtboxOvertimeRate.Location = new System.Drawing.Point(365, 111);
            this.txtboxOvertimeRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOvertimeRate.Name = "txtboxOvertimeRate";
            this.txtboxOvertimeRate.Size = new System.Drawing.Size(64, 22);
            this.txtboxOvertimeRate.TabIndex = 3;
            this.txtboxOvertimeRate.Click += new System.EventHandler(this.Overtime_Rate_Click);
            // 
            // txtboxSalesReceipts
            // 
            this.txtboxSalesReceipts.Location = new System.Drawing.Point(523, 59);
            this.txtboxSalesReceipts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSalesReceipts.Name = "txtboxSalesReceipts";
            this.txtboxSalesReceipts.Size = new System.Drawing.Size(132, 22);
            this.txtboxSalesReceipts.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hourly Employees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Sales Receipts";
            // 
            // txtboxOtherEarnings1
            // 
            this.txtboxOtherEarnings1.Location = new System.Drawing.Point(365, 44);
            this.txtboxOtherEarnings1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherEarnings1.Name = "txtboxOtherEarnings1";
            this.txtboxOtherEarnings1.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherEarnings1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Other Earnings";
            // 
            // pnlDeductions
            // 
            this.pnlDeductions.Controls.Add(this.cmbPRSI_Class);
            this.pnlDeductions.Controls.Add(this.cmbOtherDeductions3);
            this.pnlDeductions.Controls.Add(this.txtboxOtherDeductions3);
            this.pnlDeductions.Controls.Add(this.cmbOtherDeductions2);
            this.pnlDeductions.Controls.Add(this.txtboxOtherDeductions2);
            this.pnlDeductions.Controls.Add(this.cmbOtherDeductions1);
            this.pnlDeductions.Controls.Add(this.txtboxOtherDeductions1);
            this.pnlDeductions.Controls.Add(this.cmbCalculationBasis);
            this.pnlDeductions.Controls.Add(this.label29);
            this.pnlDeductions.Controls.Add(this.label27);
            this.pnlDeductions.Controls.Add(this.label23);
            this.pnlDeductions.Controls.Add(this.txtboxTotalDeductions);
            this.pnlDeductions.Controls.Add(this.label15);
            this.pnlDeductions.Controls.Add(this.txtboxPRSI);
            this.pnlDeductions.Controls.Add(this.label14);
            this.pnlDeductions.Controls.Add(this.txtboxUSC);
            this.pnlDeductions.Controls.Add(this.label13);
            this.pnlDeductions.Controls.Add(this.txtboxPAYE);
            this.pnlDeductions.Controls.Add(this.label11);
            this.pnlDeductions.Controls.Add(this.label12);
            this.pnlDeductions.Location = new System.Drawing.Point(725, 15);
            this.pnlDeductions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeductions.Name = "pnlDeductions";
            this.pnlDeductions.Size = new System.Drawing.Size(689, 534);
            this.pnlDeductions.TabIndex = 15;
            // 
            // cmbPRSI_Class
            // 
            this.cmbPRSI_Class.FormattingEnabled = true;
            this.cmbPRSI_Class.Location = new System.Drawing.Point(131, 219);
            this.cmbPRSI_Class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPRSI_Class.Name = "cmbPRSI_Class";
            this.cmbPRSI_Class.Size = new System.Drawing.Size(525, 24);
            this.cmbPRSI_Class.TabIndex = 3;
            // 
            // cmbOtherDeductions3
            // 
            this.cmbOtherDeductions3.FormattingEnabled = true;
            this.cmbOtherDeductions3.Location = new System.Drawing.Point(72, 421);
            this.cmbOtherDeductions3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherDeductions3.Name = "cmbOtherDeductions3";
            this.cmbOtherDeductions3.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherDeductions3.TabIndex = 9;
            // 
            // txtboxOtherDeductions3
            // 
            this.txtboxOtherDeductions3.Location = new System.Drawing.Point(263, 422);
            this.txtboxOtherDeductions3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherDeductions3.Name = "txtboxOtherDeductions3";
            this.txtboxOtherDeductions3.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherDeductions3.TabIndex = 10;
            // 
            // cmbOtherDeductions2
            // 
            this.cmbOtherDeductions2.FormattingEnabled = true;
            this.cmbOtherDeductions2.Location = new System.Drawing.Point(72, 390);
            this.cmbOtherDeductions2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherDeductions2.Name = "cmbOtherDeductions2";
            this.cmbOtherDeductions2.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherDeductions2.TabIndex = 7;
            // 
            // txtboxOtherDeductions2
            // 
            this.txtboxOtherDeductions2.Location = new System.Drawing.Point(263, 391);
            this.txtboxOtherDeductions2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherDeductions2.Name = "txtboxOtherDeductions2";
            this.txtboxOtherDeductions2.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherDeductions2.TabIndex = 8;
            // 
            // cmbOtherDeductions1
            // 
            this.cmbOtherDeductions1.FormattingEnabled = true;
            this.cmbOtherDeductions1.Location = new System.Drawing.Point(72, 357);
            this.cmbOtherDeductions1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherDeductions1.Name = "cmbOtherDeductions1";
            this.cmbOtherDeductions1.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherDeductions1.TabIndex = 5;
            // 
            // txtboxOtherDeductions1
            // 
            this.txtboxOtherDeductions1.Location = new System.Drawing.Point(264, 358);
            this.txtboxOtherDeductions1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherDeductions1.Name = "txtboxOtherDeductions1";
            this.txtboxOtherDeductions1.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherDeductions1.TabIndex = 6;
            // 
            // cmbCalculationBasis
            // 
            this.cmbCalculationBasis.FormattingEnabled = true;
            this.cmbCalculationBasis.Location = new System.Drawing.Point(455, 71);
            this.cmbCalculationBasis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCalculationBasis.Name = "cmbCalculationBasis";
            this.cmbCalculationBasis.Size = new System.Drawing.Size(196, 24);
            this.cmbCalculationBasis.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(43, 332);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(172, 22);
            this.label29.TabIndex = 41;
            this.label29.Text = "Other Deductions:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(231, 81);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 17);
            this.label27.TabIndex = 31;
            this.label27.Text = "Calculation Basis";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(43, 229);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 17);
            this.label23.TabIndex = 29;
            this.label23.Text = "PRSI Class";
            // 
            // txtboxTotalDeductions
            // 
            this.txtboxTotalDeductions.Location = new System.Drawing.Point(263, 482);
            this.txtboxTotalDeductions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxTotalDeductions.Name = "txtboxTotalDeductions";
            this.txtboxTotalDeductions.Size = new System.Drawing.Size(132, 22);
            this.txtboxTotalDeductions.TabIndex = 28;
            this.txtboxTotalDeductions.Click += new System.EventHandler(this.All_Taxes_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(43, 486);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "Total Deductions:";
            // 
            // txtboxPRSI
            // 
            this.txtboxPRSI.Location = new System.Drawing.Point(524, 271);
            this.txtboxPRSI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPRSI.Name = "txtboxPRSI";
            this.txtboxPRSI.Size = new System.Drawing.Size(132, 22);
            this.txtboxPRSI.TabIndex = 4;
            this.txtboxPRSI.Click += new System.EventHandler(this.All_Taxes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 279);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "PRSI";
            // 
            // txtboxUSC
            // 
            this.txtboxUSC.Location = new System.Drawing.Point(520, 167);
            this.txtboxUSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxUSC.Name = "txtboxUSC";
            this.txtboxUSC.Size = new System.Drawing.Size(132, 22);
            this.txtboxUSC.TabIndex = 2;
            this.txtboxUSC.Click += new System.EventHandler(this.All_Taxes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 176);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "USC";
            // 
            // txtboxPAYE
            // 
            this.txtboxPAYE.Location = new System.Drawing.Point(520, 113);
            this.txtboxPAYE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPAYE.Name = "txtboxPAYE";
            this.txtboxPAYE.Size = new System.Drawing.Size(132, 22);
            this.txtboxPAYE.TabIndex = 1;
            this.txtboxPAYE.Click += new System.EventHandler(this.All_Taxes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Deductions:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "PAYE";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(659, 779);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 52);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtboxEmployeeID
            // 
            this.txtboxEmployeeID.Enabled = false;
            this.txtboxEmployeeID.Location = new System.Drawing.Point(127, 96);
            this.txtboxEmployeeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxEmployeeID.Name = "txtboxEmployeeID";
            this.txtboxEmployeeID.Size = new System.Drawing.Size(132, 22);
            this.txtboxEmployeeID.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Employee ID";
            // 
            // txtboxPPSNumber
            // 
            this.txtboxPPSNumber.Enabled = false;
            this.txtboxPPSNumber.Location = new System.Drawing.Point(392, 96);
            this.txtboxPPSNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPPSNumber.Name = "txtboxPPSNumber";
            this.txtboxPPSNumber.Size = new System.Drawing.Size(199, 22);
            this.txtboxPPSNumber.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(301, 100);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "PPS Number";
            // 
            // txtboxRateHours
            // 
            this.txtboxRateHours.Location = new System.Drawing.Point(364, 69);
            this.txtboxRateHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxRateHours.Name = "txtboxRateHours";
            this.txtboxRateHours.Size = new System.Drawing.Size(64, 22);
            this.txtboxRateHours.TabIndex = 1;
            // 
            // pnlHourlyEmployees
            // 
            this.pnlHourlyEmployees.Controls.Add(this.txtboxGrossPayHourly);
            this.pnlHourlyEmployees.Controls.Add(this.label4);
            this.pnlHourlyEmployees.Controls.Add(this.label22);
            this.pnlHourlyEmployees.Controls.Add(this.txtboxRateHours);
            this.pnlHourlyEmployees.Controls.Add(this.txtboxHoursWorked);
            this.pnlHourlyEmployees.Controls.Add(this.label5);
            this.pnlHourlyEmployees.Controls.Add(this.label6);
            this.pnlHourlyEmployees.Controls.Add(this.txtboxOvertime);
            this.pnlHourlyEmployees.Controls.Add(this.txtboxOvertimeRate);
            this.pnlHourlyEmployees.Controls.Add(this.label8);
            this.pnlHourlyEmployees.Location = new System.Drawing.Point(40, 247);
            this.pnlHourlyEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHourlyEmployees.Name = "pnlHourlyEmployees";
            this.pnlHourlyEmployees.Size = new System.Drawing.Size(595, 194);
            this.pnlHourlyEmployees.TabIndex = 7;
            this.pnlHourlyEmployees.Visible = false;
            // 
            // txtboxGrossPayHourly
            // 
            this.txtboxGrossPayHourly.Location = new System.Drawing.Point(297, 158);
            this.txtboxGrossPayHourly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxGrossPayHourly.Name = "txtboxGrossPayHourly";
            this.txtboxGrossPayHourly.Size = new System.Drawing.Size(161, 22);
            this.txtboxGrossPayHourly.TabIndex = 4;
            this.txtboxGrossPayHourly.Click += new System.EventHandler(this.GrossPay_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(47, 158);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 22);
            this.label22.TabIndex = 29;
            this.label22.Text = "Gross Pay:";
            // 
            // cmbPayType
            // 
            this.cmbPayType.Enabled = false;
            this.cmbPayType.FormattingEnabled = true;
            this.cmbPayType.Location = new System.Drawing.Point(127, 203);
            this.cmbPayType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPayType.Name = "cmbPayType";
            this.cmbPayType.Size = new System.Drawing.Size(289, 24);
            this.cmbPayType.TabIndex = 6;
            this.cmbPayType.SelectedIndexChanged += new System.EventHandler(this.CmbPayType_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 203);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Pay Type";
            // 
            // pnlSalariedEmployees
            // 
            this.pnlSalariedEmployees.Controls.Add(this.lblCommissionPercentage);
            this.pnlSalariedEmployees.Controls.Add(this.txtBoxCommissionPercentage);
            this.pnlSalariedEmployees.Controls.Add(this.txtboxGrossPaySalaried_Commission);
            this.pnlSalariedEmployees.Controls.Add(this.rbCommissions);
            this.pnlSalariedEmployees.Controls.Add(this.label24);
            this.pnlSalariedEmployees.Controls.Add(this.label7);
            this.pnlSalariedEmployees.Controls.Add(this.label20);
            this.pnlSalariedEmployees.Controls.Add(this.label19);
            this.pnlSalariedEmployees.Controls.Add(this.txtboxBasicPaySalary);
            this.pnlSalariedEmployees.Controls.Add(this.label21);
            this.pnlSalariedEmployees.Controls.Add(this.txtboxCommissions);
            this.pnlSalariedEmployees.Controls.Add(this.txtboxSalesReceipts);
            this.pnlSalariedEmployees.Controls.Add(this.label9);
            this.pnlSalariedEmployees.Location = new System.Drawing.Point(40, 469);
            this.pnlSalariedEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSalariedEmployees.Name = "pnlSalariedEmployees";
            this.pnlSalariedEmployees.Size = new System.Drawing.Size(677, 217);
            this.pnlSalariedEmployees.TabIndex = 8;
            this.pnlSalariedEmployees.Visible = false;
            // 
            // lblCommissionPercentage
            // 
            this.lblCommissionPercentage.AutoSize = true;
            this.lblCommissionPercentage.Location = new System.Drawing.Point(335, 111);
            this.lblCommissionPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommissionPercentage.Name = "lblCommissionPercentage";
            this.lblCommissionPercentage.Size = new System.Drawing.Size(167, 17);
            this.lblCommissionPercentage.TabIndex = 34;
            this.lblCommissionPercentage.Text = "Commissions Percentage";
            // 
            // txtBoxCommissionPercentage
            // 
            this.txtBoxCommissionPercentage.Location = new System.Drawing.Point(523, 102);
            this.txtBoxCommissionPercentage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCommissionPercentage.Name = "txtBoxCommissionPercentage";
            this.txtBoxCommissionPercentage.Size = new System.Drawing.Size(44, 22);
            this.txtBoxCommissionPercentage.TabIndex = 2;
            // 
            // txtboxGrossPaySalaried_Commission
            // 
            this.txtboxGrossPaySalaried_Commission.Location = new System.Drawing.Point(136, 180);
            this.txtboxGrossPaySalaried_Commission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxGrossPaySalaried_Commission.Name = "txtboxGrossPaySalaried_Commission";
            this.txtboxGrossPaySalaried_Commission.Size = new System.Drawing.Size(160, 22);
            this.txtboxGrossPaySalaried_Commission.TabIndex = 32;
            this.txtboxGrossPaySalaried_Commission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtboxGrossPaySalaried_Commission.Click += new System.EventHandler(this.GrossPay_Click);
            // 
            // rbCommissions
            // 
            this.rbCommissions.AutoSize = true;
            this.rbCommissions.Location = new System.Drawing.Point(564, 10);
            this.rbCommissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCommissions.Name = "rbCommissions";
            this.rbCommissions.Size = new System.Drawing.Size(17, 16);
            this.rbCommissions.TabIndex = 33;
            this.rbCommissions.TabStop = true;
            this.rbCommissions.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 180);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 22);
            this.label24.TabIndex = 31;
            this.label24.Text = "Gross Pay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Commission on Sales";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 6);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "Salaried Employees";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Basic Pay";
            // 
            // txtboxBasicPaySalary
            // 
            this.txtboxBasicPaySalary.Location = new System.Drawing.Point(131, 64);
            this.txtboxBasicPaySalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxBasicPaySalary.Name = "txtboxBasicPaySalary";
            this.txtboxBasicPaySalary.Size = new System.Drawing.Size(132, 22);
            this.txtboxBasicPaySalary.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(404, 151);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "Commissions";
            // 
            // txtboxCommissions
            // 
            this.txtboxCommissions.Location = new System.Drawing.Point(523, 143);
            this.txtboxCommissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxCommissions.Name = "txtboxCommissions";
            this.txtboxCommissions.Size = new System.Drawing.Size(132, 22);
            this.txtboxCommissions.TabIndex = 10;
            // 
            // cmbOtherEarnings1
            // 
            this.cmbOtherEarnings1.FormattingEnabled = true;
            this.cmbOtherEarnings1.Location = new System.Drawing.Point(61, 44);
            this.cmbOtherEarnings1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherEarnings1.Name = "cmbOtherEarnings1";
            this.cmbOtherEarnings1.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherEarnings1.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(361, 18);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 22);
            this.label25.TabIndex = 32;
            this.label25.Text = "Amount";
            // 
            // cmbOtherEarnings2
            // 
            this.cmbOtherEarnings2.FormattingEnabled = true;
            this.cmbOtherEarnings2.Location = new System.Drawing.Point(61, 72);
            this.cmbOtherEarnings2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherEarnings2.Name = "cmbOtherEarnings2";
            this.cmbOtherEarnings2.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherEarnings2.TabIndex = 11;
            // 
            // txtboxOtherEarnings2
            // 
            this.txtboxOtherEarnings2.Location = new System.Drawing.Point(365, 72);
            this.txtboxOtherEarnings2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherEarnings2.Name = "txtboxOtherEarnings2";
            this.txtboxOtherEarnings2.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherEarnings2.TabIndex = 12;
            // 
            // cmbOtherEarnings3
            // 
            this.cmbOtherEarnings3.FormattingEnabled = true;
            this.cmbOtherEarnings3.Location = new System.Drawing.Point(61, 103);
            this.cmbOtherEarnings3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtherEarnings3.Name = "cmbOtherEarnings3";
            this.cmbOtherEarnings3.Size = new System.Drawing.Size(160, 24);
            this.cmbOtherEarnings3.TabIndex = 13;
            // 
            // txtboxOtherEarnings3
            // 
            this.txtboxOtherEarnings3.Location = new System.Drawing.Point(365, 103);
            this.txtboxOtherEarnings3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxOtherEarnings3.Name = "txtboxOtherEarnings3";
            this.txtboxOtherEarnings3.Size = new System.Drawing.Size(132, 22);
            this.txtboxOtherEarnings3.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(992, 779);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 52);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(827, 779);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 52);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtboxTotalGrossPay
            // 
            this.txtboxTotalGrossPay.Location = new System.Drawing.Point(342, 148);
            this.txtboxTotalGrossPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxTotalGrossPay.Name = "txtboxTotalGrossPay";
            this.txtboxTotalGrossPay.Size = new System.Drawing.Size(160, 22);
            this.txtboxTotalGrossPay.TabIndex = 35;
            this.txtboxTotalGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtboxTotalGrossPay.Click += new System.EventHandler(this.TxtboxTotalGrossPay_Click);
            this.txtboxTotalGrossPay.TextChanged += new System.EventHandler(this.CmbPayType_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(186, 152);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(99, 22);
            this.label30.TabIndex = 34;
            this.label30.Text = "Gross Pay:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(811, 661);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(110, 25);
            this.label31.TabIndex = 43;
            this.label31.Text = "Payment:";
            // 
            // txtboxNetPay
            // 
            this.txtboxNetPay.Location = new System.Drawing.Point(1009, 661);
            this.txtboxNetPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxNetPay.Name = "txtboxNetPay";
            this.txtboxNetPay.Size = new System.Drawing.Size(151, 22);
            this.txtboxNetPay.TabIndex = 43;
            this.txtboxNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtboxNetPay.Click += new System.EventHandler(this.TxtboxNetPay_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlOtherEarnings
            // 
            this.pnlOtherEarnings.Controls.Add(this.cmbOtherEarnings1);
            this.pnlOtherEarnings.Controls.Add(this.label10);
            this.pnlOtherEarnings.Controls.Add(this.txtboxOtherEarnings1);
            this.pnlOtherEarnings.Controls.Add(this.txtboxTotalGrossPay);
            this.pnlOtherEarnings.Controls.Add(this.txtboxOtherEarnings2);
            this.pnlOtherEarnings.Controls.Add(this.label25);
            this.pnlOtherEarnings.Controls.Add(this.cmbOtherEarnings2);
            this.pnlOtherEarnings.Controls.Add(this.label30);
            this.pnlOtherEarnings.Controls.Add(this.txtboxOtherEarnings3);
            this.pnlOtherEarnings.Controls.Add(this.cmbOtherEarnings3);
            this.pnlOtherEarnings.Location = new System.Drawing.Point(40, 694);
            this.pnlOtherEarnings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOtherEarnings.Name = "pnlOtherEarnings";
            this.pnlOtherEarnings.Size = new System.Drawing.Size(677, 217);
            this.pnlOtherEarnings.TabIndex = 44;
            this.pnlOtherEarnings.Visible = false;
            // 
            // Payroll_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 871);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlOtherEarnings);
            this.Controls.Add(this.txtboxNetPay);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSalariedEmployees);
            this.Controls.Add(this.cmbPayType);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pnlHourlyEmployees);
            this.Controls.Add(this.txtboxPPSNumber);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtboxEmployeeID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pnlDeductions);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmployeeDetails);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payroll_form";
            this.Text = "Let\'s do Payroll! - by Appland";
            this.Load += new System.EventHandler(this.Payroll_form_Load);
            this.pnlDeductions.ResumeLayout(false);
            this.pnlDeductions.PerformLayout();
            this.pnlHourlyEmployees.ResumeLayout(false);
            this.pnlHourlyEmployees.PerformLayout();
            this.pnlSalariedEmployees.ResumeLayout(false);
            this.pnlSalariedEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlOtherEarnings.ResumeLayout(false);
            this.pnlOtherEarnings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployeeDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxHoursWorked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxOvertime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxOvertimeRate;
        private System.Windows.Forms.TextBox txtboxSalesReceipts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxOtherEarnings1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDeductions;
        private System.Windows.Forms.ComboBox cmbCalculationBasis;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtboxTotalDeductions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtboxPRSI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtboxUSC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtboxPAYE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtboxEmployeeID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtboxPPSNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtboxRateHours;
        private System.Windows.Forms.Panel pnlHourlyEmployees;
        private System.Windows.Forms.TextBox txtboxGrossPayHourly;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbPayType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlSalariedEmployees;
        private System.Windows.Forms.TextBox txtboxGrossPaySalaried_Commission;
        private System.Windows.Forms.RadioButton rbCommissions;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtboxBasicPaySalary;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtboxCommissions;
        private System.Windows.Forms.ComboBox cmbOtherEarnings1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbOtherEarnings2;
        private System.Windows.Forms.TextBox txtboxOtherEarnings2;
        private System.Windows.Forms.ComboBox cmbOtherEarnings3;
        private System.Windows.Forms.TextBox txtboxOtherEarnings3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbOtherDeductions1;
        private System.Windows.Forms.TextBox txtboxOtherDeductions1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtboxTotalGrossPay;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtboxNetPay;
        private System.Windows.Forms.ComboBox cmbOtherDeductions3;
        private System.Windows.Forms.TextBox txtboxOtherDeductions3;
        private System.Windows.Forms.ComboBox cmbOtherDeductions2;
        private System.Windows.Forms.TextBox txtboxOtherDeductions2;
        private System.Windows.Forms.ComboBox cmbPRSI_Class;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCommissionPercentage;
        private System.Windows.Forms.TextBox txtBoxCommissionPercentage;
        private System.Windows.Forms.Panel pnlOtherEarnings;
    }
}


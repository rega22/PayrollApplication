using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Globalization;

namespace PayrollApplication
{
    public partial class Payroll_form : Form
    {
        //pre-coded values for functionality testing purposes
        //a connection to a SQL database with loading parameters and binding properties would be required:

        //SqlConnection conn = new SqlConnection("SQL connection string");
        //SqlCommand cmd;

        private string[] Employee_Name = { "Paolo Regazzi", "Nicola Hazels", "Bernadette Show-Gun" };
        private string[] Employee_ID = { "237", "358", "402" };
        private string[] PPS_Numbers = { "1085976L", "250157Q", "3586027A" };
        private string[] Pay_Type = { "Hourly", "Salary", "Commissions" };
        private string CalculationBasis = "Cumulative";
        private string[] OtherDeductions = { "Pension Scheme", "Savings Scheme", "Union Dues", "Medical Insurance", };
        private string[] OtherEarnings = { "Annual Leave", "Parenting Leave", "Sick Leave", "Annual Bonus" };
        private string PayTypeSelected = "";
        private string[] PRSI_Classes = { "Employee aged 16 to 65 (Class JO/AO/AX/AL/A1", "Employer's PRSI Exemption Scheme or Employer Job (PRSI) Incentive Scheme participant (Class A6/A7/A4)", "Community Employment participant (Class A8/A9)", "Employee aged 16 to 65, in subsidiary employment (Class JO/J1", "Employee aged 66 or over (Class JO/J1)", "Employee receiving FAS Allowance (Class J9)", "Employee aged 15 or under (Class M)", "Employee in receipt of occupational pension (Class M)", "Office holder (Class M/K1)", "Public Sector employee (Class B, C, D, H)", "Self-Employed qualifying Director (Class S)", "Self-Employed Qualifying Director aged 66 or over (Class M)" };


        bool ValidEntryHours = false;
        bool ValidEntryOvertime = false;
        bool ValidEntryHourlyRate = false;
        bool ValidEntrySalary = false;
        bool ValidEntrySalesReceipts = false;
        bool ValidCommissionPercentage = false;
        bool DatesCheckedFrom = false;
        bool DatesCheckedTo = false;
        bool EmployeeSelected = false;
        bool cmbPaySelected = false;

        bool OtherEarnings1Valid = false;
        bool OtherEarnings2Valid = false;
        bool OtherEarnings3Valid = false;
        bool OtherDeductions1Valid = false;
        bool OtherDeductions2Valid = false;
        bool OtherDeductions3Valid = false;

        double HoursWorked = 0.00d;
        double Overtime = 0.00d;
        double HourlyRate = 0.00d;
        double OvertimeRate = 0.00d;
        double SalaryAmount = 0.00d;
        double SalesReceiptsAmount = 0.00d;
        double CommissionPercentage = 0.00d;
        double Commissions = 0.00d;
        double OtherEarnings1 = 0.00d;
        double OtherEarnings2 = 0.00d;
        double OtherEarnings3 = 0.00d;
        double OtherDeduction1 = 0.00d;
        double OtherDeduction2 = 0.00d;
        double OtherDeduction3 = 0.00d;
        double TotalGrossPay = 0.00;



        public Payroll_form()
        {
            InitializeComponent();
        }
        private void Payroll_form_Load(object sender, EventArgs e)
        {
            //SQLConnection();

            cmbEmployeeDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCalculationBasis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPRSI_Class.DropDownStyle = ComboBoxStyle.DropDownList;
            txtboxOvertimeRate.Enabled = false;
            txtboxGrossPayHourly.Enabled = false;
            txtboxNetPay.Enabled = false;
            txtboxTotalDeductions.Enabled = false;
            txtboxTotalGrossPay.Enabled = false;
            txtboxPAYE.Enabled = false;
            txtboxUSC.Enabled = false;
            txtboxPRSI.Enabled = false;
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            txtboxOtherDeductions1.Clear();
            txtboxOtherDeductions2.Clear();
            txtboxOtherDeductions3.Clear();
            txtboxOtherEarnings1.Clear();
            txtboxOtherEarnings2.Clear();
            txtboxOtherEarnings3.Clear();
            cmbOtherEarnings1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtherEarnings2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtherEarnings3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtherDeductions1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtherDeductions2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtherDeductions3.DropDownStyle = ComboBoxStyle.DropDownList;




            for (int i = 0; i < Employee_Name.Length; i++)

            {
                cmbEmployeeDetails.Items.Add(Employee_Name[i]);
                //cmbEmployeeDetails.DrawMode = DrawMode.OwnerDrawFixed;
                //cmbEmployeeDetails.DrawItem += new DrawItemEventHandler(CmbEmployeeDetails_DrawItem);

            }

            for (int i = 0; i < Pay_Type.Length; i++)
            {
                cmbPayType.Items.Add(Pay_Type[i]);
            }

            for (int i = 0; i < PRSI_Classes.Length; i++)
            {
                cmbPRSI_Class.Items.Add(PRSI_Classes[i]);
            }

            if (cmbEmployeeDetails.SelectionStart != -1)
            {
                cmbEmployeeDetails.SelectedIndexChanged += CmbEmployeeDetails_SelectedIndexChanged;
                pnlDeductions.Visible = false;


            }

            cmbCalculationBasis.Items.Add(CalculationBasis);

            for (int i = 0; i < OtherEarnings.Length; i++)

            {
                cmbOtherEarnings1.Items.Add(OtherEarnings[i]);
                cmbOtherEarnings2.Items.Add(OtherEarnings[i]);
                cmbOtherEarnings3.Items.Add(OtherEarnings[i]);
            }

            for (int i = 0; i < OtherDeductions.Length; i++)

            {
                cmbOtherDeductions1.Items.Add(OtherDeductions[i]);
                cmbOtherDeductions2.Items.Add(OtherDeductions[i]);
                cmbOtherDeductions3.Items.Add(OtherDeductions[i]);
            }

            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += DateTimePicker2_ValueChanged;

        }





        private void CmbEmployeeDetails_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cmbEmployeeDetails.Font;
            Brush brush = Brushes.Black;

            font = new Font(font, FontStyle.Italic);

            brush = Brushes.Green;

            e.Graphics.DrawString(cmbEmployeeDetails.SelectedItem.ToString(), font, brush, e.Bounds);
        }

        //public void SQLConnection()
        //{

        //    conn.Open();
        //    cmd = new SqlCommand("SELECT [First Name] + ' ' + [Last Name] as EmployeeName FROM EmployeesTable order by [First Name]", conn);
        //    //ComboBoxEmployeeFill();
        //}

        //public void ComboBoxEmployeeFill()
        //{
        //    try
        //    {

        //        if (cmbEmployeeDetails.Enabled == true)
        //        {
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);
        //            cmbEmployeeDetails.DataSource = dt;
        //            cmbEmployeeDetails.DisplayMember = "EmployeeName";
        //            cmbEmployeeDetails.SelectedIndex = -1;
        //        }
        //        SqlDataReader DR = cmd.ExecuteReader();
        //        while (DR.Read())
        //        {
        //            cmbEmployeeDetails.Items.Add(DR[0]);
        //        }
        //        DR.Close();
        //    }
        //    catch (Exception ex)
        // 
        //}
        private void CmbEmployeeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEmployee();
        }

        private void LoadEmployees()
        {
            try
            {
                SelectEmployee();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + ":  \n" + ex.Message + "\n\nSome possible reasons for this message are: \n\n* -You need to select an Employee from the list!!!" + "\n\n* -Error connecting to SQL Database!!\n\n* -Please check all data entered....", "Exception");
            }
        }

        private void CmbPayTypeSelected()
        {
            if (cmbPayType.SelectedIndex > -1)
            {


                if (cmbPayType.SelectedIndex == 0) /*Hourly Pay*/
                {
                    HourlyPayCalculations();

                }

                if (cmbPayType.SelectedIndex == 1) /*Salary Pay*/
                {
                    SalaryPayCalculations();

                }


                if (cmbPayType.SelectedIndex == 2) /*Salary Pay and Commissions*/

                {
                    SalaryAndCommissionsCalculations();

                }
            }

            //else
            //{
            //    if ((cmbPayType.Enabled == true) || (cmbPayType.SelectedIndex == -1 && (DatesCheckedFrom == true || DatesCheckedTo == true) && EmployeeSelected == true))
            //    {
            //        cmbPayType.Enabled = true;
            //        MessageBox.Show("Now, select a Pay Type", "Friendly Advice");
            //    }
            //}
        }

        private void CheckDatesSelected()
        {
            if (DatesCheckedFrom == true || DatesCheckedTo == true)
            {


                //conn = new SqlConnection("SQL connection string");
                //conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT EmployeeID, PPSNumber FROM EmployeesTable where [First Name] + ' ' + [Last Name] = " + cmbEmployeeDetails.SelectedValue + " ", conn);
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    txtboxEmployeeID.Text = Convert.ToString(dr["EmployeeID"]);
                //    txtboxPPSNumber.Text = Convert.ToString(dr["PPSNumber"]);
                //}
                //else
                //{
                //    MessageBox.Show("Data NotFound");
                //}


                cmbPayType.Enabled = true;
                label30.Visible = true;
                txtboxTotalGrossPay.Visible = true;

            }
        }

        private void SelectEmployee()
        {
            if (cmbEmployeeDetails.SelectedIndex == -1) /*Nothing Selected*/
            {

                MessageBox.Show("Please select an Employee from the dropdown list", "Notice");
            }

            else
            {
                EmployeeSelected = true;
                int cmbEmployeeIndexSelected = cmbEmployeeDetails.SelectedIndex;
                txtboxEmployeeID.Text = (string)Employee_ID.GetValue(cmbEmployeeIndexSelected);
                txtboxPPSNumber.Text = (string)PPS_Numbers.GetValue(cmbEmployeeIndexSelected);
                txtboxEmployeeID.Enabled = false;
                txtboxPPSNumber.Enabled = false;

                if (DatesCheckedFrom == false && DatesCheckedTo == false)
                {
                    DatesBeenChecked_SelectPay();
                }
            }


        }

        private void CmbOtherEarnings3_Click(object sender, EventArgs e)
        {
            cmbOtherEarnings3.Enabled = false; ;
        }

        private void CmbOtherEarnings2_Click(object sender, EventArgs e)
        {
            cmbOtherEarnings2.Enabled = false;
        }

        private void CmbOtherEarnings1_Click(object sender, EventArgs e)
        {
            cmbOtherEarnings1.Enabled = false;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DatesCheckedFrom = true;
            cmbPayType.Enabled = true;
            DatesBeenChecked_SelectPay();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DatesCheckedTo = true;
            cmbPayType.Enabled = true;
            DatesBeenChecked_SelectPay();
        }

        private void DatesBeenChecked_SelectPay()
        {
            if (DatesCheckedFrom == false || DatesCheckedTo == false)
            {
                DialogResult dr = MessageBox.Show("Please check the Pay FROM and/or TO dates!! \nAre the dates OK?", "Notice", MessageBoxButtons.OK);
            }
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            
            if (cmbPaySelected == false && EmployeeSelected == true)
            {
                MessageBox.Show("Now select a Pay Type", "Friendly Advice");
            }

            else
            {
                if (cmbPayType.SelectedIndex == 0) /*Hourly Rate*/
                {
                    HourlyPayCalculations();
                }
                if (cmbPayType.SelectedIndex == 1) /*Salary Only*/
                {
                    SalaryPayCalculations();
                }
                if (cmbPayType.SelectedIndex == 2) /*Salary and Commissions*/
                {
                    SalaryAndCommissionsCalculations();

                }
            }

            if (cmbOtherEarnings1.SelectionStart != -1)
            {
                cmbOtherEarnings1.SelectedIndexChanged += CmbOtherEarnings1_SelectedIndexChanged;
            }

            if (cmbOtherEarnings2.SelectionStart != -1)
            {
                cmbOtherEarnings2.SelectedIndexChanged += CmbOtherEarnings2_SelectedIndexChanged;
            }

            if (cmbOtherEarnings3.SelectionStart != -1)
            {
                cmbOtherEarnings3.SelectedIndexChanged += CmbOtherEarnings3_SelectedIndexChanged;
            }



            if (cmbOtherDeductions1.SelectionStart != -1)
            {
                cmbOtherDeductions1.SelectedIndexChanged += CmbOtherDeductions1_SelectedIndexChanged;
            }


            if (cmbOtherDeductions2.SelectionStart != -1)
            {
                cmbOtherDeductions2.SelectedIndexChanged += CmbOtherDeductions2_SelectedIndexChanged;
            }

            if (cmbOtherDeductions3.SelectionStart != -1)
            {
                cmbOtherDeductions3.SelectedIndexChanged += CmbOtherDeductions3_SelectedIndexChanged;
            }




        }

        private void CmbOtherEarnings1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherEarnings1.Enabled = true;
            txtboxOtherEarnings1.Leave += TxtboxOtherEarnings1_TextChanged;


        }

        private void CmbOtherEarnings2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherEarnings2.Enabled = true;
            txtboxOtherEarnings2.Leave += TxtboxOtherEarnings2_TextChanged;

        }

        private void CmbOtherEarnings3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherEarnings3.Enabled = true;
            txtboxOtherEarnings3.Leave += TxtboxOtherEarnings3_TextChanged;

        }







        private void CmbOtherDeductions1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherDeductions1.Enabled = true;
            txtboxOtherDeductions1.Leave += TxtboxOtherDeductions1_TextChanged;



        }

        private void CmbOtherDeductions2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherDeductions2.Enabled = true;
            txtboxOtherDeductions2.TextChanged += TxtboxOtherDeductions2_TextChanged;

        }

        private void CmbOtherDeductions3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxOtherDeductions3.Enabled = true;
            txtboxOtherDeductions3.TextChanged += TxtboxOtherDeductions1_TextChanged;

        }

        private void TxtboxOtherDeductions1_TextChanged(object sender, EventArgs e)
        {
            OtherDeductions1Valid = double.TryParse(txtboxOtherDeductions1.Text, out OtherDeduction1);


            if (OtherDeductions1Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Deductions!!", "Attention");
            }

        }

        private void TxtboxOtherDeductions2_TextChanged(object sender, EventArgs e)
        {
            OtherDeductions2Valid = double.TryParse(txtboxOtherDeductions2.Text, out OtherDeduction2);

            if (OtherDeductions2Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Deductions!!", "Attention");
            }
        }

        private void TxtboxOtherDeductions3_TextChanged(object sender, EventArgs e)
        {
            OtherDeductions3Valid = double.TryParse(txtboxOtherDeductions3.Text, out OtherDeduction3);

            if (OtherDeductions3Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Deductions!!", "Attention");
            }
        }



        private void TxtboxOtherEarnings1_TextChanged(object sender, EventArgs e)
        {

            OtherEarnings1Valid = double.TryParse(txtboxOtherEarnings1.Text, out OtherEarnings1);

            if (OtherEarnings1Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Earnings!!", "Attention");
            }

            TotalGrossPay = TotalGrossPay + OtherEarnings1;
            txtboxTotalGrossPay.Text = TotalGrossPay.ToString();


        }
        private void TxtboxOtherEarnings2_TextChanged(object sender, EventArgs e)
        {

            OtherEarnings2Valid = double.TryParse(txtboxOtherEarnings2.Text, out OtherEarnings2);

            if (OtherEarnings2Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Earnings!!", "Attention");
            }

            TotalGrossPay = TotalGrossPay + OtherEarnings2;
            txtboxTotalGrossPay.Text = TotalGrossPay.ToString();

        }

        private void TxtboxOtherEarnings3_TextChanged(object sender, EventArgs e)
        {

            OtherEarnings3Valid = double.TryParse(txtboxOtherEarnings3.Text, out OtherEarnings3);

            if (OtherEarnings3Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Earnings!!", "Attention");
            }

            TotalGrossPay = TotalGrossPay + OtherEarnings3;
            txtboxTotalGrossPay.Text = TotalGrossPay.ToString();
        }



        private void SalaryAndCommissionsCalculations()
        {
            ValidEntrySalary = double.TryParse(txtboxBasicPaySalary.Text, out SalaryAmount);
            ValidEntrySalesReceipts = double.TryParse(txtboxSalesReceipts.Text, out SalesReceiptsAmount);
            ValidCommissionPercentage = double.TryParse(txtBoxCommissionPercentage.Text, out CommissionPercentage);

            if (string.IsNullOrEmpty(txtboxBasicPaySalary.Text) && string.IsNullOrEmpty(txtboxSalesReceipts.Text) && string.IsNullOrEmpty(txtBoxCommissionPercentage.Text)
                           || (ValidEntrySalary == false || ValidEntrySalesReceipts == false || ValidCommissionPercentage == false))
            {

                MessageBox.Show("Please enter Basic Pay Amount \nand Total Sales Receipts \nand/or Commission Percentage", "Attention");
                txtboxTotalGrossPay.Text = "ERROR";
            }

            else
            {



                if (ValidEntrySalary == false)
                {
                    txtboxBasicPaySalary.ForeColor = ValidEntrySalary ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid Basic Pay amount", "Reminder");
                    txtboxBasicPaySalary.Tag = "Please enter the Weekly/Bi-Weekly/Monthly Rate of Pay";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }

                if (ValidEntrySalesReceipts == false)
                {
                    txtboxSalesReceipts.ForeColor = ValidEntrySalesReceipts ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid Sales Receipts amount", "Reminder");
                    txtboxBasicPaySalary.Tag = "Please enter the amount of Sales Receipts on which calculate Commissions";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }

                if (ValidCommissionPercentage == false)
                {
                    txtBoxCommissionPercentage.ForeColor = ValidCommissionPercentage ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid Commissions Percentage", "Reminder");
                    txtboxBasicPaySalary.Tag = "Please enter the Percentage of Commissions";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }

                else
                {

                    txtboxCommissions.Text = (SalesReceiptsAmount * (CommissionPercentage / 100)).ToString();
                    Commissions = double.Parse(txtboxCommissions.Text);
                    txtboxGrossPaySalaried_Commission.Text = (SalaryAmount + Commissions).ToString();
                    TotalGrossPay = double.Parse(txtboxGrossPaySalaried_Commission.Text);
                    txtboxTotalGrossPay.Text = TotalGrossPay.ToString();
                    pnlDeductions.Visible = true;
                    pnlOtherEarnings.Visible = true;

                }
            }
        }





        private void SalaryPayCalculations()
        {
            ValidEntrySalary = double.TryParse(txtboxBasicPaySalary.Text, out SalaryAmount);

            if (string.IsNullOrEmpty(txtboxBasicPaySalary.Text) || ValidEntrySalary == false)
            {
                MessageBox.Show("Please enter Basic Pay Amount \nand/or check if employee is on commissions", "Attention");
                txtboxTotalGrossPay.Text = "ERROR";
            }
            else
            {



                if (ValidEntrySalary == false)
                {
                    txtboxBasicPaySalary.ForeColor = ValidEntrySalary ? Color.Black : Color.Red;

                    MessageBox.Show("Please enter a valid Basic Pay amount", "Reminder");
                    txtboxBasicPaySalary.Tag = "Please enter the Weekly/Bi-Weekly/Monthly Rate of Pay";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }
                else
                {
                    txtboxTotalGrossPay.Text = txtboxGrossPaySalaried_Commission.Text;
                    pnlDeductions.Visible = true;
                    pnlOtherEarnings.Visible = true;
                }
            }
        }

        private void HourlyPayCalculations()
        {

            ValidEntryHours = double.TryParse(txtboxHoursWorked.Text, out HoursWorked);
            ValidEntryHourlyRate = double.TryParse(txtboxRateHours.Text, out HourlyRate);
            ValidEntryOvertime = double.TryParse(txtboxOvertime.Text, out Overtime);

            if (string.IsNullOrEmpty(txtboxHoursWorked.Text) && string.IsNullOrEmpty(txtboxOvertime.Text) && string.IsNullOrEmpty(txtboxRateHours.Text) ||
                            (ValidEntryHours == false || ValidEntryHourlyRate == false || ValidEntryOvertime == false))
            {
                MessageBox.Show("Please enter Number of Hours, Pay Rate and/or Overtime", "Attention");
                pnlOtherEarnings.Visible = true;
                txtboxTotalGrossPay.Text = "ERROR";

            }

            else
            {

                OvertimeRate = HourlyRate * 1.5;
                txtboxOvertimeRate.Text = OvertimeRate.ToString();
                txtboxOvertimeRate.Enabled = false;
                txtboxGrossPayHourly.Enabled = false;
                txtboxTotalGrossPay.Visible = true;

                double GrossPayHourly;
                GrossPayHourly = ((HoursWorked * HourlyRate) + (Overtime * OvertimeRate));
                txtboxGrossPayHourly.Text = GrossPayHourly.ToString("C2", new CultureInfo("en-IE"));
                txtboxTotalGrossPay.Text = txtboxGrossPayHourly + txtboxBasicPaySalary.Text;

                if (ValidEntryHours == false)
                {

                    txtboxHoursWorked.ForeColor = ValidEntryHours ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid number of hours worked \nExample: 10.25 for 10 hours and 15 minutes", "Hours Worked not Valid");
                    txtboxHoursWorked.Tag = "Please enter a number of Hours Worked";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }
                if (ValidEntryHourlyRate == false)
                {
                    txtboxRateHours.ForeColor = ValidEntryHourlyRate ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid rate of hourly pay \nExample: 11.15 for €11.15 an hour", "Rate Not Valid");

                    txtboxRateHours.Tag = "Please enter a rate of pay per hour";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }

                if (ValidEntryOvertime == false)
                {
                    txtboxOvertime.ForeColor = ValidEntryOvertime ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid number of overtime hours worked \nExample: 2.50 for 2 hours and half \nIf no overtime worked, enter \"0\"", "Overtime Not Valid");

                    txtboxOvertime.Tag = "Please enter a number of overtime hours worked";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                }
                else
                {
                    txtboxTotalGrossPay.Visible = true;
                    txtboxTotalGrossPay.Text = txtboxGrossPayHourly.Text;
                    pnlDeductions.Visible = true;

                }
            }

        }


        private void CalculatePAYE()
        {

        }





        private void CmbPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PayTypeSelected = (string)cmbPayType.SelectedItem;
            switch (PayTypeSelected)
            {
                case "Hourly":
                    pnlHourlyEmployees.Visible = true;
                    pnlSalariedEmployees.Visible = false;
                    cmbPaySelected = true;
                    pnlOtherEarnings.Visible = true;

                    break;

                case "Salary":
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Enabled = false;
                    rbCommissions.Checked = false;
                    txtboxSalesReceipts.Enabled = false;
                    txtBoxCommissionPercentage.Enabled = false;
                    txtboxCommissions.Enabled = false;
                    cmbPaySelected = true;
                    pnlOtherEarnings.Visible = true;

                    break;

                case "Commissions":
                    txtboxBasicPaySalary.Visible = true;
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Checked = true;
                    txtboxSalesReceipts.Enabled = true;
                    txtBoxCommissionPercentage.Enabled = true;
                    txtboxCommissions.Enabled = false;
                    cmbPaySelected = true;
                    pnlOtherEarnings.Visible = true;

                    break;


            }
        }

        private void TxtboxNetPay_Click(object sender, EventArgs e)
        {
            txtboxNetPay.Enabled = false;
        }

        private void TxtboxTotalGrossPay_Click(object sender, EventArgs e)
        {
            txtboxTotalGrossPay.Enabled = false;
        }

        private void GrossPay_Click(object sender, EventArgs e)
        {
            txtboxTotalGrossPay.Enabled = false;
        }

        private void Overtime_Rate_Click(object sender, EventArgs e)
        {
            txtboxOvertimeRate.Enabled = false;
        }

        private void Total_Deductions_Click(object sender, EventArgs e)
        {
            txtboxTotalDeductions.Enabled = false;
        }

        private void All_Taxes_Click(object sender, EventArgs e)
        {
            txtboxPAYE.Enabled = false;
            txtboxPRSI.Enabled = false;
            txtboxUSC.Enabled = false;
            txtboxTotalDeductions.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBoxHoursWorkedClicked(object sender, EventArgs e)
        {
            txtboxHoursWorked.Text = "";

        }

        private void TxtBoxHourlyRateClicked(object sender, EventArgs e)
        {
            txtboxRateHours.Text = "";
        }

        private void TxtBoxOvertimeClicked(object sender, EventArgs e)
        {
            txtboxOvertime.Text = "";
        }
    }
}

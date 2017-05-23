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

        double HoursWorked = 0;
        double Overtime = 0;
        double HourlyRate = 0;
        double OvertimeRate = 0;
        double SalaryAmount = 0;
        double SalesReceiptsAmount = 0;
        double CommissionPercentage = 0;
        double Commissions = 0;
        double OtherEarnings1 = 0.00;
        double OtherEarnings2 = 0.00;
        double OtherEarnings3 = 0.00;
        double OtherDeduction1 = 0.00;
        double OtherDeduction2 = 0.00;
        double OtherDeduction3 = 0.00;

        

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
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                SelectEmployee();

                


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

                    int cmbEmployeeIndexSelected = cmbEmployeeDetails.SelectedIndex;
                    txtboxEmployeeID.Text = (string)Employee_ID.GetValue(cmbEmployeeIndexSelected);
                    txtboxPPSNumber.Text = (string)PPS_Numbers.GetValue(cmbEmployeeIndexSelected);
                    txtboxEmployeeID.Enabled = false;
                    txtboxPPSNumber.Enabled = false;
                    cmbPayType.Enabled = true;
                    
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + ":  \n" + ex.Message + "\n\nSome possible reasons for this message are: \n\n* -You need to select an Employee from the list!!!" + "\n\n* -Incorrect Values entered in Other Earnings!! \n\n* -Error connecting to SQL Database!!\n\n* -Please check all data entered....", "Exception");
            }
        }

        private void SelectEmployee()
        {
            if (cmbEmployeeDetails.SelectedIndex == -1) /*Nothing Selected*/
            {

                cmbOtherEarnings1.Click += CmbOtherEarnings1_Click;
                cmbOtherEarnings2.Click += CmbOtherEarnings2_Click;
                cmbOtherEarnings3.Click += CmbOtherEarnings3_Click;
                OtherEarnings1Valid = double.TryParse(txtboxOtherEarnings1.Text, out OtherEarnings1);
                OtherEarnings2Valid = double.TryParse(txtboxOtherEarnings2.Text, out OtherEarnings2);
                OtherEarnings3Valid = double.TryParse(txtboxOtherEarnings3.Text, out OtherEarnings3);
                


                MessageBox.Show("Please select an Employee from the dropdown list", "Notice");
            }

            else
            {
                EmployeeSelected = true;

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

            else
            {
               
                if (cmbPayType.SelectedIndex > -1)
                {
                    
                    cmbOtherEarnings1.Enabled = true;
                    cmbOtherEarnings2.Enabled = true;
                    cmbOtherEarnings3.Enabled = true;


                    if (cmbPayType.SelectedIndex == 0) /*Hourly Pay*/
                    {

                        if (string.IsNullOrEmpty(txtboxHoursWorked.Text) && string.IsNullOrEmpty(txtboxOvertime.Text) && string.IsNullOrEmpty(txtboxRateHours.Text))
                        {
                            MessageBox.Show("Please enter Number of Hours, Pay Rate and Overtime", "Attention");
                            txtboxTotalGrossPay.Text = "ERROR";

                        }
                    }

                    if (cmbPayType.SelectedIndex == 1) /*Salary Pay*/
                    {

                        if (string.IsNullOrEmpty(txtboxBasicPaySalary.Text))
                        {
                            MessageBox.Show("Please enter Basic Pay Amount \nand/or check if employee is on commissions", "Attention");

                        }
                    }


                    if (cmbPayType.SelectedIndex == 2) /*Salary Pay and Commissions*/

                    {


                        if (string.IsNullOrEmpty(txtboxBasicPaySalary.Text) && string.IsNullOrEmpty(txtboxSalesReceipts.Text) && string.IsNullOrEmpty(txtBoxCommissionPercentage.Text))
                        {

                            MessageBox.Show("Please enter Basic Pay Amount \nand Total Sales Receipts \nand/or Commission Percentage", "Attention");

                        }
                    }
                }

                if((cmbPayType.Enabled == true) || (cmbPayType.SelectedIndex == -1 && (DatesCheckedFrom == true || DatesCheckedTo == true) && EmployeeSelected == true))
                {
                    cmbPayType.Enabled = true;
                    MessageBox.Show("Now select a Pay Type", "Friendly Advice");
                }
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

            if(OtherEarnings1Valid == false || OtherEarnings2Valid == false || OtherEarnings3Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Earnings!!", "Attention");

            }
                

            
            

        }

        

        private void SalaryAndCommissionsCalculations()
        {
            ValidEntrySalary = double.TryParse(txtboxBasicPaySalary.Text, out SalaryAmount);
            ValidEntrySalesReceipts = double.TryParse(txtboxSalesReceipts.Text, out SalesReceiptsAmount);
            ValidCommissionPercentage = double.TryParse(txtBoxCommissionPercentage.Text, out CommissionPercentage);


            if (ValidEntrySalary == false)
            {
                txtboxBasicPaySalary.ForeColor = ValidEntrySalary ? Color.Black : Color.Red;
                MessageBox.Show("Please enter a valid Basic Pay amount", "Reminder");
                txtboxBasicPaySalary.Tag = "Please enter the Weekly/Bi-Weekly/Monthly Rate of Pay";
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }

            else if (ValidEntrySalesReceipts == false)
            {
                txtboxSalesReceipts.ForeColor = ValidEntrySalesReceipts ? Color.Black : Color.Red;
                MessageBox.Show("Please enter a valid Sales Receipts amount", "Reminder");
                txtboxBasicPaySalary.Tag = "Please enter the amount of Sales Receipts on which calculate Commissions";
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }

            else if (ValidCommissionPercentage == false)
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
                txtboxTotalGrossPay.Text = txtboxGrossPaySalaried_Commission.Text;
                pnlDeductions.Visible = true;
                pnlOtherEarnings.Visible = true;
                OtherDeduction1 = double.Parse(txtboxOtherDeductions1.Text);
                OtherDeduction2 = double.Parse(txtboxOtherDeductions2.Text);
                OtherDeduction3 = double.Parse(txtboxOtherDeductions3.Text);
            }
        }

        private void SalaryPayCalculations()
        {
            ValidEntrySalary = double.TryParse(txtboxBasicPaySalary.Text, out SalaryAmount);
            bool SalaryAmountValidated = true;
            if (ValidEntrySalary == false && SalaryAmountValidated == false)
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

        private void HourlyPayCalculations()
        {

            ValidEntryHours = double.TryParse(txtboxHoursWorked.Text, out HoursWorked);
            ValidEntryHourlyRate = double.TryParse(txtboxRateHours.Text, out HourlyRate);
            ValidEntryOvertime = double.TryParse(txtboxOvertime.Text, out Overtime);

            OvertimeRate = HourlyRate * 1.5;
            txtboxOvertimeRate.Text = OvertimeRate.ToString();
            txtboxOvertimeRate.Enabled = false;
            txtboxGrossPayHourly.Enabled = false;

            double GrossPayHourly;
            GrossPayHourly = ((HoursWorked * HourlyRate) + (Overtime * OvertimeRate));
            txtboxGrossPayHourly.Text = GrossPayHourly.ToString("C2", new CultureInfo("en-IE"));
            txtboxTotalGrossPay.Text = txtboxGrossPayHourly + txtboxBasicPaySalary.Text;

            if (ValidEntryHours == false)
            {

                txtboxHoursWorked.ForeColor = ValidEntryHours ? Color.Black : Color.Red;
                MessageBox.Show("Please enter a valid number of hours worked \nExample: 10.25 for 10 hours and 15 minutes", "Reminder");
                txtboxHoursWorked.Tag = "Please enter a number of Hours Worked";
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else if (ValidEntryHourlyRate == false)
            {
                txtboxRateHours.ForeColor = ValidEntryHourlyRate ? Color.Black : Color.Red;
                MessageBox.Show("Please enter a valid rate of hourly pay \nExample: 11.15 for €11.15 an hour", "Reminder");

                txtboxRateHours.Tag = "Please enter a rate of pay per hour";
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }

            else if (ValidEntryOvertime == false)
            {
                txtboxOvertime.ForeColor = ValidEntryOvertime ? Color.Black : Color.Red;
                MessageBox.Show("Please enter a valid number of overtime hours worked \nExample: 2.50 for 2 hours and half \nIf no overtime worked, enter \"0\"", "Reminder");

                txtboxOvertime.Tag = "Please enter a number of overtime hours worked";
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
            else
            {
                txtboxTotalGrossPay.Text = txtboxGrossPayHourly.Text;
                pnlDeductions.Visible = true;
                pnlOtherEarnings.Visible = true;
            }

        }


        private void CalculatePAYE()
        {

        }

        private void OtherDeductionValidated()
        {
            if (OtherDeductions1Valid == false || OtherDeductions2Valid == false || OtherDeductions3Valid == false)
            {
                MessageBox.Show("Please check the Values entered in Other Deductions!!", "Attention");
            }

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

                    break;

                case "Salary":
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Enabled = false;
                    rbCommissions.Checked = false;
                    txtboxSalesReceipts.Enabled = false;
                    txtboxCommissions.Enabled = false;
                    cmbPaySelected = true;

                    break;

                case "Commissions":
                    txtboxBasicPaySalary.Visible = true;
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Checked = true;
                    txtboxSalesReceipts.Enabled = true;
                    txtboxCommissions.Enabled = false;
                    cmbPaySelected = true;

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


    }
}

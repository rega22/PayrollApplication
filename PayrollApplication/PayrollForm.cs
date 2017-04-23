using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Globalization;

namespace PayrollApplication
{
    public partial class payroll_form : Form
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
        bool DatesChecked = false;

        double HoursWorked = 0;
        double Overtime = 0;
        double HourlyRate = 0;
        double OvertimeRate = 0;



        private bool cmbPaySelected = false;


        public payroll_form()
        {
            InitializeComponent();

        }
        private void Payroll_form_Load(object sender, EventArgs e)
        {
            //SQLConnection();

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
                if (cmbEmployeeDetails.SelectedIndex == -1)
                {
                    txtboxOtherDeductions1.Clear();
                    txtboxOtherDeductions2.Clear();
                    txtboxOtherDeductions3.Clear();
                    txtboxOtherEarnings1.Clear();
                    txtboxOtherEarnings2.Clear();
                    txtboxOtherEarnings3.Clear();
                    MessageBox.Show("Please select an Employee from the dropdown list", "Notice");
                    

                }

                else
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

                    int IndexSelected = cmbEmployeeDetails.SelectedIndex;
                    txtboxEmployeeID.Text = (string)Employee_ID.GetValue(IndexSelected);
                    txtboxPPSNumber.Text = (string)PPS_Numbers.GetValue(IndexSelected);
                    txtboxEmployeeID.Enabled = false;
                    txtboxPPSNumber.Enabled = false;
                    cmbPayType.Enabled = true;

                    DatesBeenChecked_SelectPay();

                    dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
                    dateTimePicker2.ValueChanged += DateTimePicker2_ValueChanged;




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + " " + ex.Message, "Exception");
            }



        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DatesChecked = true;

            DatesBeenChecked_SelectPay();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DatesChecked = true;

            DatesBeenChecked_SelectPay();
        }

        private void DatesBeenChecked_SelectPay()
        {
            if (DatesChecked == false)
            {

                DialogResult dr = MessageBox.Show("Please check the Pay From and To dates!!", "Notice", MessageBoxButtons.OK);

                
                    if (cmbPayType.SelectedIndex > -1)

                    {
                        cmbPaySelected = true;
                        if (string.IsNullOrEmpty(txtboxHoursWorked.Text) && string.IsNullOrEmpty(txtboxOvertime.Text) && string.IsNullOrEmpty(txtboxRateHours.Text))
                        {
                            MessageBox.Show("Please enter Number of Hours, Pay Rate and Overtime", "Attention");
                            
                        }

                    }

                    else
                    {

                        MessageBox.Show("Now select a Pay Type", "Friendly Advice");
                    }
                }
            }
        



        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            LoadEmployees();

            if (cmbPaySelected == true)
            {
                ValidEntryHours = double.TryParse(txtboxHoursWorked.Text, out HoursWorked);
                ValidEntryHourlyRate = double.TryParse(txtboxRateHours.Text, out HourlyRate);
                ValidEntryOvertime = double.TryParse(txtboxOvertime.Text, out Overtime);

                bool HoursWorkedValidated = true;
                bool RatePerHourValidated = true;
                bool OvertimeValidated = true;


                OvertimeRate = HourlyRate * 1.5;
                txtboxOvertimeRate.Text = OvertimeRate.ToString();
                txtboxOvertimeRate.Enabled = false;
                txtboxGrossPayHourly.Enabled = false;

                double GrossPayHourly;
                GrossPayHourly = ((HoursWorked * HourlyRate) + (Overtime * OvertimeRate));
                txtboxGrossPayHourly.Text = GrossPayHourly.ToString("C2", new CultureInfo("ie-EN"));
                txtboxTotalGrossPay.Text = txtboxGrossPayHourly + txtboxBasicPaySalary.Text;

                if (ValidEntryHours == false && RatePerHourValidated == false && OvertimeValidated == false)
                {

                    txtboxHoursWorked.ForeColor = ValidEntryHours ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid number of hours worked \nExample: 10.25 for 10 hours and 15 minutes", "Reminder");

                    txtboxHoursWorked.Tag = "Please enter a number of Hours Worked";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;



                }
                else if (ValidEntryHourlyRate == false && HoursWorkedValidated == false && OvertimeValidated == false)
                {
                    txtboxRateHours.ForeColor = ValidEntryHourlyRate ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid rate of hourly pay \nExample: 11.15 for €11.15 an hour", "Reminder");

                    txtboxRateHours.Tag = "Please enter a rate of pay per hour";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                }

                else if (ValidEntryOvertime == false && HoursWorkedValidated == false && RatePerHourValidated == false)
                {
                    txtboxOvertime.ForeColor = ValidEntryOvertime ? Color.Black : Color.Red;
                    MessageBox.Show("Please enter a valid number of overtime hours worked \nExample: 2.50 for 2 hours and half \nIf no overtime worked, enter \"0\"");

                    txtboxOvertime.Tag = "Please enter a valid number of overtime hours worked";
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
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
                    break;

                case "Salary":
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Enabled = false;
                    rbCommissions.Checked = false;
                    txtboxSalesReceipts.Enabled = false;
                    txtboxCommissions.Enabled = false;
                    break;

                case "Commissions":
                    txtboxBasicPaySalary.Visible = true;
                    pnlHourlyEmployees.Visible = false;
                    pnlSalariedEmployees.Visible = true;
                    rbCommissions.Checked = true;
                    txtboxSalesReceipts.Enabled = true;
                    txtboxCommissions.Enabled = true;
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
            txtboxTotalDeductions.Enabled=false;
        }


    }
}

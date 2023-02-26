using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class UpdateTimesheet : UserControl
    {
        public UpdateTimesheet()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog= FLEET MANAGEMENT DATABASE;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TimeSpan result = this.dateTimeForth.Value - this.dateTimeThird.Value;
            this.txtHours.Text = result.ToString();
            string s = txtHours.Text;
            string[] tempArry = txtHours.Text.Split('.');
            txtHours.Text = "The hours spent :" + tempArry[0];

            try
            {
                string sqlQuery = "INSERT INTO [TimeSheet_Manager] VALUES (@TM_Record,@Date_Checked_In,@Time_Checked_In,@Date_Checked_Out,@Time_Checked_Out)";
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                con.Open();
                cm.Parameters.AddWithValue("@TM_Record", Convert.ToInt32(txtTMRecords.Text.Trim()));
                //cm.Parameters.AddWithValue("@Employee_Id", txtEmp.Text.Trim());
                cm.Parameters.AddWithValue("@Date_Checked_In", dateTimeFirst.Value.ToString());
                cm.Parameters.AddWithValue("@Time_Checked_In", dateTimeThird.Value.ToString());
                cm.Parameters.AddWithValue("@Date_Checked_Out", dateTimeSecond.Value.ToString());
                cm.Parameters.AddWithValue("@Time_Checked_Out", dateTimeForth.Value.ToString());
                cm.ExecuteNonQuery();
                MessageBox.Show("Information inserted successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
            finally
            {
                con.Close();
            }
   
        }
        public void TmRecords()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TM_Record from TimeSheet_Manager", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtTMRecords.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    txtTMRecords.Text = "1";
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        private void UpdateTimesheet_Load(object sender, EventArgs e)
        {
           TmRecords();
        }
    }
}

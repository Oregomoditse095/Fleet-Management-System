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
using System.Security.Cryptography;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class EmpRegistration : Form
    {
        public EmpRegistration()
        {
            InitializeComponent();
        }



        static string EncryptPassword(string value)
        {
            using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = mD5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);

            }

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtConPassword.Text != txtEmpPassword.Text)
            {
                MessageBox.Show("The passwords entered do not match! Please re-enter the password. ");
            }
            else
            {
                string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string cmds = $"INSERT INTO Employees VALUES (@Employee_ID, @Employee_Name, @Employee_Surname, @Employee_Occupation, @Employee_ContactNum, @Employee_Email, @Employee_Password)";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Employee_Id", txtEmpId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Employee_Name", txtEmpName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Employee_Surname", txtEmpSurname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Employee_Occupation", cmbOccupation.SelectedItem.ToString().Trim());
                    cmd.Parameters.AddWithValue("@Employee_Email", txtEmpEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Employee_ContactNum", Convert.ToInt32(txtEmpPhone.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Employee_Password", EncryptPassword(txtEmpPassword.Text.Trim()));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Successfully registered");
                }

                if (cmbOccupation.SelectedItem.ToString() == "Office Manager")
                {
                    this.Hide();
                    new OfficeManager().Show();
                }
                if (cmbOccupation.SelectedItem.ToString() == "Trip Manager")
                {
                    this.Hide();
                    new TripManager().Show();
                }
                if (cmbOccupation.SelectedItem.ToString() == "Timesheet Manager")
                {
                    this.Hide();
                    new TimesheetManager().Show();
                }
                if (cmbOccupation.SelectedItem.ToString() == "Service Manager")
                {
                    this.Hide();
                    new Appointments().Show();
                }
                if (cmbOccupation.SelectedItem.ToString() == "Vehicle Administrator")
                {
                    this.Hide();
                    new Veh_Admin().Show();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }


    }
}

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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

      

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new EmpRegistration().Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog= FLEET MANAGEMENT DATABASE;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmds = $"SELECT COUNT(*) FROM Employees WHERE Employee_Email = '{txtEmpEmail.Text}' AND Employee_Password = '{txtEmpPassword.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(cmds, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows[0][0].ToString() == "1")
                {
                    if (cmbOccupation.SelectedItem.ToString() == "Trip Manager")//text if this statement will 
                    {
                        this.Hide();
                        new TripManager().Show();
                    }
                    if (cmbOccupation.SelectedItem.ToString() == "Timesheet Manager")
                    {
                        this.Hide();
                        new TimesheetManager().Show();
                    }
                    if (cmbOccupation.SelectedItem.ToString() == "Office Manager")
                    {
                        this.Hide();
                        new OfficeManager().Show();
                    }
                    if (cmbOccupation.SelectedItem.ToString() == "Vehicle Administrator")
                    {
                        this.Hide();
                        new Veh_Admin().Show();
                    }
                    if (cmbOccupation.SelectedItem.ToString() == "Service Manager")
                    {
                        this.Hide();
                        new Appointments().Show();
                    }

                }
               else
                {
                    MessageBox.Show("Your email or password was invalid, please re-enter the correct field!");
                }
                con.Close();

            }
        }

    
    }
}

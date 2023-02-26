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
    public partial class Records : UserControl
    {
        public Records()
        {
            InitializeComponent();
        }
        //Bookings 
        // 
        //Vehicle Records
        //Employee Attendance
        //Trip Records
        //Payments
        private void BtnView_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
            con.Open();
              
                if (cmbRecords.SelectedItem.ToString() == "Customer Records")
                {
                    string cmds = "SELECT * FROM Customers";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;
                    
                }
                if (cmbRecords.SelectedItem.ToString() == "Vehicle Records")
                {
                    string cmds = "SELECT * FROM Vehicles";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;
                    
                }
                if (cmbRecords.SelectedItem.ToString() == "Employee Attendance")
                {
                    string cmds = "SELECT * FROM Timesheet_Manager";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;
                    
                }
                if (cmbRecords.SelectedItem.ToString() == "Trip Records")
                {
                    string cmds = "SELECT * FROM Trips";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;
                    
                }
                if (cmbRecords.SelectedItem.ToString() == "Payments")
                {
                    string cmds = "SELECT * FROM Payments";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;
                    
                }
                if (cmbRecords.SelectedItem.ToString() == "Incident Records")
                {
                    string cmds = "SELECT * FROM Incidents";
                    SqlCommand cmd = new SqlCommand(cmds, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;
                    dataGridViewRec.DataSource = source;  
                }
                con.Close();
            }
        }


    }

    
    }


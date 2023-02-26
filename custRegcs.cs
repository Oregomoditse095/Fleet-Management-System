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
    public partial class custRegcs : UserControl
    {
        public custRegcs()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string cmds = $"INSERT INTO Customers VALUES (@Customer_Id,@Customer_Name, @Customer_Surname, @Customer_Phone, @Customer_Email, @Customer_Class)";
                SqlCommand cmd = new SqlCommand(cmds, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Customer_Id", txtCustId.Text.Trim());
                cmd.Parameters.AddWithValue("@Customer_Name", custNametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Customer_Surname", custSurtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Customer_Class", custClasscmb.SelectedItem.ToString().Trim());
                cmd.Parameters.AddWithValue("@Customer_Email", custEmailtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Customer_Phone", custphonetxt.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Customer has been successfully registered.");
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            txtCustId.Text = custNametxt.Text = custSurtxt.Text = custEmailtxt.Text = custphonetxt.Text = "";
        }
    }
}
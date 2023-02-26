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
    public partial class ViewTimesheet : UserControl
    {
        public ViewTimesheet()
        {
            InitializeComponent();
        }

        SqlDataAdapter sdr;
        DataTable dt;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True");

       

        public void ViewTable()
        {
            string sqlQuery = "SELECT * FROM Employees";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            sdr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                try
                {
                    ViewTable();
                    SqlCommandBuilder cmd = new SqlCommandBuilder(sdr);
                    sdr.Update(dt);
                    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
        }

        private void txtEmpSearch_TextChanged_1(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Employees where Employee_Id like '" + txtEmpSearch.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ViewTimesheet_Load(object sender, EventArgs e)
        {
            ViewTable();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string sqlQuery = "Delete from Employees where  Employee_Id = '" + txtEmpSearch.Text + "'";
            SqlCommand comm = new SqlCommand(sqlQuery, con);
            comm.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Information Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

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
    public partial class ViewBookings : Form
    {
        SqlDataAdapter sdr;
        DataTable dt;
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TripManager().Show();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {    
                SqlCommandBuilder cmd = new SqlCommandBuilder(sdr);
                sdr.Update(dt);
                MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand comm = new SqlCommand("Select * from Trips", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet dt = new System.Data.DataSet();
            sda.Fill(dt, "Trips");
            dataGridView1.DataSource = dt.Tables[0];
            con.Close();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            SelectView();
        }
        public void SelectView()
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            string sqlQuery = "SELECT * FROM Trips";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            sdr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtDelete_TextChanged_1(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            string sqlQuery = "SELECT * FROM Trips where Trip_Id like '" + txtDelete.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            sdr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sqlQuery = "Delete from Trips where  Trip_Id = '" + txtDelete.Text + "'";
            SqlCommand comm = new SqlCommand(sqlQuery, con);
            comm.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Information Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    }
    


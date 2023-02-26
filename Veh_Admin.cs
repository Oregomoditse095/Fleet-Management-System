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
using System.Configuration;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class Veh_Admin : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        bool mouseDown;
        private Point offset;
        public Veh_Admin()
        {
            InitializeComponent();
        }

        private void Veh_Admin_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T1S3EAF\SQLEXPRESS;Initial Catalog=JAPTECH_Database;Integrated Security=True");
            //sda = new SqlDataAdapter(@"SELECT * FROM Vehicles", con);
            //dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'jAPTECH_DatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            //this.vehiclesTableAdapter.Fill(this.jAPTECH_DatabaseDataSet.Vehicles);
            /* SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T1S3EAF\SQLEXPRESS;Initial Catalog=JAPTECH_Database;Integrated Security=True");

             {
                 if (conn.State == ConnectionState.Closed)

                     conn.Open();
             }

             SqlCommand cmd1 = new SqlCommand("SELECT * FROM Vehicles", conn);

             SqlDataAdapter da = new SqlDataAdapter();

             DataTable dt = new DataTable();

             da.SelectCommand = cmd1;

             dt.Clear();
             da.Fill(dt);

             dataGridView1.DataSource = dt; */

            //dataGridView1.DataSource = GetVehicleList();

        }

        /*private DataTable GetVehicleList()
        {
            DataTable dtVehicles = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicles", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtVehicles.Load(reader);
                }
            }

            return dtVehicles;
        }*/
        

       

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-31H3BH8T\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM Vehicles", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtVehColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehiclesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Veh_Admin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fLEET_MANAGEMENT_DATABASEDataSet2.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.fLEET_MANAGEMENT_DATABASEDataSet2.Vehicles);

        }
    }
}

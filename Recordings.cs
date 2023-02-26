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
    public partial class Recordings : UserControl
    {
        public Recordings()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True");

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT Petrol_Usage FROM Trips WHERE Trip_Id = @Trip_Id", connect);

            cmd.Parameters.AddWithValue("@Trip_Id", txtTripID.Text);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtCalc.Text = read.GetValue(0).ToString();
            }
            connect.Close();

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT Total_usedKm, Vehicle_Id, InitialFuel FROM Trips WHERE Trip_Id = @Trip_Id", connect);

            cmd.Parameters.AddWithValue("@Trip_Id", txtTripID.Text);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtKMTravel.Text = read.GetValue(0).ToString();
                txtVehicleReg.Text = read.GetValue(1).ToString();
                txtTank.Text = read.GetValue(2).ToString();
            }
            connect.Close();
        }

        private void btnSubmitFuel_Click(object sender, EventArgs e)
        {
            if ((txtKMTravel.Text == "") || (txtLtRefill.Text == ""))

                MessageBox.Show("Please Enter All Credentials.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Book calc = new Book();

            calc.TripID = txtVehicleReg.Text;
            calc.vehicleReg = txtVehicleReg.Text;
            calc.km = double.Parse(txtKMTravel.Text);
            calc.FuelTank = int.Parse(txtTank.Text);
            calc.LitresRefilled = double.Parse(txtLtRefill.Text);

            //listBox1.Items.Add(calc.FuelUsage());



            connect.Open();
            string CMD = $"UPDATE Trips SET Petrol_Usage = @Petrol_Usage WHERE Trip_Id = @Trip_Id";
            SqlCommand comand = new SqlCommand("UPDATE Trips SET Petrol_Usage = @Petrol_Usage WHERE Trip_Id = @Trip_Id", connect);
            comand.Parameters.AddWithValue("@Trip_Id", txtVehicleReg.Text);
            comand.Parameters.AddWithValue("@Petrol_Usage", calc.FuelUsage());

            comand.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Database/Table Successfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }


        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-31H3BH8T\\SQLEXPRESS;Initial Catalog=FLEET MANAGEMENT DATABASE;Integrated Security=True");
        private void BtnCreateQuote_Click(object sender, EventArgs e)
        {
                if ((cmbGoods.Text == "") || (cmbQuantity.Text == "") || (txtDeparture.Text == "") || (txtDestination.Text == "") || (dateTimePickerDeparture.Value.ToString() == "") || (dateTimePickerDes.Value.ToString() == ""))

                    MessageBox.Show("Please Enter All Credentials.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string CMD = $"INSERT INTO Trips VALUES (@Trip_Id,@Employees_Id,@Vehicles_Id ,@Customer_Email, @Booking_Date, @Cargo_Type, @Quantity, @Booking_Deposit, @Trip_departure, @Trip_destination, @Trip_DepDateAndTime, @Trip_DesDateAndTime, @InitialFuel , @Petrol_Usage, @Trip_Kilometers)";
                SqlCommand command = new SqlCommand(CMD, connect);
                connect.Open();
            command.Parameters.AddWithValue("@Trip_Id", txtTripID.Text.Trim());
            command.Parameters.AddWithValue("@Employees_Id", txtEmp.Text.Trim());
            command.Parameters.AddWithValue("@Vehicles_Id", txtVehicle.Text.Trim());
            command.Parameters.AddWithValue("@Customer_Email", txtCust.Text.Trim());
            command.Parameters.AddWithValue("@Booking_Date", "2021-11-12");
            command.Parameters.AddWithValue("@Cargo_Type", cmbGoods.SelectedItem.ToString().Trim());
            command.Parameters.AddWithValue("@Quantity", cmbQuantity.SelectedItem.ToString().Trim());
            command.Parameters.AddWithValue("@Booking_Deposit", Discount());
            command.Parameters.AddWithValue("@Trip_departure", txtDeparture.Text.Trim());
            command.Parameters.AddWithValue("@Trip_destination", txtDestination.Text.Trim());
            command.Parameters.AddWithValue("@Trip_DepDateAndTime", dateTimePickerDeparture.Value.ToString());
            command.Parameters.AddWithValue("@Trip_DesDateAndTime", dateTimePickerDes.Value.ToString());
            command.Parameters.AddWithValue("@InitialFuel", 345);
            command.Parameters.AddWithValue("@Petrol_Usage", 100);
            command.Parameters.AddWithValue("@Trip_Kilometers", 67);
            command.ExecuteNonQuery();
            connect.Close();

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {

                        sw.WriteLine("JAPTECH BOOKING QUOTE");
                        sw.WriteLine("----------------------------------");
                        sw.WriteLine("Trip ID: " + txtTripID.Text);
                        sw.WriteLine("Driver Number: " + txtEmp.Text);
                        sw.WriteLine("Vehicle Number: " + txtVehicle.Text);
                        sw.WriteLine("Customer Email: " + txtCust.Text);
                        sw.WriteLine("Type of goods: " + cmbGoods.SelectedItem);
                        sw.WriteLine("Quantity: " + cmbQuantity.SelectedItem);
                        sw.WriteLine("Place of departure: " + txtDeparture.Text);
                        sw.WriteLine("Place of destination: " + txtDestination.Text);
                        sw.WriteLine("Departure date & time: " + dateTimePickerDeparture.Value);
                        sw.WriteLine("Destination date & time: " + dateTimePickerDes.Value);
                        sw.WriteLine("Deposit amount due: R" + Discount());
                        sw.WriteLine("----------------------------------");
                        sw.WriteLine("Disclaimer: If customers are unable to pay the initial deposit within 72 hours from the time of booking, the booking will be deemed invalid and therefore cancelled");
                    }
                }
            
                    
                }

                MessageBox.Show("Database/Table Values Successfully Inserted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            public double Discount()
            {
                double disPerc = 0.1;
                double payments;
                double discounts;
                if (cmbGoods.SelectedItem.ToString() == "Vehicles")
                {
                    double price = 25274.45;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;

                }
                else if (cmbGoods.SelectedItem.ToString() == "Ordered Goods")
                {
                    double price = 61;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Frozen Food")
                {
                    double price = 100;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Vehicles")
                {
                    double price = 25274.45;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Flower(s)")
                {
                    double price = 200;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Frozen Sea Food")
                {
                    double price = 450.99;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Fertilizer(s)")
                {
                    double price = 899;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Cargo Container")
                {
                    double price = 4499.99;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else if (cmbGoods.SelectedItem.ToString() == "Fruits and Veggies")
                {
                    double price = 349.99;
                    payments = price * Int32.Parse(cmbQuantity.SelectedItem.ToString());
                    discounts = payments * disPerc;
                    return discounts;
                }
                else
                    payments = 15000;
                discounts = payments * disPerc;
                return discounts;

            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtTripID.Clear();
                cmbGoods.Text = string.Empty;
                cmbQuantity.Text = string.Empty;
                txtDeparture.Clear();
                txtDestination.Clear();
                dateTimePickerDeparture.Text = string.Empty;
                dateTimePickerDes.Text = string.Empty;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TripBookings();
        }

       
    }
    }


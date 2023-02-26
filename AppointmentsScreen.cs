using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class AppointmentsScreen : UserControl
    {
        public AppointmentsScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtPhoneNumber.Clear();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "" || cmbServices.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in phone number & service type");
            }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {

                        sw.WriteLineAsync("JAPTECH VEHICLE SERVICE APPOINTMENT");
                        sw.WriteLine("----------------------------------------");
                        sw.WriteLine("You have a scheduled vehicle service appointment on: \t" + dateTimePicker1.Value);
                        sw.WriteLine("The type of service to be done: \t\t\t" + cmbServices.SelectedItem);
                        sw.WriteLine("Call this number for any enquiries: \t\t\t" + txtPhoneNumber.Text);
                        sw.WriteLine("Additional information: \t\t\t\t" + txtInfo.Text);
                        MessageBox.Show("The vehicle service appointment has been successfully created");
                    }
                }
            }
        }
    }
}

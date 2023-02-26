using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    public partial class TripBookings : UserControl
    {
        public TripBookings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bookings().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBookings().Show();
        }
    }
}

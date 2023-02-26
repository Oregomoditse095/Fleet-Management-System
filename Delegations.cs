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
    public partial class Delegations : UserControl
    {
        public Delegations()
        {
            InitializeComponent();
        }

        private void BtnTripMan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Hide();
            new TimesheetManager().Show();
        }

        private void BtnServiceMan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OfficeManager().Hide();
            new Appointments().Show();
        }

        private void BtnVehAdmin_Click(object sender, EventArgs e)
        {  
            this.Hide();
            new OfficeManager().Hide();
            new Veh_Admin().Show();
        }
    }
}

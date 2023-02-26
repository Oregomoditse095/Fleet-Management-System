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
    public partial class TripManager : Form
    {
        public TripManager()
        {
            InitializeComponent();
            Load += TripManager_Load;
        }

        private void TripManager_Load(object sender, EventArgs e)
        {
            SetActivePanel(custRegcs1);
        }

        private void custRegbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(custRegcs1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        private void SetActivePanel(UserControl control)
        {
            //DISABLE ALL USER CONTROLS//
            custRegcs1.Visible = false;
            tripBookings1.Visible = false;
            recordings1.Visible = false;
            emergencies1.Visible = false;

            //Enabling the Active Control//
            control.Visible = true;

        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(tripBookings1);
        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(recordings1);
        }

        private void emergencybtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(emergencies1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using JAPTECH_FLEET_MANAGEMENT_SYSTEM;
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
    public partial class Appointments : Form
    {
        bool mouseDown;
        private Point offset;
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            SetActivePanel(appointmentsScreen1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            SetActivePanel(appointmentsScreen1);
        }

        public void SetActivePanel(UserControl control)
        {
            appointmentsScreen1.Visible = false;
            jobSheet1.Visible = false;
            control.Visible = true;
        }

        private void btnJobSheets_Click(object sender, EventArgs e)
        {
            SetActivePanel(jobSheet1);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void appointmentsScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}

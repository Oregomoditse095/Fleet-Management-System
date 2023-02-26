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
    public partial class TimesheetManager : Form
    {
        public TimesheetManager()
        {
            InitializeComponent();
            Load += TimesheetManager_Load;
        }

        private void TimesheetManager_Load(object sender, EventArgs e)
        {
            SetActivePanel(updateTimesheet1);
        }

        private void BtnUpdateTs_Click(object sender, EventArgs e)
        {
            SetActivePanel(updateTimesheet1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        
        private void SetActivePanel(UserControl control)
        {
            //Disabling user controls
            updateTimesheet1.Visible = false;
            viewTimesheet1.Visible = false;

            //enables the active control
            control.Visible = true;

        }

        private void btnViewTs_Click(object sender, EventArgs e)
        {
            SetActivePanel(viewTimesheet1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

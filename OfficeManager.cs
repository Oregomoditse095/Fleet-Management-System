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
    public partial class OfficeManager : Form
    {
        public OfficeManager()
        {
            InitializeComponent();
            Load += OfficeManager_Load;
        }

        private void OfficeManager_Load(object sender, EventArgs e)
        {
            SetActivePanel(delegations1);
        }   
/// <summary>
/// 
/// </summary>
/// <param name="control"></param>
        private void SetActivePanel(UserControl control)
        {
            //Disable user controls
            delegations1.Visible = false;
            records1.Visible = false;

            //Enable control
            control.Visible = true;
        }

        private void btnDelegations_Click(object sender, EventArgs e)
        {
            SetActivePanel(delegations1);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            SetActivePanel(records1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

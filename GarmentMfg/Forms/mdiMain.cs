using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GarmentMfg
{
    public partial class mdiMain : Form
    {
        public mdiMain()
        {
            InitializeComponent();
        }

        private void garmentManufacturingCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMfgCycle objCycle = new frmMfgCycle();
            objCycle.MdiParent = this;
            objCycle.Show();
        }

        private void fabricIssueToJobberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductIssue objProduct = new frmProductIssue();
            objProduct.MdiParent = this;
            objProduct.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            garmentManufacturingCycleToolStripMenuItem_Click(null, null);
        }

        private void autoPurchaseEntryModuleForJobberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoPurchase objAutoPurchase = new frmAutoPurchase();
            objAutoPurchase.MdiParent = this;
            objAutoPurchase.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plcalc.Core;
using plcalc.Core.Manager;

namespace plcalc
{
    public partial class PlReport : Form
    {
        public PlReport()
        {
            InitializeComponent();
            BindPnL();
        }

        private async void BindPnL()
        {
            var mgr = new TransactionManager();
            dgPnL.DataSource = await mgr.GetPlReportData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindPnL();
        }
    }
}

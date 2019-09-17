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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            BindTransactionData();
        }

        private void BindTransactionData()
        {
            dgTransaction.DataSource = new TransactionManager().GetTransactions();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindTransactionData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

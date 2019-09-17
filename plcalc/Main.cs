using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plcalc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form frm;
            var ctrl = sender as ToolStripMenuItem;
            if (ctrl == null) return;
            switch (ctrl.Tag)
            {
                case "vt":
                    frm = new Transactions();
                    frm.ShowDialog();
                    break;
                case "mt":
                    frm = new OrderForm();
                    frm.ShowDialog();
                    break;
                case "pl":
                    frm = new PlReport();
                    frm.ShowDialog();
                    break;
            }
        }
    }
}

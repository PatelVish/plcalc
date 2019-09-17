using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plcalc.Common.Enums;
using plcalc.Core;
using plcalc.Core.Dto;
using plcalc.Core.Manager;

namespace plcalc
{
    public partial class OrderForm : Form
    {
        private MarketPriceManager _marketPriceManager = new MarketPriceManager();
        public OrderForm()
        {
            InitializeComponent();
        }

        private async void btnPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTicker.Text.Trim())) return;
            MarketPriceRes res = await _marketPriceManager.GetLatestRateByTicker(txtTicker.Text.Trim());
            lblPriceValue.Text = res?.Price.ToString() ?? "N/A";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price = 0;
                int quantity = 0;
                decimal.TryParse(lblPriceValue.Text, out price);
                int.TryParse(txtQuantity.Text, out quantity);
                if (quantity > 0 && price > 0)
                {
                    var res = new TransactionManager().AddNewTransaction(new TransactionDto
                    {
                        Ticker = txtTicker.Text.Trim(),
                        Action = cboBuySell.SelectedText == "Buy" ? TradeAction.Buy : TradeAction.Sell,
                        Price = price,
                        Quantity = quantity,
                        TradeDate = DateTime.Now
                    });
                    if(res)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid transaction data");
                }
            }
            catch (Exception ex)
            {
                //TBD: Log error
                throw;
            }
        }
    }
}

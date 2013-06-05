using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black_Scholes_Calculator
{
    public partial class MainWindow : Form
    {
        Option option;

        public MainWindow()
        {
            InitializeComponent();

            option = new Option();
        }

        private void buildOption()
        {
            option.assetPrice = Double.Parse(assetPriceField.Text);
            option.strike = Double.Parse(strikeField.Text);
            option.riskFreeRate = Double.Parse(rateField.Text);
            if (timeChecked.Checked)
            {
                option.timeToExpiry = Double.Parse(timeField.Text);
            }
            else
            {
                option.timeToExpiry = expiryDateField.Value.Subtract(valuationDateField.Value).TotalDays / 365.0;
            }
        }

        private void buildOptionWithVolatility()
        {
            buildOption();
            option.volatility = Double.Parse(volatilityField.Text);
        }

        private void buildOptionWithPrice()
        {
            buildOption();
            option.optionPrice = Double.Parse(priceField.Text);
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            buildOptionWithVolatility();
            option.price();
            priceField.Text = option.optionPrice.ToString();
            priceField.Update();
        }

        private void volatilityButton_Click(object sender, EventArgs e)
        {
            buildOptionWithPrice();
            option.implicitVolatility();
            volatilityField.Text = option.volatility.ToString();
            volatilityField.Update();
        }
    }
}

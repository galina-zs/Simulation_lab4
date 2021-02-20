using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        const double k = 0.02;
        double price, rubles;
        int currency = 0;
        int days, days_counter;
        Random rnd = new Random();

        private void buyButton_Click(object sender, EventArgs e)
        {
            int count = (int)exchangeNumericUpDown.Value;
            if (rubles >= price * count)
            {
                currency += count;
                rubles -= price * count;
                currencyCounterLabel.Text = currency.ToString();
                rublesCounterLabel.Text = Math.Round(rubles, 4).ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            rubles = 500;
            currency = 0;
            rublesCounterLabel.Text = rubles.ToString();
            currencyCounterLabel.Text = "0";
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            int count = (int)exchangeNumericUpDown.Value;
            if (currency >= count)
            {
                rubles += count * price;
                currency -= count;
                currencyCounterLabel.Text = currency.ToString();
                rublesCounterLabel.Text = Math.Round(rubles, 4).ToString();
            }
        }

        private void calculatingButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            price = (double)priceNumericUpDown.Value;
            days = (int)daysNumericUpDown.Value;
            chart1.Series[0].Points.AddXY(0, price);
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            days_counter++;
            if (days_counter <= days)
            {
                if (days_counter >= 10)
                {
                    chart1.ChartAreas[0].AxisX.Minimum = days_counter - 10;
                    chart1.ChartAreas[0].AxisX.Maximum = days_counter + 1;
                }
                price = price * (1 + k * (rnd.NextDouble() - 0.5));
                currencyPriceLabel.Text = "Currency Price: " + price.ToString();
                chart1.Series[0].Points.AddXY(days_counter, price);
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}

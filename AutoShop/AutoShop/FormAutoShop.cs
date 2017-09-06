using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop
{
    public partial class FormAutoShop : Form
    {
        public FormAutoShop()
        {
            InitializeComponent();
        }
        private decimal sum = 0;
        private void checkBox2_Click(object sender, EventArgs e)
        {
            string product=((CheckBox)sender).Tag.ToString();
            switch (product)
            {
                
                case "HotDog":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(HotDog.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(HotDog.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Hamburger":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Hamburger.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Hamburger.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Cheesburger":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Cheesburger.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Cheesburger.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Cola":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Cola.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Cola.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Sprite":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Sprite.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Sprite.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Americano":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Americano.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Americano.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Espresso":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Espresso.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Espresso.Text);
                        All.Text = sum.ToString();
                    }
                    break;
                case "Latte":
                    if (((CheckBox)sender).Checked)
                    {
                        sum += Convert.ToDecimal(Latte.Text);
                        All.Text = sum.ToString();
                    }
                    else
                    {
                        sum -= Convert.ToDecimal(Latte.Text);
                        All.Text = sum.ToString();
                    }
                    break;

            }
    
        }

        private void Total_Click(object sender, EventArgs e)
        {
            string button = ((Button)sender).Tag.ToString();
            switch (button)
            {
                case "Total":
                    if ((Convert.ToInt16(All.Text)) > 0)
                    {
                        TotalShow.Text = All.Text;
                        payment.Enabled=true;
                    }
                    break;
                case "Payment":
                    MessageBox.Show("Оплачено");
                    payment.Enabled = false;
                    All.Text = "0";
                    TotalShow.Text = "0";
                    break;
            }
        }
    }
}

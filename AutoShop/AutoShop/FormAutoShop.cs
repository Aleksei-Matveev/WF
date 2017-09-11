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
        private Dictionary<TextBox, decimal> array = new Dictionary<TextBox, decimal>(); 
        public FormAutoShop()
        {
            InitializeComponent();
        }
        private decimal sumShop = 0;
        private decimal sumFuel = 0;
        private void checkBox_Click(object sender, EventArgs e)
        {
            string product = ((CheckBox)sender).Tag.ToString();
            TextBox textboxCurrentPieces = textboxPieces(checkbox(product).Tag.ToString());
           
            if (checkbox(product).Checked)
            {
                textboxCurrentPieces.ReadOnly = false;
                textboxCurrentPieces.Text = "";
            }
            else
            {
                decimal price = Convert.ToDecimal(textboxPrice(product).Text);
                sumShop -= array[textboxPieces(product)] * price;
                array[textboxCurrentPieces] = 0;
                tbTotalShop.Text = sumShop.ToString();
                textboxCurrentPieces.ReadOnly = true;
                textboxCurrentPieces.Text = "";           
            }                 
        }

        private void tbPieces_TextChanged(object sender, EventArgs e)
        {
            string product=((TextBox)sender).Tag.ToString();
            decimal price = Convert.ToDecimal(textboxPrice(product).Text);
            int countProduct=0;             
            decimal cursum = 0;

            if (textboxPieces(product).Text != "")
            {
                if (int.TryParse(textboxPieces(product).Text, out countProduct) && countProduct <= 20)
                {
                    cursum = price * countProduct;
                    sumShop -= array[textboxPieces(product)] * price;
                    array[textboxPieces(product)] = countProduct;
                    sumShop += cursum;
                    tbTotalShop.Text = sumShop.ToString();
                }
                else
                    MessageBox.Show("Ограничение товара 20 штук!", "ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        private TextBox textboxPrice(string product)
        {
            switch (product)
            {
                case "HotDog":return tbHotDogPrice;
                case "Hamburger":return tbHamburgerPrice;
                case "Cheesburger": return tbCheesburgerPrice;
                case "Cola": return tbColaPrice;
                case "Sprite": return tbSpritePrice;
                case "Americano": return tbAmericanoPrice;
                case "Espresso": return tbEspressoPrice;
                case "Latte": return tbLattePrice;
                default: return null;               
            }
        }
        private TextBox textboxPieces(string product)
        {
            switch (product)
            {
                case "HotDog": return tbHotDogPieces;
                case "Hamburger": return tbHamburgerPieces;
                case "Cheesburger": return tbCheesburgerPieces;
                case "Cola": return tbColaPieces;
                case "Sprite": return tbSpritePieces;
                case "Americano": return tbAmericanoPieces;
                case "Espresso": return tbEspressoPieces;
                case "Latte": return tbLattePieces;
                default: return null;
            }
        }
        private CheckBox checkbox(string product)
        {
            switch (product)
            {
                case "HotDog": return chbHotDog;
                case "Hamburger": return chbHamburger;
                case "Cheesburger": return chbCheesburger;
                case "Cola": return chbCola;
                case "Sprite": return chbSprite;
                case "Americano": return chbAmericano;
                case "Espresso": return chbEspresso;
                case "Latte": return chbLatte;
                default: return null;
            }
        }
        private void Total_Click(object sender, EventArgs e)
        {
            string button = ((Button)sender).Tag.ToString();
            switch (button)
            {
                case "Total":
                    if ((Convert.ToDecimal(tbTotalShop.Text)) > 0)
                    {
                        decimal sumTotal = sumShop + sumFuel;
                        TotalShow.Text = sumTotal.ToString();
                        payment.Enabled = true;
                    }
                    break;

                case "Payment":
                    MessageBox.Show("Оплачено");
                    payment.Enabled = false;
                    tbTotalShop.Text = "0";
                    TotalShow.Text = "0";
                    tbTotalFuel.Text = "0";
                    sumShop = 0;
                    tbLitr.Text = "0";
                    chbHotDog.Checked = false;
                    chbHamburger.Checked = false;
                    chbCheesburger.Checked = false;
                    chbCola.Checked = false;
                    chbSprite.Checked = false;
                    chbAmericano.Checked = false;
                    chbEspresso.Checked = false;
                    chbLatte.Checked = false;
                    break;
            }
        }        
        private void FormAutoShop_Load(object sender, EventArgs e)
        {
            cbFuels.DisplayMember = "Name";
            cbFuels.DataSource = FuelRepository.GetFuels();
            cbFuels.SelectedIndex = 1;
            array.Add(tbHotDogPieces, 0);
            array.Add(tbHamburgerPieces, 0);
            array.Add(tbCheesburgerPieces, 0);
            array.Add(tbColaPieces, 0);
            array.Add(tbSpritePieces, 0);
            array.Add(tbAmericanoPieces, 0);
            array.Add(tbEspressoPieces, 0);
            array.Add(tbLattePieces, 0);            
        }

        private void cbFuels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFuels.SelectedItem != null)
            {
                FuelInfo sel = cbFuels.SelectedItem as FuelInfo;
                tbPriceFuel.Text = sel.Price.ToString();
            }
        }

        private void textBox18_KeyUp(object sender, EventArgs e)
        {
           sumFuel= Convert.ToDecimal(tbPriceFuel.Text)*Convert.ToDecimal(tbLitr.Text);
           tbTotalFuel.Text = sumFuel.ToString();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthor author= new FormAuthor();
            author.ShowDialog();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAutoShop_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Хотите завершить работу?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                e.Cancel = true;
            }
           
        }
    }
}
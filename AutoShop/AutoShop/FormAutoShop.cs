using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

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
        private decimal sumTotal = 0;
        private readonly string templateFileName = @"d:\template.docx";
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            string product = ((CheckBox)sender).Tag.ToString();
            TextBox textboxCurrentPieces = textboxPieces(checkbox(product).Tag.ToString());

            if (checkbox(product).Checked)
            {
                textboxCurrentPieces.ReadOnly = false;
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
            string product = ((TextBox)sender).Tag.ToString();
            decimal price = Convert.ToDecimal(textboxPrice(product).Text);
            int countProduct = 0;
            decimal cursum = 0;
            if (checkbox(product).Checked)
            {
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
                else
                    tbTotalShop.Text = "0";
            }
        }
        private TextBox textboxPrice(string product)
        {
            switch (product)
            {
                case "HotDog": return tbHotDogPrice;
                case "Hamburger": return tbHamburgerPrice;
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
                    sumTotal = Convert.ToInt64(tbTotalFuel.Text) + Convert.ToInt64(tbTotalShop.Text);
                    if (sumTotal>0)
                    {
                        TotalShow.Text = sumTotal.ToString();
                        payment.Enabled = true;
                    }
                    break;

                case "Payment":
                    MessageBox.Show("Оплачено " + sumTotal.ToString(),"Оплата",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   // exportWord("Сумма к оплате :" + sumTotal.ToString());

                    payment.Enabled = false;
                    tbTotalShop.Text = "0";
                    TotalShow.Text = "0";
                    tbTotalFuel.Text = "0";                    
                    tbLitr.Text = "";
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
            cbFuels.SelectedIndex = 0;
            tbLitr.Text = "";
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
        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthor author = new FormAuthor();
            author.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void tbFuel_TextChanged(object sender, EventArgs e)
        {
            int countLtrFuel = 0;
            decimal price = Convert.ToDecimal(tbPriceFuel.Text);

            if (rbLitrFuel.Checked)
            {
                if (tbLitr.Text != "")
                {
                    if (int.TryParse(tbLitr.Text, out countLtrFuel) && countLtrFuel <= 1000)
                    {
                        tbSumFuel.Text = tbTotalFuel.Text = (Convert.ToDecimal(tbPriceFuel.Text) * countLtrFuel).ToString();
                    }
                    else
                        errorMessage();
                }
                else
                {
                    resetTexBox();
                }
            }

            if (rbSumFuel.Checked)
            {
                if (tbSumFuel.Text != "")
                {
                    if (decimal.TryParse(tbSumFuel.Text, out sumFuel) && (sumFuel / price <= 1000))
                    {
                        countLtrFuel = (int)(sumFuel / price);
                        tbLitr.Text = countLtrFuel.ToString("N2");
                        tbTotalFuel.Text = sumFuel.ToString();
                    }
                    else
                        errorMessage();
                }
                else
                {
                    resetTexBox();
                }
            }
        }
        private void rbSumFuel_Click(object sender, EventArgs e)
        {
            if (rbLitrFuel.Checked)
            {
                switchRButton(false, true);               
            }
            if (rbSumFuel.Checked)
            {
                switchRButton(true, false);
            }
        }
        private void tbTotalFuel_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(tbTotalFuel.Text) + Convert.ToInt64(tbTotalShop.Text) != 0)
                btTotal.Enabled = true;
            else
                btTotal.Enabled = false;
        }
        private void switchRButton(bool litr, bool sum)
        {
            tbLitr.Text = "";
            tbSumFuel.Text = "";
            tbLitr.ReadOnly = litr;
            tbSumFuel.ReadOnly = sum;
        }
        private void resetTexBox()
        {
            tbTotalFuel.Text = "0";
            tbLitr.Text = "";
            tbSumFuel.Text = "";
        }
        private void errorMessage()
        {
            MessageBox.Show("Ограничение выдачи топлива 1000 литров!", "ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportWord(string text)
        {
            var wordapp = new Word.Application();
            wordapp.Visible = false;
            var wordDocument = wordapp.Documents.Open(templateFileName);
            replace("{name}", text, wordDocument);
            wordDocument.SaveAs2(@"d:\result.docx");
            wordapp.Visible = true;
        }

        private void replace(string stub, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }
    }
}
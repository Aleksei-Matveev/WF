using Authorization.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Authorization
{
    public partial class Form1 : Form
    {
        Image Entry = Resources.entry;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Entry;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(":");
        }

        private void pictureBox1_MouseHover(object sender, System.EventArgs e)
        {
            int EntryWidth=Entry.Width+((Entry.Width*20)/100);
            int EntryHeigth = Entry.Height+((Entry.Height * 20) / 100);

            Bitmap EntryTmp = new Bitmap(EntryWidth, EntryHeigth);
            Graphics g = Graphics.FromImage(EntryTmp);
            g.DrawImage(Entry, new Rectangle(Point.Empty, EntryTmp.Size));
            pictureBox1.Image = EntryTmp;
        }

        private void pictureBox1_MouseLeave(object sender, System.EventArgs e)
        {
            pictureBox1.Image = Entry;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDriver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            driverBindingSource.EndEdit();
            driverTableAdapter.Update(this.driverDataSet.Driver);
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.driverDataSet.Driver);
            clockStatusLabel.Text = DateTime.Now.ToShortDateString().ToString(); 
        }

      

        private void MainForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Не пугайся!", "Я тут буду! Если что, кликай правой кнопкой мышуни!",ToolTipIcon.None);
            }
        }
       

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            notifyIcon.Visible = false;
        }

        private void deleteToolStripMenuItemDataGrid_Click(object sender, EventArgs e)
        {
            driverBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            driverBindingSource.EndEdit();
            driverTableAdapter.Update(this.driverDataSet.Driver);

        }

        private void editToolStripMenuItemDataGrid_Click(object sender, EventArgs e)
        {
          
        }
    }
}

using Login.Interface;
using System.Windows.Forms;

namespace Login.View
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }   
     

        void IMainForm.ShowWindow()
        {
            this.Visible = true;
        }
        private void Exit()
        {
            if (DialogResult.Yes == MessageBox.Show("Завершение работы", "Завершить работу?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }
        private void exitTS_Click(object sender, System.EventArgs e)
        {
           Exit();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
            
        }
    }
}

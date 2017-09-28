using System;
using System.Windows.Forms;

namespace Authorization
{
    public partial class ForgotForm : Form
    {
        public ForgotForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            string code = sendMail.Send(tbEmail.Text);
            CheckCodeForm checkCodeForm = new CheckCodeForm();
            if (checkCodeForm.ShowDialog() == DialogResult.OK)
            {
                if (code == checkCodeForm.Code)
                {
                    grBoxPass.Show();                   
                }
            }           
        }        
    }
}
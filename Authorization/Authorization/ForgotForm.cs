using System;
using System.Windows.Forms;

namespace Authorization
{
    public partial class ForgotForm : Form
    {
        private bool isCheck;
        public ForgotForm()
        {
            InitializeComponent();
            isCheck = false;
            grBoxPass.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if (isCheck)
            //{
            //    SendMail sendMail = new SendMail();
            //    string code = sendMail.Send(tbEmail.Text);
            //    CheckCodeForm checkCodeForm = new CheckCodeForm();
            //    if (checkCodeForm.ShowDialog() == DialogResult.OK)
            //    {
            //        if (code == checkCodeForm.Code)
            //        {
                        grBoxPass.Show();
            //        }
            //    }
            //}
            Query.Update(tbEmail.Text, tbPassword.Text);
            this.Close();
        }        
    }
}
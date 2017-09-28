using System;
using System.Net;
using System.Net.Mail;
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
            string code=sendMail.Send();

            this.Close();
        }        
    }
}

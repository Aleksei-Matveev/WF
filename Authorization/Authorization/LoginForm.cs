using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Authorization
{
    public partial class AutorizForm : Form
    {
        
        public AutorizForm()
        {
            InitializeComponent();
           
        }

        private void PBLogin_Click(object sender, System.EventArgs e)        {

            timer1.Enabled = true;
           
            progressBar.Visible = true;
            progressBar.Maximum = 10;
            progressBar.Step = 1;
           
           
            if(Query.Check(tbLogin.Text, tbPassword.Text))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            tbError.Visible = true;
        }
        private void LLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }
        private void lLForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotForm forgotForm = new ForgotForm();
            forgotForm.ShowDialog();
            this.Show();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {           
            progressBar.Increment(+1);
            Graphics text = progressBar.CreateGraphics();
            text.DrawString("Идет проверка ....", new Font("Microsoft Sans Serif", 11, FontStyle.Regular), new SolidBrush(Color.DarkGreen), 95, 1);
            text.Dispose();
            if (progressBar.Value == 9)
            {
               
                timer1.Enabled = false;
                progressBar.Increment(+1);
               
            }
        }
    }
}
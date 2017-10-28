using System;
using System.Windows.Forms;
using Login.Interface;


namespace Login.View
{   
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();

            btnEntry.Click += new EventHandler(btnEntry_Click);
            tbLogin.KeyUp += new KeyEventHandler(keyUp_Enter);
        }

        private void keyUp_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ) 
                if (tbLogin.Focused == true)
                    tbPassword.Focus();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            EntryClick?.Invoke(this, EventArgs.Empty);
        }

        #region ILoginForm
        public string Login
        {
            get { return tbLogin.Text; }
        }
        public string Password
        {
            get { return tbPassword.Text; }
        }
        public new void Hide()
        {
            this.Visible=false;
        }
        public event EventHandler EntryClick;

        
        #endregion
    }
}
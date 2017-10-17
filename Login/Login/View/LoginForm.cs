using System;
using System.Windows.Forms;

namespace Login
{
    public interface ILoginForm
    {
        string Login { get; }
        string Password { get; }
        void Hide();

        event EventHandler EntryClick;
    }

    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();

            btnEntry.Click += new EventHandler(btnEntry_Click);
        }       

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (EntryClick != null)
                EntryClick(this, EventArgs.Empty);
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

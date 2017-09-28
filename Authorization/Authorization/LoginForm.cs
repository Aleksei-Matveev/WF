using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Authorization
{
    public partial class AutorizForm : Form
    {
        private SqlConnection sqlConnection;
        public AutorizForm()
        {
            InitializeComponent();
            this.tbLogin.GotFocus += OnFocus;
            this.tbLogin.LostFocus += OnDeFocus;
        }
        private void OnFocus(object sender, EventArgs e)
        {
            
        }
        private void OnDeFocus(object sender, EventArgs e)
        {
        
        }  
        private void PBLogin_Click(object sender, System.EventArgs e)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString= ConfigurationManager.ConnectionStrings["Registration"].ConnectionString;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM USERS	WHERE name='"+tbLogin.Text+"' AND password='"+tbPassword.Text+"'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Ошибка");
        }
        private void lLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        private void lLForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotForm forgotForm = new ForgotForm();
            forgotForm.ShowDialog();
        }
    }
}
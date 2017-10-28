using System;
using System.Windows.Forms;
using Login.BL;
using Login.BL.Services;
using Login.Presenter;
using Login.View;


namespace Login
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();
            RegisterForm registerForm = new RegisterForm();
            ForgotForm forgotForm = new ForgotForm();
            
            MessageService messageService = new MessageService();
            UserRepository database = new UserRepository(messageService);

            AppPresenter presenter = new AppPresenter(loginForm, registerForm, forgotForm, mainForm ,database, messageService);

            Application.Run(loginForm);

            
        }
    }
}

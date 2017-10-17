using System;
using System.Windows.Forms;
using Login.BL;
using Login.Presenter;

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
            MessageService messageService = new MessageService();
            WorkDatabase database = new WorkDatabase();

            LoginPresenter presenter = new LoginPresenter(loginForm, database, messageService);

            Application.Run(loginForm);
        }
    }
}

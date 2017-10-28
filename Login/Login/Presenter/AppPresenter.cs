using System;
using Login.BL.Entity;
using Login.BL.Interface;
using Login.Interface;
using System.Windows.Forms;

namespace Login.Presenter
{
    public class AppPresenter
    {
        private readonly ILoginForm _viewLogin;
        private readonly IMainForm _viewMain;
        private readonly IRegisterForm _viewRegister;
        private readonly IForgotForm _viewForgot;
        private readonly IUserRepository _database;
        private readonly IMessageService _messageService;

        private User user;

        public AppPresenter(ILoginForm viewLogin, IRegisterForm viewRegister, IForgotForm viewForgot, IMainForm viewMain, IUserRepository database,IMessageService messageService)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;
            _viewForgot = viewForgot;
            _viewRegister = viewRegister;
            _database = database;
            _messageService = messageService;

            viewLogin.EntryClick += new EventHandler(_view_EntryClick);
            
        }

       

        private void _view_EntryClick(object sender, EventArgs e)
        {
            user = new User
            {
                Login = _viewLogin.Login,
                Password = _viewLogin.Password
            };
            if (!_database.IsExistUser(user))
                _messageService.ShowError("Нет такого пользователя");
            else
            {
                _messageService.ShowMessage("Добро пожаловать");
                _viewLogin.Hide();
                _viewMain.ShowWindow();
            }
        }
    }
}

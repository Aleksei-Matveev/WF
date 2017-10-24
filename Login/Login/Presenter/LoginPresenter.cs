using System;
using Login.BL.Entity;
using Login.BL.Interface;
using Login.Interface;

namespace Login.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginForm _view;
        private readonly IWorkDatabase _database;
        private readonly IMessageService _messageService;
        private User user;

        public LoginPresenter(ILoginForm view, IWorkDatabase database,IMessageService messageService)
        {
            _view = view;
            _database = database;
            _messageService = messageService;

            view.EntryClick += new System.EventHandler(_view_EntryClick);
            
        }

       

        private void _view_EntryClick(object sender, EventArgs e)
        {
            user = new User
            {
                Login = _view.Login,
                Password = _view.Password
            };
            if (!_database.IsExistUser(user))
                _messageService.ShowError("Нет такого пользователя");
            else
            {
                _messageService.ShowMessage("Добро пожаловать");
                _view.Hide();
            }
        }
    }
}

using System;

namespace Login.Interface
{
    public interface ILoginForm
    {
        string Login { get; }
        string Password { get; }
        void Hide();

        event EventHandler EntryClick;
       
    }
}

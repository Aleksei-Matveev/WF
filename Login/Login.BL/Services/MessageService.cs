using Login.BL.Interface;
using System.Windows.Forms;

namespace Login.BL.Services
{   
    public class MessageService : IMessageService
    {
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
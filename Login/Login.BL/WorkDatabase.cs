using Login;
using Login.BL.Entity;

namespace Login.BL
{
    public interface IWorkDatabase
    {
        bool IsExist(User user);
    }

    public class WorkDatabase : IWorkDatabase
    {
        public bool IsExist(User user)
        {
            if (user.Login == "matveev")
                return true;
            return false;
        }
    }
}

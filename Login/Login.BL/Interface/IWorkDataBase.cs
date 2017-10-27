using Login.BL.Entity;

namespace Login.BL.Interface
{
    public interface IWorkDatabase
    {
        void AddUser(User user);
        void UpdatePassowd(User user);
        bool IsExistUser(User user);
        bool IsExisEmail(string email);
    }
}

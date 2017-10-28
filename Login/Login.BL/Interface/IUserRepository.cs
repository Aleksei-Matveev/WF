using Login.BL.Entity;
using System.Collections.Generic;

namespace Login.BL.Interface
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void AddUser(User item);
        void UpdatePassowd(User item);
        bool IsExistUser(User item);
        bool IsExisEmail(string email);
    }
}

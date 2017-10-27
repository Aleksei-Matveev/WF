using Login.BL.Interface;
namespace Login.BL.Entity
{

    public class User : IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

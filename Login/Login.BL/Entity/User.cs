namespace Login.BL.Entity
{
    public interface IUser
    {
        string Login { get; set; }

        string Password { get; set; }

        string Email { get; set; }
    }
    public class User : IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

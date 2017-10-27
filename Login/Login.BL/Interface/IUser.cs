namespace Login.BL.Interface
{
    public interface IUser
    {
        string Login { get; set; }

        string Password { get; set; }

        string Email { get; set; }
    }
}

public class MUser
{
    public string Name;
    public string Password;
    public string Role;
    public MUser(string name, string password, string role)
    {
        this.Name = name;
        this.Password = password;
        this.Role = role;
    }
}
namespace challenge2
{
    public class MUser
    {
        public string username;
        public string password;
        public string role;

        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
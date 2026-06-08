using System.Collections.Generic;

namespace challenge2
{
    public class MUserDL
    {
        public static List<MUser> users = new List<MUser>();

        public static void AddUser(MUser user)
        {
            users.Add(user);
        }
        public static MUser VerifyUser(string username, string password)
        {
            foreach (MUser user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
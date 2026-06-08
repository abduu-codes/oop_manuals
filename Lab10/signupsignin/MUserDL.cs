using System;
using System.Collections.Generic;
using System.IO;

public class MUserDL
{
    private static string path = "users.txt";
    public static List<MUser> usersList = new List<MUser>();

    public static void StoreUserInFile(MUser user)
    {
        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine(user.Name + "," + user.Password + "," + user.Role);
        file.Flush();
        file.Close();
    }

    public static void LoadUsersFromFile()
    {
        if (File.Exists(path))
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                MUser user = new MUser(data[0], data[1], data[2]);
                MUserDL.usersList.Add(user);
            }
            file.Close();
        }
    }

    public static MUser CheckUser(string name, string password)
    {
        foreach (var user in usersList)
        {
            if (user.Name == name && user.Password == password)
            {
                return user;
            }
        }
        return null;
    }
}
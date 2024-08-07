using System;
using System.IO;

namespace BusinessLayer
{
    public static class CurrentLogedinUser
    {


        public static clsUser currentUser { get; set; }

        public static void ClearFile()
        {
            File.WriteAllText(PATHES.LOGIN_REMEMBER_ME, String.Empty);
            
        }

        public static void SaveCurrentUserDataToFile(string password)
        {
            if (currentUser == null)
                return;

            string text = $"{currentUser.UserName}/##/{password}";
            File.WriteAllText(PATHES.LOGIN_REMEMBER_ME, text);
        }

        public static string[] ReadRememberMeUserData()
        {
            string[] userData = new string[2];

            string input = File.ReadAllText(PATHES.LOGIN_REMEMBER_ME);

            if (!String.IsNullOrEmpty(input))
            {
                string[] splitData = input.Split(new string[] { "/##/" }, StringSplitOptions.None);


                userData[0] = splitData[0];
                userData[1] = splitData[1];
            }


            return userData;
        }


    }
}

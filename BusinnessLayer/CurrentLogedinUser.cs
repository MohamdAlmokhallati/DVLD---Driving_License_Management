using System;
using System.IO;
using Microsoft.Win32;

namespace BusinessLayer
{
    public static class CurrentLogedinUser
    {


        public static clsUser currentUser { get; set; }

        public static void ClearFile()
        {
            try
            {
                Registry.SetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_User_Name, string.Empty, RegistryValueKind.String);
                Registry.SetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_PASSWORD, string.Empty, RegistryValueKind.String);
            }
            catch (Exception)
            {
                // Handle exceptions as needed (logging, rethrowing, etc.)
            }
        }

        public static void SaveCurrentUserDataToFile(string password)
        {
            if (currentUser == null)
                return;
            string userName = currentUser.UserName;
            try
            {

                Registry.SetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_User_Name, userName, RegistryValueKind.String);
                Registry.SetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_PASSWORD, password, RegistryValueKind.String);


            }
            catch
            (Exception)
            {

            }

        }

        public static string[] ReadRememberMeUserData()
        {
            string[] userData = new string[2];

            string UserName = Registry.GetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_User_Name, null) as string;
            string Password = Registry.GetValue(PATHES.KEY_PATH, PATHES.KEY_PATH_PASSWORD, null) as string;
          
            if (!String.IsNullOrEmpty(UserName))
                userData[0] = UserName;
            if (!String.IsNullOrEmpty(Password))
                userData[1] = Password;

            return userData;
        }


    }
}

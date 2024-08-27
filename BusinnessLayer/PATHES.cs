using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class PATHES
    {
        public static string KEY_PATH = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_DrivingLicenseManagement";
        public static string KEY_PATH_User_Name = "User_Name";
        public static string KEY_PATH_PASSWORD = "Password";

        public static string SELF_PHOTOS_FOLDER = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\DVLDSelfPhotos\";
    }
}

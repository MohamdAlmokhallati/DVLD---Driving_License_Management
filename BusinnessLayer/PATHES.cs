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
        public static string LOGIN_REMEMBER_ME = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\RememberMEFile.txt";


        public static string SELF_PHOTOS_FOLDER = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\DVLDSelfPhotos\";
    }
}

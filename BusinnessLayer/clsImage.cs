using System;
using System.IO;

namespace BusinessLayer
{
    public class clsImage
    {
        public static bool RemoveImage(string imagePath)
        {
            bool IsDeleted = false;

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                IsDeleted = true;
            }

            return IsDeleted;
        }
        public static string ChangeImage(string oldPhoto, string NewPhoto)
        {


            if (!String.IsNullOrEmpty(NewPhoto))
            {
                if (System.IO.File.Exists(NewPhoto))
                    System.IO.File.Delete(NewPhoto);

                File.Copy(oldPhoto, NewPhoto, true);
                return NewPhoto;
            }
            else
            {
                return SaveImageToFile(oldPhoto);
            }

        }




        public static string SaveImageToFile(string sourcePhoto)
        {
            Guid guid = Guid.NewGuid();
            FileInfo fileInfo = new FileInfo(sourcePhoto);
            string DVLDSelfPhotos = PATHES.SELF_PHOTOS_FOLDER + guid.ToString() + fileInfo.Extension;



            try
            {
                File.Copy(sourcePhoto, DVLDSelfPhotos, true);
                return DVLDSelfPhotos;
            }
            catch (IOException)
            {
                //TODO:File handle error
                return "";
            }



        }
    }

}

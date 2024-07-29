using System;
using System.IO;

namespace BusinessLayer
{
    public class clsImage
    {

        public static string ChangeImage(string sourcePhoto, string imagePath)
        {


            if (!String.IsNullOrEmpty(imagePath))
            {
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);

                File.Copy(sourcePhoto, imagePath, true);
                return imagePath;
            }
            else
            {
                return SaveImageToFile(sourcePhoto);
            }

        }

        public static string SaveImageToFile(string sourcePhoto)
        {
            Guid guid = Guid.NewGuid();
            string DVLDSelfPhotos = PATHES.SELF_PHOTOS_FOLDER + guid.ToString() + ".jpg";



            try
            {
                File.Copy(sourcePhoto, DVLDSelfPhotos, true);
                return DVLDSelfPhotos;
            }
            catch (IOException iox)
            {
                //TODO:File handle error
                Console.WriteLine(iox.Message);
                return null;
            }



        }
    }

}

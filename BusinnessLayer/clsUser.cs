using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsUser : clsPerson
    {

        public int UserID { get; private set; }


        public string UserName { get; set; }

        private string encryptedPassword; // Backing field for storing the encrypted password

        public string Password
        {
            get
            {
                return EncryptionHelper.Decrypt(encryptedPassword);
            }
            set
            {
                encryptedPassword = EncryptionHelper.Encrypt(value);
            }
        }

        public bool IsActive { get; set; }






        public clsUser(string userName, string password, bool isActiv
        , clsPerson person) :

            this(-1,userName,password,isActiv,person.PersonID, person.FirstName, person.SecondName,
            person.ThirdName, person.LastName, person.DateOfBirth,
             person.Gender, person.Address, person.NationalNo, person.Phone, person.Email,
            person.Country, person.ImagePath)
        {
        }






        private clsUser(int userID, string userName, string password, bool isActiv
        , int personID, string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth,
            bool gender, string address, string nationalNo, string phone, string email,
            string country, string imagePath) :

            base(personID, firstName, secondName,
            thirdName, lastName, dateOfBirth,
             gender, address, nationalNo, phone, email,
            country, imagePath)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            IsActive = isActiv;
        }



        public clsUser(string userName, string password, bool isActiv
        , string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth,
            bool gender, string address, string nationalNo, string phone, string email,
            string country, string imagePath) :

            this(-1,userName,password,isActiv,-1,firstName, secondName,
            thirdName, lastName, dateOfBirth,
             gender, address, nationalNo, phone, email,
            country, imagePath)
        {
        }

        public static bool IsExist(string userName, string password)
        {
            return UserDB.IsExist(userName, EncryptionHelper.Encrypt(password));
        }

        public static clsUser getUser(int userID)
        {


            bool isActive = false;
            string userName = string.Empty;
            string password = string.Empty;


            int personID = 0;
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.MinValue;
            bool gender = false;
            string address = string.Empty;
            string nationalNo = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            string country = string.Empty;
            string imagePath = string.Empty;

            // Call the getUser method

            if(!UserDB.getUserById(ref userID, ref userName, ref password, ref isActive,
                ref personID, ref firstName, ref secondName, ref thirdName, ref lastName,
                ref dateOfBirth, ref gender, ref address, ref nationalNo, ref phone,
                ref email, ref country, ref imagePath))
            {
                return null;
            }

            return new clsUser(userID, userName, password, isActive, personID, firstName, secondName,
                thirdName, lastName, dateOfBirth, gender, address, nationalNo, phone, email, country, imagePath);

        }

        public static clsUser getUser(string userName, string password)
        {
            password = EncryptionHelper.Encrypt(password);
            int userID = 1; // Example userID you want to retrieve
            bool isActive = false;

            int personID = 0;
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.MinValue;
            bool gender = false;
            string address = string.Empty;
            string nationalNo = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            string country = string.Empty;
            string imagePath = string.Empty;

            // Call the getUser method

            UserDB.getUser(ref userID, ref userName, ref password, ref isActive,
                ref personID, ref firstName, ref secondName, ref thirdName, ref lastName,
                ref dateOfBirth, ref gender, ref address, ref nationalNo, ref phone,
                ref email, ref country, ref imagePath);

            return new clsUser(userID, userName, password, isActive, personID, firstName, secondName,
                thirdName, lastName, dateOfBirth, gender, address, nationalNo, phone, email, country, imagePath);
        }


        public static DataTable GetAllUsers()
        {
            return UserDB.GetAllUsers();
        }


        public bool Save()
        {
            int newUserID = -1;

            int newPersonID = -1;

            if (UserID > 0)
            {
                newUserID = this.UserID;
            }

            if (this.PersonID > 0)
            {
                newPersonID = this.PersonID;
            }

            bool isSaved = UserDB.Save(ref newPersonID, ref newUserID, UserName, encryptedPassword, IsActive);

            PersonID = newPersonID;
            UserID = newUserID;

            return isSaved;
        }



        public enum enFilterby
        {
            UserID = 1, Username, FullName, IsActive
        }


        public static string WriteDataViewFilterQuery(enFilterby filterby, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return "";
            }

            switch (filterby)
            {
                case enFilterby.UserID:
                    return $"UserID = {value}";

                case enFilterby.Username:
                    return $"UserName Like '{value}%'";

                case enFilterby.FullName:
                    return $"FullName Like '{value}%'";

                case enFilterby.IsActive:
                    return $"IsActive = {value}";

                default:
                    return "";
            }

        }


        public static bool ChangeActive(int userID, bool isActive)
        {
            return UserDB.ChangeActive(userID, isActive);
        }

        public bool IsPasswordCurrect(string password)
        {
            return EncryptionHelper.Encrypt(password) == this.Password;
        }


    }
}
using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsPerson
    {
        public int PersonID { get; protected set; }

        public int getPersonID()
        {
            return PersonID;
        }



        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string NationalNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }

        protected clsPerson(int personID, string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth,
            bool gender, string address, string nationalNo, string phone, string email,
            string country, string imagePath)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            NationalNo = nationalNo;
            Phone = phone;
            Email = email;
            Country = country;
            ImagePath = imagePath;
        }

        public clsPerson(string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth,
            bool gender, string address, string nationalNo, string phone, string email,
            string country, string imagePath)
        {
            PersonID = -1;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            NationalNo = nationalNo;
            Phone = phone;
            Email = email;
            Country = country;
            ImagePath = imagePath;
        }




        public string FullName()
        {
            return $"{FirstName} {SecondName} {ThirdName} {LastName}";
        }



        public static DataTable GetAllPepole()
        {
            return PersonDB.GetAllPepol();
        }




        public enum enFilterby
        {
            PersonID = 1, NationalNo, FirstName, SecondName, Phone,
            ThirdName, LastName, Nationality, Gender, Email
        }


        public static string WriteDataViewFilterQuery(enFilterby filterby, string value)
        {

            if (String.IsNullOrEmpty(value))
            {
                return "";
            }

            switch (filterby)
            {
                case enFilterby.PersonID:
                    return $"PersonID = {value}";

                case enFilterby.NationalNo:
                    return $"NationalNo Like '{value}%'";

                case enFilterby.FirstName:
                    return $"FirstName Like '{value}%'";

                case enFilterby.SecondName:
                    return $"SecondName Like '{value}%'";

                case enFilterby.Phone:
                    return $"Phone Like '{value}%'";

                case enFilterby.ThirdName:
                    return $"ThirdName Like '{value}%'";

                case enFilterby.LastName:
                    return $"LastName Like '{value}%'";

                case enFilterby.Nationality:
                    return $"NationalityCountryID = {value}";

                case enFilterby.Gender:
                    return $"Gendor like '{value}%'";

                case enFilterby.Email:
                    return $"Email = '{value}'%";

                default:
                    return "";

            }



        }


        public bool Save()
        {
            int newPersonID = -1;
            if (PersonID > 0)
            {
                newPersonID = this.PersonID;
            }
            bool isSaved = PersonDB.Save(ref newPersonID, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, NationalNo, Phone, Email, clsCountry.GetCountryID(Country), ImagePath);

            PersonID = newPersonID;

            return isSaved;
        }

        public static clsPerson GetPerson(string NationalNo)
        {
            int personID = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            bool gender = true;
            string address = "";
            string phone = "";
            string email = "";
            string country = "";
            string imagePath = "";


            PersonDB.getPersonBynationalNo(ref personID, ref firstName, ref secondName, ref thirdName,
            ref lastName, ref dateOfBirth, ref gender, ref address, ref NationalNo, ref phone,
                ref email, ref country, ref imagePath);

            return new clsPerson(personID, firstName, secondName, thirdName,
                lastName, dateOfBirth, gender, address, NationalNo, phone,
                email, country, imagePath);
        }



        public static clsPerson GetPerson(int personID)
        {
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            bool gender = true;
            string address = "";
            string nationalNo = "";
            string phone = "";
            string email = "";
            string country = "";
            string imagePath = "";


            PersonDB.getPersonByID(ref personID, ref firstName, ref secondName, ref thirdName,
            ref lastName, ref dateOfBirth, ref gender, ref address, ref nationalNo, ref phone,
                ref email, ref country, ref imagePath);

            return new clsPerson(personID, firstName, secondName, thirdName,
                lastName, dateOfBirth, gender, address, nationalNo, phone,
                email, country, imagePath);
        }


        public static bool IsNationalNoValid(string nationalNo)
        {
            return PersonDB.IsNationalNoValid(nationalNo);
        }

        public static bool Delete(int personID)
        {
            return PersonDB.Delete(personID);
        }

        public bool IsUser()
        {
            return PersonDB.IsUser(this.getPersonID());
        }


        public bool HasActiveApp(int ClassID)
        {
            return PersonDB.HasActiveApp(this.PersonID, ClassID);
        }

        public bool HasOpenedAppointment(int ApplicationID, int TestTypeID)
        {
            return PersonDB.HasOpenedAppointment(ApplicationID, TestTypeID);
        }

        public bool HasLicense(int LicenseClassID)
        {
            return PersonDB.HasLicense(this.PersonID, LicenseClassID);
        }

        public bool IsDriver()
        {
            return PersonDB.IsDriver(this.PersonID);
        }



    }
}

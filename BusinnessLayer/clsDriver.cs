using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsDriver : clsPerson
    {


        public int DriverID { get; private set; }
        public clsUser CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }



        public clsDriver(clsUser createdBy, DateTime createdDate, clsPerson person)
        : this(-1, createdBy, createdDate, person)
        {
        }

        protected clsDriver(int driverID, clsUser createdBy, DateTime createdDate, clsPerson person)
            : base(person.PersonID, person.FirstName, person.SecondName, person.ThirdName,
          person.LastName, person.DateOfBirth, person.Gender, person.Address, person.NationalNo,
          person.Phone, person.Email, person.Country, person.ImagePath)
        {
            DriverID = driverID;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }

        public bool Save()
        {
            int driverID = -1;

            if (this.DriverID > 0)
            {
                driverID = this.DriverID;
            }




            bool isSaved = DriverDB.Save(ref driverID, this.PersonID, this.CreatedBy.UserID, this.CreatedDate);
            this.DriverID = driverID;


            return isSaved;

        }



        public static clsDriver GetDriver(int driverID)
        {
            int DriverID = driverID;

            int userID = -1;
            clsUser createdBy = null;

            DateTime createdDate = DateTime.Now;

            int personID = -1;
            clsPerson person = null;


            DriverDB.GetDriver(ref DriverID, ref userID, ref createdDate, ref personID);

            createdBy = clsUser.getUser(userID);
            person = clsPerson.GetPerson(personID);




            return new clsDriver(DriverID, createdBy, createdDate, person);
        }

        public static clsDriver GetDriverByPersonID(int PersonID)
        {
            int DriverID = -1;

            int userID = -1;
            clsUser createdBy = null;

            DateTime createdDate = DateTime.Now;

            clsPerson person = clsPerson.GetPerson(PersonID);


            DriverDB.GetDriverByPersonID(person.PersonID, ref userID, ref createdDate, ref DriverID);

            createdBy = clsUser.getUser(userID);



            return new clsDriver(DriverID, createdBy, createdDate, person);
        }

        public static DataTable GetAllDrivers()
        {
            return DriverDB.GetAllDrivers();
        }

    }
}

using System;
using DataLayer;


namespace BusinessLayer
{
    public class clsApplication
    {

        //1-New 2-Cancelled 3-Completed
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { get; private set; }
        public clsPerson Person { get; set; }

        public DateTime ApplicationDate { get; set; }
        public clsApplicationType ApplicationType { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public clsUser CreatedBy { get; set; }



        public clsApplication(clsPerson person, DateTime applicationDate,
            clsApplicationType applicationType, DateTime lastStatusDate, enApplicationStatus applicationStatus, decimal paidFees,
            clsUser createdBy)
            : this(-1, person, applicationDate, applicationType, lastStatusDate, applicationStatus, paidFees, createdBy)
        {
        }



        protected clsApplication(int applicationID, clsPerson person, DateTime applicationDate,
            clsApplicationType applicationType, DateTime lastStatusDate, enApplicationStatus applicationStatus, decimal paidFees,
            clsUser createdBy)
        {
            ApplicationID = applicationID;
            Person = person;
            ApplicationDate = applicationDate;
            ApplicationType = applicationType;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedBy = createdBy;
        }



        public bool SaveApp()
        {



            int newAppID = -1;



            if (ApplicationID > 0)
            {
                newAppID = this.ApplicationID;
            }


            bool isSaved = ApplicationDB.Save(ref newAppID, this.Person.getPersonID(), this.ApplicationDate,
                this.ApplicationType.ApplicationTypID, (int)ApplicationStatus, DateTime.Now,
                this.PaidFees, this.CreatedBy.getUserID());

            this.ApplicationID = newAppID;


            return isSaved;
        }

        public bool HasFaledTest(int TestTypeID)
        {
            return ApplicationDB.HasFaledTest(this.ApplicationID, TestTypeID);
        }

        public static bool ChangeApplicationStatus(int ApplicationID, int StatusID)
        {
            return ApplicationDB.ChangeApplicationStatus(ApplicationID, StatusID);
        }

        public static bool CancleApplication(int ApplicationID)
        {
            return ChangeApplicationStatus(ApplicationID, 2);
        }

        public static clsApplication GetApplication(int ApplicationID)
        {
            int applicationID = ApplicationID;

            int personID = -1;
            clsPerson person = null;

            DateTime applicationDate = DateTime.Now;

            int applicationTypeID = -1;
            clsApplicationType applicationType = null;

            DateTime lastStatusDate = DateTime.Now;

            int applicationStatusNumber = -1;
            enApplicationStatus applicationStatus = default;
            decimal paidFees = 0;

            int userID = -1;
            clsUser createdBy = null;

            ApplicationDB.GetApplication(ref applicationID, ref personID, ref applicationDate,
                ref applicationTypeID, ref lastStatusDate, ref applicationStatusNumber, ref paidFees,
                ref userID);

            person = clsPerson.GetPerson(personID);
            applicationType = clsApplicationType.GetApplicationType(applicationTypeID);
            createdBy = clsUser.getUser(userID);


            return new clsApplication(ApplicationID, person, applicationDate, applicationType,
                lastStatusDate, applicationStatus, paidFees, createdBy);
        }


    }
}

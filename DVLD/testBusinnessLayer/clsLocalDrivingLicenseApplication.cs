using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public int LDLid { get; private set; }

        public int PassedTets { get; set; }

        public clsLicenseClass LicenseClass { get; set; }



        public clsLocalDrivingLicenseApplication(clsPerson person, DateTime applicationDate,
        clsApplicationType applicationType, DateTime lastStatusDate, clsApplication.enApplicationStatus applicationStatus, decimal paidFees,
        clsUser createdBy, clsLicenseClass licenseClass, int passedTets)
            : this(-1, person, applicationDate, applicationType, lastStatusDate, applicationStatus, paidFees,
                 createdBy, -1, licenseClass, passedTets)
        {
        }

        private clsLocalDrivingLicenseApplication(int appID, clsPerson person, DateTime applicationDate,
        clsApplicationType applicationType, DateTime lastStatusDate, clsApplication.enApplicationStatus applicationStatus, decimal paidFees,
        clsUser createdBy, int ldlid, clsLicenseClass licenseClass, int passedTets)
        : base(appID, person, applicationDate, applicationType, lastStatusDate, applicationStatus, paidFees, createdBy)
        {
            LDLid = ldlid;
            LicenseClass = licenseClass;
            PassedTets = passedTets;
        }


        public static DataTable GetAllLocalApps()
        {
            return LocalDrivingLicenseApplicationDB.GetAllLocalApps();
        }


        public bool Save()
        {

            int newldlaID = -1;

            int newApplicationID = -1;

            if (this.SaveApp())
            {
                newApplicationID = this.ApplicationID;
            }



            if (LDLid > 0)
            {
                newldlaID = this.LDLid;
            }


            bool isSaved = LocalDrivingLicenseApplicationDB.Save(ref newldlaID, ref newApplicationID, LicenseClass.LicenseClassID);

            LDLid = newldlaID;


            return isSaved;

        }

        public enum enFilterby
        {
            LDLAppID = 1, NationalNo, FullName, Status
        }


        public static string WriteDataViewFilterQuery(enFilterby filter, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return "";
            }
            switch (filter)
            {
                case enFilterby.LDLAppID:
                    return $"LocalDrivingLicenseApplicationID = {value}";
                case enFilterby.NationalNo:
                    return $"NationalNo Like '{value}%'";
                case enFilterby.FullName:
                    return $"FullName Like '{value}%'";
                case enFilterby.Status:
                    return $"Status Like '{value}%'";
                default:
                    return "";
            }
        }




        public static clsLocalDrivingLicenseApplication GetLocalDrivingApp(int localAppId)
        {
            int ldlid = localAppId;
            int appId = -1;

            int personID = -1;
            clsPerson person = null;



            DateTime applicationDate = DateTime.Now;
            DateTime lastAppDate = DateTime.Now;

            int applicationTypeID = -1;
            clsApplicationType applicationType = null;

            int applicationStatusNumber = -1;
            clsApplication.enApplicationStatus applicationStatus = default;
            decimal paidFees = 0;


            int UserID = -1;
            clsUser createdBy = null;

            int licenseClassid = -1;
            clsLicenseClass licenseClass = null;

            int passedTets = 0;

            LocalDrivingLicenseApplicationDB.getLDLA(ref ldlid, ref appId, ref personID,
                ref applicationDate, ref applicationTypeID, ref paidFees, ref UserID,
                ref licenseClassid, ref applicationStatusNumber, ref lastAppDate, ref passedTets);

            person = clsPerson.GetPerson(personID);
            applicationType = clsApplicationType.GetApplicationType(applicationTypeID);
            createdBy = clsUser.getUser(UserID);
            licenseClass = clsLicenseClass.GetLicenseClass(licenseClassid);






            clsLocalDrivingLicenseApplication ldla = new clsLocalDrivingLicenseApplication(
               appId, person, applicationDate, applicationType, lastAppDate, applicationStatus,
               paidFees, createdBy, ldlid, licenseClass, passedTets);



            return ldla;
        }



    }
}

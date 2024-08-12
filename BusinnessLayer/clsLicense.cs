using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsLicense
    {
        public enum enIssueReason { FirstTime=1 , Renew=2 , ReplacementForDamaged=3 , ReplacementForLost=4 }
        public int LicenseId { get; private set; }
        public clsApplication Application { get; set; }
        public clsDriver Driver { get; set; }
        public clsLicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public clsUser CreatedBy { get; set; }


        public clsLicense(clsApplication application, clsDriver driver,
            clsLicenseClass licenseClass, DateTime issueDate, DateTime expirationDate,
            string notes, decimal paidFees, bool isActive, enIssueReason issueReason, clsUser createdBy)
            : this(-1, application, driver, licenseClass, issueDate, expirationDate, notes,
                 paidFees, isActive, issueReason, createdBy)
        {

        }


        protected clsLicense(int licenseId, clsApplication application, clsDriver driver,
            clsLicenseClass licenseClass, DateTime issueDate, DateTime expirationDate,
            string notes, decimal paidFees, bool isActive, enIssueReason issueReason, clsUser createdBy)
        {
            LicenseId = licenseId;
            Application = application;
            Driver = driver;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedBy = createdBy;
        }


        public bool Save()
        {
            int licenseID = -1;

            if (this.LicenseId > 0)
            {
                licenseID = this.LicenseId;
            }




            bool isSaved = LicenseDB.Save(ref licenseID, this.Application.ApplicationID, this.Driver.DriverID,
                this.LicenseClass.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes,
                this.PaidFees, this.IsActive,(int) this.IssueReason, this.CreatedBy.UserID);

            this.LicenseId = licenseID;


            return isSaved;
        }
        public static clsLicense GetLicenseByLocalApplicationID(int LocalApplicationID)
        {
            int licenseID = -1;
            LicenseDB.GetLicenseIDByLocalApplicationID(ref licenseID, LocalApplicationID);


            return GetLicense(licenseID);
        }




        public static clsLicense GetLicense(int LicenseID)
        {
            int licenseID = LicenseID;

            int applicationID = -1;
            clsApplication application = null;

            int driverID = -1;
            clsDriver driver = null;

            int LicenseClassID = -1;
            clsLicenseClass licenseClass = null;

            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = 1;

            int userID = -1;
            clsUser createdBy = null;


            bool licenseExists =  LicenseDB.GetLicense(ref licenseID, ref applicationID, ref driverID, ref LicenseClassID,
               ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason,
               ref userID);

            if(!licenseExists)
            {
                return null;
            }



            application = clsApplication.GetApplication(applicationID);
            driver = clsDriver.GetDriver(driverID);
            licenseClass = clsLicenseClass.GetLicenseClass(LicenseClassID);
            createdBy = clsUser.getUser(userID);



            return new clsLicense(licenseID, application, driver, licenseClass, issueDate, expirationDate,
                notes, paidFees, isActive,(enIssueReason) issueReason, createdBy);
        }


        public static DataTable GetAllLocalLicenseOfPerson(int personID)
        {
            return LicenseDB.GetAllLicenseOfPerson(personID);
        }

        public static DataTable GetAllInternationalLicenseOfPerson(int personID)
        {
            return LicenseDB.GetAllInternationalLicenseOfPerson(personID);
        }



    }
}

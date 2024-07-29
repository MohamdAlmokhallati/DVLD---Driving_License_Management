using DataLayer;
using System;
using System.Data;
using System.Runtime.ExceptionServices;

namespace BusinessLayer
{
    public class clsInternationalLicense : clsApplication
    {


        public int InternationalLicenseID { get; private set; }
        public clsDriver Driver { get; set; }
        public int IssedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public clsUser InternationalLicenseCreatedBy { get; set; }







        public clsInternationalLicense(clsDriver driver,
    int issedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,
    bool isActive, clsUser internationalLicenseCreatedBy, clsApplication application)
    : this(-1, driver, issedUsingLocalLicenseID, issueDate, expirationDate, isActive, internationalLicenseCreatedBy
         , application.ApplicationID, application.Person, application.ApplicationDate, application.ApplicationType, application.LastStatusDate,
          application.ApplicationStatus, application.PaidFees, application.CreatedBy)
        {
        }


        public clsInternationalLicense(clsDriver driver,
            int issedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,
            bool isActive, clsUser internationalLicenseCreatedBy, clsPerson person,
            DateTime applicationDate, clsApplicationType applicationType, DateTime lastStatusDate,
    string applicationStatus, decimal paidFees, clsUser createdBy)
            : this(-1, driver, issedUsingLocalLicenseID, issueDate, expirationDate, isActive, internationalLicenseCreatedBy
                 , -1, person, applicationDate, applicationType, lastStatusDate, applicationStatus, paidFees, createdBy)
        {
        }

        private clsInternationalLicense(int internationalLicenseID, clsDriver driver,
            int issedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,
            bool isActive, clsUser internationalLicenseCreatedBy, int applicationID, clsPerson person,
            DateTime applicationDate, clsApplicationType applicationType, DateTime lastStatusDate,
    string applicationStatus, decimal paidFees, clsUser createdBy)
        : base(applicationID, person, applicationDate, applicationType, lastStatusDate,
        applicationStatus, paidFees, createdBy)
        {
            InternationalLicenseID = internationalLicenseID;
            Driver = driver;
            IssedUsingLocalLicenseID = issedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            InternationalLicenseCreatedBy = internationalLicenseCreatedBy;
        }


        public static DataTable GetAllInternationalLicenses()
        {
            return InternationalLicenseDB.GetAllInternationalLicenses();
        }

        public bool SaveLicense()
        {
            int licenseID = -1;

            if (this.InternationalLicenseID > 0)
            {
                licenseID = this.InternationalLicenseID;
            }


            bool isSaved = InternationalLicenseDB.Save(ref licenseID,this.ApplicationID,Driver.DriverID,IssedUsingLocalLicenseID,
                IssueDate,ExpirationDate,IsActive, InternationalLicenseCreatedBy.getUserID());

            this.InternationalLicenseID = licenseID;

            return isSaved;
        }









    }
}

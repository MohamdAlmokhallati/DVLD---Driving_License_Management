using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsDetainedLicense:clsLicense
    {


        public int DetainedLicenseID { get; private set; }
        public DateTime DetainDate { get;  set; }
        public decimal FineFees { get; set; }
        public clsUser DetainBy { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public clsUser ReleasedByUser { get; set; }
        public clsApplication ReleaseApplication { get; set; }



        private clsDetainedLicense(int detainedLicenseID, DateTime detainDate, decimal fineFees
            ,clsUser detainBy, bool isReleased, DateTime releaseDate,
            clsUser releasedByUser, clsApplication releaseApplication,
             clsLicense license)
            : base(license.LicenseId, license.Application, license.Driver, license.LicenseClass,
                  license.IssueDate, license.ExpirationDate, license.Notes,
                  license.PaidFees, license.IsActive, license.IssueReason, license.CreatedBy)
        {
            DetainedLicenseID = detainedLicenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            DetainBy = detainBy;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUser = releasedByUser;
            ReleaseApplication = releaseApplication;
        }


        public clsDetainedLicense( DateTime detainDate, decimal fineFees
            , clsUser detainBy, bool isReleased, DateTime releaseDate,
            clsUser releasedByUser, clsApplication releaseApplication,
            clsLicense license)
            :this(-1,detainDate,fineFees,detainBy,isReleased,releaseDate,releasedByUser,
                 releaseApplication, license)
        {
        }




        public bool SaveDetainedLicense()
        {
            int detainLicenseID = -1;

            if (this.DetainedLicenseID > 0)
            {
                detainLicenseID = this.DetainedLicenseID;
            }


            int releasedByUser = ReleasedByUser == null ? -1 : ReleasedByUser.UserID;
            int releaseApplication = ReleaseApplication == null ? -1 : ReleaseApplication.ApplicationID;

            bool isSaved = DetainedLicenseDB.Save(ref detainLicenseID,this.LicenseId,DetainDate,
                FineFees,DetainBy.UserID,IsReleased,ReleaseDate, releasedByUser, releaseApplication);

            this.DetainedLicenseID = detainLicenseID;


            return isSaved;
        }


        public static bool IsDetained(int LicenesID)
        {
            return DetainedLicenseDB.IsDetained(LicenesID);
        }

        public static clsDetainedLicense GetDetainedLicense(int licenseID)
        {
            int detainedLicenseID = -1;
            DateTime detainDate = default;
            decimal fineFees = 0;

            int detainByID = -1;
            clsUser detainBy = null;

            bool isReleased = false;
            DateTime releaseDate = default;

            int releasedByUserID = -1;
            clsUser releasedByUser = null;


            int releaseApplicationID = -1;
            clsApplication releaseApplication = null;


            int LicenseID = licenseID;
            clsLicense license = null;


            bool IsFound = DetainedLicenseDB.GetDetainedLicense(ref detainedLicenseID,
                ref detainDate,ref fineFees,ref detainByID,ref isReleased,ref releaseDate, ref releasedByUserID,
                ref releaseApplicationID,ref LicenseID);

            if (!IsFound)
                return null;

            detainBy = clsUser.getUser(detainByID);
            if(releasedByUserID > 0)
                releasedByUser = clsUser.getUser(releasedByUserID);

            if(releaseApplicationID > 0)
            releaseApplication = clsApplication.GetApplication(releaseApplicationID);

            license = clsLicense.GetLicense(LicenseID);


            return new clsDetainedLicense(detainedLicenseID,detainDate,fineFees,detainBy,
                isReleased,releaseDate,releasedByUser,releaseApplication,license);
        }

        public static DataTable GetAllDetainedLicense()
        {
            return DetainedLicenseDB.GetAllDetainedLicense();
        }

    }
}

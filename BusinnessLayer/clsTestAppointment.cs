using DataLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsTestAppointment
    {

        public int TestAppointmentID { get; private set; }

        public clsTestType TestType { get; set; }

        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public clsUser CreatedBy { get; set; }
        public bool IsLocked { get; set; }


        public clsTestAppointment(clsTestType testType,
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication,
            DateTime appointmentDate, decimal paidFees, clsUser createdBy, bool isLocked)
            : this(-1, testType, localDrivingLicenseApplication, appointmentDate, paidFees, createdBy, isLocked)
        {
        }



        private clsTestAppointment(int testAppointmentID, clsTestType testType,
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication,
            DateTime appointmentDate, decimal paidFees, clsUser createdBy, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestType = testType;
            LocalDrivingLicenseApplication = localDrivingLicenseApplication;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedBy = createdBy;
            IsLocked = isLocked;
        }


        public static DataTable GetAllPersonAppointment(int personID, int TestTypeID)
        {
            return TestAppointmentDB.GetAllPersonAppointment(personID, TestTypeID);
        }

        public bool Save()
        {
            int newAppointmentID = -1;

            if (this.TestAppointmentID > 0)
            {
                newAppointmentID = this.TestAppointmentID;
            }

            bool isSaved = TestAppointmentDB.Save(ref newAppointmentID, TestType.TestTypeID, LocalDrivingLicenseApplication.LDLid,
                                                AppointmentDate, PaidFees, CreatedBy.UserID, IsLocked);

            this.TestAppointmentID = newAppointmentID;

            return isSaved;
        }

        public static clsTestAppointment getTestAppointment(int testAppointmentID)
        {

            int testAppointmentId = testAppointmentID;
            int testTypeID = -1;
            int ldlaID = -1;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int userid = -1;
            bool islocked = false;

            TestAppointmentDB.getTestAppointment(ref testAppointmentId, ref testTypeID, ref ldlaID,
                ref appointmentDate, ref paidFees, ref userid, ref islocked);

            clsTestType testType = clsTestType.GetTestType(testTypeID);
            clsLocalDrivingLicenseApplication ldla = clsLocalDrivingLicenseApplication.GetLocalDrivingApp(ldlaID);
            clsUser user = clsUser.getUser(userid);



            return new clsTestAppointment(testAppointmentId, testType, ldla,
                 appointmentDate, paidFees, user, islocked);
        }

        public bool LockAppointment()
        {
            return TestAppointmentDB.LockAppointment(this.TestAppointmentID);

        }



    }
}

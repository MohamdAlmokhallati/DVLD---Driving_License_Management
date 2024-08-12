using DataLayer;

namespace BusinessLayer
{
    public class clsTest : clsTestType
    {


        public int TestID { get; private set; }

        public clsTestAppointment TestAppointment { get; set; }

        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public clsUser CreatedBy { get; set; }

        public clsTest(clsTestAppointment testAppointment, bool testResult, string notes,
            clsUser createdBy, clsTestType testType)
            : this(-1, testAppointment, testResult, notes, createdBy, -1, testType.Title,
                 testType.Description, testType.Fees)
        {
        }

        private clsTest(int testID, clsTestAppointment testAppointment, bool testResult,
            string notes, clsUser createdBy, int testTypeID, string title, string description, decimal fees)
            : base(testTypeID, title, description, fees)
        {
            TestID = testID;
            TestAppointment = testAppointment;
            TestResult = testResult;
            Notes = notes;
            CreatedBy = createdBy;
        }

        public bool Save()
        {
            int testID = -1;

            if (TestID > 0)
            {
                testID = TestID;
            }




            bool isSaved = TestDB.Save(ref testID, TestAppointment.TestAppointmentID, TestResult, Notes, CreatedBy.UserID);



            this.TestID = testID;

            if (isSaved)
            {
                this.TestAppointment.LockAppointment();
            }


            return isSaved;

        }




    }
}

using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsTestType
    {

        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestType(string title, string description, decimal fees)
        {
            TestTypeID = -1;
            Title = title;
            Description = description;
            Fees = fees;
        }

        protected clsTestType(int testTypeID, string title, string description, decimal fees)
        {
            TestTypeID = testTypeID;
            Title = title;
            Description = description;
            Fees = fees;
        }




        public static clsTestType GetTestType(int testTypeID)
        {
            string title = string.Empty;
            string description = string.Empty;
            decimal fees = 0;




            TestTypeDB.GetTestTypes(ref testTypeID, ref title, ref description, ref fees);


            return new clsTestType(testTypeID, title, description, fees);
        }




        public static DataTable GetAllTestTypes()
        {
            return TestTypeDB.GetAllTestTypes();
        }

        public bool Save()
        {
            int testTypeID = -1;

            if (this.TestTypeID > 0)
            {
                testTypeID = this.TestTypeID;
            }


            bool isSaved = TestTypeDB.Save(ref testTypeID, this.Title, this.Description, this.Fees);

            this.TestTypeID = testTypeID;

            return isSaved;
        }

    }
}

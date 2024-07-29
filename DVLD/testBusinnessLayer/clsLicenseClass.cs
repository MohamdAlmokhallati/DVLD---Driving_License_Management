using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class clsLicenseClass
    {




        public int LicenseClassID { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int MinimumAllowedAge { get; set; }

        public int DefaultValidityLength { get; set; }

        public decimal Fees { get; set; }

        private clsLicenseClass(int licenseClassID, string name, string description,
            int minimumAllowedAge, int defaultValidityLength, decimal fees)
        {
            LicenseClassID = licenseClassID;
            Name = name;
            Description = description;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            Fees = fees;
        }
        public clsLicenseClass(string name, string description,
            int minimumAllowedAge, int defaultValidityLength, decimal fees)
        {
            LicenseClassID = -1;
            Name = name;
            Description = description;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            Fees = fees;
        }


        public static List<clsLicenseClass> getAllLicenseClasses()
        {
            DataTable dt = LicenseClassDB.getAllLicenseClasses();

            List<clsLicenseClass> list = new List<clsLicenseClass>();
            foreach (DataRow row in dt.Rows)
            {
                clsLicenseClass licenseClass = new clsLicenseClass
                (
                    Convert.ToInt32(row["LicenseClassID"]),
                    row["ClassName"].ToString(),
                    row["ClassDescription"].ToString(),
                    Convert.ToInt32(row["MinimumAllowedAge"]),
                    Convert.ToInt32(row["DefaultValidityLength"]),
                    Convert.ToDecimal(row["ClassFees"])
                );

                list.Add(licenseClass);
            }

            return list;
        }


        public static clsLicenseClass GetLicenseClass(int id)
        {
            int licenseClassId = id;
            string description = string.Empty;
            string name = string.Empty;
            int minimumAllowedAge = -1;
            int defaultValidityLength = -1;
            decimal fees = 0;

            LicenseClassDB.GetLicenseClass(ref licenseClassId, ref name, ref description,
                ref minimumAllowedAge, ref defaultValidityLength, ref fees);



            return new clsLicenseClass(licenseClassId, name, description, minimumAllowedAge,
                defaultValidityLength, fees);
        }









    }

}

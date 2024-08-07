using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class clsApplicationType
    {

        public int ApplicationTypID { get; }

        public string ApplicationTypTitle { get; set; }
        public decimal ApplicationTypFees { get; set; }

        private clsApplicationType(int applicationTypID, string applicationTypTitle, decimal applicationTypFees)
        {
            ApplicationTypID = applicationTypID;
            ApplicationTypTitle = applicationTypTitle;
            ApplicationTypFees = applicationTypFees;
        }


        public static clsApplicationType GetApplicationType(int applicationTypID)
        {
            int appTypeId = applicationTypID;
            string appTypeTitle = string.Empty;
            decimal appTypeFees = 0;

            ApplicationTypeDB.GetApplicationType(ref appTypeId, ref appTypeTitle, ref appTypeFees);


            return new clsApplicationType(applicationTypID, appTypeTitle, appTypeFees);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeDB.getAllApplicationTypes();
        }


        public static List<clsApplicationType> getApplicationTypesList()
        {
            DataTable dt = GetAllApplicationTypes();
            List<clsApplicationType> list = new List<clsApplicationType>();
            foreach (DataRow row in dt.Rows)
            {
                clsApplicationType applicationType = new clsApplicationType
                (
                    Convert.ToInt32(row["Id"]),
                    row["Title"].ToString(),
                    Convert.ToDecimal(row["Fees"])
                );

                list.Add(applicationType);
            }

            return list;
        }


        public static decimal GetFees(string appTitle)
        {
            return ApplicationTypeDB.getFees(appTitle);
        }
    }



}

using System;
using System.Data.SqlClient;
using System.Xml.Linq;
using dataLayer;

namespace businessLayer
{
    internal class clsCountry
    {
        public string CountryName { get; set; }
        public string CountryID { get; set; }

        public clsCountry(string countryName, string countryID)
        {
            CountryName = countryName;
            CountryID = countryID;
        }

        public static List<clsCountry> LoadAllCountrys()
        {
            List<clsCountry> countrysList = new List<clsCountry>();

            SqlDataReader reader = CountrysDB.GetAllCountrys();
            if (reader != null)
            {
                while (reader.Read())
                {
                    countrysList.Add(new clsCountry((string)reader["CountryName"], (string)reader["CountryID"]));
                }
            }
            return countrysList;


        }

        public static string[] GetAllCountrys()
        {
            return null;



        }

    }
}

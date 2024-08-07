using DataLayer;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class clsCountry
    {
        public string CountryName { get; set; }
        public string CountryID { get; set; }

        public clsCountry(string countryName, string countryID)
        {
            CountryName = countryName;
            CountryID = countryID;
        }

        public static DataTable LoadAllCountrys()
        {
            return CountrysDB.GetAllCountrys();
        }


        public static string[] GetAllCountrys()
        {
            return LoadAllCountrys().Rows.OfType<DataRow>().Select(k => k["CountryName"].ToString()).ToArray(); ;

        }

        public static int GetCountryID(string countryName)
        {
            return CountrysDB.GetCountryID(countryName);
        }





    }
}

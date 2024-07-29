using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CountrysDB
    {
        public static DataTable GetAllCountrys()
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = "SELECT * FROM Countries;";

            SqlCommand cmd = new SqlCommand(query, conn);



            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //TODO: LogFile Error Saving
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                conn.Close();
            }

            return dt;
        }


        public static int GetCountryID(string countryName)
        {
            string query = @"SELECT CountryID FROM Countries
                            WHERE CountryName = @CounName";


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);



            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CounName", countryName);



            int CountID = -1;

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CountID = insertedID;
                }



            }
            catch (Exception ex)
            {
                //TODO: LogFile Error Saving
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                conn.Close();
            }

            return CountID;

        }







    }
}

using System;
using System.Data.SqlClient;

namespace dataLayer
{
    public class CountrysDB
    {
        public static SqlDataReader GetAllCountrys()
        {
            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand cmd = new SqlCommand(query,conn);

            SqlDataReader reader = null;

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                //TODO: LogFile Error Saving
                Console.WriteLine(ex.ToString());
            }finally
            {
                conn.Close();
            }

            return reader;
        }
    }
}

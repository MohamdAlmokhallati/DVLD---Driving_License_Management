using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class LicenseClassDB
    {

        public static DataTable getAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses";

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


        public static void GetLicenseClass(ref int LicenseClassID, ref string className,
            ref string classDescription, ref int MinAge, ref int defaultLength, ref decimal classFess)
        {

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses
                        WHERE LicenseClassID = @LicenseClassID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LicenseClassID = (int)reader["LicenseClassID"];
                    className = (string)reader["ClassName"];
                    classDescription = (string)reader["ClassDescription"];
                    defaultLength = (byte)reader["DefaultValidityLength"];
                    classFess = (decimal)reader["ClassFees"];
                    MinAge = (byte)reader["MinimumAllowedAge"];
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
        }


    }
}

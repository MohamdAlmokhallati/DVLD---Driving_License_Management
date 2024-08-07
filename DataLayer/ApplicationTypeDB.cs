using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class ApplicationTypeDB
    {


        public static void GetApplicationType(ref int AppTypeID, ref string AppTypeTitle, ref decimal AppTypeFees)
        {


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes
                    WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", AppTypeID);



            try
            {
                conn.Open();


                SqlDataReader result = cmd.ExecuteReader();

                if (result.Read())
                {
                    AppTypeTitle = (string)result["ApplicationTypeTitle"];
                    AppTypeFees = (decimal)result["ApplicationFees"];
                }
                result.Close();

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

        public static decimal getFees(string AppTitle)
        {

            decimal Fees = 0;


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"  SELECT ApplicationFees FROM ApplicationTypes
	            WHERE ApplicationTypeTitle = @ApplicationTypeTitle";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", AppTitle);



            try
            {
                conn.Open();


                object result = cmd.ExecuteScalar();

                Fees = (decimal)result;


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



            return Fees;
        }





        public static DataTable getAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT ApplicationTypeID AS ID,ApplicationTypeTitle AS Title
                            ,ApplicationFees AS Fees FROM ApplicationTypes";

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





    }
}

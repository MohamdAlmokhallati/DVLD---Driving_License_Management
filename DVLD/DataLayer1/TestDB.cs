using System;
using System.Data.SqlClient;


namespace DataLayer
{
    public static class TestDB
    {

        public static bool Save(ref int testID, int testAppointmentID, bool testResult, string Notes,
            int userID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[Tests]
                               ([TestAppointmentID]
                               ,[TestResult]
                               ,[Notes]
                               ,[CreatedByUserID])
                         VALUES
                               (@TestAppointmentID
                               ,@TestResult
                               ,@Notes
                               ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

            cmd.Parameters.AddWithValue("@TestResult", testResult);

            if (String.IsNullOrEmpty(Notes))
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", Notes);

            }



            cmd.Parameters.AddWithValue("@CreatedByUserID", userID);



            try
            {
                conn.Open();


                object NewID = cmd.ExecuteScalar();

                if (NewID != null && int.TryParse(NewID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    testID = insertedID;
                }
                else
                {
                    isSaved = false;
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


            return isSaved;
        }



    }
}

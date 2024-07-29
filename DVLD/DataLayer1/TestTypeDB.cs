using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class TestTypeDB
    {


        private static bool _Save(ref int TestTypeID, string Title, string Description, decimal Fees)
        {
            //NOT Tested!!!!
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[TestTypes]
                   ([TestTypeTitle]
                   ,[TestTypeDescription]
                   ,[TestTypeFees])
             VALUES
                   (@TestTypeTitle
                   ,@TestTypeDescription
                   ,@TestTypeFees)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestTypeTitle", Title);

            cmd.Parameters.AddWithValue("@TestTypeDescription", Description);


            cmd.Parameters.AddWithValue("@TestTypeFees", Fees);





            try
            {
                conn.Open();


                object NewTestTypeID = cmd.ExecuteScalar();

                if (NewTestTypeID != null && int.TryParse(NewTestTypeID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    TestTypeID = insertedID;
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

        private static bool _Update(int TestTypeID, string Title, string Description, decimal Fees)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
                        UPDATE [dbo].[TestTypes]
                           SET [TestTypeTitle] = @TestTypeTitle
                              ,[TestTypeDescription] = @TestTypeDescription 
                              ,[TestTypeFees] = @TestTypeFees
                         WHERE TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestTypeTitle", Title);

            cmd.Parameters.AddWithValue("@TestTypeDescription", Description);


            cmd.Parameters.AddWithValue("@TestTypeFees", Fees);


            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);



            try
            {
                conn.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    isSaved = true;
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



        public static bool Save(ref int TestTypeID, string Title, string Description, decimal Fees)
        {
            if (TestTypeID < 0)
            {
                return _Save(ref TestTypeID, Title, Description, Fees);
            }
            else
            {
                return _Update(TestTypeID, Title, Description, Fees);
            }
        }




        public static void GetTestTypes(ref int testTypeID, ref string title, ref string description, ref decimal fees)
        {
            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM TestTypes
                        WHERE TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    testTypeID = (int)reader["TestTypeID"];
                    title = (string)reader["TestTypeTitle"];
                    description = (string)reader["TestTypeDescription"];
                    fees = (decimal)reader["TestTypeFees"];

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






        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT TestTypeID AS ID,TestTypeTitle AS Title,
            TestTypeDescription AS Description,TestTypeFees AS Fees FROM TestTypes";

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

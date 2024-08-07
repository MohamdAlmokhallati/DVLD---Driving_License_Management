using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class DriverDB
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        Drivers.DriverID, People.FirstName, Drivers.CreatedDate, Users.UserName
FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Users ON Drivers.CreatedByUserID = Users.UserID";

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

        public static void GetDriverByPersonID(int personID, ref int userID,
            ref DateTime createdDate, ref int DriverID)
        {
            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM Drivers
                    WHERE PersonID = @PersonID"
            ;

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];
                    userID = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];
                    personID = (int)reader["PersonID"];

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

        public static void GetDriver(ref int DriverID, ref int userID,
            ref DateTime createdDate, ref int personID)
        {

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"  SELECT * FROM Drivers 
                         WHERE DriverID = @DriverID"
            ;

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];
                    userID = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];
                    personID = (int)reader["PersonID"];

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




        private static bool _Save(ref int driverID, int personID, int createdByID, DateTime createdTime)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[Drivers]
                                   ([PersonID]
                                   ,[CreatedByUserID]
                                   ,[CreatedDate])
                             VALUES
                                   (@PersonID
                                   ,@CreatedByUserID
                                   ,@CreatedDate)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);

            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByID);

            cmd.Parameters.AddWithValue("@CreatedDate", createdTime);




            try
            {
                conn.Open();


                object NewID = cmd.ExecuteScalar();

                if (NewID != null && int.TryParse(NewID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    driverID = insertedID;
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

        private static bool _Update(ref int driverID, int personID, int createdByID, DateTime createdTime)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[Drivers]
                   SET [PersonID] = @PersonID
                      ,[CreatedByUserID] = @CreatedByUserID
                      ,[CreatedDate] = @CreatedDate
                 WHERE DriverID = @DriverID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);

            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByID);

            cmd.Parameters.AddWithValue("@CreatedDate", createdTime);

            cmd.Parameters.AddWithValue("@DriverID", driverID);

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

        public static bool Save(ref int driverID, int personID, int createdByID, DateTime createdTime)
        {
            if (driverID < 0)
            {
                //Save New
                return _Save(ref driverID, personID, createdByID, createdTime);
            }
            else
            {
                //Update
                return _Update(ref driverID, personID, createdByID, createdTime);
            }
        }




    }
}

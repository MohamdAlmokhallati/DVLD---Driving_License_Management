using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class TestAppointmentDB
    {

        public static DataTable GetAllPersonAppointment(int personID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked
                    FROM            People INNER JOIN
                                             Applications ON People.PersonID = Applications.ApplicantPersonID INNER JOIN
                                             LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                                             TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                    WHERE  People.PersonID = @PersonID AND TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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
        private static bool _Update(ref int appointmentID, int TestTypeID, int LDLALID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[TestAppointments]
                           SET [TestTypeID] = @TestTypeID
                              ,[LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID
                              ,[AppointmentDate] = @AppointmentDate
                              ,[PaidFees] = @PaidFees
                              ,[CreatedByUserID] = @CreatedByUserID
                              ,[IsLocked] = @IsLocked
                         WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLALID);


            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);


            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            cmd.Parameters.AddWithValue("@TestAppointmentID", appointmentID);
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



        private static bool _Save(ref int appointmentID, int TestTypeID, int LDLALID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[TestAppointments]
                               ([TestTypeID]
                               ,[LocalDrivingLicenseApplicationID]
                               ,[AppointmentDate]
                               ,[PaidFees]
                               ,[CreatedByUserID]
                               ,[IsLocked])
                         VALUES
                               (@TestTypeID
                               ,@LocalDrivingLicenseApplicationID
                               ,@AppointmentDate
                               ,@PaidFees
                               ,@CreatedByUserID
                               ,@IsLocked)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLALID);


            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);


            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);



            try
            {
                conn.Open();


                object NewID = cmd.ExecuteScalar();

                if (NewID != null && int.TryParse(NewID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    appointmentID = insertedID;
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

        public static bool Save(ref int appointmentID, int TestTypeID, int LDLALID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            if (appointmentID < 0)
            {
                //Save New
                return _Save(ref appointmentID, TestTypeID, LDLALID, AppointmentDate,
             PaidFees, CreatedByUserID, IsLocked);
            }
            else
            {
                //Update
                return _Update(ref appointmentID, TestTypeID, LDLALID, AppointmentDate,
             PaidFees, CreatedByUserID, IsLocked);
            }
        }

        public static void getTestAppointment(ref int testAppointmentId, ref int testTypeID
            , ref int ldlaID, ref DateTime appointmentDate, ref decimal paidFees,
            ref int userid, ref bool islocked)
        {


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM TestAppointments
                                WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentId);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    testAppointmentId = (int)reader["TestAppointmentID"];
                    testTypeID = (int)reader["TestTypeID"];
                    ldlaID = (int)reader["LocalDrivingLicenseApplicationID"];
                    appointmentDate = (DateTime)reader["AppointmentDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    userid = (int)reader["CreatedByUserID"];
                    islocked = (bool)reader["IsLocked"];
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

        public static bool LockAppointment(int AppointmentID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[TestAppointments]
                           SET [IsLocked] = 1
                         WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@TestAppointmentID", AppointmentID);


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





    }
}

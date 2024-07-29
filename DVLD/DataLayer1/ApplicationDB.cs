using System;

using System.Data.SqlClient;

namespace DataLayer
{
    public class ApplicationDB
    {

        public static void GetApplication(ref int applicationID, ref int personID,
            ref DateTime applicationDate, ref int applicationTypeID, ref DateTime lastStatusDate,
            ref string applicationStatus, ref decimal paidFees, ref int userID)
        {


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
SELECT        Applications.*, ApplicationsStatuses.StatusName
FROM            Applications INNER JOIN
                         ApplicationsStatuses ON Applications.ApplicationStatus = ApplicationsStatuses.StatusID

                        WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    personID = (int)reader["ApplicantPersonID"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    applicationStatus = (string)reader["StatusName"];
                    paidFees = (decimal)reader["PaidFees"];
                    userID = (int)reader["CreatedByUserID"];
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

        public static bool ChangeApplicationStatus(int ApplicationID, int StatusID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[Applications]
                           SET [ApplicationStatus] = @ApplicationStatus

                         WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", StatusID);




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









        private static bool _Update(ref int appID, int personID, DateTime appDate, int appTypeId,
            int appStatus, DateTime lastStatusDate, decimal paidFees, int userID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[Applications]
                   SET [ApplicantPersonID] = @ApplicantPersonID
                      ,[ApplicationDate] = @ApplicationDate
                      ,[ApplicationTypeID] = @ApplicationTypeID
                      ,[ApplicationStatus] = @ApplicationStatus
                      ,[LastStatusDate] = @LastStatusDate
                      ,[PaidFees] = @PaidFees
                      ,[CreatedByUserID] = @CreatedByUserID
                 WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", personID);

            cmd.Parameters.AddWithValue("@ApplicationDate", appDate);


            cmd.Parameters.AddWithValue("@ApplicationTypeID", appTypeId);

            cmd.Parameters.AddWithValue("@ApplicationStatus", appStatus);

            cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);

            cmd.Parameters.AddWithValue("@PaidFees", paidFees);

            cmd.Parameters.AddWithValue("@CreatedByUserID", userID);

            cmd.Parameters.AddWithValue("@ApplicationID", appID);


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

        private static bool _Save(ref int appID, int personID, DateTime appDate, int appTypeId,
            int appStatus, DateTime lastStatusDate, decimal paidFees, int userID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[Applications]
                                   ([ApplicantPersonID]
                                   ,[ApplicationDate]
                                   ,[ApplicationTypeID]
                                   ,[ApplicationStatus]
                                   ,[LastStatusDate]
                                   ,[PaidFees]
                                   ,[CreatedByUserID])
                             VALUES
                                   (@ApplicantPersonID
                                   ,@ApplicationDate
                                   ,@ApplicationTypeID
                                   ,@ApplicationStatus
                                   ,@LastStatusDate
                                   ,@PaidFees
                                   ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", personID);

            cmd.Parameters.AddWithValue("@ApplicationDate", appDate);


            cmd.Parameters.AddWithValue("@ApplicationTypeID", appTypeId);

            cmd.Parameters.AddWithValue("@ApplicationStatus", appStatus);

            cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);

            cmd.Parameters.AddWithValue("@PaidFees", paidFees);

            cmd.Parameters.AddWithValue("@CreatedByUserID", userID);

            try
            {
                conn.Open();


                object NewAppID = cmd.ExecuteScalar();

                if (NewAppID != null && int.TryParse(NewAppID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    appID = insertedID;
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


        public static bool Save(ref int appID, int personID, DateTime appDate, int appTypeId,
            int appStatus, DateTime lastStatusDate, decimal paidFees, int userID)
        {
            if (appID > 0)
            {
                //Update
                return _Update(ref appID, personID, appDate, appTypeId, appStatus, lastStatusDate, paidFees, userID);
            }
            else
            {
                //Save New
                return _Save(ref appID, personID, appDate, appTypeId, appStatus, lastStatusDate, paidFees, userID);
            }
        }


        public static bool HasFaledTest(int ApplicationID, int TestTypeID)
        {
            bool hasFaledTest = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        COUNT(*) 
FROM            Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                         LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
WHERE TestResult = 0 AND LocalDrivingLicenseApplications.ApplicationID = @ApplicationID AND TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    hasFaledTest = true;
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


            return hasFaledTest;
        }






    }
}

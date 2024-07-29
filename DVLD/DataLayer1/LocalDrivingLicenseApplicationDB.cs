using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class LocalDrivingLicenseApplicationDB
    {




        private static bool _Save(ref int ldlaID, ref int ApplicationID, int LicenseClassID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                               ([ApplicationID]
                               ,[LicenseClassID])
                         VALUES
                               (@ApplicationID
                               ,@LicenseClassID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            try
            {
                conn.Open();


                object NewldlaID = cmd.ExecuteScalar();

                if (NewldlaID != null && int.TryParse(NewldlaID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    ldlaID = insertedID;
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


        public static bool Save(ref int ldlaID, ref int ApplicationID, int LicenseClassID)
        {
            if (ldlaID < 0)
            {
                //Save New
                return _Save(ref ldlaID, ref ApplicationID, LicenseClassID);
            }
            else
            {
                //Update
                // return _Update(ref PersonID, ref userID, userName, password, isActive);
                return false;
            }

        }




        public static DataTable GetAllLocalApps()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT 
                            LDA.LocalDrivingLicenseApplicationID, 
                            LC.ClassName, 
                            P.NationalNo,
                            (P.FirstName + ' ' + P.SecondName + ' ' + P.LastName) AS FullName,
                            A.ApplicationDate, 
                            COALESCE(PassedTests.PassedCount, 0) AS PassedTests,
                            CASE
                                WHEN ApplicationStatus = 1 THEN 'New'
                                WHEN ApplicationStatus = 2 THEN 'Cancelled'
                                ELSE 'Completed'
                            END AS Status
                        FROM 
                            LocalDrivingLicenseApplications LDA
                        INNER JOIN 
                            Applications A ON LDA.ApplicationID = A.ApplicationID
                        INNER JOIN 
                            LicenseClasses LC ON LDA.LicenseClassID = LC.LicenseClassID
                        INNER JOIN 
                            People P ON A.ApplicantPersonID = P.PersonID
                        LEFT JOIN 
                            (SELECT 
                                 TA.LocalDrivingLicenseApplicationID, 
                                 COUNT(*) AS PassedCount
                             FROM 
                                 TestAppointments TA
                             INNER JOIN 
                                 Tests T ON TA.TestAppointmentID = T.TestAppointmentID
                             WHERE 
                                 T.TestResult = 1
                             GROUP BY 
                                 TA.LocalDrivingLicenseApplicationID) AS PassedTests
                        ON 
                            LDA.LocalDrivingLicenseApplicationID = PassedTests.LocalDrivingLicenseApplicationID;
                        ";

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





        public static void getLDLA(ref int ldlAppId, ref int appID, ref int personID,
            ref DateTime appDate, ref int appTypeID, ref decimal paidFees, ref int UserId,
            ref int LicenseClassID, ref string Stauts, ref DateTime lastappDate, ref int passedTest)
        {


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
SELECT
    lda.LocalDrivingLicenseApplicationID,
    a.ApplicationID,
    a.ApplicantPersonID,
    a.ApplicationDate,
    a.ApplicationTypeID,
    a.PaidFees,
    a.CreatedByUserID,
    lc.LicenseClassID,
    s.StatusName,
    a.LastStatusDate,
    COALESCE(SUM(CASE WHEN t.TestResult = 1 THEN 1 ELSE 0 END), 0) AS PassedTests
FROM
    LocalDrivingLicenseApplications AS lda
INNER JOIN
    Applications AS a ON lda.ApplicationID = a.ApplicationID
INNER JOIN
    LicenseClasses AS lc ON lda.LicenseClassID = lc.LicenseClassID
INNER JOIN
    ApplicationsStatuses AS s ON a.ApplicationStatus = s.StatusID
LEFT JOIN
    TestAppointments AS ta ON lda.LocalDrivingLicenseApplicationID = ta.LocalDrivingLicenseApplicationID
LEFT JOIN
    Tests AS t ON ta.TestAppointmentID = t.TestAppointmentID

	WHERE lda.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID

GROUP BY
    lda.LocalDrivingLicenseApplicationID,
    a.ApplicationID,
    a.ApplicantPersonID,
    a.ApplicationDate,
    a.ApplicationTypeID,
    a.PaidFees,
    a.CreatedByUserID,
    lc.LicenseClassID,
    s.StatusName,
    a.LastStatusDate;
";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ldlAppId);




            try
            {
                conn.Open();


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ldlAppId = (int)reader["LocalDrivingLicenseApplicationID"];
                    appID = (int)reader["ApplicationID"];
                    personID = (int)reader["ApplicantPersonID"];
                    appDate = (DateTime)reader["ApplicationDate"];
                    appTypeID = (int)reader["ApplicationTypeID"];
                    paidFees = (decimal)reader["PaidFees"];
                    UserId = (int)reader["CreatedByUserID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    Stauts = (string)reader["StatusName"];
                    lastappDate = (DateTime)reader["LastStatusDate"];
                    passedTest = (int)reader["PassedTests"];
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

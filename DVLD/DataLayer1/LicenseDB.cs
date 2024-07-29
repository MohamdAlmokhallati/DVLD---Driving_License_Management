using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class LicenseDB
    {

        public static DataTable GetAllInternationalLicenseOfPerson(int personID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT     DIStinct   InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, Drivers.DriverID, InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, 
                         InternationalLicenses.IsActive, InternationalLicenses.CreatedByUserID
FROM            InternationalLicenses INNER JOIN
                         Drivers ON InternationalLicenses.DriverID = Drivers.DriverID CROSS JOIN
                         LicenseClasses
            WHERE Drivers.PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);


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



        public static DataTable GetAllLicenseOfPerson(int personID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        Licenses.*
            FROM            Licenses INNER JOIN
                                     Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                                     People ON Drivers.PersonID = People.PersonID
            WHERE People.PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);


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




        public static void GetLicenseIDByLocalApplicationID(ref int licenseID, int LocalApplicationID)
        {

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT         Licenses.LicenseID
FROM            Licenses INNER JOIN
                         Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN
                         LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
						 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalApplicationID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    licenseID = count;
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

        }



        public static void GetLicense(ref int licenseID, ref int applicationID, ref int driverID,
            ref int LicenseClassID, ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
            ref decimal paidFees, ref bool isActive, ref int issueReason, ref int userID)
        {


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM Licenses 
                    WHERE LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", licenseID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    licenseID = (int)reader["LicenseID"];
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClass"];

                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : default;
                    paidFees = (decimal)reader["PaidFees"];
                    isActive = (bool)reader["IsActive"];
                    issueReason = (int)reader["IssueReason"];
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






        private static bool _Save(ref int licenseID, int applicationID, int driverID, int LicenseClassID,
            DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive,
            int issueReason, int createdByID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[Licenses]
                               ([ApplicationID]
                               ,[DriverID]
                               ,[LicenseClass]
                               ,[IssueDate]
                               ,[ExpirationDate]
                               ,[Notes]
                               ,[PaidFees]
                               ,[IsActive]
                               ,[IssueReason]
                               ,[CreatedByUserID])
                         VALUES
                               (@ApplicationID
                               ,@DriverID
                               ,@LicenseClass
                               ,@IssueDate
                               ,@ExpirationDate
                               ,@Notes
                               ,@PaidFees
                               ,@IsActive
                               ,@IssueReason
                               ,@CreatedByUserID)   
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

            cmd.Parameters.AddWithValue("@DriverID", driverID);

            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            cmd.Parameters.AddWithValue("@IssueDate", issueDate);

            cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);

            if (String.IsNullOrEmpty(notes))
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", notes);

            }



            cmd.Parameters.AddWithValue("@PaidFees", paidFees);

            cmd.Parameters.AddWithValue("@IsActive", isActive);

            cmd.Parameters.AddWithValue("@IssueReason", issueReason);

            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByID);



            try
            {
                conn.Open();


                object NewID = cmd.ExecuteScalar();

                if (NewID != null && int.TryParse(NewID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    licenseID = insertedID;
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

        private static bool _Update(ref int licenseID, int applicationID, int driverID, int LicenseClassID,
            DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive,
            int issueReason, int createdByID)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[Licenses]
                   SET [ApplicationID] = @ApplicationID
                      ,[DriverID] = @DriverID
                      ,[LicenseClass] = @LicenseClass
                      ,[IssueDate] = @IssueDate
                      ,[ExpirationDate] = @ExpirationDate
                      ,[Notes] = @Notes
                      ,[PaidFees] = @PaidFees
                      ,[IsActive] = @IsActive
                      ,[IssueReason] = @IssueReason
                      ,[CreatedByUserID] = @CreatedByUserID
                 WHERE LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

            cmd.Parameters.AddWithValue("@DriverID", driverID);

            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            cmd.Parameters.AddWithValue("@IssueDate", issueDate);

            cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);

            if (String.IsNullOrEmpty(notes))
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", notes);

            }



            cmd.Parameters.AddWithValue("@PaidFees", paidFees);

            cmd.Parameters.AddWithValue("@IsActive", isActive);

            cmd.Parameters.AddWithValue("@IssueReason", issueReason);

            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByID);

            cmd.Parameters.AddWithValue("@LicenseID", licenseID);

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

        public static bool Save(ref int licenseID, int applicationID, int DriverID, int LicenseClassID,
            DateTime lssueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive,
            int lssueReason, int createdByID)
        {
            if (licenseID < 0)
            {
                //Save New
                return _Save(ref licenseID, applicationID, DriverID, LicenseClassID,
             lssueDate, expirationDate, notes, paidFees, isActive,
             lssueReason, createdByID);
            }
            else
            {
                //Update
                return _Update(ref licenseID, applicationID, DriverID, LicenseClassID,
             lssueDate, expirationDate, notes, paidFees, isActive,
             lssueReason, createdByID);
            }
        }




    }
}

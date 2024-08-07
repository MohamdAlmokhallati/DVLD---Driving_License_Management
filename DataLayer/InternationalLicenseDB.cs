using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer
{
    public static class InternationalLicenseDB
    {
        //InternationalLicenseDB.Save(ref licenseID,this.ApplicationID, Driver.DriverID, IssedUsingLocalLicenseID,
        //        IssueDate, ExpirationDate, IsActive, InternationalLicenseCreatedBy);


        private static bool _Save(ref int licenseID, int ApplicationID, int DriverID, int IssedUsingLocalLicenseID,
               DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int InternationalLicenseCreatedBy)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[InternationalLicenses]
                                   ([ApplicationID]
                                   ,[DriverID]
                                   ,[IssuedUsingLocalLicenseID]
                                   ,[IssueDate]
                                   ,[ExpirationDate]
                                   ,[IsActive]
                                   ,[CreatedByUserID])
                             VALUES
                                   (@ApplicationID
                                   ,@DriverID
                                   ,@IssuedUsingLocalLicenseID
                                   ,@IssueDate
                                   ,@ExpirationDate
                                   ,@IsActive
                                   ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);


            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssedUsingLocalLicenseID);


            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", InternationalLicenseCreatedBy);



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


        private static bool _Update(ref int licenseID, int ApplicationID, int DriverID, int IssedUsingLocalLicenseID,
       DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int InternationalLicenseCreatedBy)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[InternationalLicenses]
                   SET [ApplicationID] = @ApplicationID
                      ,[DriverID] = @DriverID
                      ,[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID
                      ,[IssueDate] = @IssueDate
                      ,[ExpirationDate] = @ExpirationDate
                      ,[IsActive] = @IsActive
                      ,[CreatedByUserID] = @CreatedByUserID
                 WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);


            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssedUsingLocalLicenseID);


            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", InternationalLicenseCreatedBy);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", licenseID);


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


        public static bool Save(ref int licenseID, int ApplicationID,int  DriverID,int IssedUsingLocalLicenseID,
               DateTime IssueDate, DateTime ExpirationDate,bool IsActive,int InternationalLicenseCreatedBy)
        {
            if (licenseID < 0)
            {
                //Save New
                return _Save(ref licenseID,ApplicationID, DriverID, IssedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, InternationalLicenseCreatedBy);
            }
            else
            {
                //Update
                return _Update(ref licenseID, ApplicationID, DriverID, IssedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, InternationalLicenseCreatedBy);
            }

        }



        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
SELECT        InternationalLicenses.InternationalLicenseID,InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.ApplicationID, FullName = (People.FirstName + ' ' +People.SecondName+ ' ' + People.ThirdName + ' ' + People.LastName), InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, 
                         InternationalLicenses.IsActive, Users.UserName
FROM            InternationalLicenses INNER JOIN
                         Drivers ON InternationalLicenses.DriverID = Drivers.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Users ON InternationalLicenses.CreatedByUserID = Users.UserID";

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

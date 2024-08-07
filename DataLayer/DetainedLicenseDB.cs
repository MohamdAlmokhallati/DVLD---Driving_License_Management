using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer
{
    public static class DetainedLicenseDB
    {

        public static DataTable GetAllDetainedLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        DetainedLicenses.DetainID, FullName = People.FirstName + People.SecondName + People.ThirdName + People.LastName, DetainedLicenses.DetainDate, DetainedLicenses.FineFees, DetainedLicenses.CreatedByUserID, Users.UserName
FROM            DetainedLicenses INNER JOIN
                         Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                         Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Users ON DetainedLicenses.CreatedByUserID = Users.UserID
						 WHERE IsReleased = 0";

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











        public static bool GetDetainedLicense(ref int detainedLicenseID,
                ref DateTime detainDate, ref decimal fineFees, ref int detainByID,
                ref bool isReleased,ref DateTime releaseDate, ref int releasedByUserID,
                ref int releaseApplicationID, ref int LicenseID)
        {
            bool licenseExists = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses
                WHERE LicenseID = @LicenseID AND IsReleased = 0";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    detainedLicenseID = (int)reader["DetainID"];
                    detainDate = (DateTime)reader["DetainDate"];
                    fineFees = (decimal)reader["FineFees"];
                    detainByID = (int)reader["CreatedByUserID"];

                    isReleased = (bool)reader["IsReleased"];

                    releaseDate = reader["ReleaseDate"] != DBNull.Value ? (DateTime)reader["ReleaseDate"] : default;
                    releasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? (int)reader["ReleasedByUserID"] : -1;
                    releaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? (int)reader["ReleaseApplicationID"] : -1;
                    LicenseID = (int)reader["LicenseID"];


                    licenseExists = true;
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

            return licenseExists;
        }



        public static bool IsDetained(int LicenesID)
        {
            bool IsExist = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT COUNT(*) FROM DetainedLicenses
                            WHERE LicenseID = @LicenseID AND IsReleased = 0";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", LicenesID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    IsExist = true;
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



            return IsExist;
        }

        private static bool _Save(ref int detainLicenseID, int LicenseId, DateTime DetainDate,
           decimal FineFees, int DetainBy, bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUser, int ReleaseApplication)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[DetainedLicenses]
                               ([LicenseID]
                               ,[DetainDate]
                               ,[FineFees]
                               ,[CreatedByUserID]
                               ,[IsReleased]
                               ,[ReleaseDate]
                               ,[ReleasedByUserID]
                               ,[ReleaseApplicationID])
                         VALUES
                               (@LicenseID
                               ,@DetainDate
                               ,@FineFees
                               ,@CreatedByUserID
                               ,@IsReleased
                               ,@ReleaseDate
                               ,@ReleasedByUserID
                               ,@ReleaseApplicationID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseId);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", DetainBy);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == default(DateTime) ? (object)DBNull.Value : ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUser < 0 ? (object)DBNull.Value : ReleasedByUser);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplication < 0 ? (object)DBNull.Value : ReleaseApplication);
            cmd.Parameters.AddWithValue("@DetainID", detainLicenseID);

            try
            {
                conn.Open();


                object NewID = cmd.ExecuteScalar();

                if (NewID != null && int.TryParse(NewID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    detainLicenseID = insertedID;
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


        private static bool _Update(ref int detainLicenseID, int LicenseId, DateTime DetainDate,
            decimal FineFees, int DetainBy, bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUser, int ReleaseApplication)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[DetainedLicenses]
                   SET [LicenseID] = @LicenseID
                      ,[DetainDate] = @DetainDate
                      ,[FineFees] = @FineFees
                      ,[CreatedByUserID] = @CreatedByUserID
                      ,[IsReleased] = @IsReleased
                      ,[ReleaseDate] = @ReleaseDate
                      ,[ReleasedByUserID] = @ReleasedByUserID
                      ,[ReleaseApplicationID] = @ReleaseApplicationID
                 WHERE DetainID = @DetainID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseId);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", DetainBy);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == default(DateTime) ? (object)DBNull.Value : ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUser < 0 ? (object)DBNull.Value : ReleasedByUser);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplication < 0 ? (object)DBNull.Value : ReleaseApplication);
            cmd.Parameters.AddWithValue("@DetainID", detainLicenseID);

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


        public static bool Save(ref int detainLicenseID, int LicenseId,DateTime DetainDate,
   decimal FineFees, int DetainBy, bool IsReleased,DateTime ReleaseDate,
    int ReleasedByUser,int ReleaseApplication)
        {
            if (detainLicenseID < 0)
            {
                //Save New
                return _Save(ref detainLicenseID, LicenseId, DetainDate,
                     FineFees, DetainBy, IsReleased, ReleaseDate,
                     ReleasedByUser, ReleaseApplication);
            }
            else
            {
                //Update
                return _Update(ref detainLicenseID, LicenseId, DetainDate,
                     FineFees, DetainBy, IsReleased, ReleaseDate,
                     ReleasedByUser, ReleaseApplication);
            }
        }





    }
}

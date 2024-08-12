using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DataLayer
{
    public static class PersonDB
    {
        public static bool IsPassTest(int testTypeID, int licenseClassID,int personID)
        {
            bool isPassTest = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
SELECT COUNT(*) FROM
(
SELECT People.PersonID, Tests.*, LicenseClasses.LicenseClassID, LicenseClasses.ClassName
FROM            Applications INNER JOIN
                         People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                         LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                         Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                         LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
						 WHERE PersonID = @PersonID AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID AND TestResult = 1
)R1";


            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);
            cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count >= testTypeID)
                {
                    isPassTest = true;
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



            return isPassTest;
        }


        public static bool IsDriver(int PersonID)
        {
            bool isDriver = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT Count(*) FROM Drivers
                    WHERE PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isDriver = true;
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



            return isDriver;
        }
        public static bool HasLicense(int personid, int LicenseClassID)
        {
            bool hasOpenedAppointment = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        COUNT(*)
FROM            Licenses INNER JOIN
                         Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID
						 WHERE Drivers.PersonID = @PersonID AND LicenseClass = @LicenseClass";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personid);

            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    hasOpenedAppointment = true;
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



            return hasOpenedAppointment;
        }



        public static bool HasOpenedAppointment(int ApplicationID, int TestTypeID)
        {
            bool hasOpenedAppointment = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT Count(*) FROM
                    (
                    SELECT  TestAppointments.IsLocked
                    FROM      Applications INNER JOIN
                People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
				WHERE  Applications.ApplicationID = @ApplicationID AND IsLocked = 0
                    AND TestTypeID = @TestTypeID )R1";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    hasOpenedAppointment = true;
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



            return hasOpenedAppointment;
        }


        public static bool HasActiveApp(int personID, int ClassID)
        {
            bool hasActiveApp = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT COUNT(*) FROM
        (
        SELECT        Applications.ApplicationStatus, LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicantPersonID
        FROM            Applications INNER JOIN
                                    LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
		        WHERE Applications.ApplicationStatus = 1 AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID AND 
		        Applications.ApplicantPersonID = @ApplicantPersonID
        )R1";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseClassID", ClassID);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", personID);

            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    hasActiveApp = true;
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



            return hasActiveApp;
        }

        public static bool IsUser(int personID)
        {
            bool isUser = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT COUNT(*) FROM 
                            (
                            SELECT Users.*, People.PersonID AS Expr1
                            FROM            Users INNER JOIN
                                                     People ON Users.PersonID = People.PersonID
                            )R1
                            WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);
            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isUser = true;
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



            return isUser;
        }


        // if we can use then true
        // if we cant use the false
        public static bool IsNationalNoValid(string nationalNo)
        {
            bool isValid = true;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT COUNT(1) FROM [dbo].[People] WHERE [NationalNo] = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
            try
            {
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isValid = false;
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



            return isValid;
        }

        public static bool getPersonBynationalNo(ref int personID, ref string firstName, ref string secondName
            , ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref bool gendor,
            ref string address, ref string nationalNo, ref string phone,
            ref string email, ref string country, ref string imagePath)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, People.Address, People.Gendor, People.Phone, People.Email, People.ImagePath, 
                         Countries.CountryName
            FROM            People INNER JOIN
                                        Countries ON People.NationalityCountryID = Countries.CountryID
            WHERE People.NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    address = (string)reader["Address"];
                    nationalNo = (string)reader["NationalNo"];
                    phone = (string)reader["Phone"];
                    email = (string)reader["Email"];
                    country = (string)reader["CountryName"];

                    imagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : default;
                    // Since the Gendor column database is of type tinyint :(
                    gendor = Convert.ToInt32(reader["Gendor"]) != 0;
                    IsFound = true;
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
            return IsFound;
        }

        public static bool getPersonByID(ref int personID, ref string firstName, ref string secondName
            , ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref bool gendor,
            ref string address, ref string nationalNo, ref string phone,
            ref string email, ref string country, ref string imagePath)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, People.Address, People.Gendor, People.Phone, People.Email, People.ImagePath, 
                         Countries.CountryName
            FROM            People INNER JOIN
                                        Countries ON People.NationalityCountryID = Countries.CountryID
            WHERE People.PersonID = @personID;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@personID", personID);
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    address = (string)reader["Address"];
                    nationalNo = (string)reader["NationalNo"];
                    phone = (string)reader["Phone"];
                    email = (string)reader["Email"];
                    country = (string)reader["CountryName"];

                    imagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : default;
                    // Since the Gendor column database is of type tinyint :(
                    gendor = Convert.ToInt32(reader["Gendor"]) != 0;
                    IsFound = true;
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

            return IsFound;

        }



        private static bool _Update(ref int personID, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, bool gendor, string address, string nationalNo, string phone,
            string email, int country, string imagePath)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"
                UPDATE [dbo].[People]
                SET [NationalNo] = @NationalNo,
                    [FirstName] = @FirstName,
                    [SecondName] = @SecondName,
                    [ThirdName] = @ThirdName,
                    [LastName] = @LastName,
                    [DateOfBirth] = @DateOfBirth,
                    [Gendor] = @Gendor,
                    [Address] = @Address,
                    [Phone] = @Phone,
                    [Email] = @Email,
                    [NationalityCountryID] = @NationalityCountryID,
                    [ImagePath] = @ImagePath
                WHERE [PersonID] = @PersonID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);


            cmd.Parameters.AddWithValue("@FirstName", firstName);


            cmd.Parameters.AddWithValue("@SecondName", secondName);

            cmd.Parameters.AddWithValue("@ThirdName", thirdName);


            cmd.Parameters.AddWithValue("@LastName", lastName);


            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);


            cmd.Parameters.AddWithValue("@Gendor", gendor);


            cmd.Parameters.AddWithValue("@Address", address);


            cmd.Parameters.AddWithValue("@Phone", phone);


            cmd.Parameters.AddWithValue("@Email", email);


            cmd.Parameters.AddWithValue("@NationalityCountryID", country);

            cmd.Parameters.AddWithValue("@PersonID", personID);

            if (String.IsNullOrEmpty(imagePath))
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

            }

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

        private static bool _Save(ref int personID, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, bool gendor, string address, string nationalNo, string phone,
            string email, int country, string imagePath)
        {

            bool isSaved = false;

            string query = @"INSERT INTO [dbo].[People]([NationalNo],[FirstName],[SecondName]
           ,[ThirdName],[LastName],[DateOfBirth],[Gendor],[Address]
           ,[Phone],[Email],[NationalityCountryID],[ImagePath])
            VALUES
           (@NationalNo ,@FirstName ,@SecondName, @ThirdName,@LastName ,@DateOfBirth,@Gendor
           ,@Address,@Phone,@Email,@CountryID,@ImagePath);
                    SELECT SCOPE_IDENTITY();";


            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@NationalNo", nationalNo);


                cmd.Parameters.AddWithValue("@FirstName", firstName);


                cmd.Parameters.AddWithValue("@SecondName", secondName);

                cmd.Parameters.AddWithValue("@ThirdName", thirdName);


                cmd.Parameters.AddWithValue("@LastName", lastName);


                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);


                cmd.Parameters.AddWithValue("@Gendor", gendor);


                cmd.Parameters.AddWithValue("@Address", address);


                cmd.Parameters.AddWithValue("@Phone", phone);


                cmd.Parameters.AddWithValue("@Email", email);


                cmd.Parameters.AddWithValue("@CountryID", country);


                if (String.IsNullOrEmpty(imagePath))
                {
                    cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                }
            }



            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
                }
                else
                {
                    isSaved = false;
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                //TODO:FILE ERROR HANDLE
            }
            finally
            {
                conn.Close();
            }



            return isSaved;
        }



        public static bool Save(ref int personID, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, bool gendor, string address, string nationalNo, string phone,
            string email, int country, string imagePath)
        {

            if (personID < 0)
            {
                //Save New
                return _Save(ref personID, firstName, secondName, thirdName, lastName, dateOfBirth,
                    gendor, address, nationalNo, phone, email, country, imagePath);
            }
            else
            {
                //Update
                return _Update(ref personID, firstName, secondName, thirdName, lastName, dateOfBirth,
                    gendor, address, nationalNo, phone, email, country, imagePath);
            }


        }









        public static DataTable GetAllPepol()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth,
	                        CASE
                            WHEN People.Gendor = 0 THEN 'Male'
                            WHEN People.Gendor = 1 THEN 'Female'
                            ELSE 'unknown'
	                        END AS Gendor, People.Phone, People.Email, People.ImagePath, 
                                                    Countries.CountryName
                        FROM            People Left JOIN
                        Countries ON People.NationalityCountryID = Countries.CountryID
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

        public static bool Delete(int personID)
        {
            bool isDeleted = false;




            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = "DELETE FROM [dbo].[People]WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                conn.Open();

                int result = (int)cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    isDeleted = true;
                }


            }
            catch (SqlException e)
            {

                //TODO:FILE ERROR HANDLE
            }
            finally
            {
                conn.Close();
            }




            return isDeleted;
        }


    }
}

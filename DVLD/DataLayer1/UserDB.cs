﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public static class UserDB
    {




        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        Users.UserID, Users.UserName, 
			        FullName = (People.FirstName + ' ' +People.SecondName+ ' ' + People.ThirdName + ' ' + People.LastName),
			        People.DateOfBirth, People.Gendor,
			        People.Address, People.Phone, People.Email, Users.IsActive
                            FROM            Users INNER JOIN
                            People ON Users.PersonID = People.PersonID";

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







        public static void getUser(ref int userID, ref string userName, ref string password, ref bool isActive,
            ref int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
            ref DateTime dateOfBirth, ref bool gender, ref string address, ref string nationalNo, ref string phone,
            ref string email, ref string country, ref string imagePath)
        {



            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        Users.*, People.*
                    FROM            Users INNER JOIN
                         People ON Users.PersonID = People.PersonID
                    WHERE UserName = @UserName AND Password = @Password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userID = (int)reader["UserID"];
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

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

        public static void getUserById(ref int userID, ref string userName, ref string password, ref bool isActive,
            ref int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
            ref DateTime dateOfBirth, ref bool gender, ref string address, ref string nationalNo, ref string phone,
            ref string email, ref string country, ref string imagePath)
        {



            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT        Users.*, People.*
                    FROM            Users INNER JOIN
                         People ON Users.PersonID = People.PersonID
                    WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", userID);


            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userID = (int)reader["UserID"];
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

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









        public static bool IsExist(string userName, string password)
        {
            bool IsExist = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"SELECT COUNT(1) FROM Users WHERE UserName = @UserName AND Password = @Password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);

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


        private static bool _Save(ref int PersonID, ref int userID, string userName, string password, bool isActive)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"INSERT INTO [dbo].[Users]
                                   ([PersonID]
                                   ,[UserName]
                                   ,[Password]
                                   ,[IsActive])
                             VALUES
                                   (@PersonID
                                   ,@UserName
                                   ,@Password
                                   ,@IsActive)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            cmd.Parameters.AddWithValue("@UserName", userName);


            cmd.Parameters.AddWithValue("@Password", password);


            cmd.Parameters.AddWithValue("@IsActive", isActive);



            try
            {
                conn.Open();


                object NewUserID = cmd.ExecuteScalar();

                if (NewUserID != null && int.TryParse(NewUserID.ToString(), out int insertedID))
                {
                    isSaved = true;
                    userID = insertedID;
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

        private static bool _Update(ref int PersonID, ref int userID, string userName, string password, bool isActive)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE [dbo].[Users]
                           SET [PersonID] = @PersonID
                              ,[UserName] = @UserName
                              ,[Password] = @Password
                              ,[IsActive] = @IsActive
                         WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            cmd.Parameters.AddWithValue("@UserName", userName);


            cmd.Parameters.AddWithValue("@Password", password);


            cmd.Parameters.AddWithValue("@IsActive", isActive);

            cmd.Parameters.AddWithValue("@UserID", userID);


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


        public static bool Save(ref int PersonID, ref int userID, string userName, string password, bool isActive)
        {
            if (userID < 0)
            {
                //Save New
                return _Save(ref PersonID, ref userID, userName, password, isActive);
            }
            else
            {
                //Update
                return _Update(ref PersonID, ref userID, userName, password, isActive);
            }

        }

        public static bool ChangeActive(int userID, bool isActive)
        {
            bool isSaved = false;

            SqlConnection conn = new SqlConnection(DBConnction.ConnectionString);

            string query = @"UPDATE[dbo].[Users]
                             SET
                             [IsActive] = @IsActive
                            WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@IsActive", isActive);

            cmd.Parameters.AddWithValue("@UserID", userID);


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

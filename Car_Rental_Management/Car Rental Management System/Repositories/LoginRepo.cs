using Car_Rental_Management_System.Data;
using Car_Rental_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Car_Rental_Management_System.Repositories
{
    class LoginRepo
    {
        DataAccess dataAccess;
        public LoginRepo()
        {
            dataAccess = new DataAccess();
        }

        public UserEntity LoginValidation(UserEntity ue)
        {
            try
            {
                string sql = "SELECT * FROM Users WHERE Phone ='" + ue.Phone + "' AND [password]='" + ue.Password + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                ue.Phone = (int)reader["Phone"];
                ue.Password = reader["Password"].ToString();
                ue.UserType = (int)reader["UserType"];
                return ue;
            }
            catch
            {
                return null;
            }
        }
    }
}

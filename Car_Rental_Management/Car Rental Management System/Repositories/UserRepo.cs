using Car_Rental_Management_System.Data;
using Car_Rental_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Car_Rental_Management_System.Repositories
{
    class UserRepo
    {
        DataAccess dataAccess;
        public UserRepo()
        {
            dataAccess = new DataAccess();
        }
        public List<UserEntity> GetAllUsers()
        {
            try
            {
                string sql = "SELECT * FROM Users";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<UserEntity> uel = new List<UserEntity>();
                while (reader.Read())
                {
                    UserEntity ue = new UserEntity();

                    ue.Name = reader["Name"].ToString();
                    ue.Email = reader["Email"].ToString();
                    ue.Phone = (int)reader["Phone"];
                    ue.Address = reader["Address"].ToString();

                    uel.Add(ue);
                }
                return uel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public UserEntity GetUIdName(int phone)
        {
            string sql = "select * from Users where Phone = '" + phone + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            UserEntity ue = new UserEntity();
            ue.UId = (int)reader["UId"];
            ue.Name = reader["Name"].ToString();
            return ue;
        }
        public UserEntity GeUserByUserId(int uid)
        {
            string sql = "SELECT * FROM Users where UId = '" + uid + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            UserEntity ue = new UserEntity();
            ue.Name = reader["Name"].ToString();
            ue.Email = reader["Email"].ToString();
            ue.Phone = (int)reader["Phone"];
            ue.Address = reader["Address"].ToString();
            return ue;
        }
    }
}

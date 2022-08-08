using Car_Rental_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_Management_System.Repositories
{
    class SignupRepo
    {
        DataAccess dataAccess;
        public SignupRepo()
        {
            dataAccess = new DataAccess();
        }
        public int Register(string name, string email, int phone, string address, string password, int usertype)
        {
            string sql = "INSERT INTO Users([Name],[Email],phone,[Address],[Password],UserType) " +
                "VALUES('" + name + "','" + email + "','" + phone + "','" + address + "','" + password + "','" + usertype + "')";
            return dataAccess.ExecuteQuery(sql);
        }
    }
}

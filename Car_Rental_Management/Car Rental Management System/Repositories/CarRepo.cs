using Car_Rental_Management_System.Data;
using Car_Rental_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Car_Rental_Management_System.Repositories
{
    class CarRepo
    {
        DataAccess dataAccess;
        public CarRepo()
        {
            dataAccess = new DataAccess();
        }
        public int AddNewCar(string brand, string model, string regno, int rent, string available)
        {
            string sql = "INSERT INTO Cars([Brand],[Model],[RegNo],Rent,[Available]) VALUES('" + brand + "','" + model + "','" + regno + "','" + rent + "','" + available + "')";
            return dataAccess.ExecuteQuery(sql);
        }
        public List<CarEntity> GetAllCars()
        {
            try
            {
                string sql = "SELECT * FROM Cars";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<CarEntity> cel = new List<CarEntity>();
                while (reader.Read())
                {
                    CarEntity ce = new CarEntity();

                    ce.Brand = reader["Brand"].ToString();
                    ce.Model = reader["Model"].ToString();
                    ce.RegNo = reader["RegNo"].ToString();
                    ce.Rent = (int)reader["Rent"];
                    ce.Available = reader["Available"].ToString();

                    cel.Add(ce);
                }
                return cel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public CarEntity GetCarInfo(string regno)
        {
            string sql = "SELECT * FROM Cars WHERE RegNo='" + regno + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            CarEntity ce = new CarEntity();
        
            ce.Rent= (int)reader["Rent"];
            ce.Available = reader["Available"].ToString();

            return ce;
        }
        public int UpdateRentAndAvailable(string regno, int rent, string available)
        {
            try
            {
                string sql = "UPDATE Cars SET Rent='" + rent + "', Available = '" + available + "' WHERE RegNo='" + regno + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int DeleteCarInfo(string regno)
        {
            try
            {
                string sql = "DELETE FROM Cars WHERE RegNo='" + regno + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public List<CarEntity> GetAllAvailableCars(string brand, string available)
        {
            try
            {
                string sql = "SELECT * FROM Cars WHERE Brand = '" + brand + "' and Available = '" + available + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<CarEntity> cel = new List<CarEntity>();
                while (reader.Read())
                {
                    CarEntity ce = new CarEntity();

                    ce.Brand = reader["Brand"].ToString();
                    ce.Model = reader["Model"].ToString();
                    ce.RegNo = reader["RegNo"].ToString();
                    ce.Rent = (int)reader["Rent"];
                    ce.Available = reader["Available"].ToString();

                    cel.Add(ce);
                }
                return cel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int UpdateAvailable(string regno, string available)
        {
            try
            {
                string sql = "UPDATE Cars SET Available = '" + available + "' WHERE RegNo='" + regno + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

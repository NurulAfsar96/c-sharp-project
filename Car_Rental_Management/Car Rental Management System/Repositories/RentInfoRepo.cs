using Car_Rental_Management_System.Data;
using Car_Rental_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Car_Rental_Management_System.Repositories
{
    class RentInfoRepo
    {
        DataAccess dataAccess;
        public RentInfoRepo()
        {
            dataAccess = new DataAccess();
        }
        public int AddNewRentInfo(string brand, string model, string regno, int uid, DateTime rentdate, DateTime returndate, int rentfee, string returnstatuse)
        {
            string sql = "INSERT INTO RentInfo([Brand],[Model],[RegNo],UId,RentDate,ReturnDate,RentFee,ReturnStatuse) VALUES('" + brand + "','" + model + "','" + regno + "','" + uid + "','" + rentdate + "','" + returndate + "','" + rentfee + "','" + returnstatuse + "')";
            return dataAccess.ExecuteQuery(sql);
        }
        public List<RentInfoEntity> GetAllRentInfo()
        {
            try
            {
                string sql = "SELECT * FROM RentInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<RentInfoEntity> riel = new List<RentInfoEntity>();
                while (reader.Read())
                {
                    RentInfoEntity rie = new RentInfoEntity();

                    rie.Brand = reader["Brand"].ToString();
                    rie.Model = reader["Model"].ToString();
                    rie.RegNo = reader["RegNo"].ToString();
                    rie.RentDate = (DateTime)reader["RentDate"];
                    rie.ReturnDate = (DateTime)reader["ReturnDate"];
                    rie.RentFee = (int)reader["RentFee"];
                    //rie.DelayFee = (int)reader["DelayFee"];
                    rie.ReturnStatuse = reader["ReturnStatuse"].ToString();

                    riel.Add(rie);
                }
                return riel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<RentInfoEntity> GetAllRentInfoByUser(int uid)
        {
            try
            {
                string sql = "SELECT * FROM RentInfo WHERE UId='" + uid + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<RentInfoEntity> riel = new List<RentInfoEntity>();
                while (reader.Read())
                {
                    RentInfoEntity rie = new RentInfoEntity();

                    rie.Brand = reader["Brand"].ToString();
                    rie.Model = reader["Model"].ToString();
                    rie.RegNo = reader["RegNo"].ToString();
                    rie.RentDate = (DateTime)reader["RentDate"];
                    rie.ReturnDate = (DateTime)reader["ReturnDate"];
                    rie.RentFee = (int)reader["RentFee"];
                    //rie.DelayFee = (int)reader["DelayFee"];
                    rie.ReturnStatuse = reader["ReturnStatuse"].ToString();

                    riel.Add(rie);
                }
                return riel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int UpdateReturnStatus(string regno, string returnStatus)
        {
            try
            {
                string sql = "UPDATE RentInfo SET ReturnStatuse = '" + returnStatus + "' WHERE RegNo='" + regno + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public RentInfoEntity GetUIdByRegNo(string regno)
        {
            string sql = "select * from RentInfo where RegNo = '" + regno + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            RentInfoEntity rie = new RentInfoEntity();
            rie.UId = (int)reader["UId"];
            return rie;
        }
    }
}

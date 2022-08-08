using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_Management_System.Entities
{
    public class RentInfoEntity
    {
        public int RId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public int UId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int RentFee { get; set; }
        public int DelayFee { get; set; }
        public string ReturnStatuse { get; set; }
    }
}

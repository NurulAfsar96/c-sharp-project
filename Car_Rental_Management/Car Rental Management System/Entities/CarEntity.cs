using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_Management_System.Entities
{
    public class CarEntity
    {
        public int CId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public int Rent { get; set; }
        public string Available { get; set; }
    }
}

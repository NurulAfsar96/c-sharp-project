using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_Management_System.Entities
{
    public class UserEntity
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
    }
}

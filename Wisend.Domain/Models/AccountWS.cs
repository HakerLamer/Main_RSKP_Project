using System;
using Wisend.Domain.Enum;

namespace Wisend.Domain.Models
{
    public class AccountWS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birth { get; set; }
        public string Password { get; set; } //?
        public Gen Gender { get; set; }  
        public string City { get; set; }
        public string Country { get; set; }
    }
}

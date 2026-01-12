using System;

namespace FinalVRM.Models
{
    public class person
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
    

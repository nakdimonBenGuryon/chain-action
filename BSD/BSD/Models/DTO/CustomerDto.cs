using chinasA.Models;
using System.ComponentModel.DataAnnotations;

namespace BSD.Models.DTO
{
    public class CustomerDto
    {
        
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public int Password { get; set; }

        //public Purchase Purchases { get; set; }

        //public Gift Gifts { get; set; }
    }
}

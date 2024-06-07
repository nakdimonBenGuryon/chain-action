using chinasA.Models;
using System.ComponentModel.DataAnnotations;

namespace BSD.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public int Password { get; set; }

        public IEnumerable<Purchase> Purchases { get; set; }
    
        public IEnumerable<Gift> Gifts { get; set; }
    }
}

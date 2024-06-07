using BSD.Models;
using System.ComponentModel.DataAnnotations;

namespace chinasA.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Card> Cards { get; set; }

    }
}

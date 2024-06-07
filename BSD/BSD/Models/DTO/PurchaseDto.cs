using chinasA.Models;
using System.ComponentModel.DataAnnotations;

namespace BSD.Models.DTO
{
    public class PurchaseDto
    {
        public bool Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //public IEnumerable<Card> Cards { get; set; }
    }
}

using BSD.Models;
using System.ComponentModel.DataAnnotations;

namespace chinasA.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int GiftId { get; set; }
        public float Price { get; set; }
        public Gift Gift { get; set; }

    }
}

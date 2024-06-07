using System.ComponentModel.DataAnnotations;

namespace BSD.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public float Price { get; set; }
        public int DonationId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Donation Donation { get; set; }

    }
}

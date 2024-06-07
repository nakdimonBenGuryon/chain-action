using System.ComponentModel.DataAnnotations;

namespace BSD.Models
{
    public class Category
    {
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
    }
}

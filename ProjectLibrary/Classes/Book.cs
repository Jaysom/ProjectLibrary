using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLibrary.Classes
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        public double Price { get; set; }

        [StringLength(200)]
        public string Terms { get; set; }

        public int Related { get; set; }
    }
}
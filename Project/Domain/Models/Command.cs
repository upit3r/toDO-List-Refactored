using System.ComponentModel.DataAnnotations;

namespace Domain.Models{
    public class Command{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Heading { get; set; }
        [MaxLength(250)]
        [Required]
        public string Description { get; set; }
        [Required]
        public string Signature { get; set; }

    }
}
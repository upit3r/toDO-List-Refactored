using System.ComponentModel.DataAnnotations;
namespace Client{
    public class CommandUpdateDto{
        [Required]
        public string Heading { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public string Signature { get; set; }

    }
}
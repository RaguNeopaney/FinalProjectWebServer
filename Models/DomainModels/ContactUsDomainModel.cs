using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectWebServer.Models.DomainModels
{
    [Table("ContectUs")]
    public class ContactUsDomainModel
    {
        [Key]
        public int ContactUsMail { get; set; }

        [Column]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "TEXT")]
        [Required]
        public string Messsage { get; set; }
    }
}
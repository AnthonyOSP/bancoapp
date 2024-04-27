using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bancoapp.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {   get; set;}
        public string? Name { get; set; }
        public string? AccountType { get; set; }
        public Decimal Balance { get; set; }
        public string? Email { get; set; }
    }
}
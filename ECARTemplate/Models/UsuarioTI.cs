using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECARTemplate.Models
{
    public class UsuarioTI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Código de Usuario TI")]
        public string CodigoUsuarioTi { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Rol TI")]
        public string RolTi { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre de Usuario TI")]
        public string NombreUsuarioTi { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Usuario TI")]
        public string UsuarioTi { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Contraseña")]
        public string ContrasenaUsuarioTi { get; set; }
    }
}
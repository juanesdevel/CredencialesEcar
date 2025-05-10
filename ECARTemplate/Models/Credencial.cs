using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECARTemplate.Models
{
    public class Credencial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Código del Equipo")]
        public string CodigoEquipo { get; set; }

        [Display(Name = "Fecha y Hora de Creación")]
        public DateTime? FechaHora { get; set; }

        [MaxLength(100)]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Código de Usuario ECAR")]
        public string CodigoUsuarioEcar { get; set; }

        [MaxLength(100)]
        [Display(Name = "Perfil")]
        public string Perfil { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        [MaxLength(50)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [MaxLength(50)]
        [Display(Name = "Usuario TI (Registro)")]
        public string UsuarioTiRegistro { get; set; }

        [Display(Name = "Fecha de Modificación")]
        public DateTime? FechaModificacion { get; set; }

        // Opcional:
        // [MaxLength(50)]
        // [Display(Name = "Usuario TI (Modificación)")]
        // public string UsuarioTiModificacion { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECARTemplate.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Código de Usuario ECAR")]
        public string CodigoUsuarioEcar { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime? Fecha { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nombre del Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Firma BPM")]
        public string FirmaBpm { get; set; }

        [MaxLength(100)]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [MaxLength(50)]
        [Display(Name = "Área")]
        public string Area { get; set; }

        [MaxLength(50)]
        [Display(Name = "Sub Área")]
        public string SubArea { get; set; }

        [Display(Name = "Nota")]
        public string Nota { get; set; }

        [MaxLength(10)]
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
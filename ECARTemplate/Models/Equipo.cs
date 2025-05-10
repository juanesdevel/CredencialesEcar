using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECARTemplate.Models
{
    public class Equipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Código del Equipo")]
        public string CodigoEquipo { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime? Fecha { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nombre del Equipo")]
        public string NombreEquipo { get; set; }

        [MaxLength(50)]
        [Display(Name = "Sede")]
        public string Sede { get; set; }

        [MaxLength(50)]
        [Display(Name = "Área")]
        public string Area { get; set; }

        [MaxLength(50)]
        [Display(Name = "Sub Área")]
        public string SubArea { get; set; }

        [Display(Name = "Nota")]
        public string Nota { get; set; }

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
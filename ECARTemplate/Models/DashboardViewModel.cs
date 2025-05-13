namespace ECARTemplate.Models
{
    public class DashboardViewModel
    {
        public int TotalEquipos { get; set; }
        public int EquiposActivos { get; set; }
        public int EquiposInactivos { get; set; }

        public int TotalUsuarios { get; set; }
        public int UsuariosActivos { get; set; }
        public int UsuariosInactivos { get; set; }

        public int TotalUsuariosTI { get; set; }

        public int TotalCredenciales { get; set; }
        public int CredencialesActivas { get; set; }
        public int CredencialesInactivas { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using ECARTemplate.Data;
using ECARTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System;

namespace ECARTemplate.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string _databaseName;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
            _databaseName = _context.Database.GetDbConnection().Database;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardViewModel
            {
                TotalEquipos = await _context.Equipos.CountAsync(),
                EquiposActivos = await _context.Equipos.CountAsync(e => e.Estado == "Activo"),
                EquiposInactivos = await _context.Equipos.CountAsync(e => e.Estado == "Inactivo"),

                TotalUsuarios = await _context.Usuarios.CountAsync(),
                UsuariosActivos = await _context.Usuarios.CountAsync(u => u.Estado == "Activo"),
                UsuariosInactivos = await _context.Usuarios.CountAsync(u => u.Estado == "Inactivo"),

                TotalUsuariosTI = await _context.UsuariosTI.CountAsync(),

                TotalCredenciales = await _context.Credenciales.CountAsync(),
                CredencialesActivas = await _context.Credenciales.CountAsync(c => c.Estado == "Activo"),
                CredencialesInactivas = await _context.Credenciales.CountAsync(c => c.Estado == "Inactivo")
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GenerarBackup()
        {
            string backupPath = Path.Combine(Directory.GetCurrentDirectory(), "Backups");
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }
            string fileName = $"Backup_{_databaseName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            string fullBackupPath = Path.Combine(backupPath, fileName);
            string connectionString = _context.Database.GetConnectionString();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand($"BACKUP DATABASE {_databaseName} TO DISK = @backupPath", connection))
                    {
                        command.Parameters.AddWithValue("@backupPath", fullBackupPath);
                        command.ExecuteNonQuery();
                    }
                }

                var fileBytes = System.IO.File.ReadAllBytes(fullBackupPath);
                return File(fileBytes, "application/octet-stream", fileName);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Ocurrió un error al generar el backup: {ex.Message}";
            }
            finally
            {
                // Opcional: Puedes decidir si quieres eliminar el archivo del servidor después de la descarga
                // System.IO.File.Delete(fullBackupPath);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using ECARTemplate.Data; // Asegúrate de que este sea el namespace correcto para tu ApplicationDbContext
using ECARTemplate.Models; // Asegúrate de que este sea el namespace correcto para tu modelo Usuario
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECARTemplate.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public IActionResult Index()
        {
            // Pasa una colección vacía a la vista
            return View(new List<Usuario>());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoUsuarioEcar,NombreUsuario,FirmaBpm,Cargo,Area,Nota,Estado,UsuarioTiRegistro")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoUsuarioEcar,NombreUsuario,FirmaBpm,Cargo,Area,Nota,Estado,UsuarioTiRegistro")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        // GET: Usuarios/Activar/5
        public async Task<IActionResult> Activar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Estado = "Activo"; // Asegúrate de que "Activo" coincida con tu modelo
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Usuarios/Inactivar/5
        public async Task<IActionResult> Inactivar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Estado = "Inactivo"; // Asegúrate de que "Inactivo" coincida con tu modelo
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        // GET: Usuarios/Buscar
        public IActionResult Buscar(string term)
        {
            if (string.IsNullOrEmpty(term))
            {
                return Json(new List<Usuario>()); // Devuelve una lista vacía si no hay término de búsqueda
            }

            var resultados = _context.Usuarios
                .Where(u => u.CodigoUsuarioEcar.Contains(term) || u.NombreUsuario.Contains(term))
                .Select(u => new
                {
                    id = u.Id,
                    codigoUsuarioEcar = u.CodigoUsuarioEcar,
                    nombreUsuario = u.NombreUsuario,
                    firmaBpm = u.FirmaBpm,
                    cargo = u.Cargo,
                    area = u.Area,
                    nota = u.Nota,
                    estado = u.Estado,
                    usuarioTiRegistro = u.UsuarioTiRegistro
                })
                .ToList();

            return Json(resultados);
        }
    }
}
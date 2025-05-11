using Microsoft.AspNetCore.Mvc;
using ECARTemplate.Data; // Importa tu ApplicationDbContext
using ECARTemplate.Models; // Importa tu modelo Usuario
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
        public async Task<IActionResult> Create([Bind("Id,CodigoUsuarioEcar,Fecha,NombreUsuario,FirmaBpm,Cargo,Area,SubArea,Nota,Estado,UsuarioTiRegistro,FechaModificacion")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (await _context.Usuarios.AnyAsync(u => u.CodigoUsuarioEcar == usuario.CodigoUsuarioEcar))
                {
                    ModelState.AddModelError("CodigoUsuarioEcar", "Ya existe un usuario con este código.");
                    return View(usuario);
                }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoUsuarioEcar,Fecha,NombreUsuario,FirmaBpm,Cargo,Area,SubArea,Nota,Estado,UsuarioTiRegistro,FechaModificacion")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (await _context.Usuarios.AnyAsync(u => u.CodigoUsuarioEcar == usuario.CodigoUsuarioEcar && u.Id != usuario.Id))
                    {
                        ModelState.AddModelError("CodigoUsuarioEcar", "Ya existe otro usuario con este código.");
                        return View(usuario);
                    }

                    usuario.FechaModificacion = DateTime.Now;
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
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

        public async Task<IActionResult> Buscar(string term)
        {
            var usuariosFiltrados = await _context.Usuarios
                .Where(u => u.CodigoUsuarioEcar.Contains(term) || u.NombreUsuario.Contains(term))
                .ToListAsync();

            return Json(usuariosFiltrados);
        }
    }
}
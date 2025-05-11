using Microsoft.AspNetCore.Mvc;
using ECARTemplate.Data;
using ECARTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ECARTemplate.Controllers
{
    public class CredencialesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CredencialesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Credenciales
        public async Task<IActionResult> Index()
        {
            return View(await _context.Credenciales.ToListAsync());
        }

        // GET: Credenciales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credenciales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (credencial == null)
            {
                return NotFound();
            }

            return View(credencial);
        }

        // GET: Credenciales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Credenciales/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoEquipo,FechaHora,NombreUsuario,CodigoUsuarioEcar,Perfil,Usuario,Contrasena,Estado,UsuarioTiRegistro")] Credencial credencial)
        {
            if (ModelState.IsValid)
            {
                // Validar si ya existe un usuario con el mismo CodigoUsuarioEcar para este CodigoEquipo
                if (await _context.Credenciales.AnyAsync(c => c.CodigoEquipo == credencial.CodigoEquipo && c.CodigoUsuarioEcar == credencial.CodigoUsuarioEcar))
                {
                    ModelState.AddModelError("CodigoUsuarioEcar", $"Ya existe un usuario con el código '{credencial.CodigoUsuarioEcar}' para el equipo '{credencial.CodigoEquipo}'.");
                    return View(credencial);
                }

                credencial.FechaHora = DateTime.Now;
                _context.Add(credencial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(credencial);
        }

        // GET: Credenciales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credenciales.FindAsync(id);
            if (credencial == null)
            {
                return NotFound();
            }
            return View(credencial);
        }

        // POST: Credenciales/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoEquipo,FechaHora,NombreUsuario,CodigoUsuarioEcar,Perfil,Usuario,Contrasena,Estado,UsuarioTiRegistro")] Credencial credencial)
        {
            if (id != credencial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Validar si ya existe otro usuario con el mismo CodigoUsuarioEcar para este CodigoEquipo (excluyendo el registro actual)
                if (await _context.Credenciales.AnyAsync(c => c.Id != credencial.Id && c.CodigoEquipo == credencial.CodigoEquipo && c.CodigoUsuarioEcar == credencial.CodigoUsuarioEcar))
                {
                    ModelState.AddModelError("CodigoUsuarioEcar", $"Ya existe otro usuario con el código '{credencial.CodigoUsuarioEcar}' para el equipo '{credencial.CodigoEquipo}'.");
                    return View(credencial);
                }

                try
                {
                    credencial.FechaModificacion = DateTime.Now;
                    _context.Update(credencial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CredencialExists(credencial.Id))
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
            return View(credencial);
        }

        // GET: Credenciales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credenciales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (credencial == null)
            {
                return NotFound();
            }

            return View(credencial);
        }

        // POST: Credenciales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var credencial = await _context.Credenciales.FindAsync(id);
            _context.Credenciales.Remove(credencial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Credenciales/Activar/5
        public async Task<IActionResult> Activar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credenciales.FindAsync(id);
            if (credencial == null)
            {
                return NotFound();
            }

            credencial.Estado = "Activo";
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
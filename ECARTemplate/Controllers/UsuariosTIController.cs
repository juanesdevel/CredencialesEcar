using Microsoft.AspNetCore.Mvc;
using ECARTemplate.Data;
using ECARTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECARTemplate.Controllers
{
    public class UsuariosTIController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosTIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsuariosTI
        public async Task<IActionResult> Index() // Cambiado de Listar a Index
        {
            return View(await _context.UsuariosTI.ToListAsync());
        }

        // GET: UsuariosTI/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // To resolve the MVC1004 diagnostic, rename the parameter in the Crear method to avoid conflict with the property name in the UsuarioTI class.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(UsuarioTI nuevoUsuarioTI) // Renamed parameter to 'nuevoUsuarioTI'
        {
            if (ModelState.IsValid)
            {
                _context.Add(nuevoUsuarioTI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirigimos a Index
            }
            return View(nuevoUsuarioTI);
        }

        // GET: UsuariosTI/Editar/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioTI = await _context.UsuariosTI.FindAsync(id);
            if (usuarioTI == null)
            {
                return NotFound();
            }
            return View(usuarioTI);
        }

        // POST: UsuariosTI/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, UsuarioTI usuarioTIActualizado) // Renamed parameter to 'usuarioTIActualizado'
        {
            if (id != usuarioTIActualizado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioTIActualizado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioTIExists(usuarioTIActualizado.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirigimos a Index
            }
            return View(usuarioTIActualizado);
        }

        // GET: UsuariosTI/Eliminar/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioTI = await _context.UsuariosTI.FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioTI == null)
            {
                return NotFound();
            }
            return View(usuarioTI);
        }

        // POST: UsuariosTI/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmado(int id)
        {
            var usuarioTI = await _context.UsuariosTI.FindAsync(id);
            _context.UsuariosTI.Remove(usuarioTI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); // Redirigimos a Index
        }

        private bool UsuarioTIExists(int id)
        {
            return _context.UsuariosTI.Any(e => e.Id == id);
        }
    }
}
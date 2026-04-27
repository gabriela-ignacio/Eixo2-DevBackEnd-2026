using mf_dev_backend_2026.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace mf_dev_backend_2026.Controllers
{
    public class VeiculosController : Controller 
    {
        private readonly AppDBContext _context;

        public VeiculosController(AppDBContext context) 
        { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculos.Add(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }    

            return View(veiculo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            
            var dados = await _context.Veiculos.FindAsync(id);
            
            if (dados == null)
                return NotFound();
            
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Veiculo dados)
        {
            if (Id != dados.Id)
                return NotFound();


            if (ModelState.IsValid)
            {
                _context.Veiculos.Update(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(Id);

            if (dados == null)
                return NotFound(); 

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(Id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            if(Id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(Id);
            
            if (dados == null)
                return NotFound();

            _context.Veiculos.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}

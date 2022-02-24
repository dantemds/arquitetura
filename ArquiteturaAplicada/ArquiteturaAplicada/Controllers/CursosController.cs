using ArquiteturaAplicada.Models;
using ArquiteturaAplicada.Rrepository;
using ArquiteturaAplicada.Rrepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArquiteturaAplicada.Controllers
{
    public class CursosController : Controller
    {
        private readonly ICrudRepo _crud;
        public CursosController(ICrudRepo crud)
        {
            this._crud = crud;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConfirmaçãoComprar()
        {
            return View();
        }
        public IActionResult CriarCursos()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarCurso(Cursos curso)
        {
            _crud.Add(curso);
            await _crud.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

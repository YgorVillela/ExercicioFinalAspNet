using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioAspCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioAspCore.Controllers
{
    public class GeneroController : Controller
    {
        private IGeneroRepository _generoRepository;

        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Genero genero)
        {
            if (ModelState.IsValid)
            {
                _generoRepository.Cadastrar(genero);
                _generoRepository.Salvar();
                TempData["msg"] = "Cadastrado com sucesso!!!";
                return RedirectToAction("Cadastrar");
            }

            return View();
        }
            
        
    }
}
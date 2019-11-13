using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioAspCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExercicioAspCore.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _jogoRepository;
        private IGeneroRepository _generoRepository;

        public JogoController(IJogoRepository jogoRepository, IGeneroRepository generoRepository)
        {
            _jogoRepository = jogoRepository;
            _generoRepository = generoRepository;
        }

        private void CarregarGeneros()
        {
            var lista = _generoRepository.Listar();
            ViewBag.generos = new SelectList("lista", "GeneroId","Nome");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarGeneros();
            return View();

        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _jogoRepository.Cadastrar(jogo);
                _jogoRepository.Salvar();
                TempData["msg"] = "Cadastrado com sucesso!!!";
                return RedirectToAction("Cadastrar");
            }
            CarregarGeneros();
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            CarregarGeneros();
            return View(_jogoRepository.Listar());
        }
    }
}
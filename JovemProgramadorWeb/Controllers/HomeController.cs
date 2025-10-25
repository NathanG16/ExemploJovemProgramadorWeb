using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JovemProgramadorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly ITurmaRepositorio _turmaRepositorio;

        public HomeController(ILogger<HomeController> logger, IAlunoRepositorio alunoRepositorio, 
            ITurmaRepositorio turmaRepositorio)
        {
            _logger = logger;
            _alunoRepositorio = alunoRepositorio;
            _turmaRepositorio = turmaRepositorio;   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            var alunos = _alunoRepositorio.BuscarAlunos();
            var turmas = _turmaRepositorio.BuscarTurmas();

            List<RelatorioViewModel> relatorioViewModels = alunos
                .Select(x => new RelatorioViewModel
                {
                    Aluno = x,
                    Turma = turmas.FirstOrDefault(y => y.Id == x.IdTurma)
                }).ToList();

            return View(relatorioViewModels);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

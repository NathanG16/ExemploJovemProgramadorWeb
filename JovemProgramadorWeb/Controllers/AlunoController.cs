using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;   
        }
        public IActionResult Index() 
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult CadastrarAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.CadastrarAluno(aluno);

                TempData["MsgOk"] = "Aluno Cadastrado com sucesso!!!";

                return RedirectToAction("Index", "Aluno");
            
            }
            catch (Exception e)
            {

                TempData["MsgErro"] = "Erro ao cadastrar Aluno";
            }
           

            return View("Index");
        }
    }
}

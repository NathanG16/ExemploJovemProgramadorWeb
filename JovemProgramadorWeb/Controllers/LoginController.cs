using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                if(usuario.Email == "katia@gmail" && usuario.Senha == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Usuário ou senha incorretos! Tente novamente...";
                }
            }
            catch (Exception)
            {

                TempData["MsgErro"] = "Erro ao buscar dados do usuário";
            }

            return View("Index");
        }

    }
}

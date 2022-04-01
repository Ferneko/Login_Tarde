using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Tarde.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {
            return View( 0 );
        }

        [HttpPost]
        public IActionResult Entrar(string usuario, string senha)
        {
            if(usuario == "admin" && senha == "123")
            {
                //Logado com sucesso
                return View( 1 );
            }
            else
            {
                //return View( 2 );
                return RedirectToAction("FalhaLogin");
            }
        }

        public IActionResult FalhaLogin()
        {
            return View();
        }
    }
}

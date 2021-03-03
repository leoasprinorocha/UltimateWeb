using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateWeb.Contracts;

namespace UltimateWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService _userService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _userService = usuarioService;
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string user, string senha)
        {
            var valida = _userService.Login(user, senha);
            
            TempData["dadosLogin"] = valida;

            if (valida)
            {
                return RedirectToAction();
            }

        }


        [HttpGet]

        public IActionResult Logado()
        {
            return View();
        }
    }
}

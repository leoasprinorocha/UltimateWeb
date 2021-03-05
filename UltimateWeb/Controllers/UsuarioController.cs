using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateWeb.Contracts;
using UltimateWeb.Models;
using UltimateWeb.Services;

namespace UltimateWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _userService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _userService = usuarioService;
        }



        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string senha)
        {
            var valida = _userService.Login(user, senha);
            
            TempData["dadosLogin"] = valida;
            TempData["nomeUser"] = user;

            if (valida)
                return RedirectToAction("Logado", "Usuario");

            else
            {
              
                return RedirectToAction("Index", "Usuario");
            }
        }


        [HttpGet]

        public IActionResult Logado(Usuario user)
        {
            return View(user);
        }


        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public bool CreateUser(string user, string senha, string email, int permissao)
        {
            var valida = _userService.CreateUser(user, senha, email, permissao);
            if (valida)
                return true;
            else
                return false;
        }
    }
}

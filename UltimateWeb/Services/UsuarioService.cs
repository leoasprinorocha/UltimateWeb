using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateWeb.Contracts;
using UltimateWeb.Data;
using UltimateWeb.Models;

namespace UltimateWeb.Services
{
    public class UsuarioService : IUsuarioService
    {
        private UltimateWebContext _context;

        public UsuarioService(UltimateWebContext context)
        {
            _context = context;
        }

        public bool Login(string userName, string senha)
        {
            var user = _context.Usuario.FirstOrDefault(c => c.Username == userName);
            if (user == null)
            {
                return false;
            }

            if (user.Senha != senha)
            {
                return false;
            }

            return true;
            
            
            
        }
    }


}

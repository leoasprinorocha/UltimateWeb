using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateWeb.Contracts
{
    public interface IUsuarioService
    {
        public bool Login(string userName, string senha);
    }
}

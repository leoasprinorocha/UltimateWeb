using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateWeb.Models
{
    public class Usuario
    {
        [Key]
        public string Username { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        //0 usuario global admin, 1 usuario administrativo, 2 usuario comum
        public int Permissoes { get; set; }

        public Usuario(string username, string senha, string email, int permissoes)
        {
            Username = username;
            Senha = senha;
            Email = email;
            Permissoes = permissoes;


        }
    }
}

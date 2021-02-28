using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateWeb.Models
{
    public class Treinador
    {
        public string Nome { get; set; }

        [Key]
        public string CPF { get; set; }

        public ICollection<Aluno> Alunos { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Categoria { get; set; }

        public int Idade { get; set; }


        public Treinador()
        {

        }


        public Treinador(string nome, string cPF, ICollection<Aluno> alunos, string telefone, string endereco, string categoria, int idade)
        {
            Nome = nome;
            CPF = cPF;
            Alunos = alunos;
            Telefone = telefone;
            Endereco = endereco;
            Categoria = categoria;
            Idade = idade;
        }
    }
}

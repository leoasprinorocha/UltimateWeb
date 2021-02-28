using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateWeb.Models
{
    public class Aluno
    {

        public string Nome { get; set; }

        [Key]
        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public int idade { get; set; }

        public string Categoria { get; set; }

        [NotMapped]
        public ICollection<Treinador> Treinadores { get; set; }



        public Aluno()
        {

        }


        public Aluno(string nome, string cpf, string telefone, string endereco, int idade, string categoria, ICollection<Treinador> treinadores)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            this.idade = idade;
            Categoria = categoria;
            Treinadores = treinadores;
        }
    }
}




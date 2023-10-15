using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudAluno.Aluno
{
    public class Alunos
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set;}
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public bool Ativo { get; set; }
    }
}
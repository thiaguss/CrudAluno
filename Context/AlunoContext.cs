using CrudAluno.Aluno;
using Microsoft.EntityFrameworkCore;

namespace CrudAluno.AlunoContext
{
    public class AlunoContexts : DbContext
    {
        public AlunoContexts(DbContextOptions<AlunoContexts> options) : base(options)
        {

        }
        public DbSet<Alunos> Alunos {get; set;}
    }
}
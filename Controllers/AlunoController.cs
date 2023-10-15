using CrudAluno.Aluno;
using CrudAluno.AlunoContext;
using Microsoft.AspNetCore.Mvc;

namespace CrudAluno.AlunoController
{
    [ApiController]
    [Route("controller")]
    public class AlunoController : Controller
    {
        private readonly AlunoContexts _aluno;
        public AlunoController(AlunoContexts aluno)
        {
            _aluno = aluno;
        }

        [HttpPost("Adicionar")]
        public IActionResult Create(string nome, DateTime dataNascimento, string nomePai, string nomeMae, bool ativo)
        {
            var aluno = new Alunos
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                NomePai = nomePai,
                NomeMae = nomeMae,
                Ativo = ativo
            };

            _aluno.Add(aluno);
            _aluno.SaveChanges();

            return Ok();
        }
        
        [HttpGet("PesquisarId")]
        public IActionResult ObterId(int id)
        {
            var alunoId = _aluno.Alunos.Find(id);
            if(alunoId == null)
                return NotFound();

            return Ok(alunoId);    
        }

        [HttpGet("PesquisarNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var alunoNome = _aluno.Alunos.Where(x => x.Nome.Contains(nome));
            return Ok(alunoNome);
        }
    }
}
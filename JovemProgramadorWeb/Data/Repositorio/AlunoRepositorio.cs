using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio
{

    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void CadastrarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }

        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();   
        }

        public void ExcluirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        }
        public List<Aluno> BuscaAlunoPorNome(string nome)
        {
            return _bancoContexto.Aluno.Where(x => x.Nome.Contains(nome)).ToList();
        }
    }
}

using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        void CadastrarAluno(Aluno aluno);
        List<Aluno> BuscarAlunos();
        void EditarAluno(Aluno aluno);
        void ExcluirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        List<Aluno> BuscaAlunoPorNome(string nome);
    }
}

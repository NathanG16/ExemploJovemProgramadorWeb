using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        void CadastrarAluno(Aluno aluno);

        List<Aluno> BuscarAlunos();
    }
}

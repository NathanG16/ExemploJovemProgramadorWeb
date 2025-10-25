using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio
{
    public class TurmaRepositorio : ITurmaRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public TurmaRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Turma> BuscarTurmas()
        {
            return _bancoContexto.Turma.ToList();
        }
    }

}
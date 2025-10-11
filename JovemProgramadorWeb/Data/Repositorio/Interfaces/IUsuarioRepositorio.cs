using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void CadastrarUsuario(Usuario usuario);

        Usuario ValidarUsuario(Usuario usuario);
    }
}

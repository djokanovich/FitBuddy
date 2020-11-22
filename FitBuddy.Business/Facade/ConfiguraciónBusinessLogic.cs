using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IConfiguraciónBusinessLogic
    {
        Idioma[] ObtenerIdiomas();
        bool ActualizarUsuarioIdioma(int usuarioId, Idioma idioma);
    }

    public class ConfiguraciónBusinessLogic : IConfiguraciónBusinessLogic
    {
        private readonly IRepositorio<Idioma> _idiomaRepositorio;
        private readonly IRepositorio<Usuario> _usuarioRepositorio;

        public ConfiguraciónBusinessLogic(IRepositorio<Idioma> idiomaRepositorio, IRepositorio<Usuario> usuarioRepositorio)
        {
            _idiomaRepositorio = idiomaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Idioma[] ObtenerIdiomas()
        {
            return _idiomaRepositorio.Todos().ToArray();
        }

        public bool ActualizarUsuarioIdioma(int usuarioId, Idioma idioma)
        {
            var usuario = _usuarioRepositorio.ObtenerPorClavePrimaria(usuarioId);
            usuario.IdiomaId = idioma.Id;
            usuario.Idioma = idioma;

            _usuarioRepositorio.ActualizarExistente(usuario);
            return _usuarioRepositorio.GuardarCambios() > 0;
        }
    }
}

using System.Linq;
using Common.Utilidades;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ILogInBusinessLogic
    {
        (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword);
        void IntentoFallidoDeLogin(Usuario usuario);
    }

    public class LogInBusinessLogic : ILogInBusinessLogic
    {
        private readonly IHashService _hashService;
        private readonly IRepositorio<Usuario> _usuarioRepositorio;

        public LogInBusinessLogic(IHashService hashService, IRepositorio<Usuario> usuarioRepositorio)
        {
            _hashService = hashService;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword)
        {
            var hashedPassword = _hashService.Hash(plainPassword);

            var usuario = _usuarioRepositorio.BuscarPor(u => u.Username == username).SingleOrDefault();

            return (usuario, usuario != null && usuario.Password == hashedPassword);
        }

        public void IntentoFallidoDeLogin(Usuario usuario)
        {
            ++usuario.IntentosFallidos;
            _usuarioRepositorio.ActualizarExistente(usuario);
            _usuarioRepositorio.GuardarCambios();
        }
    }
}

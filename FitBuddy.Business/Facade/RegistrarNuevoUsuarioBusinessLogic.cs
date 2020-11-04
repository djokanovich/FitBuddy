using System.Linq;
using Common.Utilidades;
using FitBuddy.Business.Validators;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IRegistrarNuevoUsuarioBusinessLogic
    {
        int ContraseñaLongitudMínima { get; }
        bool ExisteNombreDeUsuario(string username);
        bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainPassword);
        bool EsContraseñaVálida(string contraseña);
        bool EsEmailVálido(string email);
    }

    public class RegistrarNuevoUsuarioBusinessLogic : IRegistrarNuevoUsuarioBusinessLogic
    {
        private readonly IMd5HashingService _md5HashingService;
        private readonly IRepositorio<Usuario> _usuarioRepositorio;
        private readonly IPasswordValidator _passwordValidator;
        private readonly IEmailValidator _emailValidator;

        public int ContraseñaLongitudMínima => _passwordValidator.ContraseñaLongitudMínima;

        public RegistrarNuevoUsuarioBusinessLogic(
            IMd5HashingService md5HashingService,
            IRepositorio<Usuario> usuarioRepositorio,
            IPasswordValidator passwordValidator,
            IEmailValidator emailValidator)
        {
            _md5HashingService = md5HashingService;
            _usuarioRepositorio = usuarioRepositorio;
            _passwordValidator = passwordValidator;
            _emailValidator = emailValidator;
        }

        public bool ExisteNombreDeUsuario(string username)
        {
            var usuario = _usuarioRepositorio.BuscarPor(u => u.Username == username).SingleOrDefault();
            return usuario != null;
        }

        public bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainPassword)
        {
            var hashedPassword = _md5HashingService.CalcularHash(plainPassword);

            usuario.Password = hashedPassword;

            _usuarioRepositorio.AgregarNuevo(usuario);

            return _usuarioRepositorio.GuardarCambios() > 0;
        }

        public bool EsContraseñaVálida(string contraseña)
        {
            return _passwordValidator.EsContraseñaVálida(contraseña);
        }

        public bool EsEmailVálido(string email)
        {
            return _emailValidator.EsEmailVálido(email);
        }
    }
}

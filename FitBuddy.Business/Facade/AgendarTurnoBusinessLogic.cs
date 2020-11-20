using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Common.Bitacora;
using Common.Utilidades;
using FitBuddy.Business.Modelos;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IAgendarTurnoBusinessLogic
    {
        List<Médico> ObtenerMédicos();
        string LimpiarClave(string claveSucia);
        bool EnviarCitaPorEmail(AgendarTurnoModelo agendarTurnoModelo);
    }

    public class AgendarTurnoBusinessLogic : IAgendarTurnoBusinessLogic
    {
        private readonly IRepositorio<Médico> _médicoRepositorio;
        private readonly IEmailService _emailService;
        private readonly IBitacora<AgendarTurnoBusinessLogic> _bitacora;

        public AgendarTurnoBusinessLogic(IRepositorio<Médico> médicoRepositorio, IEmailService emailService, IBitacora<AgendarTurnoBusinessLogic> bitacora)
        {
            _médicoRepositorio = médicoRepositorio;
            _emailService = emailService;
            _bitacora = bitacora;
        }

        public List<Médico> ObtenerMédicos()
        {
            return _médicoRepositorio.Todos().ToList();
        }

        /// <summary>
        /// If you're giving the application to untrustworthy users (i.e. this is a desktop app,
        /// rather than code running on an [ASP] server that users can't access directly) then
        /// there's nothing that you can do [to protect a password].
        /// https://stackoverflow.com/questions/12864120/need-to-hard-code-a-password
        /// </summary>
        /// <param name="claveSucia"></param>
        /// <returns></returns>
        public string LimpiarClave(string claveSucia)
        {
            try
            {
                return Encoding.ASCII.GetString(claveSucia.Split('|').Select(s => byte.Parse(s)).Reverse().Select(b => Procesar(b)).ToArray());
            }
            catch (Exception e)
            {
                _bitacora.Error($"Error al limpiar la clave sucia: {claveSucia}. Detalles de la excepción:\n{e.Message}");
                return string.Empty;
            }

            byte Procesar(byte input)
            {
                byte output = 0;
                for (int i = 0; i < 8; i++)
                {
                    var filter = 1 << i;
                    output += (byte)(((input & filter) == 0 ? 0 : 1) << 7 - i);
                }

                return output;
            }
        }

        public bool EnviarCitaPorEmail(AgendarTurnoModelo agendarTurnoModelo)
        {
            var fromAddress = agendarTurnoModelo.NetworkCredentialsEmail;
            var fromName = agendarTurnoModelo.NombrePaciente;
            var toAddress = agendarTurnoModelo.EmailMédico;
            var toName = agendarTurnoModelo.NombreMédico;
            string asuntoMensaje = "FitBuddy mailing service";
            var cuerpoMensaje = agendarTurnoModelo.Mensaje
                .Replace("{NombreDoctor}", agendarTurnoModelo.NombreMédico)
                .Replace("{NombrePaciente}", agendarTurnoModelo.NombrePaciente)
                .Replace("{FechaTurno}", agendarTurnoModelo.Fecha.ToLongDateString())
                .Replace("{HoraTurno}", agendarTurnoModelo.Hora);

            MailMessage mailMessage;

            try
            {
                mailMessage = _emailService.CrearMensaje(fromAddress, fromName, toAddress, toName, replyTo: null, asuntoMensaje, cuerpoMensaje, conFormatoHtml: true);
            }
            catch (Exception e)
            {
                _bitacora.Error(e.Message);
                return false;
            }

            var smtpClientHost = agendarTurnoModelo.SmtpClientHost;
            var smtpClientPort = agendarTurnoModelo.SmtpClientPort;
            var networkCredentialsPassword = agendarTurnoModelo.NetworkCredentialsPassword;

            try
            {
                _emailService.Enviar(smtpClientHost, smtpClientPort, fromAddress, networkCredentialsPassword, mailMessage);
            }
            catch (Exception e)
            {
                _bitacora.Error(e.Message);
                return false;
            }

            return true;
        }
    }
}

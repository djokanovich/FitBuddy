using Common.Bitacora;
using FitBuddy.Business;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI
{
    internal class FitBuddyApp
    {
        private readonly IBitacora _bitacora;
        private readonly IServicioIntegridadBLL _servicioIntegridadBLL;

        public FitBuddyApp(IBitacora bitacora, IServicioIntegridadBLL servicioIntegridadBLL)
        {
            _bitacora = bitacora;
            _servicioIntegridadBLL = servicioIntegridadBLL;
        }

        public event EventHandler AbrirVentanaPrincipal;

        public void Iniciar()
        {
            if (AbrirVentanaPrincipal == null)
                throw new Exception("No se configuró ningún evento para abrir la ventana principal.");

            _bitacora.Info("Aplicación iniciada.");

            VerificarIntegridadDb();

            AbrirVentanaPrincipal.Invoke(this, new EventArgs());
        }

        private void VerificarIntegridadDb()
        {
            bool dbTieneIntegridad = _servicioIntegridadBLL.DbTieneIntegridad();
            if (dbTieneIntegridad)
            {
                _bitacora.Info("Integridad de la base de datos verificada correctamente.");
            }
            else
            {
                _bitacora.Advertencia("La aplicación inició con un problema de integridad en la base de datos.");
                var respuesta = MessageBox.Show("Se vió afectada la integridad del sistema. ¿Desea notificar al administrador?",
                    "Atención",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes)
                {
                    // TODO: Notificar al administrador.
                }
            }
        }
    }
}

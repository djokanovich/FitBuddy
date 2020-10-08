using Common.Bitacora;
using FitBuddy.Business;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI
{
    internal class FitBuddyApp
    {
        private readonly IBitacora<FitBuddyApp> _bitacora;
        private readonly IIntegridadBusinessLogic _integridadBusinessLogic;

        public FitBuddyApp(IBitacora<FitBuddyApp> bitacora, IIntegridadBusinessLogic integridadBusinessLogic)
        {
            _bitacora = bitacora;
            _integridadBusinessLogic = integridadBusinessLogic;
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
            if (_integridadBusinessLogic.DbTieneIntegridad())
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

using GUI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class GestionarPerfil : Form
    {
        private CustomPrincipal _customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;

        public GestionarPerfil()
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {_customPrincipal.Identity.Name}";
        }

        public void Clear()
        {
            txtEdad.Text = null;
            txtPeso.Text = null;
            txtAltura.Text = null;
            txtCintura.Text = null;
            txtCadera.Text = null;
            txtMuslo.Text = null;
            txtBrazo.Text = null;
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var genero = ((RadioButton)grpBoxSexo.Controls[0]).Checked ? "F" : "M"; // Operador condicional ternario

            var gesUsuario = new gesUsuario();
            var usuario = gesUsuario.ObtenerUsuario(_customPrincipal.Identity.Id);
            Paciente paciente = new Paciente
            {
                UsuarioId = _customPrincipal.Identity.Id,
                Usuario = usuario,
                Peso = Convert.ToInt32(txtPeso.Text),
                ContBrazo = Convert.ToInt32(txtBrazo.Text),
                ContCadera = Convert.ToInt32(txtCadera.Text),
                Altura = Convert.ToInt32(txtAltura.Text),
                ContCintura = Convert.ToInt32(txtCintura.Text),
                ContMuslo = Convert.ToInt32(txtMuslo.Text),
                Edad = Convert.ToInt32(txtEdad.Text),
                Genero = genero,
                FechaRegistroPerfil = Convert.ToDateTime(dtpFecha.Text)
            };

            // le paso a la BLL el paciente creado
            var gesPaciente = new gesPaciente();
            gesPaciente.CrearPaciente(paciente);


            MessageBox.Show("Datos cargados con éxito");
            Clear();
        }

        private void OnBtnLimpiarClick(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

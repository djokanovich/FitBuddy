using Common.Bitacora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class AcercaDe : Form
    {
        private readonly IBitacora _bitacora;

        public AcercaDe(IBitacora bitacora)
        {
            InitializeComponent();
            _bitacora = bitacora;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var logIn = new LogIn(_bitacora);
            logIn.Show();
        }
    }
}

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
        private readonly IFormBuilder _formBuilder;

        public AcercaDe(IFormBuilder formBuilder)
        {
            InitializeComponent();
            _formBuilder = formBuilder;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            _formBuilder.Show<LogIn>();
        }
    }
}

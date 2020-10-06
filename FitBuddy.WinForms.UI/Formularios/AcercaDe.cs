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
        private readonly LogIn _logIn;

        public AcercaDe(LogIn logIn)
        {
            InitializeComponent();
            _logIn = logIn;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            _logIn.Show();
        }
    }
}

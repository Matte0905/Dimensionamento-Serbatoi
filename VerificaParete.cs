using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimensionamento_Serbatoi
{

    public partial class FormVerificaParete : Form
    {
        public string tipoNormativa = string.Empty;
        public string tipoCilindro = string.Empty;
        public string tipoSerbatorio = string.Empty;

        public FormVerificaParete()
        {
            InitializeComponent();
            this.Load += VerificaParete_Load;
        }

        private void VerificaParete_Load(object? sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tipoNormativa)) {
                lblTitolo.Text += " " + $"({tipoNormativa})";
                if(!string.IsNullOrEmpty(tipoSerbatorio))
                    lblTitolo.Text += " " + $"({tipoSerbatorio})";
                if (!string.IsNullOrEmpty(tipoCilindro))
                    lblTitolo.Text += " " + $"({tipoCilindro})";
            }
        }
    }
}

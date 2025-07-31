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
    public partial class TipoSerbatorio : Form {
        public string tipoNormativa = string.Empty;

        public string tipoCilindro = string.Empty;
        public string tipoSerbatorio = string.Empty;

        public TipoSerbatorio() {
            InitializeComponent();
            this.Load += TipoSerbatorio_Load;
        }

        private void TipoSerbatorio_Load(object? sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tipoNormativa)) {
                lblTitolo.Text += " " + $"({tipoNormativa})";

            }
        }

        private void btnSuccessivo_Click(object sender, EventArgs e) {

            switch (true) {
                case var _ when radioBtnConico.Checked:
                tipoCilindro = "Conico";
                break;

                case var _ when radioBtnEllisoidale.Checked:
                tipoCilindro = "Ellisoidale";
                break;

                case var _ when radioBtnSferico.Checked:
                tipoSerbatorio = "Sferico";
                break;
            }
        }
    }
}

namespace Dimensionamento_Serbatoi {
    public partial class TipoSerbatorio : Form
    {
        FormVerificaParete formVerificaParete = new();

        public string tipoNormativa = string.Empty;
        public string tipoCilindro = string.Empty;
        public string tipoSerbatorio = string.Empty;

        public TipoSerbatorio()
        {
            InitializeComponent();
            this.Load += TipoSerbatorio_Load;
        }

        private void TipoSerbatorio_Load(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tipoNormativa))
            {
                lblTitolo.Text += " " + $"({tipoNormativa})";

            }
        }

        private void btnSuccessivo_Click(object sender, EventArgs e)
        {

            switch (true)
            {
                case var _ when radioBtnTorisferico.Checked:
                    tipoSerbatorio = "Torisferico";
                    break;

                case var _ when radioBtnEllisoidale.Checked:
                    tipoCilindro = "Ellisoidale";
                    break;

                case var _ when radioBtnEmisferico.Checked:
                    tipoCilindro = "Emisferico";
                    break;

                case var _ when radioBtnConico.Checked:
                    tipoCilindro = "Conico";
                    break;

                case var _ when radioBtnFondoPiatto.Checked:
                    tipoCilindro = "Piatto";
                    break;

                case var _ when radioBtnSferico.Checked:
                    tipoSerbatorio = "Sferico";
                    break;

                case var _ when radioBtnAnello.Checked:
                    tipoCilindro = "Anello";
                    break;


            }
            if (tipoSerbatorio == "Anello")
            {
                this.Hide();
                formVerificaParete.tipoNormativa = tipoNormativa;
                formVerificaParete.tipoCilindro = tipoCilindro;
                formVerificaParete.tipoSerbatorio = tipoSerbatorio;
                formVerificaParete.Show();
            }
            else
            {
                this.Hide();
                formVerificaParete.tipoNormativa = tipoNormativa;
                formVerificaParete.tipoCilindro = tipoCilindro;
                formVerificaParete.tipoSerbatorio = tipoSerbatorio;
                formVerificaParete.Show();
            }
        }

        private void btnPrecedente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

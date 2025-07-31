namespace Dimensionamento_Serbatoi {
    public partial class FormSelezionaTipoCalcolo : Form {

        public FormSelezionaTipoCalcolo() {
            InitializeComponent();
        }

        string tipoNormativa = string.Empty;
        TipoSerbatorio formSerbatoio = new TipoSerbatorio();

        private void btnIniziaCalcoloPressione_Click(object sender, EventArgs e) {
            if (radioBtnASME.Checked) {
                this.Hide();
                tipoNormativa = "ASME";
                formSerbatoio.tipoNormativa = tipoNormativa;
                formSerbatoio.Show();
            } else if (radioBtnPED.Checked) {
                this.Hide();
                tipoNormativa = "PED";
                formSerbatoio.tipoNormativa = tipoNormativa;
                formSerbatoio.Show();
            } else {
                MessageBox.Show("Seleziona Normativa");
            }

        }

        private void btnIniziaCalcoloSismico_Click(object sender, EventArgs e) {
            if (radioBtnASCE.Checked) {
                this.Hide();
                tipoNormativa = "ASCE";
                formSerbatoio.tipoNormativa = tipoNormativa;
                formSerbatoio.Show();
            } else if (radioBtnEUROCODICE.Checked) {
                this.Hide();
                tipoNormativa = "EUROCODICE";
                formSerbatoio.tipoNormativa = tipoNormativa;
                formSerbatoio.Show();
            } else {
                MessageBox.Show("Seleziona Normativa");
            }
        }

    }
}

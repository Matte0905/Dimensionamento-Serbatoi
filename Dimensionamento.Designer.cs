namespace Dimensionamento_Serbatoi
{
    partial class Dimensionamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitolo = new Label();
            panelDimensionamento = new Panel();
            label1 = new Label();
            txtBXTmax = new TextBox();
            lblTmax = new Label();
            label3 = new Label();
            txtBXTmin = new TextBox();
            lblTmin = new Label();
            txtBXMateriale = new TextBox();
            label15 = new Label();
            txtBXModuloElastico = new TextBox();
            lblDiametroInterno = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            txtBXPressione = new TextBox();
            txtBXSovraspessore = new TextBox();
            txtBXCoefGiunzione = new TextBox();
            txtBXModalitaCalcolo = new TextBox();
            txtBXSforzoAmmissibile = new TextBox();
            lblParametroVar = new Label();
            lblMateriale = new Label();
            lblSforzoAmmissibile = new Label();
            lblCoefGiunzione = new Label();
            lblPressioneDiProgetto = new Label();
            lblSovraspessore = new Label();
            btnPrecedente = new Button();
            btnSuccessivo = new Button();
            panelDimensionamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.Font = new Font("Segoe UI", 18F);
            lblTitolo.Location = new Point(525, 18);
            lblTitolo.Margin = new Padding(2, 0, 2, 0);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(490, 29);
            lblTitolo.TabIndex = 15;
            lblTitolo.Text = "Dimensionamento Serbatoio";
            // 
            // panelDimensionamento
            // 
            panelDimensionamento.Controls.Add(label1);
            panelDimensionamento.Controls.Add(txtBXTmax);
            panelDimensionamento.Controls.Add(lblTmax);
            panelDimensionamento.Controls.Add(label3);
            panelDimensionamento.Controls.Add(txtBXTmin);
            panelDimensionamento.Controls.Add(lblTmin);
            panelDimensionamento.Controls.Add(txtBXMateriale);
            panelDimensionamento.Controls.Add(label15);
            panelDimensionamento.Controls.Add(txtBXModuloElastico);
            panelDimensionamento.Controls.Add(lblDiametroInterno);
            panelDimensionamento.Controls.Add(label14);
            panelDimensionamento.Controls.Add(label13);
            panelDimensionamento.Controls.Add(label10);
            panelDimensionamento.Controls.Add(txtBXPressione);
            panelDimensionamento.Controls.Add(txtBXSovraspessore);
            panelDimensionamento.Controls.Add(txtBXCoefGiunzione);
            panelDimensionamento.Controls.Add(txtBXModalitaCalcolo);
            panelDimensionamento.Controls.Add(txtBXSforzoAmmissibile);
            panelDimensionamento.Controls.Add(lblParametroVar);
            panelDimensionamento.Controls.Add(lblMateriale);
            panelDimensionamento.Controls.Add(lblSforzoAmmissibile);
            panelDimensionamento.Controls.Add(lblCoefGiunzione);
            panelDimensionamento.Controls.Add(lblPressioneDiProgetto);
            panelDimensionamento.Controls.Add(lblSovraspessore);
            panelDimensionamento.Location = new Point(20, 62);
            panelDimensionamento.Margin = new Padding(2);
            panelDimensionamento.Name = "panelDimensionamento";
            panelDimensionamento.Size = new Size(1488, 368);
            panelDimensionamento.TabIndex = 23;
            // 
            // label1
            // 
            label1.Location = new Point(1426, 234);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 51;
            label1.Text = "°C";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXTmax
            // 
            txtBXTmax.Location = new Point(223, 234);
            txtBXTmax.Margin = new Padding(2);
            txtBXTmax.Name = "txtBXTmax";
            txtBXTmax.ReadOnly = true;
            txtBXTmax.Size = new Size(1191, 23);
            txtBXTmax.TabIndex = 50;
            // 
            // lblTmax
            // 
            lblTmax.AutoSize = true;
            lblTmax.Font = new Font("Segoe UI", 11F);
            lblTmax.Location = new Point(14, 234);
            lblTmax.Margin = new Padding(2, 0, 2, 0);
            lblTmax.Name = "lblTmax";
            lblTmax.Size = new Size(187, 20);
            lblTmax.TabIndex = 49;
            lblTmax.Text = "Temperatura Max Esercizio";
            // 
            // label3
            // 
            label3.Location = new Point(1426, 207);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 48;
            label3.Text = "°C";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXTmin
            // 
            txtBXTmin.Location = new Point(223, 207);
            txtBXTmin.Margin = new Padding(2);
            txtBXTmin.Name = "txtBXTmin";
            txtBXTmin.Size = new Size(1191, 23);
            txtBXTmin.TabIndex = 47;
            // 
            // lblTmin
            // 
            lblTmin.AutoSize = true;
            lblTmin.Font = new Font("Segoe UI", 11F);
            lblTmin.Location = new Point(14, 207);
            lblTmin.Margin = new Padding(2, 0, 2, 0);
            lblTmin.Name = "lblTmin";
            lblTmin.Size = new Size(184, 20);
            lblTmin.TabIndex = 46;
            lblTmin.Text = "Temperatura Min Esercizio";
            // 
            // txtBXMateriale
            // 
            txtBXMateriale.Location = new Point(222, 13);
            txtBXMateriale.Margin = new Padding(2);
            txtBXMateriale.Name = "txtBXMateriale";
            txtBXMateriale.ReadOnly = true;
            txtBXMateriale.Size = new Size(1191, 23);
            txtBXMateriale.TabIndex = 39;
            // 
            // label15
            // 
            label15.Location = new Point(1424, 66);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(48, 19);
            label15.TabIndex = 38;
            label15.Text = "mm";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXModuloElastico
            // 
            txtBXModuloElastico.Location = new Point(222, 66);
            txtBXModuloElastico.Margin = new Padding(2);
            txtBXModuloElastico.Name = "txtBXModuloElastico";
            txtBXModuloElastico.ReadOnly = true;
            txtBXModuloElastico.Size = new Size(1191, 23);
            txtBXModuloElastico.TabIndex = 37;
            // 
            // lblDiametroInterno
            // 
            lblDiametroInterno.AutoSize = true;
            lblDiametroInterno.Font = new Font("Segoe UI", 11F);
            lblDiametroInterno.Location = new Point(14, 66);
            lblDiametroInterno.Margin = new Padding(2, 0, 2, 0);
            lblDiametroInterno.Name = "lblDiametroInterno";
            lblDiametroInterno.Size = new Size(126, 20);
            lblDiametroInterno.TabIndex = 36;
            lblDiametroInterno.Text = "Diametro Interno:";
            // 
            // label14
            // 
            label14.Location = new Point(1424, 93);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 19);
            label14.TabIndex = 34;
            label14.Text = "MPa";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Location = new Point(1424, 120);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 19);
            label13.TabIndex = 33;
            label13.Text = "mm";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Location = new Point(1424, 41);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 30;
            label10.Text = "MPa";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXPressione
            // 
            txtBXPressione.Location = new Point(222, 93);
            txtBXPressione.Margin = new Padding(2);
            txtBXPressione.Name = "txtBXPressione";
            txtBXPressione.ReadOnly = true;
            txtBXPressione.Size = new Size(1191, 23);
            txtBXPressione.TabIndex = 29;
            // 
            // txtBXSovraspessore
            // 
            txtBXSovraspessore.Location = new Point(222, 120);
            txtBXSovraspessore.Margin = new Padding(2);
            txtBXSovraspessore.Name = "txtBXSovraspessore";
            txtBXSovraspessore.Size = new Size(1191, 23);
            txtBXSovraspessore.TabIndex = 28;
            // 
            // txtBXCoefGiunzione
            // 
            txtBXCoefGiunzione.Location = new Point(222, 147);
            txtBXCoefGiunzione.Margin = new Padding(2);
            txtBXCoefGiunzione.Name = "txtBXCoefGiunzione";
            txtBXCoefGiunzione.ReadOnly = true;
            txtBXCoefGiunzione.Size = new Size(1191, 23);
            txtBXCoefGiunzione.TabIndex = 26;
            // 
            // txtBXModalitaCalcolo
            // 
            txtBXModalitaCalcolo.Location = new Point(222, 180);
            txtBXModalitaCalcolo.Margin = new Padding(2);
            txtBXModalitaCalcolo.Name = "txtBXModalitaCalcolo";
            txtBXModalitaCalcolo.Size = new Size(1191, 23);
            txtBXModalitaCalcolo.TabIndex = 25;
            // 
            // txtBXSforzoAmmissibile
            // 
            txtBXSforzoAmmissibile.Location = new Point(222, 40);
            txtBXSforzoAmmissibile.Margin = new Padding(2);
            txtBXSforzoAmmissibile.Name = "txtBXSforzoAmmissibile";
            txtBXSforzoAmmissibile.ReadOnly = true;
            txtBXSforzoAmmissibile.Size = new Size(1191, 23);
            txtBXSforzoAmmissibile.TabIndex = 24;
            // 
            // lblParametroVar
            // 
            lblParametroVar.AutoSize = true;
            lblParametroVar.Font = new Font("Segoe UI", 11F);
            lblParametroVar.Location = new Point(14, 180);
            lblParametroVar.Margin = new Padding(2, 0, 2, 0);
            lblParametroVar.Name = "lblParametroVar";
            lblParametroVar.Size = new Size(93, 20);
            lblParametroVar.TabIndex = 22;
            lblParametroVar.Text = "Parametro C:";
            // 
            // lblMateriale
            // 
            lblMateriale.AutoSize = true;
            lblMateriale.Font = new Font("Segoe UI", 11F);
            lblMateriale.Location = new Point(14, 12);
            lblMateriale.Margin = new Padding(2, 0, 2, 0);
            lblMateriale.Name = "lblMateriale";
            lblMateriale.Size = new Size(75, 20);
            lblMateriale.TabIndex = 16;
            lblMateriale.Text = "Materiale:";
            // 
            // lblSforzoAmmissibile
            // 
            lblSforzoAmmissibile.AutoSize = true;
            lblSforzoAmmissibile.Font = new Font("Segoe UI", 11F);
            lblSforzoAmmissibile.Location = new Point(14, 39);
            lblSforzoAmmissibile.Margin = new Padding(2, 0, 2, 0);
            lblSforzoAmmissibile.Name = "lblSforzoAmmissibile";
            lblSforzoAmmissibile.Size = new Size(182, 20);
            lblSforzoAmmissibile.TabIndex = 21;
            lblSforzoAmmissibile.Text = "Sforzo Ammissibile a T Es:";
            // 
            // lblCoefGiunzione
            // 
            lblCoefGiunzione.AutoSize = true;
            lblCoefGiunzione.Font = new Font("Segoe UI", 11F);
            lblCoefGiunzione.Location = new Point(14, 147);
            lblCoefGiunzione.Margin = new Padding(2, 0, 2, 0);
            lblCoefGiunzione.Name = "lblCoefGiunzione";
            lblCoefGiunzione.Size = new Size(179, 20);
            lblCoefGiunzione.TabIndex = 17;
            lblCoefGiunzione.Text = "Coefficiente di Giunzione:";
            // 
            // lblPressioneDiProgetto
            // 
            lblPressioneDiProgetto.AutoSize = true;
            lblPressioneDiProgetto.Font = new Font("Segoe UI", 11F);
            lblPressioneDiProgetto.Location = new Point(14, 93);
            lblPressioneDiProgetto.Margin = new Padding(2, 0, 2, 0);
            lblPressioneDiProgetto.Name = "lblPressioneDiProgetto";
            lblPressioneDiProgetto.Size = new Size(153, 20);
            lblPressioneDiProgetto.TabIndex = 20;
            lblPressioneDiProgetto.Text = "Pressione di Progetto:";
            // 
            // lblSovraspessore
            // 
            lblSovraspessore.AutoSize = true;
            lblSovraspessore.Font = new Font("Segoe UI", 11F);
            lblSovraspessore.Location = new Point(14, 120);
            lblSovraspessore.Margin = new Padding(2, 0, 2, 0);
            lblSovraspessore.Name = "lblSovraspessore";
            lblSovraspessore.Size = new Size(201, 20);
            lblSovraspessore.TabIndex = 19;
            lblSovraspessore.Text = "Sovraspessore Di Corrosione:";
            // 
            // btnPrecedente
            // 
            btnPrecedente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPrecedente.Location = new Point(1004, 534);
            btnPrecedente.Margin = new Padding(2);
            btnPrecedente.Name = "btnPrecedente";
            btnPrecedente.Size = new Size(245, 42);
            btnPrecedente.TabIndex = 25;
            btnPrecedente.Text = "Precedente";
            btnPrecedente.UseVisualStyleBackColor = true;
            // 
            // btnSuccessivo
            // 
            btnSuccessivo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSuccessivo.Location = new Point(1260, 534);
            btnSuccessivo.Margin = new Padding(2);
            btnSuccessivo.Name = "btnSuccessivo";
            btnSuccessivo.Size = new Size(245, 42);
            btnSuccessivo.TabIndex = 40;
            btnSuccessivo.Text = "Calcola";
            btnSuccessivo.UseVisualStyleBackColor = true;
            // 
            // Dimensionamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 596);
            Controls.Add(btnSuccessivo);
            Controls.Add(panelDimensionamento);
            Controls.Add(lblTitolo);
            Controls.Add(btnPrecedente);
            Margin = new Padding(2);
            Name = "Dimensionamento";
            Text = "Dimensionamento Serbatoio";
            Load += Dimensionamento_Load;
            panelDimensionamento.ResumeLayout(false);
            panelDimensionamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitolo;
        private Panel panelDimensionamento;
        private TextBox txtBXMateriale;
        private Button btnPrecedente;
        private Label label15;
        private TextBox txtBXModuloElastico;
        private Label lblDiametroInterno;
        private Label label14;
        private Label label13;
        private Label label10;
        private TextBox txtBXPressione;
        private TextBox txtBXSovraspessore;
        private TextBox txtBXCoefGiunzione;
        private TextBox txtBXModalitaCalcolo;
        private TextBox txtBXSforzoAmmissibile;
        private Label lblParametroVar;
        private Label lblMateriale;
        private Label lblSforzoAmmissibile;
        private Label lblCoefGiunzione;
        private Label lblPressioneDiProgetto;
        private Label lblSovraspessore;
        private Button btnSuccessivo;
        private Label label1;
        private TextBox txtBXTmax;
        private Label lblTmax;
        private Label label3;
        private TextBox txtBXTmin;
        private Label lblTmin;
    }
}
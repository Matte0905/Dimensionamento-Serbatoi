namespace Dimensionamento_Serbatoi
{
    partial class FormSelezionaTipoCalcolo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniziaCalcoloPressione = new Button();
            radioBtnASME = new RadioButton();
            radioBtnPED = new RadioButton();
            lblNormativa1 = new Label();
            lblNormativa2 = new Label();
            btnIniziaCalcoloSismico = new Button();
            panelCalcSismico = new Panel();
            radioBtnASCE = new RadioButton();
            radioBtnEUROCODICE = new RadioButton();
            panel1 = new Panel();
            lblPressione = new Label();
            lblAzioneSismiche = new Label();
            lblSelezioneCalcolo = new Label();
            panelCalcSismico.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniziaCalcoloPressione
            // 
            btnIniziaCalcoloPressione.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIniziaCalcoloPressione.Location = new Point(125, 100);
            btnIniziaCalcoloPressione.Margin = new Padding(2, 2, 2, 2);
            btnIniziaCalcoloPressione.Name = "btnIniziaCalcoloPressione";
            btnIniziaCalcoloPressione.Size = new Size(385, 33);
            btnIniziaCalcoloPressione.TabIndex = 0;
            btnIniziaCalcoloPressione.Text = "Inizia Calcolo a Pressione";
            btnIniziaCalcoloPressione.UseVisualStyleBackColor = true;
            btnIniziaCalcoloPressione.Click += btnIniziaCalcoloPressione_Click;
            // 
            // radioBtnASME
            // 
            radioBtnASME.Font = new Font("Segoe UI", 11F);
            radioBtnASME.Location = new Point(92, 49);
            radioBtnASME.Margin = new Padding(2, 2, 2, 2);
            radioBtnASME.Name = "radioBtnASME";
            radioBtnASME.Size = new Size(245, 30);
            radioBtnASME.TabIndex = 1;
            radioBtnASME.TabStop = true;
            radioBtnASME.Text = "ASME SECTION VIII";
            radioBtnASME.UseVisualStyleBackColor = true;
            // 
            // radioBtnPED
            // 
            radioBtnPED.Font = new Font("Segoe UI", 11F);
            radioBtnPED.Location = new Point(349, 49);
            radioBtnPED.Margin = new Padding(2, 2, 2, 2);
            radioBtnPED.Name = "radioBtnPED";
            radioBtnPED.Size = new Size(245, 30);
            radioBtnPED.TabIndex = 2;
            radioBtnPED.TabStop = true;
            radioBtnPED.Text = "PED (EN 13445) / VSR 1995";
            radioBtnPED.UseVisualStyleBackColor = true;
            // 
            // lblNormativa1
            // 
            lblNormativa1.AutoSize = true;
            lblNormativa1.Font = new Font("Segoe UI", 13F);
            lblNormativa1.Location = new Point(24, 16);
            lblNormativa1.Margin = new Padding(2, 0, 2, 0);
            lblNormativa1.Name = "lblNormativa1";
            lblNormativa1.Size = new Size(273, 25);
            lblNormativa1.TabIndex = 3;
            lblNormativa1.Text = "Seleziona la normativa di calcolo:";
            // 
            // lblNormativa2
            // 
            lblNormativa2.AutoSize = true;
            lblNormativa2.Font = new Font("Segoe UI", 13F);
            lblNormativa2.Location = new Point(24, 17);
            lblNormativa2.Margin = new Padding(2, 0, 2, 0);
            lblNormativa2.Name = "lblNormativa2";
            lblNormativa2.Size = new Size(273, 25);
            lblNormativa2.TabIndex = 7;
            lblNormativa2.Text = "Seleziona la normativa di calcolo:";
            // 
            // btnIniziaCalcoloSismico
            // 
            btnIniziaCalcoloSismico.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIniziaCalcoloSismico.Location = new Point(125, 99);
            btnIniziaCalcoloSismico.Margin = new Padding(2, 2, 2, 2);
            btnIniziaCalcoloSismico.Name = "btnIniziaCalcoloSismico";
            btnIniziaCalcoloSismico.Size = new Size(385, 33);
            btnIniziaCalcoloSismico.TabIndex = 4;
            btnIniziaCalcoloSismico.Text = "Inizia Calcolo Sismico";
            btnIniziaCalcoloSismico.UseVisualStyleBackColor = true;
            btnIniziaCalcoloSismico.Click += btnIniziaCalcoloSismico_Click;
            // 
            // panelCalcSismico
            // 
            panelCalcSismico.Controls.Add(radioBtnASCE);
            panelCalcSismico.Controls.Add(radioBtnEUROCODICE);
            panelCalcSismico.Controls.Add(lblNormativa2);
            panelCalcSismico.Controls.Add(btnIniziaCalcoloSismico);
            panelCalcSismico.Location = new Point(57, 296);
            panelCalcSismico.Margin = new Padding(2, 2, 2, 2);
            panelCalcSismico.Name = "panelCalcSismico";
            panelCalcSismico.Size = new Size(630, 165);
            panelCalcSismico.TabIndex = 8;
            // 
            // radioBtnASCE
            // 
            radioBtnASCE.Font = new Font("Segoe UI", 11F);
            radioBtnASCE.Location = new Point(92, 52);
            radioBtnASCE.Margin = new Padding(2, 2, 2, 2);
            radioBtnASCE.Name = "radioBtnASCE";
            radioBtnASCE.Size = new Size(245, 30);
            radioBtnASCE.TabIndex = 12;
            radioBtnASCE.TabStop = true;
            radioBtnASCE.Text = "ASCE 7 ";
            radioBtnASCE.UseVisualStyleBackColor = true;
            // 
            // radioBtnEUROCODICE
            // 
            radioBtnEUROCODICE.Font = new Font("Segoe UI", 11F);
            radioBtnEUROCODICE.Location = new Point(349, 52);
            radioBtnEUROCODICE.Margin = new Padding(2, 2, 2, 2);
            radioBtnEUROCODICE.Name = "radioBtnEUROCODICE";
            radioBtnEUROCODICE.Size = new Size(245, 30);
            radioBtnEUROCODICE.TabIndex = 13;
            radioBtnEUROCODICE.TabStop = true;
            radioBtnEUROCODICE.Text = "EUROCODICE 8 / NTC2018 ";
            radioBtnEUROCODICE.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNormativa1);
            panel1.Controls.Add(btnIniziaCalcoloPressione);
            panel1.Controls.Add(radioBtnASME);
            panel1.Controls.Add(radioBtnPED);
            panel1.Location = new Point(57, 69);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 165);
            panel1.TabIndex = 9;
            // 
            // lblPressione
            // 
            lblPressione.AutoSize = true;
            lblPressione.Font = new Font("Segoe UI", 13F);
            lblPressione.Location = new Point(57, 52);
            lblPressione.Margin = new Padding(2, 0, 2, 0);
            lblPressione.Name = "lblPressione";
            lblPressione.Size = new Size(263, 25);
            lblPressione.TabIndex = 10;
            lblPressione.Text = "Serbatoio Soggetto a Pressione";
            // 
            // lblAzioneSismiche
            // 
            lblAzioneSismiche.AutoSize = true;
            lblAzioneSismiche.Font = new Font("Segoe UI", 13F);
            lblAzioneSismiche.Location = new Point(57, 278);
            lblAzioneSismiche.Margin = new Padding(2, 0, 2, 0);
            lblAzioneSismiche.Name = "lblAzioneSismiche";
            lblAzioneSismiche.Size = new Size(322, 25);
            lblAzioneSismiche.TabIndex = 11;
            lblAzioneSismiche.Text = "Serbatoio Soggetto ad Azioni Sismiche";
            // 
            // lblSelezioneCalcolo
            // 
            lblSelezioneCalcolo.Font = new Font("Segoe UI", 18F);
            lblSelezioneCalcolo.Location = new Point(612, 18);
            lblSelezioneCalcolo.Margin = new Padding(2, 0, 2, 0);
            lblSelezioneCalcolo.Name = "lblSelezioneCalcolo";
            lblSelezioneCalcolo.Size = new Size(315, 29);
            lblSelezioneCalcolo.TabIndex = 12;
            lblSelezioneCalcolo.Text = "Seleziona il Tipo di Calcolo";
            // 
            // FormSelezionaTipoCalcolo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 596);
            Controls.Add(lblSelezioneCalcolo);
            Controls.Add(lblAzioneSismiche);
            Controls.Add(lblPressione);
            Controls.Add(panel1);
            Controls.Add(panelCalcSismico);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSelezionaTipoCalcolo";
            Text = "Tipo Calcolo";
            panelCalcSismico.ResumeLayout(false);
            panelCalcSismico.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniziaCalcoloPressione;
        private RadioButton radioBtnASME;
        private RadioButton radioBtnPED;
        private Label lblNormativa1;
        private Label lblNormativa2;
        private Button btnIniziaCalcoloSismico;
        private Panel panelCalcSismico;
        private Panel panel1;
        private Label lblPressione;
        private Label lblAzioneSismiche;
        private RadioButton radioBtnASCE;
        private RadioButton radioBtnEUROCODICE;
        private Label lblSelezioneCalcolo;
    }
}

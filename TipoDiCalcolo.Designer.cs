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
            label1 = new Label();
            label2 = new Label();
            btnIniziaCalcoloSismico = new Button();
            panelCalcSismico = new Panel();
            radioBtnASCE = new RadioButton();
            radioBtnEUROCODICE = new RadioButton();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelCalcSismico.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniziaCalcoloPressione
            // 
            btnIniziaCalcoloPressione.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIniziaCalcoloPressione.Location = new Point(178, 167);
            btnIniziaCalcoloPressione.Name = "btnIniziaCalcoloPressione";
            btnIniziaCalcoloPressione.Size = new Size(550, 55);
            btnIniziaCalcoloPressione.TabIndex = 0;
            btnIniziaCalcoloPressione.Text = "Inizia Calcolo a Pressione";
            btnIniziaCalcoloPressione.UseVisualStyleBackColor = true;
            // 
            // radioBtnASME
            // 
            radioBtnASME.Font = new Font("Segoe UI", 11F);
            radioBtnASME.Location = new Point(132, 81);
            radioBtnASME.Name = "radioBtnASME";
            radioBtnASME.Size = new Size(350, 50);
            radioBtnASME.TabIndex = 1;
            radioBtnASME.TabStop = true;
            radioBtnASME.Text = "ASME SECTION VIII";
            radioBtnASME.UseVisualStyleBackColor = true;
            // 
            // radioBtnPED
            // 
            radioBtnPED.Font = new Font("Segoe UI", 11F);
            radioBtnPED.Location = new Point(498, 81);
            radioBtnPED.Name = "radioBtnPED";
            radioBtnPED.Size = new Size(350, 50);
            radioBtnPED.TabIndex = 2;
            radioBtnPED.TabStop = true;
            radioBtnPED.Text = "PED (EN 13445) / VSR 1995";
            radioBtnPED.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(391, 36);
            label1.TabIndex = 3;
            label1.Text = "Seleziona la normativa di calcolo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(34, 28);
            label2.Name = "label2";
            label2.Size = new Size(391, 36);
            label2.TabIndex = 7;
            label2.Text = "Seleziona la normativa di calcolo:";
            // 
            // btnIniziaCalcoloSismico
            // 
            btnIniziaCalcoloSismico.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIniziaCalcoloSismico.Location = new Point(178, 165);
            btnIniziaCalcoloSismico.Name = "btnIniziaCalcoloSismico";
            btnIniziaCalcoloSismico.Size = new Size(550, 55);
            btnIniziaCalcoloSismico.TabIndex = 4;
            btnIniziaCalcoloSismico.Text = "Inizia Calcolo Sismico";
            btnIniziaCalcoloSismico.UseVisualStyleBackColor = true;
            // 
            // panelCalcSismico
            // 
            panelCalcSismico.Controls.Add(radioBtnASCE);
            panelCalcSismico.Controls.Add(radioBtnEUROCODICE);
            panelCalcSismico.Controls.Add(label2);
            panelCalcSismico.Controls.Add(btnIniziaCalcoloSismico);
            panelCalcSismico.Location = new Point(81, 494);
            panelCalcSismico.Name = "panelCalcSismico";
            panelCalcSismico.Size = new Size(900, 275);
            panelCalcSismico.TabIndex = 8;
            // 
            // radioBtnASCE
            // 
            radioBtnASCE.Font = new Font("Segoe UI", 11F);
            radioBtnASCE.Location = new Point(132, 86);
            radioBtnASCE.Name = "radioBtnASCE";
            radioBtnASCE.Size = new Size(350, 50);
            radioBtnASCE.TabIndex = 12;
            radioBtnASCE.TabStop = true;
            radioBtnASCE.Text = "ASCE 7 ";
            radioBtnASCE.UseVisualStyleBackColor = true;
            // 
            // radioBtnEUROCODICE
            // 
            radioBtnEUROCODICE.Font = new Font("Segoe UI", 11F);
            radioBtnEUROCODICE.Location = new Point(498, 86);
            radioBtnEUROCODICE.Name = "radioBtnEUROCODICE";
            radioBtnEUROCODICE.Size = new Size(350, 50);
            radioBtnEUROCODICE.TabIndex = 13;
            radioBtnEUROCODICE.TabStop = true;
            radioBtnEUROCODICE.Text = "EUROCODICE 8 / NTC2018 ";
            radioBtnEUROCODICE.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIniziaCalcoloPressione);
            panel1.Controls.Add(radioBtnASME);
            panel1.Controls.Add(radioBtnPED);
            panel1.Location = new Point(81, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 275);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(81, 87);
            label3.Name = "label3";
            label3.Size = new Size(375, 36);
            label3.TabIndex = 10;
            label3.Text = "Serbatoio Soggetto a Pressione";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(81, 464);
            label4.Name = "label4";
            label4.Size = new Size(458, 36);
            label4.TabIndex = 11;
            label4.Text = "Serbatoio Soggetto ad Azioni Sismiche";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(875, 30);
            label5.Name = "label5";
            label5.Size = new Size(450, 48);
            label5.TabIndex = 12;
            label5.Text = "Seleziona il Tipo di Calcolo";
            // 
            // FormSelezionaTipoCalcolo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2178, 994);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panelCalcSismico);
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
        private Label label1;
        private Label label2;
        private Button btnIniziaCalcoloSismico;
        private Panel panelCalcSismico;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private RadioButton radioBtnASCE;
        private RadioButton radioBtnEUROCODICE;
        private Label label5;
    }
}

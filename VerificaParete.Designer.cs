namespace Dimensionamento_Serbatoi
{
    partial class FormVerificaParete
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
            lblIntroduzione = new Label();
            lblMateriale = new Label();
            lblCoefGiunzione = new Label();
            lblDiametro = new Label();
            lblSpessore = new Label();
            lblPressioneDiProgetto = new Label();
            lblSforzoAmmissibile = new Label();
            panel1 = new Panel();
            label19 = new Label();
            label17 = new Label();
            txtBXSforzoAmmissibileT1 = new TextBox();
            lblSforzoAmmissibileT1 = new Label();
            label11 = new Label();
            txtBXSforzoAmmissibileT2 = new TextBox();
            lblSforzoAmmissibileT2 = new Label();
            label7 = new Label();
            txtBXTRiferimentoT2 = new TextBox();
            lblTRiferimentoT2 = new Label();
            label5 = new Label();
            txtBXTRiferimentoT1 = new TextBox();
            lblTRiferimentoT1 = new Label();
            label3 = new Label();
            txtBXTmax = new TextBox();
            lblTmax = new Label();
            btnVerifica = new Button();
            txtBXModuloElastico = new TextBox();
            lblModuloElastico = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            txtBXPressione = new TextBox();
            txtBXSpessore = new TextBox();
            txtBXDiametro = new TextBox();
            txtBXCoefGiunzione = new TextBox();
            txtBXModalitaCalcolo = new TextBox();
            txtBXSforzoAmmissibile = new TextBox();
            listBoxMateriale = new ListBox();
            lblModalitaCalcolo = new Label();
            btnSuccessivo = new Button();
            btnPrecedente = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.Font = new Font("Segoe UI", 18F);
            lblTitolo.Location = new Point(525, 18);
            lblTitolo.Margin = new Padding(2, 0, 2, 0);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(490, 29);
            lblTitolo.TabIndex = 14;
            lblTitolo.Text = "Verifica Preliminare Parete";
            // 
            // lblIntroduzione
            // 
            lblIntroduzione.AutoSize = true;
            lblIntroduzione.Font = new Font("Segoe UI", 13F);
            lblIntroduzione.Location = new Point(14, 54);
            lblIntroduzione.Margin = new Padding(2, 0, 2, 0);
            lblIntroduzione.Name = "lblIntroduzione";
            lblIntroduzione.Size = new Size(596, 25);
            lblIntroduzione.TabIndex = 15;
            lblIntroduzione.Text = "Inserisci i dati per determinare la formula di calcolo (parete sottille/spessa)";
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
            // lblDiametro
            // 
            lblDiametro.AutoSize = true;
            lblDiametro.Font = new Font("Segoe UI", 11F);
            lblDiametro.Location = new Point(14, 120);
            lblDiametro.Margin = new Padding(2, 0, 2, 0);
            lblDiametro.Name = "lblDiametro";
            lblDiametro.Size = new Size(126, 20);
            lblDiametro.TabIndex = 18;
            lblDiametro.Text = "Diametro Interno:";
            // 
            // lblSpessore
            // 
            lblSpessore.AutoSize = true;
            lblSpessore.Font = new Font("Segoe UI", 11F);
            lblSpessore.Location = new Point(14, 93);
            lblSpessore.Margin = new Padding(2, 0, 2, 0);
            lblSpessore.Name = "lblSpessore";
            lblSpessore.Size = new Size(188, 20);
            lblSpessore.TabIndex = 19;
            lblSpessore.Text = "Spessore Nominale Guscio:";
            // 
            // lblPressioneDiProgetto
            // 
            lblPressioneDiProgetto.AutoSize = true;
            lblPressioneDiProgetto.Font = new Font("Segoe UI", 11F);
            lblPressioneDiProgetto.Location = new Point(14, 66);
            lblPressioneDiProgetto.Margin = new Padding(2, 0, 2, 0);
            lblPressioneDiProgetto.Name = "lblPressioneDiProgetto";
            lblPressioneDiProgetto.Size = new Size(153, 20);
            lblPressioneDiProgetto.TabIndex = 20;
            lblPressioneDiProgetto.Text = "Pressione di Progetto:";
            // 
            // lblSforzoAmmissibile
            // 
            lblSforzoAmmissibile.AutoSize = true;
            lblSforzoAmmissibile.Font = new Font("Segoe UI", 11F);
            lblSforzoAmmissibile.Location = new Point(14, 309);
            lblSforzoAmmissibile.Margin = new Padding(2, 0, 2, 0);
            lblSforzoAmmissibile.Name = "lblSforzoAmmissibile";
            lblSforzoAmmissibile.Size = new Size(182, 20);
            lblSforzoAmmissibile.TabIndex = 21;
            lblSforzoAmmissibile.Text = "Sforzo Ammissibile a T Es:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(txtBXSforzoAmmissibileT1);
            panel1.Controls.Add(lblSforzoAmmissibileT1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtBXSforzoAmmissibileT2);
            panel1.Controls.Add(lblSforzoAmmissibileT2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBXTRiferimentoT2);
            panel1.Controls.Add(lblTRiferimentoT2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBXTRiferimentoT1);
            panel1.Controls.Add(lblTRiferimentoT1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBXTmax);
            panel1.Controls.Add(lblTmax);
            panel1.Controls.Add(btnVerifica);
            panel1.Controls.Add(txtBXModuloElastico);
            panel1.Controls.Add(lblModuloElastico);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBXPressione);
            panel1.Controls.Add(txtBXSpessore);
            panel1.Controls.Add(txtBXDiametro);
            panel1.Controls.Add(txtBXCoefGiunzione);
            panel1.Controls.Add(txtBXModalitaCalcolo);
            panel1.Controls.Add(txtBXSforzoAmmissibile);
            panel1.Controls.Add(listBoxMateriale);
            panel1.Controls.Add(lblModalitaCalcolo);
            panel1.Controls.Add(lblMateriale);
            panel1.Controls.Add(lblSforzoAmmissibile);
            panel1.Controls.Add(lblCoefGiunzione);
            panel1.Controls.Add(lblPressioneDiProgetto);
            panel1.Controls.Add(lblDiametro);
            panel1.Controls.Add(lblSpessore);
            panel1.Location = new Point(14, 78);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 452);
            panel1.TabIndex = 22;
            // 
            // label19
            // 
            label19.Location = new Point(1424, 39);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(48, 19);
            label19.TabIndex = 58;
            label19.Text = "MPa";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label17
            // 
            label17.Location = new Point(1424, 255);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(48, 19);
            label17.TabIndex = 57;
            label17.Text = "MPa";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXSforzoAmmissibileT1
            // 
            txtBXSforzoAmmissibileT1.Location = new Point(222, 255);
            txtBXSforzoAmmissibileT1.Margin = new Padding(2, 2, 2, 2);
            txtBXSforzoAmmissibileT1.Name = "txtBXSforzoAmmissibileT1";
            txtBXSforzoAmmissibileT1.Size = new Size(1191, 23);
            txtBXSforzoAmmissibileT1.TabIndex = 56;
            // 
            // lblSforzoAmmissibileT1
            // 
            lblSforzoAmmissibileT1.AutoSize = true;
            lblSforzoAmmissibileT1.Font = new Font("Segoe UI", 11F);
            lblSforzoAmmissibileT1.Location = new Point(14, 255);
            lblSforzoAmmissibileT1.Margin = new Padding(2, 0, 2, 0);
            lblSforzoAmmissibileT1.Name = "lblSforzoAmmissibileT1";
            lblSforzoAmmissibileT1.Size = new Size(172, 20);
            lblSforzoAmmissibileT1.TabIndex = 55;
            lblSforzoAmmissibileT1.Text = "Sforzo Ammissibile a T1:";
            // 
            // label11
            // 
            label11.Location = new Point(1426, 282);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 19);
            label11.TabIndex = 54;
            label11.Text = "MPa";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXSforzoAmmissibileT2
            // 
            txtBXSforzoAmmissibileT2.Location = new Point(223, 282);
            txtBXSforzoAmmissibileT2.Margin = new Padding(2, 2, 2, 2);
            txtBXSforzoAmmissibileT2.Name = "txtBXSforzoAmmissibileT2";
            txtBXSforzoAmmissibileT2.Size = new Size(1191, 23);
            txtBXSforzoAmmissibileT2.TabIndex = 53;
            // 
            // lblSforzoAmmissibileT2
            // 
            lblSforzoAmmissibileT2.AutoSize = true;
            lblSforzoAmmissibileT2.Font = new Font("Segoe UI", 11F);
            lblSforzoAmmissibileT2.Location = new Point(14, 282);
            lblSforzoAmmissibileT2.Margin = new Padding(2, 0, 2, 0);
            lblSforzoAmmissibileT2.Name = "lblSforzoAmmissibileT2";
            lblSforzoAmmissibileT2.Size = new Size(172, 20);
            lblSforzoAmmissibileT2.TabIndex = 52;
            lblSforzoAmmissibileT2.Text = "Sforzo Ammissibile a T2:";
            // 
            // label7
            // 
            label7.Location = new Point(1426, 228);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 19);
            label7.TabIndex = 51;
            label7.Text = "°C";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXTRiferimentoT2
            // 
            txtBXTRiferimentoT2.Location = new Point(223, 228);
            txtBXTRiferimentoT2.Margin = new Padding(2, 2, 2, 2);
            txtBXTRiferimentoT2.Name = "txtBXTRiferimentoT2";
            txtBXTRiferimentoT2.Size = new Size(1191, 23);
            txtBXTRiferimentoT2.TabIndex = 50;
            // 
            // lblTRiferimentoT2
            // 
            lblTRiferimentoT2.AutoSize = true;
            lblTRiferimentoT2.Font = new Font("Segoe UI", 11F);
            lblTRiferimentoT2.Location = new Point(14, 228);
            lblTRiferimentoT2.Margin = new Padding(2, 0, 2, 0);
            lblTRiferimentoT2.Name = "lblTRiferimentoT2";
            lblTRiferimentoT2.Size = new Size(195, 20);
            lblTRiferimentoT2.TabIndex = 49;
            lblTRiferimentoT2.Text = "Temperatura Riferimento T2";
            // 
            // label5
            // 
            label5.Location = new Point(1426, 201);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 48;
            label5.Text = "°C";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXTRiferimentoT1
            // 
            txtBXTRiferimentoT1.Location = new Point(223, 201);
            txtBXTRiferimentoT1.Margin = new Padding(2, 2, 2, 2);
            txtBXTRiferimentoT1.Name = "txtBXTRiferimentoT1";
            txtBXTRiferimentoT1.Size = new Size(1191, 23);
            txtBXTRiferimentoT1.TabIndex = 47;
            // 
            // lblTRiferimentoT1
            // 
            lblTRiferimentoT1.AutoSize = true;
            lblTRiferimentoT1.Font = new Font("Segoe UI", 11F);
            lblTRiferimentoT1.Location = new Point(14, 201);
            lblTRiferimentoT1.Margin = new Padding(2, 0, 2, 0);
            lblTRiferimentoT1.Name = "lblTRiferimentoT1";
            lblTRiferimentoT1.Size = new Size(195, 20);
            lblTRiferimentoT1.TabIndex = 46;
            lblTRiferimentoT1.Text = "Temperatura Riferimento T1";
            // 
            // label3
            // 
            label3.Location = new Point(1426, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 45;
            label3.Text = "°C";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXTmax
            // 
            txtBXTmax.Location = new Point(223, 174);
            txtBXTmax.Margin = new Padding(2, 2, 2, 2);
            txtBXTmax.Name = "txtBXTmax";
            txtBXTmax.Size = new Size(1191, 23);
            txtBXTmax.TabIndex = 44;
            // 
            // lblTmax
            // 
            lblTmax.AutoSize = true;
            lblTmax.Font = new Font("Segoe UI", 11F);
            lblTmax.Location = new Point(14, 174);
            lblTmax.Margin = new Padding(2, 0, 2, 0);
            lblTmax.Name = "lblTmax";
            lblTmax.Size = new Size(187, 20);
            lblTmax.TabIndex = 43;
            lblTmax.Text = "Temperatura Max Esercizio";
            // 
            // btnVerifica
            // 
            btnVerifica.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVerifica.Location = new Point(621, 399);
            btnVerifica.Margin = new Padding(2, 2, 2, 2);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(245, 42);
            btnVerifica.TabIndex = 25;
            btnVerifica.Text = "Verifica";
            btnVerifica.UseVisualStyleBackColor = true;
            // 
            // txtBXModuloElastico
            // 
            txtBXModuloElastico.Location = new Point(223, 39);
            txtBXModuloElastico.Margin = new Padding(2, 2, 2, 2);
            txtBXModuloElastico.Name = "txtBXModuloElastico";
            txtBXModuloElastico.ReadOnly = true;
            txtBXModuloElastico.Size = new Size(1191, 23);
            txtBXModuloElastico.TabIndex = 37;
            // 
            // lblModuloElastico
            // 
            lblModuloElastico.AutoSize = true;
            lblModuloElastico.Font = new Font("Segoe UI", 11F);
            lblModuloElastico.Location = new Point(14, 39);
            lblModuloElastico.Margin = new Padding(2, 0, 2, 0);
            lblModuloElastico.Name = "lblModuloElastico";
            lblModuloElastico.Size = new Size(161, 20);
            lblModuloElastico.TabIndex = 36;
            lblModuloElastico.Text = "Modulo Elastico a T Es:";
            // 
            // label14
            // 
            label14.Location = new Point(1426, 66);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 19);
            label14.TabIndex = 34;
            label14.Text = "MPa";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Location = new Point(1426, 93);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 19);
            label13.TabIndex = 33;
            label13.Text = "mm";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.Location = new Point(1426, 120);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 19);
            label12.TabIndex = 32;
            label12.Text = "mm";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Location = new Point(1424, 309);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 30;
            label10.Text = "MPa";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXPressione
            // 
            txtBXPressione.Location = new Point(223, 66);
            txtBXPressione.Margin = new Padding(2, 2, 2, 2);
            txtBXPressione.Name = "txtBXPressione";
            txtBXPressione.Size = new Size(1191, 23);
            txtBXPressione.TabIndex = 29;
            // 
            // txtBXSpessore
            // 
            txtBXSpessore.Location = new Point(223, 93);
            txtBXSpessore.Margin = new Padding(2, 2, 2, 2);
            txtBXSpessore.Name = "txtBXSpessore";
            txtBXSpessore.Size = new Size(1191, 23);
            txtBXSpessore.TabIndex = 28;
            // 
            // txtBXDiametro
            // 
            txtBXDiametro.Location = new Point(223, 120);
            txtBXDiametro.Margin = new Padding(2, 2, 2, 2);
            txtBXDiametro.Name = "txtBXDiametro";
            txtBXDiametro.Size = new Size(1191, 23);
            txtBXDiametro.TabIndex = 27;
            // 
            // txtBXCoefGiunzione
            // 
            txtBXCoefGiunzione.Location = new Point(223, 147);
            txtBXCoefGiunzione.Margin = new Padding(2, 2, 2, 2);
            txtBXCoefGiunzione.Name = "txtBXCoefGiunzione";
            txtBXCoefGiunzione.Size = new Size(1191, 23);
            txtBXCoefGiunzione.TabIndex = 26;
            // 
            // txtBXModalitaCalcolo
            // 
            txtBXModalitaCalcolo.Location = new Point(222, 336);
            txtBXModalitaCalcolo.Margin = new Padding(2, 2, 2, 2);
            txtBXModalitaCalcolo.Name = "txtBXModalitaCalcolo";
            txtBXModalitaCalcolo.ReadOnly = true;
            txtBXModalitaCalcolo.Size = new Size(1191, 23);
            txtBXModalitaCalcolo.TabIndex = 25;
            // 
            // txtBXSforzoAmmissibile
            // 
            txtBXSforzoAmmissibile.Location = new Point(222, 309);
            txtBXSforzoAmmissibile.Margin = new Padding(2, 2, 2, 2);
            txtBXSforzoAmmissibile.Name = "txtBXSforzoAmmissibile";
            txtBXSforzoAmmissibile.ReadOnly = true;
            txtBXSforzoAmmissibile.Size = new Size(1191, 23);
            txtBXSforzoAmmissibile.TabIndex = 24;
            // 
            // listBoxMateriale
            // 
            listBoxMateriale.Font = new Font("Segoe UI", 10F);
            listBoxMateriale.FormattingEnabled = true;
            listBoxMateriale.Items.AddRange(new object[] { "Acciaio Inox 304 (1.4301)", "Acciaio Inox 316L (1.4404)", "Acciaio Carbonio SA-516 Gr.70", "Acciaio Carbonio P265GH", "Alluminio 6061-T6", "Titanio Grado 2" });
            listBoxMateriale.Location = new Point(222, 13);
            listBoxMateriale.Margin = new Padding(2, 2, 2, 2);
            listBoxMateriale.Name = "listBoxMateriale";
            listBoxMateriale.Size = new Size(1191, 21);
            listBoxMateriale.TabIndex = 23;
            // 
            // lblModalitaCalcolo
            // 
            lblModalitaCalcolo.AutoSize = true;
            lblModalitaCalcolo.Font = new Font("Segoe UI", 11F);
            lblModalitaCalcolo.Location = new Point(14, 336);
            lblModalitaCalcolo.Margin = new Padding(2, 0, 2, 0);
            lblModalitaCalcolo.Name = "lblModalitaCalcolo";
            lblModalitaCalcolo.Size = new Size(143, 20);
            lblModalitaCalcolo.TabIndex = 22;
            lblModalitaCalcolo.Text = "Modalità di Calcolo:";
            // 
            // btnSuccessivo
            // 
            btnSuccessivo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSuccessivo.Location = new Point(1260, 534);
            btnSuccessivo.Margin = new Padding(2, 2, 2, 2);
            btnSuccessivo.Name = "btnSuccessivo";
            btnSuccessivo.Size = new Size(245, 42);
            btnSuccessivo.TabIndex = 24;
            btnSuccessivo.Text = "Successivo";
            btnSuccessivo.UseVisualStyleBackColor = true;
            // 
            // btnPrecedente
            // 
            btnPrecedente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPrecedente.Location = new Point(1004, 534);
            btnPrecedente.Margin = new Padding(2, 2, 2, 2);
            btnPrecedente.Name = "btnPrecedente";
            btnPrecedente.Size = new Size(245, 42);
            btnPrecedente.TabIndex = 23;
            btnPrecedente.Text = "Precedente";
            btnPrecedente.UseVisualStyleBackColor = true;
            // 
            // FormVerificaParete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 596);
            Controls.Add(btnSuccessivo);
            Controls.Add(btnPrecedente);
            Controls.Add(panel1);
            Controls.Add(lblIntroduzione);
            Controls.Add(lblTitolo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormVerificaParete";
            Text = "Verifica Preliminare Parete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblIntroduzione;
        private Label lblMateriale;
        private Label lblCoefGiunzione;
        private Label lblDiametro;
        private Label lblSpessore;
        private Label lblPressioneDiProgetto;
        private Label lblSforzoAmmissibile;
        private Panel panel1;
        private Label lblModalitaCalcolo;
        private TextBox txtBXSforzoAmmissibile;
        private ListBox listBoxMateriale;
        private TextBox txtBXModuloElastico;
        private Label lblModuloElastico;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private TextBox txtBXPressione;
        private TextBox txtBXSpessore;
        private TextBox txtBXDiametro;
        private TextBox txtBXCoefGiunzione;
        private TextBox txtBXModalitaCalcolo;
        private Button btnSuccessivo;
        private Button btnPrecedente;
        private Button btnVerifica;
        private Label label5;
        private TextBox txtBXTRiferimentoT1;
        private Label lblTRiferimentoT1;
        private Label label3;
        private TextBox txtBXTmax;
        private Label lblTmax;
        private Label label7;
        private TextBox txtBXTRiferimentoT2;
        private Label lblTRiferimentoT2;
        private Label label17;
        private TextBox txtBXSforzoAmmissibileT1;
        private Label lblSforzoAmmissibileT1;
        private Label label11;
        private TextBox txtBXSforzoAmmissibileT2;
        private Label lblSforzoAmmissibileT2;
        private Label label19;
    }
}
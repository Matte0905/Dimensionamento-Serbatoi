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
            txtBXMateriale = new TextBox();
            btnVerifica = new Button();
            label15 = new Label();
            txtBXModuloElastico = new TextBox();
            lblDiametroInterno = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            txtBXModalitaCalcolo = new TextBox();
            txtBXSforzoAmmissibile = new TextBox();
            lblParametroVar = new Label();
            label2 = new Label();
            lblSforzoAmmissibile = new Label();
            lblCoefGiunzione = new Label();
            lblPressioneDiProgetto = new Label();
            lblSovraspessore = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            panelDimensionamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.Font = new Font("Segoe UI", 18F);
            lblTitolo.Location = new Point(750, 30);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(700, 48);
            lblTitolo.TabIndex = 15;
            lblTitolo.Text = "Dimensionamento Serbatoio";
            // 
            // panelDimensionamento
            // 
            panelDimensionamento.Controls.Add(label1);
            panelDimensionamento.Controls.Add(textBox2);
            panelDimensionamento.Controls.Add(label5);
            panelDimensionamento.Controls.Add(label3);
            panelDimensionamento.Controls.Add(textBox1);
            panelDimensionamento.Controls.Add(label4);
            panelDimensionamento.Controls.Add(txtBXMateriale);
            panelDimensionamento.Controls.Add(label15);
            panelDimensionamento.Controls.Add(txtBXModuloElastico);
            panelDimensionamento.Controls.Add(lblDiametroInterno);
            panelDimensionamento.Controls.Add(label14);
            panelDimensionamento.Controls.Add(label13);
            panelDimensionamento.Controls.Add(label10);
            panelDimensionamento.Controls.Add(textBox6);
            panelDimensionamento.Controls.Add(textBox5);
            panelDimensionamento.Controls.Add(textBox3);
            panelDimensionamento.Controls.Add(txtBXModalitaCalcolo);
            panelDimensionamento.Controls.Add(txtBXSforzoAmmissibile);
            panelDimensionamento.Controls.Add(lblParametroVar);
            panelDimensionamento.Controls.Add(label2);
            panelDimensionamento.Controls.Add(lblSforzoAmmissibile);
            panelDimensionamento.Controls.Add(lblCoefGiunzione);
            panelDimensionamento.Controls.Add(lblPressioneDiProgetto);
            panelDimensionamento.Controls.Add(lblSovraspessore);
            panelDimensionamento.Location = new Point(29, 103);
            panelDimensionamento.Name = "panelDimensionamento";
            panelDimensionamento.Size = new Size(2125, 613);
            panelDimensionamento.TabIndex = 23;
            // 
            // txtBXMateriale
            // 
            txtBXMateriale.Location = new Point(317, 21);
            txtBXMateriale.Name = "txtBXMateriale";
            txtBXMateriale.ReadOnly = true;
            txtBXMateriale.Size = new Size(1700, 31);
            txtBXMateriale.TabIndex = 39;
            // 
            // btnVerifica
            // 
            btnVerifica.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVerifica.Location = new Point(1435, 890);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(350, 70);
            btnVerifica.TabIndex = 25;
            btnVerifica.Text = "Precedente";
            btnVerifica.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Location = new Point(2035, 110);
            label15.Name = "label15";
            label15.Size = new Size(69, 31);
            label15.TabIndex = 38;
            label15.Text = "mm";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBXModuloElastico
            // 
            txtBXModuloElastico.Location = new Point(317, 110);
            txtBXModuloElastico.Name = "txtBXModuloElastico";
            txtBXModuloElastico.ReadOnly = true;
            txtBXModuloElastico.Size = new Size(1700, 31);
            txtBXModuloElastico.TabIndex = 37;
            // 
            // lblDiametroInterno
            // 
            lblDiametroInterno.AutoSize = true;
            lblDiametroInterno.Font = new Font("Segoe UI", 11F);
            lblDiametroInterno.Location = new Point(20, 110);
            lblDiametroInterno.Name = "lblDiametroInterno";
            lblDiametroInterno.Size = new Size(184, 30);
            lblDiametroInterno.TabIndex = 36;
            lblDiametroInterno.Text = "Diametro Interno:";
            // 
            // label14
            // 
            label14.Location = new Point(2035, 155);
            label14.Name = "label14";
            label14.Size = new Size(69, 31);
            label14.TabIndex = 34;
            label14.Text = "MPa";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Location = new Point(2035, 200);
            label13.Name = "label13";
            label13.Size = new Size(69, 31);
            label13.TabIndex = 33;
            label13.Text = "mm";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Location = new Point(2035, 69);
            label10.Name = "label10";
            label10.Size = new Size(69, 31);
            label10.TabIndex = 30;
            label10.Text = "MPa";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(317, 155);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(1700, 31);
            textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(317, 200);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1700, 31);
            textBox5.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 245);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(1700, 31);
            textBox3.TabIndex = 26;
            // 
            // txtBXModalitaCalcolo
            // 
            txtBXModalitaCalcolo.Location = new Point(317, 300);
            txtBXModalitaCalcolo.Name = "txtBXModalitaCalcolo";
            txtBXModalitaCalcolo.Size = new Size(1700, 31);
            txtBXModalitaCalcolo.TabIndex = 25;
            // 
            // txtBXSforzoAmmissibile
            // 
            txtBXSforzoAmmissibile.Location = new Point(317, 66);
            txtBXSforzoAmmissibile.Name = "txtBXSforzoAmmissibile";
            txtBXSforzoAmmissibile.ReadOnly = true;
            txtBXSforzoAmmissibile.Size = new Size(1700, 31);
            txtBXSforzoAmmissibile.TabIndex = 24;
            // 
            // lblParametroVar
            // 
            lblParametroVar.AutoSize = true;
            lblParametroVar.Font = new Font("Segoe UI", 11F);
            lblParametroVar.Location = new Point(20, 300);
            lblParametroVar.Name = "lblParametroVar";
            lblParametroVar.Size = new Size(138, 30);
            lblParametroVar.TabIndex = 22;
            lblParametroVar.Text = "Parametro C:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 16;
            label2.Text = "Materiale:";
            // 
            // lblSforzoAmmissibile
            // 
            lblSforzoAmmissibile.AutoSize = true;
            lblSforzoAmmissibile.Font = new Font("Segoe UI", 11F);
            lblSforzoAmmissibile.Location = new Point(20, 65);
            lblSforzoAmmissibile.Name = "lblSforzoAmmissibile";
            lblSforzoAmmissibile.Size = new Size(263, 30);
            lblSforzoAmmissibile.TabIndex = 21;
            lblSforzoAmmissibile.Text = "Sforzo Ammissibile a T Es:";
            // 
            // lblCoefGiunzione
            // 
            lblCoefGiunzione.AutoSize = true;
            lblCoefGiunzione.Font = new Font("Segoe UI", 11F);
            lblCoefGiunzione.Location = new Point(20, 245);
            lblCoefGiunzione.Name = "lblCoefGiunzione";
            lblCoefGiunzione.Size = new Size(260, 30);
            lblCoefGiunzione.TabIndex = 17;
            lblCoefGiunzione.Text = "Coefficiente di Giunzione:";
            // 
            // lblPressioneDiProgetto
            // 
            lblPressioneDiProgetto.AutoSize = true;
            lblPressioneDiProgetto.Font = new Font("Segoe UI", 11F);
            lblPressioneDiProgetto.Location = new Point(20, 155);
            lblPressioneDiProgetto.Name = "lblPressioneDiProgetto";
            lblPressioneDiProgetto.Size = new Size(225, 30);
            lblPressioneDiProgetto.TabIndex = 20;
            lblPressioneDiProgetto.Text = "Pressione di Progetto:";
            // 
            // lblSovraspessore
            // 
            lblSovraspessore.AutoSize = true;
            lblSovraspessore.Font = new Font("Segoe UI", 11F);
            lblSovraspessore.Location = new Point(20, 200);
            lblSovraspessore.Name = "lblSovraspessore";
            lblSovraspessore.Size = new Size(297, 30);
            lblSovraspessore.TabIndex = 19;
            lblSovraspessore.Text = "Sovraspessore Di Corrosione:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(1800, 890);
            button1.Name = "button1";
            button1.Size = new Size(350, 70);
            button1.TabIndex = 40;
            button1.Text = "Calcola";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(2037, 345);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 48;
            label3.Text = "°C";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1700, 31);
            textBox1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(20, 345);
            label4.Name = "label4";
            label4.Size = new Size(268, 30);
            label4.TabIndex = 46;
            label4.Text = "Temperatura Min Esercizio";
            // 
            // label1
            // 
            label1.Location = new Point(2037, 390);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 51;
            label1.Text = "°C";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 390);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1700, 31);
            textBox2.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(20, 390);
            label5.Name = "label5";
            label5.Size = new Size(272, 30);
            label5.TabIndex = 49;
            label5.Text = "Temperatura Max Esercizio";
            // 
            // Dimensionamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2178, 994);
            Controls.Add(button1);
            Controls.Add(panelDimensionamento);
            Controls.Add(lblTitolo);
            Controls.Add(btnVerifica);
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
        private Button btnVerifica;
        private Label label15;
        private TextBox txtBXModuloElastico;
        private Label lblDiametroInterno;
        private Label label14;
        private Label label13;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox txtBXModalitaCalcolo;
        private TextBox txtBXSforzoAmmissibile;
        private Label lblParametroVar;
        private Label label2;
        private Label lblSforzoAmmissibile;
        private Label lblCoefGiunzione;
        private Label lblPressioneDiProgetto;
        private Label lblSovraspessore;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}
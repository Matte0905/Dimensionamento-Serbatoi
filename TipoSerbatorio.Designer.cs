namespace Dimensionamento_Serbatoi
{
    partial class TipoSerbatorio
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
            label5 = new Label();
            ListaSerbatoi = new Panel();
            radioBtnSferico = new RadioButton();
            radioBtnEllisoidale = new RadioButton();
            radioBtnEmisferico = new RadioButton();
            radioBtnConico = new RadioButton();
            radioButton2 = new RadioButton();
            radioBtnFondoPiatto = new RadioButton();
            radioBtnTorisferico = new RadioButton();
            panelImmagine = new Panel();
            immagineSerbatorio = new PictureBox();
            btnPrecedente = new Button();
            btnSuccessivo = new Button();
            panelDescSerbatoi = new Panel();
            label1 = new Label();
            lblDescSerbatoio = new Label();
            ListaSerbatoi.SuspendLayout();
            panelImmagine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)immagineSerbatorio).BeginInit();
            panelDescSerbatoi.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(850, 30);
            label5.Name = "label5";
            label5.Size = new Size(500, 48);
            label5.TabIndex = 13;
            label5.Text = "Seleziona il Tipo di Serbatoio";
            // 
            // ListaSerbatoi
            // 
            ListaSerbatoi.Controls.Add(radioBtnSferico);
            ListaSerbatoi.Controls.Add(radioBtnEllisoidale);
            ListaSerbatoi.Controls.Add(radioBtnEmisferico);
            ListaSerbatoi.Controls.Add(radioBtnConico);
            ListaSerbatoi.Controls.Add(radioButton2);
            ListaSerbatoi.Controls.Add(radioBtnFondoPiatto);
            ListaSerbatoi.Controls.Add(radioBtnTorisferico);
            ListaSerbatoi.Location = new Point(55, 105);
            ListaSerbatoi.Name = "ListaSerbatoi";
            ListaSerbatoi.Size = new Size(650, 750);
            ListaSerbatoi.TabIndex = 14;
            // 
            // radioBtnSferico
            // 
            radioBtnSferico.Font = new Font("Segoe UI", 11F);
            radioBtnSferico.Location = new Point(30, 550);
            radioBtnSferico.Name = "radioBtnSferico";
            radioBtnSferico.Size = new Size(350, 50);
            radioBtnSferico.TabIndex = 9;
            radioBtnSferico.TabStop = true;
            radioBtnSferico.Text = "Serbatoio Sferico";
            radioBtnSferico.UseVisualStyleBackColor = true;
            // 
            // radioBtnEllisoidale
            // 
            radioBtnEllisoidale.Font = new Font("Segoe UI", 11F);
            radioBtnEllisoidale.Location = new Point(30, 150);
            radioBtnEllisoidale.Name = "radioBtnEllisoidale";
            radioBtnEllisoidale.Size = new Size(350, 50);
            radioBtnEllisoidale.TabIndex = 8;
            radioBtnEllisoidale.TabStop = true;
            radioBtnEllisoidale.Text = "Cilindrico con Fondo Ellisoidale";
            radioBtnEllisoidale.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmisferico
            // 
            radioBtnEmisferico.Font = new Font("Segoe UI", 11F);
            radioBtnEmisferico.Location = new Point(30, 250);
            radioBtnEmisferico.Name = "radioBtnEmisferico";
            radioBtnEmisferico.Size = new Size(350, 50);
            radioBtnEmisferico.TabIndex = 7;
            radioBtnEmisferico.TabStop = true;
            radioBtnEmisferico.Text = "Cilindrico con Fondo Emisferico";
            radioBtnEmisferico.UseVisualStyleBackColor = true;
            // 
            // radioBtnConico
            // 
            radioBtnConico.Font = new Font("Segoe UI", 11F);
            radioBtnConico.Location = new Point(30, 350);
            radioBtnConico.Name = "radioBtnConico";
            radioBtnConico.Size = new Size(350, 50);
            radioBtnConico.TabIndex = 6;
            radioBtnConico.TabStop = true;
            radioBtnConico.Text = "Cilindrico con Fondo Conico";
            radioBtnConico.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 11F);
            radioButton2.Location = new Point(30, 650);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(350, 50);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Serbatoio ad Anello";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioBtnFondoPiatto
            // 
            radioBtnFondoPiatto.Font = new Font("Segoe UI", 11F);
            radioBtnFondoPiatto.Location = new Point(30, 450);
            radioBtnFondoPiatto.Name = "radioBtnFondoPiatto";
            radioBtnFondoPiatto.Size = new Size(350, 50);
            radioBtnFondoPiatto.TabIndex = 3;
            radioBtnFondoPiatto.TabStop = true;
            radioBtnFondoPiatto.Text = "Cilindrico con Fondo Piatto";
            radioBtnFondoPiatto.UseVisualStyleBackColor = true;
            // 
            // radioBtnTorisferico
            // 
            radioBtnTorisferico.Font = new Font("Segoe UI", 11F);
            radioBtnTorisferico.Location = new Point(30, 50);
            radioBtnTorisferico.Name = "radioBtnTorisferico";
            radioBtnTorisferico.Size = new Size(350, 50);
            radioBtnTorisferico.TabIndex = 2;
            radioBtnTorisferico.TabStop = true;
            radioBtnTorisferico.Text = "Cilindrico con Fondo Torisferico";
            radioBtnTorisferico.UseVisualStyleBackColor = true;
            // 
            // panelImmagine
            // 
            panelImmagine.Controls.Add(immagineSerbatorio);
            panelImmagine.Location = new Point(776, 105);
            panelImmagine.Name = "panelImmagine";
            panelImmagine.Size = new Size(650, 750);
            panelImmagine.TabIndex = 15;
            // 
            // immagineSerbatorio
            // 
            immagineSerbatorio.Location = new Point(18, 32);
            immagineSerbatorio.Name = "immagineSerbatorio";
            immagineSerbatorio.Size = new Size(611, 697);
            immagineSerbatorio.TabIndex = 0;
            immagineSerbatorio.TabStop = false;
            // 
            // btnPrecedente
            // 
            btnPrecedente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPrecedente.Location = new Point(1435, 890);
            btnPrecedente.Name = "btnPrecedente";
            btnPrecedente.Size = new Size(350, 70);
            btnPrecedente.TabIndex = 16;
            btnPrecedente.Text = "Precedente";
            btnPrecedente.UseVisualStyleBackColor = true;
            // 
            // btnSuccessivo
            // 
            btnSuccessivo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSuccessivo.Location = new Point(1800, 890);
            btnSuccessivo.Name = "btnSuccessivo";
            btnSuccessivo.Size = new Size(350, 70);
            btnSuccessivo.TabIndex = 17;
            btnSuccessivo.Text = "Successivo";
            btnSuccessivo.UseVisualStyleBackColor = true;
            // 
            // panelDescSerbatoi
            // 
            panelDescSerbatoi.Controls.Add(lblDescSerbatoio);
            panelDescSerbatoi.Location = new Point(1487, 105);
            panelDescSerbatoi.Name = "panelDescSerbatoi";
            panelDescSerbatoi.Size = new Size(650, 750);
            panelDescSerbatoi.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(1487, 77);
            label1.Name = "label1";
            label1.Size = new Size(264, 36);
            label1.TabIndex = 19;
            label1.Text = "Descrizione Serbatoio";
            // 
            // lblDescSerbatoio
            // 
            lblDescSerbatoio.Font = new Font("Segoe UI", 11F);
            lblDescSerbatoio.Location = new Point(17, 32);
            lblDescSerbatoio.Name = "lblDescSerbatoio";
            lblDescSerbatoio.Size = new Size(600, 697);
            lblDescSerbatoio.TabIndex = 0;
            // 
            // TipoSerbatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2178, 994);
            Controls.Add(label1);
            Controls.Add(panelDescSerbatoi);
            Controls.Add(btnSuccessivo);
            Controls.Add(btnPrecedente);
            Controls.Add(panelImmagine);
            Controls.Add(ListaSerbatoi);
            Controls.Add(label5);
            Name = "TipoSerbatorio";
            Text = "TipoSerbatorio";
            ListaSerbatoi.ResumeLayout(false);
            panelImmagine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)immagineSerbatorio).EndInit();
            panelDescSerbatoi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel ListaSerbatoi;
        private RadioButton radioBtnSferico;
        private RadioButton radioBtnEllisoidale;
        private RadioButton radioBtnEmisferico;
        private RadioButton radioBtnConico;
        private RadioButton radioButton2;
        private RadioButton radioBtnFondoPiatto;
        private RadioButton radioBtnTorisferico;
        private Panel panelImmagine;
        private PictureBox immagineSerbatorio;
        private Button btnPrecedente;
        private Button btnSuccessivo;
        private Panel panelDescSerbatoi;
        private Label lblDescSerbatoio;
        private Label label1;
    }
}
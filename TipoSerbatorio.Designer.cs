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
            lblTitolo = new Label();
            ListaSerbatoi = new Panel();
            radioBtnSferico = new RadioButton();
            radioBtnEllisoidale = new RadioButton();
            radioBtnEmisferico = new RadioButton();
            radioBtnConico = new RadioButton();
            radioBtnAnello = new RadioButton();
            radioBtnFondoPiatto = new RadioButton();
            radioBtnTorisferico = new RadioButton();
            panelImmagine = new Panel();
            immagineSerbatorio = new PictureBox();
            btnPrecedente = new Button();
            btnSuccessivo = new Button();
            panelDescSerbatoi = new Panel();
            lblDescSerbatoio = new Label();
            lblTitoloDescSerbatoio = new Label();
            ListaSerbatoi.SuspendLayout();
            panelImmagine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)immagineSerbatorio).BeginInit();
            panelDescSerbatoi.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.Font = new Font("Segoe UI", 18F);
            lblTitolo.Location = new Point(595, 18);
            lblTitolo.Margin = new Padding(2, 0, 2, 0);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(643, 29);
            lblTitolo.TabIndex = 13;
            lblTitolo.Text = "Seleziona il Tipo di Serbatoio";
            // 
            // ListaSerbatoi
            // 
            ListaSerbatoi.Controls.Add(radioBtnSferico);
            ListaSerbatoi.Controls.Add(radioBtnEllisoidale);
            ListaSerbatoi.Controls.Add(radioBtnEmisferico);
            ListaSerbatoi.Controls.Add(radioBtnConico);
            ListaSerbatoi.Controls.Add(radioBtnAnello);
            ListaSerbatoi.Controls.Add(radioBtnFondoPiatto);
            ListaSerbatoi.Controls.Add(radioBtnTorisferico);
            ListaSerbatoi.Location = new Point(38, 63);
            ListaSerbatoi.Margin = new Padding(2, 2, 2, 2);
            ListaSerbatoi.Name = "ListaSerbatoi";
            ListaSerbatoi.Size = new Size(455, 450);
            ListaSerbatoi.TabIndex = 14;
            // 
            // radioBtnSferico
            // 
            radioBtnSferico.Font = new Font("Segoe UI", 11F);
            radioBtnSferico.Location = new Point(21, 330);
            radioBtnSferico.Margin = new Padding(2, 2, 2, 2);
            radioBtnSferico.Name = "radioBtnSferico";
            radioBtnSferico.Size = new Size(245, 30);
            radioBtnSferico.TabIndex = 9;
            radioBtnSferico.TabStop = true;
            radioBtnSferico.Text = "Serbatoio Sferico";
            radioBtnSferico.UseVisualStyleBackColor = true;
            // 
            // radioBtnEllisoidale
            // 
            radioBtnEllisoidale.Font = new Font("Segoe UI", 11F);
            radioBtnEllisoidale.Location = new Point(21, 90);
            radioBtnEllisoidale.Margin = new Padding(2, 2, 2, 2);
            radioBtnEllisoidale.Name = "radioBtnEllisoidale";
            radioBtnEllisoidale.Size = new Size(245, 30);
            radioBtnEllisoidale.TabIndex = 8;
            radioBtnEllisoidale.TabStop = true;
            radioBtnEllisoidale.Text = "Cilindrico con Fondo Ellisoidale";
            radioBtnEllisoidale.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmisferico
            // 
            radioBtnEmisferico.Font = new Font("Segoe UI", 11F);
            radioBtnEmisferico.Location = new Point(21, 150);
            radioBtnEmisferico.Margin = new Padding(2, 2, 2, 2);
            radioBtnEmisferico.Name = "radioBtnEmisferico";
            radioBtnEmisferico.Size = new Size(245, 30);
            radioBtnEmisferico.TabIndex = 7;
            radioBtnEmisferico.TabStop = true;
            radioBtnEmisferico.Text = "Cilindrico con Fondo Emisferico";
            radioBtnEmisferico.UseVisualStyleBackColor = true;
            // 
            // radioBtnConico
            // 
            radioBtnConico.Font = new Font("Segoe UI", 11F);
            radioBtnConico.Location = new Point(21, 210);
            radioBtnConico.Margin = new Padding(2, 2, 2, 2);
            radioBtnConico.Name = "radioBtnConico";
            radioBtnConico.Size = new Size(245, 30);
            radioBtnConico.TabIndex = 6;
            radioBtnConico.TabStop = true;
            radioBtnConico.Text = "Cilindrico con Fondo Conico";
            radioBtnConico.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnello
            // 
            radioBtnAnello.Font = new Font("Segoe UI", 11F);
            radioBtnAnello.Location = new Point(21, 390);
            radioBtnAnello.Margin = new Padding(2, 2, 2, 2);
            radioBtnAnello.Name = "radioBtnAnello";
            radioBtnAnello.Size = new Size(245, 30);
            radioBtnAnello.TabIndex = 4;
            radioBtnAnello.TabStop = true;
            radioBtnAnello.Text = "Serbatoio ad Anello";
            radioBtnAnello.UseVisualStyleBackColor = true;
            // 
            // radioBtnFondoPiatto
            // 
            radioBtnFondoPiatto.Font = new Font("Segoe UI", 11F);
            radioBtnFondoPiatto.Location = new Point(21, 270);
            radioBtnFondoPiatto.Margin = new Padding(2, 2, 2, 2);
            radioBtnFondoPiatto.Name = "radioBtnFondoPiatto";
            radioBtnFondoPiatto.Size = new Size(245, 30);
            radioBtnFondoPiatto.TabIndex = 3;
            radioBtnFondoPiatto.TabStop = true;
            radioBtnFondoPiatto.Text = "Cilindrico con Fondo Piatto";
            radioBtnFondoPiatto.UseVisualStyleBackColor = true;
            // 
            // radioBtnTorisferico
            // 
            radioBtnTorisferico.Font = new Font("Segoe UI", 11F);
            radioBtnTorisferico.Location = new Point(21, 30);
            radioBtnTorisferico.Margin = new Padding(2, 2, 2, 2);
            radioBtnTorisferico.Name = "radioBtnTorisferico";
            radioBtnTorisferico.Size = new Size(245, 30);
            radioBtnTorisferico.TabIndex = 2;
            radioBtnTorisferico.TabStop = true;
            radioBtnTorisferico.Text = "Cilindrico con Fondo Torisferico";
            radioBtnTorisferico.UseVisualStyleBackColor = true;
            // 
            // panelImmagine
            // 
            panelImmagine.Controls.Add(immagineSerbatorio);
            panelImmagine.Location = new Point(543, 63);
            panelImmagine.Margin = new Padding(2, 2, 2, 2);
            panelImmagine.Name = "panelImmagine";
            panelImmagine.Size = new Size(455, 450);
            panelImmagine.TabIndex = 15;
            // 
            // immagineSerbatorio
            // 
            immagineSerbatorio.Location = new Point(13, 19);
            immagineSerbatorio.Margin = new Padding(2, 2, 2, 2);
            immagineSerbatorio.Name = "immagineSerbatorio";
            immagineSerbatorio.Size = new Size(428, 418);
            immagineSerbatorio.TabIndex = 0;
            immagineSerbatorio.TabStop = false;
            // 
            // btnPrecedente
            // 
            btnPrecedente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPrecedente.Location = new Point(1004, 534);
            btnPrecedente.Margin = new Padding(2, 2, 2, 2);
            btnPrecedente.Name = "btnPrecedente";
            btnPrecedente.Size = new Size(245, 42);
            btnPrecedente.TabIndex = 16;
            btnPrecedente.Text = "Precedente";
            btnPrecedente.UseVisualStyleBackColor = true;
            // 
            // btnSuccessivo
            // 
            btnSuccessivo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSuccessivo.Location = new Point(1260, 534);
            btnSuccessivo.Margin = new Padding(2, 2, 2, 2);
            btnSuccessivo.Name = "btnSuccessivo";
            btnSuccessivo.Size = new Size(245, 42);
            btnSuccessivo.TabIndex = 17;
            btnSuccessivo.Text = "Successivo";
            btnSuccessivo.UseVisualStyleBackColor = true;
            btnSuccessivo.Click += btnSuccessivo_Click;
            // 
            // panelDescSerbatoi
            // 
            panelDescSerbatoi.Controls.Add(lblDescSerbatoio);
            panelDescSerbatoi.Location = new Point(1041, 63);
            panelDescSerbatoi.Margin = new Padding(2, 2, 2, 2);
            panelDescSerbatoi.Name = "panelDescSerbatoi";
            panelDescSerbatoi.Size = new Size(455, 450);
            panelDescSerbatoi.TabIndex = 18;
            // 
            // lblDescSerbatoio
            // 
            lblDescSerbatoio.Font = new Font("Segoe UI", 11F);
            lblDescSerbatoio.Location = new Point(12, 19);
            lblDescSerbatoio.Margin = new Padding(2, 0, 2, 0);
            lblDescSerbatoio.Name = "lblDescSerbatoio";
            lblDescSerbatoio.Size = new Size(420, 418);
            lblDescSerbatoio.TabIndex = 0;
            // 
            // lblTitoloDescSerbatoio
            // 
            lblTitoloDescSerbatoio.AutoSize = true;
            lblTitoloDescSerbatoio.Font = new Font("Segoe UI", 13F);
            lblTitoloDescSerbatoio.Location = new Point(1041, 46);
            lblTitoloDescSerbatoio.Margin = new Padding(2, 0, 2, 0);
            lblTitoloDescSerbatoio.Name = "lblTitoloDescSerbatoio";
            lblTitoloDescSerbatoio.Size = new Size(184, 25);
            lblTitoloDescSerbatoio.TabIndex = 19;
            lblTitoloDescSerbatoio.Text = "Descrizione Serbatoio";
            // 
            // TipoSerbatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 596);
            Controls.Add(lblTitoloDescSerbatoio);
            Controls.Add(panelDescSerbatoi);
            Controls.Add(btnSuccessivo);
            Controls.Add(btnPrecedente);
            Controls.Add(panelImmagine);
            Controls.Add(ListaSerbatoi);
            Controls.Add(lblTitolo);
            Margin = new Padding(2, 2, 2, 2);
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

        private Label lblTitolo;
        private Panel ListaSerbatoi;
        private RadioButton radioBtnSferico;
        private RadioButton radioBtnEllisoidale;
        private RadioButton radioBtnEmisferico;
        private RadioButton radioBtnConico;
        private RadioButton radioBtnAnello;
        private RadioButton radioBtnFondoPiatto;
        private RadioButton radioBtnTorisferico;
        private Panel panelImmagine;
        private PictureBox immagineSerbatorio;
        private Button btnPrecedente;
        private Button btnSuccessivo;
        private Panel panelDescSerbatoi;
        private Label lblDescSerbatoio;
        private Label lblTitoloDescSerbatoio;
    }
}
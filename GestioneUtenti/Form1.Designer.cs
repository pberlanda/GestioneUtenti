namespace GestioneUtenti
{
    partial class frmGestioneUtenti
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabNuovoUtente_txtClasse = new TextBox();
            tabNuovoUtente_lblClasse = new Label();
            tabNuovoUtente_cboTipo = new ComboBox();
            tabNuovoUtente_lblTipo = new Label();
            tabNuovoUtente_lblCognome = new Label();
            tabNuovoUtente_txtCognome = new TextBox();
            tabNuovoUtente_txtNome = new TextBox();
            tabNuovoUtente_lblNome = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnEsci = new Button();
            tabNuovoUtente_btnCreaUtente = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(1, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(798, 401);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabNuovoUtente_btnCreaUtente);
            tabPage1.Controls.Add(tabNuovoUtente_txtClasse);
            tabPage1.Controls.Add(tabNuovoUtente_lblClasse);
            tabPage1.Controls.Add(tabNuovoUtente_cboTipo);
            tabPage1.Controls.Add(tabNuovoUtente_lblTipo);
            tabPage1.Controls.Add(tabNuovoUtente_lblCognome);
            tabPage1.Controls.Add(tabNuovoUtente_txtCognome);
            tabPage1.Controls.Add(tabNuovoUtente_txtNome);
            tabPage1.Controls.Add(tabNuovoUtente_lblNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 373);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabNuovoUtente_txtClasse
            // 
            tabNuovoUtente_txtClasse.Location = new Point(106, 105);
            tabNuovoUtente_txtClasse.Name = "tabNuovoUtente_txtClasse";
            tabNuovoUtente_txtClasse.Size = new Size(140, 23);
            tabNuovoUtente_txtClasse.TabIndex = 6;
            // 
            // tabNuovoUtente_lblClasse
            // 
            tabNuovoUtente_lblClasse.AutoSize = true;
            tabNuovoUtente_lblClasse.Location = new Point(14, 108);
            tabNuovoUtente_lblClasse.Name = "tabNuovoUtente_lblClasse";
            tabNuovoUtente_lblClasse.Size = new Size(40, 15);
            tabNuovoUtente_lblClasse.TabIndex = 5;
            tabNuovoUtente_lblClasse.Text = "Classe";
            // 
            // tabNuovoUtente_cboTipo
            // 
            tabNuovoUtente_cboTipo.FormattingEnabled = true;
            tabNuovoUtente_cboTipo.Location = new Point(106, 76);
            tabNuovoUtente_cboTipo.Name = "tabNuovoUtente_cboTipo";
            tabNuovoUtente_cboTipo.Size = new Size(280, 23);
            tabNuovoUtente_cboTipo.TabIndex = 3;
            // 
            // tabNuovoUtente_lblTipo
            // 
            tabNuovoUtente_lblTipo.AutoSize = true;
            tabNuovoUtente_lblTipo.Location = new Point(14, 79);
            tabNuovoUtente_lblTipo.Name = "tabNuovoUtente_lblTipo";
            tabNuovoUtente_lblTipo.Size = new Size(30, 15);
            tabNuovoUtente_lblTipo.TabIndex = 4;
            tabNuovoUtente_lblTipo.Text = "Tipo";
            // 
            // tabNuovoUtente_lblCognome
            // 
            tabNuovoUtente_lblCognome.AutoSize = true;
            tabNuovoUtente_lblCognome.Location = new Point(14, 50);
            tabNuovoUtente_lblCognome.Name = "tabNuovoUtente_lblCognome";
            tabNuovoUtente_lblCognome.Size = new Size(60, 15);
            tabNuovoUtente_lblCognome.TabIndex = 3;
            tabNuovoUtente_lblCognome.Text = "Cognome";
            // 
            // tabNuovoUtente_txtCognome
            // 
            tabNuovoUtente_txtCognome.Location = new Point(106, 47);
            tabNuovoUtente_txtCognome.Name = "tabNuovoUtente_txtCognome";
            tabNuovoUtente_txtCognome.Size = new Size(280, 23);
            tabNuovoUtente_txtCognome.TabIndex = 2;
            // 
            // tabNuovoUtente_txtNome
            // 
            tabNuovoUtente_txtNome.Location = new Point(106, 18);
            tabNuovoUtente_txtNome.Name = "tabNuovoUtente_txtNome";
            tabNuovoUtente_txtNome.Size = new Size(280, 23);
            tabNuovoUtente_txtNome.TabIndex = 1;
            // 
            // tabNuovoUtente_lblNome
            // 
            tabNuovoUtente_lblNome.AutoSize = true;
            tabNuovoUtente_lblNome.Location = new Point(14, 21);
            tabNuovoUtente_lblNome.Name = "tabNuovoUtente_lblNome";
            tabNuovoUtente_lblNome.Size = new Size(40, 15);
            tabNuovoUtente_lblNome.TabIndex = 0;
            tabNuovoUtente_lblNome.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 373);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(790, 373);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            btnEsci.Location = new Point(713, 415);
            btnEsci.Name = "btnEsci";
            btnEsci.Size = new Size(75, 23);
            btnEsci.TabIndex = 1;
            btnEsci.Text = "&Esci";
            btnEsci.UseVisualStyleBackColor = true;
            btnEsci.Click += btnEsci_Click;
            // 
            // tabNuovoUtente_btnCreaUtente
            // 
            tabNuovoUtente_btnCreaUtente.Location = new Point(110, 146);
            tabNuovoUtente_btnCreaUtente.Name = "tabNuovoUtente_btnCreaUtente";
            tabNuovoUtente_btnCreaUtente.Size = new Size(82, 23);
            tabNuovoUtente_btnCreaUtente.TabIndex = 7;
            tabNuovoUtente_btnCreaUtente.Text = "&Crea utente";
            tabNuovoUtente_btnCreaUtente.UseVisualStyleBackColor = true;
            tabNuovoUtente_btnCreaUtente.Click += tabNuovoUtente_btnCreaUtente_Click;
            // 
            // frmGestioneUtenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEsci);
            Controls.Add(tabControl);
            Name = "frmGestioneUtenti";
            Text = "Gestione utenti";
            Load += frmGestioneUtenti_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnEsci;
        private TabPage tabPage3;
        private Label tabNuovoUtente_lblTipo;
        private Label tabNuovoUtente_lblCognome;
        private TextBox tabNuovoUtente_txtCognome;
        private TextBox tabNuovoUtente_txtNome;
        private Label tabNuovoUtente_lblNome;
        private ComboBox tabNuovoUtente_cboTipo;
        private TextBox tabNuovoUtente_txtClasse;
        private Label tabNuovoUtente_lblClasse;
        private Button tabNuovoUtente_btnCreaUtente;
    }
}

﻿namespace GestioneUtenti
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
            tabNuovoUtente_btnAutocompletamentoUsername = new Button();
            tabNuovoUtente_txtUsername = new TextBox();
            tabNuovoUtente_lblUsername = new Label();
            tabNuovoUtente_btnCreaUtente = new Button();
            tabNuovoUtente_txtClasse = new TextBox();
            tabNuovoUtente_lblClasse = new Label();
            tabNuovoUtente_cboTipo = new ComboBox();
            tabNuovoUtente_lblTipo = new Label();
            tabNuovoUtente_lblCognome = new Label();
            tabNuovoUtente_txtCognome = new TextBox();
            tabNuovoUtente_txtNome = new TextBox();
            tabNuovoUtente_lblNome = new Label();
            tabPage2 = new TabPage();
            TabElimina_btnElimina = new Button();
            TabElimina_cboTipo = new ComboBox();
            TabElimina_lblTipo = new Label();
            TabElimina_txtUsername = new TextBox();
            TabElimina_lblUsername = new Label();
            tabPage3 = new TabPage();
            btnEsci = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabPage1.Controls.Add(tabNuovoUtente_btnAutocompletamentoUsername);
            tabPage1.Controls.Add(tabNuovoUtente_txtUsername);
            tabPage1.Controls.Add(tabNuovoUtente_lblUsername);
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
            // tabNuovoUtente_btnAutocompletamentoUsername
            // 
            tabNuovoUtente_btnAutocompletamentoUsername.Location = new Point(388, 72);
            tabNuovoUtente_btnAutocompletamentoUsername.Margin = new Padding(2, 1, 2, 1);
            tabNuovoUtente_btnAutocompletamentoUsername.Name = "tabNuovoUtente_btnAutocompletamentoUsername";
            tabNuovoUtente_btnAutocompletamentoUsername.Size = new Size(43, 21);
            tabNuovoUtente_btnAutocompletamentoUsername.TabIndex = 4;
            tabNuovoUtente_btnAutocompletamentoUsername.Text = "auto";
            tabNuovoUtente_btnAutocompletamentoUsername.UseVisualStyleBackColor = true;
            tabNuovoUtente_btnAutocompletamentoUsername.Click += tabNuovoUtente_btnAutocompletamentoUsername_Click;
            // 
            // tabNuovoUtente_txtUsername
            // 
            tabNuovoUtente_txtUsername.Location = new Point(106, 74);
            tabNuovoUtente_txtUsername.Margin = new Padding(2, 1, 2, 1);
            tabNuovoUtente_txtUsername.Name = "tabNuovoUtente_txtUsername";
            tabNuovoUtente_txtUsername.Size = new Size(280, 23);
            tabNuovoUtente_txtUsername.TabIndex = 3;
            // 
            // tabNuovoUtente_lblUsername
            // 
            tabNuovoUtente_lblUsername.AutoSize = true;
            tabNuovoUtente_lblUsername.Location = new Point(14, 77);
            tabNuovoUtente_lblUsername.Margin = new Padding(2, 0, 2, 0);
            tabNuovoUtente_lblUsername.Name = "tabNuovoUtente_lblUsername";
            tabNuovoUtente_lblUsername.Size = new Size(60, 15);
            tabNuovoUtente_lblUsername.TabIndex = 8;
            tabNuovoUtente_lblUsername.Text = "Username";
            // 
            // tabNuovoUtente_btnCreaUtente
            // 
            tabNuovoUtente_btnCreaUtente.Location = new Point(106, 185);
            tabNuovoUtente_btnCreaUtente.Name = "tabNuovoUtente_btnCreaUtente";
            tabNuovoUtente_btnCreaUtente.Size = new Size(82, 23);
            tabNuovoUtente_btnCreaUtente.TabIndex = 6;
            tabNuovoUtente_btnCreaUtente.Text = "&Crea utente";
            tabNuovoUtente_btnCreaUtente.UseVisualStyleBackColor = true;
            tabNuovoUtente_btnCreaUtente.Click += tabNuovoUtente_btnCreaUtente_Click;
            // 
            // tabNuovoUtente_txtClasse
            // 
            tabNuovoUtente_txtClasse.Location = new Point(106, 139);
            tabNuovoUtente_txtClasse.Name = "tabNuovoUtente_txtClasse";
            tabNuovoUtente_txtClasse.Size = new Size(140, 23);
            tabNuovoUtente_txtClasse.TabIndex = 5;
            tabNuovoUtente_txtClasse.TextChanged += tabNuovoUtente_txtClasse_TextChanged;
            // 
            // tabNuovoUtente_lblClasse
            // 
            tabNuovoUtente_lblClasse.AutoSize = true;
            tabNuovoUtente_lblClasse.Location = new Point(14, 142);
            tabNuovoUtente_lblClasse.Name = "tabNuovoUtente_lblClasse";
            tabNuovoUtente_lblClasse.Size = new Size(40, 15);
            tabNuovoUtente_lblClasse.TabIndex = 5;
            tabNuovoUtente_lblClasse.Text = "Classe";
            // 
            // tabNuovoUtente_cboTipo
            // 
            tabNuovoUtente_cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tabNuovoUtente_cboTipo.FormattingEnabled = true;
            tabNuovoUtente_cboTipo.Location = new Point(106, 108);
            tabNuovoUtente_cboTipo.Name = "tabNuovoUtente_cboTipo";
            tabNuovoUtente_cboTipo.Size = new Size(280, 23);
            tabNuovoUtente_cboTipo.TabIndex = 4;
            tabNuovoUtente_cboTipo.SelectedIndexChanged += tabNuovoUtente_cboTipo_SelectedIndexChanged;
            // 
            // tabNuovoUtente_lblTipo
            // 
            tabNuovoUtente_lblTipo.AutoSize = true;
            tabNuovoUtente_lblTipo.Location = new Point(14, 110);
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
            tabNuovoUtente_lblCognome.Click += tabNuovoUtente_lblCognome_Click;
            // 
            // tabNuovoUtente_txtCognome
            // 
            tabNuovoUtente_txtCognome.Location = new Point(106, 47);
            tabNuovoUtente_txtCognome.Name = "tabNuovoUtente_txtCognome";
            tabNuovoUtente_txtCognome.Size = new Size(280, 23);
            tabNuovoUtente_txtCognome.TabIndex = 2;
            tabNuovoUtente_txtCognome.TextChanged += tabNuovoUtente_txtCognome_TextChanged;
            // 
            // tabNuovoUtente_txtNome
            // 
            tabNuovoUtente_txtNome.Location = new Point(106, 18);
            tabNuovoUtente_txtNome.Name = "tabNuovoUtente_txtNome";
            tabNuovoUtente_txtNome.Size = new Size(280, 23);
            tabNuovoUtente_txtNome.TabIndex = 1;
            tabNuovoUtente_txtNome.TextChanged += tabNuovoUtente_txtNome_TextChanged;
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
            tabPage2.Controls.Add(TabElimina_btnElimina);
            tabPage2.Controls.Add(TabElimina_cboTipo);
            tabPage2.Controls.Add(TabElimina_lblTipo);
            tabPage2.Controls.Add(TabElimina_txtUsername);
            tabPage2.Controls.Add(TabElimina_lblUsername);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 373);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabElimina_btnElimina
            // 
            TabElimina_btnElimina.Location = new Point(301, 201);
            TabElimina_btnElimina.Name = "TabElimina_btnElimina";
            TabElimina_btnElimina.Size = new Size(82, 23);
            TabElimina_btnElimina.TabIndex = 13;
            TabElimina_btnElimina.Text = "&Elimina utente";
            TabElimina_btnElimina.UseVisualStyleBackColor = true;
            TabElimina_btnElimina.Click += TabElimina_btnElimina_Click;
            // 
            // TabElimina_cboTipo
            // 
            TabElimina_cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            TabElimina_cboTipo.FormattingEnabled = true;
            TabElimina_cboTipo.Location = new Point(301, 172);
            TabElimina_cboTipo.Name = "TabElimina_cboTipo";
            TabElimina_cboTipo.Size = new Size(280, 23);
            TabElimina_cboTipo.TabIndex = 11;
            // 
            // TabElimina_lblTipo
            // 
            TabElimina_lblTipo.AutoSize = true;
            TabElimina_lblTipo.Location = new Point(209, 174);
            TabElimina_lblTipo.Name = "TabElimina_lblTipo";
            TabElimina_lblTipo.Size = new Size(30, 15);
            TabElimina_lblTipo.TabIndex = 12;
            TabElimina_lblTipo.Text = "Tipo";
            // 
            // TabElimina_txtUsername
            // 
            TabElimina_txtUsername.Location = new Point(301, 145);
            TabElimina_txtUsername.Margin = new Padding(2, 1, 2, 1);
            TabElimina_txtUsername.Name = "TabElimina_txtUsername";
            TabElimina_txtUsername.Size = new Size(280, 23);
            TabElimina_txtUsername.TabIndex = 9;
            // 
            // TabElimina_lblUsername
            // 
            TabElimina_lblUsername.AutoSize = true;
            TabElimina_lblUsername.Location = new Point(209, 148);
            TabElimina_lblUsername.Margin = new Padding(2, 0, 2, 0);
            TabElimina_lblUsername.Name = "TabElimina_lblUsername";
            TabElimina_lblUsername.Size = new Size(60, 15);
            TabElimina_lblUsername.TabIndex = 10;
            TabElimina_lblUsername.Text = "Username";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Label tabNuovoUtente_lblUsername;
        private TextBox tabNuovoUtente_txtUsername;
        private Button tabNuovoUtente_btnAutocompletamentoUsername;
        private Button TabElimina_btnElimina;
        private ComboBox TabElimina_cboTipo;
        private Label TabElimina_lblTipo;
        private TextBox TabElimina_txtUsername;
        private Label TabElimina_lblUsername;
    }
}

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
            tabNuovoUtente_ckTestMode = new CheckBox();
            tabNuovoUtente_lblTestCmd = new Label();
            pictureBox1 = new PictureBox();
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
            menuStrip1 = new MenuStrip();
            tabPage2 = new TabPage();
            TabElimina_btnElimina = new Button();
            TabElimina_cboTipo = new ComboBox();
            TabElimina_lblTipo = new Label();
            TabElimina_txtUsername = new TextBox();
            TabElimina_lblUsername = new Label();
            tabPage3 = new TabPage();
            tabCopiaTemi_txtTemaFine = new NumericUpDown();
            tabCopiaTemi_txtTemaInizio = new NumericUpDown();
            tabCopiaTemi_btnEseguiCopia = new Button();
            tabCopiaTemi_lblTemaFine = new Label();
            tabCopiaTemi_lblTemaInizio = new Label();
            btnEsci = new Button();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            menuStrip4 = new MenuStrip();
            MainMenu = new ToolStripMenuItem();
            posizioneScriptsToolStripMenuItem = new ToolStripMenuItem();
            esciToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabCopiaTemi_txtTemaFine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabCopiaTemi_txtTemaInizio).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(1, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(645, 365);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabNuovoUtente_ckTestMode);
            tabPage1.Controls.Add(tabNuovoUtente_lblTestCmd);
            tabPage1.Controls.Add(pictureBox1);
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
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(637, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabNuovoUtente_ckTestMode
            // 
            tabNuovoUtente_ckTestMode.AutoSize = true;
            tabNuovoUtente_ckTestMode.Location = new Point(142, 205);
            tabNuovoUtente_ckTestMode.Name = "tabNuovoUtente_ckTestMode";
            tabNuovoUtente_ckTestMode.Size = new Size(329, 19);
            tabNuovoUtente_ckTestMode.TabIndex = 11;
            tabNuovoUtente_ckTestMode.Text = "Modalità test (Visualizza il comando senza creare l'utente)";
            tabNuovoUtente_ckTestMode.UseVisualStyleBackColor = true;
            // 
            // tabNuovoUtente_lblTestCmd
            // 
            tabNuovoUtente_lblTestCmd.AutoSize = true;
            tabNuovoUtente_lblTestCmd.BackColor = Color.Black;
            tabNuovoUtente_lblTestCmd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabNuovoUtente_lblTestCmd.ForeColor = SystemColors.Control;
            tabNuovoUtente_lblTestCmd.Location = new Point(142, 283);
            tabNuovoUtente_lblTestCmd.Name = "tabNuovoUtente_lblTestCmd";
            tabNuovoUtente_lblTestCmd.Size = new Size(43, 17);
            tabNuovoUtente_lblTestCmd.TabIndex = 10;
            tabNuovoUtente_lblTestCmd.Text = "label1";
            tabNuovoUtente_lblTestCmd.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_add_user_group_woman_man_48;
            pictureBox1.Location = new Point(567, 7);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // tabNuovoUtente_btnAutocompletamentoUsername
            // 
            tabNuovoUtente_btnAutocompletamentoUsername.Location = new Point(424, 89);
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
            tabNuovoUtente_txtUsername.Location = new Point(142, 91);
            tabNuovoUtente_txtUsername.Margin = new Padding(2, 1, 2, 1);
            tabNuovoUtente_txtUsername.Name = "tabNuovoUtente_txtUsername";
            tabNuovoUtente_txtUsername.Size = new Size(280, 23);
            tabNuovoUtente_txtUsername.TabIndex = 3;
            // 
            // tabNuovoUtente_lblUsername
            // 
            tabNuovoUtente_lblUsername.AutoSize = true;
            tabNuovoUtente_lblUsername.Location = new Point(50, 94);
            tabNuovoUtente_lblUsername.Margin = new Padding(2, 0, 2, 0);
            tabNuovoUtente_lblUsername.Name = "tabNuovoUtente_lblUsername";
            tabNuovoUtente_lblUsername.Size = new Size(60, 15);
            tabNuovoUtente_lblUsername.TabIndex = 8;
            tabNuovoUtente_lblUsername.Text = "Username";
            // 
            // tabNuovoUtente_btnCreaUtente
            // 
            tabNuovoUtente_btnCreaUtente.Location = new Point(142, 242);
            tabNuovoUtente_btnCreaUtente.Name = "tabNuovoUtente_btnCreaUtente";
            tabNuovoUtente_btnCreaUtente.Size = new Size(82, 23);
            tabNuovoUtente_btnCreaUtente.TabIndex = 7;
            tabNuovoUtente_btnCreaUtente.Text = "&Crea utente";
            tabNuovoUtente_btnCreaUtente.UseVisualStyleBackColor = true;
            tabNuovoUtente_btnCreaUtente.Click += tabNuovoUtente_btnCreaUtente_Click;
            // 
            // tabNuovoUtente_txtClasse
            // 
            tabNuovoUtente_txtClasse.Location = new Point(142, 159);
            tabNuovoUtente_txtClasse.Name = "tabNuovoUtente_txtClasse";
            tabNuovoUtente_txtClasse.Size = new Size(140, 23);
            tabNuovoUtente_txtClasse.TabIndex = 6;
            tabNuovoUtente_txtClasse.TextChanged += tabNuovoUtente_txtClasse_TextChanged;
            // 
            // tabNuovoUtente_lblClasse
            // 
            tabNuovoUtente_lblClasse.AutoSize = true;
            tabNuovoUtente_lblClasse.Location = new Point(50, 159);
            tabNuovoUtente_lblClasse.Name = "tabNuovoUtente_lblClasse";
            tabNuovoUtente_lblClasse.Size = new Size(40, 15);
            tabNuovoUtente_lblClasse.TabIndex = 5;
            tabNuovoUtente_lblClasse.Text = "Classe";
            // 
            // tabNuovoUtente_cboTipo
            // 
            tabNuovoUtente_cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tabNuovoUtente_cboTipo.FormattingEnabled = true;
            tabNuovoUtente_cboTipo.Location = new Point(142, 125);
            tabNuovoUtente_cboTipo.Name = "tabNuovoUtente_cboTipo";
            tabNuovoUtente_cboTipo.Size = new Size(200, 23);
            tabNuovoUtente_cboTipo.TabIndex = 5;
            tabNuovoUtente_cboTipo.SelectedIndexChanged += tabNuovoUtente_cboTipo_SelectedIndexChanged;
            // 
            // tabNuovoUtente_lblTipo
            // 
            tabNuovoUtente_lblTipo.AutoSize = true;
            tabNuovoUtente_lblTipo.Location = new Point(50, 127);
            tabNuovoUtente_lblTipo.Name = "tabNuovoUtente_lblTipo";
            tabNuovoUtente_lblTipo.Size = new Size(30, 15);
            tabNuovoUtente_lblTipo.TabIndex = 4;
            tabNuovoUtente_lblTipo.Text = "Tipo";
            // 
            // tabNuovoUtente_lblCognome
            // 
            tabNuovoUtente_lblCognome.AutoSize = true;
            tabNuovoUtente_lblCognome.Location = new Point(50, 67);
            tabNuovoUtente_lblCognome.Name = "tabNuovoUtente_lblCognome";
            tabNuovoUtente_lblCognome.Size = new Size(60, 15);
            tabNuovoUtente_lblCognome.TabIndex = 3;
            tabNuovoUtente_lblCognome.Text = "Cognome";
            tabNuovoUtente_lblCognome.Click += tabNuovoUtente_lblCognome_Click;
            // 
            // tabNuovoUtente_txtCognome
            // 
            tabNuovoUtente_txtCognome.Location = new Point(142, 64);
            tabNuovoUtente_txtCognome.Name = "tabNuovoUtente_txtCognome";
            tabNuovoUtente_txtCognome.Size = new Size(280, 23);
            tabNuovoUtente_txtCognome.TabIndex = 2;
            tabNuovoUtente_txtCognome.TextChanged += tabNuovoUtente_txtCognome_TextChanged;
            // 
            // tabNuovoUtente_txtNome
            // 
            tabNuovoUtente_txtNome.Location = new Point(142, 35);
            tabNuovoUtente_txtNome.Name = "tabNuovoUtente_txtNome";
            tabNuovoUtente_txtNome.Size = new Size(280, 23);
            tabNuovoUtente_txtNome.TabIndex = 1;
            tabNuovoUtente_txtNome.TextChanged += tabNuovoUtente_txtNome_TextChanged;
            // 
            // tabNuovoUtente_lblNome
            // 
            tabNuovoUtente_lblNome.AutoSize = true;
            tabNuovoUtente_lblNome.Location = new Point(50, 38);
            tabNuovoUtente_lblNome.Name = "tabNuovoUtente_lblNome";
            tabNuovoUtente_lblNome.Size = new Size(40, 15);
            tabNuovoUtente_lblNome.TabIndex = 0;
            tabNuovoUtente_lblNome.Text = "Nome";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(631, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
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
            tabPage2.Size = new Size(637, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabElimina_btnElimina
            // 
            TabElimina_btnElimina.Location = new Point(133, 95);
            TabElimina_btnElimina.Name = "TabElimina_btnElimina";
            TabElimina_btnElimina.Size = new Size(82, 23);
            TabElimina_btnElimina.TabIndex = 10;
            TabElimina_btnElimina.Text = "&Elimina utente";
            TabElimina_btnElimina.UseVisualStyleBackColor = true;
            TabElimina_btnElimina.Click += TabElimina_btnElimina_Click;
            // 
            // TabElimina_cboTipo
            // 
            TabElimina_cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            TabElimina_cboTipo.FormattingEnabled = true;
            TabElimina_cboTipo.Location = new Point(133, 66);
            TabElimina_cboTipo.Name = "TabElimina_cboTipo";
            TabElimina_cboTipo.Size = new Size(179, 23);
            TabElimina_cboTipo.TabIndex = 9;
            TabElimina_cboTipo.SelectedIndexChanged += TabElimina_cboTipo_SelectedIndexChanged;
            // 
            // TabElimina_lblTipo
            // 
            TabElimina_lblTipo.AutoSize = true;
            TabElimina_lblTipo.Location = new Point(41, 68);
            TabElimina_lblTipo.Name = "TabElimina_lblTipo";
            TabElimina_lblTipo.Size = new Size(30, 15);
            TabElimina_lblTipo.TabIndex = 12;
            TabElimina_lblTipo.Text = "Tipo";
            // 
            // TabElimina_txtUsername
            // 
            TabElimina_txtUsername.Location = new Point(133, 38);
            TabElimina_txtUsername.Margin = new Padding(2, 1, 2, 1);
            TabElimina_txtUsername.Name = "TabElimina_txtUsername";
            TabElimina_txtUsername.Size = new Size(280, 23);
            TabElimina_txtUsername.TabIndex = 8;
            // 
            // TabElimina_lblUsername
            // 
            TabElimina_lblUsername.AutoSize = true;
            TabElimina_lblUsername.Location = new Point(41, 42);
            TabElimina_lblUsername.Margin = new Padding(2, 0, 2, 0);
            TabElimina_lblUsername.Name = "TabElimina_lblUsername";
            TabElimina_lblUsername.Size = new Size(60, 15);
            TabElimina_lblUsername.TabIndex = 10;
            TabElimina_lblUsername.Text = "Username";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabCopiaTemi_txtTemaFine);
            tabPage3.Controls.Add(tabCopiaTemi_txtTemaInizio);
            tabPage3.Controls.Add(tabCopiaTemi_btnEseguiCopia);
            tabPage3.Controls.Add(tabCopiaTemi_lblTemaFine);
            tabPage3.Controls.Add(tabCopiaTemi_lblTemaInizio);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(637, 337);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabCopiaTemi_txtTemaFine
            // 
            tabCopiaTemi_txtTemaFine.Location = new Point(122, 58);
            tabCopiaTemi_txtTemaFine.Margin = new Padding(2, 1, 2, 1);
            tabCopiaTemi_txtTemaFine.Name = "tabCopiaTemi_txtTemaFine";
            tabCopiaTemi_txtTemaFine.Size = new Size(55, 23);
            tabCopiaTemi_txtTemaFine.TabIndex = 12;
            // 
            // tabCopiaTemi_txtTemaInizio
            // 
            tabCopiaTemi_txtTemaInizio.Location = new Point(122, 33);
            tabCopiaTemi_txtTemaInizio.Margin = new Padding(2, 1, 2, 1);
            tabCopiaTemi_txtTemaInizio.Name = "tabCopiaTemi_txtTemaInizio";
            tabCopiaTemi_txtTemaInizio.Size = new Size(55, 23);
            tabCopiaTemi_txtTemaInizio.TabIndex = 11;
            // 
            // tabCopiaTemi_btnEseguiCopia
            // 
            tabCopiaTemi_btnEseguiCopia.Location = new Point(122, 91);
            tabCopiaTemi_btnEseguiCopia.Margin = new Padding(2, 1, 2, 1);
            tabCopiaTemi_btnEseguiCopia.Name = "tabCopiaTemi_btnEseguiCopia";
            tabCopiaTemi_btnEseguiCopia.Size = new Size(105, 27);
            tabCopiaTemi_btnEseguiCopia.TabIndex = 13;
            tabCopiaTemi_btnEseguiCopia.Text = "Esegui copia";
            tabCopiaTemi_btnEseguiCopia.UseVisualStyleBackColor = true;
            tabCopiaTemi_btnEseguiCopia.Click += tabCopiaTemi_btnEseguiCopia_Click;
            // 
            // tabCopiaTemi_lblTemaFine
            // 
            tabCopiaTemi_lblTemaFine.AutoSize = true;
            tabCopiaTemi_lblTemaFine.Location = new Point(34, 60);
            tabCopiaTemi_lblTemaFine.Margin = new Padding(2, 0, 2, 0);
            tabCopiaTemi_lblTemaFine.Name = "tabCopiaTemi_lblTemaFine";
            tabCopiaTemi_lblTemaFine.Size = new Size(60, 15);
            tabCopiaTemi_lblTemaFine.TabIndex = 2;
            tabCopiaTemi_lblTemaFine.Text = "Tema Fine";
            // 
            // tabCopiaTemi_lblTemaInizio
            // 
            tabCopiaTemi_lblTemaInizio.AutoSize = true;
            tabCopiaTemi_lblTemaInizio.Location = new Point(34, 35);
            tabCopiaTemi_lblTemaInizio.Margin = new Padding(2, 0, 2, 0);
            tabCopiaTemi_lblTemaInizio.Name = "tabCopiaTemi_lblTemaInizio";
            tabCopiaTemi_lblTemaInizio.Size = new Size(66, 15);
            tabCopiaTemi_lblTemaInizio.TabIndex = 0;
            tabCopiaTemi_lblTemaInizio.Text = "Tema inizio";
            tabCopiaTemi_lblTemaInizio.Click += label1_Click;
            // 
            // btnEsci
            // 
            btnEsci.Location = new Point(560, 395);
            btnEsci.Name = "btnEsci";
            btnEsci.Size = new Size(75, 23);
            btnEsci.TabIndex = 14;
            btnEsci.Text = "&Esci";
            btnEsci.UseVisualStyleBackColor = true;
            btnEsci.Click += btnEsci_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 48);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(647, 24);
            menuStrip2.TabIndex = 15;
            // 
            // menuStrip3
            // 
            menuStrip3.Location = new Point(0, 24);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(647, 24);
            menuStrip3.TabIndex = 16;
            // 
            // menuStrip4
            // 
            menuStrip4.Location = new Point(0, 0);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(647, 24);
            menuStrip4.TabIndex = 17;
            // 
            // MainMenu
            // 
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(32, 19);
            // 
            // posizioneScriptsToolStripMenuItem
            // 
            posizioneScriptsToolStripMenuItem.Name = "posizioneScriptsToolStripMenuItem";
            posizioneScriptsToolStripMenuItem.Size = new Size(32, 19);
            // 
            // esciToolStripMenuItem
            // 
            esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            esciToolStripMenuItem.Size = new Size(32, 19);
            // 
            // frmGestioneUtenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 430);
            Controls.Add(btnEsci);
            Controls.Add(tabControl);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Controls.Add(menuStrip4);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestioneUtenti";
            Text = "Gestione utenti";
            Load += frmGestioneUtenti_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabCopiaTemi_txtTemaFine).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabCopiaTemi_txtTemaInizio).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label tabCopiaTemi_lblTemaInizio;
        private Button tabCopiaTemi_btnEseguiCopia;
        private Label tabCopiaTemi_lblTemaFine;
        private NumericUpDown tabCopiaTemi_txtTemaFine;
        private NumericUpDown tabCopiaTemi_txtTemaInizio;
        private PictureBox pictureBox1;
        private Label tabNuovoUtente_lblTestCmd;
        private CheckBox tabNuovoUtente_ckTestMode;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem MainMenu;
        private ToolStripMenuItem posizioneScriptsToolStripMenuItem;
        private ToolStripMenuItem esciToolStripMenuItem;
        //private OpenFileDialog openFileDialog1;
        //private OpenFileDialog openFileDialog2;
    }
}

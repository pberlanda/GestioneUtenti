using System.Diagnostics;

namespace GestioneUtenti
{
    public partial class frmGestioneUtenti : Form
    {
        public frmGestioneUtenti()
        {
            InitializeComponent();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestioneUtenti_Load(object sender, EventArgs e)
        {

            tabControl.TabPages[0].Text = "Nuovo utente";
            tabControl.TabPages[1].Text = "Elimina utente";
            tabControl.TabPages[2].Text = "Raccogli temi";

            // ************
            // nuovo utente
            // ************
            tabNuovoUtente_txtNome.Text = "";
            tabNuovoUtente_txtCognome.Text = "";
            tabNuovoUtente_txtUsername.Text = "";

            tabNuovoUtente_cboTipo.Items.Clear();
            tabNuovoUtente_cboTipo.Items.Add("Studente");
            tabNuovoUtente_cboTipo.Items.Add("Docente");
            tabNuovoUtente_cboTipo.Items.Add("Assistente di laboratorio");

            // imposta tipo studente
            tabNuovoUtente_cboTipo.SelectedIndex = 0;

            tabNuovoUtente_lblTestCmd.Text = "il comando da eseguire viene visualizzato qu¨¬";

            // **************
            // elimina utente
            // **************
            TabElimina_txtUsername.Text = "";

            TabElimina_cboTipo.Items.Clear();
            TabElimina_cboTipo.Items.Add("Studente");
            TabElimina_cboTipo.Items.Add("Docente");
            TabElimina_cboTipo.Items.Add("Assistente di laboratorio");

            // imposta tipo studente
            TabElimina_cboTipo.SelectedIndex = 0;

            // **********
            // copia temi
            // **********

            tabCopiaTemi_txtTemaInizio.Minimum = 0;
            tabCopiaTemi_txtTemaInizio.Maximum = 90;

            tabCopiaTemi_txtTemaFine.Minimum = 0;
            tabCopiaTemi_txtTemaFine.Maximum = 90;

            tabCopiaTemi_txtTemaInizio.Value = 0;
            tabCopiaTemi_txtTemaFine.Value = 0;
        }

        private void tabNuovoUtente_txtNome_GotFocus(object sender, EventArgs e)
        {
            tabNuovoUtente_txtNome.BackColor = Color.Yellow;
        }

        private void tabNuovoUtente_btnCreaUtente_Click(object sender, EventArgs e)
        {
            // controlla tutti i dati immessi
            if (!controlloNuovoUtente())
            {

                return;
            }

            // se non ¨¨ in modalit¨¤ test, chiede conferma prima di proseguire
            if (!tabNuovoUtente_ckTestMode.Checked) {


                if (MessageBox.Show("Stai per creare il nuovo utente " + tabNuovoUtente_txtUsername.Text + ". Proseguire?", "Controllo dati nuovo utente", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }

            // esegui la creazione dell'utente
            creaUtente();
        }

        private void creaUtente()
        {
            // Specify the path to your batch file
            string batchFilePath = @"E:\script\script";

            // determina lo script da utilizzare e compone il comando
            int selectedIndex = tabNuovoUtente_cboTipo.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    batchFilePath += @"\creaUserStudente.cmd " + tabNuovoUtente_txtNome.Text + " " + tabNuovoUtente_txtCognome.Text + " " + tabNuovoUtente_txtUsername.Text + " " + tabNuovoUtente_txtClasse.Text;
                    break;
                case 1:
                    batchFilePath += @"\creaUserDocente.cmd " + tabNuovoUtente_txtNome.Text + " " + tabNuovoUtente_txtCognome.Text;
                    break;
                case 2:
                    batchFilePath += @"\creaUserALS.cmd " + tabNuovoUtente_txtNome.Text + " " + tabNuovoUtente_txtCognome.Text;
                    break;
            }

            // test command
            tabNuovoUtente_lblTestCmd.Text = batchFilePath;

            // se in modalit?test, termina. Altrimenti prosegue con l'esecuzione del comando
            if (tabNuovoUtente_ckTestMode.Checked == true) { return; }

            // Create a new process
            Process process = new Process();

            // Specify the file name (batch file) to be executed
            process.StartInfo.FileName = "cmd.exe";

            // Pass the batch file path as an argument
            process.StartInfo.Arguments = $"/C \"{batchFilePath}\"";

            // Ensure that the process window is hidden
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the process
            process.Start();

            // Wait for the process to exit
            process.WaitForExit();
        }
        private void eliminaUtente()
        {
            // Specify the path to your batch file
            string batchFilePath = @"E:\script\script";

            // compone lo script in base al tipo utente selezionato
            int tipoUtente = TabElimina_cboTipo.SelectedIndex;

            switch (tipoUtente)
            {
                case 0:
                    batchFilePath += @"\eliminaStudente.cmd " + TabElimina_txtUsername.Text;
                    break;

                case 1:
                    batchFilePath += @"\eliminaDocente.cmd " + TabElimina_txtUsername.Text;
                    break;

                case 2:
                    batchFilePath += @"\eliminaALS.cmd " + TabElimina_txtUsername.Text;
                    break;
            }


            // Create a new process
            Process process = new Process();

            // Specify the file name (batch file) to be executed
            process.StartInfo.FileName = "cmd.exe";

            // Pass the batch file path as an argument
            process.StartInfo.Arguments = $"/C \"{batchFilePath}\"";

            // Ensure that the process window is hidden
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the process
            process.Start();

            // Wait for the process to exit
            process.WaitForExit();
        }

        private Boolean controlloNuovoUtente()
        {
            // nome deve essere immesso
            if (tabNuovoUtente_txtNome.Text == "")
            {
                MessageBox.Show("Nome non immesso!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_txtNome.Focus();
                return false;
            }

            // cognome deve essere immesso
            if (tabNuovoUtente_txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non immesso!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_txtCognome.Focus();
                return false;
            }

            // username deve essere immesso
            if (tabNuovoUtente_txtUsername.Text == "")
            {
                MessageBox.Show("Username non immesso!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_txtUsername.Focus();
                return false;
            }

            // usernmae non pu?essere pi?lungo di 20 caratteri
            if (tabNuovoUtente_txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Username troppo lungo! (max 20 caratteri)", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_txtUsername.Focus();
                return false;
            }

            // tipo utente deve essere selezionato
            if (tabNuovoUtente_cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Tipo non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_cboTipo.Focus();
                return false;
            }

            // controlla la classe se tipo utente ¨¨ studente
            if (tabNuovoUtente_cboTipo.SelectedIndex == 0)
            {
                if (tabNuovoUtente_txtClasse.Text == "")
                {
                    MessageBox.Show("Classe non immessa!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabNuovoUtente_txtClasse.Focus();
                    return false;
                }
            }

            // arrivati qui significa che il controllo ¨¨ stato completato
            return true;
        }

        private Boolean controlloEliminaUtente()
        {
            // username deve essere immesso
            if (TabElimina_txtUsername.Text == "")
            {
                MessageBox.Show("Username non immesso!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabElimina_txtUsername.Focus();
                return false;

            }

            // tipo utente deve essere selezionato
            if (TabElimina_cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Tipo non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabElimina_cboTipo.Focus();
                return false;
            }

            // arrivati qui significa che il controllo ¨¨ stato completato
            return true;
        }

        private Boolean ControlloCopiaTemi()
        {
            if (tabCopiaTemi_txtTemaInizio.Value == 0)
            {
                MessageBox.Show("Primo tema non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabCopiaTemi_txtTemaInizio.Focus();
                return false;
            }

            if (tabCopiaTemi_txtTemaFine.Value == 0)
            {
                MessageBox.Show("Ultimo tema non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabCopiaTemi_txtTemaFine.Focus();
                return false;
            }

            if (tabCopiaTemi_txtTemaInizio.Value > tabCopiaTemi_txtTemaFine.Value)
            {
                MessageBox.Show("Primo tema superiore di ultimo tema!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabCopiaTemi_txtTemaFine.Focus();
                return false;
            }

            return true;
        }
        private void tabNuovoUtente_cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabNuovoUtente_cboTipo.SelectedItem != null)
            {
                if (tabNuovoUtente_cboTipo.SelectedIndex == 0)
                {
                    tabNuovoUtente_txtClasse.Enabled = true;
                }
                else
                {
                    tabNuovoUtente_txtClasse.Enabled = false;
                }
            }

        }

        private void tabNuovoUtente_lblCognome_Click(object sender, EventArgs e)
        {

        }

        private void tabNuovoUtente_txtClasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabNuovoUtente_txtNome_TextChanged(object sender, EventArgs e)
        {
            componiUsername();
        }

        private void componiUsername()
        {

            // se nome e cognome non sono immessi termina
            if (tabNuovoUtente_txtNome.Text == "" & tabNuovoUtente_txtCognome.Text == "")
            {
                return;
            }

            string nome, cognome, username;

            nome = tabNuovoUtente_txtNome.Text.Trim();
            cognome = tabNuovoUtente_txtCognome.Text.Trim();

            nome = nome.ToLower();
            cognome = cognome.ToLower();

            username = nome + "." + cognome;
            username = username.Replace(" ", "");

            tabNuovoUtente_txtUsername.Text = username;
        }

        private void tabNuovoUtente_txtCognome_TextChanged(object sender, EventArgs e)
        {
            componiUsername();
        }

        private void tabNuovoUtente_btnAutocompletamentoUsername_Click(object sender, EventArgs e)
        {
            componiUsername();
        }

        private void TabElimina_btnElimina_Click(object sender, EventArgs e)
        {
            if (!controlloEliminaUtente()) { return; };

            eliminaUtente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabCopiaTemi_btnEseguiCopia_Click(object sender, EventArgs e)
        {
            if (!ControlloCopiaTemi()) { return; }

            copiaTemi();


        }
        private void copiaTemi()
        {
            // Specify the path to your batch file
            string batchFilePath = @"D:\dev\GestioneUtenti\command.cmd";

            // Create a new process
            Process process = new Process();

            // Specify the file name (batch file) to be executed
            process.StartInfo.FileName = "cmd.exe";

            // Pass the batch file path as an argument
            process.StartInfo.Arguments = $"/C \"{batchFilePath}\"";

            // Ensure that the process window is hidden
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the process
            process.Start();

            // Wait for the process to exit
            process.WaitForExit();
        }

        private void TabElimina_cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabNuovoUtente_btnSelectScriptPath_Click(object sender, EventArgs e)
        {

            OpenFileDialog nuovoUtenteOpenFileDialog = new OpenFileDialog();

            nuovoUtenteOpenFileDialog.InitialDirectory = "C:\\";
            //nuovoUtenteOpenFileDialog.Filter = "*.cmd";
            nuovoUtenteOpenFileDialog.FilterIndex = 0;
            nuovoUtenteOpenFileDialog.RestoreDirectory = true;
            nuovoUtenteOpenFileDialog.Title = "seleziona lo script di gestione utenti";
            nuovoUtenteOpenFileDialog.Multiselect = false;
            nuovoUtenteOpenFileDialog.ShowDialog();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
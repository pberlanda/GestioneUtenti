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

            tabNuovoUtente_txtNome.Text = "";
            tabNuovoUtente_txtCognome.Text = "";

            tabNuovoUtente_cboTipo.Items.Clear();
            tabNuovoUtente_cboTipo.Items.Add("Studente");
            tabNuovoUtente_cboTipo.Items.Add("Docente");
            tabNuovoUtente_cboTipo.Items.Add("Assistente di laboratorio");
        }

        private void tabNuovoUtente_txtNome_GotFocus(object sender, EventArgs e)
        {
            tabNuovoUtente_txtNome.BackColor = Color.Yellow;
        }

        private void tabNuovoUtente_btnCreaUtente_Click(object sender, EventArgs e)
        {
            if (!controllo())
            {
                return;
            }
        }

        private Boolean controllo()
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

            // tipo utente deve essere selezionato
            if (tabNuovoUtente_cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Tipo non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_cboTipo.Focus();
                return false;

            }

            // controlla la classe se tipo utente ии studente
            if (tabNuovoUtente_cboTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Classe non immessa!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabNuovoUtente_txtClasse.Focus();
                return false;

            }

            // arrivati qui significa che il controllo ии stato completato
            return true;
        }

        private void tabNuovoUtente_cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (tabNuovoUtente_cboTipo.SelectedItem != null)
            {
                if (tabNuovoUtente_cboTipo.SelectedIndex == 0)
                {
                    tabNuovoUtente_txtClasse.Enabled=true;
                } else
                {
                    tabNuovoUtente_txtClasse.Enabled = false;
                }
            }

        }
    }
}
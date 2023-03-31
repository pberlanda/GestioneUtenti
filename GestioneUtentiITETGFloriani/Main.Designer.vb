<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tab1ButtonEsegui = New System.Windows.Forms.Button()
        Me.tab1LabelWelcome = New System.Windows.Forms.Label()
        Me.tab1TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.tab1TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.tab1TextBoxNome = New System.Windows.Forms.TextBox()
        Me.lableNomeUtente = New System.Windows.Forms.Label()
        Me.labelCognome = New System.Windows.Forms.Label()
        Me.labelNome = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tab2ButtonEsegui = New System.Windows.Forms.Button()
        Me.tab2welcome = New System.Windows.Forms.Label()
        Me.tab2TextBoxNomeUente = New System.Windows.Forms.TextBox()
        Me.tab2LabelNomeUtente = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCopiaTemiSelezionaScript = New System.Windows.Forms.Button()
        Me.txtCopiaTemiPathToScript = New System.Windows.Forms.TextBox()
        Me.lblCopiaTemiScript = New System.Windows.Forms.Label()
        Me.NumericUpDownTemiSvoltiFine = New System.Windows.Forms.NumericUpDown()
        Me.btnSelezionaCartella = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TextBoxDestinazione = New System.Windows.Forms.TextBox()
        Me.LabelDestinazione = New System.Windows.Forms.Label()
        Me.btnCopiaTemi = New System.Windows.Forms.Button()
        Me.NumericUpDownTemiSvoltiInizio = New System.Windows.Forms.NumericUpDown()
        Me.LabelTemi = New System.Windows.Forms.Label()
        Me.tab3welcome = New System.Windows.Forms.Label()
        Me.btnEsci = New System.Windows.Forms.Button()
        Me.TabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.NumericUpDownTemiSvoltiFine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTemiSvoltiInizio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabPage1)
        Me.TabMain.Controls.Add(Me.TabPage2)
        Me.TabMain.Controls.Add(Me.TabPage3)
        Me.TabMain.Location = New System.Drawing.Point(0, 2)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(780, 208)
        Me.TabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Tab1ButtonEsegui)
        Me.TabPage1.Controls.Add(Me.tab1LabelWelcome)
        Me.TabPage1.Controls.Add(Me.tab1TextBoxUsername)
        Me.TabPage1.Controls.Add(Me.tab1TextBoxCognome)
        Me.TabPage1.Controls.Add(Me.tab1TextBoxNome)
        Me.TabPage1.Controls.Add(Me.lableNomeUtente)
        Me.TabPage1.Controls.Add(Me.labelCognome)
        Me.TabPage1.Controls.Add(Me.labelNome)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(721, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Tab1ButtonEsegui
        '
        Me.Tab1ButtonEsegui.Location = New System.Drawing.Point(101, 105)
        Me.Tab1ButtonEsegui.Name = "Tab1ButtonEsegui"
        Me.Tab1ButtonEsegui.Size = New System.Drawing.Size(75, 23)
        Me.Tab1ButtonEsegui.TabIndex = 7
        Me.Tab1ButtonEsegui.Text = "Esegui"
        Me.Tab1ButtonEsegui.UseVisualStyleBackColor = True
        '
        'tab1LabelWelcome
        '
        Me.tab1LabelWelcome.Location = New System.Drawing.Point(398, 15)
        Me.tab1LabelWelcome.Name = "tab1LabelWelcome"
        Me.tab1LabelWelcome.Size = New System.Drawing.Size(257, 154)
        Me.tab1LabelWelcome.TabIndex = 11
        Me.tab1LabelWelcome.Text = "welcome msg"
        '
        'tab1TextBoxUsername
        '
        Me.tab1TextBoxUsername.Location = New System.Drawing.Point(101, 69)
        Me.tab1TextBoxUsername.Name = "tab1TextBoxUsername"
        Me.tab1TextBoxUsername.Size = New System.Drawing.Size(236, 20)
        Me.tab1TextBoxUsername.TabIndex = 5
        '
        'tab1TextBoxCognome
        '
        Me.tab1TextBoxCognome.Location = New System.Drawing.Point(101, 42)
        Me.tab1TextBoxCognome.Name = "tab1TextBoxCognome"
        Me.tab1TextBoxCognome.Size = New System.Drawing.Size(236, 20)
        Me.tab1TextBoxCognome.TabIndex = 2
        '
        'tab1TextBoxNome
        '
        Me.tab1TextBoxNome.Location = New System.Drawing.Point(101, 15)
        Me.tab1TextBoxNome.Name = "tab1TextBoxNome"
        Me.tab1TextBoxNome.Size = New System.Drawing.Size(236, 20)
        Me.tab1TextBoxNome.TabIndex = 1
        '
        'lableNomeUtente
        '
        Me.lableNomeUtente.AutoSize = True
        Me.lableNomeUtente.Location = New System.Drawing.Point(21, 71)
        Me.lableNomeUtente.Name = "lableNomeUtente"
        Me.lableNomeUtente.Size = New System.Drawing.Size(55, 13)
        Me.lableNomeUtente.TabIndex = 3
        Me.lableNomeUtente.Text = "Username"
        '
        'labelCognome
        '
        Me.labelCognome.AutoSize = True
        Me.labelCognome.Location = New System.Drawing.Point(23, 45)
        Me.labelCognome.Name = "labelCognome"
        Me.labelCognome.Size = New System.Drawing.Size(52, 13)
        Me.labelCognome.TabIndex = 1
        Me.labelCognome.Text = "Cognome"
        '
        'labelNome
        '
        Me.labelNome.AutoSize = True
        Me.labelNome.Location = New System.Drawing.Point(23, 18)
        Me.labelNome.Name = "labelNome"
        Me.labelNome.Size = New System.Drawing.Size(35, 13)
        Me.labelNome.TabIndex = 0
        Me.labelNome.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Tab2ButtonEsegui)
        Me.TabPage2.Controls.Add(Me.tab2welcome)
        Me.TabPage2.Controls.Add(Me.tab2TextBoxNomeUente)
        Me.TabPage2.Controls.Add(Me.tab2LabelNomeUtente)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(721, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tab2ButtonEsegui
        '
        Me.Tab2ButtonEsegui.Location = New System.Drawing.Point(93, 52)
        Me.Tab2ButtonEsegui.Name = "Tab2ButtonEsegui"
        Me.Tab2ButtonEsegui.Size = New System.Drawing.Size(75, 23)
        Me.Tab2ButtonEsegui.TabIndex = 10
        Me.Tab2ButtonEsegui.Text = "Esegui"
        Me.Tab2ButtonEsegui.UseVisualStyleBackColor = True
        '
        'tab2welcome
        '
        Me.tab2welcome.Location = New System.Drawing.Point(362, 17)
        Me.tab2welcome.Name = "tab2welcome"
        Me.tab2welcome.Size = New System.Drawing.Size(309, 68)
        Me.tab2welcome.TabIndex = 14
        Me.tab2welcome.Text = "welcome msg"
        '
        'tab2TextBoxNomeUente
        '
        Me.tab2TextBoxNomeUente.Location = New System.Drawing.Point(93, 17)
        Me.tab2TextBoxNomeUente.Name = "tab2TextBoxNomeUente"
        Me.tab2TextBoxNomeUente.Size = New System.Drawing.Size(263, 20)
        Me.tab2TextBoxNomeUente.TabIndex = 8
        '
        'tab2LabelNomeUtente
        '
        Me.tab2LabelNomeUtente.AutoSize = True
        Me.tab2LabelNomeUtente.Location = New System.Drawing.Point(12, 20)
        Me.tab2LabelNomeUtente.Name = "tab2LabelNomeUtente"
        Me.tab2LabelNomeUtente.Size = New System.Drawing.Size(68, 13)
        Me.tab2LabelNomeUtente.TabIndex = 0
        Me.tab2LabelNomeUtente.Text = "Nome utente"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnCopiaTemiSelezionaScript)
        Me.TabPage3.Controls.Add(Me.txtCopiaTemiPathToScript)
        Me.TabPage3.Controls.Add(Me.lblCopiaTemiScript)
        Me.TabPage3.Controls.Add(Me.NumericUpDownTemiSvoltiFine)
        Me.TabPage3.Controls.Add(Me.btnSelezionaCartella)
        Me.TabPage3.Controls.Add(Me.ProgressBar)
        Me.TabPage3.Controls.Add(Me.TextBoxDestinazione)
        Me.TabPage3.Controls.Add(Me.LabelDestinazione)
        Me.TabPage3.Controls.Add(Me.btnCopiaTemi)
        Me.TabPage3.Controls.Add(Me.NumericUpDownTemiSvoltiInizio)
        Me.TabPage3.Controls.Add(Me.LabelTemi)
        Me.TabPage3.Controls.Add(Me.tab3welcome)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(772, 182)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnCopiaTemiSelezionaScript
        '
        Me.btnCopiaTemiSelezionaScript.Location = New System.Drawing.Point(551, 50)
        Me.btnCopiaTemiSelezionaScript.Name = "btnCopiaTemiSelezionaScript"
        Me.btnCopiaTemiSelezionaScript.Size = New System.Drawing.Size(23, 20)
        Me.btnCopiaTemiSelezionaScript.TabIndex = 36
        Me.btnCopiaTemiSelezionaScript.Text = "..."
        Me.btnCopiaTemiSelezionaScript.UseVisualStyleBackColor = True
        '
        'txtCopiaTemiPathToScript
        '
        Me.txtCopiaTemiPathToScript.Location = New System.Drawing.Point(139, 50)
        Me.txtCopiaTemiPathToScript.Name = "txtCopiaTemiPathToScript"
        Me.txtCopiaTemiPathToScript.Size = New System.Drawing.Size(406, 20)
        Me.txtCopiaTemiPathToScript.TabIndex = 35
        '
        'lblCopiaTemiScript
        '
        Me.lblCopiaTemiScript.AutoSize = True
        Me.lblCopiaTemiScript.Location = New System.Drawing.Point(17, 54)
        Me.lblCopiaTemiScript.Name = "lblCopiaTemiScript"
        Me.lblCopiaTemiScript.Size = New System.Drawing.Size(81, 13)
        Me.lblCopiaTemiScript.TabIndex = 34
        Me.lblCopiaTemiScript.Text = "Seleziona script"
        '
        'NumericUpDownTemiSvoltiFine
        '
        Me.NumericUpDownTemiSvoltiFine.Location = New System.Drawing.Point(190, 19)
        Me.NumericUpDownTemiSvoltiFine.Name = "NumericUpDownTemiSvoltiFine"
        Me.NumericUpDownTemiSvoltiFine.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDownTemiSvoltiFine.TabIndex = 26
        '
        'btnSelezionaCartella
        '
        Me.btnSelezionaCartella.Location = New System.Drawing.Point(550, 94)
        Me.btnSelezionaCartella.Name = "btnSelezionaCartella"
        Me.btnSelezionaCartella.Size = New System.Drawing.Size(24, 23)
        Me.btnSelezionaCartella.TabIndex = 33
        Me.btnSelezionaCartella.Text = "..."
        Me.btnSelezionaCartella.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(20, 139)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(287, 23)
        Me.ProgressBar.TabIndex = 32
        '
        'TextBoxDestinazione
        '
        Me.TextBoxDestinazione.Location = New System.Drawing.Point(137, 96)
        Me.TextBoxDestinazione.Name = "TextBoxDestinazione"
        Me.TextBoxDestinazione.Size = New System.Drawing.Size(409, 20)
        Me.TextBoxDestinazione.TabIndex = 27
        Me.TextBoxDestinazione.Text = "O:\"
        '
        'LabelDestinazione
        '
        Me.LabelDestinazione.AutoSize = True
        Me.LabelDestinazione.Location = New System.Drawing.Point(17, 99)
        Me.LabelDestinazione.Name = "LabelDestinazione"
        Me.LabelDestinazione.Size = New System.Drawing.Size(103, 13)
        Me.LabelDestinazione.TabIndex = 30
        Me.LabelDestinazione.Text = "Dove salvaere i temi"
        '
        'btnCopiaTemi
        '
        Me.btnCopiaTemi.Location = New System.Drawing.Point(321, 139)
        Me.btnCopiaTemi.Name = "btnCopiaTemi"
        Me.btnCopiaTemi.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiaTemi.TabIndex = 29
        Me.btnCopiaTemi.Text = "Ok"
        Me.btnCopiaTemi.UseVisualStyleBackColor = True
        '
        'NumericUpDownTemiSvoltiInizio
        '
        Me.NumericUpDownTemiSvoltiInizio.Location = New System.Drawing.Point(138, 19)
        Me.NumericUpDownTemiSvoltiInizio.Name = "NumericUpDownTemiSvoltiInizio"
        Me.NumericUpDownTemiSvoltiInizio.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDownTemiSvoltiInizio.TabIndex = 25
        '
        'LabelTemi
        '
        Me.LabelTemi.AutoSize = True
        Me.LabelTemi.Location = New System.Drawing.Point(18, 21)
        Me.LabelTemi.Name = "LabelTemi"
        Me.LabelTemi.Size = New System.Drawing.Size(110, 13)
        Me.LabelTemi.TabIndex = 28
        Me.LabelTemi.Text = "Copia temi (da 1 a 90)"
        '
        'tab3welcome
        '
        Me.tab3welcome.Location = New System.Drawing.Point(592, 37)
        Me.tab3welcome.Name = "tab3welcome"
        Me.tab3welcome.Size = New System.Drawing.Size(166, 98)
        Me.tab3welcome.TabIndex = 15
        Me.tab3welcome.Text = "welcome msg"
        '
        'btnEsci
        '
        Me.btnEsci.Location = New System.Drawing.Point(599, 216)
        Me.btnEsci.Name = "btnEsci"
        Me.btnEsci.Size = New System.Drawing.Size(75, 23)
        Me.btnEsci.TabIndex = 11
        Me.btnEsci.Text = "&Esci"
        Me.btnEsci.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 251)
        Me.Controls.Add(Me.btnEsci)
        Me.Controls.Add(Me.TabMain)
        Me.Name = "Main"
        Me.Text = "Gestione Utenti Uffici Segreteria ITET Giacomo Floriani"
        Me.TabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.NumericUpDownTemiSvoltiFine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTemiSvoltiInizio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnEsci As System.Windows.Forms.Button
    Friend WithEvents tab1TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents tab1TextBoxCognome As System.Windows.Forms.TextBox
    Friend WithEvents tab1TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents lableNomeUtente As System.Windows.Forms.Label
    Friend WithEvents labelCognome As System.Windows.Forms.Label
    Friend WithEvents labelNome As System.Windows.Forms.Label
    Friend WithEvents tab1LabelWelcome As System.Windows.Forms.Label
    Friend WithEvents tab2TextBoxNomeUente As System.Windows.Forms.TextBox
    Friend WithEvents tab2LabelNomeUtente As System.Windows.Forms.Label
    Friend WithEvents tab2welcome As System.Windows.Forms.Label
    Friend WithEvents Tab1ButtonEsegui As Button
    Friend WithEvents Tab2ButtonEsegui As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents NumericUpDownTemiSvoltiFine As NumericUpDown
    Friend WithEvents btnSelezionaCartella As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TextBoxDestinazione As TextBox
    Friend WithEvents LabelDestinazione As Label
    Friend WithEvents btnCopiaTemi As Button
    Friend WithEvents NumericUpDownTemiSvoltiInizio As NumericUpDown
    Friend WithEvents LabelTemi As Label
    Friend WithEvents tab3welcome As Label
    Friend WithEvents btnCopiaTemiSelezionaScript As Button
    Friend WithEvents txtCopiaTemiPathToScript As TextBox
    Friend WithEvents lblCopiaTemiScript As Label
End Class

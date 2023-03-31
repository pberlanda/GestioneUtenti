Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' visualizza la versione

        Me.Text = "Gestione Utenti ITET Giacomo Floriani"

        ' imposta i nomi dei tab

        TabMain.TabPages.Item(0).Text = "Nuovo utente"
        TabMain.TabPages.Item(1).Text = "Elimina utente"

        ' *****
        ' TAB 1
        ' *****

        ' imposta il welcome

        tab1LabelWelcome.Text = "Crea nuovo utente. Verrà creato l'utente in AD e verrà creata la home directory con i relativi permessi. Lo username avrà la forma ncognome. Non sono ammessi spazi. Al primo accesso è necessario cambiare la password. La passwrd di default è Covid2020"

        ' imposta i tipi di utente disponibili

        ' *****
        ' TAB 2
        ' *****

        ' imposta il welcome

        tab2welcome.Text = "Eliminare l'utente da AD, le cartelle del profilo utente e la home direcotry"

    End Sub

    Private Sub btnEsci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsci.Click

        ' chiudi tutto

        Application.Exit()

    End Sub

    Private Sub TextBoxNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxNome.GotFocus

        tab1TextBoxNome.BackColor = Color.LightGoldenrodYellow

    End Sub

    Private Sub TextBoxNome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxNome.LostFocus

        tab1TextBoxNome.BackColor = Color.White

    End Sub

    Private Sub TextBoxCognome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxCognome.GotFocus

        tab1TextBoxCognome.BackColor = Color.LightGoldenrodYellow

    End Sub

    Private Sub TextBoxCognome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxCognome.LostFocus

        tab1TextBoxCognome.BackColor = Color.White

    End Sub

    Private Sub TextBoxUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxUsername.GotFocus

        tab1TextBoxUsername.BackColor = Color.LightGoldenrodYellow


    End Sub

    Private Sub TextBoxUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab1TextBoxUsername.LostFocus

        tab1TextBoxUsername.BackColor = Color.White

    End Sub

    Private Function check() As Boolean

        ' fallito

        check = False

        ' nome

        If Trim(tab1TextBoxNome.Text) = "" Then
            MsgBox("Manca il nome!", MsgBoxStyle.Exclamation)
            tab1TextBoxNome.Focus()
            Exit Function
        End If

        ' cognome

        If Trim(tab1TextBoxCognome.Text) = "" Then
            MsgBox("Manca il cognome!", MsgBoxStyle.Exclamation)
            tab1TextBoxCognome.Focus()
            Exit Function
        End If

        ' username

        If Trim(tab1TextBoxUsername.Text) = "" Then
            MsgBox("Manca Username!", MsgBoxStyle.Exclamation)
            tab1TextBoxUsername.Focus()
            Exit Function
        End If

        ' controlla la lunghezza username

        If Len(tab1TextBoxUsername.Text) > 20 Then
            MsgBox("Username supera la lunghezza massima consentita di 20! Accorcia il nome o il cognome o modifica l'username", MsgBoxStyle.Exclamation)
            tab1TextBoxUsername.Focus()
            Exit Function
        End If

        ' ok

        check = True

    End Function

    Private Sub TextBoxCognome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab1TextBoxCognome.TextChanged

        generaUsername()

    End Sub

    Private Sub TextBoxNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab1TextBoxNome.TextChanged

        generaUsername()

    End Sub

    Private Sub generaUsername()

        ' compone la stringa dello username: tutto minuscolo, prima lettera del nome + il cognome. si tolgono anche gli spazi

        tab1TextBoxUsername.Text = Trim(LCase(tab1TextBoxNome.Text.Substring(0, 1)) + LCase(tab1TextBoxCognome.Text))

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' cancella tutto ma chiede conferma

        If MsgBox("Cancello tutti i dati immessi ok?", MsgBoxStyle.YesNo) = vbNo Then Exit Sub

        tab1TextBoxNome.Text = ""
        tab1TextBoxCognome.Text = ""
        tab1TextBoxUsername.Text = ""

    End Sub

    Private Function checkEliminaUtente() As Boolean

        ' fallito

        checkEliminaUtente = False

        ' nome utente

        If Trim(tab2TextBoxNomeUente.Text) = "" Then
            MsgBox("Nome utente da eliminare non immesso", vbExclamation)
            tab2TextBoxNomeUente.Focus()
            Exit Function
        End If

        ' ok

        checkEliminaUtente = True

    End Function

    Private Sub TextBoxNomeUente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab2TextBoxNomeUente.GotFocus

        tab2TextBoxNomeUente.BackColor = Color.LightGoldenrodYellow

    End Sub

    Private Sub TextBoxNomeUente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab2TextBoxNomeUente.LostFocus

        tab2TextBoxNomeUente.BackColor = Color.White

    End Sub

    Private Sub Tab1ButtonEsegui_Click(sender As Object, e As EventArgs) Handles Tab1ButtonEsegui.Click
        Dim sCmd As String

        ' check dati immessi

        If check() = False Then Exit Sub

        ' inizializza la stringa del comando
        sCmd = ""

        ' scrive il comando
        sCmd = "E:\script\creaUtente.cmd " + tab1TextBoxNome.Text + " " + tab1TextBoxCognome.Text + " " + tab1TextBoxUsername.Text

        ' run
        Shell(sCmd, AppWinStyle.NormalFocus)

    End Sub

    Private Sub Tab2ButtonEsegui_Click(sender As Object, e As EventArgs) Handles Tab2ButtonEsegui.Click
        Dim sCmd As String

        ' controllo

        If checkEliminaUtente() = False Then Exit Sub

        ' inizializza la stringa del comando
        sCmd = "E:\script\EliminaUtente.cmd " + tab2TextBoxNomeUente.Text

        ' scrive il comando
        ' sCmd = "E:\script\script\creaUtenteALS.cmd " + tab1TextBoxNome.Text + " " + tab1TextBoxCognome.Text + " " + tab1TextBoxUsername.Text

        ' run
        Shell(sCmd, AppWinStyle.NormalFocus)

    End Sub
End Class

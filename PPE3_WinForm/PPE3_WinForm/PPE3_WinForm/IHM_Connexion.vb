Public Class IHM_Connexion

    Dim myConnection As New Odbc.OdbcConnection
    Dim connString As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Textbox Login longueur max 8
        Login.MaxLength = 8

        'Textbox Mdp longueur max 10
        Mdp.MaxLength = 10

        'Connexion à l'utilisateur de la base
        connString = "DSN=PPEORA;Uid=PPE3_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        'Boucle de connexion à la base oracle avec gestion d'erreur
        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'Démarrage du timer
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Affectation au label 4 la date du jour
        DateDirect.Text = Date.Now.ToString("dd MMM yyyy")

        'Affectation au label 5 l'heure actuelle en dynamique
        HeureDirect.Text = Date.Now.ToString("hh : mm : ss")

    End Sub

End Class

Public Class Form1

    Dim myConnection As New Odbc.OdbcConnection
    Dim connString As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Connexion à l'utilisateur de la base
        connString = "DSN=ORA16;Uid=system;Pwd=estran;"

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
        Label4.Text = Date.Now.ToString("dd MMM yyyy")

        'Affectation au label 5 l'heure actuelle en dynamique
        Label5.Text = Date.Now.ToString("hh : mm : ss")

    End Sub

End Class

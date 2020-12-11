Public Class IHM_Acceuil

    Dim myConnection As New Odbc.OdbcConnection
    Dim connString As String
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Private Sub IHM_Acceuil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démarrage du timer
        Timer1.Enabled = True

        'Connexion à l'utilisateur de la base
        'connString = "DSN=PPEORA;Uid=PPE3_GSB;Pwd=estran;"

        'myConnection.ConnectionString = connString

        'Boucle de connexion à la base oracle avec gestion d'erreur
        'Try
        'myConnection.Open()
        'MessageBox.Show("Connexion Oracle Réussie")

        '     Catch ex As Odbc.OdbcException
        'MessageBox.Show(ex.Message)
        'End Try

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Affectation au label DateDirect la date du jour
        DateDirect.Text = Date.Now.ToString("dd MMM yyyy")

    End Sub

 
    Private Sub Fermeture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fermeture.Click
        'Ferme l'application
        Application.ExitThread()
    End Sub


    Private Sub ConsultStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultStat.Click
        Me.Hide()
        IHM_Consult_Stat.Show()

    End Sub
End Class
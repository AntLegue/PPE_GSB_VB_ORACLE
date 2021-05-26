Public Class saisie_login

    Public idvisiteur As Integer

    Public myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Private Sub Accueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Connexion à la VM ORACLE
        connString = "DSN=ORA16;Uid=PPE3;Pwd=estran;"

        'Connexion à la ferme de Serveur
        'connString = "DSN=CnxOracleFermeD25;Uid=slam16;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT id, (prenom_visiteur || ' ' ||nom_visiteur) nom_prenom_visiteur FROM visiteur ORDER BY id"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Me.Login.DataSource = donnee
        Me.Login.DisplayMember = "nom_prenom_visiteur"
        Me.Login.ValueMember = "id"

    End Sub

    Private Sub Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Connexion.Click
        Dim idchoix As String = Login.SelectedValue

        myConnection.Close()
        myConnection.Open()

        Dim query2 As String = "SELECT count(*) FROM VISITEUR WHERE id = " & idchoix & " AND mdp = '" & mdp.Text & "'"

        myCommand.Connection = myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If myReader.GetValue(0) > 0 Then
                idvisiteur = idchoix
                Me.Hide()
                accueil.Show()
            Else
                Mdp_erreur.Text = "Mot de passe incorrect, veuillez réessayez"
            End If
        End While

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub mdp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mdp.TextChanged
        mdp.PasswordChar = "*"
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
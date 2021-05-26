Public Class select_prat

    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim donnee As DataTable
    Public idpraticien As String

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listepraticien.Text = "Selectionnez un praticien"

        Dim query As String = "SELECT NUM_RPPS, (PRENOM_PRATICIEN || ' ' ||NOM_PRATICIEN) nom_prenom_praticien FROM PRATICIEN"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, saisie_login.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Me.listepraticien.DataSource = donnee
        Me.listepraticien.DisplayMember = "nom_prenom_praticien"
        Me.listepraticien.ValueMember = "NUM_RPPS"

    End Sub


    Private Sub validervisiteur_Click() Handles validervisiteur.Click
        Dim idchoix As String = listepraticien.SelectedValue
        idpraticien = idchoix

        Me.Hide()
        saisie_rapport.Show()

    End Sub

    Private Sub retour_accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retour_accueil.Click
        Me.Hide()
        accueil.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class
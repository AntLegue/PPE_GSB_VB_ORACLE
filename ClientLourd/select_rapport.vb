Public Class select_rapport

    Dim idvisiteur As Integer = accueil.idvisiteur
    Public idrapport As Integer
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
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

    Private Sub selectrapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim query As String = "SELECT id, (to_char(date_visite, 'DD/MM/YY') || '-' ||nom_praticien || ' ' || prenom_praticien) date_praticien FROM rapport, praticien WHERE id_visiteur = " & idvisiteur & " AND praticien.num_rpps = id_praticien ORDER BY id DESC"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, saisie_login.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Me.listerapport.DataSource = donnee
        Me.listerapport.DisplayMember = "date_praticien"
        Me.listerapport.ValueMember = "id"

    End Sub

    Private Sub listerapport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listerapport.Click

        saisie_login.myConnection.Close()
        saisie_login.myConnection.Open()

        idrapport = listerapport.SelectedValue

        consult_rapport.Show()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
        accueil.Show()
    End Sub

    Private Sub saisir_cr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saisir_cr.Click
        Me.Close()
        accueil.Show()
    End Sub

    Private Sub listerapport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listerapport.SelectedIndexChanged
        Me.Hide()
    End Sub
End Class
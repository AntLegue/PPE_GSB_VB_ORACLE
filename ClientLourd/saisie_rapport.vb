Public Class saisie_rapport

    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim donnee As DataTable
    Dim idmedicament As String
    Dim idpraticien As String = select_prat.idpraticien
    Dim idvisiteur As Integer = saisie_login.idvisiteur

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Private Sub Form4_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListMedPrescrit.Text = "Selectionnez un medicament"

        Dim query As String = "SELECT LIBELLE_MEDICAMENT, CODE_MEDICAMENT  FROM MEDICAMENT"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, saisie_login.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Me.ListMedPrescrit.DataSource = donnee
        Me.ListMedPrescrit.DisplayMember = "LIBELLE_MEDICAMENT"
        Me.ListMedPrescrit.ValueMember = "CODE_MEDICAMENT"

    End Sub

    Private Sub ajouterMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouterMedic.Click
        Dim quantite As Integer = QuantiteMed.Value

        ListMedicament.Items.Add(ListMedPrescrit.SelectedValue & " | " & ListMedPrescrit.Text & " | " & quantite)
    End Sub

    Private Sub validerRapport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validerRapport.Click

        Dim query2 As String = "Insert all into rapport (id,rapport_visite,date_visite,id_visiteur,id_praticien) values(SeqRapport.nextval, '" & TextRapport.Text & "',(select TO_DATE(SYSDATE, 'DD/MM/YYYY') from dual),'" & idvisiteur & "','" & idpraticien & "') "


        Dim tableau() As String

        For Each valeur As [Object] In ListMedicament.Items
            tableau = Split(valeur, "|")

            query2 = query2 & " into quantite (id_rapport,CODE_MEDICAMENT,quantite) values (SeqRapport.currval, '" & tableau(0) & "', '" & tableau(2) & "') "

        Next
        query2 = query2 & " select * from dual"
        myCommand.Connection = saisie_login.myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader
        MessageBox.Show("Rapport validé")

        TextRapport.Clear()
        Me.Close()
        accueil.Show()
    End Sub

    Private Sub retour_select_pract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retour_select_pract.Click
        Me.Hide()
        select_prat.Show()

    End Sub

    Private Sub retour_accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retour_accueil.Click
        Me.Hide()
        accueil.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class
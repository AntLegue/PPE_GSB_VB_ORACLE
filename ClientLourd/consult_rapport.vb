Public Class consult_rapport

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

    Private Sub consulterrapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT date_visite, rapport_visite FROM rapport WHERE id = " & select_rapport.idrapport


        myCommand.Connection = saisie_login.myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        Dim daterapport As Date
        Dim contenurapport As String = ""

        While myReader.Read
            daterapport = myReader.GetValue(0)
            contenurapport = myReader.GetValue(1)
        End While
        myReader.Close()

        labelrapport.Text = "Rapport datant du : " & daterapport
        rapport.Text = contenurapport


        Dim query2 As String = " Select libelle_medicament, quantite FROM medicament, quantite WHERE medicament.code_medicament = quantite.code_medicament AND id_rapport = " & select_rapport.idrapport

        myCommand.Connection = saisie_login.myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader

        While myReader.Read

            listemedicaments.Items.Add(myReader.GetValue(0))
            listequantite.Items.Add(myReader.GetValue(1))
        End While
        myReader.Close()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        select_rapport.Show()
    End Sub

    Private Sub saisir_cr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saisir_cr.Click
        Me.Hide()
        accueil.Show()
    End Sub

End Class
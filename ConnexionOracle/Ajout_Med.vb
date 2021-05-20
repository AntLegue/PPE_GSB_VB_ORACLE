Public Class Ajout_Med

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub Ajout_Med_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' connection
        connString = "DSN=ORA12;Uid=GSB_PPE;Pwd=Iroise29;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            'MessageBox.Show("Connexion Oracle OK")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT table_name FROM user_tables"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader


        While myReader.Read
            Scrollbar.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()

    End Sub

    Private Sub Scrollbar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scrollbar.SelectedIndexChanged

        Dim table_name As String = Scrollbar.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM " & table_name
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        AfficheTab.DataSource = donnee

    End Sub


    Private Sub AjoutMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutMed.Click

        ' déclaration des variables
        Dim nom_med As String
        Dim prenom_med As String
        Dim ville_med As String
        Dim adresse_med As String
        Dim cp_med As String
        Dim MyCommand As New Odbc.OdbcCommand

        ' intégration des textbox
        nom_med = Insert_Nom.Text
        prenom_med = Insert_Prenom.Text
        ville_med = Insert_Ville.Text
        adresse_med = Insert_Addr.Text
        cp_med = Insert_CP.Text

        'requete
        MyCommand.CommandText = "INSERT INTO MEDECIN (ID_MED,NOM_MED,PRENOM_MED,ADRESSE_MED,CP_MED,VILLE_MED) VALUES (SEQ_MED.NEXTVAL, '" & nom_med & "' , '" & prenom_med & "' , '" & adresse_med & "' , " & cp_med & " ,  '" & ville_med & "') "

        'envoie de la requête
        MyCommand.Connection = myConnection
        MyCommand.ExecuteNonQuery()

        ' Supprimer la zone de texte 
        Insert_Nom.Clear()
        Insert_Prenom.Clear()
        Insert_Ville.Clear()
        Insert_Addr.Clear()
        Insert_CP.Clear()

    End Sub

    Private Sub RetourAccueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourAccueil.Click

        ' on affiche l'accueil du form accueil
        Accueil_Gen.Show()
        ' on cache le form actuel
        Me.Hide()

    End Sub
End Class
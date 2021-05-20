Public Class Ajout_Vis

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub Ajout_Vis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub AjoutVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutVis.Click

        ' déclaration des variables
        Dim nom_vis As String
        Dim prenom_vis As String
        Dim adresse_vis As String
        Dim cp_vis As String
        Dim ville_vis As String
        Dim Id_reg As String
        Dim MyCommand As New Odbc.OdbcCommand

        ' intégration des textbox
        nom_vis = Insert_Nom.Text
        prenom_vis = Insert_Prenom.Text
        adresse_vis = Insert_Addr.Text
        cp_vis = Insert_CP.Text
        ville_vis = Insert_Ville.Text
        Id_reg = Select_Reg.Text()

        'requete
        MyCommand.CommandText = "INSERT INTO VISITEUR (ID_VIS, ID_REG, NOM_VIS, PRENOM_VIS, ADRESSE_VIS, CP_VIS, VILLE_VIS) VALUES(SEQ_VIS.NEXTVAL, " & Id_reg & " ,'" & nom_vis & "' , '" & prenom_vis & "' , '" & adresse_vis & "' , " & cp_vis & " ,  '" & ville_vis & "') "

        'envoie de la requête
        MyCommand.Connection = myConnection
        MyCommand.ExecuteNonQuery()

        ' Supprimer la zone de texte 
        Insert_Nom.Clear()
        Insert_Prenom.Clear()
        Insert_CP.Clear()
        Insert_Ville.Clear()
        Insert_Addr.Clear()
        Select_Reg.Clear()

    End Sub

    Private Sub RetourAccueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetourAccueil.Click

        ' on affiche l'accueil du form accueil
        Accueil_Gen.Show()
        ' on cache le form actuel
        Me.Hide()

    End Sub
End Class
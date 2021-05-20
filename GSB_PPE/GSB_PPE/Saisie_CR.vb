Public Class Saisie_CR

    Dim MyConn As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    Private Sub Saisie_CR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' connection
        connString = "DSN=ORA12;Uid=GSB_PPE;Pwd=Iroise29;"
        MyConn.ConnectionString = connString

        Try
            MyConn.Open()
            'MessageBox.Show("Connexion Oracle OK")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        ' requête sélection du médecin
        Dim select_med As String = "SELECT ID_MED , (PRENOM_MED || ' ' || NOM_MED) PRENOM_NOM_MED, NOM_MED FROM MEDECIN ORDER BY ID_MED"

        ' requête selection des médicaments
        Dim select_medicament As String = "SELECT LIB_MEDIC FROM MEDICAMENT"

        ' exécution de la requête pour les sélection des médecins
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(select_med, MyConn)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        Me.Scrollbar.DataSource = donnee
        Me.Scrollbar.DisplayMember = "PRENOM_NOM_MED"
        Me.Scrollbar.ValueMember = "ID_MED"


        ' exécution de la requête pour la sélection des médicaments
        myCommand.Connection = MyConn
        myCommand.CommandText = select_medicament
        myReader = myCommand.ExecuteReader
        While myReader.Read
            Select_Medic.Items.Add(myReader.GetString(0))
            Select_Medic2.Items.Add(myReader.GetString(0))
            Select_Medic3.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()


        ' exécution de l'affichage de l'adresse en fonction du nom,prénom 
    End Sub

    

End Class
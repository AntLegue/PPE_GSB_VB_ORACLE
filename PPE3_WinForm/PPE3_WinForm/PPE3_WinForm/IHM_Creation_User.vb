Public Class IHM_Creation_User

    Dim a As Integer = 0

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If Not Login.Text = "" Then
            a += 1

        End If
        If Not Mdp.Text = "" Then
            a += 1

        End If
        If a = 2 Then
            My.Settings.Login = Log.Text
            My.Settings.Password = Mdp.Text
            My.Settings.Save()

        End If
        MsgBox("Register succesful")
        IHM_Connexion.Show()


    End Sub
End Class
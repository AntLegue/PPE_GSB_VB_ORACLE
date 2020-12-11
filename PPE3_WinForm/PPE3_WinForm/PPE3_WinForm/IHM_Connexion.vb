Public Class IHM_Connexion

    'Initialisation de la variable pour le login
    Dim a As Integer = 0
    Dim verif As Integer = 0
    Dim compteur As Integer = 1

    Private Sub Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Connexion.Click

        'Condition Si pour vérifier la connexion
        If verif = 0 Then

            'Vérification du login
            If Login.Text = My.Settings.Login Then
                a += 1
            End If

            'Vérification du Mot de passe
            If Mdp.Text = My.Settings.Password Then
                a += 1
            End If

            'Si le login et le mot de passe sont valide connexion réussie
            If a = 2 Then
                verif = 1
                MessageBox.Show("Authentification réussie", "Login Sucessful")
                IHM_Acceuil.Show()
                Me.Hide()

                'Si le login et le mot de passe ne sont pas valide connexion échouée
                'Incrementation du compteur de 1
            Else
                MessageBox.Show("Authentification échouée, Essai n° " & compteur, "Login Denied")
                compteur = compteur + 1
            End If

            'si le nombre d'erreur depasse 3 le logiciel plante
            If compteur > 3 Then
                MessageBox.Show("Nombre d'essais dépassés", "Erreur de connexion")
                Me.Close()
            End If

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        'affichage du mot de passe si checkbox checked
        If CheckBox1.Checked = True Then
            Mdp.UseSystemPasswordChar = False
        Else
            Mdp.UseSystemPasswordChar = True
        End If

    End Sub

End Class

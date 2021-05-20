
Public Class Accueil_Gen

    ' Section régions
    Private Sub AddRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRegion.Click

        Ajout_Reg.Show()
        Me.Hide()

    End Sub

    ' Section secteurs
    Private Sub AddSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSec.Click

        Ajout_Sec.Show()
        Me.Hide()

    End Sub

    ' Section visiteurs
    Private Sub AddVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddVis.Click

        Ajout_Vis.Show()
        Me.Hide()

    End Sub

    ' Section Medicament
    Private Sub AddMedic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMedic.Click

        Ajout_Medic.Show()
        Me.Hide()

    End Sub

    ' Section Medecin
    Private Sub AddMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMed.Click

        Ajout_Med.Show()
        Me.Hide()

    End Sub

    ' Bouton quitter
    Private Sub Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitter.Click

        ' On quitte l'application
        Me.Close()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class

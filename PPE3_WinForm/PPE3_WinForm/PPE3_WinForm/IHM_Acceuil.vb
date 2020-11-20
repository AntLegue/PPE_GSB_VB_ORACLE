Public Class IHM_Acceuil

    Private Sub IHM_Acceuil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Démarrage du timer
        Timer1.Enabled = True

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Affectation au label DateDirect la date du jour
        DateDirect.Text = Date.Now.ToString("dd MMM yyyy")

    End Sub

 
End Class
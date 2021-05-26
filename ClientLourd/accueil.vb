Public Class accueil

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Public idvisiteur As Integer = saisie_login.idvisiteur

    Private Sub saisie_cr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saisir_cr.Click
        Me.Hide()
        select_prat.Show()
    End Sub

    Private Sub consult_cr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consult_cr.Click
        Me.Hide()
        select_rapport.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        saisie_login.Show()
    End Sub

    Private Sub accueil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
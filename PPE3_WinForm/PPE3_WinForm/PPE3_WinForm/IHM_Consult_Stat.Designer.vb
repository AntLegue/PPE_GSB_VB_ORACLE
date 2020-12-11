<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IHM_Consult_Stat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Retour
        '
        Me.Retour.Location = New System.Drawing.Point(434, 12)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(105, 35)
        Me.Retour.TabIndex = 0
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'IHM_Consult_Stat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 430)
        Me.Controls.Add(Me.Retour)
        Me.Name = "IHM_Consult_Stat"
        Me.Text = "IHM_Consult_Stat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Retour As System.Windows.Forms.Button
End Class

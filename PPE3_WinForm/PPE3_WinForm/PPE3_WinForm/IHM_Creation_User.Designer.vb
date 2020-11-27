<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IHM_Creation_User
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
        Me.Save = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.TextBox()
        Me.Mdp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(110, 186)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 0
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Location = New System.Drawing.Point(53, 59)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(43, 17)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(27, 120)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 17)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(110, 56)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(100, 22)
        Me.Log.TabIndex = 3
        '
        'Mdp
        '
        Me.Mdp.Location = New System.Drawing.Point(110, 117)
        Me.Mdp.Name = "Mdp"
        Me.Mdp.Size = New System.Drawing.Size(100, 22)
        Me.Mdp.TabIndex = 4
        '
        'IHM_Validation_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Mdp)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Save)
        Me.Name = "IHM_Validation_Connexion"
        Me.Text = "IHM_Validation_Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Login As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents Log As System.Windows.Forms.TextBox
    Friend WithEvents Mdp As System.Windows.Forms.TextBox
End Class

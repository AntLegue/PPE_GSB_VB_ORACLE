<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IHM_Connexion
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
        Me.components = New System.ComponentModel.Container()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Mdp = New System.Windows.Forms.TextBox()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.LabelMdp = New System.Windows.Forms.Label()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.LabelConnexion = New System.Windows.Forms.Label()
        Me.DateDirect = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HeureDirect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(179, 146)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 22)
        Me.Login.TabIndex = 0
        '
        'Mdp
        '
        Me.Mdp.Location = New System.Drawing.Point(179, 203)
        Me.Mdp.Name = "Mdp"
        Me.Mdp.Size = New System.Drawing.Size(100, 22)
        Me.Mdp.TabIndex = 1
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Location = New System.Drawing.Point(118, 146)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(51, 17)
        Me.LabelLogin.TabIndex = 2
        Me.LabelLogin.Text = "Login :"
        '
        'LabelMdp
        '
        Me.LabelMdp.AutoSize = True
        Me.LabelMdp.Location = New System.Drawing.Point(67, 206)
        Me.LabelMdp.Name = "LabelMdp"
        Me.LabelMdp.Size = New System.Drawing.Size(102, 17)
        Me.LabelMdp.TabIndex = 3
        Me.LabelMdp.Text = "Mot de Passe :"
        '
        'Connexion
        '
        Me.Connexion.Location = New System.Drawing.Point(179, 268)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(100, 30)
        Me.Connexion.TabIndex = 4
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = True
        '
        'LabelConnexion
        '
        Me.LabelConnexion.AutoSize = True
        Me.LabelConnexion.BackColor = System.Drawing.Color.GreenYellow
        Me.LabelConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnexion.Location = New System.Drawing.Point(135, 86)
        Me.LabelConnexion.Name = "LabelConnexion"
        Me.LabelConnexion.Size = New System.Drawing.Size(180, 20)
        Me.LabelConnexion.TabIndex = 5
        Me.LabelConnexion.Text = "Veuillez vous identifiez"
        '
        'DateDirect
        '
        Me.DateDirect.AutoSize = True
        Me.DateDirect.BackColor = System.Drawing.Color.GreenYellow
        Me.DateDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDirect.Location = New System.Drawing.Point(12, 9)
        Me.DateDirect.Name = "DateDirect"
        Me.DateDirect.Size = New System.Drawing.Size(111, 20)
        Me.DateDirect.TabIndex = 6
        Me.DateDirect.Text = "dd MMM yyyy"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'HeureDirect
        '
        Me.HeureDirect.AutoSize = True
        Me.HeureDirect.BackColor = System.Drawing.Color.GreenYellow
        Me.HeureDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeureDirect.Location = New System.Drawing.Point(314, 9)
        Me.HeureDirect.Name = "HeureDirect"
        Me.HeureDirect.Size = New System.Drawing.Size(103, 20)
        Me.HeureDirect.TabIndex = 7
        Me.HeureDirect.Text = "hh : mm : ss"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 437)
        Me.Controls.Add(Me.HeureDirect)
        Me.Controls.Add(Me.DateDirect)
        Me.Controls.Add(Me.LabelConnexion)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.LabelMdp)
        Me.Controls.Add(Me.LabelLogin)
        Me.Controls.Add(Me.Mdp)
        Me.Controls.Add(Me.Login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents Mdp As System.Windows.Forms.TextBox
    Friend WithEvents LabelLogin As System.Windows.Forms.Label
    Friend WithEvents LabelMdp As System.Windows.Forms.Label
    Friend WithEvents Connexion As System.Windows.Forms.Button
    Friend WithEvents LabelConnexion As System.Windows.Forms.Label
    Friend WithEvents DateDirect As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HeureDirect As System.Windows.Forms.Label

End Class

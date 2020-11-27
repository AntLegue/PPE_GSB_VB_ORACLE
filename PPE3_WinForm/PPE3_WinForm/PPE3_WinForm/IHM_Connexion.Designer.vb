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
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Mdp = New System.Windows.Forms.TextBox()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.LabelMdp = New System.Windows.Forms.Label()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(72, 90)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 22)
        Me.Login.TabIndex = 0
        '
        'Mdp
        '
        Me.Mdp.Location = New System.Drawing.Point(73, 163)
        Me.Mdp.Name = "Mdp"
        Me.Mdp.Size = New System.Drawing.Size(100, 22)
        Me.Mdp.TabIndex = 1
        Me.Mdp.UseSystemPasswordChar = True
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.ForeColor = System.Drawing.Color.White
        Me.LabelLogin.Location = New System.Drawing.Point(98, 70)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(51, 17)
        Me.LabelLogin.TabIndex = 2
        Me.LabelLogin.Text = "Login :"
        '
        'LabelMdp
        '
        Me.LabelMdp.AutoSize = True
        Me.LabelMdp.ForeColor = System.Drawing.Color.White
        Me.LabelMdp.Location = New System.Drawing.Point(69, 143)
        Me.LabelMdp.Name = "LabelMdp"
        Me.LabelMdp.Size = New System.Drawing.Size(102, 17)
        Me.LabelMdp.TabIndex = 3
        Me.LabelMdp.Text = "Mot de Passe :"
        '
        'Connexion
        '
        Me.Connexion.BackColor = System.Drawing.Color.White
        Me.Connexion.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Connexion.Location = New System.Drawing.Point(73, 286)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(100, 30)
        Me.Connexion.TabIndex = 4
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 340)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PPE3.My.Resources.Resources.Logo_gsb
        Me.PictureBox1.Location = New System.Drawing.Point(48, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Login)
        Me.Panel2.Controls.Add(Me.Connexion)
        Me.Panel2.Controls.Add(Me.LabelMdp)
        Me.Panel2.Controls.Add(Me.Mdp)
        Me.Panel2.Controls.Add(Me.LabelLogin)
        Me.Panel2.Location = New System.Drawing.Point(340, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 340)
        Me.Panel2.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(52, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 21)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Voir Mot de passe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'IHM_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 340)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "IHM_Connexion"
        Me.Text = "Authentification"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents Mdp As System.Windows.Forms.TextBox
    Friend WithEvents LabelLogin As System.Windows.Forms.Label
    Friend WithEvents LabelMdp As System.Windows.Forms.Label
    Friend WithEvents Connexion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class

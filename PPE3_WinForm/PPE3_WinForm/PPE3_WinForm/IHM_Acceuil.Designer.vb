<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IHM_Acceuil
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
        Me.DateDirect = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelBienvenue = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.AfficheNom = New System.Windows.Forms.Label()
        Me.AffichePrenom = New System.Windows.Forms.Label()
        Me.AfficheCompteRendu = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Fermeture = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateDirect
        '
        Me.DateDirect.AutoSize = True
        Me.DateDirect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DateDirect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDirect.ForeColor = System.Drawing.Color.White
        Me.DateDirect.Location = New System.Drawing.Point(12, 9)
        Me.DateDirect.Name = "DateDirect"
        Me.DateDirect.Size = New System.Drawing.Size(113, 22)
        Me.DateDirect.TabIndex = 7
        Me.DateDirect.Text = "dd MMM yyyy"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LabelBienvenue
        '
        Me.LabelBienvenue.AutoSize = True
        Me.LabelBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBienvenue.Location = New System.Drawing.Point(267, 51)
        Me.LabelBienvenue.Name = "LabelBienvenue"
        Me.LabelBienvenue.Size = New System.Drawing.Size(160, 32)
        Me.LabelBienvenue.TabIndex = 8
        Me.LabelBienvenue.Text = "Bienvenue"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(269, 140)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 20)
        Me.LabelNom.TabIndex = 9
        Me.LabelNom.Text = "Nom :"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(246, 221)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(77, 20)
        Me.LabelPrenom.TabIndex = 10
        Me.LabelPrenom.Text = "Prenom :"
        '
        'AfficheNom
        '
        Me.AfficheNom.AutoSize = True
        Me.AfficheNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AfficheNom.Location = New System.Drawing.Point(329, 140)
        Me.AfficheNom.Name = "AfficheNom"
        Me.AfficheNom.Size = New System.Drawing.Size(53, 19)
        Me.AfficheNom.TabIndex = 11
        Me.AfficheNom.Text = "Label1"
        '
        'AffichePrenom
        '
        Me.AffichePrenom.AutoSize = True
        Me.AffichePrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AffichePrenom.Location = New System.Drawing.Point(329, 221)
        Me.AffichePrenom.Name = "AffichePrenom"
        Me.AffichePrenom.Size = New System.Drawing.Size(53, 19)
        Me.AffichePrenom.TabIndex = 12
        Me.AffichePrenom.Text = "Label2"
        '
        'AfficheCompteRendu
        '
        Me.AfficheCompteRendu.BackColor = System.Drawing.Color.Orange
        Me.AfficheCompteRendu.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AfficheCompteRendu.FlatAppearance.BorderSize = 19
        Me.AfficheCompteRendu.ForeColor = System.Drawing.Color.White
        Me.AfficheCompteRendu.Location = New System.Drawing.Point(12, 307)
        Me.AfficheCompteRendu.Name = "AfficheCompteRendu"
        Me.AfficheCompteRendu.Size = New System.Drawing.Size(224, 59)
        Me.AfficheCompteRendu.TabIndex = 13
        Me.AfficheCompteRendu.Text = "Saisie du compte-rendu"
        Me.AfficheCompteRendu.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(441, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 59)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Consultation des statistiques"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Fermeture
        '
        Me.Fermeture.BackColor = System.Drawing.Color.OrangeRed
        Me.Fermeture.ForeColor = System.Drawing.Color.White
        Me.Fermeture.Location = New System.Drawing.Point(513, 9)
        Me.Fermeture.Name = "Fermeture"
        Me.Fermeture.Size = New System.Drawing.Size(152, 39)
        Me.Fermeture.TabIndex = 15
        Me.Fermeture.Text = "Fermeture"
        Me.Fermeture.UseVisualStyleBackColor = False
        '
        'IHM_Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(677, 443)
        Me.Controls.Add(Me.Fermeture)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AfficheCompteRendu)
        Me.Controls.Add(Me.AffichePrenom)
        Me.Controls.Add(Me.AfficheNom)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelBienvenue)
        Me.Controls.Add(Me.DateDirect)
        Me.DoubleBuffered = True
        Me.Name = "IHM_Acceuil"
        Me.Text = "IHM_Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateDirect As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelBienvenue As System.Windows.Forms.Label
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents LabelPrenom As System.Windows.Forms.Label
    Friend WithEvents AfficheNom As System.Windows.Forms.Label
    Friend WithEvents AffichePrenom As System.Windows.Forms.Label
    Friend WithEvents AfficheCompteRendu As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Fermeture As System.Windows.Forms.Button
End Class

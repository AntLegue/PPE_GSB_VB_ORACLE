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
        Me.ConsultStat = New System.Windows.Forms.Button()
        Me.Fermeture = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateDirect
        '
        Me.DateDirect.AutoSize = True
        Me.DateDirect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DateDirect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDirect.ForeColor = System.Drawing.Color.White
        Me.DateDirect.Location = New System.Drawing.Point(7, 5)
        Me.DateDirect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateDirect.Name = "DateDirect"
        Me.DateDirect.Size = New System.Drawing.Size(95, 19)
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
        Me.LabelBienvenue.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabelBienvenue.Location = New System.Drawing.Point(75, 51)
        Me.LabelBienvenue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBienvenue.Name = "LabelBienvenue"
        Me.LabelBienvenue.Size = New System.Drawing.Size(124, 26)
        Me.LabelBienvenue.TabIndex = 8
        Me.LabelBienvenue.Text = "Bienvenue"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabelNom.Location = New System.Drawing.Point(32, 113)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 18)
        Me.LabelNom.TabIndex = 9
        Me.LabelNom.Text = "Nom :"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabelPrenom.Location = New System.Drawing.Point(9, 193)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(77, 18)
        Me.LabelPrenom.TabIndex = 10
        Me.LabelPrenom.Text = "Prenom :"
        '
        'AfficheNom
        '
        Me.AfficheNom.AutoSize = True
        Me.AfficheNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AfficheNom.Location = New System.Drawing.Point(90, 113)
        Me.AfficheNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AfficheNom.Name = "AfficheNom"
        Me.AfficheNom.Size = New System.Drawing.Size(41, 15)
        Me.AfficheNom.TabIndex = 11
        Me.AfficheNom.Text = "Label1"
        '
        'AffichePrenom
        '
        Me.AffichePrenom.AutoSize = True
        Me.AffichePrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AffichePrenom.Location = New System.Drawing.Point(90, 197)
        Me.AffichePrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AffichePrenom.Name = "AffichePrenom"
        Me.AffichePrenom.Size = New System.Drawing.Size(41, 15)
        Me.AffichePrenom.TabIndex = 12
        Me.AffichePrenom.Text = "Label2"
        '
        'AfficheCompteRendu
        '
        Me.AfficheCompteRendu.BackColor = System.Drawing.Color.White
        Me.AfficheCompteRendu.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AfficheCompteRendu.FlatAppearance.BorderSize = 19
        Me.AfficheCompteRendu.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.AfficheCompteRendu.Location = New System.Drawing.Point(28, 100)
        Me.AfficheCompteRendu.Margin = New System.Windows.Forms.Padding(2)
        Me.AfficheCompteRendu.Name = "AfficheCompteRendu"
        Me.AfficheCompteRendu.Size = New System.Drawing.Size(168, 48)
        Me.AfficheCompteRendu.TabIndex = 13
        Me.AfficheCompteRendu.Text = "Saisie du compte-rendu"
        Me.AfficheCompteRendu.UseVisualStyleBackColor = False
        '
        'ConsultStat
        '
        Me.ConsultStat.BackColor = System.Drawing.Color.White
        Me.ConsultStat.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.ConsultStat.Location = New System.Drawing.Point(28, 180)
        Me.ConsultStat.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsultStat.Name = "ConsultStat"
        Me.ConsultStat.Size = New System.Drawing.Size(168, 48)
        Me.ConsultStat.TabIndex = 14
        Me.ConsultStat.Text = "Consultation des statistiques"
        Me.ConsultStat.UseVisualStyleBackColor = False
        '
        'Fermeture
        '
        Me.Fermeture.BackColor = System.Drawing.Color.OrangeRed
        Me.Fermeture.ForeColor = System.Drawing.Color.White
        Me.Fermeture.Location = New System.Drawing.Point(149, 2)
        Me.Fermeture.Margin = New System.Windows.Forms.Padding(2)
        Me.Fermeture.Name = "Fermeture"
        Me.Fermeture.Size = New System.Drawing.Size(57, 27)
        Me.Fermeture.TabIndex = 15
        Me.Fermeture.Text = "x"
        Me.Fermeture.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.AffichePrenom)
        Me.Panel1.Controls.Add(Me.AfficheNom)
        Me.Panel1.Controls.Add(Me.LabelPrenom)
        Me.Panel1.Controls.Add(Me.LabelNom)
        Me.Panel1.Controls.Add(Me.LabelBienvenue)
        Me.Panel1.Controls.Add(Me.DateDirect)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 252)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.ConsultStat)
        Me.Panel2.Controls.Add(Me.AfficheCompteRendu)
        Me.Panel2.Controls.Add(Me.Fermeture)
        Me.Panel2.Location = New System.Drawing.Point(285, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 252)
        Me.Panel2.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PPE3.My.Resources.Resources.Logo_gsb_blanc
        Me.PictureBox1.Location = New System.Drawing.Point(59, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'IHM_Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(492, 251)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "IHM_Acceuil"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateDirect As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelBienvenue As System.Windows.Forms.Label
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents LabelPrenom As System.Windows.Forms.Label
    Friend WithEvents AfficheNom As System.Windows.Forms.Label
    Friend WithEvents AffichePrenom As System.Windows.Forms.Label
    Friend WithEvents AfficheCompteRendu As System.Windows.Forms.Button
    Friend WithEvents ConsultStat As System.Windows.Forms.Button
    Friend WithEvents Fermeture As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

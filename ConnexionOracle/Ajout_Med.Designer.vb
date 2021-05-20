<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Med
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Scrollbar = New System.Windows.Forms.ComboBox()
        Me.AfficheTab = New System.Windows.Forms.DataGridView()
        Me.RetourAccueil = New System.Windows.Forms.Button()
        Me.AjoutMed = New System.Windows.Forms.Button()
        Me.Insert_Nom = New System.Windows.Forms.TextBox()
        Me.Nom_Med = New System.Windows.Forms.Label()
        Me.Prenom_Med = New System.Windows.Forms.Label()
        Me.Insert_Prenom = New System.Windows.Forms.TextBox()
        Me.Adresse_Med = New System.Windows.Forms.Label()
        Me.Insert_Addr = New System.Windows.Forms.TextBox()
        Me.Ville_Med = New System.Windows.Forms.Label()
        Me.Insert_Ville = New System.Windows.Forms.TextBox()
        Me.Insert_CP = New System.Windows.Forms.TextBox()
        Me.CP_Med = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.Logo_gsb
        Me.PictureBox1.Location = New System.Drawing.Point(432, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Scrollbar
        '
        Me.Scrollbar.FormattingEnabled = True
        Me.Scrollbar.Location = New System.Drawing.Point(101, 12)
        Me.Scrollbar.Name = "Scrollbar"
        Me.Scrollbar.Size = New System.Drawing.Size(321, 21)
        Me.Scrollbar.TabIndex = 20
        '
        'AfficheTab
        '
        Me.AfficheTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfficheTab.Location = New System.Drawing.Point(101, 60)
        Me.AfficheTab.Name = "AfficheTab"
        Me.AfficheTab.Size = New System.Drawing.Size(321, 250)
        Me.AfficheTab.TabIndex = 21
        '
        'RetourAccueil
        '
        Me.RetourAccueil.BackColor = System.Drawing.Color.Red
        Me.RetourAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RetourAccueil.Location = New System.Drawing.Point(359, 454)
        Me.RetourAccueil.Name = "RetourAccueil"
        Me.RetourAccueil.Size = New System.Drawing.Size(193, 35)
        Me.RetourAccueil.TabIndex = 22
        Me.RetourAccueil.Text = "Retourner à l'accueil"
        Me.RetourAccueil.UseVisualStyleBackColor = False
        '
        'AjoutMed
        '
        Me.AjoutMed.Location = New System.Drawing.Point(12, 454)
        Me.AjoutMed.Name = "AjoutMed"
        Me.AjoutMed.Size = New System.Drawing.Size(75, 23)
        Me.AjoutMed.TabIndex = 23
        Me.AjoutMed.Text = "Ajouter"
        Me.AjoutMed.UseVisualStyleBackColor = True
        '
        'Insert_Nom
        '
        Me.Insert_Nom.Location = New System.Drawing.Point(69, 420)
        Me.Insert_Nom.Name = "Insert_Nom"
        Me.Insert_Nom.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Nom.TabIndex = 24
        '
        'Nom_Med
        '
        Me.Nom_Med.AutoSize = True
        Me.Nom_Med.Location = New System.Drawing.Point(25, 423)
        Me.Nom_Med.Name = "Nom_Med"
        Me.Nom_Med.Size = New System.Drawing.Size(38, 13)
        Me.Nom_Med.TabIndex = 25
        Me.Nom_Med.Text = "Nom : "
        '
        'Prenom_Med
        '
        Me.Prenom_Med.AutoSize = True
        Me.Prenom_Med.Location = New System.Drawing.Point(12, 397)
        Me.Prenom_Med.Name = "Prenom_Med"
        Me.Prenom_Med.Size = New System.Drawing.Size(49, 13)
        Me.Prenom_Med.TabIndex = 26
        Me.Prenom_Med.Text = "Prénom :"
        '
        'Insert_Prenom
        '
        Me.Insert_Prenom.Location = New System.Drawing.Point(69, 394)
        Me.Insert_Prenom.Name = "Insert_Prenom"
        Me.Insert_Prenom.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Prenom.TabIndex = 27
        '
        'Adresse_Med
        '
        Me.Adresse_Med.AutoSize = True
        Me.Adresse_Med.Location = New System.Drawing.Point(184, 423)
        Me.Adresse_Med.Name = "Adresse_Med"
        Me.Adresse_Med.Size = New System.Drawing.Size(51, 13)
        Me.Adresse_Med.TabIndex = 28
        Me.Adresse_Med.Text = "Adresse :"
        '
        'Insert_Addr
        '
        Me.Insert_Addr.Location = New System.Drawing.Point(241, 420)
        Me.Insert_Addr.Name = "Insert_Addr"
        Me.Insert_Addr.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Addr.TabIndex = 29
        '
        'Ville_Med
        '
        Me.Ville_Med.AutoSize = True
        Me.Ville_Med.Location = New System.Drawing.Point(194, 397)
        Me.Ville_Med.Name = "Ville_Med"
        Me.Ville_Med.Size = New System.Drawing.Size(32, 13)
        Me.Ville_Med.TabIndex = 30
        Me.Ville_Med.Text = "Ville :"
        '
        'Insert_Ville
        '
        Me.Insert_Ville.Location = New System.Drawing.Point(241, 394)
        Me.Insert_Ville.Name = "Insert_Ville"
        Me.Insert_Ville.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Ville.TabIndex = 31
        '
        'Insert_CP
        '
        Me.Insert_CP.Location = New System.Drawing.Point(380, 408)
        Me.Insert_CP.Name = "Insert_CP"
        Me.Insert_CP.Size = New System.Drawing.Size(100, 20)
        Me.Insert_CP.TabIndex = 32
        '
        'CP_Med
        '
        Me.CP_Med.AutoSize = True
        Me.CP_Med.Location = New System.Drawing.Point(347, 411)
        Me.CP_Med.Name = "CP_Med"
        Me.CP_Med.Size = New System.Drawing.Size(27, 13)
        Me.CP_Med.TabIndex = 33
        Me.CP_Med.Text = "CP :"
        '
        'Ajout_Med
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 501)
        Me.Controls.Add(Me.CP_Med)
        Me.Controls.Add(Me.Insert_CP)
        Me.Controls.Add(Me.Insert_Ville)
        Me.Controls.Add(Me.Ville_Med)
        Me.Controls.Add(Me.Insert_Addr)
        Me.Controls.Add(Me.Adresse_Med)
        Me.Controls.Add(Me.Insert_Prenom)
        Me.Controls.Add(Me.Prenom_Med)
        Me.Controls.Add(Me.Nom_Med)
        Me.Controls.Add(Me.Insert_Nom)
        Me.Controls.Add(Me.AjoutMed)
        Me.Controls.Add(Me.RetourAccueil)
        Me.Controls.Add(Me.AfficheTab)
        Me.Controls.Add(Me.Scrollbar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Ajout_Med"
        Me.Text = "Ajout_Med"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents AfficheTab As System.Windows.Forms.DataGridView
    Friend WithEvents RetourAccueil As System.Windows.Forms.Button
    Friend WithEvents AjoutMed As System.Windows.Forms.Button
    Friend WithEvents Insert_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Nom_Med As System.Windows.Forms.Label
    Friend WithEvents Prenom_Med As System.Windows.Forms.Label
    Friend WithEvents Insert_Prenom As System.Windows.Forms.TextBox
    Friend WithEvents Adresse_Med As System.Windows.Forms.Label
    Friend WithEvents Insert_Addr As System.Windows.Forms.TextBox
    Friend WithEvents Ville_Med As System.Windows.Forms.Label
    Friend WithEvents Insert_Ville As System.Windows.Forms.TextBox
    Friend WithEvents Insert_CP As System.Windows.Forms.TextBox
    Friend WithEvents CP_Med As System.Windows.Forms.Label
End Class

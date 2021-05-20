<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Vis
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
        Me.AfficheTab = New System.Windows.Forms.DataGridView()
        Me.Scrollbar = New System.Windows.Forms.ComboBox()
        Me.RetourAccueil = New System.Windows.Forms.Button()
        Me.AjoutVis = New System.Windows.Forms.Button()
        Me.Nom_Vis = New System.Windows.Forms.Label()
        Me.Insert_Nom = New System.Windows.Forms.TextBox()
        Me.Prenom_Vis = New System.Windows.Forms.Label()
        Me.Adresse_Vis = New System.Windows.Forms.Label()
        Me.CP_Vis = New System.Windows.Forms.Label()
        Me.Ville_Vis = New System.Windows.Forms.Label()
        Me.Insert_Prenom = New System.Windows.Forms.TextBox()
        Me.Insert_CP = New System.Windows.Forms.TextBox()
        Me.Insert_Ville = New System.Windows.Forms.TextBox()
        Me.Insert_Addr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Select_Reg = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AfficheTab
        '
        Me.AfficheTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfficheTab.Location = New System.Drawing.Point(101, 60)
        Me.AfficheTab.Name = "AfficheTab"
        Me.AfficheTab.Size = New System.Drawing.Size(321, 250)
        Me.AfficheTab.TabIndex = 2
        '
        'Scrollbar
        '
        Me.Scrollbar.FormattingEnabled = True
        Me.Scrollbar.Location = New System.Drawing.Point(101, 12)
        Me.Scrollbar.Name = "Scrollbar"
        Me.Scrollbar.Size = New System.Drawing.Size(321, 21)
        Me.Scrollbar.TabIndex = 3
        '
        'RetourAccueil
        '
        Me.RetourAccueil.BackColor = System.Drawing.Color.Red
        Me.RetourAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RetourAccueil.Location = New System.Drawing.Point(359, 454)
        Me.RetourAccueil.Name = "RetourAccueil"
        Me.RetourAccueil.Size = New System.Drawing.Size(193, 35)
        Me.RetourAccueil.TabIndex = 4
        Me.RetourAccueil.Text = "Retourner à l'accueil"
        Me.RetourAccueil.UseVisualStyleBackColor = False
        '
        'AjoutVis
        '
        Me.AjoutVis.Location = New System.Drawing.Point(12, 454)
        Me.AjoutVis.Name = "AjoutVis"
        Me.AjoutVis.Size = New System.Drawing.Size(75, 23)
        Me.AjoutVis.TabIndex = 5
        Me.AjoutVis.Text = "Ajouter"
        Me.AjoutVis.UseVisualStyleBackColor = True
        '
        'Nom_Vis
        '
        Me.Nom_Vis.AutoSize = True
        Me.Nom_Vis.Location = New System.Drawing.Point(49, 423)
        Me.Nom_Vis.Name = "Nom_Vis"
        Me.Nom_Vis.Size = New System.Drawing.Size(38, 13)
        Me.Nom_Vis.TabIndex = 6
        Me.Nom_Vis.Text = "Nom : "
        '
        'Insert_Nom
        '
        Me.Insert_Nom.Location = New System.Drawing.Point(135, 420)
        Me.Insert_Nom.Name = "Insert_Nom"
        Me.Insert_Nom.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Nom.TabIndex = 7
        '
        'Prenom_Vis
        '
        Me.Prenom_Vis.AutoSize = True
        Me.Prenom_Vis.Location = New System.Drawing.Point(38, 393)
        Me.Prenom_Vis.Name = "Prenom_Vis"
        Me.Prenom_Vis.Size = New System.Drawing.Size(49, 13)
        Me.Prenom_Vis.TabIndex = 8
        Me.Prenom_Vis.Text = "Prénom :"
        '
        'Adresse_Vis
        '
        Me.Adresse_Vis.AutoSize = True
        Me.Adresse_Vis.Location = New System.Drawing.Point(251, 363)
        Me.Adresse_Vis.Name = "Adresse_Vis"
        Me.Adresse_Vis.Size = New System.Drawing.Size(51, 13)
        Me.Adresse_Vis.TabIndex = 9
        Me.Adresse_Vis.Text = "Adresse :"
        '
        'CP_Vis
        '
        Me.CP_Vis.AutoSize = True
        Me.CP_Vis.Location = New System.Drawing.Point(261, 427)
        Me.CP_Vis.Name = "CP_Vis"
        Me.CP_Vis.Size = New System.Drawing.Size(27, 13)
        Me.CP_Vis.TabIndex = 10
        Me.CP_Vis.Text = "CP :"
        '
        'Ville_Vis
        '
        Me.Ville_Vis.AutoSize = True
        Me.Ville_Vis.Location = New System.Drawing.Point(261, 393)
        Me.Ville_Vis.Name = "Ville_Vis"
        Me.Ville_Vis.Size = New System.Drawing.Size(32, 13)
        Me.Ville_Vis.TabIndex = 11
        Me.Ville_Vis.Text = "Ville :"
        '
        'Insert_Prenom
        '
        Me.Insert_Prenom.Location = New System.Drawing.Point(135, 390)
        Me.Insert_Prenom.Name = "Insert_Prenom"
        Me.Insert_Prenom.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Prenom.TabIndex = 12
        '
        'Insert_CP
        '
        Me.Insert_CP.Location = New System.Drawing.Point(312, 420)
        Me.Insert_CP.Name = "Insert_CP"
        Me.Insert_CP.Size = New System.Drawing.Size(100, 20)
        Me.Insert_CP.TabIndex = 13
        '
        'Insert_Ville
        '
        Me.Insert_Ville.Location = New System.Drawing.Point(312, 390)
        Me.Insert_Ville.Name = "Insert_Ville"
        Me.Insert_Ville.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Ville.TabIndex = 14
        '
        'Insert_Addr
        '
        Me.Insert_Addr.Location = New System.Drawing.Point(312, 360)
        Me.Insert_Addr.Name = "Insert_Addr"
        Me.Insert_Addr.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Addr.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Identifiant de la région : "
        '
        'Select_Reg
        '
        Me.Select_Reg.Location = New System.Drawing.Point(135, 360)
        Me.Select_Reg.Name = "Select_Reg"
        Me.Select_Reg.Size = New System.Drawing.Size(100, 20)
        Me.Select_Reg.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.Logo_gsb
        Me.PictureBox1.Location = New System.Drawing.Point(432, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Ajout_Vis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 501)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Select_Reg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Insert_Addr)
        Me.Controls.Add(Me.Insert_Ville)
        Me.Controls.Add(Me.Insert_CP)
        Me.Controls.Add(Me.Insert_Prenom)
        Me.Controls.Add(Me.Ville_Vis)
        Me.Controls.Add(Me.CP_Vis)
        Me.Controls.Add(Me.Adresse_Vis)
        Me.Controls.Add(Me.Prenom_Vis)
        Me.Controls.Add(Me.Insert_Nom)
        Me.Controls.Add(Me.Nom_Vis)
        Me.Controls.Add(Me.AjoutVis)
        Me.Controls.Add(Me.RetourAccueil)
        Me.Controls.Add(Me.Scrollbar)
        Me.Controls.Add(Me.AfficheTab)
        Me.Name = "Ajout_Vis"
        Me.Text = "Ajout_Vis"
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AfficheTab As System.Windows.Forms.DataGridView
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents RetourAccueil As System.Windows.Forms.Button
    Friend WithEvents AjoutVis As System.Windows.Forms.Button
    Friend WithEvents Nom_Vis As System.Windows.Forms.Label
    Friend WithEvents Insert_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Prenom_Vis As System.Windows.Forms.Label
    Friend WithEvents Adresse_Vis As System.Windows.Forms.Label
    Friend WithEvents CP_Vis As System.Windows.Forms.Label
    Friend WithEvents Ville_Vis As System.Windows.Forms.Label
    Friend WithEvents Insert_Prenom As System.Windows.Forms.TextBox
    Friend WithEvents Insert_CP As System.Windows.Forms.TextBox
    Friend WithEvents Insert_Ville As System.Windows.Forms.TextBox
    Friend WithEvents Insert_Addr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Select_Reg As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

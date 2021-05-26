<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saisie_rapport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(saisie_rapport))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.validerRapport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuantiteMed = New System.Windows.Forms.NumericUpDown()
        Me.TextRapport = New System.Windows.Forms.TextBox()
        Me.ListMedPrescrit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ajouterMedic = New System.Windows.Forms.Button()
        Me.ListMedicament = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.retour_select_pract = New System.Windows.Forms.Button()
        Me.retour_accueil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.QuantiteMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(231, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'validerRapport
        '
        Me.validerRapport.Location = New System.Drawing.Point(1134, 16)
        Me.validerRapport.Name = "validerRapport"
        Me.validerRapport.Size = New System.Drawing.Size(164, 37)
        Me.validerRapport.TabIndex = 2
        Me.validerRapport.Text = "Valider"
        Me.validerRapport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Veuillez saisir votre rapport : "
        '
        'QuantiteMed
        '
        Me.QuantiteMed.Location = New System.Drawing.Point(26, 169)
        Me.QuantiteMed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.QuantiteMed.Name = "QuantiteMed"
        Me.QuantiteMed.Size = New System.Drawing.Size(165, 26)
        Me.QuantiteMed.TabIndex = 5
        '
        'TextRapport
        '
        Me.TextRapport.Location = New System.Drawing.Point(173, 111)
        Me.TextRapport.Multiline = True
        Me.TextRapport.Name = "TextRapport"
        Me.TextRapport.Size = New System.Drawing.Size(479, 308)
        Me.TextRapport.TabIndex = 6
        '
        'ListMedPrescrit
        '
        Me.ListMedPrescrit.FormattingEnabled = True
        Me.ListMedPrescrit.Location = New System.Drawing.Point(22, 89)
        Me.ListMedPrescrit.Name = "ListMedPrescrit"
        Me.ListMedPrescrit.Size = New System.Drawing.Size(169, 28)
        Me.ListMedPrescrit.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Liste des médicaments prescrits : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantitée"
        '
        'ajouterMedic
        '
        Me.ajouterMedic.Location = New System.Drawing.Point(61, 223)
        Me.ajouterMedic.Name = "ajouterMedic"
        Me.ajouterMedic.Size = New System.Drawing.Size(130, 34)
        Me.ajouterMedic.TabIndex = 10
        Me.ajouterMedic.Text = "Ajouter"
        Me.ajouterMedic.UseVisualStyleBackColor = True
        '
        'ListMedicament
        '
        Me.ListMedicament.FormattingEnabled = True
        Me.ListMedicament.ItemHeight = 20
        Me.ListMedicament.Location = New System.Drawing.Point(265, 89)
        Me.ListMedicament.Name = "ListMedicament"
        Me.ListMedicament.Size = New System.Drawing.Size(343, 404)
        Me.ListMedicament.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Liste des médicaments"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.retour_select_pract)
        Me.Panel1.Controls.Add(Me.retour_accueil)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 503)
        Me.Panel1.TabIndex = 13
        '
        'retour_select_pract
        '
        Me.retour_select_pract.FlatAppearance.BorderSize = 0
        Me.retour_select_pract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retour_select_pract.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retour_select_pract.ForeColor = System.Drawing.Color.White
        Me.retour_select_pract.Image = Global.Client_Lourd.My.Resources.Resources.retour3
        Me.retour_select_pract.Location = New System.Drawing.Point(3, 179)
        Me.retour_select_pract.Name = "retour_select_pract"
        Me.retour_select_pract.Size = New System.Drawing.Size(138, 122)
        Me.retour_select_pract.TabIndex = 15
        Me.retour_select_pract.Text = "Retour à sélection d'un practicien"
        Me.retour_select_pract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.retour_select_pract.UseVisualStyleBackColor = True
        '
        'retour_accueil
        '
        Me.retour_accueil.FlatAppearance.BorderSize = 0
        Me.retour_accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retour_accueil.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retour_accueil.ForeColor = System.Drawing.Color.White
        Me.retour_accueil.Image = Global.Client_Lourd.My.Resources.Resources.Accueil
        Me.retour_accueil.Location = New System.Drawing.Point(0, 111)
        Me.retour_accueil.Name = "retour_accueil"
        Me.retour_accueil.Size = New System.Drawing.Size(144, 62)
        Me.retour_accueil.TabIndex = 14
        Me.retour_accueil.Text = "Accueil"
        Me.retour_accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.retour_accueil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client_Lourd.My.Resources.Resources.gsb
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListMedicament)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ajouterMedic)
        Me.Panel2.Controls.Add(Me.ListMedPrescrit)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.QuantiteMed)
        Me.Panel2.Location = New System.Drawing.Point(690, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(618, 503)
        Me.Panel2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(597, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "X"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 27)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ajout des médicaments : "
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.validerRapport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 503)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1310, 65)
        Me.Panel3.TabIndex = 15
        '
        'saisie_rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1310, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextRapport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "saisie_rapport"
        Me.Text = "Saisir un compte-rendu de visite"
        CType(Me.QuantiteMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents validerRapport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuantiteMed As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextRapport As System.Windows.Forms.TextBox
    Friend WithEvents ListMedPrescrit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ajouterMedic As System.Windows.Forms.Button
    Friend WithEvents ListMedicament As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents retour_accueil As System.Windows.Forms.Button
    Friend WithEvents retour_select_pract As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

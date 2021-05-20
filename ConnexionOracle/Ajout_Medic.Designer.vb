<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Medic
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
        Me.AjoutMedic = New System.Windows.Forms.Button()
        Me.RetourAccueil = New System.Windows.Forms.Button()
        Me.Lib_Medic = New System.Windows.Forms.Label()
        Me.Insert_Nom_Medic = New System.Windows.Forms.TextBox()
        Me.Insert_Type_Medic = New System.Windows.Forms.TextBox()
        Me.Type_Medic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Insert_Mode_Admin_Medic = New System.Windows.Forms.TextBox()
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
        Me.Scrollbar.TabIndex = 21
        '
        'AfficheTab
        '
        Me.AfficheTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfficheTab.Location = New System.Drawing.Point(101, 60)
        Me.AfficheTab.Name = "AfficheTab"
        Me.AfficheTab.Size = New System.Drawing.Size(321, 250)
        Me.AfficheTab.TabIndex = 22
        '
        'AjoutMedic
        '
        Me.AjoutMedic.Location = New System.Drawing.Point(12, 454)
        Me.AjoutMedic.Name = "AjoutMedic"
        Me.AjoutMedic.Size = New System.Drawing.Size(75, 23)
        Me.AjoutMedic.TabIndex = 23
        Me.AjoutMedic.Text = "Ajouter"
        Me.AjoutMedic.UseVisualStyleBackColor = True
        '
        'RetourAccueil
        '
        Me.RetourAccueil.BackColor = System.Drawing.Color.Red
        Me.RetourAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RetourAccueil.Location = New System.Drawing.Point(359, 454)
        Me.RetourAccueil.Name = "RetourAccueil"
        Me.RetourAccueil.Size = New System.Drawing.Size(193, 35)
        Me.RetourAccueil.TabIndex = 24
        Me.RetourAccueil.Text = "Retourner à l'accueil"
        Me.RetourAccueil.UseVisualStyleBackColor = False
        '
        'Lib_Medic
        '
        Me.Lib_Medic.AutoSize = True
        Me.Lib_Medic.Location = New System.Drawing.Point(12, 423)
        Me.Lib_Medic.Name = "Lib_Medic"
        Me.Lib_Medic.Size = New System.Drawing.Size(113, 13)
        Me.Lib_Medic.TabIndex = 26
        Me.Lib_Medic.Text = "Nom du médicament : "
        '
        'Insert_Nom_Medic
        '
        Me.Insert_Nom_Medic.Location = New System.Drawing.Point(131, 420)
        Me.Insert_Nom_Medic.Name = "Insert_Nom_Medic"
        Me.Insert_Nom_Medic.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Nom_Medic.TabIndex = 27
        '
        'Insert_Type_Medic
        '
        Me.Insert_Type_Medic.Location = New System.Drawing.Point(358, 420)
        Me.Insert_Type_Medic.Name = "Insert_Type_Medic"
        Me.Insert_Type_Medic.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Type_Medic.TabIndex = 28
        '
        'Type_Medic
        '
        Me.Type_Medic.AutoSize = True
        Me.Type_Medic.Location = New System.Drawing.Point(237, 423)
        Me.Type_Medic.Name = "Type_Medic"
        Me.Type_Medic.Size = New System.Drawing.Size(115, 13)
        Me.Type_Medic.TabIndex = 29
        Me.Type_Medic.Text = "Type de médicament : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Mode d'administration du médicament : "
        '
        'Insert_Mode_Admin_Medic
        '
        Me.Insert_Mode_Admin_Medic.Location = New System.Drawing.Point(286, 385)
        Me.Insert_Mode_Admin_Medic.Name = "Insert_Mode_Admin_Medic"
        Me.Insert_Mode_Admin_Medic.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Mode_Admin_Medic.TabIndex = 31
        '
        'Ajout_Medic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 501)
        Me.Controls.Add(Me.Insert_Mode_Admin_Medic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Type_Medic)
        Me.Controls.Add(Me.Insert_Type_Medic)
        Me.Controls.Add(Me.Insert_Nom_Medic)
        Me.Controls.Add(Me.Lib_Medic)
        Me.Controls.Add(Me.RetourAccueil)
        Me.Controls.Add(Me.AjoutMedic)
        Me.Controls.Add(Me.AfficheTab)
        Me.Controls.Add(Me.Scrollbar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Ajout_Medic"
        Me.Text = "Ajout_Medicament"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents AfficheTab As System.Windows.Forms.DataGridView
    Friend WithEvents AjoutMedic As System.Windows.Forms.Button
    Friend WithEvents RetourAccueil As System.Windows.Forms.Button
    Friend WithEvents Lib_Medic As System.Windows.Forms.Label
    Friend WithEvents Insert_Nom_Medic As System.Windows.Forms.TextBox
    Friend WithEvents Insert_Type_Medic As System.Windows.Forms.TextBox
    Friend WithEvents Type_Medic As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Insert_Mode_Admin_Medic As System.Windows.Forms.TextBox
End Class

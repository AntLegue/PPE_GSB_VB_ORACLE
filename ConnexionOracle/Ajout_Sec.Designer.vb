<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Sec
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
        Me.LibReg = New System.Windows.Forms.Label()
        Me.Insert_Sec = New System.Windows.Forms.TextBox()
        Me.AjoutReg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Select_Sec = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AfficheTab
        '
        Me.AfficheTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfficheTab.Location = New System.Drawing.Point(100, 56)
        Me.AfficheTab.Name = "AfficheTab"
        Me.AfficheTab.Size = New System.Drawing.Size(321, 250)
        Me.AfficheTab.TabIndex = 2
        '
        'Scrollbar
        '
        Me.Scrollbar.FormattingEnabled = True
        Me.Scrollbar.Location = New System.Drawing.Point(100, 12)
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
        'LibReg
        '
        Me.LibReg.AutoSize = True
        Me.LibReg.Location = New System.Drawing.Point(12, 395)
        Me.LibReg.Name = "LibReg"
        Me.LibReg.Size = New System.Drawing.Size(91, 13)
        Me.LibReg.TabIndex = 6
        Me.LibReg.Text = "Nom du secteur : "
        '
        'Insert_Sec
        '
        Me.Insert_Sec.Location = New System.Drawing.Point(100, 392)
        Me.Insert_Sec.Name = "Insert_Sec"
        Me.Insert_Sec.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Sec.TabIndex = 7
        '
        'AjoutReg
        '
        Me.AjoutReg.Location = New System.Drawing.Point(15, 443)
        Me.AjoutReg.Name = "AjoutReg"
        Me.AjoutReg.Size = New System.Drawing.Size(75, 23)
        Me.AjoutReg.TabIndex = 8
        Me.AjoutReg.Text = "Ajouter"
        Me.AjoutReg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Identifiant de la région : "
        '
        'Select_Sec
        '
        Me.Select_Sec.Location = New System.Drawing.Point(321, 392)
        Me.Select_Sec.Name = "Select_Sec"
        Me.Select_Sec.Size = New System.Drawing.Size(100, 20)
        Me.Select_Sec.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.Logo_gsb
        Me.PictureBox1.Location = New System.Drawing.Point(432, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Ajout_Sec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 501)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Select_Sec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AjoutReg)
        Me.Controls.Add(Me.Insert_Sec)
        Me.Controls.Add(Me.LibReg)
        Me.Controls.Add(Me.RetourAccueil)
        Me.Controls.Add(Me.Scrollbar)
        Me.Controls.Add(Me.AfficheTab)
        Me.Name = "Ajout_Sec"
        Me.Text = "Ajout du secteur"
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AfficheTab As System.Windows.Forms.DataGridView
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents RetourAccueil As System.Windows.Forms.Button
    Friend WithEvents LibReg As System.Windows.Forms.Label
    Friend WithEvents Insert_Sec As System.Windows.Forms.TextBox
    Friend WithEvents AjoutReg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Select_Sec As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

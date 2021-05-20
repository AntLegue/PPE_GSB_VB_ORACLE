<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Reg
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
        Me.Scrollbar = New System.Windows.Forms.ComboBox()
        Me.AfficheTab = New System.Windows.Forms.DataGridView()
        Me.AjoutReg = New System.Windows.Forms.Button()
        Me.RetourAccueil = New System.Windows.Forms.Button()
        Me.Insert_Reg = New System.Windows.Forms.TextBox()
        Me.LibReg = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Scrollbar
        '
        Me.Scrollbar.FormattingEnabled = True
        Me.Scrollbar.Location = New System.Drawing.Point(101, 12)
        Me.Scrollbar.Name = "Scrollbar"
        Me.Scrollbar.Size = New System.Drawing.Size(321, 21)
        Me.Scrollbar.TabIndex = 0
        '
        'AfficheTab
        '
        Me.AfficheTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfficheTab.Location = New System.Drawing.Point(101, 60)
        Me.AfficheTab.Name = "AfficheTab"
        Me.AfficheTab.Size = New System.Drawing.Size(321, 250)
        Me.AfficheTab.TabIndex = 1
        '
        'AjoutReg
        '
        Me.AjoutReg.Location = New System.Drawing.Point(15, 433)
        Me.AjoutReg.Name = "AjoutReg"
        Me.AjoutReg.Size = New System.Drawing.Size(75, 23)
        Me.AjoutReg.TabIndex = 2
        Me.AjoutReg.Text = "Ajouter"
        Me.AjoutReg.UseVisualStyleBackColor = True
        '
        'RetourAccueil
        '
        Me.RetourAccueil.BackColor = System.Drawing.Color.Red
        Me.RetourAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RetourAccueil.Location = New System.Drawing.Point(359, 454)
        Me.RetourAccueil.Name = "RetourAccueil"
        Me.RetourAccueil.Size = New System.Drawing.Size(193, 35)
        Me.RetourAccueil.TabIndex = 3
        Me.RetourAccueil.Text = "Retourner à l'accueil"
        Me.RetourAccueil.UseVisualStyleBackColor = False
        '
        'Insert_Reg
        '
        Me.Insert_Reg.Location = New System.Drawing.Point(114, 369)
        Me.Insert_Reg.Name = "Insert_Reg"
        Me.Insert_Reg.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Reg.TabIndex = 4
        '
        'LibReg
        '
        Me.LibReg.AutoSize = True
        Me.LibReg.Location = New System.Drawing.Point(12, 372)
        Me.LibReg.Name = "LibReg"
        Me.LibReg.Size = New System.Drawing.Size(96, 13)
        Me.LibReg.TabIndex = 5
        Me.LibReg.Text = "Nom de la région : "
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
        'Ajout_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 501)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LibReg)
        Me.Controls.Add(Me.Insert_Reg)
        Me.Controls.Add(Me.RetourAccueil)
        Me.Controls.Add(Me.AjoutReg)
        Me.Controls.Add(Me.AfficheTab)
        Me.Controls.Add(Me.Scrollbar)
        Me.Name = "Ajout_Reg"
        Me.Text = "Ajout de la région"
        CType(Me.AfficheTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents AfficheTab As System.Windows.Forms.DataGridView
    Friend WithEvents AjoutReg As System.Windows.Forms.Button
    Friend WithEvents RetourAccueil As System.Windows.Forms.Button
    Friend WithEvents Insert_Reg As System.Windows.Forms.TextBox
    Friend WithEvents LibReg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

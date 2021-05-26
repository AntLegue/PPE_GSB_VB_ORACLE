<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consult_rapport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consult_rapport))
        Me.labelrapport = New System.Windows.Forms.Label()
        Me.labelmedicament = New System.Windows.Forms.Label()
        Me.rapport = New System.Windows.Forms.TextBox()
        Me.listemedicaments = New System.Windows.Forms.ListBox()
        Me.listequantite = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saisir_cr = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelrapport
        '
        Me.labelrapport.AutoSize = True
        Me.labelrapport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelrapport.Location = New System.Drawing.Point(192, 71)
        Me.labelrapport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelrapport.Name = "labelrapport"
        Me.labelrapport.Size = New System.Drawing.Size(50, 17)
        Me.labelrapport.TabIndex = 0
        Me.labelrapport.Text = "Label1"
        '
        'labelmedicament
        '
        Me.labelmedicament.AutoSize = True
        Me.labelmedicament.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelmedicament.Location = New System.Drawing.Point(536, 71)
        Me.labelmedicament.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelmedicament.Name = "labelmedicament"
        Me.labelmedicament.Size = New System.Drawing.Size(158, 17)
        Me.labelmedicament.TabIndex = 1
        Me.labelmedicament.Text = "Médicaments prescrits :"
        '
        'rapport
        '
        Me.rapport.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rapport.Location = New System.Drawing.Point(195, 106)
        Me.rapport.Margin = New System.Windows.Forms.Padding(2)
        Me.rapport.Multiline = True
        Me.rapport.Name = "rapport"
        Me.rapport.ReadOnly = True
        Me.rapport.Size = New System.Drawing.Size(320, 400)
        Me.rapport.TabIndex = 2
        '
        'listemedicaments
        '
        Me.listemedicaments.FormattingEnabled = True
        Me.listemedicaments.ItemHeight = 16
        Me.listemedicaments.Location = New System.Drawing.Point(539, 106)
        Me.listemedicaments.Margin = New System.Windows.Forms.Padding(2)
        Me.listemedicaments.Name = "listemedicaments"
        Me.listemedicaments.Size = New System.Drawing.Size(195, 164)
        Me.listemedicaments.TabIndex = 3
        '
        'listequantite
        '
        Me.listequantite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listequantite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listequantite.FormattingEnabled = True
        Me.listequantite.ItemHeight = 16
        Me.listequantite.Location = New System.Drawing.Point(703, 108)
        Me.listequantite.Margin = New System.Windows.Forms.Padding(2)
        Me.listequantite.Name = "listequantite"
        Me.listequantite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listequantite.Size = New System.Drawing.Size(30, 96)
        Me.listequantite.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.saisir_cr)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 523)
        Me.Panel1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Client_Lourd.My.Resources.Resources.retour3
        Me.Button1.Location = New System.Drawing.Point(3, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 122)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Retour à la sélection d'un compte-rendu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'saisir_cr
        '
        Me.saisir_cr.FlatAppearance.BorderSize = 0
        Me.saisir_cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saisir_cr.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saisir_cr.ForeColor = System.Drawing.Color.White
        Me.saisir_cr.Image = Global.Client_Lourd.My.Resources.Resources.Accueil
        Me.saisir_cr.Location = New System.Drawing.Point(3, 135)
        Me.saisir_cr.Name = "saisir_cr"
        Me.saisir_cr.Size = New System.Drawing.Size(158, 62)
        Me.saisir_cr.TabIndex = 13
        Me.saisir_cr.Text = "Accueil"
        Me.saisir_cr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.saisir_cr.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Client_Lourd.My.Resources.Resources.gsb
        Me.PictureBox2.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(306, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Consultation du compte-rendu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(721, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "X"
        '
        'consult_rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 523)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.listequantite)
        Me.Controls.Add(Me.listemedicaments)
        Me.Controls.Add(Me.rapport)
        Me.Controls.Add(Me.labelmedicament)
        Me.Controls.Add(Me.labelrapport)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "consult_rapport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulter un rapport de visite"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelrapport As System.Windows.Forms.Label
    Friend WithEvents labelmedicament As System.Windows.Forms.Label
    Friend WithEvents listemedicaments As System.Windows.Forms.ListBox
    Friend WithEvents rapport As System.Windows.Forms.TextBox
    Friend WithEvents listequantite As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents saisir_cr As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

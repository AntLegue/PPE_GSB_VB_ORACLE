<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Accueil = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.m = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Accueil)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 554)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GSB_PPE.My.Resources.Resources.contact
        Me.Button2.Location = New System.Drawing.Point(3, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 59)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Test 2"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GSB_PPE.My.Resources.Resources.calendar
        Me.Button1.Location = New System.Drawing.Point(0, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Test 1"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.Accueil.FlatAppearance.BorderSize = 0
        Me.Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Accueil.ForeColor = System.Drawing.Color.White
        Me.Accueil.Image = Global.GSB_PPE.My.Resources.Resources.Accueil
        Me.Accueil.Location = New System.Drawing.Point(0, 138)
        Me.Accueil.Name = "Accueil"
        Me.Accueil.Size = New System.Drawing.Size(193, 59)
        Me.Accueil.TabIndex = 2
        Me.Accueil.Text = "Accueil "
        Me.Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Accueil.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.m)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 96)
        Me.Panel3.TabIndex = 2
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.Location = New System.Drawing.Point(41, -21)
        Me.m.Name = "m"
        Me.m.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.m.Size = New System.Drawing.Size(110, 117)
        Me.m.TabIndex = 2
        Me.m.Text = "m"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(196, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(610, 236)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(775, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GSB_PPE.My.Resources.Resources.gsb
        Me.PictureBox1.InitialImage = Global.GSB_PPE.My.Resources.Resources.gsb
        Me.PictureBox1.Location = New System.Drawing.Point(202, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(806, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Accueil As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents m As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

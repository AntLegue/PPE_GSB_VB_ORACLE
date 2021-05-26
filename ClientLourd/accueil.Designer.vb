<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.consult_cr = New System.Windows.Forms.Button()
        Me.saisir_cr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.presentation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Accueil"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.consult_cr)
        Me.Panel1.Controls.Add(Me.saisir_cr)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 342)
        Me.Panel1.TabIndex = 9
        '
        'consult_cr
        '
        Me.consult_cr.FlatAppearance.BorderSize = 0
        Me.consult_cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.consult_cr.ForeColor = System.Drawing.Color.White
        Me.consult_cr.Image = Global.Client_Lourd.My.Resources.Resources.consulter
        Me.consult_cr.Location = New System.Drawing.Point(3, 233)
        Me.consult_cr.Name = "consult_cr"
        Me.consult_cr.Size = New System.Drawing.Size(145, 83)
        Me.consult_cr.TabIndex = 13
        Me.consult_cr.Text = "Consulter un rapport de visite"
        Me.consult_cr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.consult_cr.UseVisualStyleBackColor = True
        '
        'saisir_cr
        '
        Me.saisir_cr.FlatAppearance.BorderSize = 0
        Me.saisir_cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saisir_cr.ForeColor = System.Drawing.Color.White
        Me.saisir_cr.Image = Global.Client_Lourd.My.Resources.Resources.rapport
        Me.saisir_cr.Location = New System.Drawing.Point(0, 124)
        Me.saisir_cr.Name = "saisir_cr"
        Me.saisir_cr.Size = New System.Drawing.Size(145, 83)
        Me.saisir_cr.TabIndex = 12
        Me.saisir_cr.Text = "Saisir un rapport de visite"
        Me.saisir_cr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.saisir_cr.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client_Lourd.My.Resources.Resources.gsb
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.presentation)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(148, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 268)
        Me.Panel2.TabIndex = 10
        '
        'presentation
        '
        Me.presentation.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentation.ForeColor = System.Drawing.Color.White
        Me.presentation.Location = New System.Drawing.Point(28, 84)
        Me.presentation.Name = "presentation"
        Me.presentation.Size = New System.Drawing.Size(600, 83)
        Me.presentation.TabIndex = 12
        Me.presentation.Text = "Bienvenue sur l'écran d'accueil, veuillez choisir l'un des modules proposés"
        Me.presentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(775, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "X"
        '
        'accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 342)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accueil"
        Me.Text = "Accueil"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents saisir_cr As System.Windows.Forms.Button
    Friend WithEvents consult_cr As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents presentation As System.Windows.Forms.Label
End Class

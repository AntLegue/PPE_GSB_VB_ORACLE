<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class select_rapport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(select_rapport))
        Me.nomvisiteur = New System.Windows.Forms.Label()
        Me.listerapport = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saisir_cr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomvisiteur
        '
        Me.nomvisiteur.AutoSize = True
        Me.nomvisiteur.Location = New System.Drawing.Point(89, 38)
        Me.nomvisiteur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nomvisiteur.Name = "nomvisiteur"
        Me.nomvisiteur.Size = New System.Drawing.Size(11, 16)
        Me.nomvisiteur.TabIndex = 0
        Me.nomvisiteur.Text = " "
        '
        'listerapport
        '
        Me.listerapport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listerapport.FormattingEnabled = True
        Me.listerapport.ItemHeight = 17
        Me.listerapport.Location = New System.Drawing.Point(174, 61)
        Me.listerapport.Margin = New System.Windows.Forms.Padding(2)
        Me.listerapport.Name = "listerapport"
        Me.listerapport.Size = New System.Drawing.Size(395, 497)
        Me.listerapport.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(170, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 27)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Liste des comptes-rendus : "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.saisir_cr)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 575)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(557, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "X"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client_Lourd.My.Resources.Resources.gsb
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'select_rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 575)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.listerapport)
        Me.Controls.Add(Me.nomvisiteur)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "select_rapport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulter un rapport de visite"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomvisiteur As System.Windows.Forms.Label
    Friend WithEvents listerapport As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents saisir_cr As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

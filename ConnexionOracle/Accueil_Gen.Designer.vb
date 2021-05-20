<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil_Gen
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
        Me.AddRegion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddSec = New System.Windows.Forms.Button()
        Me.AddVis = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.AddMed = New System.Windows.Forms.Button()
        Me.AddMedic = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddRegion
        '
        Me.AddRegion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddRegion.ForeColor = System.Drawing.Color.White
        Me.AddRegion.Location = New System.Drawing.Point(40, 70)
        Me.AddRegion.Name = "AddRegion"
        Me.AddRegion.Size = New System.Drawing.Size(196, 44)
        Me.AddRegion.TabIndex = 9
        Me.AddRegion.Text = "Ajout de régions"
        Me.AddRegion.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 36)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Veuillez choisir un module : "
        '
        'AddSec
        '
        Me.AddSec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddSec.ForeColor = System.Drawing.Color.White
        Me.AddSec.Location = New System.Drawing.Point(40, 140)
        Me.AddSec.Name = "AddSec"
        Me.AddSec.Size = New System.Drawing.Size(196, 44)
        Me.AddSec.TabIndex = 11
        Me.AddSec.Text = "Ajout de secteurs"
        Me.AddSec.UseVisualStyleBackColor = False
        '
        'AddVis
        '
        Me.AddVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddVis.ForeColor = System.Drawing.Color.White
        Me.AddVis.Location = New System.Drawing.Point(40, 210)
        Me.AddVis.Name = "AddVis"
        Me.AddVis.Size = New System.Drawing.Size(196, 44)
        Me.AddVis.TabIndex = 12
        Me.AddVis.Text = "Ajout de visiteurs"
        Me.AddVis.UseVisualStyleBackColor = False
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.Color.Red
        Me.Quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Quitter.Location = New System.Drawing.Point(500, 253)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(116, 35)
        Me.Quitter.TabIndex = 13
        Me.Quitter.Text = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'AddMed
        '
        Me.AddMed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddMed.ForeColor = System.Drawing.Color.White
        Me.AddMed.Location = New System.Drawing.Point(270, 140)
        Me.AddMed.Name = "AddMed"
        Me.AddMed.Size = New System.Drawing.Size(196, 44)
        Me.AddMed.TabIndex = 15
        Me.AddMed.Text = "Ajout de médecins"
        Me.AddMed.UseVisualStyleBackColor = False
        '
        'AddMedic
        '
        Me.AddMedic.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddMedic.ForeColor = System.Drawing.Color.White
        Me.AddMedic.Location = New System.Drawing.Point(270, 70)
        Me.AddMedic.Name = "AddMedic"
        Me.AddMedic.Size = New System.Drawing.Size(196, 44)
        Me.AddMedic.TabIndex = 16
        Me.AddMedic.Text = "Ajout de médicaments"
        Me.AddMedic.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 300)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.Logo_gsb
        Me.PictureBox1.Location = New System.Drawing.Point(496, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Accueil_Gen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 300)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.AddMedic)
        Me.Controls.Add(Me.AddMed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.AddVis)
        Me.Controls.Add(Me.AddSec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddRegion)
        Me.Name = "Accueil_Gen"
        Me.Text = "Accueil générateur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddRegion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddSec As System.Windows.Forms.Button
    Friend WithEvents AddVis As System.Windows.Forms.Button
    Friend WithEvents Quitter As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AddMed As System.Windows.Forms.Button
    Friend WithEvents AddMedic As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saisie_CR
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
        Me.Scrollbar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Affich_CP = New System.Windows.Forms.TextBox()
        Me.Affich_Ville = New System.Windows.Forms.TextBox()
        Me.Affich_Addr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Medic = New System.Windows.Forms.Panel()
        Me.Qte3 = New System.Windows.Forms.TextBox()
        Me.Qte2 = New System.Windows.Forms.TextBox()
        Me.Qte1 = New System.Windows.Forms.TextBox()
        Me.Select_Medic3 = New System.Windows.Forms.ComboBox()
        Me.Select_Medic2 = New System.Windows.Forms.ComboBox()
        Me.Select_Medic = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Valider_CR = New System.Windows.Forms.Button()
        Me.Insert_Motif = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Medic.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Scrollbar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 262)
        Me.Panel1.TabIndex = 0
        '
        'Scrollbar
        '
        Me.Scrollbar.FormattingEnabled = True
        Me.Scrollbar.Location = New System.Drawing.Point(190, 119)
        Me.Scrollbar.Name = "Scrollbar"
        Me.Scrollbar.Size = New System.Drawing.Size(162, 21)
        Me.Scrollbar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom et prénom du médecin : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Affich_CP)
        Me.Panel2.Controls.Add(Me.Affich_Ville)
        Me.Panel2.Controls.Add(Me.Affich_Addr)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(447, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 262)
        Me.Panel2.TabIndex = 1
        '
        'Affich_CP
        '
        Me.Affich_CP.Location = New System.Drawing.Point(92, 139)
        Me.Affich_CP.Name = "Affich_CP"
        Me.Affich_CP.Size = New System.Drawing.Size(140, 20)
        Me.Affich_CP.TabIndex = 5
        '
        'Affich_Ville
        '
        Me.Affich_Ville.Location = New System.Drawing.Point(92, 89)
        Me.Affich_Ville.Name = "Affich_Ville"
        Me.Affich_Ville.Size = New System.Drawing.Size(140, 20)
        Me.Affich_Ville.TabIndex = 4
        '
        'Affich_Addr
        '
        Me.Affich_Addr.Location = New System.Drawing.Point(92, 39)
        Me.Affich_Addr.Name = "Affich_Addr"
        Me.Affich_Addr.Size = New System.Drawing.Size(140, 20)
        Me.Affich_Addr.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CP :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ville :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Adresse :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date de la visite : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 300)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Motif : "
        '
        'Medic
        '
        Me.Medic.Controls.Add(Me.Qte3)
        Me.Medic.Controls.Add(Me.Qte2)
        Me.Medic.Controls.Add(Me.Qte1)
        Me.Medic.Controls.Add(Me.Select_Medic3)
        Me.Medic.Controls.Add(Me.Select_Medic2)
        Me.Medic.Controls.Add(Me.Select_Medic)
        Me.Medic.Controls.Add(Me.Label13)
        Me.Medic.Controls.Add(Me.Label12)
        Me.Medic.Controls.Add(Me.Label11)
        Me.Medic.Controls.Add(Me.Label10)
        Me.Medic.Controls.Add(Me.Label9)
        Me.Medic.Controls.Add(Me.Label8)
        Me.Medic.Controls.Add(Me.Label7)
        Me.Medic.Location = New System.Drawing.Point(413, 300)
        Me.Medic.Name = "Medic"
        Me.Medic.Size = New System.Drawing.Size(419, 177)
        Me.Medic.TabIndex = 6
        '
        'Qte3
        '
        Me.Qte3.Location = New System.Drawing.Point(273, 123)
        Me.Qte3.Multiline = True
        Me.Qte3.Name = "Qte3"
        Me.Qte3.Size = New System.Drawing.Size(52, 25)
        Me.Qte3.TabIndex = 15
        '
        'Qte2
        '
        Me.Qte2.Location = New System.Drawing.Point(273, 83)
        Me.Qte2.Multiline = True
        Me.Qte2.Name = "Qte2"
        Me.Qte2.Size = New System.Drawing.Size(52, 25)
        Me.Qte2.TabIndex = 14
        '
        'Qte1
        '
        Me.Qte1.Location = New System.Drawing.Point(273, 39)
        Me.Qte1.Multiline = True
        Me.Qte1.Name = "Qte1"
        Me.Qte1.Size = New System.Drawing.Size(52, 25)
        Me.Qte1.TabIndex = 6
        '
        'Select_Medic3
        '
        Me.Select_Medic3.FormattingEnabled = True
        Me.Select_Medic3.Location = New System.Drawing.Point(62, 123)
        Me.Select_Medic3.Name = "Select_Medic3"
        Me.Select_Medic3.Size = New System.Drawing.Size(145, 21)
        Me.Select_Medic3.TabIndex = 13
        '
        'Select_Medic2
        '
        Me.Select_Medic2.FormattingEnabled = True
        Me.Select_Medic2.Location = New System.Drawing.Point(62, 83)
        Me.Select_Medic2.Name = "Select_Medic2"
        Me.Select_Medic2.Size = New System.Drawing.Size(145, 21)
        Me.Select_Medic2.TabIndex = 12
        '
        'Select_Medic
        '
        Me.Select_Medic.FormattingEnabled = True
        Me.Select_Medic.Location = New System.Drawing.Point(62, 43)
        Me.Select_Medic.Name = "Select_Medic"
        Me.Select_Medic.Size = New System.Drawing.Size(145, 21)
        Me.Select_Medic.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Qte : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(234, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Qte : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Qte : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nom : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nom : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nom : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Médicament à ajouté : "
        '
        'Valider_CR
        '
        Me.Valider_CR.Location = New System.Drawing.Point(706, 551)
        Me.Valider_CR.Name = "Valider_CR"
        Me.Valider_CR.Size = New System.Drawing.Size(126, 30)
        Me.Valider_CR.TabIndex = 16
        Me.Valider_CR.Text = "Valider"
        Me.Valider_CR.UseVisualStyleBackColor = True
        '
        'Insert_Motif
        '
        Me.Insert_Motif.Location = New System.Drawing.Point(57, 437)
        Me.Insert_Motif.Multiline = True
        Me.Insert_Motif.Name = "Insert_Motif"
        Me.Insert_Motif.Size = New System.Drawing.Size(322, 124)
        Me.Insert_Motif.TabIndex = 16
        '
        'Saisie_CR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 593)
        Me.Controls.Add(Me.Insert_Motif)
        Me.Controls.Add(Me.Valider_CR)
        Me.Controls.Add(Me.Medic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Saisie_CR"
        Me.Text = "Saisie_CR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Medic.ResumeLayout(False)
        Me.Medic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Scrollbar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Affich_CP As System.Windows.Forms.TextBox
    Friend WithEvents Affich_Ville As System.Windows.Forms.TextBox
    Friend WithEvents Affich_Addr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Medic As System.Windows.Forms.Panel
    Friend WithEvents Qte3 As System.Windows.Forms.TextBox
    Friend WithEvents Qte2 As System.Windows.Forms.TextBox
    Friend WithEvents Qte1 As System.Windows.Forms.TextBox
    Friend WithEvents Select_Medic3 As System.Windows.Forms.ComboBox
    Friend WithEvents Select_Medic2 As System.Windows.Forms.ComboBox
    Friend WithEvents Select_Medic As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Valider_CR As System.Windows.Forms.Button
    Friend WithEvents Insert_Motif As System.Windows.Forms.TextBox
End Class

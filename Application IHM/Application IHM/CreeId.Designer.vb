<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreeId
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
        Me.TextBoxPseudo = New System.Windows.Forms.TextBox()
        Me.BoxAge = New System.Windows.Forms.TextBox()
        Me.BoxPrenom = New System.Windows.Forms.TextBox()
        Me.BoxNom = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxMdp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxPseudo
        '
        Me.TextBoxPseudo.Location = New System.Drawing.Point(60, 89)
        Me.TextBoxPseudo.Name = "TextBoxPseudo"
        Me.TextBoxPseudo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPseudo.TabIndex = 0
        '
        'BoxAge
        '
        Me.BoxAge.Location = New System.Drawing.Point(60, 254)
        Me.BoxAge.Name = "BoxAge"
        Me.BoxAge.Size = New System.Drawing.Size(100, 22)
        Me.BoxAge.TabIndex = 2
        '
        'BoxPrenom
        '
        Me.BoxPrenom.Location = New System.Drawing.Point(60, 209)
        Me.BoxPrenom.Name = "BoxPrenom"
        Me.BoxPrenom.Size = New System.Drawing.Size(100, 22)
        Me.BoxPrenom.TabIndex = 3
        '
        'BoxNom
        '
        Me.BoxNom.Location = New System.Drawing.Point(60, 163)
        Me.BoxNom.Name = "BoxNom"
        Me.BoxNom.Size = New System.Drawing.Size(100, 22)
        Me.BoxNom.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pseudo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Prenom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Age"
        '
        'TextBoxMdp
        '
        Me.TextBoxMdp.Location = New System.Drawing.Point(60, 123)
        Me.TextBoxMdp.Name = "TextBoxMdp"
        Me.TextBoxMdp.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxMdp.TabIndex = 11
        Me.TextBoxMdp.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mot de passe"
        '
        'CreeId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 403)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxMdp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BoxNom)
        Me.Controls.Add(Me.BoxPrenom)
        Me.Controls.Add(Me.BoxAge)
        Me.Controls.Add(Me.TextBoxPseudo)
        Me.Name = "CreeId"
        Me.Text = "CreeId"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPseudo As TextBox
    Friend WithEvents BoxAge As TextBox
    Friend WithEvents BoxPrenom As TextBox
    Friend WithEvents BoxNom As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxMdp As TextBox
    Friend WithEvents Label5 As Label
End Class

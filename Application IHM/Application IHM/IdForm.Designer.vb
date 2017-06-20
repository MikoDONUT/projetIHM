<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IdForm
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
        Me.PseudoBox = New System.Windows.Forms.TextBox()
        Me.mdpBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PseudoBox
        '
        Me.PseudoBox.Location = New System.Drawing.Point(48, 124)
        Me.PseudoBox.Name = "PseudoBox"
        Me.PseudoBox.Size = New System.Drawing.Size(100, 22)
        Me.PseudoBox.TabIndex = 0
        '
        'mdpBox
        '
        Me.mdpBox.Location = New System.Drawing.Point(48, 192)
        Me.mdpBox.Name = "mdpBox"
        Me.mdpBox.Size = New System.Drawing.Size(97, 22)
        Me.mdpBox.TabIndex = 1
        Me.mdpBox.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pseudo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Connexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mdpBox)
        Me.Controls.Add(Me.PseudoBox)
        Me.Name = "IdForm"
        Me.Text = "IdForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PseudoBox As TextBox
    Friend WithEvents mdpBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

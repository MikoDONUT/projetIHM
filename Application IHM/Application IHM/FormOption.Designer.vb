<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOption
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxNuit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDalt = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEco = New System.Windows.Forms.CheckBox()
        Me.BtnAppliquer = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Option"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxNuit
        '
        Me.CheckBoxNuit.AutoSize = True
        Me.CheckBoxNuit.Location = New System.Drawing.Point(79, 102)
        Me.CheckBoxNuit.Name = "CheckBoxNuit"
        Me.CheckBoxNuit.Size = New System.Drawing.Size(94, 21)
        Me.CheckBoxNuit.TabIndex = 3
        Me.CheckBoxNuit.Text = "Mode Nuit"
        Me.CheckBoxNuit.UseVisualStyleBackColor = True
        '
        'CheckBoxDalt
        '
        Me.CheckBoxDalt.AutoSize = True
        Me.CheckBoxDalt.Location = New System.Drawing.Point(79, 128)
        Me.CheckBoxDalt.Name = "CheckBoxDalt"
        Me.CheckBoxDalt.Size = New System.Drawing.Size(127, 21)
        Me.CheckBoxDalt.TabIndex = 4
        Me.CheckBoxDalt.Text = "Mode daltonien"
        Me.CheckBoxDalt.UseVisualStyleBackColor = True
        '
        'CheckBoxEco
        '
        Me.CheckBoxEco.AutoSize = True
        Me.CheckBoxEco.Location = New System.Drawing.Point(79, 155)
        Me.CheckBoxEco.Name = "CheckBoxEco"
        Me.CheckBoxEco.Size = New System.Drawing.Size(147, 21)
        Me.CheckBoxEco.TabIndex = 5
        Me.CheckBoxEco.Text = "Mode Economique"
        Me.CheckBoxEco.UseVisualStyleBackColor = True
        '
        'BtnAppliquer
        '
        Me.BtnAppliquer.Location = New System.Drawing.Point(28, 356)
        Me.BtnAppliquer.Name = "BtnAppliquer"
        Me.BtnAppliquer.Size = New System.Drawing.Size(94, 35)
        Me.BtnAppliquer.TabIndex = 6
        Me.BtnAppliquer.Text = "Appliquer"
        Me.BtnAppliquer.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(162, 356)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(94, 35)
        Me.BtnQuitter.TabIndex = 7
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 403)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnAppliquer)
        Me.Controls.Add(Me.CheckBoxEco)
        Me.Controls.Add(Me.CheckBoxDalt)
        Me.Controls.Add(Me.CheckBoxNuit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOption"
        Me.Text = "FormOption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxNuit As CheckBox
    Friend WithEvents CheckBoxDalt As CheckBox
    Friend WithEvents CheckBoxEco As CheckBox
    Friend WithEvents BtnAppliquer As Button
    Friend WithEvents BtnQuitter As Button
End Class

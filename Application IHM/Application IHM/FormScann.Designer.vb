﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScann
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
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(12, 1)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(110, 37)
        Me.BtnRetour.TabIndex = 11
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Avoir le prix d'un article"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 47)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Scanner un article"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormScann
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRetour)
        Me.Name = "FormScann"
        Me.Text = "FormScann"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRetour As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

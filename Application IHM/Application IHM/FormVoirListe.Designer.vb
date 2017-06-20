<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVoirListe
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
        Me.LstBoxProduit = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LstBoxPartager = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(2, 12)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetour.TabIndex = 0
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'LstBoxProduit
        '
        Me.LstBoxProduit.FormattingEnabled = True
        Me.LstBoxProduit.ItemHeight = 16
        Me.LstBoxProduit.Location = New System.Drawing.Point(12, 106)
        Me.LstBoxProduit.Name = "LstBoxProduit"
        Me.LstBoxProduit.Size = New System.Drawing.Size(244, 84)
        Me.LstBoxProduit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Detail de"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Supprimer un produit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Partager avec"
        '
        'LstBoxPartager
        '
        Me.LstBoxPartager.FormattingEnabled = True
        Me.LstBoxPartager.ItemHeight = 16
        Me.LstBoxPartager.Location = New System.Drawing.Point(13, 263)
        Me.LstBoxPartager.Name = "LstBoxPartager"
        Me.LstBoxPartager.Size = New System.Drawing.Size(243, 84)
        Me.LstBoxPartager.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 26)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Supprimer partage"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormVoirListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LstBoxPartager)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstBoxProduit)
        Me.Controls.Add(Me.BtnRetour)
        Me.Name = "FormVoirListe"
        Me.Text = "FormVoirListe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRetour As Button
    Friend WithEvents LstBoxProduit As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LstBoxPartager As ListBox
    Friend WithEvents Button2 As Button
End Class

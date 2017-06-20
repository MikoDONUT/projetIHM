<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnShare = New System.Windows.Forms.Button()
        Me.BtnRm = New System.Windows.Forms.Button()
        Me.Btnoption = New System.Windows.Forms.Button()
        Me.ListProduit = New System.Windows.Forms.ListBox()
        Me.BtnVoir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes Listes"
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(234, 85)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(133, 73)
        Me.BtnNew.TabIndex = 1
        Me.BtnNew.Text = "Nouvelle Liste"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnShare
        '
        Me.BtnShare.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnShare.Enabled = False
        Me.BtnShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BtnShare.Location = New System.Drawing.Point(233, 368)
        Me.BtnShare.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnShare.Name = "BtnShare"
        Me.BtnShare.Size = New System.Drawing.Size(133, 73)
        Me.BtnShare.TabIndex = 1
        Me.BtnShare.Text = "Partager"
        Me.BtnShare.UseVisualStyleBackColor = False
        '
        'BtnRm
        '
        Me.BtnRm.BackColor = System.Drawing.Color.Red
        Me.BtnRm.Enabled = False
        Me.BtnRm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRm.Location = New System.Drawing.Point(233, 275)
        Me.BtnRm.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRm.Name = "BtnRm"
        Me.BtnRm.Size = New System.Drawing.Size(134, 73)
        Me.BtnRm.TabIndex = 6
        Me.BtnRm.Text = "Supprimer"
        Me.BtnRm.UseVisualStyleBackColor = False
        '
        'Btnoption
        '
        Me.Btnoption.Location = New System.Drawing.Point(291, 464)
        Me.Btnoption.Name = "Btnoption"
        Me.Btnoption.Size = New System.Drawing.Size(75, 30)
        Me.Btnoption.TabIndex = 7
        Me.Btnoption.Text = "Option"
        Me.Btnoption.UseVisualStyleBackColor = True
        '
        'ListProduit
        '
        Me.ListProduit.FormattingEnabled = True
        Me.ListProduit.ItemHeight = 16
        Me.ListProduit.Items.AddRange(New Object() {"liste 1", "liste 2", "liste 3"})
        Me.ListProduit.Location = New System.Drawing.Point(12, 85)
        Me.ListProduit.Name = "ListProduit"
        Me.ListProduit.Size = New System.Drawing.Size(202, 404)
        Me.ListProduit.TabIndex = 8
        '
        'BtnVoir
        '
        Me.BtnVoir.Enabled = False
        Me.BtnVoir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoir.Location = New System.Drawing.Point(233, 180)
        Me.BtnVoir.Name = "BtnVoir"
        Me.BtnVoir.Size = New System.Drawing.Size(133, 73)
        Me.BtnVoir.TabIndex = 9
        Me.BtnVoir.Text = "Detail"
        Me.BtnVoir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(379, 506)
        Me.Controls.Add(Me.BtnVoir)
        Me.Controls.Add(Me.Btnoption)
        Me.Controls.Add(Me.BtnRm)
        Me.Controls.Add(Me.BtnShare)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListProduit)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnNew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnShare As Button
    Friend WithEvents BtnRm As Button
    Friend WithEvents Btnoption As Button
    Friend WithEvents ListProduit As ListBox
    Friend WithEvents BtnVoir As Button
End Class

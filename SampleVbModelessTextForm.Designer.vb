﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleVbModelessTextForm
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
    Me.textBox = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'textBox
    '
    Me.textBox.AcceptsReturn = True
    Me.textBox.AcceptsTab = True
    Me.textBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.textBox.Location = New System.Drawing.Point(0, 0)
    Me.textBox.Multiline = True
    Me.textBox.Name = "textBox"
    Me.textBox.Size = New System.Drawing.Size(284, 261)
    Me.textBox.TabIndex = 0
    '
    'SampleVbModelessTextForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.textBox)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "SampleVbModelessTextForm"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Text = "SampleVbModelessTextForm"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents textBox As System.Windows.Forms.TextBox
End Class

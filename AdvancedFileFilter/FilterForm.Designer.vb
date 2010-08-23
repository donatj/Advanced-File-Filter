<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.textRaw = New System.Windows.Forms.TextBox
        Me.textRaw_excl = New System.Windows.Forms.TextBox
        Me.textFold_excl = New System.Windows.Forms.TextBox
        Me.textFold = New System.Windows.Forms.TextBox
        Me.textFilter = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(260, 327)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'textRaw
        '
        Me.textRaw.Location = New System.Drawing.Point(12, 12)
        Me.textRaw.Multiline = True
        Me.textRaw.Name = "textRaw"
        Me.textRaw.Size = New System.Drawing.Size(194, 124)
        Me.textRaw.TabIndex = 1
        '
        'textRaw_excl
        '
        Me.textRaw_excl.Location = New System.Drawing.Point(212, 12)
        Me.textRaw_excl.Multiline = True
        Me.textRaw_excl.Name = "textRaw_excl"
        Me.textRaw_excl.Size = New System.Drawing.Size(194, 124)
        Me.textRaw_excl.TabIndex = 2
        '
        'textFold_excl
        '
        Me.textFold_excl.Location = New System.Drawing.Point(212, 142)
        Me.textFold_excl.Multiline = True
        Me.textFold_excl.Name = "textFold_excl"
        Me.textFold_excl.Size = New System.Drawing.Size(194, 124)
        Me.textFold_excl.TabIndex = 4
        '
        'textFold
        '
        Me.textFold.Location = New System.Drawing.Point(12, 142)
        Me.textFold.Multiline = True
        Me.textFold.Name = "textFold"
        Me.textFold.Size = New System.Drawing.Size(194, 124)
        Me.textFold.TabIndex = 3
        '
        'textFilter
        '
        Me.textFilter.Location = New System.Drawing.Point(12, 301)
        Me.textFilter.Name = "textFilter"
        Me.textFilter.Size = New System.Drawing.Size(391, 20)
        Me.textFilter.TabIndex = 5
        '
        'AdvancedFilter
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(418, 368)
        Me.Controls.Add(Me.textFilter)
        Me.Controls.Add(Me.textFold_excl)
        Me.Controls.Add(Me.textFold)
        Me.Controls.Add(Me.textRaw_excl)
        Me.Controls.Add(Me.textRaw)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdvancedFilter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AdvancedFilter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents textRaw As System.Windows.Forms.TextBox
    Friend WithEvents textRaw_excl As System.Windows.Forms.TextBox
    Friend WithEvents textFold_excl As System.Windows.Forms.TextBox
    Friend WithEvents textFold As System.Windows.Forms.TextBox
    Friend WithEvents textFilter As System.Windows.Forms.TextBox

End Class

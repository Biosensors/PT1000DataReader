<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admentment
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
        Me.ComboBoxResult = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNewReason = New System.Windows.Forms.ComboBox()
        Me.TextBoxNewRemarks = New System.Windows.Forms.TextBox()
        Me.LabelChangeReasonTo = New System.Windows.Forms.Label()
        Me.LabelChangeRemark = New System.Windows.Forms.Label()
        Me.ButtonAmend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxResult
        '
        Me.ComboBoxResult.FormattingEnabled = True
        Me.ComboBoxResult.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxResult.Name = "ComboBoxResult"
        Me.ComboBoxResult.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxResult.TabIndex = 0
        '
        'ComboBoxNewReason
        '
        Me.ComboBoxNewReason.FormattingEnabled = True
        Me.ComboBoxNewReason.Location = New System.Drawing.Point(12, 71)
        Me.ComboBoxNewReason.Name = "ComboBoxNewReason"
        Me.ComboBoxNewReason.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxNewReason.TabIndex = 1
        '
        'TextBoxNewRemarks
        '
        Me.TextBoxNewRemarks.Location = New System.Drawing.Point(12, 131)
        Me.TextBoxNewRemarks.Name = "TextBoxNewRemarks"
        Me.TextBoxNewRemarks.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxNewRemarks.TabIndex = 2
        '
        'LabelChangeReasonTo
        '
        Me.LabelChangeReasonTo.AutoSize = True
        Me.LabelChangeReasonTo.Location = New System.Drawing.Point(12, 45)
        Me.LabelChangeReasonTo.Name = "LabelChangeReasonTo"
        Me.LabelChangeReasonTo.Size = New System.Drawing.Size(127, 13)
        Me.LabelChangeReasonTo.TabIndex = 3
        Me.LabelChangeReasonTo.Text = "Change Burst Reason To"
        '
        'LabelChangeRemark
        '
        Me.LabelChangeRemark.AutoSize = True
        Me.LabelChangeRemark.Location = New System.Drawing.Point(12, 104)
        Me.LabelChangeRemark.Name = "LabelChangeRemark"
        Me.LabelChangeRemark.Size = New System.Drawing.Size(105, 13)
        Me.LabelChangeRemark.TabIndex = 4
        Me.LabelChangeRemark.Text = "Change Remarks To"
        '
        'ButtonAmend
        '
        Me.ButtonAmend.Location = New System.Drawing.Point(12, 157)
        Me.ButtonAmend.Name = "ButtonAmend"
        Me.ButtonAmend.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAmend.TabIndex = 7
        Me.ButtonAmend.Text = "Update"
        Me.ButtonAmend.UseVisualStyleBackColor = True
        '
        'Admentment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 189)
        Me.Controls.Add(Me.ButtonAmend)
        Me.Controls.Add(Me.LabelChangeRemark)
        Me.Controls.Add(Me.LabelChangeReasonTo)
        Me.Controls.Add(Me.TextBoxNewRemarks)
        Me.Controls.Add(Me.ComboBoxNewReason)
        Me.Controls.Add(Me.ComboBoxResult)
        Me.Name = "Admentment"
        Me.Text = "Result Amendment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxResult As ComboBox
    Friend WithEvents ComboBoxNewReason As ComboBox
    Friend WithEvents TextBoxNewRemarks As TextBox
    Friend WithEvents LabelChangeReasonTo As Label
    Friend WithEvents LabelChangeRemark As Label
    Friend WithEvents ButtonAmend As Button
End Class

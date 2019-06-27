<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpboxLogon = New System.Windows.Forms.GroupBox()
        Me.cmbworkarea = New System.Windows.Forms.ComboBox()
        Me.lblOperationMode = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.grpboxLogon.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxLogon
        '
        Me.grpboxLogon.Controls.Add(Me.cmbworkarea)
        Me.grpboxLogon.Controls.Add(Me.lblOperationMode)
        Me.grpboxLogon.Controls.Add(Me.txtPassword)
        Me.grpboxLogon.Controls.Add(Me.txtUserID)
        Me.grpboxLogon.Controls.Add(Me.Label1)
        Me.grpboxLogon.Controls.Add(Me.lblUserID)
        Me.grpboxLogon.Location = New System.Drawing.Point(22, 18)
        Me.grpboxLogon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpboxLogon.Name = "grpboxLogon"
        Me.grpboxLogon.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpboxLogon.Size = New System.Drawing.Size(424, 151)
        Me.grpboxLogon.TabIndex = 0
        Me.grpboxLogon.TabStop = False
        Me.grpboxLogon.Text = "Logon Credentials"
        Me.grpboxLogon.UseWaitCursor = True
        '
        'cmbworkarea
        '
        Me.cmbworkarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbworkarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbworkarea.FormattingEnabled = True
        Me.cmbworkarea.Items.AddRange(New Object() {"LAB", "IQA", "BALLOON", "IPQC"})
        Me.cmbworkarea.Location = New System.Drawing.Point(119, 28)
        Me.cmbworkarea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbworkarea.Name = "cmbworkarea"
        Me.cmbworkarea.Size = New System.Drawing.Size(227, 25)
        Me.cmbworkarea.TabIndex = 5
        Me.cmbworkarea.UseWaitCursor = True
        '
        'lblOperationMode
        '
        Me.lblOperationMode.AutoSize = True
        Me.lblOperationMode.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationMode.Location = New System.Drawing.Point(33, 28)
        Me.lblOperationMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOperationMode.Name = "lblOperationMode"
        Me.lblOperationMode.Size = New System.Drawing.Size(76, 17)
        Me.lblOperationMode.TabIndex = 4
        Me.lblOperationMode.Text = "Work Area"
        Me.lblOperationMode.UseWaitCursor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(119, 110)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(227, 24)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseWaitCursor = True
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(119, 70)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(227, 24)
        Me.txtUserID.TabIndex = 10
        Me.txtUserID.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password"
        Me.Label1.UseWaitCursor = True
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(33, 72)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(57, 17)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "User ID"
        Me.lblUserID.UseWaitCursor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(164, 192)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 27)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(256, 192)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(69, 27)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 228)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpboxLogon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.grpboxLogon.ResumeLayout(False)
        Me.grpboxLogon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxLogon As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents lblOperationMode As System.Windows.Forms.Label
    Friend WithEvents cmbworkarea As System.Windows.Forms.ComboBox
End Class

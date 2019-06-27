Public Class FrmLogin


    'Public clspm As New IniFileFunctions
    Public ds As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim sIniSections As String
        Dim sStr() As String
        Dim j As Integer
        Dim sIniPath As String

        domainUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name
        txtUserID.Text = domainUser

        sIniPath = sGetIniFilePath()
        If Not sIniPath = "" Then
            sIniSections = INIRead(sIniPath)
            sIniSections = sIniSections.Replace(ControlChars.NullChar, "|"c)
            ' to split the pipe and load the sections into the dropdownlist

            sStr = Split(sIniSections, "|")

            If (sStr.Length > 0) Then
                For j = 0 To sStr.Length - 2

                    'Me.cmbServer.Items.Add(sStr(j))
                Next
            End If
            'sValue = INIRead(Application.StartupPath & "\biotrack.ini", "section2", "Key2")
        End If
        Me.txtUserID.Focus()


    End Sub

    Private Sub Login_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If (sLoginCancel) Then
        'Me.Close()
        '    Application.Exit()
        'Else

        Application.Exit()
        '    ' frmParent = New MDIForm
        '    ' frmParent.Show()
        '    'Else
        'End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'If (sLoginCancel) Then
        Me.Close()
        Application.Exit()
        ' Else

        Application.Exit()
        ' frmParent = New MDIForm
        ' frmParent.Show()
        'Else
        'End If
    End Sub
    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        'If cmbServer.SelectedIndex <> -1 Then
        ValidateLogin()
       ' End If

    End Sub
    Private Sub txtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserID.TextChanged
        'If (txtUserID.Text = "") Then
        '    btn()
        '    btnLogIn.Enabled = False
        'Else
        '    btnLogIn.Enabled = True
        'End If

    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ValidateLogin()    ' Commented to Skip authentication
            'SuccessLogin()
        End If
    End Sub
    Private Sub ValidateLogin()
        Dim nUserPos As Integer
        Try
            sLogonUser = "*"
            sConnectionServer = GetConnectionStringValue()

            'Check the same userName/PWD exist in table Users
            ' split the txtUserID.text (ex. BSI\Admin to Admin) for checking in table
            If cmbworkarea.SelectedIndex < 0 Then
                sWorkArea = ""
            Else
                sWorkArea = cmbworkarea.SelectedItem.ToString
            End If

            If sWorkArea = "" Then
                MsgBox("Select the Work Area", MsgBoxStyle.Information)
            Else

                nUserPos = InStr(txtUserID.Text, "\")
                If nUserPos > 0 Then
                    Username = Mid(txtUserID.Text, nUserPos + 1, Len(txtUserID.Text))
                Else
                    Username = Trim(txtUserID.Text)
                End If
                sLogonUser = Username

                If (True = ValidateActiveDirectoryLogin(txtUserID.Text.Trim(), txtPassword.Text.Trim())) Then
                    SuccessLogin()
                Else
                    sLogonUser = "*"
                    sWorkArea = ""
                    'throw exception stated with userid is not defined in the table
                    MsgBox("Authentication Failed. Please try again", MsgBoxStyle.Critical)
                    Me.txtPassword.Focus()
                    Me.txtPassword.SelectAll()
                End If
            End If

        Catch ex As System.Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub SuccessLogin()
        Me.txtPassword.Text = ""
        Me.Hide()
        MainForm.Show()
        'sLoginCancel = True

        'Call MDIForm.PopulateMenu(sLogonUser)
        '' sLogonUser = UserNameActual
        '' MDIForm.Activate()
        'MDIForm.TSSlblLogin.Text = UserFullName & " (" & sLogonUser & ")"
        'MDIForm.TSSlbldbName.Text = cmbServer.SelectedItem
        'MDIForm.TSSlblVersion.Text = "Ver: " & sVersion & ""
        'MDIForm.Activate()
        'Do load Menu
        'Call MDIForm.PopulateMenu(sLogonUser)
    End Sub

    Private Sub btnlogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

    End Sub

    Private Sub grpboxLogon_Enter(sender As Object, e As EventArgs) Handles grpboxLogon.Enter

    End Sub
End Class
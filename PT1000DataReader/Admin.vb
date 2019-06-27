Public Class Admentment
    Private Sub Admentment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadReason()
        loadResult()
        If ComboBoxResult.Items.Count = 0 Then
            MessageBox.Show("Only Leader can access to this module !")
            Me.Close()
        End If

    End Sub

    Private Sub loadReason()

        Sql = "EXEC dbo.PT_GetBurstReasonCode "
        ds = db.selectQuery(Sql)

        If (ds.Tables(0).Rows.Count > 0) Then
            ComboBoxNewReason.DataSource = ds.Tables(0)
            ComboBoxNewReason.DisplayMember = "ReasonDesc"
            ComboBoxNewReason.ValueMember = "ReasonCode"
        End If

    End Sub

    Private Sub loadResult()

        Sql = "EXEC dbo.[PT_GetPT1000DataForAmendment] '" & sLogonUser & "' "

        ds = db.selectQuery(Sql)

        If (ds.Tables(0).Rows.Count > 0) Then
            ComboBoxResult.DataSource = ds.Tables(0)
            ComboBoxResult.DisplayMember = "GroupKey"
            ComboBoxResult.ValueMember = "RowKey"
        End If

    End Sub

    Private Sub ButtonAmend_Click(sender As Object, e As EventArgs) Handles ButtonAmend.Click

        If ComboBoxResult.Text <> "" And ComboBoxNewReason.SelectedValue <> "" Then
            Dim selected_value As String
            selected_value = ComboBoxResult.Text
            Dim parts As String() = selected_value.Split("@")
            Dim parts2 As String() = parts(3).Split("_")
            Sql = "EXEC dbo.[PT_UpdateResult] '" & Convert.ToString(ComboBoxResult.SelectedValue) & "','" & sLogonUser & "','" & ComboBoxNewReason.SelectedValue & "','" & TextBoxNewRemarks.Text & "','" & parts2(0) & "','" & parts(1) & "','" & parts(2) & "'"
            ds = db.selectQuery(Sql)

            MessageBox.Show("Result Has Been Updated !")
            Me.Close()

        Else

            MessageBox.Show("Please select result and reason to proceed amendment ")

        End If




    End Sub
End Class

Public Class MainForm
    Dim myPort As Array
    Public sBatchNoList() As String = New String(5) {}
    Public sSerialNoList() As String = New String(5) {}
    Public sIndividualBurstReason() As String = New String(5) {}
    Public sIndividualRemarks() As String = New String(5) {}
    Public lastrecordID As String = ""


    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sDBServer = "SGDEVBX" Then
            LabelEnv.Text = "V2 -> Development Enviroment"
        Else
            LabelEnv.Text = "V2 -> Production Enviroment"
        End If



        txtHDRRowKey.Visible = False
        grpboxCompletion.Visible = False
        SetRs232Parameters()
        myPort = IO.Ports.SerialPort.GetPortNames()
        'ComboBox1.Items.AddRange(myPort)
        GetBurstReasonsList()
        GETPT1000TestTypes()
        btnStart.Enabled = True
        txtworkarea.Text = sWorkArea
        txtSinglewall.Visible = False
        lblsinglewall.Visible = False
        lbllogonUser.Text = "User ID:" & sLogonUser
        btnCancelReader.Enabled = False
        ' rtbDataFromPT1000.ReadOnly = True
        If sWorkArea = "LAB" Then
            cmdMultiBatch.Enabled = True
            ButtonTruncate.Visible = True

        Else
            cmdMultiBatch.Enabled = False
            ButtonTruncate.Visible = False

        End If
        ' None
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        If Check4ValidInputs() Then
            StartDataRead()
        End If

    End Sub
    Private Function StartDataRead()

        ClosePort()
        SerialPort1.PortName = "COM" & PORTNO     ' ComboBox1.Text
        SerialPort1.BaudRate = BAUDRATE   'ComboBox2.Text
        SerialPort1.ReadTimeout = TIMEOUT
        SerialPort1.DataBits = DATABIT
        SerialPort1.Parity = DATAPARITY
        SerialPort1.StopBits = STOPBIT
        txtHDRRowKey.Text = ""
        If txtbatchno.Text <> "" Then
            Call EnableorDisableInputParameters(0)
            SerialPort1.Open()
            SerialPort1.Write("HELLO" & vbCr)
            LoadBatchAndSerialArray()
            Call CreateDataReaderHDRRecord(txtHDRRowKey.Text, sBatchNoList, Me.txtEquipment.Text, sSerialNoList, Me.cmbSterileType.Text, Me.txtTubingPart.Text, Me.txtSinglewall.Text, Me.sIndividualBurstReason, Me.sIndividualRemarks, Me.cmbTestType.SelectedValue, sWorkArea, Me.txtduedate.Text)
            txtHDRRowKey.Text = sNewRecordRowID
            btnCancelReader.Enabled = True
            Me.timerDataReader.Enabled = True
            Me.btnStart.Enabled = False
            ButtonReset.Enabled = False
        Else
            MsgBox("Missing or Invalid Serial/ Batch No.")
        End If
    End Function

    Private Sub ClosePort()
        SerialPort1.Close()
        Me.timerDataReader.Enabled = False
        'EnableorDisableInputParameters(1)
        'Button1.Enabled = True
        'Button2.Enabled = False
        'Button4.Enabled = False
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal ReceivedData As String) 'input from ReadExisting
        Dim bTestCompletionStatus As Boolean
        Dim nSearchPos As Integer
        Dim nLFPos As Integer
        If rtbDataFromPT1000.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(ReceivedData)})
        Else
            ' Me.rtbDataFromPT1000.Text &= ReceivedData 'append text
            Me.rtbDataFromPT1000.AppendText(ReceivedData) 'append text
        End If
        'End Test

        If InStr(Me.rtbDataFromPT1000.ToString, "End Test") > 0 Then
            bTestCompletionStatus = True
        Else
            bTestCompletionStatus = False
        End If
        'MsgBox(ReceivedData.ToString)
        ' Call CreateDataReaderDetailRecord(ReceivedData.ToString)
    End Sub
    Private Function Check4ValidInputs() As Boolean
        Dim sBatchnofromserialno As String
        Dim nErrorCount As Integer

        On Error GoTo ErrHandle

        nErrorCount = 0
        txtserial01.BackColor = Color.White
        txtbatch01.BackColor = Color.White
        txtserial02.BackColor = Color.White
        txtbatch02.BackColor = Color.White
        txtserial03.BackColor = Color.White
        txtbatch03.BackColor = Color.White
        txtserial04.BackColor = Color.White
        txtbatch04.BackColor = Color.White
        txtserial05.BackColor = Color.White
        txtbatch05.BackColor = Color.White

        If Not (txtserial01.Text = "" And txtbatch01.Text = "") Then
            sBatchnofromserialno = ValidateSerialOrBatchDetails(txtserial01.Text, txtbatch01.Text)
            If sBatchnofromserialno = "" And txtbatch01.Text <> "N.A" Then
                txtserial01.BackColor = Color.Red
                txtbatch01.BackColor = Color.Red
                nErrorCount = nErrorCount + 1
                MsgBox("Invalid Batch/Serial No.")
            Else
                txtserialno.Text = txtserial01.Text
                txtbatchno.Text = txtbatch01.Text
                nErrorCount = 0
            End If
        Else
            nErrorCount = 1
        End If
        If Not (txtserial02.Text = "" And txtbatch02.Text = "") Then
            sBatchnofromserialno = ValidateSerialOrBatchDetails(txtserial02.Text, txtbatch02.Text)
            If sBatchnofromserialno = "" Then
                txtserial02.BackColor = Color.Red
                txtbatch02.BackColor = Color.Red
                nErrorCount = nErrorCount + 1
                MsgBox("Invalid Batch/Serial No.")
            End If
        End If
        If Not (txtserial03.Text = "" And txtbatch03.Text = "") Then
            sBatchnofromserialno = ValidateSerialOrBatchDetails(txtserial03.Text, txtbatch03.Text)
            If sBatchnofromserialno = "" Then
                txtserial03.BackColor = Color.Red
                txtbatch03.BackColor = Color.Red
                nErrorCount = nErrorCount + 1
                MsgBox("Invalid Batch/Serial No.")
            End If
        End If
        If Not (txtserial04.Text = "" And txtbatch04.Text = "") Then
            sBatchnofromserialno = ValidateSerialOrBatchDetails(txtserial04.Text, txtbatch04.Text)
            If sBatchnofromserialno = "" Then
                txtserial04.BackColor = Color.Red
                txtbatch04.BackColor = Color.Red
                nErrorCount = nErrorCount + 1
                MsgBox("Invalid Batch/Serial No.")
            End If
        End If
        If Not (txtserial05.Text = "" And txtbatch05.Text = "") Then
            sBatchnofromserialno = ValidateSerialOrBatchDetails(txtserial05.Text, txtbatch05.Text)
            If sBatchnofromserialno = "" Then
                txtserial05.BackColor = Color.Red
                txtbatch05.BackColor = Color.Red
                nErrorCount = nErrorCount + 1
                MsgBox("Invalid Batch/Serial No.")
            End If
        End If
        If (txtbatch01.Text = "" And txtbatch02.Text = "" And txtbatch04.Text = "" And txtbatch04.Text = "" And txtbatch05.Text = "") Then
            MsgBox("Alteast one Batch No is required")
            nErrorCount = nErrorCount + 1
        End If
        If (txtEquipment.Text = "" Or GetEquipmentDetails() = False) Then
            MsgBox("Equipment ID is Mandatory / Entered Equipment ID is not valid")
            nErrorCount = nErrorCount + 1
        End If

        If (cmbSterileType.Text = "") Then
            MsgBox("Sterilization Type is required. ")
            nErrorCount = nErrorCount + 1
        End If

        'If (cmbTestType.Text = "") Then
        '    MsgBox("Test Type is required. ")
        '    nErrorCount = nErrorCount + 1
        'End If

        'If (txtTubingPart.Text = "") Then
        '    MsgBox("Tubing Part cannot be blank. ")
        '    nErrorCount = nErrorCount + 1
        'End If

        If nErrorCount = 0 Then
            Check4ValidInputs = True
        Else
            Check4ValidInputs = False
        End If
        Exit Function
ErrHandle:
        MsgBox("Module : Check4ValidInputs " & vbCrLf & Err.Description)
        Check4ValidInputs = False
    End Function
    Private Sub EnableorDisableInputParameters(ByVal EnableOrDisable As Integer)
        Dim bEnableOrDisableControl As Boolean
        If EnableOrDisable = 1 Then
            bEnableOrDisableControl = True
            Me.rtbDataFromPT1000.BackColor = Color.White
            ClearSerialAndBatchBoxes()
        Else
            bEnableOrDisableControl = False
            Me.rtbDataFromPT1000.BackColor = Color.Yellow
        End If
        txtbatchno.Enabled = bEnableOrDisableControl
        'txtfgpart.Enabled = bEnableOrDisableControl
        'txtfgpartdesc.Enabled = bEnableOrDisableControl
        txtserialno.Enabled = bEnableOrDisableControl
        txtEquipment.Enabled = bEnableOrDisableControl
        txtSinglewall.Enabled = bEnableOrDisableControl
        txtTubingPart.Enabled = bEnableOrDisableControl
        cmbSterileType.Enabled = bEnableOrDisableControl
        grpboxMultiBatch.Enabled = bEnableOrDisableControl
        btnlogoff.Enabled = bEnableOrDisableControl
        cmbTestType.Enabled = bEnableOrDisableControl
    End Sub
    Private Sub ClearSerialAndBatchBoxes()
        txtserial01.Text = ""
        txtserial02.Text = ""
        txtserial03.Text = ""
        txtserial04.Text = ""
        txtserial05.Text = ""

        txtbatch01.Text = ""
        txtbatch02.Text = ""
        txtbatch03.Text = ""
        txtbatch04.Text = ""
        txtbatch05.Text = ""

        lblreason01.Text = txtbatch01.Text & "/" & txtserial01.Text
        lblreason02.Text = txtbatch02.Text & "/" & txtserial02.Text
        lblreason03.Text = txtbatch03.Text & "/" & txtserial03.Text
        lblreason04.Text = txtbatch04.Text & "/" & txtserial04.Text
        lblreason05.Text = txtbatch05.Text & "/" & txtserial05.Text


        txtbatch01.Enabled = True
        txtbatch02.Enabled = True
        txtbatch03.Enabled = True
        txtbatch04.Enabled = True
        txtbatch05.Enabled = True

    End Sub
    Private Function LoadBatchAndSerialArray()



        sBatchNoList(1) = txtbatch01.Text
        sBatchNoList(2) = txtbatch02.Text
        sBatchNoList(3) = txtbatch03.Text
        sBatchNoList(4) = txtbatch04.Text
        sBatchNoList(5) = txtbatch05.Text

        sSerialNoList(1) = txtserial01.Text
        sSerialNoList(2) = txtserial02.Text
        sSerialNoList(3) = txtserial03.Text
        sSerialNoList(4) = txtserial04.Text
        sSerialNoList(5) = txtserial05.Text


    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetBatchRelatedData()
    End Sub
    Private Function SetBatchRelatedData()
        Call ValidateSerialOrBatchDetails(Me.txtserialno.Text, Me.txtbatchno.Text)
        cmbBurstReason.SelectedValue = ""
        cmbburstreason02.SelectedValue = ""
        cmbBurstReason03.SelectedValue = ""
        cmbBurstReason04.SelectedValue = ""
        cmbBurstReason05.SelectedValue = ""

        rtbFinalRemarks.Text = ""
        rtbFinalRemarks02.Text = ""
        rtbFinalRemarks03.Text = ""
        rtbFinalRemarks04.Text = ""
        rtbFinalRemarks05.Text = ""

    End Function


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        grpboxCompletion.Visible = True
        Call SaveTestResults()
    End Sub

    Private Sub timerDataReader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerDataReader.Tick

        Dim nSearchPos As Integer = 0
        Dim nLFPos As Integer = 0
        If rtbDataFromPT1000.Text.ToString <> "" Then
            'If txttestType.Text = "" Then
            '    nSearchPos = InStr(Me.rtbDataFromPT1000.Text.ToString, "Test type:")
            '    nLFPos = InStr(Me.rtbDataFromPT1000.ToString, vbLf)

            '    If nSearchPos > 0 Then
            '        txttestType.Text = Mid(Me.rtbDataFromPT1000.Text.ToString, nSearchPos + 10, IIf((nLFPos - 1) <= 0, 1, (nLFPos - 1)))
            '    End If
            'End If


            If InStr(Me.rtbDataFromPT1000.Text, "Cycle hh:mm:ss") > 0 Then
                btnCancelReader.Enabled = False
            End If
            If InStr(Me.rtbDataFromPT1000.Text, "End Test") > 0 Then
                Me.timerDataReader.Enabled = False
                ClosePort()
                Me.rtbDataFromPT1000.BackColor = Color.GreenYellow

                nSearchPos = 0
                nLFPos = 0

                If rtbDataFromPT1000.Text.ToString <> "" Then
                    If txttestType.Text = "" Then
                        nSearchPos = InStr(Me.rtbDataFromPT1000.Text.ToString, "Test type:")
                        nLFPos = InStr(Me.rtbDataFromPT1000.ToString, vbLf)

                        If nSearchPos > 0 Then
                            cmbTestType.SelectedValue = Mid(Me.rtbDataFromPT1000.Text.ToString, nSearchPos + 10, IIf((nLFPos - 1) <= 0, 1, (nLFPos - 1)))
                        End If
                    End If
                End If
                'If MsgBox("Test Completed. Press OK to SAVE the data", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                Call RefreshReasonCodeControls()
                grpboxCompletion.Visible = True
                'Call SaveTestResults()
                'Call CreateDataReaderHDRRecord(txtHDRRowKey.Text, Me.txtbatchno.Text, Me.txtEquipment.Text, Me.txtserialno.Text, Me.cmbSterileType.Text, Me.txtTubingPart.Text, Me.txtSinglewall.Text, "")
                'End If
            End If
        End If
    End Sub

    Private Function RefreshReasonCodeControls()
        If txtserial01.Text = "" And txtbatch01.Text = "" Then
            lblreason01.Text = txtbatch01.Text & "/" & txtserial01.Text
            lblreason01.Visible = False
            rtbFinalRemarks.Visible = False
            cmbBurstReason.Visible = False
        Else
            lblreason01.Text = txtbatch01.Text & "/" & txtserial01.Text
            lblreason01.Visible = True
            rtbFinalRemarks.Visible = True
            cmbBurstReason.Visible = True
        End If

        If txtserial02.Text = "" And txtbatch02.Text = "" Then
            lblreason02.Text = txtbatch02.Text & "/" & txtserial02.Text
            lblreason02.Visible = False
            rtbFinalRemarks02.Visible = False
            cmbBurstReason02.Visible = False
        Else
            lblreason02.Text = txtbatch02.Text & "/" & txtserial02.Text
            lblreason02.Visible = True
            rtbFinalRemarks02.Visible = True
            cmbBurstReason02.Visible = True
        End If

        If txtserial03.Text = "" And txtbatch03.Text = "" Then
            lblreason03.Text = txtbatch03.Text & "/" & txtserial03.Text
            lblreason03.Visible = False
            rtbFinalRemarks03.Visible = False
            cmbBurstReason03.Visible = False
        Else
            lblreason03.Text = txtbatch03.Text & "/" & txtserial03.Text
            lblreason03.Visible = True
            rtbFinalRemarks03.Visible = True
            cmbBurstReason03.Visible = True
        End If

        If txtserial04.Text = "" And txtbatch04.Text = "" Then
            lblreason04.Text = txtbatch04.Text & "/" & txtserial04.Text
            lblreason04.Visible = False
            rtbFinalRemarks04.Visible = False
            cmbBurstReason04.Visible = False
        Else
            lblreason04.Text = txtbatch04.Text & "/" & txtserial04.Text
            lblreason04.Visible = True
            rtbFinalRemarks04.Visible = True
            cmbBurstReason04.Visible = True
        End If

        If txtserial05.Text = "" And txtbatch05.Text = "" Then
            lblreason05.Text = txtbatch05.Text & "/" & txtserial05.Text
            lblreason05.Visible = False
            rtbFinalRemarks05.Visible = False
            cmbBurstReason05.Visible = False
        Else
            lblreason05.Text = txtbatch05.Text & "/" & txtserial05.Text
            lblreason05.Visible = True
            rtbFinalRemarks05.Visible = True
            cmbBurstReason05.Visible = True
        End If


    End Function
    Private Function SaveTestResults()
        Dim PT1000DataLine() As String
        Dim lineID As Integer
        Dim NextLineStr As String

        'GrpboxMain.Enabled = False
        'grpboxCompletion.Visible = True

        If Me.rtbDataFromPT1000.Text <> "" Then
            PT1000DataLine = Split(Me.rtbDataFromPT1000.Text, vbLf)
            For lineID = 0 To UBound(PT1000DataLine)
                NextLineStr = PT1000DataLine(lineID)
                If NextLineStr <> "" Then
                    Call CreateDataReaderDetailRecord(Me.txtHDRRowKey.Text, lineID, NextLineStr)
                End If
            Next
        End If
        EnableorDisableInputParameters(1)
    End Function


    Private Sub txtserialno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserialno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ValidateSerialNoChange(1, txtserial01.Text, txtbatchno.Text)
        End If
    End Sub

    Private Function ValidateSerialNoChange(ByVal nSequenceNo As Integer, ByVal sSerialNo As String, ByVal sBatchNo As String)

        Dim sBatchNoFromSerialNo As String

        sBatchNoFromSerialNo = ValidateSerialOrBatchDetails(sSerialNo, sBatchNo)

        Select Case nSequenceNo
            Case 1
                If sSerialNo = "" Then
                    txtbatchno.Enabled = True
                    'txtbatchno.Focus()
                    txtbatch01.Enabled = True
                    txtbatch01.Focus()

                Else
                    txtbatch01.Text = sBatchNoFromSerialNo
                    txtbatchno.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatchno.Enabled = False
                        txtbatch01.Enabled = False
                    Else
                        txtbatchno.Enabled = True
                        txtbatch01.Enabled = True
                    End If
                End If

            Case 2
                If sSerialNo = "" Then
                    txtbatch02.Enabled = True
                    txtbatch02.Focus()
                Else
                    txtbatch02.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatch02.Enabled = False
                    Else
                        txtbatch02.Enabled = True
                    End If
                End If
            Case 3
                If sSerialNo = "" Then
                    txtbatch03.Enabled = True
                    txtbatch03.Focus()
                Else
                    txtbatch03.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatch03.Enabled = False
                    Else
                        txtbatch03.Enabled = True
                    End If
                End If

            Case 4
                If sSerialNo = "" Then
                    txtbatch04.Enabled = True
                    txtbatch04.Focus()
                Else
                    txtbatch04.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatch04.Enabled = False
                    Else
                        txtbatch04.Enabled = True
                    End If
                End If

            Case 5
                If sSerialNo = "" Then
                    txtbatch05.Enabled = True
                    txtbatch05.Focus()
                Else
                    txtbatch05.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatch05.Enabled = False
                    Else
                        txtbatch05.Enabled = True
                    End If
                End If
            Case Else
                If sSerialNo = "" Then
                    txtbatchno.Enabled = True
                    txtbatchno.Focus()
                Else
                    txtbatchno.Text = sBatchNoFromSerialNo
                    If sBatchNoFromSerialNo <> "" Then
                        txtbatchno.Enabled = False
                    Else
                        txtbatchno.Enabled = True
                    End If
                End If

        End Select
    End Function

    Private Function ValidateSerialOrBatchDetails(ByVal sInputSerialNo As String, ByVal sInputBatch As String) As String
        ValidateSerialOrBatchDetails = ""
        txtfgpart.Text = ""
        txtfgpartdesc.Text = ""
        'txtTubingPart.Text = ""



        If Not (sInputSerialNo = "" And sInputBatch = "") Then
            Sql = "EXEC PT_SPGetWorkOrderDetails '" & sInputSerialNo & "', '" & sInputBatch & "' "
            ds = db.selectQuery_Material(Sql)
            If Not (ds Is Nothing) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    'txtbatchno.Text = ds.Tables(0).Rows(0).Item("batchno").ToString()
                    txtfgpart.Text = ds.Tables(0).Rows(0).Item("Material").ToString()
                    txtfgpartdesc.Text = ds.Tables(0).Rows(0).Item("MaterialDesc").ToString()
                    ValidateSerialOrBatchDetails = ds.Tables(0).Rows(0).Item("batchno").ToString()
                    'txtTubingPart.Text = ds.Tables(0).Rows(0).Item("TubingPart").ToString()
                    'txtTubingPart.Focus()
                Else
                    txtfgpart.Text = ""
                    txtfgpartdesc.Text = ""
                    'txtTubingPart.Text = ""
                    'MsgBox("Serial No/ Batch No doesn't exists", MsgBoxStyle.Critical)
                    ValidateSerialOrBatchDetails = ""
                    'txtbatchno.Focus()
                End If
            End If
        End If
    End Function

    Private Sub GetBurstReasonsList()
        Dim ds02, ds03, ds04, ds05 As DataSet

        Sql = "EXEC dbo.PT_GetBurstReasonCode "
        ds = db.selectQuery(Sql)
        ds02 = db.selectQuery(Sql)
        ds03 = db.selectQuery(Sql)
        ds04 = db.selectQuery(Sql)
        ds05 = db.selectQuery(Sql)

        If (ds.Tables(0).Rows.Count > 0) Then
            cmbBurstReason.DataSource = ds.Tables(0)
            cmbBurstReason.DisplayMember = "ReasonDesc"
            cmbBurstReason.ValueMember = "ReasonCode"

            cmbBurstReason02.DataSource = ds02.Tables(0)
            cmbBurstReason02.DisplayMember = "ReasonDesc"
            cmbBurstReason02.ValueMember = "ReasonCode"

            cmbBurstReason03.DataSource = ds03.Tables(0)
            cmbBurstReason03.DisplayMember = "ReasonDesc"
            cmbBurstReason03.ValueMember = "ReasonCode"

            cmbBurstReason04.DataSource = ds04.Tables(0)
            cmbBurstReason04.DisplayMember = "ReasonDesc"
            cmbBurstReason04.ValueMember = "ReasonCode"

            cmbBurstReason05.DataSource = ds05.Tables(0)
            cmbBurstReason05.DisplayMember = "ReasonDesc"
            cmbBurstReason05.ValueMember = "ReasonCode"

            txtTubingPart.Focus()

        Else
            ' MsgBox("Serial No/ Batch No doesn't exists", MsgBoxStyle.Critical)
            'txtbatchno.Focus()
        End If

    End Sub

    Private Sub GetPT1000TestTypes()
        Sql = "EXEC dbo.PT_GetTestTypes "
        ds = db.selectQuery(Sql)
        If (ds.Tables(0).Rows.Count > 0) Then
            If (ds.Tables(0).Rows.Count > 0) Then
                cmbTestType.DataSource = ds.Tables(0)
                cmbTestType.DisplayMember = "TestTypeDesc"
                cmbTestType.ValueMember = "TestTypeCode"
            End If
        Else
            ' MsgBox("Serial No/ Batch No doesn't exists", MsgBoxStyle.Critical)
            'txtbatchno.Focus()
        End If

    End Sub

    Private Function GetEquipmentDetails() As Boolean
        If txtduedate.Text = "" Then
            GetEquipmentDetails = False
            Sql = "EXEC dbo.[GetEquipmentDetails] '" & txtEquipment.Text & "' "
            ds = db.selectQuery(Sql)
            If Not (ds Is Nothing) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    txtduedate.Text = ds.Tables(0).Rows(0).Item("DueDateString").ToString()
                    GetEquipmentDetails = True
                Else
                    'MsgBox("Equipment ID." & txtEquipment.Text & " doesnot Exist")
                    txtduedate.Text = ""
                    GetEquipmentDetails = False
                End If
            Else
                'MsgBox("Equipment ID :" & txtEquipment.Text & " doesnot Exist")
                txtEquipment.Text = ""
                GetEquipmentDetails = False
            End If
        Else
            GetEquipmentDetails = True
        End If


    End Function

    Private Sub btnconfirmsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmsave.Click

        btnconfirmsave.Enabled = False
        Call SaveTestResults()
        Call AssignBurstReasonAndRemarks()
        Call CreateDataReaderHDRRecord(txtHDRRowKey.Text, sBatchNoList, Me.txtEquipment.Text, sSerialNoList, Me.cmbSterileType.Text, Me.txtTubingPart.Text, Me.txtSinglewall.Text, Me.sIndividualBurstReason, Me.sIndividualRemarks, Me.cmbTestType.SelectedValue, sWorkArea, Me.txtduedate.Text)
        grpboxCompletion.Visible = False
        GrpboxMain.Enabled = True
        lastrecordID = txtHDRRowKey.Text
        btnconfirmsave.Enabled = True
        ClosePort()
        InitializeNewTest()
        'If MsgBox("Proceed to print report ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

        'End If
    End Sub

    Private Sub AssignBurstReasonAndRemarks()

        sIndividualBurstReason(1) = cmbBurstReason.SelectedValue.ToString
        If Not cmbburstreason02.SelectedValue = Nothing Then
            sIndividualBurstReason(2) = cmbburstreason02.SelectedValue.ToString
        Else
            sIndividualBurstReason(2) = ""
        End If

        If Not cmbBurstReason03.SelectedValue = Nothing Then
            sIndividualBurstReason(3) = cmbBurstReason03.SelectedValue.ToString
        Else
            sIndividualBurstReason(3) = ""
        End If

        If Not cmbBurstReason04.SelectedValue = Nothing Then
            sIndividualBurstReason(4) = cmbBurstReason04.SelectedValue.ToString
        Else
            sIndividualBurstReason(4) = ""
        End If

        If Not cmbBurstReason05.SelectedValue = Nothing Then
            sIndividualBurstReason(5) = cmbBurstReason05.SelectedValue.ToString
        Else
            sIndividualBurstReason(5) = ""
        End If

        'sIndividualBurstReason(3) = IIf(cmbBurstReason03.SelectedValue = Nothing, "", cmbBurstReason03.SelectedValue.ToString)
        'sIndividualBurstReason(4) = cmbBurstReason04.SelectedValue.ToString
        'sIndividualBurstReason(5) = cmbBurstReason05.SelectedValue.ToString

        sIndividualRemarks(1) = rtbFinalRemarks.Text
        sIndividualRemarks(2) = rtbFinalRemarks02.Text
        sIndividualRemarks(3) = rtbFinalRemarks03.Text
        sIndividualRemarks(4) = rtbFinalRemarks04.Text
        sIndividualRemarks(5) = rtbFinalRemarks05.Text


    End Sub

    Private Sub InitializeNewTest()
        'ClosePort()
        txtbatchno.Text = ""
        txtbatch01.Text = ""
        txtserial01.Text = ""
        txtfgpart.Text = ""
        txtfgpartdesc.Text = ""
        txtserialno.Text = ""
        'txtEquipment.Text = ""
        txtSinglewall.Text = ""
        txtTubingPart.Text = ""
        rtbDataFromPT1000.Text = ""
        rtbFinalRemarks.Text = ""
        btnCancelReader.Enabled = False
        btnStart.Enabled = True
        ButtonReset.Enabled = True
        cmbBurstReason.SelectedValue = ""
        cmbBurstReason02.SelectedValue = ""
        cmbBurstReason03.SelectedValue = ""
        cmbBurstReason04.SelectedValue = ""
        cmbBurstReason05.SelectedValue = ""

        rtbFinalRemarks.Text = ""
        rtbFinalRemarks02.Text = ""
        rtbFinalRemarks03.Text = ""
        rtbFinalRemarks04.Text = ""
        rtbFinalRemarks05.Text = ""
        btnCancelReader.Enabled = False

        Me.rtbDataFromPT1000.BackColor = Color.White
        EnableorDisableInputParameters(1)
    End Sub

    Private Sub txtbatchno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbatchno.DoubleClick
        'MsgBox("Multiple Batches")
    End Sub

    Private Sub txtbatch01_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbatchno.LostFocus
        SetBatchRelatedData()
    End Sub

    Private Sub txtbatchno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbatchno.TextChanged
        txtbatch01.Text = txtbatchno.Text
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        'grpboxMultiBatch.Visible = False
        'AssignMultipleSerialBatches()
    End Sub

    Private Sub cmdMultiBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiBatch.Click
        If grpboxMultiBatch.Visible = False Then
            grpboxMultiBatch.Visible = True
            cmdMultiBatch.Text = "^^^"
        Else
            grpboxMultiBatch.Visible = False
            cmdMultiBatch.Text = "vvv"
        End If
    End Sub

    Private Sub txtserialno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserialno.LostFocus
        txtserial01.Text = txtserialno.Text
        ValidateSerialNoChange(1, txtserialno.Text, txtbatchno.Text)
    End Sub

    Private Sub txtserial01_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserial01.LostFocus
        txtserialno.Text = txtserial01.Text
        ValidateSerialNoChange(1, txtserial01.Text, txtbatch01.Text)
    End Sub

    Private Sub txtserial02_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserial02.LostFocus
        ValidateSerialNoChange(2, txtserial02.Text, txtbatch02.Text)
    End Sub

    Private Sub txtserial03_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserial03.LostFocus
        ValidateSerialNoChange(3, txtserial03.Text, txtbatch03.Text)
    End Sub
    Private Sub txtserial04_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserial04.LostFocus
        ValidateSerialNoChange(4, txtserial04.Text, txtbatch04.Text)
    End Sub
    Private Sub txtserial05_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserial05.LostFocus
        ValidateSerialNoChange(5, txtserial05.Text, txtbatch05.Text)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportV.Show()
    End Sub

    Private Sub btnlogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogoff.Click
        If MsgBox("Are you sure to Log Off from this Session ? ", MsgBoxStyle.OkCancel, "Logoff Confirmation") = MsgBoxResult.Ok Then
            Me.Close()
            FrmLogin.Visible = True
            FrmLogin.Focus()
        End If
    End Sub

    Private Sub txtEquipment_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEquipment.LostFocus
        ' Get Maintenance Due Date
        If GetEquipmentDetails() Then
            'If Check4ValidInputs() Then
            '    StartDataRead()
            'End If
        Else
            'txtEquipment.Focus()
        End If
    End Sub

    Private Sub btnCancelReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelReader.Click
        MsgBox("Warning !!! The data will be discarded and will not be Saved", MsgBoxStyle.Critical)
        If MsgBox("Are you sure to Abort & Ignore the Test Results ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            rtbDataFromPT1000.Text = ""
            Me.timerDataReader.Enabled = False
            Me.btnStart.Enabled = True
            ButtonReset.Enabled = True

            InitializeNewTest()
            'If Check4ValidInputs() Then
            '    StartDataRead()
            'End If
        Else
            ' InitializeNewTest()
        End If
    End Sub

    Private Sub grpboxCompletion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpboxCompletion.Enter

    End Sub

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbFinalRemarks04.TextChanged

    End Sub

    Private Function Truncate_Long_BatchSerial(ByVal input) As Boolean

        If input.Length > 10 And sWorkArea = "LAB" Then
            Return True

            'Dim result As DialogResult = MessageBox.Show("Serial/Batch No. : " & input & " & seems too long. Do you want to truncate and take last 9 characters ?", "Title", MessageBoxButtons.YesNo)
            'If (result = DialogResult.Yes) Then
            '    Return True
            'Else
            '    Return False
            'End If
        Else
            Return False

        End If

    End Function

    Private Sub ButtonTruncate_Click(sender As Object, e As EventArgs) Handles ButtonTruncate.Click

        If Truncate_Long_BatchSerial(Me.txtserialno.Text) = True Then
            Me.txtserialno.Text = Me.txtserialno.Text.Substring(Me.txtserialno.TextLength - 9)
            Me.txtserial01.Text = Me.txtserialno.Text
        End If

        If Truncate_Long_BatchSerial(Me.txtbatchno.Text) = True Then
            If IsNumeric(txtbatchno.Text.Substring(txtbatchno.TextLength - 1)) = True Then
                txtbatchno.Text = txtbatchno.Text.Substring(txtbatchno.TextLength - 9)
                txtbatch01.Text = txtbatchno.Text
            Else
                txtbatchno.Text = txtbatchno.Text.Substring(txtbatchno.TextLength - 10)
                txtbatch01.Text = txtbatchno.Text
            End If
        End If


        If Truncate_Long_BatchSerial(Me.txtserial02.Text) = True Then
            Me.txtserial02.Text = Me.txtserial02.Text.Substring(Me.txtserial02.TextLength - 9)
        End If

        If Truncate_Long_BatchSerial(Me.txtbatch02.Text) = True Then
            If IsNumeric(txtbatch02.Text.Substring(txtbatch02.TextLength - 1)) = True Then
                txtbatch02.Text = txtbatch02.Text.Substring(txtbatch02.TextLength - 9)
            Else
                txtbatch02.Text = txtbatch02.Text.Substring(txtbatch02.TextLength - 10)
            End If
        End If

        If Truncate_Long_BatchSerial(Me.txtserial03.Text) = True Then
            Me.txtserial03.Text = Me.txtserial03.Text.Substring(Me.txtserial03.TextLength - 9)
        End If

        If Truncate_Long_BatchSerial(Me.txtbatch03.Text) = True Then
            If IsNumeric(txtbatch03.Text.Substring(txtbatch03.TextLength - 1)) = True Then
                txtbatch03.Text = txtbatch03.Text.Substring(txtbatch03.TextLength - 9)
            Else
                txtbatch03.Text = txtbatch03.Text.Substring(txtbatch03.TextLength - 10)
            End If
        End If

        If Truncate_Long_BatchSerial(Me.txtserial04.Text) = True Then
            Me.txtserial04.Text = Me.txtserial04.Text.Substring(Me.txtserial04.TextLength - 9)
        End If

        If Truncate_Long_BatchSerial(Me.txtbatch04.Text) = True Then
            If IsNumeric(txtbatch04.Text.Substring(txtbatch04.TextLength - 1)) = True Then
                txtbatch04.Text = txtbatch04.Text.Substring(txtbatch04.TextLength - 9)
            Else
                txtbatch04.Text = txtbatch04.Text.Substring(txtbatch04.TextLength - 10)
            End If
        End If


        If Truncate_Long_BatchSerial(Me.txtserial05.Text) = True Then
            Me.txtserial05.Text = Me.txtserial05.Text.Substring(Me.txtserial05.TextLength - 9)
        End If

        If Truncate_Long_BatchSerial(Me.txtbatch05.Text) = True Then
            If IsNumeric(txtbatch05.Text.Substring(txtbatch05.TextLength - 1)) = True Then
                txtbatch05.Text = txtbatch05.Text.Substring(txtbatch05.TextLength - 9)
            Else
                txtbatch05.Text = txtbatch05.Text.Substring(txtbatch05.TextLength - 10)
            End If
        End If




        ValidateSerialNoChange(1, txtserial01.Text, txtbatch01.Text)
        ValidateSerialNoChange(2, txtserial02.Text, txtbatch02.Text)
        ValidateSerialNoChange(3, txtserial03.Text, txtbatch03.Text)
        ValidateSerialNoChange(4, txtserial04.Text, txtbatch04.Text)
        ValidateSerialNoChange(5, txtserial05.Text, txtbatch05.Text)

        SetBatchRelatedData()
        MsgBox("All long batch/serial no have been truncated", MsgBoxStyle.Information)



    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        InitializeNewTest()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        FrmLogin.Visible = True
        FrmLogin.Focus()

    End Sub

    Private Sub cmbBurstReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBurstReason.SelectedIndexChanged

    End Sub

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        Admentment.Show()
    End Sub

    Private Sub LabelEnv_Click(sender As Object, e As EventArgs) Handles LabelEnv.Click

    End Sub
End Class

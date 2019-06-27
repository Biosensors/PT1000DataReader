<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GrpboxMain = New System.Windows.Forms.GroupBox()
        Me.ButtonTruncate = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.grpboxMultiBatch = New System.Windows.Forms.GroupBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.txtserial05 = New System.Windows.Forms.TextBox()
        Me.txtbatch05 = New System.Windows.Forms.TextBox()
        Me.txtserial04 = New System.Windows.Forms.TextBox()
        Me.txtHDRRowKey = New System.Windows.Forms.TextBox()
        Me.txtbatch04 = New System.Windows.Forms.TextBox()
        Me.txtbatch03 = New System.Windows.Forms.TextBox()
        Me.txtserial03 = New System.Windows.Forms.TextBox()
        Me.txtbatch02 = New System.Windows.Forms.TextBox()
        Me.txtserial02 = New System.Windows.Forms.TextBox()
        Me.txtbatch01 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblserialNo = New System.Windows.Forms.Label()
        Me.txtserial01 = New System.Windows.Forms.TextBox()
        Me.lblduedate = New System.Windows.Forms.Label()
        Me.cmdMultiBatch = New System.Windows.Forms.Button()
        Me.txttestType = New System.Windows.Forms.TextBox()
        Me.lbltesttype = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtEquipment = New System.Windows.Forms.TextBox()
        Me.lblequipment = New System.Windows.Forms.Label()
        Me.cmbSterileType = New System.Windows.Forms.ComboBox()
        Me.lbltubingpart = New System.Windows.Forms.Label()
        Me.lblsteriletype = New System.Windows.Forms.Label()
        Me.lblsinglewall = New System.Windows.Forms.Label()
        Me.txtTubingPart = New System.Windows.Forms.TextBox()
        Me.txtfgpartdesc = New System.Windows.Forms.TextBox()
        Me.txtSinglewall = New System.Windows.Forms.TextBox()
        Me.txtserialno = New System.Windows.Forms.TextBox()
        Me.txtfgpart = New System.Windows.Forms.TextBox()
        Me.lblfinalpart = New System.Windows.Forms.Label()
        Me.txtbatchno = New System.Windows.Forms.TextBox()
        Me.lblBatchNo = New System.Windows.Forms.Label()
        Me.cmbTestType = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.rtbDataFromPT1000 = New System.Windows.Forms.RichTextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.timerDataReader = New System.Windows.Forms.Timer(Me.components)
        Me.lblburstreason = New System.Windows.Forms.Label()
        Me.cmbBurstReason = New System.Windows.Forms.ComboBox()
        Me.grpboxCompletion = New System.Windows.Forms.GroupBox()
        Me.cmbburstreason02 = New System.Windows.Forms.ComboBox()
        Me.lblreason05 = New System.Windows.Forms.Label()
        Me.rtbFinalRemarks05 = New System.Windows.Forms.RichTextBox()
        Me.cmbBurstReason05 = New System.Windows.Forms.ComboBox()
        Me.lblreason04 = New System.Windows.Forms.Label()
        Me.rtbFinalRemarks04 = New System.Windows.Forms.RichTextBox()
        Me.cmbBurstReason04 = New System.Windows.Forms.ComboBox()
        Me.lblreason03 = New System.Windows.Forms.Label()
        Me.rtbFinalRemarks03 = New System.Windows.Forms.RichTextBox()
        Me.cmbBurstReason03 = New System.Windows.Forms.ComboBox()
        Me.lblreason02 = New System.Windows.Forms.Label()
        Me.rtbFinalRemarks02 = New System.Windows.Forms.RichTextBox()
        Me.lblreason01 = New System.Windows.Forms.Label()
        Me.btnconfirmsave = New System.Windows.Forms.Button()
        Me.rtbFinalRemarks = New System.Windows.Forms.RichTextBox()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlogoff = New System.Windows.Forms.Button()
        Me.lbllogonUser = New System.Windows.Forms.Label()
        Me.txtworkarea = New System.Windows.Forms.TextBox()
        Me.btnCancelReader = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.LabelEnv = New System.Windows.Forms.Label()
        Me.GrpboxMain.SuspendLayout()
        Me.grpboxMultiBatch.SuspendLayout()
        Me.grpboxCompletion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpboxMain
        '
        Me.GrpboxMain.Controls.Add(Me.ButtonTruncate)
        Me.GrpboxMain.Controls.Add(Me.ButtonReset)
        Me.GrpboxMain.Controls.Add(Me.txtduedate)
        Me.GrpboxMain.Controls.Add(Me.grpboxMultiBatch)
        Me.GrpboxMain.Controls.Add(Me.lblduedate)
        Me.GrpboxMain.Controls.Add(Me.cmdMultiBatch)
        Me.GrpboxMain.Controls.Add(Me.txttestType)
        Me.GrpboxMain.Controls.Add(Me.lbltesttype)
        Me.GrpboxMain.Controls.Add(Me.btnRefresh)
        Me.GrpboxMain.Controls.Add(Me.txtEquipment)
        Me.GrpboxMain.Controls.Add(Me.lblequipment)
        Me.GrpboxMain.Controls.Add(Me.cmbSterileType)
        Me.GrpboxMain.Controls.Add(Me.lbltubingpart)
        Me.GrpboxMain.Controls.Add(Me.lblsteriletype)
        Me.GrpboxMain.Controls.Add(Me.lblsinglewall)
        Me.GrpboxMain.Controls.Add(Me.txtTubingPart)
        Me.GrpboxMain.Controls.Add(Me.txtfgpartdesc)
        Me.GrpboxMain.Controls.Add(Me.txtSinglewall)
        Me.GrpboxMain.Controls.Add(Me.txtserialno)
        Me.GrpboxMain.Controls.Add(Me.txtfgpart)
        Me.GrpboxMain.Controls.Add(Me.lblfinalpart)
        Me.GrpboxMain.Controls.Add(Me.txtbatchno)
        Me.GrpboxMain.Controls.Add(Me.lblBatchNo)
        Me.GrpboxMain.Controls.Add(Me.cmbTestType)
        Me.GrpboxMain.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpboxMain.Location = New System.Drawing.Point(14, 12)
        Me.GrpboxMain.Name = "GrpboxMain"
        Me.GrpboxMain.Size = New System.Drawing.Size(1027, 250)
        Me.GrpboxMain.TabIndex = 0
        Me.GrpboxMain.TabStop = False
        '
        'ButtonTruncate
        '
        Me.ButtonTruncate.Location = New System.Drawing.Point(903, 15)
        Me.ButtonTruncate.Name = "ButtonTruncate"
        Me.ButtonTruncate.Size = New System.Drawing.Size(112, 48)
        Me.ButtonTruncate.TabIndex = 82
        Me.ButtonTruncate.Text = "Truncate Part/Serial No"
        Me.ButtonTruncate.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(808, 15)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(87, 48)
        Me.ButtonReset.TabIndex = 83
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'txtduedate
        '
        Me.txtduedate.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(654, 151)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(227, 24)
        Me.txtduedate.TabIndex = 96
        '
        'grpboxMultiBatch
        '
        Me.grpboxMultiBatch.Controls.Add(Me.btndone)
        Me.grpboxMultiBatch.Controls.Add(Me.txtserial05)
        Me.grpboxMultiBatch.Controls.Add(Me.txtbatch05)
        Me.grpboxMultiBatch.Controls.Add(Me.txtserial04)
        Me.grpboxMultiBatch.Controls.Add(Me.txtHDRRowKey)
        Me.grpboxMultiBatch.Controls.Add(Me.txtbatch04)
        Me.grpboxMultiBatch.Controls.Add(Me.txtbatch03)
        Me.grpboxMultiBatch.Controls.Add(Me.txtserial03)
        Me.grpboxMultiBatch.Controls.Add(Me.txtbatch02)
        Me.grpboxMultiBatch.Controls.Add(Me.txtserial02)
        Me.grpboxMultiBatch.Controls.Add(Me.txtbatch01)
        Me.grpboxMultiBatch.Controls.Add(Me.Label1)
        Me.grpboxMultiBatch.Controls.Add(Me.lblserialNo)
        Me.grpboxMultiBatch.Controls.Add(Me.txtserial01)
        Me.grpboxMultiBatch.Location = New System.Drawing.Point(24, 70)
        Me.grpboxMultiBatch.Name = "grpboxMultiBatch"
        Me.grpboxMultiBatch.Size = New System.Drawing.Size(1014, 174)
        Me.grpboxMultiBatch.TabIndex = 93
        Me.grpboxMultiBatch.TabStop = False
        Me.grpboxMultiBatch.Visible = False
        '
        'btndone
        '
        Me.btndone.Location = New System.Drawing.Point(466, 141)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(96, 27)
        Me.btndone.TabIndex = 29
        Me.btndone.Text = "Validate "
        Me.btndone.UseVisualStyleBackColor = True
        Me.btndone.Visible = False
        '
        'txtserial05
        '
        Me.txtserial05.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial05.Location = New System.Drawing.Point(825, 51)
        Me.txtserial05.Name = "txtserial05"
        Me.txtserial05.Size = New System.Drawing.Size(172, 24)
        Me.txtserial05.TabIndex = 31
        '
        'txtbatch05
        '
        Me.txtbatch05.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch05.Location = New System.Drawing.Point(825, 92)
        Me.txtbatch05.Name = "txtbatch05"
        Me.txtbatch05.Size = New System.Drawing.Size(172, 24)
        Me.txtbatch05.TabIndex = 41
        '
        'txtserial04
        '
        Me.txtserial04.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial04.Location = New System.Drawing.Point(646, 51)
        Me.txtserial04.Name = "txtserial04"
        Me.txtserial04.Size = New System.Drawing.Size(172, 24)
        Me.txtserial04.TabIndex = 29
        '
        'txtHDRRowKey
        '
        Me.txtHDRRowKey.Location = New System.Drawing.Point(691, -17)
        Me.txtHDRRowKey.Name = "txtHDRRowKey"
        Me.txtHDRRowKey.Size = New System.Drawing.Size(127, 23)
        Me.txtHDRRowKey.TabIndex = 81
        '
        'txtbatch04
        '
        Me.txtbatch04.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch04.Location = New System.Drawing.Point(646, 92)
        Me.txtbatch04.Name = "txtbatch04"
        Me.txtbatch04.Size = New System.Drawing.Size(172, 24)
        Me.txtbatch04.TabIndex = 39
        '
        'txtbatch03
        '
        Me.txtbatch03.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch03.Location = New System.Drawing.Point(467, 92)
        Me.txtbatch03.Name = "txtbatch03"
        Me.txtbatch03.Size = New System.Drawing.Size(172, 24)
        Me.txtbatch03.TabIndex = 37
        '
        'txtserial03
        '
        Me.txtserial03.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial03.Location = New System.Drawing.Point(467, 51)
        Me.txtserial03.Name = "txtserial03"
        Me.txtserial03.Size = New System.Drawing.Size(172, 24)
        Me.txtserial03.TabIndex = 27
        '
        'txtbatch02
        '
        Me.txtbatch02.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch02.Location = New System.Drawing.Point(285, 92)
        Me.txtbatch02.Name = "txtbatch02"
        Me.txtbatch02.Size = New System.Drawing.Size(172, 24)
        Me.txtbatch02.TabIndex = 35
        '
        'txtserial02
        '
        Me.txtserial02.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial02.Location = New System.Drawing.Point(285, 51)
        Me.txtserial02.Name = "txtserial02"
        Me.txtserial02.Size = New System.Drawing.Size(172, 24)
        Me.txtserial02.TabIndex = 25
        '
        'txtbatch01
        '
        Me.txtbatch01.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch01.Location = New System.Drawing.Point(100, 92)
        Me.txtbatch01.Name = "txtbatch01"
        Me.txtbatch01.Size = New System.Drawing.Size(172, 24)
        Me.txtbatch01.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Batch No"
        '
        'lblserialNo
        '
        Me.lblserialNo.AutoSize = True
        Me.lblserialNo.Location = New System.Drawing.Point(6, 54)
        Me.lblserialNo.Name = "lblserialNo"
        Me.lblserialNo.Size = New System.Drawing.Size(71, 16)
        Me.lblserialNo.TabIndex = 22
        Me.lblserialNo.Text = "Serial No"
        '
        'txtserial01
        '
        Me.txtserial01.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial01.Location = New System.Drawing.Point(102, 49)
        Me.txtserial01.Name = "txtserial01"
        Me.txtserial01.Size = New System.Drawing.Size(172, 24)
        Me.txtserial01.TabIndex = 21
        '
        'lblduedate
        '
        Me.lblduedate.AutoSize = True
        Me.lblduedate.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduedate.Location = New System.Drawing.Point(470, 154)
        Me.lblduedate.Name = "lblduedate"
        Me.lblduedate.Size = New System.Drawing.Size(143, 18)
        Me.lblduedate.TabIndex = 95
        Me.lblduedate.Text = "Calibration Due On"
        '
        'cmdMultiBatch
        '
        Me.cmdMultiBatch.Location = New System.Drawing.Point(454, 27)
        Me.cmdMultiBatch.Name = "cmdMultiBatch"
        Me.cmdMultiBatch.Size = New System.Drawing.Size(36, 27)
        Me.cmdMultiBatch.TabIndex = 84
        Me.cmdMultiBatch.Text = "vv"
        Me.cmdMultiBatch.UseVisualStyleBackColor = True
        '
        'txttestType
        '
        Me.txttestType.Enabled = False
        Me.txttestType.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttestType.Location = New System.Drawing.Point(130, 151)
        Me.txttestType.Name = "txttestType"
        Me.txttestType.Size = New System.Drawing.Size(77, 24)
        Me.txttestType.TabIndex = 83
        Me.txttestType.Visible = False
        '
        'lbltesttype
        '
        Me.lbltesttype.AutoSize = True
        Me.lbltesttype.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltesttype.Location = New System.Drawing.Point(23, 155)
        Me.lbltesttype.Name = "lbltesttype"
        Me.lbltesttype.Size = New System.Drawing.Size(77, 18)
        Me.lbltesttype.TabIndex = 82
        Me.lbltesttype.Text = "Test Type"
        Me.lbltesttype.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(706, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 48)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtEquipment
        '
        Me.txtEquipment.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipment.Location = New System.Drawing.Point(654, 112)
        Me.txtEquipment.Name = "txtEquipment"
        Me.txtEquipment.Size = New System.Drawing.Size(227, 24)
        Me.txtEquipment.TabIndex = 80
        '
        'lblequipment
        '
        Me.lblequipment.AutoSize = True
        Me.lblequipment.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblequipment.Location = New System.Drawing.Point(470, 118)
        Me.lblequipment.Name = "lblequipment"
        Me.lblequipment.Size = New System.Drawing.Size(108, 18)
        Me.lblequipment.TabIndex = 12
        Me.lblequipment.Text = "Equipment No"
        '
        'cmbSterileType
        '
        Me.cmbSterileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSterileType.FormattingEnabled = True
        Me.cmbSterileType.Items.AddRange(New Object() {"Sterile", "Non Sterile", "Not Applicable"})
        Me.cmbSterileType.Location = New System.Drawing.Point(222, 117)
        Me.cmbSterileType.Name = "cmbSterileType"
        Me.cmbSterileType.Size = New System.Drawing.Size(226, 24)
        Me.cmbSterileType.TabIndex = 70
        '
        'lbltubingpart
        '
        Me.lbltubingpart.AutoSize = True
        Me.lbltubingpart.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltubingpart.Location = New System.Drawing.Point(23, 184)
        Me.lbltubingpart.Name = "lbltubingpart"
        Me.lbltubingpart.Size = New System.Drawing.Size(94, 18)
        Me.lbltubingpart.TabIndex = 6
        Me.lbltubingpart.Text = "Tubing Part "
        Me.lbltubingpart.Visible = False
        '
        'lblsteriletype
        '
        Me.lblsteriletype.AutoSize = True
        Me.lblsteriletype.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsteriletype.Location = New System.Drawing.Point(23, 121)
        Me.lblsteriletype.Name = "lblsteriletype"
        Me.lblsteriletype.Size = New System.Drawing.Size(131, 18)
        Me.lblsteriletype.TabIndex = 10
        Me.lblsteriletype.Text = "Sterilization Type"
        '
        'lblsinglewall
        '
        Me.lblsinglewall.AutoSize = True
        Me.lblsinglewall.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsinglewall.Location = New System.Drawing.Point(470, 190)
        Me.lblsinglewall.Name = "lblsinglewall"
        Me.lblsinglewall.Size = New System.Drawing.Size(85, 18)
        Me.lblsinglewall.TabIndex = 9
        Me.lblsinglewall.Text = "Single Wall"
        '
        'txtTubingPart
        '
        Me.txtTubingPart.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTubingPart.Location = New System.Drawing.Point(221, 184)
        Me.txtTubingPart.Name = "txtTubingPart"
        Me.txtTubingPart.Size = New System.Drawing.Size(227, 24)
        Me.txtTubingPart.TabIndex = 50
        Me.txtTubingPart.Visible = False
        '
        'txtfgpartdesc
        '
        Me.txtfgpartdesc.Enabled = False
        Me.txtfgpartdesc.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfgpartdesc.Location = New System.Drawing.Point(497, 76)
        Me.txtfgpartdesc.Name = "txtfgpartdesc"
        Me.txtfgpartdesc.Size = New System.Drawing.Size(382, 24)
        Me.txtfgpartdesc.TabIndex = 40
        '
        'txtSinglewall
        '
        Me.txtSinglewall.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinglewall.Location = New System.Drawing.Point(654, 184)
        Me.txtSinglewall.Name = "txtSinglewall"
        Me.txtSinglewall.Size = New System.Drawing.Size(227, 24)
        Me.txtSinglewall.TabIndex = 60
        '
        'txtserialno
        '
        Me.txtserialno.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserialno.Location = New System.Drawing.Point(220, 26)
        Me.txtserialno.Name = "txtserialno"
        Me.txtserialno.Size = New System.Drawing.Size(227, 24)
        Me.txtserialno.TabIndex = 10
        '
        'txtfgpart
        '
        Me.txtfgpart.Enabled = False
        Me.txtfgpart.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfgpart.Location = New System.Drawing.Point(219, 76)
        Me.txtfgpart.Name = "txtfgpart"
        Me.txtfgpart.Size = New System.Drawing.Size(227, 24)
        Me.txtfgpart.TabIndex = 30
        '
        'lblfinalpart
        '
        Me.lblfinalpart.AutoSize = True
        Me.lblfinalpart.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinalpart.Location = New System.Drawing.Point(21, 76)
        Me.lblfinalpart.Name = "lblfinalpart"
        Me.lblfinalpart.Size = New System.Drawing.Size(61, 18)
        Me.lblfinalpart.TabIndex = 2
        Me.lblfinalpart.Text = "Part No"
        '
        'txtbatchno
        '
        Me.txtbatchno.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatchno.Location = New System.Drawing.Point(497, 26)
        Me.txtbatchno.Name = "txtbatchno"
        Me.txtbatchno.Size = New System.Drawing.Size(202, 24)
        Me.txtbatchno.TabIndex = 20
        '
        'lblBatchNo
        '
        Me.lblBatchNo.AutoSize = True
        Me.lblBatchNo.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatchNo.Location = New System.Drawing.Point(21, 31)
        Me.lblBatchNo.Name = "lblBatchNo"
        Me.lblBatchNo.Size = New System.Drawing.Size(130, 18)
        Me.lblBatchNo.TabIndex = 0
        Me.lblBatchNo.Text = "Serial No / Batch "
        '
        'cmbTestType
        '
        Me.cmbTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTestType.FormattingEnabled = True
        Me.cmbTestType.Location = New System.Drawing.Point(222, 151)
        Me.cmbTestType.Name = "cmbTestType"
        Me.cmbTestType.Size = New System.Drawing.Size(227, 24)
        Me.cmbTestType.TabIndex = 94
        Me.cmbTestType.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(1065, 268)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 62)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'rtbDataFromPT1000
        '
        Me.rtbDataFromPT1000.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDataFromPT1000.Location = New System.Drawing.Point(39, 285)
        Me.rtbDataFromPT1000.Name = "rtbDataFromPT1000"
        Me.rtbDataFromPT1000.ReadOnly = True
        Me.rtbDataFromPT1000.Size = New System.Drawing.Size(1027, 393)
        Me.rtbDataFromPT1000.TabIndex = 90
        Me.rtbDataFromPT1000.Text = ""
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1066, 383)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 31)
        Me.BtnSave.TabIndex = 91
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        Me.BtnSave.Visible = False
        '
        'timerDataReader
        '
        Me.timerDataReader.Interval = 3000
        '
        'lblburstreason
        '
        Me.lblburstreason.AutoSize = True
        Me.lblburstreason.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblburstreason.Location = New System.Drawing.Point(197, 34)
        Me.lblburstreason.Name = "lblburstreason"
        Me.lblburstreason.Size = New System.Drawing.Size(105, 18)
        Me.lblburstreason.TabIndex = 84
        Me.lblburstreason.Text = "Burst Reason"
        Me.lblburstreason.UseWaitCursor = True
        '
        'cmbBurstReason
        '
        Me.cmbBurstReason.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBurstReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBurstReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBurstReason.FormattingEnabled = True
        Me.cmbBurstReason.Location = New System.Drawing.Point(198, 67)
        Me.cmbBurstReason.Name = "cmbBurstReason"
        Me.cmbBurstReason.Size = New System.Drawing.Size(205, 25)
        Me.cmbBurstReason.TabIndex = 92
        '
        'grpboxCompletion
        '
        Me.grpboxCompletion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpboxCompletion.Controls.Add(Me.cmbburstreason02)
        Me.grpboxCompletion.Controls.Add(Me.lblreason05)
        Me.grpboxCompletion.Controls.Add(Me.rtbFinalRemarks05)
        Me.grpboxCompletion.Controls.Add(Me.cmbBurstReason05)
        Me.grpboxCompletion.Controls.Add(Me.lblreason04)
        Me.grpboxCompletion.Controls.Add(Me.rtbFinalRemarks04)
        Me.grpboxCompletion.Controls.Add(Me.cmbBurstReason04)
        Me.grpboxCompletion.Controls.Add(Me.lblreason03)
        Me.grpboxCompletion.Controls.Add(Me.rtbFinalRemarks03)
        Me.grpboxCompletion.Controls.Add(Me.cmbBurstReason03)
        Me.grpboxCompletion.Controls.Add(Me.lblreason02)
        Me.grpboxCompletion.Controls.Add(Me.rtbFinalRemarks02)
        Me.grpboxCompletion.Controls.Add(Me.lblreason01)
        Me.grpboxCompletion.Controls.Add(Me.btnconfirmsave)
        Me.grpboxCompletion.Controls.Add(Me.rtbFinalRemarks)
        Me.grpboxCompletion.Controls.Add(Me.lblremarks)
        Me.grpboxCompletion.Controls.Add(Me.cmbBurstReason)
        Me.grpboxCompletion.Controls.Add(Me.lblburstreason)
        Me.grpboxCompletion.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpboxCompletion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpboxCompletion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxCompletion.Location = New System.Drawing.Point(12, 23)
        Me.grpboxCompletion.Name = "grpboxCompletion"
        Me.grpboxCompletion.Size = New System.Drawing.Size(1181, 274)
        Me.grpboxCompletion.TabIndex = 92
        Me.grpboxCompletion.TabStop = False
        Me.grpboxCompletion.Text = "Select Burst Reason"
        '
        'cmbburstreason02
        '
        Me.cmbburstreason02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbburstreason02.FormattingEnabled = True
        Me.cmbburstreason02.Location = New System.Drawing.Point(198, 98)
        Me.cmbburstreason02.Name = "cmbburstreason02"
        Me.cmbburstreason02.Size = New System.Drawing.Size(205, 25)
        Me.cmbburstreason02.TabIndex = 110
        '
        'lblreason05
        '
        Me.lblreason05.AutoSize = True
        Me.lblreason05.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblreason05.Location = New System.Drawing.Point(18, 197)
        Me.lblreason05.Name = "lblreason05"
        Me.lblreason05.Size = New System.Drawing.Size(60, 15)
        Me.lblreason05.TabIndex = 109
        Me.lblreason05.Text = "Sample 1"
        Me.lblreason05.UseWaitCursor = True
        '
        'rtbFinalRemarks05
        '
        Me.rtbFinalRemarks05.Location = New System.Drawing.Point(409, 197)
        Me.rtbFinalRemarks05.Name = "rtbFinalRemarks05"
        Me.rtbFinalRemarks05.Size = New System.Drawing.Size(348, 31)
        Me.rtbFinalRemarks05.TabIndex = 108
        Me.rtbFinalRemarks05.Text = ""
        '
        'cmbBurstReason05
        '
        Me.cmbBurstReason05.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBurstReason05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBurstReason05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBurstReason05.FormattingEnabled = True
        Me.cmbBurstReason05.Location = New System.Drawing.Point(198, 197)
        Me.cmbBurstReason05.Name = "cmbBurstReason05"
        Me.cmbBurstReason05.Size = New System.Drawing.Size(205, 25)
        Me.cmbBurstReason05.TabIndex = 107
        '
        'lblreason04
        '
        Me.lblreason04.AutoSize = True
        Me.lblreason04.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblreason04.Location = New System.Drawing.Point(18, 163)
        Me.lblreason04.Name = "lblreason04"
        Me.lblreason04.Size = New System.Drawing.Size(60, 15)
        Me.lblreason04.TabIndex = 106
        Me.lblreason04.Text = "Sample 1"
        Me.lblreason04.UseWaitCursor = True
        '
        'rtbFinalRemarks04
        '
        Me.rtbFinalRemarks04.Location = New System.Drawing.Point(409, 163)
        Me.rtbFinalRemarks04.Name = "rtbFinalRemarks04"
        Me.rtbFinalRemarks04.Size = New System.Drawing.Size(348, 31)
        Me.rtbFinalRemarks04.TabIndex = 105
        Me.rtbFinalRemarks04.Text = ""
        '
        'cmbBurstReason04
        '
        Me.cmbBurstReason04.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBurstReason04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBurstReason04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBurstReason04.FormattingEnabled = True
        Me.cmbBurstReason04.Location = New System.Drawing.Point(198, 163)
        Me.cmbBurstReason04.Name = "cmbBurstReason04"
        Me.cmbBurstReason04.Size = New System.Drawing.Size(205, 25)
        Me.cmbBurstReason04.TabIndex = 104
        '
        'lblreason03
        '
        Me.lblreason03.AutoSize = True
        Me.lblreason03.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblreason03.Location = New System.Drawing.Point(18, 129)
        Me.lblreason03.Name = "lblreason03"
        Me.lblreason03.Size = New System.Drawing.Size(60, 15)
        Me.lblreason03.TabIndex = 103
        Me.lblreason03.Text = "Sample 1"
        Me.lblreason03.UseWaitCursor = True
        '
        'rtbFinalRemarks03
        '
        Me.rtbFinalRemarks03.Location = New System.Drawing.Point(409, 129)
        Me.rtbFinalRemarks03.Name = "rtbFinalRemarks03"
        Me.rtbFinalRemarks03.Size = New System.Drawing.Size(348, 31)
        Me.rtbFinalRemarks03.TabIndex = 102
        Me.rtbFinalRemarks03.Text = ""
        '
        'cmbBurstReason03
        '
        Me.cmbBurstReason03.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBurstReason03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBurstReason03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBurstReason03.FormattingEnabled = True
        Me.cmbBurstReason03.Location = New System.Drawing.Point(198, 129)
        Me.cmbBurstReason03.Name = "cmbBurstReason03"
        Me.cmbBurstReason03.Size = New System.Drawing.Size(205, 25)
        Me.cmbBurstReason03.TabIndex = 101
        '
        'lblreason02
        '
        Me.lblreason02.AutoSize = True
        Me.lblreason02.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblreason02.Location = New System.Drawing.Point(18, 98)
        Me.lblreason02.Name = "lblreason02"
        Me.lblreason02.Size = New System.Drawing.Size(60, 15)
        Me.lblreason02.TabIndex = 100
        Me.lblreason02.Text = "Sample 1"
        Me.lblreason02.UseWaitCursor = True
        '
        'rtbFinalRemarks02
        '
        Me.rtbFinalRemarks02.Location = New System.Drawing.Point(409, 98)
        Me.rtbFinalRemarks02.Name = "rtbFinalRemarks02"
        Me.rtbFinalRemarks02.Size = New System.Drawing.Size(348, 31)
        Me.rtbFinalRemarks02.TabIndex = 99
        Me.rtbFinalRemarks02.Text = ""
        '
        'lblreason01
        '
        Me.lblreason01.AutoSize = True
        Me.lblreason01.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblreason01.Location = New System.Drawing.Point(18, 67)
        Me.lblreason01.Name = "lblreason01"
        Me.lblreason01.Size = New System.Drawing.Size(60, 15)
        Me.lblreason01.TabIndex = 97
        Me.lblreason01.Text = "Sample 1"
        Me.lblreason01.UseWaitCursor = True
        '
        'btnconfirmsave
        '
        Me.btnconfirmsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmsave.Location = New System.Drawing.Point(365, 234)
        Me.btnconfirmsave.Name = "btnconfirmsave"
        Me.btnconfirmsave.Size = New System.Drawing.Size(111, 31)
        Me.btnconfirmsave.TabIndex = 96
        Me.btnconfirmsave.Text = "Save"
        Me.btnconfirmsave.UseVisualStyleBackColor = True
        '
        'rtbFinalRemarks
        '
        Me.rtbFinalRemarks.Location = New System.Drawing.Point(409, 67)
        Me.rtbFinalRemarks.Name = "rtbFinalRemarks"
        Me.rtbFinalRemarks.Size = New System.Drawing.Size(348, 31)
        Me.rtbFinalRemarks.TabIndex = 95
        Me.rtbFinalRemarks.Text = ""
        '
        'lblremarks
        '
        Me.lblremarks.AutoSize = True
        Me.lblremarks.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremarks.Location = New System.Drawing.Point(408, 34)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(70, 18)
        Me.lblremarks.TabIndex = 94
        Me.lblremarks.Text = "Remarks"
        Me.lblremarks.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1066, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnlogoff
        '
        Me.btnlogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoff.ForeColor = System.Drawing.Color.Red
        Me.btnlogoff.Location = New System.Drawing.Point(1047, 24)
        Me.btnlogoff.Name = "btnlogoff"
        Me.btnlogoff.Size = New System.Drawing.Size(112, 28)
        Me.btnlogoff.TabIndex = 94
        Me.btnlogoff.Text = "Log off"
        Me.btnlogoff.UseVisualStyleBackColor = True
        '
        'lbllogonUser
        '
        Me.lbllogonUser.AutoSize = True
        Me.lbllogonUser.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogonUser.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbllogonUser.Location = New System.Drawing.Point(973, 5)
        Me.lbllogonUser.Name = "lbllogonUser"
        Me.lbllogonUser.Size = New System.Drawing.Size(54, 15)
        Me.lbllogonUser.TabIndex = 95
        Me.lbllogonUser.Text = "User ID:"
        '
        'txtworkarea
        '
        Me.txtworkarea.Location = New System.Drawing.Point(1047, 89)
        Me.txtworkarea.Name = "txtworkarea"
        Me.txtworkarea.Size = New System.Drawing.Size(127, 19)
        Me.txtworkarea.TabIndex = 95
        Me.txtworkarea.Visible = False
        '
        'btnCancelReader
        '
        Me.btnCancelReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelReader.Location = New System.Drawing.Point(1069, 597)
        Me.btnCancelReader.Name = "btnCancelReader"
        Me.btnCancelReader.Size = New System.Drawing.Size(112, 62)
        Me.btnCancelReader.TabIndex = 96
        Me.btnCancelReader.Text = "Cancel "
        Me.btnCancelReader.UseVisualStyleBackColor = True
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Location = New System.Drawing.Point(1066, 420)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(111, 28)
        Me.ButtonAdmin.TabIndex = 97
        Me.ButtonAdmin.Text = "Admin"
        Me.ButtonAdmin.UseVisualStyleBackColor = True
        '
        'LabelEnv
        '
        Me.LabelEnv.AutoSize = True
        Me.LabelEnv.ForeColor = System.Drawing.Color.Red
        Me.LabelEnv.Location = New System.Drawing.Point(20, 5)
        Me.LabelEnv.Name = "LabelEnv"
        Me.LabelEnv.Size = New System.Drawing.Size(60, 13)
        Me.LabelEnv.TabIndex = 98
        Me.LabelEnv.Text = "LabelEnv"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 671)
        Me.Controls.Add(Me.LabelEnv)
        Me.Controls.Add(Me.ButtonAdmin)
        Me.Controls.Add(Me.btnCancelReader)
        Me.Controls.Add(Me.lbllogonUser)
        Me.Controls.Add(Me.txtworkarea)
        Me.Controls.Add(Me.btnlogoff)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpboxCompletion)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.rtbDataFromPT1000)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GrpboxMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "PT1000 - Data Collecter"
        Me.GrpboxMain.ResumeLayout(False)
        Me.GrpboxMain.PerformLayout()
        Me.grpboxMultiBatch.ResumeLayout(False)
        Me.grpboxMultiBatch.PerformLayout()
        Me.grpboxCompletion.ResumeLayout(False)
        Me.grpboxCompletion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpboxMain As System.Windows.Forms.GroupBox
    Friend WithEvents txtfgpart As System.Windows.Forms.TextBox
    Friend WithEvents lblfinalpart As System.Windows.Forms.Label
    Friend WithEvents txtbatchno As System.Windows.Forms.TextBox
    Friend WithEvents lblBatchNo As System.Windows.Forms.Label
    Friend WithEvents txtSinglewall As System.Windows.Forms.TextBox
    Friend WithEvents txtTubingPart As System.Windows.Forms.TextBox
    Friend WithEvents lbltubingpart As System.Windows.Forms.Label
    Friend WithEvents txtfgpartdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtserialno As System.Windows.Forms.TextBox
    Friend WithEvents lblsinglewall As System.Windows.Forms.Label
    Friend WithEvents cmbSterileType As System.Windows.Forms.ComboBox
    Friend WithEvents lblsteriletype As System.Windows.Forms.Label
    Friend WithEvents txtEquipment As System.Windows.Forms.TextBox
    Friend WithEvents lblequipment As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents rtbDataFromPT1000 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents timerDataReader As System.Windows.Forms.Timer
    Friend WithEvents txtHDRRowKey As System.Windows.Forms.TextBox
    Friend WithEvents txttestType As System.Windows.Forms.TextBox
    Friend WithEvents lbltesttype As System.Windows.Forms.Label
    Friend WithEvents cmbBurstReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblburstreason As System.Windows.Forms.Label
    Friend WithEvents grpboxCompletion As System.Windows.Forms.GroupBox
    Friend WithEvents rtbFinalRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents btnconfirmsave As System.Windows.Forms.Button
    Friend WithEvents cmdMultiBatch As System.Windows.Forms.Button
    Friend WithEvents grpboxMultiBatch As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblserialNo As System.Windows.Forms.Label
    Friend WithEvents txtserial01 As System.Windows.Forms.TextBox
    Friend WithEvents txtbatch03 As System.Windows.Forms.TextBox
    Friend WithEvents txtserial03 As System.Windows.Forms.TextBox
    Friend WithEvents txtbatch02 As System.Windows.Forms.TextBox
    Friend WithEvents txtserial02 As System.Windows.Forms.TextBox
    Friend WithEvents txtbatch01 As System.Windows.Forms.TextBox
    Friend WithEvents txtbatch04 As System.Windows.Forms.TextBox
    Friend WithEvents txtserial04 As System.Windows.Forms.TextBox
    Friend WithEvents txtbatch05 As System.Windows.Forms.TextBox
    Friend WithEvents txtserial05 As System.Windows.Forms.TextBox
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnlogoff As System.Windows.Forms.Button
    Friend WithEvents cmbTestType As System.Windows.Forms.ComboBox
    Friend WithEvents lbllogonUser As System.Windows.Forms.Label
    Friend WithEvents txtworkarea As System.Windows.Forms.TextBox
    Friend WithEvents txtduedate As System.Windows.Forms.TextBox
    Friend WithEvents lblduedate As System.Windows.Forms.Label
    Friend WithEvents btnCancelReader As System.Windows.Forms.Button
    Friend WithEvents lblreason01 As System.Windows.Forms.Label
    Friend WithEvents lblreason05 As System.Windows.Forms.Label
    Friend WithEvents rtbFinalRemarks05 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBurstReason05 As System.Windows.Forms.ComboBox
    Friend WithEvents lblreason04 As System.Windows.Forms.Label
    Friend WithEvents rtbFinalRemarks04 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBurstReason04 As System.Windows.Forms.ComboBox
    Friend WithEvents lblreason03 As System.Windows.Forms.Label
    Friend WithEvents rtbFinalRemarks03 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBurstReason03 As System.Windows.Forms.ComboBox
    Friend WithEvents lblreason02 As System.Windows.Forms.Label
    Friend WithEvents rtbFinalRemarks02 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbburstreason02 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonTruncate As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonAdmin As Button
    Friend WithEvents LabelEnv As Label
End Class

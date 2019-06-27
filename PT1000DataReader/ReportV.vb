Public Class ReportV
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private WithEvents crvreport As CrystalDecisions.Windows.Forms.CrystalReportViewer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crvreport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvreport
        '
        Me.crvreport.ActiveViewIndex = -1
        Me.crvreport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvreport.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crvreport.Location = New System.Drawing.Point(12, 33)
        Me.crvreport.Name = "crvreport"
        Me.crvreport.Size = New System.Drawing.Size(833, 400)
        Me.crvreport.TabIndex = 0
        '
        'ReportV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 475)
        Me.Controls.Add(Me.crvreport)
        Me.Name = "ReportV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIREVI - Biosensors Report Viewer 1.0"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim nHH, nWd As Double


    Private Sub ReportV_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        crvreport.Height = Me.Height - 50
        crvreport.Width = Me.Width - 30

    End Sub

    'Private Sub customizeToolbar()

    '    'This method creates a new toolbar button using the image from the old export button

    '    'It then removes the old export button. 

    '    'Declare a toolstrip
    '    Dim ts As ToolStrip

    '    'Assign the crystal toolstrip to ts
    '    ts = CType(crvreport.Controls(1), ToolStrip)

    '    'Declare a new tool strip button
    '    Dim PrintButton As New ToolStripButton

    '    'Set the image of the new button to be the same as the old export image
    '    PrintButton.Image = ts.Items(0).Image

    '    'Remove the old button
    '    ts.Items.Remove(ts.Items(0))

    '    'Add the new button at location 0
    '    ts.Items.Insert(0, PrintButton)

    '    AddHandler PrintButton.Click, AddressOf ExportClick
    'End Sub

    'Private Sub ExportClick(ByVal sender As Object, ByVal e As System.EventArgs)

    '    'Get the file name
    '    If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

    '        Dim exportOpts As New ExportOptions()
    '        Dim DiskOpts As New DiskFileDestinationOptions
    '        DiskOpts.DiskFileName = SaveFileDialog1.FileName

    '        exportOpts = crvreport.ReportSource.ExportOptions

    '        With exportOpts
    '            .ExportFormatType = ExportFormatType.PortableDocFormat
    '            .ExportDestinationType = ExportDestinationType.DiskFile
    '            .ExportDestinationOptions = DiskOpts
    '        End With

    '        DiskOpts.DiskFileName = SaveFileDialog1.FileName

    '        crvreport.ReportSource.Export()

    '    End If

    'End Sub


    Private Sub ReportV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim LoadLastRsesult As Integer = 0

        If MainForm.lastrecordID <> "" Then
            LoadLastRsesult = MessageBox.Show("Click Yes to retrieve last save result. Click No to proceed to report search screen.  ", "caption", MessageBoxButtons.YesNo)
        End If

        'Dim CrVDoc As New CrystalDecisions.Windows.Forms.ReportDocuments
        sRptFileName = ".\Reports\" & "PT1000_TestResults.rpt"
        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(sRptFileName)

        Try
            With rptDoc.DataSourceConnections(0)
                'Dim dbname As String = "BioTrack"               '.DatabaseName
                Dim Integrated As Boolean = True           '.IntegratedSecurity
                .SetConnection(sDBServer, sDBName, Integrated)
            End With

            rptDoc.Refresh()

            If LoadLastRsesult = DialogResult.Yes Then
                rptDoc.SetParameterValue("@sBatchNo", Nothing)
                rptDoc.SetParameterValue("@sSerialNo", Nothing)
                rptDoc.SetParameterValue("@sTestType", Nothing)
                rptDoc.SetParameterValue("@sOprnArea", MainForm.lastrecordID)
                rptDoc.SetParameterValue("@dRunDate", Nothing)
                rptDoc.SetParameterValue("@sIncludeDiscard", Nothing)
                rptDoc.SetParameterValue("@sPartNo", Nothing)


            End If


            crvreport.ReportSource = rptDoc

            'SetReport(rptDoc)
            'frm.Show()

        Catch ex As CrystalDecisions.CrystalReports.Engine.DataSourceException
            MessageBox.Show("Error Connecting to the Report Database")
        Catch ex As Exception
            MessageBox.Show("Error Returned from the Crystal Report, Please Check the Report")
        End Try
        'Me.Hide()
        'crvreport.ReportSource = sRptFileName    '& "\" & l & ".rpt"
        'Me.Show()
        crvreport.Show()

    End Sub

    Public Sub SetReport(ByVal rptDoc As _
        CrystalDecisions.CrystalReports.Engine.ReportDocument)
        crvreport.ReportSource = rptDoc
    End Sub

End Class

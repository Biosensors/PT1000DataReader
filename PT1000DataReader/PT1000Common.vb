Imports System.Data
Imports System.Data.SqlClient
Imports system.IO
Imports System

Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports System.Reflection
Imports System.IO.StreamWriter


Module PT1000Common

    Public db As New Class1
    Public sLogonUser As String
    Public sWorkArea As String
    Public sLogonAdmin As String
    Public domainUser As String
    Public sLoginCancel As String
    Public Username As String
    Public sDBServer As String
    Public sDBName As String
    Public UserFullName As String
    Public sConnectionServer As String
    Public sRptFileName As String
    Public INIFilePath As String
    Public version As String
    Public Sql As String
    Public ds As DataSet
    Public sVersion As String
    Public sUserID As String
    Public conn As New SqlConnection(sConnectionServer)
    Public strQuery As String
    Public BAUDRATE As Integer = 9600
    Public TIMEOUT As Integer = 1500
    Public PORTNO As Integer = 1
    Public DATAPARITY As Integer = 2
    Public DATABIT As Integer = 8
    Public STOPBIT As Integer = 0
    Public XONXOFF As Boolean = 1    'True
    Public iniFileName As String = "PT1000.ini"
    Public sNewRecordRowID As String
    Public dsL As New DataSet
    Dim datRow As DataRow
    'Public db As New Class1
    Public sMainWorkOrderNO As String
    Public sMainOperation As Integer
    'Public sLogonUser As String
    Public sUpdateMode As String
    Public sSerialNoList As String()
    Public sBatchList As String()
    Public sEquipmentID As String
    Public adPath As String = ConfigurationManager.AppSettings("loginURL")
    'Public strQuery As String
    Private oFile As System.IO.File
    Private oWrite As System.IO.StreamWriter
    Private strNewRecord As String

    Public Function ValidateActiveDirectoryLogin(ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = True
        Dim Entry As New DirectoryServices.DirectoryEntry("LDAP://BITSG.BSI.CORP" & adPath, Username, Password)

        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Success = False
        End Try
        Return (Success)
    End Function

    Private Sub WritetoINIFile(ByVal Baudrate As String, ByVal TimeOut As String, ByVal PortNo As String, ByVal DataParity As String, ByVal DataBit As String, ByVal StopBit As String, ByVal XonXoff As String)
        Try
            Dim INIPath = Path.Combine(Directory.GetCurrentDirectory, iniFileName)
            INIWrite(INIPath, "RS232Config", "BaudRate", BAUDRATE)
            INIWrite(INIPath, "RS232Config", "TimeOut", TIMEOUT)
            INIWrite(INIPath, "RS232Config", "PortNo", PORTNO)
            INIWrite(INIPath, "RS232Config", "DataParity", DATAPARITY)
            INIWrite(INIPath, "RS232Config", "DataBit", DATABIT)
            INIWrite(INIPath, "RS232Config", "StopBit", STOPBIT)
            INIWrite(INIPath, "RS232Config", "XonXoff", XONXOFF)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetRs232Parameters()
        BAUDRATE = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "BaudRate")
        TIMEOUT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "TimeOut")
        PORTNO = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "PortNo")
        DATAPARITY = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "DataParity")
        DATABIT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "DataBit")
        STOPBIT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "StopBit")
        XONXOFF = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "XonXoff")
    End Sub
    Public Function GetConnectionStringValue() As String
        Dim dbConnectionName As String = "DBConnection"
        Dim sTmpConnString As String = ""
        GetConnectionStringValue = ""

        sDBServer = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Server")
        sDBName = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Database")

        sTmpConnString = "SERVER="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Server")
        sTmpConnString = sTmpConnString & ";Database="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Database")
        sTmpConnString = sTmpConnString & ";UID="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Uid")
        sTmpConnString = sTmpConnString & ";PWD="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Pwd")
        sTmpConnString = sTmpConnString & ";Trusted_Connection="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Trusted_Connection")
        GetConnectionStringValue = sTmpConnString
    End Function


    Public Function getUserAuthentication() As Boolean

        Dim Success As Boolean = False
        Try
            Sql = "Select * from Users where userid = '" & sLogonUser & "'"
            ds = db.selectQuery(Sql)

            If (ds.Tables(0).Rows.Count > 0) Then
                If (ds.Tables(0).Rows(0).Item("stat") = 1) Then
                    Success = True
                    UserFullName = ds.Tables(0).Rows(0).Item("uname")
                Else
                    Success = False
                    MsgBox("User does not exist", MsgBoxStyle.Critical)
                End If
            Else
                UserFullName = ""
                Success = False
            End If
        Catch ex As System.Exception

        End Try
        Return (Success)
    End Function

    Public Function MNI(ByVal i As Object) As Integer
        If IsDBNull(i) Then
            Return 0
        ElseIf i Is Nothing Then
            Return 0
        Else
            Return Convert.ToInt32(i)
        End If
    End Function

    Public Function MNDbl(ByVal i As Object) As Double
        If IsDBNull(i) Then
            Return 0
        ElseIf i Is Nothing Then
            Return 0
        Else
            Return Convert.ToDouble(i)
        End If
    End Function

    Public Function MNS(ByVal i As Object) As String
        If IsDBNull(i) Then
            Return ""
        ElseIf i Is Nothing Then
            Return ""
        Else
            Return Convert.ToString(i)
        End If
    End Function

    Public Function MND(ByVal i As Object) As String
        Try
            If IsDBNull(i) Then
                Return ""
            ElseIf i Is Nothing Then
                Return ""
            Else
                Dim dt As DateTime
                dt = Convert.ToDateTime(i).AddHours(8)
                If dt.Year <= 1971 Then Return ""
                Return dt.ToString
            End If
        Catch ex As System.Exception
            Return ""
        End Try

    End Function

    Public Function MNDiff(ByVal dto1 As Object, ByVal dto2 As Object) As String
        Try
            If IsDBNull(dto1) Or dto1 Is Nothing Or IsDBNull(dto2) Or dto2 Is Nothing Then
                Return ""
            Else
                Dim dt1 As DateTime
                dt1 = Convert.ToDateTime(dto1)
                Dim dt2 As DateTime
                dt2 = Convert.ToDateTime(dto2)
                If dt1.Year <= 1971 Or dt2.Year <= 1971 Then Return ""
                Dim ts As TimeSpan
                ts = dt1.Subtract(dt2)
                Return ts.Hours & ":" & ts.Minutes & ":" & ts.Seconds
            End If
        Catch ex As System.Exception
            Return ""
        End Try

    End Function

    Public Function updateDate(ByVal dt As DateTime) As String
        Dim dt2 As DateTime
        dt2 = dt.AddHours(-8)

        'for SQL
        'Return "'" & dt2.ToString() & "'"

        'for oracle
        Return "TO_Date( '" & dt2.ToString() & "', 'MM/DD/YYYY HH:MI:SS AM')"

    End Function

    Public Function CreateDataReaderHDRRecord(ByVal HDRRowKey As String, ByVal TmpBatchNoList() As String, ByVal EquipmentID As String, ByVal TmpSerialNoList() As String, ByVal SerileType As String, ByVal TubingPart As String, ByVal singlewall As String, ByVal BurstReason() As String, ByVal sFinalRemarks() As String, ByVal sTestType As String, ByVal sOprnArea As String, ByVal dDueDate As String)

        Dim db As New Class1
        Dim sql As String
        Dim ds As DataSet
        Dim dr As DataRow

        '@sRowKey			Varchar(30)=NULL,
        '@sCurrentUser		Varchar(30)='',
        '@sEquipmentID		Varchar(20),
        '@sBatchNo			Varchar(20),
        '@sSerialNo			Varchar(10),
        '@sSterileType		Varchar(30),
        '@sTubingMaterial	Varchar(20),
        '@sSingleWall		Varchar(30),
        '@sBurstReason		Varchar(12)


        sql = "EXEC [PT_InitializeDataReadUpdates] '"
        sql = sql & HDRRowKey
        sql = sql & "','" & sLogonUser
        sql = sql & "','" & EquipmentID
        sql = sql & "','" & sTestType
        sql = sql & "','" & TmpBatchNoList(1)
        sql = sql & "','" & TmpBatchNoList(2)
        sql = sql & "','" & TmpBatchNoList(3)
        sql = sql & "','" & TmpBatchNoList(4)
        sql = sql & "','" & TmpBatchNoList(5)


        sql = sql & "','" & TmpSerialNoList(1)
        sql = sql & "','" & TmpSerialNoList(2)
        sql = sql & "','" & TmpSerialNoList(3)
        sql = sql & "','" & TmpSerialNoList(4)
        sql = sql & "','" & TmpSerialNoList(5)

        sql = sql & "','" & SerileType
        sql = sql & "','" & TubingPart
        sql = sql & "','" & singlewall
        'sql = sql & "','" & BurstReason
        'sql = sql & "','" & sFinalRemarks

        sql = sql & "','" & BurstReason(1)
        sql = sql & "','" & BurstReason(2)
        sql = sql & "','" & BurstReason(3)
        sql = sql & "','" & BurstReason(4)
        sql = sql & "','" & BurstReason(5)

        sql = sql & "','" & sFinalRemarks(1)
        sql = sql & "','" & sFinalRemarks(2)
        sql = sql & "','" & sFinalRemarks(3)
        sql = sql & "','" & sFinalRemarks(4)
        sql = sql & "','" & sFinalRemarks(5)

        sql = sql & "','" & sOprnArea
        sql = sql & "','" & dDueDate
        sql = sql & "' "
        ds = db.selectQuery(sql)

        sNewRecordRowID = ds.Tables(0).Rows(0).Item("NewRowKey").ToString
        ' GetServerDateTime = Convert.ToDateTime(dr(0))

    End Function

    Public Function CreateDataReaderDetailRecord(ByVal sHDRRowKey As String, ByVal nSequenceNo As Integer, ByVal sDataFromMachine As String)

        Dim db As New Class1
        Dim sql As String
        Dim ds As DataSet
        'Dim dr As DataRow
        On Error Resume Next
        sql = "EXEC [PT_CreateDataReadLogDetail] " & nSequenceNo & ",'" & sHDRRowKey & "', '" & sDataFromMachine & "' "
        ds = db.selectQuery(sql)



        ' sNewRecordRowID = ds.Tables(0).Rows(0).Item("NewRowKey")
        ' GetServerDateTime = Convert.ToDateTime(dr(0))

    End Function

    Public Function UpdateResult(ByVal sHDRRowKey As String, ByVal sReason As String, ByVal sRemarks As String, ByVal sUpdatedBy As String, ByVal sSequence As Integer, ByVal sBatchNo As String, ByVal sSerialNo As String)

        Dim db As New Class1
        Dim sql As String
        Dim ds As DataSet
        'Dim dr As DataRow
        On Error Resume Next
        sql = "EXEC [PT_UpdateResult] " & sHDRRowKey & ",'" & sUpdatedBy & "','" & sReason & "', '" & sRemarks & "', '" & sSequence & "', '" & sBatchNo & "', '" & sSerialNo & "' "
        ds = db.selectQuery(sql)


        ' sNewRecordRowID = ds.Tables(0).Rows(0).Item("NewRowKey")
        ' GetServerDateTime = Convert.ToDateTime(dr(0))

    End Function

    Public Function GetServerDateTime() As Date
        Try
            'Dim cfg As New clsConfig
            Dim db As New Class1
            Dim sql As String
            Dim ds As DataSet
            Dim dr As DataRow

            sql = "select to_char(sysdate, ' MM-DD-YYYY HH:MI:SS PM') from dual"
            ds = db.selectQuery(sql)

            dr = ds.Tables(0).Rows(0)
            GetServerDateTime = Convert.ToDateTime(dr(0))
            'MsgBox(GetServerDateTime)

        Catch
            MsgBox("Error in GetServerDateTime: " & Err.Description)
        End Try

    End Function

    Public Function StuffWithZeros(ByVal sInputStr As String, ByVal nStrLength As Integer) As String
        Dim sTmpStr, sStuff As String
        Dim nI As Integer
        sTmpStr = Trim(sInputStr)
        sStuff = ""
        For nI = 1 To (nStrLength - Len(sInputStr))
            sStuff = sStuff & "0"
        Next
        sTmpStr = sStuff & sTmpStr
        Return sTmpStr
    End Function

    Public Function GetServerYear(ByVal dInputDate As Date)
        ' To get server Year
        Return dInputDate.ToString("yyyy")
        'Sql = "select CONVERT(varchar(4), year('" & dInputDate & "'), 112) as 'Year'"
        'ds = db.selectQuery(Sql)
        'Return ds.Tables(0).Rows(0).Item("Year")
    End Function

    Public Function GetServerMonth(ByVal dInputDate As Date)
        ' To get server Month
        Return dInputDate.ToString("MM")
        'Sql = "select (CONVERT(varchar(6), month('" & dInputDate & "'), 112)) as 'Month'"
        'ds = db.selectQuery(Sql)
        'Return ds.Tables(0).Rows(0).Item("Month")
    End Function

    Public Function GetServerFormattedYear(ByVal dInputDate As Date)
        ' To get server FormattedYear
        Return dInputDate.ToString("yy")
        'Sql = "select substring(CONVERT(varchar(4), year('" & dInputDate & "'), 112),3,2) as 'FormattedYear'"
        'ds = db.selectQuery(Sql)
        'Return ds.Tables(0).Rows(0).Item("FormattedYear")
    End Function

End Module

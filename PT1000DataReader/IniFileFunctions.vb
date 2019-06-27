Imports system.IO
Module IniFileFunctions
    Dim KeyValue As String
#Region "API Calls"
    ' standard API declarations for INI access 
    ' changing only "As Long" to "As Int32" (As Integer would work also) 
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
#End Region


    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String, ByVal KeyName As String,
    ByVal DefaultValue As String) As String
        ' primary version of call gets single value given all parameters 
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024) ' allocate some room 
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue,
        sData, sData.Length, LTrim(RTrim((INIPath))))
        If n > 0 Then ' return whatever it gave us 
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function

#Region "INIRead Overloads"
    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String, ByVal KeyName As String) As String
        ' overload 1 assumes zero-length default 
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file 
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path 
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function
#End Region

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    'Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, _
    'ByVal KeyName As String) ' delete single line from section 
    '    Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    'End Sub

    'Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
    '    ' delete section from INI file 
    '    Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    'End Sub


    Public Function sGetIniFilePath() As String
        Dim sFileName As String
        Dim ds As DataSet

        sFileName = Path.Combine(Directory.GetCurrentDirectory, "config.xml")
        ds = New DataSet
        ds.ReadXml(sFileName)

        INIFilePath = MNS(ds.Tables(0).Rows(0)("INIFilePath")).ToString().Trim()
        'sVersion = MNS(ds.Tables(0).Rows(0)("version")).ToString().Trim()
        'sVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString
        sVersion = Application.ProductVersion.ToString()

        INIFilePath = LTrim(RTrim(INIFilePath))
        sVersion = LTrim(RTrim(sVersion))
        INIFilePath = INIFilePath & "\PT1000.ini"    'LTrim(RTrim(INIFilePath))
        sGetIniFilePath = INIFilePath
    End Function

End Module

'------------------------------------------------------------------------------
' mkversion.vb
'
' Modification History :
'
' 03.10.2003        - Initial implementation
' 03.14.2003        - Added version.txt file
' 03.27.2007        - Added version.wxi file
'------------------------------------------------------------------------------

Imports System.IO

Module Module1

    '--------------------------------------------------------------------------
    ' Constants
    '--------------------------------------------------------------------------

    Private Const COMMENT_CPP As String = "//"          ' C++ line comment
    Private Const COMMENT_CS As String = "//"           ' C# line comment
    Private Const COMMENT_NULL As String = ""           ' Null line comment
    Private Const COMMENT_JSL As String = "//"          ' J# line comment
    Private Const COMMENT_VB As String = "'"            ' VB line comment

    Private Const EXTENSION_CPP As String = ".cpp"      ' C++ source file
    Private Const EXTENSION_CS As String = ".cs"        ' C# source file
    Private Const EXTENSION_JSL As String = ".jsl"      ' J# source file
    Private Const EXTENSION_TXT As String = ".txt"      ' Text file
    Private Const EXTENSION_VB As String = ".vb"        ' VB source file
    Private Const EXTENSION_RC1 As String = ".rc1"      ' RC1 source file
    Private Const EXTENSION_RC2 As String = ".rc2"      ' RC2 source file
    Private Const EXTENSION_WXI As String = ".wxi"      ' WXI source file

    Private Const FILENAME_BASE As String = "version"   ' Base file name

    '--------------------------------------------------------------------------
    ' Delegates
    '--------------------------------------------------------------------------

    '///<summary>
    '/// Function pointer to one of the EmitXXX functions
    '///</summary>

    Private Delegate Sub EmitFunction(ByVal out As TextWriter, _
        ByVal maj As Integer, ByVal min As Integer, ByVal build As Integer)

    '--------------------------------------------------------------------------
    ' Sub Main
    '--------------------------------------------------------------------------

    '///<summary>
    '/// Main application entry point
    '///</summary>

    Sub Main(ByVal args() As String)

        Dim maj As Integer = 1                  ' Default major is "1"
        Dim min As Integer = 0                  ' Default minor is "0"
        Dim prefix As String = String.Empty     ' Generic file prefix
        Dim build As Integer                    ' Generate the build number

        ' I've had some very weird problems with this function, and using
        ' the DateTime.Parse() method seems to work much better than the
        ' New DateTime(2000, 1, 1) method ???????????????????????

        build = DateTime.Today.Subtract(DateTime.Parse("1/1/2000")).Days

        ' There needs to be at least one, but no more than three arguments

        If args.Length = 0 Or args.Length > 3 Then
            ShowUsage()
            Return
        End If

        ' Extract the command line arguments

        If args.Length >= 1 Then prefix = args(0) ' filename prefix
        If args.Length >= 2 Then maj = CInt(args(1)) ' major version
        If args.Length >= 3 Then min = CInt(args(2)) ' minor version

        ' Text file

        CreateVersionFile(prefix, EXTENSION_TXT, COMMENT_NULL, _
            AddressOf EmitText, maj, min, build)

        ' C++

        CreateVersionFile(prefix, EXTENSION_CPP, COMMENT_CPP, _
            AddressOf EmitCPlusPlus, maj, min, build)

        ' C#

        CreateVersionFile(prefix, EXTENSION_CS, COMMENT_CS, _
            AddressOf EmitCSharp, maj, min, build)

        ' J#

        CreateVersionFile(prefix, EXTENSION_JSL, COMMENT_JSL, _
            AddressOf EmitJSharp, maj, min, build)

        ' VB

        CreateVersionFile(prefix, EXTENSION_VB, COMMENT_VB, _
            AddressOf EmitVB, maj, min, build)

        ' C++ Resources Part 1

        CreateVersionFile(prefix, EXTENSION_RC1, COMMENT_CPP, _
            AddressOf EmitRC1, maj, min, build)

        ' C++ Resources Part 2

        CreateVersionFile(prefix, EXTENSION_RC2, COMMENT_CPP, _
            AddressOf EmitRC2, maj, min, build)

        ' WiX Installer Include File
        CreateVersionFile(prefix, EXTENSION_WXI, COMMENT_NULL, _
            AddressOf EmitWxi, maj, min, build)

    End Sub

    '--------------------------------------------------------------------------
    ' Private Member Functions
    '--------------------------------------------------------------------------

    '///<summary>
    '/// Creates a single version output file
    '///</summary>

    Private Sub CreateVersionFile(ByVal prefix As String, ByVal extension As String, _
        ByVal comment As String, ByVal emitFunc As EmitFunction, _
        ByVal majorVersion As Integer, ByVal minorVersion As Integer, ByVal build As Integer)

        Dim filename As String              ' The file name to use
        Dim writer As TextWriter            ' Output file TextWriter object

        ' Generate the filename to be used for the version info file

        If prefix.Length > 0 Then filename = prefix & FILENAME_BASE & extension _
        Else filename = FILENAME_BASE.ToLower() & extension

        ' 06.28.2005 -- Added this to remove S/H/R attributes from the file

        If File.Exists(filename) Then File.SetAttributes(filename, FileAttributes.Normal)

        writer = File.CreateText(filename)              ' Create the output file
        EmitWarning(writer, comment)                    ' Emit the warning comments
        emitFunc(writer, majorVersion, minorVersion, build)    ' Emit the version attr

        writer.Flush()                      ' Save changes to disk
        writer.Close()                      ' Close the output file

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the C++ assembly version information
    '///</summary>

    Private Sub EmitCPlusPlus(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine("#include ""stdafx.h""")
        outputFile.WriteLine("#using <mscorlib.dll>")
        outputFile.WriteLine("using namespace System::Reflection;")
        outputFile.WriteLine("using namespace System::Runtime::CompilerServices;")
        outputFile.WriteLine()
        outputFile.WriteLine("[assembly:AssemblyVersionAttribute(""" & versionMajor & "." & _
            versionMinor & ".0.0" & """)];")
        outputFile.WriteLine("[assembly:AssemblyFileVersionAttribute(""" & versionMajor & "." & _
            versionMinor & "." & build & ".0" & """)];")

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the C# assembly version information
    '///</summary>

    Private Sub EmitCSharp(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine("using System.Reflection;")
        outputFile.WriteLine("using System.Runtime.CompilerServices;")
        outputFile.WriteLine()
        outputFile.WriteLine("[assembly: AssemblyVersion(""" & versionMajor & "." & _
            versionMinor & ".0.0" & """)]")
        outputFile.WriteLine("[assembly: AssemblyFileVersion(""" & versionMajor & "." & _
            versionMinor & "." & build & ".0" & """)]")

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the J# assembly version information
    '///</summary>

    Private Sub EmitJSharp(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine("import System.Reflection.*;")
        outputFile.WriteLine("import System.Runtime.CompilerServices.*;")
        outputFile.WriteLine()
        outputFile.WriteLine("/** @assembly AssemblyVersion(""" & versionMajor & "." & _
            versionMinor & ".0.0" & """) */")
        outputFile.WriteLine("/** @assembly AssemblyFileVersion(""" & versionMajor & "." & _
            versionMinor & "." & build & ".0" & """) */")

    End Sub

    '--------------------------------------------------------------------------

    ' note: Add as a #include in the real .RC in place of FILEVERSION and PRODUCTVERSION

    Private Sub EmitRC1(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine(vbTab & "FILEVERSION " & versionMajor & ", " & _
            versionMinor & ", " & build & ", 0")
        outputFile.WriteLine(vbTab & "PRODUCTVERSION " & versionMajor & ", " & _
            versionMinor & ", " & build & ", 0")

    End Sub

    ' note: add as a #include in the real .RC in place of the VALUE "FileVersion" and 
    ' VALUE "ProductVersion" attributes

    Private Sub EmitRC2(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine(vbTab & "VALUE ""FileVersion"", """ & versionMajor & "." & _
            versionMinor & "." & build & ".0""")
        outputFile.WriteLine(vbTab & "VALUE ""ProductVersion"", """ & versionMajor & "." & _
            versionMinor & "." & build & ".0""")

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the Visual Basic assembly version information
    '///</summary>

    Private Sub EmitVB(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine("Imports System.Reflection")
        outputFile.WriteLine("Imports System.Runtime.InteropServices")
        outputFile.WriteLine()
        outputFile.WriteLine("<Assembly: AssemblyVersion(""" & versionMajor & "." & _
            versionMinor & ".0.0" & """)>")
        outputFile.WriteLine("<Assembly: AssemblyFileVersion(""" & versionMajor & "." & _
            versionMinor & "." & build & ".0" & """)>")

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the stand-alone version.txt file contents
    '///</summary>

    Private Sub EmitText(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        outputFile.WriteLine(versionMajor & "." & versionMinor & "." & _
            build & ".0")

    End Sub

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Emits the standard warning message, using the specified line comment chars
    '///</summary>

    Private Sub EmitWarning(ByVal outputFile As TextWriter, ByVal comment As String)

        If comment = COMMENT_NULL Then Return

        outputFile.WriteLine(comment & " DO NOT MANUALLY EDIT THIS FILE")
        outputFile.WriteLine(comment)
        outputFile.WriteLine(comment & " This file was automatically generated in order")
        outputFile.WriteLine(comment & " to provide consistent version information across")
        outputFile.WriteLine(comment & " multiple .NET assemblies.")
        outputFile.WriteLine(comment)
        outputFile.WriteLine(comment & " Please use the mkversion.exe tool to update this data")
        outputFile.WriteLine()

    End Sub

    '///<summary>
    '/// Emits the stand-alone version.txt file contents
    '///</summary>

    Private Sub EmitWxi(ByVal outputFile As TextWriter, ByVal versionMajor As Integer, _
        ByVal versionMinor As Integer, ByVal build As Integer)

        Dim ver As Version = New Version(versionMajor & "." & versionMinor & "." & build & ".0")

        outputFile.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
        outputFile.WriteLine("<Include>")
        outputFile.WriteLine("<?define ProjectVersionMajor = """ & versionMajor.ToString() & """ ?>")
        outputFile.WriteLine("<?define ProjectVersionMinor = """ & versionMinor.ToString() & """ ?>")
        outputFile.WriteLine("<?define ProjectVersionBuild = """ & build.ToString() & """ ?>")
        outputFile.WriteLine("<?define ProjectVersion.2 = """ & ver.ToString(2) & """ ?>")
        outputFile.WriteLine("<?define ProjectVersion.3 = """ & ver.ToString(3) & """ ?>")
        outputFile.WriteLine("<?define ProjectVersion.4 = """ & ver.ToString(4) & """ ?>")
        outputFile.WriteLine("</Include>")

    End Sub

    '--------------------------------------------------------------------------

    '--------------------------------------------------------------------------

    '///<summary>
    '/// Displays basic usage information to the user
    '///</summary>

    Private Sub ShowUsage()

        Console.WriteLine()
        Console.WriteLine("mkversion - .NET assembly versioning tool")
        Console.WriteLine()
        Console.WriteLine("USAGE: mkversion prefix [major] [minor]")
        Console.WriteLine()
        Console.WriteLine("prefix = prefix to prepend to the file name")
        Console.WriteLine("major  = Optional major version number.  Default is 1")
        Console.WriteLine("minor  = Optional minor version number.  Default is 0")
        Console.WriteLine()
        Console.WriteLine("To specify a different folder for the output files, you can prepend")
        Console.WriteLine("a path to the prefix name, i.e. :")
        Console.WriteLine()
        Console.WriteLine("    c:\era\src\era\common\framework")
        Console.WriteLine()
        Console.WriteLine("Will place files named ""frameworkVersion.xx"" into c:\era\src\era\common")

    End Sub

End Module

'------------------------------------------------------------------------------

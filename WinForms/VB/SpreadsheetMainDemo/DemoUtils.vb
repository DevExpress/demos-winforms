Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Class SpreadSheetTutorialControlBase
        Inherits TutorialControlBase

        Private ReadOnly _defaultCulture As CultureInfo = New CultureInfo("en-US")

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public ReadOnly Property DefaultCulture As CultureInfo
            Get
                Return _defaultCulture
            End Get
        End Property

        Public Overridable ReadOnly Property ShowWithPaddings As Boolean
            Get
                Return False
            End Get
        End Property
    End Class

    Public Class DemoUtils

        Public Shared Function GetRelativePath(ByVal name As String) As String
            Dim path As String = System.IO.Path.Combine("Data", name)
            Return Tutorials.FilePathUtils.FindFilePath(path, False)
        End Function

        Public Shared Function LoadImageByName(ByVal name As String) As Bitmap
            Dim root As String = "DevExpress.XtraSpreadsheet.Demos."
            Dim assembly As System.Reflection.Assembly = GetType(frmMain).Assembly
            Dim stream As Stream = assembly.GetManifestResourceStream($"{root}Resources.{name}")
            If stream Is Nothing Then stream = assembly.GetManifestResourceStream($"{root} {name}")
            If stream IsNot Nothing Then Return TryCast(ImageTool.ImageFromStream(stream), Bitmap)
            Return Nothing
        End Function

        Public Shared Sub SetDatabasePath()
            Const dbName As String = "nwind.mdb"
            Const pathToDbTag As String = "|pathToDb|"
            Dim path As String = GetRelativePath(dbName)
            If String.IsNullOrEmpty(path) Then Return
            Dim connectionString As String = TryCast(Global.DevExpress.XtraSpreadsheet.Demos.Properties.Settings.Default("nwindConnectionString"), String)
            If String.IsNullOrEmpty(connectionString) Then Return
            connectionString = connectionString.Replace(pathToDbTag, path)
            Global.DevExpress.XtraSpreadsheet.Demos.Properties.Settings.Default("nwindConnectionString") = connectionString
        End Sub

        Public Shared Function GetLanguageString() As String
            Dim result As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
            If Equals(result, "CS") Then result = "C#"
            Return result
        End Function
    End Class

    Public Class DemoMenuManager

        Public Shared Sub SetMenuManager(ByVal controls As Control.ControlCollection, ByVal menuManager As IDXMenuManager)
            Dim count As Integer = controls.Count
            For i As Integer = 0 To count - 1
                Dim control As Control = controls(i)
                Dim baseEdit As BaseEdit = TryCast(control, BaseEdit)
                If baseEdit IsNot Nothing Then baseEdit.MenuManager = menuManager
                Call SetMenuManager(control.Controls, menuManager)
            Next
        End Sub
    End Class

    Public Class DemoColors

        Public Shared Function ApplyTint(ByVal color As Color, ByVal tint As Single) As Color
            Dim red As Single = color.R
            Dim green As Single = color.G
            Dim blue As Single = color.B
            If tint < 0 Then
                red *= 1 + tint
                green *= 1 + tint
                blue *= 1 + tint
            Else
                red +=(&HfF - red) * tint
                green +=(&HfF - green) * tint
                blue +=(&HfF - blue) * tint
            End If

            Return Color.FromArgb(color.A, CInt(red), CInt(green), CInt(blue))
        End Function
    End Class

    Friend Class DemoMruItem

        Public Property [Module] As ModuleInfo

        Public Property TutorialControl As Control
    End Class
End Namespace

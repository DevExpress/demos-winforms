Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.MailClient.Win
    Friend NotInheritable Class UnpackHelper

        Private Sub New()
        End Sub

        Private Shared Arabic As String = "ar"
        Private Shared ArabicResource As String = ".ar."
        Private Shared Farsi As String = "fa"
        Private Shared FarsiResource As String = ".fa."
        Private Shared Hebrew As String = "he"
        Private Shared HebrewResource As String = ".he."
        Friend Shared Sub Unpack()
            Try
                Dim executingAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim startPath As New DirectoryInfo(Application.StartupPath)
                If Not Directory.Exists(Path.Combine(startPath.ToString(), Arabic)) Then
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Arabic))
                End If
                If Not Directory.Exists(Path.Combine(startPath.ToString(), Farsi)) Then
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Farsi))
                End If
                If Not Directory.Exists(Path.Combine(startPath.ToString(), Hebrew)) Then
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Hebrew))
                End If
                Dim resources() As String = executingAssembly.GetManifestResourceNames()
                For Each resource As String In resources
                    If Not resource.EndsWith("resources.dll") Then
                        Continue For
                    End If
                    CreateResourceIfNeed(executingAssembly, startPath, resource, ArabicResource, Arabic)
                    CreateResourceIfNeed(executingAssembly, startPath, resource, FarsiResource, Farsi)
                    CreateResourceIfNeed(executingAssembly, startPath, resource, HebrewResource, Hebrew)
                Next resource
            Catch
            End Try
        End Sub

        Private Shared Sub CreateResourceIfNeed(ByVal executingAssembly As System.Reflection.Assembly, ByVal startPath As DirectoryInfo, ByVal resource As String, ByVal resourcePrefix As String, ByVal resourceLanguagePrefix As String)
            If resource.Contains(resourcePrefix) Then
                Dim fileName As String = resource.Remove(0, resource.LastIndexOf(resourcePrefix) + resourcePrefix.Length)
                Using fs As New FileStream(Path.Combine(startPath.ToString(), resourceLanguagePrefix) & "\" & fileName, FileMode.OpenOrCreate)
                    executingAssembly.GetManifestResourceStream(resource).CopyTo(fs)
                End Using
            End If
        End Sub
    End Class
End Namespace

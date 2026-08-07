Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Internal
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports Message = DevExpress.WindowsMailClient.Win.Data.Message
Imports DevExpress.DXperience.Demos
#If Not NET
Imports System.Data.Entity

#Else
using Microsoft.EntityFrameworkCore;
#End If
Namespace DevExpress.WindowsMailClient.Win.Model

    Friend Class MailClientDataModel

        Private Shared _employees As BindingList(Of Employee) = Nothing

        Private Shared _messages As List(Of Message) = Nothing

        Friend Shared ReadOnly Property MailTable As DataTable
            Get
                Const table As String = "Messages"
                Return CreateDataTable(table)
            End Get
        End Property

        Public Shared ReadOnly Property Messages As List(Of Message)
            Get
                Try
                    If _messages Is Nothing Then
                        _messages = New List(Of Message)()
                        Dim tbl As DataTable = MailTable
                        If tbl IsNot Nothing Then
                            For i As Integer = 0 To tbl.Rows.Count - 1
                                Dim message As Message = New Message(tbl.Rows(i))
                                _messages.Add(message)
                            Next

                            For Each row As DataRow In tbl.Rows
                                Call _messages.Add(New Message(row))
                            Next
                        End If
                    End If
                Catch e As Exception
                    XtraMessageBox.Show(e.Message, e.Source)
                    _messages = New List(Of Message)()
                End Try

                Return _messages
            End Get
        End Property

        Friend Shared ReadOnly Property Employees As BindingList(Of Employee)
            Get
                If _employees Is Nothing Then
#If Not NET
                    Dim devAvDb As DevAVDb = New DevAVDb(MainFormHelper.TakeScreens)
#Else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={Internal.DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}", MainFormHelper.TakeScreens);
#End If
                    devAvDb.Employees.Load()
                    _employees = devAvDb.Employees.Local.ToBindingList()
                End If

                Return _employees
            End Get
        End Property

        Public Shared Function GetNameByEmail(ByVal email As String) As String
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) Equals(p.Email, email))
            Return If(employee IsNot Nothing, employee.FullName, String.Empty)
        End Function

        Public Shared Function GetPhotoByEmail(ByVal email As String) As Image
            Dim employee As Employee = Employees.FirstOrDefault(Function(p) Equals(p.Email, email))
            If employee Is Nothing OrElse employee.Picture Is Nothing Then Return Nothing
            Dim clippedImage As Bitmap = New Bitmap(employee.Photo)
            Using g As Graphics = Graphics.FromImage(clippedImage)
                Using gCache As GraphicsCache = New GraphicsCache(g)
                    Using path As GraphicsPath = New GraphicsPath()
                        Dim indent As Integer = 4
                        Dim size As Integer = Math.Max(1, Math.Min(clippedImage.Width, clippedImage.Height) - indent * 3)
                        path.AddEllipse(indent, indent, size, size)
                        gCache.DrawPath(Pens.Gray, path)
                    End Using
                End Using
            End Using

            Return clippedImage
        End Function

        Private Shared Function CreateDataTable(ByVal table As String) As DataTable
            Dim dataSet As DataSet = New DataSet()
            Dim dataFile As String = DevAVDataDirectoryHelper.GetFile("MailDevAv.xml")
            If Not Equals(dataFile, String.Empty) Then
                Dim fi As FileInfo = New FileInfo(dataFile)
                dataSet.ReadXml(fi.FullName)
                Return dataSet.Tables(table)
            End If

            Return Nothing
        End Function

        Private Shared images As Dictionary(Of String, Bitmap) = New Dictionary(Of String, Bitmap)()

        Public Shared Function CreateSenderImage(ByVal sender As String, ByVal size As Size, ByVal ulf As LookAndFeel.UserLookAndFeel) As Bitmap
            Dim image As Bitmap = Nothing
            If images.TryGetValue(sender, image) Then Return image
            If size.Width <> size.Height Then
                Dim max As Integer = Math.Max(size.Width, size.Height)
                size = New Size(max, max)
            End If

            Dim imageSize As Size = New Size(size.Width, size.Height)
            Dim parsedText As String() = sender.Split(" "c)
            Dim result As String = String.Empty
            Dim count As Integer = 0
            For i As Integer = 0 To parsedText.Length - 1
                If parsedText(i).Length > 0 Then
                    result += parsedText(i)(0)
                    count += 1
                    If count = 2 Then Exit For
                End If
            Next

            image = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result)
            images.Add(sender, image)
            Return image
        End Function
    End Class
End Namespace

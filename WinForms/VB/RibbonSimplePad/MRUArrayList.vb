Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Public Class MRUArrayList
        Inherits ArrayList

        Public Shared MRUFileName As String = "RibbonMRUFiles.ini"

        Public Shared MRUFolderName As String = "RibbonMRUFolders.ini"

        Private container As Control

        Private maxRecentFiles As Integer = 9

        Private imgChecked, imgUncheked, glyph As Image

        Public Event LabelClicked As EventHandler

        Private indexedList As Boolean

        Private showDescription As Boolean

        Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image, ByVal glyph As Image, ByVal indexedList As Boolean, ByVal showDescription As Boolean)
            Me.New(cont, iChecked, iUnchecked, glyph)
            Me.indexedList = indexedList
            Me.showDescription = showDescription
        End Sub

        Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image, ByVal glyph As Image)
            Me.New(cont, iChecked, iUnchecked)
            Me.glyph = glyph
        End Sub

        Public Sub New(ByVal cont As Control, ByVal iChecked As Image, ByVal iUnchecked As Image)
            MyBase.New()
            indexedList = True
            imgChecked = iChecked
            imgUncheked = iUnchecked
            container = cont
        End Sub

        Private Function GetLastAppMenuFileLabelIndex() As Integer
            For i As Integer = container.Controls.Count - 1 To 0 Step -1
                If TypeOf container.Controls(i) Is AppMenuFileLabel Then Return i + 1
            Next

            Return 0
        End Function

        Public Sub InsertElement(ByVal value As Object)
            Dim names As String() = value.ToString().Split(","c)
            Dim _name As String = names(0)
            Dim checkedLabel As Boolean = False
            If names.Length > 1 Then checkedLabel = names(1).ToLower().Equals("true")
            For Each c As Control In container.Controls
                Dim ml As AppMenuFileLabel = TryCast(c, AppMenuFileLabel)
                If ml Is Nothing Then Continue For
                If ml.Tag.Equals(_name) Then
                    checkedLabel = ml.Checked
                    Remove(_name)
                    RemoveHandler ml.LabelClick, New EventHandler(AddressOf OnLabelClick)
                    ml.Dispose()
                    Exit For
                End If
            Next

            Dim access As Boolean = True
            If Count >= maxRecentFiles Then access = RemoveLastElement()
            If access Then
                Insert(0, _name)
                Dim ml As AppMenuFileLabel = New AppMenuFileLabel()
                Dim index As Integer = GetLastAppMenuFileLabelIndex()
                container.Controls.Add(ml)
                container.Controls.SetChildIndex(ml, index)
                ml.Tag = _name
                If showDescription Then
                    ml.Text = GetFileName(_name)
                    ml.Description = _name
                Else
                    ml.Text = GetFileName(_name)
                End If

                ml.Glyph = glyph
                ml.Checked = checkedLabel
                ml.AutoHeight = True
                ml.Dock = DockStyle.Top
                ml.Image = imgUncheked
                ml.SelectedImage = imgChecked
                AddHandler ml.LabelClick, New EventHandler(AddressOf OnLabelClick)
                If indexedList Then SetElementsRange()
            End If
        End Sub

        Private Sub OnLabelClick(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent LabelClicked(CType(sender, AppMenuFileLabel).Tag.ToString(), e)
        End Sub

        Public Function RemoveLastElement() As Boolean
            For i As Integer = 0 To container.Controls.Count - 1
                Dim ml As AppMenuFileLabel = TryCast(container.Controls(i), AppMenuFileLabel)
                If ml IsNot Nothing AndAlso Not ml.Checked Then
                    Remove(ml.Tag)
                    RemoveHandler ml.LabelClick, New EventHandler(AddressOf OnLabelClick)
                    ml.Dispose()
                    Return True
                End If
            Next

            Return False
        End Function

        Private Function GetFileName(ByVal obj As Object) As String
            Dim fi As FileInfo = New FileInfo(obj.ToString())
            Return fi.Name
        End Function

        Private Sub SetElementsRange()
            Dim i As Integer = 0
            For Each c As Control In container.Controls
                Dim ml As AppMenuFileLabel = TryCast(c, AppMenuFileLabel)
                If ml Is Nothing Then Continue For
                ml.Caption = String.Format("&{0}", container.Controls.Count - i)
                i += 1
            Next
        End Sub

        Public Function GetLabelChecked(ByVal name As String) As Boolean
            For Each c As Control In container.Controls
                Dim ml As AppMenuFileLabel = TryCast(c, AppMenuFileLabel)
                If ml Is Nothing Then Continue For
                If ml.Tag.Equals(name) Then Return ml.Checked
            Next

            Return False
        End Function

        Public Sub Init(ByVal fileName As String, ByVal defaultItem As String)
            If Not File.Exists(fileName) Then
                InsertElement(defaultItem)
                Return
            End If

            Dim sr As StreamReader = File.OpenText(fileName)
            container.SuspendLayout()
            Dim list As List(Of String) = New List(Of String)()
            Dim s As String = sr.ReadLine()
            While Not Equals(s, Nothing)
                list.Add(s)
                s = sr.ReadLine()
            End While

            For i As Integer = list.Count - 1 To 0 Step -1
                InsertElement(list(i))
            Next

            sr.Close()
            container.ResumeLayout()
        End Sub
    End Class
End Namespace

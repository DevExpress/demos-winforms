Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.Internal
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing

Namespace DevExpress.XtraGrid.Demos

    Public Class KanbanHelper

        Public Shared Function LoadTasks() As BindingList(Of TaskRecord)
            Dim file As String = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanTasks.xml"))
            Dim _tasks = New BindingList(Of TaskRecord)()
            Using reader = New StreamReader(file)
                Dim deserializer As XmlSerializer = New XmlSerializer(GetType(TaskList), New XmlRootAttribute("DocumentElement"))
                Dim taskList = CType(deserializer.Deserialize(reader), TaskList)
                _tasks = taskList.List
            End Using

            LoadImages(_tasks)
            Return _tasks
        End Function

        Private Shared Sub LoadImages(ByVal taskList As BindingList(Of TaskRecord))
            For Each task In taskList
                If Not String.IsNullOrEmpty(task.ImagePath) Then
                    Dim file As String = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "Images", task.ImagePath))
                    If IO.File.Exists(file) Then task.AttachedImage = Image.FromFile(file)
                End If
            Next
        End Sub

        Public Shared Function LoadChecklist() As DataTable
            Dim file As String = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanChecklist.xml"))
            Dim checklist = New DataTable()
            checklist.TableName = "TaskChecklist"
            checklist.Columns.Add("TaskID", GetType(Guid))
            checklist.Columns.Add("Caption", GetType(String))
            checklist.Columns.Add("Checked", GetType(Boolean))
            If Not String.IsNullOrEmpty(file) AndAlso IO.File.Exists(file) Then
                checklist.ReadXml(file)
            End If

            Return checklist
        End Function

        Public Shared Function LoadMembers() As DataTable
            Dim file As String = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanMembers.xml"))
            Dim members = New DataTable()
            members.TableName = "TaskMembers"
            members.Columns.Add("TaskID", GetType(Guid))
            members.Columns.Add("MemberID", GetType(Integer))
            If Not String.IsNullOrEmpty(file) AndAlso IO.File.Exists(file) Then
                members.ReadXml(file)
            End If

            Return members
        End Function

        Public Shared Function LoadEmployees() As DataTable
            Dim DBFileName As String = String.Empty
            Dim connectionString As String = String.Empty
            DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml")
            If String.IsNullOrEmpty(DBFileName) Then Return Nothing
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(DBFileName)
            Dim table = ds.Tables("Employees")
            table.PrimaryKey = New DataColumn() {table.Columns("EmployeeID")}
            Return table
        End Function

        Public Shared Sub UpdateMembersGlyph(ByVal employees As DataTable, ByVal skinProvider As ISkinProvider, ByVal size As Integer)
            For i As Integer = 0 To employees.Rows.Count - 1
                Dim row = employees.Rows(i)
                Dim a As Char = TryCast(row("FirstName"), String)(0)
                Dim b As Char = TryCast(row("LastName"), String)(0)
                Dim text As String = String.Format("{0}{1}", a, b)
                Dim glyphbytes As Byte()
                Dim glyph As Bitmap = GlyphPainter.CreateRoundedStubGlyph(skinProvider, New Size(size, size), text)
                Using ms As MemoryStream = New MemoryStream()
                    glyph.Save(ms, ImageFormat.Png)
                    glyphbytes = ms.ToArray()
                    ms.Close()
                End Using

                row("Photo") = glyphbytes
            Next
        End Sub

        Public Shared Function CreateNewTask() As TaskRecord
            Return New TaskRecord()
        End Function
    End Class

    Public Enum TaskStatus
        ToDo
        Planned
        Doing
        Testing
        Done
    End Enum

    Public Enum TaskLabel
        None
        Red
        Yellow
        Green
    End Enum

    Public Class TaskRecord

        Public Sub New()
            Label = TaskLabel.None
        End Sub

        Public Property Id As Guid

        Public Property Caption As String

        Public Property Description As String

        Public Property ImagePath As String

        Public Property AttachedImage As Image

        <XmlIgnore>
        Public Property Status As TaskStatus

        <XmlIgnore>
        Public Property Label As TaskLabel

        <XmlElement("Status")>
        Public Property StatusCore As Integer
            Get
                Return CInt(Status)
            End Get

            Set(ByVal value As Integer)
                Status = CType(value, TaskStatus)
            End Set
        End Property

        <XmlElement("Label")>
        Public Property LabelCore As Integer
            Get
                Return CInt(Label)
            End Get

            Set(ByVal value As Integer)
                Label = CType(value, TaskLabel)
            End Set
        End Property
    End Class

    <XmlRoot("DocumentElement")>
    Public Class TaskList

        Public Sub New()
            List = New BindingList(Of TaskRecord)()
        End Sub

        <XmlElement("Tasks")>
        Public Property List As BindingList(Of TaskRecord)
    End Class
End Namespace

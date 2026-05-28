Imports System
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGantt.Options

Namespace DevExpress.XtraGantt.Demos

    Public Partial Class LargeDataSource
        Inherits DevExpress.XtraGantt.Demos.TutorialControl

        Public Sub New()
            Me.InitializeComponent()
            Me.ganttControl1.ChartStartDate = New System.DateTime(2020, 2, 17)
            Me.ganttControl1.ChartFinishDate = New System.DateTime(2020, 11, 5)
            Me.LoadData()
        End Sub

        Private Sub LoadData()
            'ganttControl1.OptionsBehavior.PopulateServiceColumns = true;
            Me.ganttControl1.LoadingPanelVisible = True
            Me.btngenerate.Enabled = False
            Dim uiScheduler = System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext()
            System.Threading.Tasks.Task.Factory.StartNew(Of System.Collections.Generic.List(Of Global.DevExpress.XtraGantt.Demos.Task))(CType((Function() CType((DevExpress.XtraGantt.Demos.DataGenerator.Generate(CInt((Me.TasksCount)))), System.Collections.Generic.List(Of DevExpress.XtraGantt.Demos.Task))), System.Func(Of System.Collections.Generic.List(Of DevExpress.XtraGantt.Demos.Task)))).ContinueWith(Sub(load)
                'this.ganttControl1.BeginUpdate();
                Me.ganttControl1.ChartMappings.StartDateFieldName = "Start"
                Me.ganttControl1.ChartMappings.DurationFieldName = "Duration"
                Me.ganttControl1.ChartMappings.PredecessorsFieldName = "Predecessors"
                Me.ganttControl1.KeyFieldName = "UID"
                Me.ganttControl1.ParentFieldName = "ParentUID"
                Me.ganttControl1.ChartMappings.TextFieldName = "Name"
                Me.ganttControl1.DataSource = Nothing
                Me.ganttControl1.DataSource = load.Result
                Me.ganttControl1.ExpandAll()
                Me.ganttControl1.LoadingPanelVisible = False
                Me.btngenerate.Enabled = True
            'this.ganttControl1.EndUpdate();
            End Sub, uiScheduler)
        End Sub

        Public Overrides ReadOnly Property MainControl As GanttControl
            Get
                Return Me.ganttControl1
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"LargeDataSource"}
            End Get
        End Property

        Private ReadOnly Property TasksCount As Integer
            Get
                If Me.ceValue1.Checked Then Return 100000
                If Me.ceValue2.Checked Then Return 500000
                If Me.ceValue3.Checked Then Return 1000000
                Return CInt(Me.customTasksCount.Value)
            End Get
        End Property

        Private Sub seCustomRecordsCount_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ceCustom.Checked = True
        End Sub

        Private Sub ceTask_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim ce As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            If Not ce.Checked Then Return
            If ce IsNot Me.ceCustom Then
                Me.LoadData()
            End If
        End Sub

        Private Sub btngenerate_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ceCustom.Checked = True
            Me.LoadData()
        End Sub
    End Class

    Public Class Task

        Public Property UID As Integer

        Public Property ParentUID As Integer

        Public Property Name As String

        Public Property Start As DateTime

        Public Property Duration As TimeSpan

        Public Property Predecessors As IList(Of Integer)
    End Class

    Friend Module DataGenerator

        Private generated As System.Collections.Generic.List(Of DevExpress.XtraGantt.Demos.Task) = New System.Collections.Generic.List(Of DevExpress.XtraGantt.Demos.Task)(100000)

        Private courses As String() = {"World History", "Economics", "Chemistry", "Biology", "Physics", "Cosmology", "Astronomy", "BioChemistry", "Classics", "English", "Political Science", "Marketing", "Accounting", "Education", "Communications", "Public Administration", "Architecture", "Business Admin", "Engineering", "Materials Science", "Anthropology", "Archaeology", "Egyptology", "Mathematics", "Astrophysics", "Oceanic Sciences", "Legal Studies", "Linguistics", "Computer Science", "BioPhysics", "Art History", "Molecular Biology", "Music", "Neuroscience", "Ecology", "Data Science", "Civil Engineering", "Electrical Engineering", "Climatology", "Geology", "Social Studies", "Psychology", "Psychiatry", "Urban Planning", "Theater", "Sociology", "Social Welfare", "Statistics", "Logic", "Philosophy", "European Studies", "Mid-East Studies", "Far-East Studies", "Genetics", "Film & TV", "Applied Science"}

        Private courseModules As String() = {"Overview and Introduction", "Module One", "Module Two", "Module Three", "Module Four", "Module Five", "Module Six", "Module Seven", "Module Eight", "Final Module", "Review and Final Exam Prep"}

        Private durations As System.TimeSpan() = {New System.TimeSpan(8, 0, 0), New System.TimeSpan(16, 0, 0), New System.TimeSpan(8, 0, 0), New System.TimeSpan(24, 0, 0), New System.TimeSpan(8, 0, 0), New System.TimeSpan(8, 0, 0), New System.TimeSpan(16, 0, 0), New System.TimeSpan(40, 0, 0), New System.TimeSpan(24, 0, 0), New System.TimeSpan(8, 0, 0), New System.TimeSpan(0, 0, 0)}

        Private dateTime As System.DateTime() = {New System.DateTime(2020, 04, 02), New System.DateTime(2020, 04, 03), New System.DateTime(2020, 04, 07), New System.DateTime(2020, 04, 8), New System.DateTime(2020, 04, 13), New System.DateTime(2020, 04, 14), New System.DateTime(2020, 04, 15), New System.DateTime(2020, 04, 17), New System.DateTime(2020, 04, 24), New System.DateTime(2020, 04, 29), New System.DateTime(2020, 4, 29, 17, 0, 0, 0)}

        Public Function Generate(ByVal count As Integer) As List(Of DevExpress.XtraGantt.Demos.Task)
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Clear()
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 0, .ParentUID = -1, .Name = "Company training", .Start = New System.DateTime(2020, 2, 17), .Duration = New System.TimeSpan(488, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 1, .ParentUID = 0, .Name = "Preparation stage", .Start = New System.DateTime(2020, 2, 17), .Duration = New System.TimeSpan(264, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 2, .ParentUID = 1, .Name = "Define objectives", .Start = New System.DateTime(2020, 2, 17), .Duration = New System.TimeSpan(16, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 3, .ParentUID = 1, .Name = "Identify Departments to be Trained", .Start = New System.DateTime(2020, 2, 19), .Duration = New System.TimeSpan(96, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 4, .ParentUID = 3, .Name = "Create a list of target departments", .Start = New System.DateTime(2020, 2, 19), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {2}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 5, .ParentUID = 3, .Name = "Perform departmental training needs analysis", .Start = New System.DateTime(2020, 2, 20), .Duration = New System.TimeSpan(56, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {4}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 6, .ParentUID = 3, .Name = "Compile results", .Start = New System.DateTime(2020, 3, 2), .Duration = New System.TimeSpan(16, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {5}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 7, .ParentUID = 3, .Name = "Create a list of courses", .Start = New System.DateTime(2020, 3, 4), .Duration = New System.TimeSpan(16, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {6}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 8, .ParentUID = 3, .Name = "Inform department heads of the training initiative", .Start = New System.DateTime(2020, 3, 4), .Duration = New System.TimeSpan(16, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {6}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 9, .ParentUID = 1, .Name = "Find for a courses vendor", .Start = New System.DateTime(2020, 3, 6), .Duration = New System.TimeSpan(80, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 10, .ParentUID = 9, .Name = "Create a list of vendors", .Start = New System.DateTime(2020, 3, 6), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {7}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 11, .ParentUID = 9, .Name = "Review and customize training material", .Start = New System.DateTime(2020, 3, 9), .Duration = New System.TimeSpan(56, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {10}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 12, .ParentUID = 9, .Name = "Selection of the vendor and conclusion of the contract", .Start = New System.DateTime(2020, 3, 18), .Duration = New System.TimeSpan(16, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {11}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 13, .ParentUID = 1, .Name = "Schedule courses", .Start = New System.DateTime(2020, 3, 20), .Duration = New System.TimeSpan(72, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 14, .ParentUID = 13, .Name = "Determine course dates, start and end times", .Start = New System.DateTime(2020, 3, 20), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {12}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 15, .ParentUID = 13, .Name = "Determine course locations", .Start = New System.DateTime(2020, 3, 20), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {12}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 16, .ParentUID = 13, .Name = "Post training outlines and schedule", .Start = New System.DateTime(2020, 3, 23), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {14}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 17, .ParentUID = 13, .Name = "Order training manuals and necessary material", .Start = New System.DateTime(2020, 3, 24), .Duration = New System.TimeSpan(56, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {16}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 18, .ParentUID = 1, .Name = "Finish stage", .Start = New System.DateTime(2020, 4, 1, 17, 0, 0, 0), .Duration = New System.TimeSpan(0, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {17}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = 19, .ParentUID = 0, .Name = "Implementation stage", .Start = New System.DateTime(2020, 4, 2), .Duration = New System.TimeSpan(160, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {18}})
            Dim requiredCoursesCount As Integer = count - 29
            Dim fullCoursesCount As Integer = requiredCoursesCount \ 12
            Dim additionalCourses As Integer = requiredCoursesCount - fullCoursesCount * 12
            Dim coursesDependencies As System.Collections.Generic.List(Of Integer) = New System.Collections.Generic.List(Of Integer)()
            Dim start = DevExpress.XtraGantt.Demos.DataGenerator.dateTime(0)
            Dim uid As Integer = 20
            For course As Integer = 0 To fullCoursesCount - 1
                Dim courseIndex As Integer = course Mod DevExpress.XtraGantt.Demos.DataGenerator.courses.Length
                Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.Start = start, .Duration = New System.TimeSpan(160, 0, 0), .Name = DevExpress.XtraGantt.Demos.DataGenerator.GetCourseName(courseIndex, If(course < DevExpress.XtraGantt.Demos.DataGenerator.courses.Length, 0, course)), .UID = uid, .ParentUID = 19})
                Dim _parentuid As Integer = uid
                uid = uid + 1
                Dim currentPredecessorUID As Integer = 18
                For m As Integer = 0 To DevExpress.XtraGantt.Demos.DataGenerator.courseModules.Length - 1
                    'Predecessors = new List<int> { currentPredecessorUID }
                    Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.Start = DevExpress.XtraGantt.Demos.DataGenerator.dateTime(m), .Duration = DevExpress.XtraGantt.Demos.DataGenerator.durations(m), .Name = DevExpress.XtraGantt.Demos.DataGenerator.courseModules(m), .ParentUID = _parentuid, .UID = uid})
                    currentPredecessorUID = uid
                    uid = uid + 1
                Next

                coursesDependencies.Add(currentPredecessorUID)
            Next

            For ac As Integer = 0 To additionalCourses - 1
                Dim courseIndex As Integer = ac Mod DevExpress.XtraGantt.Demos.DataGenerator.courses.Length
                'Predecessors = new List<int> { 18 }
                Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.Start = start, .Duration = New System.TimeSpan(160, 0, 0), .Name = DevExpress.XtraGantt.Demos.DataGenerator.courses(courseIndex) & " Additional", .UID = uid, .ParentUID = 19})
                coursesDependencies.Add(uid)
                uid = uid + 1
            Next

            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = 19, .Name = "Finish implementation stage", .Start = DevExpress.XtraGantt.Demos.DataGenerator.dateTime(DevExpress.XtraGantt.Demos.DataGenerator.dateTime.Length - 1), .Duration = New System.TimeSpan(0, 0, 0, 0), .Predecessors = coursesDependencies})
            Dim parentUID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = parentUID, .ParentUID = 0, .Name = "Closing stage", .Start = New System.DateTime(2020, 4, 30), .Duration = New System.TimeSpan(64, 0, 0)})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = "Issue certificates of completion to participants", .Start = New System.DateTime(2020, 4, 30), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 2))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = "Discuss evaluations, results, and process improvements", .Start = New System.DateTime(2020, 5, 1), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = "Collect feedback and compile results", .Start = New System.DateTime(2020, 5, 4), .Duration = New System.TimeSpan(24, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = "Discuss results with vendor for any improvements", .Start = New System.DateTime(2020, 5, 7), .Duration = New System.TimeSpan(8, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = " Create a list of best practices and FAQ for future training endeavors", .Start = New System.DateTime(2020, 5, 8), .Duration = New System.TimeSpan(16, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = parentUID, .Name = "Finish stage", .Start = New System.DateTime(2020, 5, 11, 17, 0, 0, 0), .Duration = New System.TimeSpan(0, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Call DevExpress.XtraGantt.Demos.DataGenerator.generated.Add(New DevExpress.XtraGantt.Demos.Task() With {.UID = DevExpress.XtraGantt.Demos.DataGenerator.generated.Count, .ParentUID = 0, .Name = "Finish company training", .Start = New System.DateTime(2020, 5, 11, 17, 0, 0, 0), .Duration = New System.TimeSpan(0, 0, 0), .Predecessors = New System.Collections.Generic.List(Of Integer) From {DevExpress.XtraGantt.Demos.DataGenerator.generated(CInt((DevExpress.XtraGantt.Demos.DataGenerator.generated.Count - 1))).UID}})
            Return DevExpress.XtraGantt.Demos.DataGenerator.generated
        End Function

        Private Function GetCourseName(ByVal course As Integer, ByVal rp As Integer) As String
            If rp = 0 Then Return DevExpress.XtraGantt.Demos.DataGenerator.courses(course)
            Return DevExpress.XtraGantt.Demos.DataGenerator.courses(course) & " " & rp
        End Function
    End Module
End Namespace

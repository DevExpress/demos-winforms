Imports System
Imports System.Collections.Generic
#If Not NET
Imports System.Data.Entity
#Else
using Microsoft.EntityFrameworkCore;
#End If
Imports System.Drawing
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.DXperience.Demos

Namespace DevExpress.HTML.Demos.Helpers

    Public Class GanttControlTask

        Public Property Id As Integer

        Public Property ParentId As Integer

        Public Property Name As String

        Public Property StartDate As Date

        Public Property FinishDate As Date

        Public Property Duration As TimeSpan

        Public Property Progress As Double

        Public Property Employee As String

        Public Property EmployeePhoto As Image

        Public Property Resource As String

        Public Property ColorName As String

        Public ReadOnly Property Predecessors As IList(Of Integer) = New List(Of Integer)()

        Public Shared Function LoadData() As IList(Of GanttControlTask)
            Return TaskStorage.LoadData()
        End Function
    End Class

    Public Class TaskStorage

#If NET
        static string GetDatabaseFilePath() {
            var filePath = DevAVDataDirectoryHelper.GetFile("devav.sqlite3");
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly))
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
            }
            catch { }
            return filePath;
        }
#End If
        Private Shared employeesCore As Dictionary(Of String, Employee) = New Dictionary(Of String, Employee)()

        Public Shared Function LoadData() As IList(Of GanttControlTask)
#If NET
            DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#Else
            Dim devAvDb As DevAVDb = New DevAVDb()
#End If
            devAvDb.Employees.Load()
            employeesCore = devAvDb.Employees.Local.ToDictionary(Function(employee) employee.FullName)
            Dim tasks = New List(Of GanttControlTask)()
            Dim softwareDevelopment As GanttControlTask = CreateTask(tasks, "Software Development", 0, -1, TutorialConstants.Now, 1, 24, "John Heart", "Danger", "Management")
            Dim analyzeRequirements As GanttControlTask = CreateTask(tasks, "Analyze Requirements", 1, softwareDevelopment.Id, softwareDevelopment.StartDate, 1, 100, "Ed Holmes", "Primary", "Analyst")
            Dim developFunctionalSpecifications As GanttControlTask = CreateTask(tasks, "Develop Functional Specifications", 2, softwareDevelopment.Id, analyzeRequirements.FinishDate, 1, 100, "Robert Reagan", "Warning", "Project Manager", 1)
            Dim developSoftware As GanttControlTask = CreateTask(tasks, "Develop Software", 3, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 5, 40, "Brett Wade", "Question", "Developer", developFunctionalSpecifications.Id)
            Dim developHelpSystem As GanttControlTask = CreateTask(tasks, "Develop Help System", 4, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 1, 90, "Greta Sims", "Success", "Developer", developFunctionalSpecifications.Id)
            Dim developUserManuals As GanttControlTask = CreateTask(tasks, "Develop User Manuals", 5, softwareDevelopment.Id, developHelpSystem.FinishDate, 1, 0, "Mary Stern", "Warning", "Developer", developHelpSystem.Id)
            Dim testSoftware As GanttControlTask = CreateTask(tasks, "Test Software", 6, softwareDevelopment.Id, developSoftware.FinishDate, 2, 0, "Samantha Piper", "Primary", "Testers", developSoftware.Id)
            Dim deployBeta As GanttControlTask = CreateTask(tasks, "Deploy Beta", 7, softwareDevelopment.Id, testSoftware.FinishDate, 0, 0, "John Heart", "Danger", "Management", testSoftware.Id)
            Dim collectFeedback As GanttControlTask = CreateTask(tasks, "Collect Feedback", 8, softwareDevelopment.Id, deployBeta.FinishDate, 2, 0, "Robert Reagan", "Warning", "Project Manager", deployBeta.Id)
            Dim fixBugs As GanttControlTask = CreateTask(tasks, "Fix Bugs", 9, softwareDevelopment.Id, collectFeedback.FinishDate, 2, 0, "Robert Reagan", "Warning", "Project Manager", collectFeedback.Id)
            Dim incorporateFeedBack As GanttControlTask = CreateTask(tasks, "Incorporate Feedback", 10, softwareDevelopment.Id, collectFeedback.FinishDate, 3, 0, "Ed Holmes", "Primary", "Analyst", collectFeedback.Id)
            Dim releaseSoftware As GanttControlTask = CreateTask(tasks, "Release Software", 11, softwareDevelopment.Id, incorporateFeedBack.FinishDate, 2, 0, "Brett Wade", "Question", "Developer", fixBugs.Id, incorporateFeedBack.Id)
            Dim createSoftwareMaintenanceTeam As GanttControlTask = CreateTask(tasks, "Create Software Maintenance Team", 12, softwareDevelopment.Id, deployBeta.FinishDate, 1, 0, "John Heart", "Danger", "Management", developSoftware.Id)
            Dim softwareDevelopmentComplete As GanttControlTask = CreateTask(tasks, "Software Development Complete", 13, softwareDevelopment.Id, releaseSoftware.FinishDate, 0, 0, "John Heart", "Danger", "Management", releaseSoftware.Id)
            softwareDevelopment.FinishDate = softwareDevelopmentComplete.FinishDate
            Call TryUpdateDates(tasks)
            Return tasks
        End Function

        Private Shared Function CreateTask(ByVal tasks As ICollection(Of GanttControlTask), ByVal name As String, ByVal id As Integer, ByVal parentId As Integer, ByVal start As Date, ByVal duration As Integer, ByVal progress As Double, ByVal employee As String, ByVal color As String, ByVal resource As String, ParamArray predecessors As Integer()) As GanttControlTask
            Dim ganttControlTask As GanttControlTask = New GanttControlTask()
            ganttControlTask.Id = id
            ganttControlTask.ParentId = parentId
            ganttControlTask.Name = name
            ganttControlTask.StartDate = start
            ganttControlTask.FinishDate = start + TimeSpan.FromDays(duration)
            ganttControlTask.Duration = TimeSpan.FromDays(duration)
            ganttControlTask.Progress = progress
            ganttControlTask.Employee = employee
            ganttControlTask.ColorName = color
            ganttControlTask.EmployeePhoto = LoadPhoto(employee)
            ganttControlTask.Resource = resource
            For i As Integer = 0 To predecessors.Length - 1
                Dim pid As Integer = predecessors(i)
                If pid < 0 Then Continue For
                ganttControlTask.Predecessors.Add(pid)
            Next

            tasks.Add(ganttControlTask)
            Return ganttControlTask
        End Function

        Private Shared Function LoadPhoto(ByVal resourceName As String) As Image
            Dim employee As Employee = Nothing
            If employeesCore.TryGetValue(resourceName, employee) Then Return employee.Photo
            Return Nothing
        End Function

        Private Shared Sub TryUpdateDates(ByVal tasks As IList(Of GanttControlTask))
            If tasks IsNot Nothing AndAlso tasks.Count > 0 Then
                Dim actualProjectStart As Date = CalcActualProjectStart()
                Dim projectStart As Date = tasks(0).StartDate
                For i As Integer = 0 To tasks.Count - 1
                    Dim task = tasks(i)
                    task.StartDate = actualProjectStart + TimeSpan.FromTicks(task.StartDate.Ticks - projectStart.Ticks)
                    task.FinishDate = actualProjectStart + TimeSpan.FromTicks(task.FinishDate.Ticks - projectStart.Ticks)
                Next
            End If
        End Sub

        Private Shared Function CalcActualProjectStart() As Date
            Return TutorialConstants.Now + TimeSpan.FromDays(4 - CInt(TutorialConstants.Now.DayOfWeek))
        End Function
    End Class
End Namespace

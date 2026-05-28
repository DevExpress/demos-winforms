Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Xml.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports System.Runtime.CompilerServices

Namespace DevExpress.XtraGantt.Demos

    Public Module ProjectXMLLoader

        <Extension()>
        Public Function GetElement(ByVal element As XElement, ByVal name As String) As XElement
            Return element.Element(XName.Get(name, element.GetDefaultNamespace().NamespaceName))
        End Function

        <Extension()>
        Public Function GetElements(ByVal element As XElement, ByVal name As String) As IEnumerable(Of XElement)
            Return element.Elements(XName.Get(name, element.GetDefaultNamespace().NamespaceName))
        End Function

        Public Sub TryUpdateDates(ByVal tasks As IList(Of TaskDataItem))
            If tasks IsNot Nothing AndAlso tasks.Count > 0 Then
                Dim actualProjectStart As Date = CalcActualProjectStart()
                'specific for dataSource
                Dim projectStart As Date = tasks(0).StartDate
                For i As Integer = 0 To tasks.Count - 1
                    Dim task = tasks(i)
                    task.StartDate = actualProjectStart + TimeSpan.FromTicks(task.StartDate.Ticks - projectStart.Ticks)
                    task.FinishDate = actualProjectStart + TimeSpan.FromTicks(task.FinishDate.Ticks - projectStart.Ticks)
                    If Equals(task.UID, "4") Then
                        task.ConstraintType = CInt(ConstraintType.StartNoEarlierThan)
                        task.ConstraintDate = task.StartDate + TimeSpan.FromDays(1)
                    End If

                    If Equals(task.UID, "9") Then
                        task.ConstraintType = CInt(ConstraintType.StartNoLaterThan)
                        task.ConstraintDate = task.StartDate
                    End If

                    If Equals(task.UID, "14") Then
                        task.ConstraintType = CInt(ConstraintType.MustFinishOn)
                        task.ConstraintDate = task.FinishDate
                    End If

                    If Equals(task.UID, "21") Then
                        task.ConstraintType = CInt(ConstraintType.FinishNoEarlierThan)
                        task.ConstraintDate = task.FinishDate
                    End If

                    If task.BaselineStartDate.HasValue Then task.BaselineStartDate = actualProjectStart + TimeSpan.FromTicks(task.BaselineStartDate.Value.Ticks - projectStart.Ticks)
                    If task.BaselineFinishDate.HasValue Then task.BaselineFinishDate = actualProjectStart + TimeSpan.FromTicks(task.BaselineFinishDate.Value.Ticks - projectStart.Ticks)
                Next
            '
            End If
        End Sub

        Private Function CalcActualProjectStart() As Date
            Dim now As Date = TutorialConstants.Now
            Return now + TimeSpan.FromDays(4 - CInt(now.DayOfWeek))
        End Function

        Private Class ResourceInfo

            Public Property UID As String

            Public Property Name As String
        End Class

        Private Function GetParentWBS(ByVal wbs As String) As String
            If String.IsNullOrEmpty(wbs) Then Return String.Empty
            Dim wbsPaths = wbs.Split("."c)
            Return If(wbsPaths.Length = 1, "0", String.Join(".", wbsPaths.Take(wbsPaths.Length - 1)))
        End Function

        Private Function GetParentUID(ByVal wbs As String, ByVal itemsByWBS As Dictionary(Of String, TaskDataItem)) As String
            Dim parentWBS = GetParentWBS(wbs)
            Dim parentItem As TaskDataItem = Nothing
            If itemsByWBS.TryGetValue(parentWBS, parentItem) Then Return parentItem.UID
            Return Nothing
        End Function

        Private Function ReadResources(ByVal projectElement As XElement) As IEnumerable(Of ResourceInfo)
            Return projectElement.GetElement("Resources").Elements().Where(Function(x) x.GetElement("Name") IsNot Nothing).[Select](Function(x) New ResourceInfo() With {.UID = x.GetElement("UID").Value, .Name = x.GetElement("Name").Value}).ToArray()
        End Function

        Private Function ReadPredecessorsUID(ByVal taskElement As XElement) As List(Of String)
            Dim predecessors = taskElement.GetElements("PredecessorLink")
            If predecessors Is Nothing Then Return Nothing
            Return predecessors.[Select](Function(x) x.GetElement("PredecessorUID").Value).ToList()
        End Function

        Private Function GetResoucesFromTask(ByVal projectElement As XElement, ByVal taskUID As String, ByVal resources As IEnumerable(Of ResourceInfo)) As IEnumerable(Of String)
            Return projectElement.GetElement("Assignments").Elements().Where(Function(x) taskUID.Equals(x.GetElement("TaskUID").Value)).[Select](Function(x) resources.SingleOrDefault(Function(res) res.UID.Equals(x.GetElement("ResourceUID").Value))).Where(Function(x) x IsNot Nothing AndAlso Not String.IsNullOrEmpty(x.Name)).[Select](Function(x) x.Name)
        End Function

        Private Function CreateTask(ByVal projectElement As XElement, ByVal taskNode As XElement, ByVal itemsByWBS As Dictionary(Of String, TaskDataItem), ByVal resources As IEnumerable(Of ResourceInfo)) As TaskDataItem
            Dim wbs = taskNode.GetElement("WBS").Value
            Dim uid = taskNode.GetElement("UID").Value
            Dim baseline = taskNode.GetElement("Baseline")
            Dim task = New TaskDataItem(uid, GetParentUID(wbs, itemsByWBS), taskNode.GetElement("Name").Value, taskNode.GetElement("Start").Value, taskNode.GetElement("Duration").Value, taskNode.GetElement("Finish").Value, baseline?.GetElement("Start").Value, baseline?.GetElement("Finish").Value, Convert.ToDouble(taskNode.GetElement("PercentComplete").Value, CultureInfo.InvariantCulture), ReadPredecessorsUID(taskNode), String.Join(", ", GetResoucesFromTask(projectElement, uid, resources)), Convert.ToBoolean(taskNode.GetElement("VisibleInTimeline")?.Value))
            itemsByWBS.Add(wbs, task)
            Return task
        End Function

        Private Function ReadTasks(ByVal projectElement As XElement) As List(Of TaskDataItem)
            Dim itemsByWBS = New Dictionary(Of String, TaskDataItem)()
            Dim resources = ReadResources(projectElement)
            Return projectElement.GetElement("Tasks").Elements().[Select](Function(item) CreateTask(projectElement, item, itemsByWBS, resources)).ToList()
        End Function

        Public Function LoadModel(ByVal xmlStream As Stream) As IList(Of TaskDataItem)
            Dim root = SafeXml.CreateXDocument(xmlStream).Root
            Dim tasks As IList(Of TaskDataItem) = ReadTasks(root)
            Return tasks
        End Function
    End Module
End Namespace

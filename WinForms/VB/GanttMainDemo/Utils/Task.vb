Imports System
Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Serialization

Namespace DevExpress.XtraGantt.Demos

    Public Class TaskDataItem

        Public Sub New()
            Predecessors = New List(Of String)()
        End Sub

        Public Property ParentUID As String

        Public Property StartDate As Date

        Public Property Duration As TimeSpan

        Public Property FinishDate As Date

        Public Property BaselineStartDate As Date?

        Public Property BaselineFinishDate As Date?

        Public Property Name As String

        Public Property UID As String

        Public Property Predecessors As List(Of String)

        Public Property Resources As String

        Public Property Progress As Double

        Public Property ConstraintType As Integer

        Public Property ConstraintDate As Date?

        Public Property VisibleInTimeline As Boolean

        Public Sub New(ByVal uid As String, ByVal parentUID As String, ByVal name As String, ByVal startDate As String, ByVal duration As String, ByVal finishDate As String, ByVal baselineStartDate As String, ByVal baselineFinishDate As String, ByVal progress As Double, ByVal predecessors As List(Of String), ByVal resources As String, ByVal visibleInTimeline As Boolean)
            Me.UID = uid
            Me.ParentUID = parentUID
            Me.Name = name
            Me.StartDate = ParseDateTime(startDate).Value
            Me.FinishDate = ParseDateTime(finishDate).Value
            Me.Duration = XmlConvert.ToTimeSpan(duration)
            Me.BaselineStartDate = ParseDateTime(baselineStartDate)
            Me.BaselineFinishDate = ParseDateTime(baselineFinishDate)
            Me.Progress = progress
            Me.Predecessors = predecessors
            Me.Resources = resources
            Me.VisibleInTimeline = visibleInTimeline
        End Sub

        Private Function ParseDateTime(ByVal inputString As String) As Date?
            If String.IsNullOrEmpty(inputString) Then Return Nothing
            Dim dt As Date
            Date.TryParse(inputString, dt)
            Return dt
        End Function
    End Class

    <XmlRoot("TaskBaselineOffset")>
    Public Class TaskItemBaseLineOffset

        <XmlElement(Order:=1)>
        Public Property UID As String

        <XmlElement("StartOffset", Order:=2)>
        Public Property BaselineStartOffset As Long

        <XmlElement("FinishOffset", Order:=3)>
        Public Property BaselineFinishOffset As Long
    End Class

    <XmlRoot("TaskTimelineInfo")>
    Public Class TaskTimelineInfo

        <XmlElement(Order:=1)>
        Public Property UID As String

        <XmlElement(Order:=2)>
        Public Property DisplayAsBar As Boolean
    End Class

    Public Class TaskSplitInfo

        Public Property UID As String

        Public Property StartDate As Date

        Public Property Duration As TimeSpan
    End Class
End Namespace

Imports System.ComponentModel

Namespace DevExpress.XtraTreeList.Demos

    Public Enum Priority
        Normal = 0
        Low = 1
        High = 2
    End Enum

    Public Class Project

        Private nameCore As String

        Private descriptionCore As String

        Private startDateCore As Date

        Private endDateCore As Date

        Private priorityCore As Priority

        Private ownerCore As Projects

        Private projectsCore As Projects

        Private isTaskCore As Boolean

        Public Sub New()
            ownerCore = Nothing
            nameCore = ""
            descriptionCore = ""
            isTaskCore = False
            endDateCore = Date.Today
            startDateCore = endDateCore
            priorityCore = Priority.Normal
            projectsCore = New Projects()
        End Sub

        Public Sub New(ByVal name As String, ByVal description As String, ByVal startDate As Date, ByVal endDate As Date, ByVal priority As Priority, ByVal isTask As Boolean)
            nameCore = name
            descriptionCore = description
            isTaskCore = isTask
            startDateCore = startDate
            endDateCore = endDate
            priorityCore = priority
            projectsCore = New Projects()
        End Sub

        Public Sub New(ByVal projects As Projects, ByVal name As String, ByVal description As String, ByVal startDate As Date, ByVal endDate As Date, ByVal priority As Priority, ByVal isTask As Boolean)
            Me.New(name, description, startDate, endDate, priority, isTask)
            projectsCore = projects
        End Sub

        <Browsable(False)>
        Public Property Owner As Projects
            Get
                Return ownerCore
            End Get

            Set(ByVal value As Projects)
                ownerCore = value
            End Set
        End Property

        Public Property IsTask As Boolean
            Get
                Return isTaskCore
            End Get

            Set(ByVal value As Boolean)
                If isTaskCore = value Then Return
                isTaskCore = value
                OnChanged()
            End Set
        End Property

        Public Property Name As String
            Get
                Return nameCore
            End Get

            Set(ByVal value As String)
                If Equals(Name, value) Then Return
                nameCore = value
                OnChanged()
            End Set
        End Property

        <Browsable(False)>
        Public Property Description As String
            Get
                Return descriptionCore
            End Get

            Set(ByVal value As String)
                If Equals(Description, value) Then Return
                descriptionCore = value
                OnChanged()
            End Set
        End Property

        Public Property StartDate As Date
            Get
                Return startDateCore
            End Get

            Set(ByVal value As Date)
                If StartDate = value Then Return
                startDateCore = value
                OnChanged()
            End Set
        End Property

        Public Property EndDate As Date
            Get
                Return endDateCore
            End Get

            Set(ByVal value As Date)
                If StartDate = value Then Return
                endDateCore = value
                OnChanged()
            End Set
        End Property

        Public Property Priority As Priority
            Get
                Return priorityCore
            End Get

            Set(ByVal value As Priority)
                If Priority = value Then Return
                priorityCore = value
                OnChanged()
            End Set
        End Property

        <Browsable(False)>
        Public ReadOnly Property Projects As Projects
            Get
                Return projectsCore
            End Get
        End Property

        Private Sub OnChanged()
            If ownerCore Is Nothing Then Return
            Dim index As Integer = ownerCore.IndexOf(Me)
            ownerCore.ResetItem(index)
        End Sub
    End Class

    '<treeList1>
    Public Class Projects
        Inherits BindingList(Of Project)
        Implements TreeList.IVirtualTreeListData

        Private Sub VirtualTreeGetChildNodes(ByVal info As VirtualTreeGetChildNodesInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes
            Dim obj As Project = TryCast(info.Node, Project)
            info.Children = obj.Projects
        End Sub

        Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal _item As Project)
            _item.Owner = Me
            MyBase.InsertItem(index, _item)
        End Sub

        Private Sub VirtualTreeGetCellValue(ByVal info As VirtualTreeGetCellValueInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeGetCellValue
            Dim obj As Project = TryCast(info.Node, Project)
            Select Case info.Column.Caption
                Case "Name"
                    info.CellData = obj.Name
                Case "Description"
                    info.CellData = obj.Description
                Case "StartDate"
                    info.CellData = obj.StartDate
                Case "EndDate"
                    info.CellData = obj.EndDate
                Case "Priority"
                    info.CellData = obj.Priority
            End Select
        End Sub

        Private Sub VirtualTreeSetCellValue(ByVal info As VirtualTreeSetCellValueInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeSetCellValue
            Dim obj As Project = TryCast(info.Node, Project)
            Select Case info.Column.Caption
                Case "Name"
                    obj.Name = CStr(info.NewCellData)
                Case "Description"
                    obj.Description = CStr(info.NewCellData)
                Case "StartDate"
                    obj.StartDate = CDate(info.NewCellData)
                Case "EndDate"
                    obj.EndDate = CDate(info.NewCellData)
                Case "Priority"
                    obj.Priority = CType(info.NewCellData, Priority)
            End Select
        End Sub
    End Class
'</treeList1>
End Namespace

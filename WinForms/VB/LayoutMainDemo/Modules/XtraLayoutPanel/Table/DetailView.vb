Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Layout
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Extensions
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

    Public Partial Class DetailView
        Inherits XtraLayoutPanelDemoViewBase

        Private _newColumnButtonRect As Rectangle

        Private _newRowButtonRect As Rectangle

        Private _newRowButtonState As ObjectState

        Private _newColumnButtonState As ObjectState

        Public Sub New()
            InitializeComponent()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ShowGrid As Boolean
            Get
                Return tablePanel.ShowGrid = DefaultBoolean.True
            End Get

            Set(ByVal value As Boolean)
                tablePanel.ShowGrid = If(value, DefaultBoolean.True, DefaultBoolean.False)
                InvalidatePanel()
            End Set
        End Property

        Private Shared ReadOnly markerObj As Object = New Object()

        Protected Overrides Sub InitializeControls()
            MyBase.InitializeControls()
            deHireDate.DateTime = TutorialConstants.Now - TimeSpan.FromDays(365 * 5)
            deBirthDate.DateTime = TutorialConstants.Now - TimeSpan.FromDays(365 * 35)
            tablePanel.ForEachTableEntity(Sub(x) x.Tag = markerObj)
        End Sub

        Public Overrides Sub ResetLayout()
            LayoutPanel.SuspendLayout()
            Try
                MyBase.ResetLayout()
                For n As Integer = tablePanel.Rows.Count - 1 To 0 Step -1
                    If Not ReferenceEquals(tablePanel.Rows(n).Tag, markerObj) Then tablePanel.Rows.RemoveAt(n)
                Next

                For n As Integer = tablePanel.Columns.Count - 1 To 0 Step -1
                    If Not ReferenceEquals(tablePanel.Columns(n).Tag, markerObj) Then tablePanel.Columns.RemoveAt(n)
                Next
            Finally
                LayoutPanel.ResumeLayout()
            End Try
        End Sub

#Region "Rects"
        Private Property NewColumnButtonRect As Rectangle
            Get
                Return _newColumnButtonRect
            End Get

            Set(ByVal value As Rectangle)
                If NewColumnButtonRect = value Then Return
                _newColumnButtonRect = value
                InvalidatePanel()
            End Set
        End Property

        Private Property NewRowButtonRect As Rectangle
            Get
                Return _newRowButtonRect
            End Get

            Set(ByVal value As Rectangle)
                If NewRowButtonRect = value Then Return
                _newRowButtonRect = value
                InvalidatePanel()
            End Set
        End Property

        Private Property NewColumnButtonState As ObjectState
            Get
                Return _newColumnButtonState
            End Get

            Set(ByVal value As ObjectState)
                If NewColumnButtonState = value Then Return
                _newColumnButtonState = value
                InvalidatePanel()
            End Set
        End Property

        Private Property NewRowButtonState As ObjectState
            Get
                Return _newRowButtonState
            End Get

            Set(ByVal value As ObjectState)
                If NewRowButtonState = value Then Return
                _newRowButtonState = value
                InvalidatePanel()
            End Set
        End Property

#End Region
#Region "Paint"
        Private Sub OnTablePanelPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
            CalculateRectangles()
            Using cache As GraphicsCache = New GraphicsCache(e)
                If ShowGrid Then DrawButtons(cache)
            End Using
        End Sub

        Private Sub DrawButtons(ByVal cache As GraphicsCache)
            cache.DrawImageUnscaled(CreateColumnImage, NewColumnButtonRect)
            cache.DrawImageUnscaled(CreateRowImage, NewRowButtonRect)
        End Sub

#End Region
#Region "Events"
        Private Sub OnTablePanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            CalculateObjectStates(e)
        End Sub

        Private Sub OnTablePanelMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            CalculateObjectStates(e)
        End Sub

        Private Sub OnTablePanelMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            CalculateRectangles()
            CalculateObjectStates(e)
        End Sub

        Private Sub OnTablePanelMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            If NewColumnButtonRect.Contains(e.Location) Then
                CreateColumn()
            ElseIf NewRowButtonRect.Contains(e.Location) Then
                CreateRow()
            End If
        End Sub

#End Region
#Region "Calculations"
        Private Shared ReadOnly ButtonSize As Size = ScaleUtils.ScaleValue(New Size(16, 16))

        Private Sub CalculateRectangles()
            NewColumnButtonRect = LayoutPanel.Bounds.RightTop().CreateRect(ButtonSize).WithOffset(-ButtonSize.Width, ButtonSize.Height)
            NewRowButtonRect = LayoutPanel.Bounds.RightBottom().CreateRect(ButtonSize).WithOffset(-ButtonSize.Width, -ButtonSize.Height)
        End Sub

        Private Sub CalculateObjectStates(ByVal e As MouseEventArgs)
            NewColumnButtonState = CalculateObjectStateCore(NewColumnButtonRect, e)
            NewRowButtonState = CalculateObjectStateCore(NewRowButtonRect, e)
        End Sub

        Private Function CalculateObjectStateCore(ByVal bounds As Rectangle, ByVal e As MouseEventArgs) As ObjectState
            Return If(bounds.Contains(e.Location) AndAlso (e.Button And MouseButtons.Left) = 0, ObjectState.Hot, ObjectState.Normal)
        End Function

#End Region
        Private Sub CreateColumn()
            tablePanel.Columns.Add(New TablePanelColumn(TablePanelEntityStyle.Relative, 50F))
        End Sub

        Private Sub CreateRow()
            tablePanel.Rows.Add(New TablePanelRow(TablePanelEntityStyle.Absolute, 38F))
        End Sub

        Private Sub InvalidatePanel()
            LayoutPanel.Invalidate()
        End Sub

        Private ReadOnly Property CreateColumnImage As Image
            Get
                Return imageList.GetImage(If(NewColumnButtonState = ObjectState.Hot, 1, 0), New Size(16, 16))
            End Get
        End Property

        Private ReadOnly Property CreateRowImage As Image
            Get
                Return imageList.GetImage(If(NewRowButtonState = ObjectState.Hot, 3, 2), New Size(16, 16))
            End Get
        End Property

        Public Overrides ReadOnly Property LayoutPanel As XtraLayoutPanelBase
            Get
                Return tablePanel
            End Get
        End Property

        Public ReadOnly Property TableLayoutPanel As TablePanel
            Get
                Return tablePanel
            End Get
        End Property
    End Class
End Namespace

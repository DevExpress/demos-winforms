Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace PhotoViewer

    Public Partial Class DateFilter
        Inherits XtraUserControl

        Private Shared ReadOnly _selectionChanged As Object = New Object()

        Public Sub New()
            InitializeComponent()
            AddHandler calendarStartDate.SizeChanged, AddressOf startDate_SizeChanged
        End Sub

        Private Sub startDate_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateStartDateLocation()
        End Sub

        Protected Overridable Sub UpdateStartDateLocation()
            Dim pt As Point = New Point(DisplayRectangle.X + (DisplayRectangle.Width - calendarStartDate.Width) \ 2, DisplayRectangle.Y + (panel1.Top - DisplayRectangle.Y - calendarStartDate.Height) \ 2)
            pt.X = Math.Max(0, pt.X)
            pt.Y = Math.Max(0, pt.Y)
            calendarStartDate.Location = pt
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            UpdateStartDateLocation()
        End Sub

        Public ReadOnly Property StartDate As Date
            Get
                Return If(allowFilterCheck.Checked, calendarStartDate.SelectionStart, Date.MinValue)
            End Get
        End Property

        Public ReadOnly Property EndDate As Date
            Get
                Return If(allowFilterCheck.Checked, calendarStartDate.SelectionEnd, Date.MinValue)
            End Get
        End Property

        Public ReadOnly Property AllowFilter As Boolean
            Get
                Return allowFilterCheck.Checked
            End Get
        End Property

        Protected Sub RaiseSelectionChanged()
            Dim handler As EventHandler = TryCast(Events(_selectionChanged), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Custom Event SelectionChanged As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(_selectionChanged, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(_selectionChanged, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Private Sub allowFilterCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseSelectionChanged()
        End Sub

        Private Sub startDate_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseSelectionChanged()
        End Sub

        Private Sub endDate_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseSelectionChanged()
        End Sub
    End Class
End Namespace

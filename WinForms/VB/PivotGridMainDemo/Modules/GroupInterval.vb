Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.PivotGrid.Utils
Imports System.Collections.Generic
Imports System.Threading
Imports System.Globalization

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class GroupInterval
        Inherits TutorialControl

        Private fieldOrderDateBinding As DataSourceColumnBinding

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            fieldOrderDateBinding = CType(fieldOrderDate.DataBinding, DataSourceColumnBinding)
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private Sub GroupInterval_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            InitComboBox()
            ceProductInterval.Checked = True
            pivotGridControl1.HeaderImages = HeadersImageList
            fieldExtendedPrice.ImageIndex = 3
        End Sub

        Private Sub InitComboBox()
            PopulateItems(GroupIntervalHelper.BasicDiscreteDateTimeGroupIntervals)
            PopulateItems(GroupIntervalHelper.BasicContinuousDateTimeGroupIntervals)
            PopulateItems(GroupIntervalHelper.AdditionalDiscreteDateTimeGroupIntervals)
            PopulateItems(GroupIntervalHelper.AdditionalContinuousDateTimeGroupIntervals)
            icbGroupInterval.SelectedIndex = 7
        End Sub

        Private Sub PopulateItems(ByVal intervals As IEnumerable(Of PivotGroupInterval))
            For Each interval As PivotGroupInterval In intervals
                Dim intervalCaption As String = GroupIntervalHelper.GetDateTimeGroupIntervalCaption(interval)
                icbGroupInterval.Properties.Items.Add(New ImageComboBoxItem(intervalCaption, interval, -1))
            Next
        End Sub

        '<icbGroupInterval>
        Private Sub icbGroupInterval_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldOrderDate.FilterValues.Clear()
            fieldOrderDateBinding.GroupInterval = CType(icbGroupInterval.EditValue, PivotGroupInterval)
        End Sub

        '</icbGroupInterval>
        '<ceProductInterval>
        Private Sub ceProductInterval_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldProductAlphabetical.Visible = ceProductInterval.Checked
        End Sub

        '</ceProductInterval>
        Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If e.Field Is fieldOrderDate Then
                If fieldOrderDateBinding.GroupInterval = PivotGroupInterval.DateQuarter Then
                    e.DisplayText = String.Format("Qtr {0}", e.Value)
                    If e.ValueType = PivotGridValueType.Total Then e.DisplayText += " Total"
                End If

                If fieldOrderDateBinding.GroupInterval = PivotGroupInterval.DateWeekYear Then
                    Dim [date] As Date = CDate(e.Value)
                    Dim culture As CultureInfo = Thread.CurrentThread.CurrentUICulture
                    Dim weekNumber As Integer = culture.Calendar.GetWeekOfYear([date], culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek)
                    e.DisplayText = String.Format("Week {0} of {1}", weekNumber, [date].Year)
                    If e.ValueType = PivotGridValueType.Total Then e.DisplayText += " Total"
                End If
            End If
        End Sub

        Private Sub pivotGridControl1_MenuItemClick(ByVal sender As Object, ByVal e As PivotGridMenuItemClickEventArgs)
            If e.Field Is fieldOrderDate Then
                If TypeOf e.Item.Tag Is PivotGroupInterval Then
                    BeginInvoke(New Action(Sub() icbGroupInterval.EditValue = e.Item.Tag))
                End If
            End If
        End Sub
    End Class
End Namespace

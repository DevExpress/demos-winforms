Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Html

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Partial Class PCMarket
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitComputersData()
            SetUpMRUFilters()
            SetUpRecordHeaderPanel()
        End Sub

        Private configurations As List(Of ComputersData.PCConfiguration)

        Private Sub InitComputersData()
            Dim dbFileName = DataDirectoryHelper.GetDataFile("Computers.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                configurations = ComputersData.InitOrdersData(dbFileName, vGridControl1, 147000)
                ComputersData.InitEditors(vGridControl1)
            End If
        End Sub

        Private Sub SetUpMRUFilters()
            vGridControl1.ActiveFilterString = "([ModelPrice] >= 1250 And [ModelPrice] <= 2000) And [AverageRating] >= 6 And [ProcReleaseYear] >= 2020 and [Discount] >= 0.1"
            vGridControl1.ActiveFilterString = "([ModelPrice] >= 1250 And [ModelPrice] <= 2000) And [AverageRating] >= 6"
            vGridControl1.ActiveFilterString = "[AverageRating] >= 6 And [ProcReleaseYear] >= 2020 and [Discount] >= 0.1"
        End Sub

        Private Sub SetUpRecordHeaderPanel()
            vGridControl1.OptionsHint.ShowRecordHeaderHints = False
            vGridControl1.OptionsBehavior.HyperlinkClickMode = HyperlinkClickMode.Click
            htmlCtx = New DxHtmlPainterContext()
            AddHandler vGridControl1.CustomDrawRecordHeader, AddressOf OnCustomDrawRecordHeader
            AddHandler vGridControl1.MouseDown, AddressOf VGridControl1_MouseDown
            AddHandler vGridControl1.MouseMove, AddressOf VGridControl1_MouseMove
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            AddHandler vGridControl1.RecordCountChanged, AddressOf OnRecordCountChanged
            vGridControl1.FocusedRecord = 0
            UpdateCaption(vGridControl1.RecordCount, configurations.Count)
        End Sub

        Private orders As HashSet(Of Integer) = New HashSet(Of Integer)()

        Private htmlCtx As DxHtmlPainterContext

        Private Sub VGridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo = vGridControl1.CalcHitInfo(e.Location)
            Dim dataSourceRowIndex As Integer = vGridControl1.GetDataSourceRecordIndex(hitInfo.RecordIndex)
            vGridControl1.Cursor = htmlCtx.GetCursor(e.Location, dataSourceRowIndex)
        End Sub

        Private Sub VGridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo = vGridControl1.CalcHitInfo(e.Location)
            If hitInfo.HitInfoType = HitInfoTypeEnum.RecordHeader Then
                Dim dataSourceRowIndex As Integer = vGridControl1.GetDataSourceRecordIndex(hitInfo.RecordIndex)
                Dim htmlHitInfo = htmlCtx.CalcHitInfo(e.Location, dataSourceRowIndex)
                If htmlHitInfo IsNot Nothing AndAlso htmlHitInfo.HasId("btn-add") Then
                    If Not orders.Remove(dataSourceRowIndex) Then orders.Add(dataSourceRowIndex)
                    vGridControl1.InvalidateRecordHeader(hitInfo.RecordIndex)
                End If
            End If
        End Sub

        Private Sub OnCustomDrawRecordHeader(ByVal sender As Object, ByVal e As Events.CustomDrawRecordHeaderEventArgs)
            If e.Record < 0 Then Return
            e.DefaultDraw()
            Dim dataSourceRowIndex As Integer = vGridControl1.GetDataSourceRecordIndex(e.Record)
            e.DrawHtml(headerTemplate, htmlCtx, Sub(args)
                args.InteractivityKey = dataSourceRowIndex
                Dim isAddedToCart As Boolean = orders.Contains(dataSourceRowIndex)
                args.SetFieldValue("Added", isAddedToCart)
                args.SetFieldValue("AddButtonCaption", If(isAddedToCart, "ADDED TO CART", "ADD TO CART"))
            End Sub)
        End Sub

        Private Sub OnRecordCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateCaption(vGridControl1.RecordCount, configurations.Count)
        End Sub

        Private Sub UpdateCaption(ByVal visible As Integer, ByVal total As Integer)
            vGridControl1.Caption = String.Format("Showing {0:n0} out of {1:n0} configurations", visible, total)
        End Sub
    End Class
End Namespace

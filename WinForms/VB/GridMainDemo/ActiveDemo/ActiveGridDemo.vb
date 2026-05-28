Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing

Namespace DevExpress.ActiveDemos

    Public Class ActiveGridDemo
        Inherits ActiveDemo

        Private fgridControl As GridControl

        Public Sub New(ByVal fgridControl As GridControl)
            Me.fgridControl = fgridControl
        End Sub

        Public ReadOnly Property GridControl As GridControl
            Get
                Return fgridControl
            End Get
        End Property

        Public ReadOnly Property ActiveView As BaseView
            Get
                Return GridControl.DefaultView
            End Get
        End Property 'TODO

        Public ReadOnly Property ActiveGridView As GridView
            Get
                If ActiveView IsNot Nothing AndAlso (TypeOf ActiveView Is GridView) Then
                    Return TryCast(ActiveView, GridView)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Public ReadOnly Property ActiveBandedGridView As BandedGridView
            Get
                If ActiveView IsNot Nothing AndAlso (TypeOf ActiveView Is BandedGridView) Then
                    Return TryCast(ActiveView, BandedGridView)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Public ReadOnly Property ActiveGridViewInfo As GridViewInfo
            Get
                If ActiveGridView IsNot Nothing Then
                    Return GetGridViewInfo(ActiveGridView)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Public ReadOnly Property ActiveBandedGridViewInfo As BandedGridViewInfo
            Get
                If ActiveBandedGridView IsNot Nothing Then
                    Dim propertyInfo As PropertyInfo = GetType(BandedGridView).GetProperty("ViewInfo")
                    If propertyInfo IsNot Nothing Then
                        Return TryCast(propertyInfo.GetValue(ActiveGridView, Nothing), BandedGridViewInfo)
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Public Sub SelectCellByMouse(ByVal column As GridColumn, ByVal row As Integer)
            If Actions.Canceled OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            If TypeOf column.View Is GridView Then
                Dim gridView As GridView = TryCast(column.View, GridView)
                gridView.MakeColumnVisible(column)
                Dim viewInfo As GridViewInfo = GetGridViewInfo(gridView)
                Dim cell As GridCellInfo = viewInfo.GetGridCellInfo(row, column)
                If cell IsNot Nothing Then
                    Dim r As Rectangle = cell.Bounds
                    Actions.MouseClick(fgridControl, New Point(r.Left + r.Width \ 2, r.Top + r.Height \ 2))
                End If
            End If
        End Sub

        Public Sub SelectCellByKeyBoard(ByVal column As GridColumn, ByVal row As Integer)
            If Actions.Canceled OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            If TypeOf column.View Is GridView Then
                Dim gridView As GridView = TryCast(column.View, GridView)
                If gridView.FocusedColumn Is Nothing Then
                    SelectCellByMouse(column, row)
                Else
                    While gridView.FocusedColumn IsNot column
                        If Actions.Canceled Then Return
                        If gridView.FocusedColumn.VisibleIndex < column.VisibleIndex Then
                            Actions.SendString(GridControl, "[Right]")
                        Else
                            Actions.SendString(GridControl, "[Left]")
                        End If
                    End While

                    If row > -1 AndAlso row < gridView.RowCount Then
                        While GetFocusedRow(gridView) <> row
                            If Actions.Canceled Then Return
                            If GetFocusedRow(gridView) > row Then
                                Actions.SendString(GridControl, "[Up]")
                            Else
                                Actions.SendString(GridControl, "[Down]")
                            End If
                        End While
                    End If
                End If
            End If
        End Sub

        Public Sub ClickGridColumn(ByVal column As GridColumn)
            If Actions.Canceled OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            If TypeOf column.View Is GridView Then Actions.MouseClick(GridControl, GetColumnLocationAtCenter(column))
        End Sub

        Public Sub GroupByColumn(ByVal column As GridColumn)
            GroupByColumn(column, column.View.SortInfo.GroupCount)
        End Sub

        Public Sub GroupByColumn(ByVal column As GridColumn, ByVal groupIndex As Integer)
            If Actions.Canceled OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            If TypeOf column.View Is GridView Then
                Dim gridView As GridView = TryCast(column.View, GridView)
                gridView.OptionsView.ShowGroupPanel = True
                gridView.MakeColumnVisible(column)
                Dim viewInfo As GridViewInfo = GetGridViewInfo(gridView)
                If groupIndex < 0 Then groupIndex = 0
                If groupIndex >= gridView.SortInfo.GroupCount Then groupIndex = gridView.SortInfo.GroupCount
                Dim r As Rectangle = viewInfo.ViewRects.GroupPanel
                Dim pt As Point
                If groupIndex = 0 Then
                    pt = New Point(r.Left + 2, r.Top + 2)
                Else
                    r = viewInfo.GroupPanel.Rows(groupIndex - 1).Bounds
                    'r = viewInfo.GroupPanel.Rows[groupIndex - 1].CaptionInfo.CaptionRect;
                    pt = New Point(r.Left + groupIndex * 100, r.Bottom - 5) 'TODO
                End If

                Actions.MouseDown(fgridControl, GetColumnLocationAtCenter(column))
                Actions.MoveMousePointTo(fgridControl, pt)
                Actions.MouseUp(fgridControl, pt)
            End If
        End Sub

        Public Sub ClickMasterRecordIcon(ByVal view As GridView, ByVal row As Integer)
            If Actions.Canceled Then Return
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            If viewInfo Is Nothing Then Return
            If row < viewInfo.RowsInfo.Count Then
                Dim rowInfo As GridDataRowInfo = TryCast(viewInfo.RowsInfo(row), GridDataRowInfo)
                If rowInfo IsNot Nothing AndAlso rowInfo.IsMasterRow Then
                    Dim r As Rectangle = Rectangle.Empty
                    For Each cellInfo As GridCellInfo In rowInfo.Cells
                        If Not cellInfo.CellButtonRect.IsEmpty Then
                            r = cellInfo.CellButtonRect
                            Exit For
                        End If
                    Next

                    ActiveActions.Delay(1000)
                    If Not r.IsEmpty Then Actions.MouseClick(fgridControl, New Point(r.Left + r.Width \ 2, r.Top + r.Height \ 2))
                End If
            End If
        End Sub

        Public Sub ColumnResize(ByVal column As GridColumn, ByVal delta As Integer)
            If column IsNot Nothing AndAlso TypeOf column.View Is GridView Then ColumnResize(column, TryCast(column.View, GridView), delta)
        End Sub

        Public Sub ColumnResize(ByVal column As GridColumn, ByVal view As GridView, ByVal delta As Integer)
            If Actions.Canceled OrElse view Is Nothing OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            If viewInfo Is Nothing Then Return
            Dim r As Rectangle = GetGridColumnInfo(view, column).Bounds
            Dim pt As Point = New Point(r.Right, r.Top + r.Height \ 2)
            Actions.MouseDown(fgridControl, pt)
            pt.X += delta
            Actions.MoveMousePointTo(fgridControl, pt)
            Actions.MouseUp(fgridControl, pt)
        End Sub

        Public Sub ColumnBestFit(ByVal column As GridColumn)
            ColumnBestFit(column, String.Empty)
        End Sub

        Public Sub ColumnBestFit(ByVal column As GridColumn, ByVal message As String)
            If column IsNot Nothing AndAlso TypeOf column.View Is GridView Then ColumnBestFit(column, TryCast(column.View, GridView), message)
        End Sub

        Public Sub ColumnBestFit(ByVal column As GridColumn, ByVal view As GridView)
            ColumnBestFit(column, view, String.Empty)
        End Sub

        Public Sub ColumnBestFit(ByVal column As GridColumn, ByVal view As GridView, ByVal message As String)
            If Actions.Canceled OrElse view Is Nothing OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            If viewInfo Is Nothing Then Return
            Dim r As Rectangle = GetGridColumnInfo(view, column).Bounds
            Dim pt As Point = New Point(r.Right, r.Top + r.Height \ 2)
            Actions.MoveMousePointTo(fgridControl, pt)
            If Not Equals(message, String.Empty) Then
                ShowMessage(message)
            Else
                ActiveActions.Delay(300)
            End If

            Actions.MouseDblClick(fgridControl, pt)
        End Sub

        Public Sub ViewZoom(ByVal view As GridView)
            ViewZoom(view, String.Empty)
        End Sub

        Public Sub ViewZoom(ByVal view As GridView, ByVal message As String)
            If Actions.Canceled Then Return
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            If viewInfo Is Nothing Then Return
            For i As Integer = 0 To viewInfo.ColumnsInfo.Count - 1
                If viewInfo.ColumnsInfo(i).Type = GridColumnInfoType.Indicator Then
                    Dim pt As Point = GetPointAtCenter(viewInfo.ColumnsInfo(i).Bounds)
                    Actions.MoveMousePointTo(fgridControl, pt)
                    If Not Equals(message, String.Empty) Then ShowMessage(message)
                    Actions.MouseClick(fgridControl, pt)
                    Exit For
                End If
            Next
        End Sub

        Public Sub ExpandCollapseRow(ByVal view As GridView, ByVal groupRow As Integer)
            If Actions.Canceled Then Return
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            Dim groupRowCount As Integer = 0
            If viewInfo Is Nothing Then Return
            For i As Integer = 0 To viewInfo.RowsInfo.Count - 1
                If viewInfo.RowsInfo(i).IsGroupRow Then
                    If groupRowCount = groupRow Then
                        Actions.MouseClick(fgridControl, GetPointAtCenter(CType(viewInfo.RowsInfo(i), GridGroupRowInfo).ButtonBounds))
                        Exit For
                    End If

                    groupRowCount += 1
                End If
            Next
        End Sub

        Public Function GetGroupPanelRectangle(ByVal view As GridView) As Rectangle
            If Actions.Canceled Then Return Rectangle.Empty
            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            Return viewInfo.ViewRects.GroupPanel
        End Function

        Public Sub ClickControlNavigatorButton(ByVal buttonType As NavigatorButtonType)
            If Actions.Canceled Then Return
            Dim button As NavigatorButton = GridControl.EmbeddedNavigator.Buttons.ButtonByButtonType(buttonType)
            If button Is Nothing Then Return
            Dim viewInfo As NavigatorButtonsViewInfo = GetGridNavigatorButtonsViewInfo()
            If viewInfo Is Nothing Then Return
            Dim buttonViewInfo As NavigatorButtonViewInfo = viewInfo.GetButtonViewInfo(button)
            If buttonViewInfo Is Nothing OrElse buttonViewInfo.Bounds.IsEmpty Then Return
            Dim pt As Point = GridControl.PointToScreen(GridControl.EmbeddedNavigator.Location)
            pt.X += buttonViewInfo.Bounds.X + buttonViewInfo.Bounds.Width \ 2
            pt.Y += buttonViewInfo.Bounds.Y + buttonViewInfo.Bounds.Height \ 2
            Actions.MouseClick(pt)
            ActiveActions.Delay(300)
        End Sub

        Private Function GetColumnLocationAtCenter(ByVal column As GridColumn) As Point
            Dim gridView As GridView = TryCast(column.View, GridView)
            gridView.MakeColumnVisible(column)
            Dim viewInfo As GridViewInfo = GetGridViewInfo(gridView)
            Return GetPointAtCenter(viewInfo.ColumnsInfo(column).Bounds)
        End Function

        Public Shared Function GetGridViewInfo(ByVal gridView As GridView) As GridViewInfo
            If gridView Is Nothing Then Return Nothing
            Dim res As GridViewInfo = TryCast(gridView.GetViewInfo(), GridViewInfo)
            If res Is Nothing Then Return Nothing
            If Not res.IsReady Then gridView.LayoutChanged()
            Return res
        End Function

        Private Function GetFocusedRow(ByVal gridView As GridView) As Integer
            Return CInt(gridView.FocusedRowHandle)
        End Function

        Private Function GetGridColumnInfo(ByVal column As GridColumn) As GridColumnInfoArgs
            Return GetGridColumnInfo(TryCast(column.View, GridView), column)
        End Function

        Private Function GetGridColumnInfo(ByVal view As GridView, ByVal column As GridColumn) As GridColumnInfoArgs
            If column.View IsNot view Then
                For Each col As GridColumn In view.Columns
                    If Equals(col.Name, column.Name) Then
                        column = col
                        Exit For
                    End If
                Next
            End If

            Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
            Return viewInfo.ColumnsInfo(column)
        End Function

        Private Function GetGridNavigatorButtonsViewInfo() As NavigatorButtonsViewInfo
            Dim propertyInfo As PropertyInfo = GridControl.EmbeddedNavigator.Buttons.GetType().GetProperty("ViewInfo", BindingFlags.Instance Or BindingFlags.GetProperty Or BindingFlags.NonPublic, Nothing, GetType(NavigatorButtonsViewInfo), New Type(-1) {}, Nothing)
            If propertyInfo IsNot Nothing Then
                Return TryCast(propertyInfo.GetValue(GridControl.EmbeddedNavigator.Buttons, Nothing), NavigatorButtonsViewInfo)
            Else
                Return Nothing
            End If
        End Function

        '---------------------------------------------------------------
        Public Sub ClickGridColumnAtFilterButton(ByVal column As GridColumn)
            ClickGridColumnAtElement(column, GetType(GridFilterButtonInfoArgs))
        End Sub

        Public Sub ClickGridColumnAtElement(ByVal column As GridColumn, ByVal type As Type)
            If Actions.Canceled OrElse column Is Nothing OrElse column.VisibleIndex < 0 Then Return
            If TypeOf column.View Is GridView Then
                Dim p As Point = GetColumnLocationAtElement(column, type)
                If p <> Point.Empty Then Actions.MouseClick(GridControl, p)
            End If
        End Sub

        Private Function GetColumnLocationAtElement(ByVal column As GridColumn, ByVal type As Type) As Point
            Dim gridView As GridView = TryCast(column.View, GridView)
            gridView.MakeColumnVisible(column)
            Dim viewInfo As GridViewInfo = GetGridViewInfo(gridView)
            Dim args As ObjectInfoArgs = Nothing
            For Each info As DrawElementInfo In viewInfo.ColumnsInfo(column).InnerElements
                If info.ElementInfo.GetType().Equals(type) Then
                    args = info.ElementInfo
                    Exit For
                End If
            Next

            If args IsNot Nothing Then Return GetPointAtCenter(args.Bounds)
            Return Point.Empty
        End Function
    End Class
End Namespace

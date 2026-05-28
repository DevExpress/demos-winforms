Imports DevExpress.Data
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports LipsumDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.LipsumDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Paging", "Paging.cs")>
    Public Module Paging

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = New System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.LipsumObject)()
            gridView.PopulateColumns()
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Unbound Columns"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Virtual Paging", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.LipsumDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("VirtualServerModeSource", "VirtualServerModeConfigurationInfo", "VirtualServerModeRowsEventArgs", "CancellationToken", "LipsumObject", "Task", "HtmlPagerHelper", "ICollection", "IEnumerable", "Func", "LoremIpsum")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ConfigurationChanged", "MoreRows"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(202)>
        Public Sub VirtualPaging(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Creating the VirtualSource
            Dim virtualSource = New DevExpress.Data.VirtualServerModeSource()
            virtualSource.RowType = GetType(DevExpress.DXperience.Demos.CodeDemo.Data.LipsumObject)
            ' Creating the Pager (LabelControl with Html formatting)
            Dim htmlPager = New DevExpress.XtraEditors.LabelControl()
            htmlPager.AllowHtmlString = True
            htmlPager.Dock = System.Windows.Forms.DockStyle.Bottom
            htmlPager.Padding = New System.Windows.Forms.Padding(10)
            htmlPager.Parent = gridControl.Parent
            htmlPager.SendToBack()
            ' Creating the paging tasks
            Const TotalRowsCount As Integer = 1234, RowsPerPage As Integer = 10
            Dim rowsTask = New System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, Integer, Integer, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of System.Collections.ICollection))(Async Function(config, pageSize, pageToFetch, cancellation)
                Await System.Threading.Tasks.Task.Delay(333, cancellation)
                Return DevExpress.DXperience.Demos.CodeDemo.Data.LipsumObject.GetRows(TotalRowsCount, config.Filter, config.SortInfo).Skip(pageSize * pageToFetch).Take(pageSize).ToArray()
            End Function)
            Dim rowCountTask = New System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of Integer))(Async Function(config, cancellation)
                Await System.Threading.Tasks.Task.Delay(5555, cancellation)
                Return DevExpress.DXperience.Demos.CodeDemo.Data.LipsumObject.GetRows(TotalRowsCount, config.Filter, config.SortInfo).Count()
            End Function)
            ' Handling the paging
            Dim tmp_VirtualPagerHelper = New DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper(RowsPerPage, virtualSource, htmlPager, rowsTask, rowCountTask)
            gridControl.DataSource = virtualSource
        End Sub

#End Region
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class VirtualPagerHelper
            Implements System.IDisposable

            Public NotInheritable Class HtmlPagerHelper

                Public Shared Iterator Function GenerateHtmlPagerElements(ByVal currentPage As Integer, ByVal pages As Integer, ByVal visibleRadius As Integer, ByVal lastPageTextOverride As String) As IEnumerable(Of String)
                    Dim pg As Integer = 0
                    While pg < pages
                        If pg = visibleRadius + 1 AndAlso pg < currentPage - visibleRadius - 1 Then
                            pg = currentPage - visibleRadius
                            Yield "…"
                        End If

                        If pg = currentPage + visibleRadius + 1 AndAlso pg < pages - visibleRadius - 2 Then
                            pg = pages - visibleRadius - 1
                            Yield "…"
                        End If

                        Dim pageDispText = If((Not Equals(lastPageTextOverride, Nothing) AndAlso pg <> currentPage AndAlso pg = pages - 1), lastPageTextOverride, (pg + 1).ToString(System.Globalization.CultureInfo.InvariantCulture))
                        If pg = currentPage Then
                            Yield "<b>" & pageDispText & "</b>"
                        Else
                            Yield "<href=" & pg & ">" & pageDispText & "</href>"
                        End If

                        Call System.Threading.Interlocked.Increment(pg)
                    End While
                End Function

                Public Shared Function GenerateHtmlPager(ByVal currentPage As Integer, ByVal pages As Integer, ByVal visibleRadius As Integer, ByVal lastPageTextOverride As String) As String
                    Return String.Join(" ", DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.GenerateHtmlPagerElements(currentPage, pages, visibleRadius, lastPageTextOverride))
                End Function

                Public Shared DefaultVisibleRadius As Integer = 4

                Public Shared Function GenerateHtmlPager(ByVal currentPage As Integer, ByVal pages As Integer) As String
                    Return String.Join(" ", DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.GenerateHtmlPagerElements(currentPage, pages, DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.DefaultVisibleRadius, Nothing))
                End Function

                Public Const MoreButtonText As String = "→"

                Public Shared Function GenerateHtmlPager(ByVal currentPage As Integer, ByVal pages As Integer, ByVal lastPageTextOverride As String) As String
                    Return String.Join(" ", DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.GenerateHtmlPagerElements(currentPage, pages, DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.DefaultVisibleRadius, lastPageTextOverride))
                End Function
            End Class

            Private pageSize As Integer

            Private currentPage As Integer

            Private pagesCount As Integer

            Private pagesCountKnownExactly As Boolean

            Private pagesCountCancellation As System.Threading.CancellationTokenSource

            Private virtualSource As DevExpress.Data.VirtualServerModeSource

            Private htmlPager As DevExpress.XtraEditors.LabelControl

            Private rowsTask As System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, Integer, Integer, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of System.Collections.ICollection))

            Private rowCountTask As System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of Integer))

            Public Sub New(ByVal initialPageSize As Integer, ByVal virtualSource As DevExpress.Data.VirtualServerModeSource, ByVal htmlPager As DevExpress.XtraEditors.LabelControl, ByVal rowsTask As System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, Integer, Integer, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of System.Collections.ICollection)), ByVal rowCountTask As System.Func(Of DevExpress.Data.VirtualServerModeConfigurationInfo, System.Threading.CancellationToken, System.Threading.Tasks.Task(Of Integer)))
                Me.pageSize = initialPageSize
                Me.virtualSource = virtualSource
                Me.htmlPager = htmlPager
                Me.rowsTask = rowsTask
                Me.rowCountTask = rowCountTask
                '
                Me.pagesCount = 1
                Me.pagesCountKnownExactly = False
                Me.currentPage = 0
                '
                AddHandler htmlPager.HyperlinkClick, AddressOf Me.HtmlPager_HyperlinkClick
                AddHandler virtualSource.ConfigurationChanged, AddressOf Me.src_ConfigurationChanged
                AddHandler virtualSource.MoreRows, AddressOf Me.src_MoreRows
                '
                Me.UpdatePager()
            End Sub

            Public Sub Dispose() Implements Global.System.IDisposable.Dispose
                If Me.htmlPager IsNot Nothing Then RemoveHandler Me.htmlPager.HyperlinkClick, AddressOf Me.HtmlPager_HyperlinkClick
                Me.htmlPager = Nothing
                If Me.virtualSource IsNot Nothing Then
                    RemoveHandler Me.virtualSource.ConfigurationChanged, AddressOf Me.src_ConfigurationChanged
                    RemoveHandler Me.virtualSource.MoreRows, AddressOf Me.src_MoreRows
                    Me.htmlPager = Nothing
                End If

                Me.CancelPagesTask()
            End Sub

            Private Sub CancelPagesTask()
                If Me.pagesCountCancellation Is Nothing Then Return
                Dim c = Me.pagesCountCancellation
                Me.pagesCountCancellation = Nothing
                c.Cancel()
                c.Dispose()
            End Sub

            Private Async Function GetRowsPageAsync(ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs) As Task(Of DevExpress.Data.VirtualServerModeRowsTaskResult)
                Dim userTask = Me.rowsTask(e.ConfigurationInfo, Me.pageSize, Me.currentPage, e.CancellationToken)
                Dim userRv = Await userTask
                Me.OnPageLoaded(userRv.Count)
                Return New DevExpress.Data.VirtualServerModeRowsTaskResult(userRv)
            End Function

            Private Sub src_MoreRows(ByVal sender As Object, ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs)
                e.RowsTask = Me.GetRowsPageAsync(e)
            End Sub

            Private Sub src_ConfigurationChanged(ByVal sender As Object, ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs)
                If Me.inPageClick <> 0 Then Return ' pager navigation, not real reconfiguration
                Me.CancelPagesTask()
                Me.currentPage = 0
                Me.pagesCount = 1
                Me.pagesCountKnownExactly = False
                Me.UpdatePager()
                Dim pagesTask = Me.GoPagesCount(e)
            End Sub

            Private Async Function GoPagesCount(ByVal e As DevExpress.Data.VirtualServerModeRowsEventArgs) As System.Threading.Tasks.Task
                If Me.rowCountTask Is Nothing Then Return
                Dim cancellationSource = New System.Threading.CancellationTokenSource()
                Me.pagesCountCancellation = cancellationSource
                Dim rowCount As Integer = Await Me.rowCountTask(e.ConfigurationInfo, cancellationSource.Token)
                Me.CancelPagesTask()
                If rowCount >= 0 Then
                    Me.pagesCountKnownExactly = True
                    Me.pagesCount =(rowCount + Me.pageSize - 1) \ Me.pageSize
                    Me.UpdatePager()
                End If
            End Function

            Private Sub HtmlPager_HyperlinkClick(ByVal sender As Object, ByVal e As DevExpress.Utils.HyperlinkClickEventArgs)
                Me.OnPageClick(Integer.Parse(e.Link, System.Globalization.CultureInfo.InvariantCulture))
            End Sub

            Private inPageClick As Integer

            Private Sub OnPageClick(ByVal page As Integer)
                Call System.Threading.Interlocked.Increment(Me.inPageClick)
                Try
                    Me.currentPage = page
                    Me.UpdatePager()
                    Me.virtualSource.Refresh()
                Finally
                    Call System.Threading.Interlocked.Decrement(Me.inPageClick)
                End Try
            End Sub

            Public Sub SetPageSize(ByVal newPageSize As Integer)
                Me.pageSize = newPageSize
                Me.currentPage = 0
                Me.virtualSource.Refresh()
            End Sub

            Private Sub OnPageLoaded(ByVal rows As Integer)
                If Not Me.pagesCountKnownExactly Then
                    If Me.currentPage = Me.pagesCount - 1 Then
                        If rows < Me.pageSize Then
                            Me.CancelPagesTask()
                            Me.pagesCountKnownExactly = True
                            If rows = 0 Then Me.pagesCount -= 1
                        Else
                            Me.pagesCount += 1
                        End If
                    End If
                End If

                Me.UpdatePager()
            End Sub

            Private Sub UpdatePager()
                If Me.pagesCountKnownExactly Then
                    Me.htmlPager.Text = DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.GenerateHtmlPager(Me.currentPage, System.Math.Max(Me.pagesCount, Me.currentPage + 1))
                Else
                    Me.htmlPager.Text = DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.GenerateHtmlPager(Me.currentPage, Me.pagesCount, DevExpress.XtraGrid.Demos.CodeExamples.Paging.VirtualPagerHelper.HtmlPagerHelper.MoreButtonText)
                End If
            End Sub
        End Class
    End Module
End Namespace

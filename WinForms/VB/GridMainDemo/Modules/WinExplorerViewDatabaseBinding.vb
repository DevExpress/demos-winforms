Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports System.Diagnostics
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class WinExplorerViewDatabaseBinding
        Inherits TutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            If MainFormHelper.TakeScreens Then
                winExplorerView1.OptionsView.AnimationType = Views.Base.GridAnimationType.NeverAnimate
                winExplorerView1.OptionsImageLoad.AsyncLoad = False
            End If

            SetToolTipController(Me, gridControl1)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitVehiclesData()
            InitGrid()
        End Sub

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            VehiclesData.InitXMLData(dataFileName, gridControl1)
        End Sub

        Private Sub InitGrid()
            winExplorerView1.Columns.Clear()
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "ID"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Name"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Description"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Photo"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "InStock"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "CategoryName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "TrademarkName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "TransmissionType"})
            Dim item As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            winExplorerView1.Columns("Name").ColumnEdit = item
            gridControl1.RepositoryItems.Add(item)
            winExplorerView1.ColumnSet.TextColumn = winExplorerView1.Columns("Name")
            winExplorerView1.ColumnSet.DescriptionColumn = winExplorerView1.Columns("Description")
            winExplorerView1.ColumnSet.ExtraLargeImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.MediumImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.CheckBoxColumn = winExplorerView1.Columns("InStock")
            winExplorerView1.ColumnSet.GroupColumn = winExplorerView1.Columns("CategoryName")
        End Sub

        Private Sub ribbonGalleryBarItem1_Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As Ribbon.GalleryItemEventArgs)
            Dim allowAsyncLoad As Boolean = False
            If Not e.Item.Checked Then Return
            Select Case e.Item.Caption
                Case "Extra large icons"
                    allowAsyncLoad = True
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.ExtraLarge
                Case "Large icons"
                    allowAsyncLoad = True
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Large
                Case "Medium icons"
                    allowAsyncLoad = True
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Medium
                Case "Small icons"
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Small
                Case "List"
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.List
                Case "Tiles"
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Tiles
                Case "Content"
                    winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Content
            End Select

            UpdateGridOptionsImageLoad(allowAsyncLoad)
        End Sub

        Private Sub UpdateGridOptionsImageLoad(ByVal allowAsyncLoad As Boolean)
            If MainFormHelper.TakeScreens Then allowAsyncLoad = False
            If winExplorerView1.OptionsImageLoad.AsyncLoad = allowAsyncLoad Then Return
            winExplorerView1.OptionsImageLoad.AsyncLoad = allowAsyncLoad
            winExplorerView1.RefreshData()
        End Sub

        Private Sub bcItemCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView1.OptionsView.ShowCheckBoxes = bcItemCheckBoxes.Checked
        End Sub

        Private Sub bcGroupCaptionButton_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView1.OptionsView.ShowExpandCollapseButtons = bcGroupCaptionButton.Checked
        End Sub

        Private Sub bcGroupCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = bcGroupCheckBoxes.Checked
        End Sub

        Private Sub OnSortingCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Not CType(e.Item, BarCheckItem).Checked Then Return
            If e.Item Is bcAscending Then
                winExplorerView1.ColumnSet.GroupColumn.SortOrder = Data.ColumnSortOrder.Ascending
                winExplorerView1.ColumnSet.TextColumn.SortOrder = Data.ColumnSortOrder.Ascending
            End If

            If e.Item Is bcDescending Then
                winExplorerView1.ColumnSet.GroupColumn.SortOrder = Data.ColumnSortOrder.Descending
                winExplorerView1.ColumnSet.TextColumn.SortOrder = Data.ColumnSortOrder.Descending
            End If

            If e.Item Is bcSortNone Then
                winExplorerView1.ColumnSet.GroupColumn.SortOrder = Data.ColumnSortOrder.None
                winExplorerView1.ColumnSet.TextColumn.SortOrder = Data.ColumnSortOrder.None
            End If
        End Sub

        Private Sub OnGroupByCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView1.GroupCount = If(e.Item Is bcGroupNone, 0, 1)
            If e.Item Is bcTrademark Then
                winExplorerView1.ColumnSet.GroupColumn = winExplorerView1.Columns("TrademarkName")
            ElseIf e.Item Is bcTransmissionType Then
                winExplorerView1.ColumnSet.GroupColumn = winExplorerView1.Columns("TransmissionType")
            ElseIf e.Item Is bcCategory Then
                winExplorerView1.ColumnSet.GroupColumn = winExplorerView1.Columns("CategoryName")
            End If
        End Sub

        Private Sub OnAnimationTypeChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If e.Item Is bcAnimationNone Then
                winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.None
            ElseIf e.Item Is bcExpandAnimation Then
                winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand
            ElseIf e.Item Is bcPushAnimation Then
                winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push
            ElseIf e.Item Is bcSlideAnimation Then
                winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide
            ElseIf e.Item Is bcSegmentedAnimation Then
                winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade
            End If

            Dim dataSource = gridControl1.DataSource
            gridControl1.DataSource = Nothing
            gridControl1.DataSource = dataSource
        End Sub

        Private Sub barCheckItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView1.OptionsImageLoad.RandomShow = barCheckItem1.Checked
        End Sub

        Private Sub winExplorerView1_GetThumbnailImage(ByVal sender As Object, ByVal e As ThumbnailImageEventArgs)
            Dim w As Stopwatch = New Stopwatch()
            w.Start()
            While w.ElapsedMilliseconds < 20
            End While

            w.Stop()
        End Sub
    End Class
End Namespace

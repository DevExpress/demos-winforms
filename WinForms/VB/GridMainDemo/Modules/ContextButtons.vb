Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ContextButtons
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            SetGalleryImageSize(300)
            SetToolTipController(Me, gridControl1)
        End Sub

        Private Sub item_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarCheckItem = CType(e.Item, BarCheckItem)
            If item.Checked Then winExplorerView1.ContextButtonOptions.AnimationType = CType(item.Tag, ContextAnimationType)
        End Sub

        Private Sub SetGalleryImageSize(ByVal width As Integer)
            winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = New Size(width, CInt(width * 0.6))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitVehiclesData()
            InitGrid()
            UpdateContextButtonsPanelsColors()
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
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Transmission"})
            winExplorerView1.ColumnSet.DescriptionColumn = winExplorerView1.Columns("Description")
            winExplorerView1.ColumnSet.ExtraLargeImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.MediumImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.CheckBoxColumn = winExplorerView1.Columns("InStock")
            winExplorerView1.ColumnSet.GroupColumn = winExplorerView1.Columns("CategoryName")
        End Sub

        Private checkedValuesCore As Dictionary(Of Integer, Boolean)

        Protected ReadOnly Property CheckedValues As Dictionary(Of Integer, Boolean)
            Get
                If checkedValuesCore Is Nothing Then checkedValuesCore = New Dictionary(Of Integer, Boolean)()
                Return checkedValuesCore
            End Get
        End Property

        Private ratingValuesCore As Dictionary(Of Integer, Integer)

        Protected ReadOnly Property RatingValues As Dictionary(Of Integer, Integer)
            Get
                If ratingValuesCore Is Nothing Then ratingValuesCore = New Dictionary(Of Integer, Integer)()
                Return ratingValuesCore
            End Get
        End Property

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateContextButtonsPanelsColors()
        End Sub

        Private Sub UpdateContextButtonsPanelsColors()
            winExplorerView1.ContextButtonOptions.TopPanelColor = Color.FromArgb(160, LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Control))
            winExplorerView1.ContextButtonOptions.BottomPanelColor = winExplorerView1.ContextButtonOptions.TopPanelColor
        End Sub

        Private Sub winExplorerView1_ContextButtonCustomize(ByVal sender As Object, ByVal e As Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventArgs)
            If Equals(e.Item.Name, "itemText") Then
                CType(e.Item, ContextButton).Caption = GetContextButtonCaption(e.RowHandle, winExplorerView1.Columns("Name"), winExplorerView1.Columns("TrademarkName"))
            ElseIf Equals(e.Item.Name, "itemCheck") Then
                If Not CheckedValues.ContainsKey(e.RowHandle) Then CheckedValues.Add(e.RowHandle, e.RowHandle Mod 2 = 0)
                CType(e.Item, CheckContextButton).Checked = CheckedValues(e.RowHandle)
            ElseIf Equals(e.Item.Name, "itemRating") Then
                If Not RatingValues.ContainsKey(e.RowHandle) Then RatingValues.Add(e.RowHandle, e.RowHandle Mod 6)
                CType(e.Item, RatingContextButton).Rating = RatingValues(e.RowHandle)
            End If
        End Sub

        Private Function GetContextButtonCaption(ByVal rowHandle As Integer, ByVal model As GridColumn, ByVal trademark As GridColumn) As String
            Dim _caption As String = String.Empty
            If model IsNot Nothing Then _caption = CStr(winExplorerView1.GetRowCellValue(rowHandle, model))
            If Not Equals(_caption, Nothing) AndAlso trademark IsNot Nothing AndAlso _caption.Length < 20 Then _caption = String.Format("{0} {1}", winExplorerView1.GetRowCellValue(rowHandle, trademark), _caption)
            Return _caption
        End Function

        Private Sub winExplorerView1_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs)
            If Equals(e.Item.Name, "itemCheck") Then
                CheckedValues(CInt(e.DataItem)) = CType(e.Item, CheckContextButton).Checked
            ElseIf Equals(e.Item.Name, "itemRating") Then
                RatingValues(CInt(e.DataItem)) = CInt(CType(e.Item, RatingContextButton).Rating)
            ElseIf Equals(e.Item.Name, "itemDownload") Then
                XtraMessageBox.Show("'Download' item clicked")
            ElseIf Equals(e.Item.Name, "itemRemove") Then
                XtraMessageBox.Show("'Remove' item clicked")
            ElseIf Equals(e.Item.Name, "itemInfo") Then
                XtraMessageBox.Show("'Info' item clicked")
            End If
        End Sub

        Private Sub OnAnimationTypeEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value = CType(radioGroup1.EditValue, ContextAnimationType)
            winExplorerView1.ContextButtonOptions.AnimationType = value
        End Sub

        Private Sub OnZoomTrackBarEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As Integer = CType(sender, ZoomTrackBarControl).Value
            SetGalleryImageSize(value)
        End Sub
    End Class
End Namespace

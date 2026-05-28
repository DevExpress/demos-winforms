Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Annotations
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ScrollAnnotations
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            gridControl.DataSource = TaskGenerator.Default.GenerateSource(400)
            InitEditors()
            gridView.ClearSelection()
            gridView.ApplyFindFilter("QA")
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ScrollAnnotations"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ScrollAnnotations"
            End Get
        End Property

        Private Sub InitEditors()
            repositoryItemPriorityComboBox.AddImages(svgImageCollection)
            repositoryItemDescriptionComboBox.Items.Add("", True, 3)
            repositoryItemCompletedComboBox.Items.Add("", True, 2)
            stylesSource.DataSource = style
        End Sub

        Private Sub OnRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
            Dim task As EmployeeTask = TryCast(gridView.GetRow(e.RowHandle), EmployeeTask)
            If task IsNot Nothing AndAlso task.IsCompleted Then e.Appearance.FontStyleDelta =(FontStyle.Italic Or FontStyle.Strikeout)
        End Sub

        Private Function GetPalette() As Utils.Design.ISvgPaletteProvider
            Return Svg.SvgPaletteHelper.GetSvgPalette(gridControl.LookAndFeel, Utils.Drawing.ObjectState.Normal)
        End Function

        ' Addding bookmark items
        '<gridControl>
        Private ReadOnly bookmarks As HashSet(Of Integer) = New HashSet(Of Integer)() From {5, 17, 74}

        Private Sub OnCustomScrollAnnotation(ByVal sender As Object, ByVal e As GridCustomScrollAnnotationsEventArgs)
            Dim rowHandles As Integer() = bookmarks.[Select](Function(x) gridView.GetRowHandle(x)).ToArray()
            e.SetAnnotations(DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue, rowHandles)
        End Sub

        Private Sub OnCustomDrawRowIndicator(ByVal sender As Object, ByVal e As RowIndicatorCustomDrawEventArgs)
            If e.RowHandle >= 0 Then
                If e.Info.ImageIndex = GridPainter.IndicatorError OrElse e.Info.ImageIndex = GridPainter.IndicatorFocusedError Then
                    ' suppress error indicator
                    e.Info.ImageIndex = If(e.RowHandle = gridView.FocusedRowHandle, GridPainter.IndicatorFocused, -1)
                End If

                If Not ceBookmarksEnabled.Checked OrElse Not bookmarks.Contains(gridView.GetDataSourceRowIndex(e.RowHandle)) Then Return
                e.DefaultDraw()
                Dim bookmarkImage = svgImageCollection.GetImage("bookmark", GetPalette(), ScaleDPI.ScaleSize(New Size(8, 8)))
                Dim imageBounds = PlacementHelper.Arrange(bookmarkImage.Size, e.Bounds, ContentAlignment.MiddleLeft)
                e.Cache.DrawImageUnscaled(bookmarkImage, imageBounds)
                e.Handled = True
            End If
        End Sub

        '</gridControl>
        ' Bookmark items navigation
        '<gridControl>
        Private Overloads Sub OnKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = (Keys.F2 Or Keys.Control) OrElse e.KeyData = (Keys.B Or Keys.Control) Then e.Handled = ToggleBookmark(gridView.FocusedRowHandle)
            ' navigating via shortcuts
            If e.KeyData = Keys.F2 Then e.Handled = gridView.MoveToNextScrollAnnotation(ScrollAnnotationKind.Custom)
            If e.KeyData = (Keys.F2 Or Keys.Shift) Then e.Handled = gridView.MoveToPrevScrollAnnotation(ScrollAnnotationKind.Custom)
        End Sub

        Private Function ToggleBookmark(ByVal handle As Integer) As Boolean
            Dim dataIndex As Integer = gridView.GetDataSourceRowIndex(handle)
            If dataIndex < 0 Then Return False
            If Not bookmarks.Remove(dataIndex) Then bookmarks.Add(dataIndex)
            gridView.RefreshScrollAnnotations(ScrollAnnotationKind.Custom)
            gridView.InvalidateRow(handle)
            Return True
        End Function

        '</gridControl>
        Private Overloads Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            Dim hitInfo = gridView.CalcHitInfo(e.Location)
            If hitInfo.InRowCell AndAlso hitInfo.Column Is descriptionColumn Then
                Dim task As EmployeeTask = TryCast(gridView.GetRow(hitInfo.RowHandle), EmployeeTask)
                If task IsNot Nothing AndAlso task.HasDescription Then ToolTipController.DefaultController.ShowHint(task.Description, ToolTipLocation.RightCenter)
            End If
        End Sub

        '<optionsPage>
        Private ReadOnly style As AnnotationsStyle = New AnnotationsStyle()

        Private Sub OnScrollAnnotationsStyle(ByVal sender As Object, ByVal e As GridScrollAnnotationsStyleEventArgs)
            Dim styleColor = style.GetColor(e.Kind)
            If Not styleColor.IsEmpty Then e.Color = styleColor
        End Sub

        Private Sub OnAnnotationsStyleChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            If e.ListChangedType = ListChangedType.ItemChanged Then gridView.InvalidateScrollAnnotations()
        End Sub

        Private Sub OnAnnotationsEnabledChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim _enabled As Boolean = CType(sender, CheckEdit).Checked
            Dim _show As DefaultBoolean = If(_enabled, DefaultBoolean.True, DefaultBoolean.False)
            If sender Is ceErrorsEnabled Then
                layoutControlItemForErrors.Enabled = _enabled
                gridView.OptionsScrollAnnotations.ShowErrors = _show
            End If

            If sender Is ceFocusedEnabled Then
                layoutControlItemForFocused.Enabled = _enabled
                gridView.OptionsScrollAnnotations.ShowFocusedRow = _show
            End If

            If sender Is ceBookmarksEnabled Then gridView.OptionsScrollAnnotations.ShowCustomAnnotations = _show
        End Sub
    '</optionsPage>
    End Class

    Public Class AnnotationsStyle

        Private ReadOnly colors As Dictionary(Of ScrollAnnotationKind, Color) = New Dictionary(Of ScrollAnnotationKind, Color)()

        Public Property ErrorsColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.Errors)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.Errors) = value
            End Set
        End Property

        Public Property SearchResultsColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.SearchResults)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.SearchResults) = value
            End Set
        End Property

        Public Property FocusColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.FocusedRow)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.FocusedRow) = value
            End Set
        End Property

        Public Function GetColor(ByVal kind As ScrollAnnotationKind) As Color
            Dim color As Color
            Return If(colors.TryGetValue(kind, color), color, Color.Empty)
        End Function
    End Class
End Namespace

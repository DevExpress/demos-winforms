Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class HitInfo
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
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

        Private Sub HitInfo_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            pivotGridControl1.HeaderImages = HeadersImageList
            pivotGridControl1.ValueImages = CategoryImageList
            fieldSalesPerson.ImageIndex = 0
            fieldCountry.CollapseValue("UK")
            ShowHitInfo(Nothing)
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        '<pivotGridControl1>
        Private Sub pivotGridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            ShowHitInfo(pivotGridControl1.CalcHitInfo(New Point(e.X, e.Y)))
        End Sub

        Private Sub pivotGridControl1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            ShowHitInfo(pivotGridControl1.CalcHitInfo(New Point(-1, -1)))
        End Sub

        '<panelControl1>
        Private Sub ShowHitInfo(ByVal info As PivotGridHitInfo)
            ShowCellInfo(info)
            ShowValueInfo(info)
            ShowHeaderInfo(info)
            Dim hintVisible As Boolean = lcgCell.Visibility <> XtraLayout.Utils.LayoutVisibility.Always AndAlso lcgValue.Visibility <> XtraLayout.Utils.LayoutVisibility.Always AndAlso lcgHeadersArea.Visibility <> XtraLayout.Utils.LayoutVisibility.Always
            lciHint.Visibility = If(hintVisible, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        '</panelControl1>
        '</pivotGridControl1>
        Private Sub ShowCellInfo(ByVal info As PivotGridHitInfo)
            If info Is Nothing OrElse info.CellInfo Is Nothing Then
                lcgCell.Visibility = XtraLayout.Utils.LayoutVisibility.Never
                Return
            End If

            lcgCell.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            textEdit1.Text = info.CellInfo.DisplayText
            textEdit2.Text = String.Format("{0}, {1}", info.CellInfo.ColumnIndex, info.CellInfo.RowIndex)
            textEdit3.Text = String.Format("{0}", info.CellInfo.Value)
            textEdit4.Text = If(info.CellInfo.DataField IsNot Nothing, info.CellInfo.DataField.ToString(), "")
        End Sub

        Private Sub ShowValueInfo(ByVal info As PivotGridHitInfo)
            If info Is Nothing OrElse info.ValueInfo Is Nothing Then
                lcgValue.Visibility = XtraLayout.Utils.LayoutVisibility.Never
                Return
            End If

            lcgValue.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            textEdit5.Text = String.Format("{0}", info.ValueInfo.Value)
            textEdit6.Text = String.Format("{0}", info.ValueInfo.ValueType)
            textEdit7.Text = String.Format("{0}", info.ValueInfo.Field)
        End Sub

        Private Sub ShowHeaderInfo(ByVal info As PivotGridHitInfo)
            If info Is Nothing OrElse info.HeadersAreaInfo Is Nothing Then
                lcgHeadersArea.Visibility = XtraLayout.Utils.LayoutVisibility.Never
                Return
            End If

            lcgHeadersArea.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            textEdit8.Text = String.Format("{0}", info.HeadersAreaInfo.Area)
            textEdit9.Text = String.Format("{0}", info.HeadersAreaInfo.Field)
        End Sub

        Private Sub paddingPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        End Sub
    End Class
End Namespace

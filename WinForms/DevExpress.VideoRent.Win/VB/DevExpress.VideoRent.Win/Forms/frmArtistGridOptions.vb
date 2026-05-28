Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils

Namespace DevExpress.VideoRent.Win.Forms
    Partial Public Class frmArtistGridOptions
        Inherits frmGridOptionsBase
        Public Sub New(ByVal parent As Form, ByVal view As GridView)
            MyBase.New(parent, ConstStrings.ViewOptions, view)
            InitializeComponent()
        End Sub
        Private FieldNames As String = "ArtistId, Gender"
        Protected Overrides Sub InitOptions()
            MyBase.InitOptions()
            cePreview.Checked = View.OptionsView.ShowPreview
            ceVertLines.Checked = View.OptionsView.ShowVerticalLines <> DefaultBoolean.False
            ceAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow
            ceEditing.Checked = View.OptionsBehavior.Editable
            ceAutoZoomDetail.Checked = View.OptionsDetail.AutoZoomDetail
            ceMasterDetail.Checked = View.OptionsDetail.EnableMasterViewMode
        End Sub
        Protected Overrides Sub SetOptions()
            MyBase.SetOptions()
            View.OptionsView.ShowPreview = cePreview.Checked
            View.OptionsView.ShowVerticalLines = If(ceVertLines.Checked, DefaultBoolean.Default, DefaultBoolean.False)
            View.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked
            For Each column As GridColumn In View.Columns
                column.OptionsColumn.AllowFocus = ceEditing.Checked
                If FieldNames.IndexOf(column.FieldName) = -1 Then
                    column.OptionsColumn.AllowEdit = ceEditing.Checked
                End If
            Next column
            View.OptionsBehavior.Editable = ceEditing.Checked
            View.OptionsDetail.AutoZoomDetail = ceAutoZoomDetail.Checked
            View.OptionsDetail.EnableMasterViewMode = ceMasterDetail.Checked
        End Sub
    End Class
End Namespace


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
    Partial Public Class frmReceiptGridOptions
        Inherits frmGridOptionsBase
        Public Sub New(ByVal parent As Form, ByVal view As GridView, ByVal caption As String)
            MyBase.New(parent, caption, view)
            InitializeComponent()
        End Sub
        Protected Overrides Sub InitOptions()
            MyBase.InitOptions()
            ceGroupRowFooter.Checked = Object.Equals(View.OptionsView.GroupFooterShowMode, GroupFooterShowMode.VisibleIfExpanded)
            ceVertLines.Checked = View.OptionsView.ShowVerticalLines <> DefaultBoolean.False
            ceAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow
            ceIndicator.Checked = View.OptionsView.ShowIndicator
            ceDetailTabs.Checked = View.OptionsDetail.ShowDetailTabs
            ceViewCaption.Checked = View.OptionsView.ShowViewCaption
        End Sub
        Protected Overrides Sub SetOptions()
            MyBase.SetOptions()
            If ceGroupRowFooter.Checked Then
                View.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded
            Else
                View.OptionsView.GroupFooterShowMode = GroupFooterShowMode.Hidden
            End If
            View.OptionsView.ShowVerticalLines = If(ceVertLines.Checked, DefaultBoolean.Default, DefaultBoolean.False)
            View.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked
            View.OptionsView.ShowIndicator = ceIndicator.Checked
            View.OptionsDetail.ShowDetailTabs = ceDetailTabs.Checked
            View.OptionsView.ShowViewCaption = ceViewCaption.Checked
            SetDetailViewBorder()
        End Sub

        Private Sub SetDetailViewBorder()
            For Each view As GridView In Me.View.GridControl.ViewCollection
                If view IsNot Me.View Then
                    If Me.View.OptionsDetail.ShowDetailTabs Then
                        view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
                    Else
                        view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
                    End If
                End If
            Next view
        End Sub
    End Class
End Namespace


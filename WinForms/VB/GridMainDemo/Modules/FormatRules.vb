Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class FormatRules
        Inherits TutorialControl

        Private formatRulesMenu As DXPopupMenu = New DXPopupMenu()

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = GenerateSales()
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As Views.Grid.RowCellClickEventArgs)
            If e.Button = MouseButtons.Right Then
                Dim items As GridFormatRuleMenuItems = New GridFormatRuleMenuItems(gridView1, e.Column, formatRulesMenu.Items)
                If items.Count > 0 Then Call MenuManagerHelper.ShowMenu(formatRulesMenu, gridControl1.LookAndFeel, gridControl1.MenuManager, gridControl1, New Point(e.X, e.Y))
            End If
        End Sub

#Region "GenerateReport"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace

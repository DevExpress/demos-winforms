Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for Filtering.
    ''' </summary>
    Public Partial Class Filtering
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Filtering"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Filtering"
            End Get
        End Property

        Private Sub Filtering_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitIssueListData(dsIssueList1)
            InitFilter()
            InitEditors()
        End Sub

        Private Sub InitFilter()
            gridControl1.ForceInitialize()
        End Sub

        '<ceAllowFilter>
        Private Sub InitDemoFilter()
            gridView1.Columns("FixedDate").FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[FixedDate] is not null")
            gridView1.Columns("Status").FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[Status] in (2, 3, 4)")
        End Sub

        '</ceAllowFilter>
        Private Sub InitEditors()
            ceAllowFilter.Checked = gridView1.OptionsCustomization.AllowFilter
            ceFilterEditor.Checked = gridView1.OptionsFilter.AllowFilterEditor
            ceAdvDialog.Checked = gridView1.OptionsFilter.UseNewCustomFilterDialog
            ceFilterList.Checked = gridView1.OptionsFilter.AllowMRUFilterList
            ceColumnFilterList.Checked = gridView1.OptionsFilter.AllowColumnMRUFilterList
            InitEnabled()
        End Sub

        Private Sub InitEnabled()
            ceColumnFilterList.Enabled = gridView1.OptionsCustomization.AllowFilter
            ceFilterList.Enabled = ceColumnFilterList.Enabled
            ceAdvDialog.Enabled = ceFilterList.Enabled
            ceFilterEditor.Enabled = ceAdvDialog.Enabled
        End Sub

        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As Views.Grid.PopupMenuShowingEventArgs)
            If e.MenuType = Views.Grid.GridMenuType.Column Then
                For i As Integer = e.Menu.Items.Count - 1 To 0 Step -1
                    If e.Menu.Items(i) IsNot Nothing Then
                        If e.Menu.Items(i).Caption.IndexOf("Filter", StringComparison.OrdinalIgnoreCase) = -1 Then
                            e.Menu.Items.RemoveAt(i)
                        Else
                            e.Menu.Items(i).BeginGroup = False
                        End If
                    End If
                Next
            End If
        End Sub

        '<ceAllowFilter>
        Private Sub ceAllowFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsCustomization.AllowFilter = ceAllowFilter.Checked
            If Not ceAllowFilter.Checked Then
                gridView1.ClearColumnsFilter()
            Else
                InitDemoFilter()
            End If

            InitEnabled()
        End Sub

        '</ceAllowFilter>
        '<ceFilterEditor>
        Private Sub ceFilterEditor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked
        End Sub

        '</ceFilterEditor>
        '<ceAdvDialog>
        Private Sub ceAdvDialog_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsFilter.UseNewCustomFilterDialog = ceAdvDialog.Checked
        End Sub

        '</ceAdvDialog>
        '<ceFilterList>
        Private Sub ceFilterList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked
        End Sub

        '</ceFilterList>
        '<ceColumnFilterList>
        Private Sub ceColumnFilterList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked
        End Sub

        '</ceColumnFilterList>
        '<sbInfo>
        Private Sub sbInfo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim args As ToolTipControllerShowEventArgs = New ToolTipControllerShowEventArgs()
            args.IconType = ToolTipIconType.Information
            args.IconSize = ToolTipIconSize.Large
            args.AutoHide = False
            args.ToolTip = String.Format("<u>{7}</u><br> {0}<br><br>{8} <b>{1}</b><br><br>{9} <b>{2}</b><br>{10} <b>{3}</b><br>{11} <b>{4}</b><br>{12} <b>{5}</b><br>{13} <b>{6}</b><br>", gridView1.FilterPanelText, gridView1.RowCount, gridView1.OptionsFilter.ColumnFilterPopupMaxRecordsCount, gridView1.OptionsFilter.ColumnFilterPopupRowCount, gridView1.OptionsFilter.MRUColumnFilterListCount, gridView1.OptionsFilter.MRUFilterListCount, gridView1.OptionsFilter.MRUFilterListPopupCount, Properties.Resources.RowFilter, Properties.Resources.RowCount, Properties.Resources.FilterPopupMaxRecord, Properties.Resources.FilterPopupRowCount, Properties.Resources.MRUColumnFilterListCount, Properties.Resources.MRUFilterListCount, Properties.Resources.MRUFilterListPopupCount)
            args.ShowBeak = True
            args.ToolTipLocation = ToolTipLocation.TopLeft
            toolTipController1.ShowHint(args, sbInfo.Parent.PointToScreen(New Point(sbInfo.Left + sbInfo.Width \ 2, sbInfo.Top)))
        End Sub

        '</sbInfo>
        Private Sub sbInfo_Leave(ByVal sender As Object, ByVal e As EventArgs)
            toolTipController1.HideHint()
        End Sub
    End Class
End Namespace

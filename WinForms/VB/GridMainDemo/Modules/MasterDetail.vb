Imports System
Imports System.Data
Imports System.Drawing
Imports DevExpress.ActiveDemos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for MasterDetail.
    ''' </summary>
    Public Partial Class MasterDetail
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            gridControl1.ForceInitialize()
            InitNWindData()
            InitEditing()
            InitMasterDetailDemo()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"MasterDetail"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MasterDetail"
            End Get
        End Property

#Region "Init"
        Private ReadOnly Property MainView As GridView
            Get
                Return advBandedGridView1
            End Get
        End Property

        Private ReadOnly Property ProductView As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            dsNWindSupplier1.ReadXml(dataFileName, XmlReadMode.InferSchema)
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1)
            Return dsNWindSupplier1
        End Function

        Private Sub InitMasterDetailDemo()
            MainView.BeginUpdate()
            MainView.FocusedRowHandle = 0
            MainView.SetMasterRowExpanded(MainView.FocusedRowHandle, True)
            Dim gv As GridView = TryCast(MainView.GetVisibleDetailView(MainView.FocusedRowHandle), GridView)
            If gv IsNot Nothing Then gv.SetMasterRowExpanded(0, True)
            MainView.SetMasterRowExpandedEx(1, 1, True)
            seVertIndent.Value = 4
            MainView.EndUpdate()
            '<ceAllowFindInExpandedDetails>
            ProductView.OptionsFind.AllowFindInExpandedDetails = DefaultBoolean.False
        '</ceAllowFindInExpandedDetails>
        End Sub

        Private Sub InitEditing()
            InitCheckButtons()
            SetZoom(imageComboBoxEdit1.SelectedIndex)
        End Sub

        Private Sub InitCheckButtons()
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1)
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1)
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode
            ceAllowFindInExpandedDetails.EditValue = MainView.OptionsFind.AllowFindInExpandedDetails = DefaultBoolean.False
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent <> DefaultBoolean.False
            ceTabs.Checked = MainView.OptionsDetail.ShowDetailTabs
            ceToolTips.Checked = MainView.OptionsDetail.EnableDetailToolTip
            ceMain.IsOn = MainView.OptionsDetail.EnableMasterViewMode
        End Sub

        '<ceDetailTabStyle>
        Private Sub advBandedGridView1_DetailTabStyle(ByVal sender As Object, ByVal e As DetailTabStyleEventArgs)
            If ceDetailTabStyle.Checked Then
                If Equals(e.Caption, "Products") Then
                    e.ImageOptions.SvgImage = svgImageCollection1("product")
                End If

                If Equals(e.Caption, "Category") Then
                    e.Appearance.Header.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
                    e.ImageOptions.SvgImage = svgImageCollection1("category")
                End If

                If e.IsSelected Then
                    e.Appearance.Header.FontStyleDelta = FontStyle.Underline
                End If
            End If
        End Sub

        '</ceDetailTabStyle>
#End Region
#Region "Editing"
        '<imageComboBoxEdit1>
        Private Sub SetZoom(ByVal allow As Boolean, ByVal auto As Boolean)
            MainView.OptionsDetail.AllowZoomDetail = allow
            MainView.OptionsDetail.AutoZoomDetail = auto
            ProductView.OptionsDetail.AllowZoomDetail = allow
            ProductView.OptionsDetail.AutoZoomDetail = auto
        End Sub

        Private Sub SetZoom(ByVal index As Integer)
            Select Case index
                Case 0 '"Auto Zoom"
                    SetZoom(True, True)
                Case 1 '"Manual Zoom"
                    SetZoom(True, False)
                Case 2 '"No Zoom"
                    SetZoom(False, False)
            End Select

            MainView.CollapseAllDetails()
        End Sub

        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetZoom(imageComboBoxEdit1.SelectedIndex)
        End Sub

        '</imageComboBoxEdit1>
        '<ceAllowFindInExpandedDetails>
        Private Sub ceAllowFindInExpandedDetails_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsFind.AllowFindInExpandedDetails = If(ce.Checked, DefaultBoolean.True, DefaultBoolean.Default)
            If ce.Checked AndAlso Not MainView.IsFindPanelVisible Then
                MainView.ShowFindPanel()
                MainView.FindFilterText = "cha"
            End If
        End Sub

        '</ceAllowFindInExpandedDetails>
        '<ceTabs>
        Private Sub ceTabs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsDetail.ShowDetailTabs = ce.Checked
            MainView.CollapseAllDetails()
            ProductView.BorderStyle = If(MainView.OptionsDetail.ShowDetailTabs, BorderStyles.NoBorder, BorderStyles.Default)
        End Sub

        '</ceTabs>
        '<ceToolTips>
        Private Sub ceToolTips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            MainView.OptionsDetail.EnableDetailToolTip = ce.Checked
        End Sub

        '</ceToolTips>
        '<ceMain>
        Private Sub ceMain_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim toggleSwitch As ToggleSwitch = TryCast(sender, ToggleSwitch)
            MainView.OptionsDetail.EnableMasterViewMode = toggleSwitch.IsOn
            MainView.OptionsView.ShowChildrenInGroupPanel = toggleSwitch.IsOn
            '<skip>
            UpdateEnabledOptions()
            InitMasterDetailDemo()
        '</skip>
        End Sub

        '</ceMain>
        Private Sub UpdateEnabledOptions()
            ceToolTips.Enabled = MainView.OptionsDetail.EnableMasterViewMode
            ceTabs.Enabled = ceToolTips.Enabled
            imageComboBoxEdit1.Enabled = ceTabs.Enabled
            icbDetailMode.Enabled = imageComboBoxEdit1.Enabled
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode = DetailMode.Embedded AndAlso MainView.OptionsDetail.EnableMasterViewMode
            seVertIndent.Enabled = ceMain.IsOn
            lciZooming.Enabled = MainView.OptionsDetail.DetailMode <> DetailMode.Embedded
            lciDetailIndent.Enabled = lciZooming.Enabled
        End Sub

        '<seVertIndent>
        Private Sub seVertIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each view As Views.Base.BaseView In gridControl1.Views
                Dim gView As GridView = TryCast(view, GridView)
                If gView IsNot Nothing Then gView.DetailVerticalIndent = CInt(seVertIndent.Value)
            Next
        End Sub

        '</seVertIndent>
        Private Sub icbDetailMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<icbDetailMode>
            MainView.OptionsDetail.DetailMode = CType(icbDetailMode.EditValue, DetailMode)
            '</icbDetailMode>
            UpdateEnabledOptions()
            InitMasterDetailDemo()
            MainView.TopRowIndex = 0
        End Sub

        '<ceShowEmbeddedDetailIndent>
        Private Sub ceShowEmbeddedDetailIndent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = If(ceShowEmbeddedDetailIndent.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceShowEmbeddedDetailIndent>
        Private Sub ceDetailTabStyle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            MainView.CollapseAllDetails()
            InitMasterDetailDemo()
        End Sub

#End Region
#Region "GenerateReport"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property

#End Region
#Region "ActiveDemo"
        Public Overrides ReadOnly Property HasActiveDemo As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function CreateActiveDemo() As ActiveDemo
            Return New ActiveGridDemo(gridControl1)
        End Function

        Protected Overrides Sub RunGridActiveDemo(ByVal activeDemo As ActiveGridDemo)
            icbDetailMode.EditValue = DetailMode.Classic
            advBandedGridView1.CollapseAllDetails()
            imageComboBoxEdit1.SelectedIndex = 1
            ceTabs.Checked = True
            ceMain.IsOn = True
            activeDemo.ClickMasterRecordIcon(advBandedGridView1, 1)
            advBandedGridView1.TopRowIndex = 0
            activeDemo.ClickMasterRecordIcon(advBandedGridView1, 0)
            Dim detailView As GridView = TryCast(advBandedGridView1.GetVisibleDetailView(0), GridView)
            activeDemo.ColumnBestFit(colCategoryID, detailView, Properties.Resources.ActiveGrid_BestFit)
            activeDemo.ColumnResize(colCategoryID, detailView, 100)
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_SynhronizedViews)
            activeDemo.ViewZoom(detailView, Properties.Resources.ActiveGrid_ViewZoom)
            activeDemo.ClickMasterRecordIcon(detailView, 1)
            activeDemo.ClickMasterRecordIcon(detailView, 0)
            If activeDemo.Actions.Canceled Then Return
            If detailView Is Nothing Then Return
            Dim subDetailView As GridView = TryCast(detailView.GetVisibleDetailView(0), GridView)
            ActiveActions.Delay(500)
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewZoomSubDetail)
            If activeDemo.Actions.Canceled Then Return
            ActiveActions.Delay(500)
            activeDemo.ExpandCollapseRow(subDetailView, 1)
            activeDemo.MoveMouseFromPoint(200, 100)
            activeDemo.ExpandCollapseRow(subDetailView, 0)
            activeDemo.MoveMouseFromPoint(100, 200)
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewUnzoom)
            activeDemo.MoveMouseFromPoint(200, 200)
            activeDemo.ViewZoom(detailView)
            If activeDemo.Actions.Canceled Then Return
            subDetailView.OptionsView.ShowGroupPanel = True
            Dim r As Rectangle = activeDemo.GetGroupPanelRectangle(subDetailView)
            activeDemo.Actions.MoveMousePointTo(gridControl1, New Point(r.X + 50, r.Top + r.Height \ 2))
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel)
            r = activeDemo.GetGroupPanelRectangle(advBandedGridView1)
            activeDemo.Actions.MoveMousePointTo(gridControl1, New Point(r.X + 50, r.Top + r.Height \ 2))
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel2)
            If activeDemo.Actions.Canceled Then Return
            subDetailView.OptionsView.ShowGroupPanel = False
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev)
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev)
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_EmbeddedNavigator)
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next)
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next)
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next)
        End Sub
#End Region
    End Class
End Namespace

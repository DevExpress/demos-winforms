Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.Utils.DPI

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class OLAP
        Inherits TutorialControl

        Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Private connectionHelper As OLAPConnectionHelper = New OLAPConnectionHelper()

        Private Sub OLAP_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.FieldsCustomization()
            If ConnectToDefault() Then UpdateControls(True)
        End Sub

        Private Function ConnectToDefault() As Boolean
            Dim success As Boolean = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, False)
            If success Then ConfigureLayout()
            panelError.Visible = Not success
            radioGroup1.Enabled = success
            Return success
        End Function

        Private Async Sub ConfigureLayout()
            pivotGridControl.RetrieveFields(PivotArea.FilterArea, False)
            pivotGridControl.BeginUpdate()
            Dim fieldFiscalYear As PivotGridField = pivotGridControl.Fields("[Date].[Fiscal].[Fiscal Year]")
            fieldFiscalYear.Area = PivotArea.ColumnArea
            fieldFiscalYear.Visible = True
            fieldFiscalYear.SortOrder = PivotSortOrder.Descending
            Dim fieldCategory As PivotGridField = pivotGridControl.Fields("[Product].[Product Categories].[Category]")
            fieldCategory.Area = PivotArea.RowArea
            fieldCategory.Visible = True
            Dim fieldSalesAmount As PivotGridField = pivotGridControl.Fields("[Measures].[Internet Sales Amount]")
            fieldSalesAmount.Area = PivotArea.DataArea
            fieldSalesAmount.Visible = True
            fieldSalesAmount.Caption = "Sales"
            Dim fieldRatio As PivotGridField = pivotGridControl.Fields("[Measures].[Internet Ratio to All Products]")
            fieldRatio.Area = PivotArea.DataArea
            fieldRatio.Visible = True
            fieldRatio.CellFormat.FormatType = FormatType.Numeric
            fieldRatio.CellFormat.FormatString = "P"
            fieldRatio.Caption = "Ratio"
            Dim fieldRevenueStatus As PivotGridField = pivotGridControl.Fields("[Measures].[Internet Revenue Status]")
            fieldRevenueStatus.Area = PivotArea.DataArea
            fieldRevenueStatus.Visible = True
            fieldRevenueStatus.Caption = "Status"
            Dim fieldRevenueTrend As PivotGridField = pivotGridControl.Fields("[Measures].[Internet Revenue Trend]")
            fieldRevenueTrend.Area = PivotArea.DataArea
            fieldRevenueTrend.Visible = True
            fieldRevenueTrend.Caption = "Trend"
            Await pivotGridControl.EndUpdateAsync()
            Await fieldCategory.ExpandAllAsync()
            Await pivotGridControl.ExpandValueAsync(True, New Object() {CShort(2005)})
            Await pivotGridControl.ExpandValueAsync(True, New Object() {CShort(2005), "H1 FY 2005"})
            Await pivotGridControl.ExpandValueAsync(True, New Object() {CShort(2005), "H1 FY 2005", "Q1 FY 2005"})
            Await pivotGridControl.ExpandValueAsync(True, New Object() {CShort(2005), "H1 FY 2005", "Q1 FY 2005", "July 2005"})
            pivotGridControl.BestFitRowArea()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Private Sub pivotGridControl_FieldValueNotExpanded(ByVal sender As Object, ByVal e As PivotFieldValueEventArgs)
            XtraMessageBox.Show("Cannot show details for this item: it has no child items.", "OLAP Browser", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub pivotGridControl_ShowingCustomizationForm(ByVal sender As Object, ByVal e As CustomizationFormShowingEventArgs)
            e.ParentControl = sidePanel2
            e.CustomizationForm.Dock = DockStyle.Fill
            If DpiAwarenessHelper.Default.IsPerMonitor() Then
                AddHandler e.CustomizationForm.HandleCreated, Sub(s, evArgs) e.CustomizationForm.AutoScaleMode = AutoScaleMode.Inherit
            End If
        End Sub

        Protected Overrides Sub DoDpiChangeAfterParent()
            MyBase.DoDpiChangeAfterParent()
            sidePanel2.Width += 1 'Recalc docking control
            sidePanel2.Width -= 1
        End Sub

        Private Sub pivotGridControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.MenuType = PivotGridMenuType.Header OrElse e.MenuType = PivotGridMenuType.HeaderArea Then
                For Each item As DXMenuItem In e.Menu.Items
                    If Equals(item.Caption, PivotGridLocalizer.GetString(PivotGridStringId.PopupMenuHideFieldList)) Then
                        e.Menu.Items.Remove(item)
                        Exit For
                    End If
                Next
            End If
        End Sub

        Private Sub UpdateControls(ByVal configured As Boolean)
            cbeDatabase.Text = String.Empty
            cbeCube.Text = String.Empty
            Dim isDefaultSample As Boolean = radioGroup1.SelectedIndex = 0
            If isDefaultSample AndAlso Not configured Then
                ConnectToDefault()
            End If

            SetVisibility(Not isDefaultSample)
        End Sub

        Private Sub SetVisibility(ByVal val As Boolean)
            Dim visibility = If(val, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            lciServer.Visibility = visibility
            lciDataBase.Visibility = visibility
            lciCube.Visibility = visibility
            layoutControlItem6.Visibility = visibility
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls(False)
        End Sub

        Private Sub sbConnect_Click(ByVal sender As Object, ByVal e As EventArgs)
            Connect()
        End Sub

        Private Sub Connect()
            Dim info As IOLAPConnectionInfo = connectionHelper.GetOlapConnectionInfo(beServer.Text, cbeDatabase.Text, cbeCube.Text)
            If info.IsError Then
                ProcessError(info)
            Else
                pivotGridControl.Fields.Clear()
                Dim connectionString As String = CType(info, OLAPConnectionStringInfo).ConnectionString
                '<sbConnect>
                pivotGridControl.OLAPConnectionString = connectionString
                '</sbConnect>
                If radioGroup1.SelectedIndex = 2 Then
                    ConfigureLayout()
                Else
                    Call OLAPConfigurator.RetrieveFields(pivotGridControl)
                End If
            End If
        End Sub

        Private Sub cbeDatabase_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If String.IsNullOrEmpty(beServer.Text) Then
                e.Cancel = True
                Return
            End If

            Dim baseInfo As IOLAPConnectionInfo = connectionHelper.GetCatalogList(beServer.Text)
            If baseInfo Is Nothing Then
                e.Cancel = True
                Return
            End If

            If baseInfo.IsError Then
                ProcessError(baseInfo)
                e.Cancel = True
            Else
                cbeDatabase.Properties.Items.Clear()
                cbeDatabase.Properties.Items.AddRange(CType(baseInfo, OLAPStringListConnectionInfo).StringList)
                e.Cancel = False
            End If
        End Sub

        Private Sub cbeCube_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If String.IsNullOrEmpty(beServer.Text) OrElse String.IsNullOrEmpty(cbeDatabase.Text) Then
                e.Cancel = True
                Return
            End If

            Dim baseInfo As IOLAPConnectionInfo = connectionHelper.GetCubeList(beServer.Text, cbeDatabase.Text)
            If baseInfo.IsError Then
                ProcessError(baseInfo)
                e.Cancel = True
            Else
                cbeCube.Properties.Items.Clear()
                cbeCube.Properties.Items.AddRange(CType(baseInfo, OLAPStringListConnectionInfo).StringList)
                e.Cancel = False
            End If
        End Sub

        Private Sub ProcessError(ByVal info As IOLAPConnectionInfo)
            Dim [error] As OLAPConnectionInfoError = CType(info, OLAPConnectionInfoError)
            Dim control As Control = If([error].Type = ConnectionErrorType.ServerName, beServer, If([error].Type = ConnectionErrorType.CatalogName, cbeDatabase, cbeCube))
            ShowBalloon([error].Message, control)
        End Sub

        Private Sub ShowBalloon(ByVal text As String, ByVal control As Control)
            Dim eShow As ToolTipControllerShowEventArgs = toolTipController1.CreateShowArgs()
            eShow.ToolTip = text
            eShow.Title = "Error"
            eShow.IconType = ToolTipIconType.Error
            eShow.IconSize = ToolTipIconSize.Small
            toolTipController1.ShowHint(eShow, control)
        End Sub
    End Class
End Namespace

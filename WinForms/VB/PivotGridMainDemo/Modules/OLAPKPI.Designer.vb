Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class OLAPKPI

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.fieldTrend = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldStatus = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ddlTrendGraphics = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ddlStatusGraphics = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.separator1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ddlTrendGraphics.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ddlStatusGraphics.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldTrend
            ' 
            Me.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldTrend.AreaIndex = 3
            Me.fieldTrend.Caption = "Trend"
            Me.fieldTrend.FieldName = "[Measures].[Internet Revenue Trend]"
            Me.fieldTrend.Name = "fieldTrend"
            Me.fieldTrend.ToolTips.HeaderText = "[Measures].[Internet Revenue Trend]"
            Me.fieldTrend.ToolTips.ValueText = "[Measures].[Internet Revenue Trend]"
            ' 
            ' fieldStatus
            ' 
            Me.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldStatus.AreaIndex = 2
            Me.fieldStatus.Caption = "Status"
            Me.fieldStatus.FieldName = "[Measures].[Internet Revenue Status]"
            Me.fieldStatus.Name = "fieldStatus"
            Me.fieldStatus.ToolTips.HeaderText = "[Measures].[Internet Revenue Status]"
            Me.fieldStatus.ToolTips.ValueText = "[Measures].[Internet Revenue Status]"
            ' 
            ' pivotGridField5
            ' 
            Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField5.AreaIndex = 2
            Me.pivotGridField5.Caption = "Fiscal Quarter"
            Me.pivotGridField5.FieldName = "[Date].[Fiscal].[Fiscal Quarter]"
            Me.pivotGridField5.Name = "pivotGridField5"
            ' 
            ' pivotGridField4
            ' 
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField4.AreaIndex = 1
            Me.pivotGridField4.Caption = "Fiscal Semester"
            Me.pivotGridField4.FieldName = "[Date].[Fiscal].[Fiscal Semester]"
            Me.pivotGridField4.Name = "pivotGridField4"
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.Caption = "Fiscal Year"
            Me.pivotGridField3.FieldName = "[Date].[Fiscal].[Fiscal Year]"
            Me.pivotGridField3.Name = "pivotGridField3"
            ' 
            ' pivotGridField2
            ' 
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField2.AreaIndex = 1
            Me.pivotGridField2.Caption = "Goal"
            Me.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.pivotGridField2.FieldName = "[Measures].[Internet Revenue Goal]"
            Me.pivotGridField2.Name = "pivotGridField2"
            Me.pivotGridField2.ToolTips.HeaderText = "[Measures].[Internet Revenue Goal]"
            Me.pivotGridField2.ToolTips.ValueText = "[Measures].[Internet Revenue Goal]"
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 0
            Me.pivotGridField1.Caption = "Internet Revenue"
            Me.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.pivotGridField1.FieldName = "[Measures].[Internet Sales Amount]"
            Me.pivotGridField1.Name = "pivotGridField1"
            Me.pivotGridField1.ToolTips.HeaderText = "[Measures].[Internet Sales Amount]"
            Me.pivotGridField1.ToolTips.ValueText = "[Measures].[Internet Sales Amount]"
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5, Me.fieldStatus, Me.fieldTrend})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 51)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl.Size = New System.Drawing.Size(490, 419)
            Me.pivotGridControl.TabIndex = 3
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(490, 51)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 419)
            Me.sidePanel1.TabIndex = 18
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 419)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 419)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 392)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ddlTrendGraphics)
            Me.layoutControl1.Controls.Add(Me.ddlStatusGraphics)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(885, 439, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 392)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ddlTrendGraphics
            ' 
            Me.ddlTrendGraphics.EditValue = ""
            Me.ddlTrendGraphics.Location = New System.Drawing.Point(90, 56)
            Me.ddlTrendGraphics.Name = "ddlTrendGraphics"
            Me.ddlTrendGraphics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ddlTrendGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.ddlTrendGraphics.Size = New System.Drawing.Size(97, 20)
            Me.ddlTrendGraphics.StyleController = Me.layoutControl1
            Me.ddlTrendGraphics.TabIndex = 6
            AddHandler Me.ddlTrendGraphics.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTrendGraphic_SelectedIndexChanged)
            ' 
            ' ddlStatusGraphics
            ' 
            Me.ddlStatusGraphics.EditValue = ""
            Me.ddlStatusGraphics.Location = New System.Drawing.Point(90, 32)
            Me.ddlStatusGraphics.Name = "ddlStatusGraphics"
            Me.ddlStatusGraphics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ddlStatusGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.ddlStatusGraphics.Size = New System.Drawing.Size(97, 20)
            Me.ddlStatusGraphics.StyleController = Me.layoutControl1
            Me.ddlStatusGraphics.TabIndex = 4
            AddHandler Me.ddlStatusGraphics.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbStatusGraphic_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 392)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 88)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 304)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 88)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 88)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "KPI Settings"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ddlTrendGraphics
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem2.Text = "Trend graphics"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ddlStatusGraphics
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem1.Text = "Status Graphics"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' separator1
            ' 
            Me.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.separator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.separator1.Location = New System.Drawing.Point(0, 43)
            Me.separator1.Name = "separator1"
            Me.separator1.Size = New System.Drawing.Size(690, 8)
            Me.separator1.TabIndex = 16
            ' 
            ' panelError
            ' 
            Me.panelError.Controls.Add(Me.hyperLinkEdit1)
            Me.panelError.Controls.Add(Me.labelControl1)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(0, 0)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(690, 43)
            Me.panelError.TabIndex = 17
            ' 
            ' hyperLinkEdit1
            ' 
            Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(456, 18)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
            Me.hyperLinkEdit1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Appearance.Options.UseForeColor = True
            Me.labelControl1.AutoEllipsis = True
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(12, 6)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(663, 28)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" & ".0 (or later) " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "installed on your system. You can get the latest version of this" & " provider here:"
            ' 
            ' OLAPKPI
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.separator1)
            Me.Controls.Add(Me.panelError)
            Me.Name = "OLAPKPI"
            Me.Size = New System.Drawing.Size(690, 470)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ddlTrendGraphics.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ddlStatusGraphics.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separator1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ddlTrendGraphics As DevExpress.XtraEditors.ComboBoxEdit

        Private ddlStatusGraphics As DevExpress.XtraEditors.ComboBoxEdit

        Private fieldTrend As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldStatus As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private separator1 As DevExpress.XtraEditors.PanelControl

        Private panelError As DevExpress.XtraEditors.PanelControl

        Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace

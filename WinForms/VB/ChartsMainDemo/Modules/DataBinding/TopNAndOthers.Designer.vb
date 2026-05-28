Namespace DevExpress.XtraCharts.Demos

    Partial Class TopNAndOthersDemo

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim simpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim doughnut3DSeriesLabel1 As DevExpress.XtraCharts.Doughnut3DSeriesLabel = New DevExpress.XtraCharts.Doughnut3DSeriesLabel()
            Dim doughnut3DSeriesView1 As DevExpress.XtraCharts.Doughnut3DSeriesView = New DevExpress.XtraCharts.Doughnut3DSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter()
            Me.oleDbSelectCommand = New System.Data.OleDb.OleDbCommand()
            Me.oleDbConnection = New System.Data.OleDb.OleDbConnection()
            Me.dS21 = New DevExpress.XtraCharts.Demos.DS2()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditCount = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditShowOthers = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.textEditOthersArgument = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemShowOther = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemOthersArgument = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((simpleDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnut3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnut3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dS21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowOthers.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditOthersArgument.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowOther), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemOthersArgument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.DataSource = Me.dS21.Countries
            simpleDiagram3D1.RotationMatrixSerializable = "0.990157351881877;-0.0243454369756547;0.13782495497091;0;0.10562840212504;0.77604" & "3051453063;-0.621771519897728;0;-0.0918207992710787;0.630209871384037;0.77097630" & "237987;0;0;0;0;1"
            simpleDiagram3D1.RuntimeRotation = True
            simpleDiagram3D1.RuntimeScrolling = True
            simpleDiagram3D1.RuntimeZooming = True
            Me.chart.Diagram = simpleDiagram3D1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.RefreshDataOnRepaint = True
            dataMember1.ColumnName = "Country"
            dataMember2.ColumnName = "Area"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2})
            series1.DataAdapter = dataSourceAdapter1
            doughnut3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Tangent
            doughnut3DSeriesLabel1.TextPattern = "{VP:P2}"
            series1.Label = doughnut3DSeriesLabel1
            series1.LegendTextPattern = "{A:P2}"
            series1.Name = "Series 1"
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            series1.TopNOptions.Enabled = True
            series1.TopNOptions.ThresholdPercent = 2.3R
            series1.TopNOptions.ThresholdValue = 7000R
            series1.View = doughnut3DSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 1
            chartTitle1.Text = "Land Area by Country"
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.nationmaster.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' oleDbDataAdapter
            ' 
            Me.oleDbDataAdapter.SelectCommand = Me.oleDbSelectCommand
            Me.oleDbDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Countries", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("OfficialName", "OfficialName"), New System.Data.Common.DataColumnMapping("Area", "Area")})})
            ' 
            ' oleDbSelectCommand
            ' 
            Me.oleDbSelectCommand.CommandText = "SELECT Country, OfficialName, Area FROM Countries"
            Me.oleDbSelectCommand.Connection = Me.oleDbConnection
            ' 
            ' dS21
            ' 
            Me.dS21.DataSetName = "DS2"
            Me.dS21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditCount)
            Me.layoutControl.Controls.Add(Me.checkEditShowOthers)
            Me.layoutControl.Controls.Add(Me.comboBoxEditMode)
            Me.layoutControl.Controls.Add(Me.textEditOthersArgument)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(817, 168, 817, 753)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 172)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditCount
            ' 
            Me.spinEditCount.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditCount.Location = New System.Drawing.Point(107, 106)
            Me.spinEditCount.Name = "spinEditCount"
            Me.spinEditCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditCount.Properties.IsFloatValue = False
            Me.spinEditCount.Properties.MaskSettings.[Set]("mask", "N00")
            Me.spinEditCount.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinEditCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditCount.Size = New System.Drawing.Size(122, 20)
            Me.spinEditCount.StyleController = Me.layoutControl
            Me.spinEditCount.TabIndex = 9
            AddHandler Me.spinEditCount.EditValueChanged, New System.EventHandler(AddressOf Me.checkEditCount_EditValueChanged)
            ' 
            ' checkEditShowOthers
            ' 
            Me.checkEditShowOthers.EditValue = True
            Me.checkEditShowOthers.Location = New System.Drawing.Point(12, 34)
            Me.checkEditShowOthers.Name = "checkEditShowOthers"
            Me.checkEditShowOthers.Properties.Caption = "Show Others"
            Me.checkEditShowOthers.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowOthers.StyleController = Me.layoutControl
            Me.checkEditShowOthers.TabIndex = 10
            AddHandler Me.checkEditShowOthers.EditValueChanged, New System.EventHandler(AddressOf Me.checkEditShowOthers_CheckedChanged)
            ' 
            ' comboBoxEditMode
            ' 
            Me.comboBoxEditMode.EditValue = "Count"
            Me.comboBoxEditMode.Location = New System.Drawing.Point(107, 82)
            Me.comboBoxEditMode.Name = "comboBoxEditMode"
            Me.comboBoxEditMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMode.Properties.Items.AddRange(New Object() {"Count", "Threshold Value", "Threshold Percent"})
            Me.comboBoxEditMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMode.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxEditMode.StyleController = Me.layoutControl
            Me.comboBoxEditMode.TabIndex = 13
            AddHandler Me.comboBoxEditMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBOxEditMode_SelectedIndexChanged)
            ' 
            ' textEditOthersArgument
            ' 
            Me.textEditOthersArgument.EditValue = "Other"
            Me.textEditOthersArgument.Location = New System.Drawing.Point(107, 58)
            Me.textEditOthersArgument.Name = "textEditOthersArgument"
            Me.textEditOthersArgument.Size = New System.Drawing.Size(122, 20)
            Me.textEditOthersArgument.StyleController = Me.layoutControl
            Me.textEditOthersArgument.TabIndex = 14
            AddHandler Me.textEditOthersArgument.EditValueChanged, New System.EventHandler(AddressOf Me.textEditOthersArgument_EditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupLabel})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemCount, Me.layoutControlItemShowOther, Me.layoutControlItemMode, Me.layoutControlItemOthersArgument})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 138)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemCount
            ' 
            Me.layoutControlItemCount.Control = Me.spinEditCount
            Me.layoutControlItemCount.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemCount.Name = "layoutControlItemCount"
            Me.layoutControlItemCount.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemCount.Text = "Count:"
            Me.layoutControlItemCount.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlItemShowOther
            ' 
            Me.layoutControlItemShowOther.Control = Me.checkEditShowOthers
            Me.layoutControlItemShowOther.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemShowOther.Name = "layoutControlItemShowOther"
            Me.layoutControlItemShowOther.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemShowOther.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemShowOther.TextVisible = False
            ' 
            ' layoutControlItemMode
            ' 
            Me.layoutControlItemMode.Control = Me.comboBoxEditMode
            Me.layoutControlItemMode.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemMode.Name = "layoutControlItemMode"
            Me.layoutControlItemMode.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMode.Text = "Mode"
            Me.layoutControlItemMode.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlItemOthersArgument
            ' 
            Me.layoutControlItemOthersArgument.Control = Me.textEditOthersArgument
            Me.layoutControlItemOthersArgument.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemOthersArgument.Name = "layoutControlItemOthersArgument"
            Me.layoutControlItemOthersArgument.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemOthersArgument.Text = "Others Argument"
            Me.layoutControlItemOthersArgument.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 204)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 334)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 138)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 66)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' TopNAndOthersDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "TopNAndOthersDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((simpleDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnut3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnut3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dS21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowOthers.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditOthersArgument.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowOther), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemOthersArgument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter

        Private oleDbSelectCommand As System.Data.OleDb.OleDbCommand

        Private oleDbConnection As System.Data.OleDb.OleDbConnection

        Private dS21 As DevExpress.XtraCharts.Demos.DS2

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditShowOthers As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemShowOther As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditCount As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemCount As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMode As DevExpress.XtraLayout.LayoutControlItem

        Private textEditOthersArgument As DevExpress.XtraEditors.TextEdit

        Private layoutControlItemOthersArgument As DevExpress.XtraLayout.LayoutControlItem

        Private chart As DevExpress.XtraCharts.ChartControl

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

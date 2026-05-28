Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class PivotModuleNew
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement6 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement7 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement8 As New DevExpress.XtraEditors.TileItemElement()
			Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.tiles = New DevExpress.ProductsDemo.Win.PivotTileControl()
			Me.tileGroup1 = New DevExpress.XtraEditors.TileGroup()
			Me.tiRevenue = New DevExpress.XtraEditors.TileItem()
			Me.tiUnitSales = New DevExpress.XtraEditors.TileItem()
			Me.tiDirectSales = New DevExpress.XtraEditors.TileItem()
			Me.tiBestSector = New DevExpress.XtraEditors.TileItem()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.pivot = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.chartsPanel = New DevExpress.XtraEditors.PanelControl()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.ucUnits = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
			Me.ucSales = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.pivot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.chartsPanel.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' rangeControl
			' 
			Me.tableLayoutPanel1.SetColumnSpan(Me.rangeControl, 2)
			Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rangeControl.Location = New System.Drawing.Point(3, 175)
			Me.rangeControl.Name = "rangeControl"
			rangeControlRange1.Maximum = 4.5R
			rangeControlRange1.Minimum = -0.5R
			rangeControlRange1.Owner = Me.rangeControl
			Me.rangeControl.SelectedRange = rangeControlRange1
			Me.rangeControl.ShowToolTips = False
			Me.rangeControl.ShowZoomScrollBar = False
			Me.rangeControl.Size = New System.Drawing.Size(1036, 54)
			Me.rangeControl.TabIndex = 5
			Me.rangeControl.Text = "rangeControl1"
			Me.rangeControl.VisibleRangeMaximumScaleFactor = 1R
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.tiles)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
			Me.panelControl1.Size = New System.Drawing.Size(1042, 111)
			Me.panelControl1.TabIndex = 0
			' 
			' tiles
			' 
			Me.tiles.AllowDrag = False
			Me.tiles.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(51)))), (CInt((CByte(116)))), (CInt((CByte(189)))))
			Me.tiles.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DodgerBlue
			Me.tiles.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tiles.AppearanceItem.Normal.Options.UseBorderColor = True
			Me.tiles.AppearanceText.Font = New System.Drawing.Font("Segoe Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tiles.AppearanceText.Options.UseFont = True
			Me.tiles.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tiles.Groups.Add(Me.tileGroup1)
			Me.tiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.tiles.IndentBetweenGroups = 0
			Me.tiles.ItemSize = 101
			Me.tiles.LargeItemWidth = 250
			Me.tiles.Location = New System.Drawing.Point(4, 4)
			Me.tiles.Margin = New System.Windows.Forms.Padding(0)
			Me.tiles.MaxId = 9
			Me.tiles.Name = "tiles"
			Me.tiles.Padding = New System.Windows.Forms.Padding(0)
			Me.tiles.RowCount = 1
			Me.tiles.Size = New System.Drawing.Size(1034, 107)
			Me.tiles.TabIndex = 0
			Me.tiles.Text = "Dashboard: Sales by Product"
			Me.tiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
			' 
			' tileGroup1
			' 
			Me.tileGroup1.Items.Add(Me.tiRevenue)
			Me.tileGroup1.Items.Add(Me.tiUnitSales)
			Me.tileGroup1.Items.Add(Me.tiDirectSales)
			Me.tileGroup1.Items.Add(Me.tiBestSector)
			Me.tileGroup1.Name = "tileGroup1"
			Me.tileGroup1.Text = "tileGroup1"
			' 
			' tiRevenue
			' 
			Me.tiRevenue.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tiRevenue.AppearanceItem.Normal.Options.UseFont = True
			tileItemElement1.Text = "Revenues<br><size=10>YTD GROWTH"
			tileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe Condensed", 30F)
			tileItemElement2.Appearance.Normal.Options.UseFont = True
			tileItemElement2.Text = "+1%"
			tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
			Me.tiRevenue.Elements.Add(tileItemElement1)
			Me.tiRevenue.Elements.Add(tileItemElement2)
			Me.tiRevenue.Id = 5
			Me.tiRevenue.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tiRevenue.Name = "tiRevenue"
			' 
			' tiUnitSales
			' 
			Me.tiUnitSales.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tiUnitSales.AppearanceItem.Normal.Options.UseFont = True
			tileItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			tileItemElement3.Appearance.Normal.Options.UseFont = True
			tileItemElement3.Text = "Unit Sales<br><size=10>YTD"
			tileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			tileItemElement4.Appearance.Normal.Options.UseFont = True
			tileItemElement4.Text = "2820"
			tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
			Me.tiUnitSales.Elements.Add(tileItemElement3)
			Me.tiUnitSales.Elements.Add(tileItemElement4)
			Me.tiUnitSales.Id = 6
			Me.tiUnitSales.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tiUnitSales.Name = "tiUnitSales"
			' 
			' tiDirectSales
			' 
			Me.tiDirectSales.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tiDirectSales.AppearanceItem.Normal.Options.UseFont = True
			tileItemElement5.Text = "Direct Sales<br><size=10>YTD"
			tileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Segoe Condensed", 30F)
			tileItemElement6.Appearance.Normal.Options.UseFont = True
			tileItemElement6.Text = "$200M"
			tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
			Me.tiDirectSales.Elements.Add(tileItemElement5)
			Me.tiDirectSales.Elements.Add(tileItemElement6)
			Me.tiDirectSales.Id = 7
			Me.tiDirectSales.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tiDirectSales.Name = "tiDirectSales"
			' 
			' tiBestSector
			' 
			Me.tiBestSector.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.tiBestSector.AppearanceItem.Normal.Options.UseFont = True
			tileItemElement7.Text = "Best Sector YTD<br><size=10>{0}"
			tileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe Condensed", 30F)
			tileItemElement8.Appearance.Normal.Options.UseFont = True
			tileItemElement8.Text = "$14M"
			tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
			Me.tiBestSector.Elements.Add(tileItemElement7)
			Me.tiBestSector.Elements.Add(tileItemElement8)
			Me.tiBestSector.Id = 8
			Me.tiBestSector.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tiBestSector.Name = "tiBestSector"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.pivot)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(0, 111)
			Me.panelControl2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Padding = New System.Windows.Forms.Padding(3)
			Me.panelControl2.Size = New System.Drawing.Size(1042, 328)
			Me.panelControl2.TabIndex = 1
			' 
			' pivot
			' 
			Me.pivot.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivot.Location = New System.Drawing.Point(3, 3)
			Me.pivot.Name = "pivot"
			Me.pivot.OptionsView.ShowFilterHeaders = False
			Me.pivot.Size = New System.Drawing.Size(1036, 322)
			Me.pivot.TabIndex = 0
			' 
			' chartsPanel
			' 
			Me.chartsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.chartsPanel.Controls.Add(Me.tableLayoutPanel1)
			Me.chartsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.chartsPanel.Location = New System.Drawing.Point(0, 439)
			Me.chartsPanel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.chartsPanel.Name = "chartsPanel"
			Me.chartsPanel.Size = New System.Drawing.Size(1042, 232)
			Me.chartsPanel.TabIndex = 2
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.95702F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.04298F))
			Me.tableLayoutPanel1.Controls.Add(Me.ucUnits, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.ucSales, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.rangeControl, 0, 1)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(1042, 232)
			Me.tableLayoutPanel1.TabIndex = 5
			' 
			' ucUnits
			' 
			Me.ucUnits.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ucUnits.Location = New System.Drawing.Point(2, 3)
			Me.ucUnits.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.ucUnits.Name = "ucUnits"
			Me.ucUnits.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.ucUnits.ShowButtonsPanel = False
			Me.ucUnits.ShowCaptionPanel = False
			Me.ucUnits.Size = New System.Drawing.Size(631, 166)
			Me.ucUnits.TabIndex = 1
			' 
			' ucSales
			' 
			Me.ucSales.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ucSales.Location = New System.Drawing.Point(637, 3)
			Me.ucSales.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.ucSales.Name = "ucSales"
			Me.ucSales.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
			Me.ucSales.ShowButtonsPanel = False
			Me.ucSales.ShowCaptionPanel = False
			Me.ucSales.Size = New System.Drawing.Size(403, 166)
			Me.ucSales.TabIndex = 0
			' 
			' PivotModuleNew
			' 
			Me.Appearance.Font = New System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.chartsPanel)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
			Me.Name = "PivotModuleNew"
			Me.Size = New System.Drawing.Size(1042, 671)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.pivot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.chartsPanel.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As XtraEditors.PanelControl
		Private tiles As PivotTileControl
		Private tileGroup1 As XtraEditors.TileGroup
		Private tiRevenue As XtraEditors.TileItem
		Private tiUnitSales As XtraEditors.TileItem
		Private tiDirectSales As XtraEditors.TileItem
		Private tiBestSector As XtraEditors.TileItem
		Private panelControl2 As XtraEditors.PanelControl
		Private chartsPanel As XtraEditors.PanelControl
		Private ucSales As SalesDemo.Win.Modules.ucSalesPerformance
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private pivot As XtraPivotGrid.PivotGridControl
		Private ucUnits As SalesDemo.Win.Modules.ucSalesPerformance
		Private rangeControl As XtraEditors.RangeControl

	End Class
End Namespace

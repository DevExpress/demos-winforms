Namespace DevExpress.XtraGauges.Demos

    Partial Class Databinding

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
            Me.components = New System.ComponentModel.Container()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dsCategories = New DevExpress.XtraGauges.Demos.dsCategories()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsCategories), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.gaugeControl3)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(954, 166, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(565, 431)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gaugeControl2
            ' 
            Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.gaugeControl2.Location = New System.Drawing.Point(392, 266)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.ShowToolTips = True
            Me.gaugeControl2.Size = New System.Drawing.Size(149, 141)
            Me.gaugeControl2.TabIndex = 6
            ' 
            ' circularGauge2
            ' 
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent2})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 137, 129)
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent2})
            Me.circularGauge2.OptionsToolTip.TooltipTitle = "UnitsOnOrder"
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent2})
            ' 
            ' arcScaleBackgroundLayerComponent2
            ' 
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "bg"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.619F)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style1
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(250F, 202F)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' arcScaleComponent2
            ' 
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.productsBindingSource, "UnitsOnOrder", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.arcScaleComponent2.EndAngle = 30F
            Me.arcScaleComponent2.MajorTickCount = 9
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent2.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 160F
            Me.arcScaleComponent2.MinorTickCount = 4
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent2.Name = "scale1"
            Me.arcScaleComponent2.StartAngle = -210F
            Me.arcScaleComponent2.Value = 80F
            ' 
            ' productsBindingSource
            ' 
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.dsCategories
            ' 
            ' dsCategories
            ' 
            Me.dsCategories.DataSetName = "dsCategories"
            Me.dsCategories.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' arcScaleNeedleComponent2
            ' 
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.Name = "needle"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent2.StartOffset = -4.5F
            Me.arcScaleNeedleComponent2.ZOrder = -50
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(392, 88)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.ShowToolTips = True
            Me.gaugeControl1.Size = New System.Drawing.Size(149, 130)
            Me.gaugeControl1.TabIndex = 5
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 137, 118)
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.OptionsToolTip.TooltipTitle = "UnitsInStock"
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "bg"
            Me.arcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.619F)
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style1
            Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(250F, 202F)
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
            Me.arcScaleComponent1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.productsBindingSource, "UnitsInStock", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.arcScaleComponent1.EndAngle = 30F
            Me.arcScaleComponent1.MajorTickCount = 9
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -15F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 160F
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.StartAngle = -210F
            Me.arcScaleComponent1.Value = 80F
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.Name = "needle"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
            Me.arcScaleNeedleComponent1.StartOffset = -4.5F
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.productsBindingSource
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(367, 431)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDiscontinued, Me.colProductName, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 2
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 1
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 3
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Visible = True
            Me.colUnitsOnOrder.VisibleIndex = 4
            ' 
            ' gaugeControl3
            ' 
            Me.gaugeControl3.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge1})
            Me.gaugeControl3.Location = New System.Drawing.Point(368, 0)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.ShowToolTips = True
            Me.gaugeControl3.Size = New System.Drawing.Size(197, 64)
            Me.gaugeControl3.TabIndex = 6
            ' 
            ' digitalGauge1
            ' 
            Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8C8C8")
            Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 185, 52)
            Me.digitalGauge1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.productsBindingSource, "ProductName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
            Me.digitalGauge1.DigitCount = 0
            Me.digitalGauge1.Name = "digitalGauge1"
            Me.digitalGauge1.OptionsToolTip.TooltipTitle = "ProductName"
            Me.digitalGauge1.Text = "00,000"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.simpleSeparator1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(565, 431)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(367, 431)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gaugeControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(368, 64)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(197, 178)
            Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(24, 24, 24, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.gaugeControl2
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(368, 242)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(197, 189)
            Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(24, 24, 24, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gaugeControl3
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(368, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(197, 64)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.Location = New System.Drawing.Point(367, 0)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(1, 431)
            ' 
            ' Databinding
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Databinding"
            Me.Size = New System.Drawing.Size(565, 431)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.circularGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsCategories), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private productsBindingSource As System.Windows.Forms.BindingSource

        Private dsCategories As DevExpress.XtraGauges.Demos.dsCategories

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private gaugeControl3 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    End Class
End Namespace

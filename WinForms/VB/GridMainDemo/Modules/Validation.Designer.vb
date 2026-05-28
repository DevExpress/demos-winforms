Namespace DevExpress.XtraGrid.Demos

    Partial Class Validation

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.Validation))
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindOrders1 = New DevExpress.XtraGrid.Demos.dsNWindOrders()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.validationControl1 = New DevExpress.XtraGrid.Demos.ValidationControl()
            Me.validationControl3 = New DevExpress.XtraGrid.Demos.ValidationControl()
            Me.validationControl2 = New DevExpress.XtraGrid.Demos.ValidationControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsNWindOrders1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumn2.FieldName = "ProductID"
            Me.gridColumn2.Name = "gridColumn2"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemCalcEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.AppearanceHeader.Font = CType((resources.GetObject("gridColumn5.AppearanceHeader.Font")), System.Drawing.Font)
            Me.gridColumn5.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.DisplayFormat.FormatString = "p"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn5.FieldName = "Discount"
            Me.gridColumn5.Name = "gridColumn5"
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.AppearanceHeader.Font = CType((resources.GetObject("gridColumn4.AppearanceHeader.Font")), System.Drawing.Font)
            Me.gridColumn4.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn4.FieldName = "Quantity"
            Me.gridColumn4.Name = "gridColumn4"
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsNWindOrders1.Order_Details
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' dsNWindOrders1
            ' 
            Me.dsNWindOrders1.DataSetName = "dsNWindOrders"
            Me.dsNWindOrders1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindOrders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.Lavender
            Me.gridView1.Appearance.EvenRow.BackColor2 = CType((resources.GetObject("gridView1.Appearance.EvenRow.BackColor2")), System.Drawing.Color)
            Me.gridView1.Appearance.EvenRow.GradientMode = CType((resources.GetObject("gridView1.Appearance.EvenRow.GradientMode")), System.Drawing.Drawing2D.LinearGradientMode)
            Me.gridView1.Appearance.EvenRow.Options.UseBackColor = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            AddHandler Me.gridView1.RowCellStyle, New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(AddressOf Me.gridView1_RowCellStyle)
            AddHandler Me.gridView1.ValidateRow, New DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(AddressOf Me.gridView1_ValidateRow)
            AddHandler Me.gridView1.ValidatingEditor, New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(AddressOf Me.gridView1_ValidatingEditor)
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "OrderID"
            Me.gridColumn1.Name = "gridColumn1"
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.AppearanceHeader.Font = CType((resources.GetObject("gridColumn3.AppearanceHeader.Font")), System.Drawing.Font)
            Me.gridColumn3.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "UnitPrice"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsFilter.AllowFilter = False
            ' 
            ' gridColumn6
            ' 
            Me.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.LightSkyBlue
            Me.gridColumn6.AppearanceCell.BackColor2 = CType((resources.GetObject("gridColumn6.AppearanceCell.BackColor2")), System.Drawing.Color)
            Me.gridColumn6.AppearanceCell.Font = CType((resources.GetObject("gridColumn6.AppearanceCell.Font")), System.Drawing.Font)
            Me.gridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.Indigo
            Me.gridColumn6.AppearanceCell.GradientMode = CType((resources.GetObject("gridColumn6.AppearanceCell.GradientMode")), System.Drawing.Drawing2D.LinearGradientMode)
            Me.gridColumn6.AppearanceCell.Options.UseBackColor = True
            Me.gridColumn6.AppearanceCell.Options.UseFont = True
            Me.gridColumn6.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.DisplayFormat.FormatString = "c"
            Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn6.FieldName = "SubTotal"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowEdit = False
            Me.gridColumn6.OptionsColumn.[ReadOnly] = True
            Me.gridColumn6.OptionsFilter.AllowFilter = False
            Me.gridColumn6.UnboundDataType = GetType(Decimal)
            Me.gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
            ' 
            ' validationControl1
            ' 
            resources.ApplyResources(Me.validationControl1, "validationControl1")
            Me.validationControl1.Name = "validationControl1"
            AddHandler Me.validationControl1.ValidateCondition, New System.EventHandler(AddressOf Me.validationControl_ValidateCondition)
            ' 
            ' validationControl3
            ' 
            resources.ApplyResources(Me.validationControl3, "validationControl3")
            Me.validationControl3.Name = "validationControl3"
            AddHandler Me.validationControl3.ValidateCondition, New System.EventHandler(AddressOf Me.validationControl_ValidateCondition)
            ' 
            ' validationControl2
            ' 
            resources.ApplyResources(Me.validationControl2, "validationControl2")
            Me.validationControl2.Name = "validationControl2"
            AddHandler Me.validationControl2.ValidateCondition, New System.EventHandler(AddressOf Me.validationControl_ValidateCondition)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.AutoWidthInLayoutControl = True
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.validationControl3)
            Me.layoutControl1.Controls.Add(Me.validationControl1)
            Me.layoutControl1.Controls.Add(Me.validationControl2)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(640, 462)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.validationControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 346)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(620, 32)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.validationControl3
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 378)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(620, 32)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.validationControl2
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 410)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(620, 32)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gridControl1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(620, 320)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.simpleButton1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(132, 26)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(132, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(488, 26)
            ' 
            ' Validation
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Validation"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Validation_Load)
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsNWindOrders1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private validationControl1 As DevExpress.XtraGrid.Demos.ValidationControl

        Private validationControl2 As DevExpress.XtraGrid.Demos.ValidationControl

        Private validationControl3 As DevExpress.XtraGrid.Demos.ValidationControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private dsNWindOrders1 As DevExpress.XtraGrid.Demos.dsNWindOrders

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

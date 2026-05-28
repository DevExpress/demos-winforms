Namespace DevExpress.XtraTreeList.Demos

    Partial Class TreeListMultiEditors

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.TreeListMultiEditors))
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.treeList1.Appearance.HeaderPanel.Options.UseFont = True
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AutoNodeHeight = False
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemComboBox1, Me.repositoryImageComboBox1, Me.repositoryItemProgressBar1, Me.repositoryItemTextEdit1})
            Me.treeList1.Size = New System.Drawing.Size(580, 296)
            Me.treeList1.TabIndex = 1
            AddHandler Me.treeList1.CustomNodeCellEdit, New DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(AddressOf Me.treeList1_GetCustomNodeCellEdit)
            AddHandler Me.treeList1.CustomDrawNodeCell, New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(AddressOf Me.treeList1_CustomDrawNodeCell)
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.treeListColumn1.AppearanceCell.Options.UseFont = True
            Me.treeListColumn1.Caption = "Category"
            Me.treeListColumn1.FieldName = "Category"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.OptionsColumn.AllowEdit = False
            Me.treeListColumn1.OptionsColumn.AllowFocus = False
            Me.treeListColumn1.OptionsColumn.AllowMoveToCustomizationForm = False
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "Product1"
            Me.treeListColumn2.FieldName = "Product1"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.OptionsColumn.AllowSort = False
            Me.treeListColumn2.OptionsFilter.AllowAutoFilter = False
            Me.treeListColumn2.OptionsFilter.AllowFilter = False
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            ' 
            ' treeListColumn3
            ' 
            Me.treeListColumn3.Caption = "Product2"
            Me.treeListColumn3.FieldName = "Product2"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.OptionsColumn.AllowSort = False
            Me.treeListColumn3.OptionsFilter.AllowAutoFilter = False
            Me.treeListColumn3.OptionsFilter.AllowFilter = False
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            ' 
            ' treeListColumn4
            ' 
            Me.treeListColumn4.Caption = "Product3"
            Me.treeListColumn4.FieldName = "Product3"
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.OptionsColumn.AllowSort = False
            Me.treeListColumn4.OptionsFilter.AllowAutoFilter = False
            Me.treeListColumn4.OptionsFilter.AllowFilter = False
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AllowFocused = False
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' repositoryItemCheckEdit1
            ' 
            Me.repositoryItemCheckEdit1.AllowFocused = False
            Me.repositoryItemCheckEdit1.AutoHeight = False
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AllowFocused = False
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.DisplayFormat.FormatString = "c"
            Me.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AllowFocused = False
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AllowFocused = False
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' repositoryImageComboBox1
            ' 
            Me.repositoryImageComboBox1.AllowFocused = False
            Me.repositoryImageComboBox1.AutoHeight = False
            Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Beverages", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Confections", 2, 1)})
            Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
            Me.repositoryImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Beverages", CType((resources.GetObject("svgImageCollection1.Beverages")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("confections", CType((resources.GetObject("svgImageCollection1.confections")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.EndColor = System.Drawing.Color.OldLace
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.StartColor = System.Drawing.Color.DarkKhaki
            AddHandler Me.repositoryItemProgressBar1.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.repositoryItemProgressBar1_KeyDown)
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AllowFocused = False
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "(999) 000-0000"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(580, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 296)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(580, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 296)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(580, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 296)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "ShowButtons_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "TreeView_16x16.png")
            Me.imageCollection1.Images.SetKeyName(2, "ShowRoot_16x16.png")
            Me.imageCollection1.Images.SetKeyName(3, "CanResizeNodes_16x16.png")
            ' 
            ' TreeListMultiEditors
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "TreeListMultiEditors"
            Me.Size = New System.Drawing.Size(580, 296)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private components As System.ComponentModel.IContainer

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace

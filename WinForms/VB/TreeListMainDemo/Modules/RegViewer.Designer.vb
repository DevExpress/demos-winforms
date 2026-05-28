Namespace DevExpress.XtraTreeList.Demos

    Partial Class TreeListRegViewer

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
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.treeList2 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.sidePanel3 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel3.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList1.ChildListFieldName = "Items"
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.EnableDynamicLoading = False
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsBehavior.ResizeNodes = False
            Me.treeList1.OptionsMenu.EnableFooterMenu = False
            Me.treeList1.OptionsPrint.PrintHorzLines = False
            Me.treeList1.OptionsPrint.PrintVertLines = False
            Me.treeList1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList1.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell
            Me.treeList1.SelectImageList = Me.svgImageCollection1
            Me.treeList1.Size = New System.Drawing.Size(322, 290)
            Me.treeList1.TabIndex = 0
            Me.treeList1.TreeViewFieldName = "Name"
            AddHandler Me.treeList1.GetSelectImage, New DevExpress.XtraTreeList.GetSelectImageEventHandler(AddressOf Me.treeList1_GetSelectImage)
            AddHandler Me.treeList1.BeforeExpand, New DevExpress.XtraTreeList.BeforeExpandEventHandler(AddressOf Me.treeList1_BeforeExpand)
            AddHandler Me.treeList1.FocusedNodeChanged, New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(AddressOf Me.treeList1_FocusedNodeChanged)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("electronics_desktopmac", "image://svgimages/icon builder/electronics_desktopmac.svg")
            Me.svgImageCollection1.Add("actions_folderclose", "image://svgimages/icon builder/actions_folderclose.svg")
            Me.svgImageCollection1.Add("open", "image://svgimages/actions/open.svg")
            Me.svgImageCollection1.Add("string", "image://svgimages/snap/string.svg")
            Me.svgImageCollection1.Add("array", "image://svgimages/snap/array.svg")
            ' 
            ' treeList2
            ' 
            Me.treeList2.AutoFillColumn = Me.treeListColumn2
            Me.treeList2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3})
            Me.treeList2.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList2.Location = New System.Drawing.Point(0, 0)
            Me.treeList2.Name = "treeList2"
            Me.treeList2.OptionsBehavior.Editable = False
            Me.treeList2.OptionsBehavior.ResizeNodes = False
            Me.treeList2.OptionsMenu.EnableFooterMenu = False
            Me.treeList2.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList2.OptionsView.AutoCalcPreviewLineCount = True
            Me.treeList2.OptionsView.AutoWidth = False
            Me.treeList2.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList2.OptionsView.ShowHorzLines = False
            Me.treeList2.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList2.OptionsView.ShowIndicator = False
            Me.treeList2.OptionsView.ShowRoot = False
            Me.treeList2.OptionsView.ShowVertLines = False
            Me.treeList2.SelectImageList = Me.svgImageCollection1
            Me.treeList2.Size = New System.Drawing.Size(347, 290)
            Me.treeList2.TabIndex = 1
            AddHandler Me.treeList2.GetSelectImage, New DevExpress.XtraTreeList.GetSelectImageEventHandler(AddressOf Me.treeList2_GetSelectImage)
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "Data"
            Me.treeListColumn2.FieldName = "Data"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 2
            Me.treeListColumn2.Width = 39
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 187
            ' 
            ' treeListColumn3
            ' 
            Me.treeListColumn3.Caption = "Type"
            Me.treeListColumn3.FieldName = "Type"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 1
            Me.treeListColumn3.Width = 121
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.treeList1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel1.Location = New System.Drawing.Point(0, 19)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(323, 290)
            Me.sidePanel1.TabIndex = 3
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.treeList2)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel2.Location = New System.Drawing.Point(323, 19)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(347, 290)
            Me.sidePanel2.TabIndex = 4
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textEdit1.Location = New System.Drawing.Point(0, 0)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEdit1.Properties.[ReadOnly] = True
            Me.textEdit1.Properties.UseReadOnlyAppearance = False
            Me.textEdit1.Size = New System.Drawing.Size(670, 18)
            Me.textEdit1.TabIndex = 1
            ' 
            ' sidePanel3
            ' 
            Me.sidePanel3.AllowResize = False
            Me.sidePanel3.Controls.Add(Me.textEdit1)
            Me.sidePanel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel3.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel3.Name = "sidePanel3"
            Me.sidePanel3.Size = New System.Drawing.Size(670, 19)
            Me.sidePanel3.TabIndex = 5
            Me.sidePanel3.Text = "sidePanel3"
            ' 
            ' TreeListRegViewer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.sidePanel3)
            Me.Name = "TreeListRegViewer"
            Me.Size = New System.Drawing.Size(670, 309)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel3.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treeList2 As DevExpress.XtraTreeList.TreeList

        Private components As System.ComponentModel.IContainer = Nothing

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private sidePanel3 As DevExpress.XtraEditors.SidePanel

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace

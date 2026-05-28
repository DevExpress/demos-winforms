Namespace DevExpress.XtraTreeList.Demos

    Partial Class TreeListPictures

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.TreeListPictures))
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.colCommonName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colLenght = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colNotes = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.colPicture = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCommonName, Me.colLenght, Me.colNotes, Me.colPicture})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsPrint.PrintReportFooter = False
            Me.treeList1.OptionsPrint.UsePrintStyles = True
            Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
            Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList1.PreviewFieldName = "Notes"
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemMemoEdit1})
            Me.treeList1.Size = New System.Drawing.Size(788, 377)
            Me.treeList1.TabIndex = 0
            ' 
            ' colCommonName
            ' 
            Me.colCommonName.Caption = "Common Name"
            Me.colCommonName.FieldName = "Common Name"
            Me.colCommonName.Name = "colCommonName"
            Me.colCommonName.Visible = True
            Me.colCommonName.VisibleIndex = 0
            Me.colCommonName.Width = 150
            ' 
            ' colLenght
            ' 
            Me.colLenght.Caption = "Length(cm)"
            Me.colLenght.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colLenght.FieldName = "Length(cm)"
            Me.colLenght.Name = "colLenght"
            Me.colLenght.Visible = True
            Me.colLenght.VisibleIndex = 1
            Me.colLenght.Width = 100
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
            ' colNotes
            ' 
            Me.colNotes.Caption = "Notes"
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 2
            Me.colNotes.Width = 200
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.AllowFocused = False
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colPicture
            ' 
            Me.colPicture.AppearanceCell.BackColor = System.Drawing.Color.White
            Me.colPicture.AppearanceCell.Options.UseBackColor = True
            Me.colPicture.Caption = "Picture"
            Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.OptionsColumn.AllowEdit = False
            Me.colPicture.OptionsColumn.AllowSort = False
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 3
            Me.colPicture.Width = 250
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "PrintPreview_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "PrintDesigner_16x16.png")
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.MaxItemId = 0
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(788, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 377)
            Me.barDockControlBottom.Size = New System.Drawing.Size(788, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 377)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(788, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 377)
            ' 
            ' TreeListPictures
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "TreeListPictures"
            Me.Size = New System.Drawing.Size(788, 377)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private colNotes As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPicture As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCommonName As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colLenght As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private components As System.ComponentModel.IContainer
    End Class
End Namespace

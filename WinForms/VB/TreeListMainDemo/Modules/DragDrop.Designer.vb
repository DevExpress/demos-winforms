Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos

    Partial Class TreeListDragDrop

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim itemTemplateBase1 As DevExpress.XtraEditors.TableLayout.ItemTemplateBase = New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim templatedItemElement1 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement2 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement3 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.colFullName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBirthDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colHireDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colPhone = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCity = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colEmailAddress = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colJobTitle = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colGroupName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colPhoto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.dragDropEvents1 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
            Me.dragDropEvents2 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' listBoxControl
            ' 
            Me.behaviorManager1.SetBehaviors(Me.listBoxControl, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraEditors.DragDropBehaviorSourceForListBox), True, True, True, True, Me.dragDropEvents1)), DevExpress.Utils.Behaviors.Behavior)})
            Me.listBoxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.listBoxControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl.ItemHeight = 80
            Me.listBoxControl.Location = New System.Drawing.Point(1, 0)
            Me.listBoxControl.Name = "listBoxControl"
            Me.listBoxControl.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.listBoxControl.Size = New System.Drawing.Size(220, 441)
            Me.listBoxControl.TabIndex = 0
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 68R
            tableColumnDefinition2.Length.Value = 164R
            tableColumnDefinition2.PaddingLeft = 10
            itemTemplateBase1.Columns.Add(tableColumnDefinition1)
            itemTemplateBase1.Columns.Add(tableColumnDefinition2)
            templatedItemElement1.FieldName = "Photo"
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement1.Text = "Photo"
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement2.Appearance.Normal.FontSizeDelta = 1
            templatedItemElement2.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            templatedItemElement2.Appearance.Normal.Options.UseFont = True
            templatedItemElement2.ColumnIndex = 1
            templatedItemElement2.FieldName = "FullName"
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement2.Text = "FullName"
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
            templatedItemElement3.ColumnIndex = 1
            templatedItemElement3.FieldName = "JobTitle"
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement3.RowIndex = 1
            templatedItemElement3.Text = "JobTitle"
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            itemTemplateBase1.Elements.Add(templatedItemElement1)
            itemTemplateBase1.Elements.Add(templatedItemElement2)
            itemTemplateBase1.Elements.Add(templatedItemElement3)
            itemTemplateBase1.Name = "CustomTemplate"
            tableRowDefinition1.PaddingBottom = 3
            tableRowDefinition2.PaddingTop = 3
            itemTemplateBase1.Rows.Add(tableRowDefinition1)
            itemTemplateBase1.Rows.Add(tableRowDefinition2)
            tableSpan1.RowSpan = 2
            itemTemplateBase1.Spans.Add(tableSpan1)
            Me.listBoxControl.Templates.Add(itemTemplateBase1)
            ' 
            ' treeList1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.treeList1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraTreeList.TreeListDragDropSource), True, True, True, True, Me.dragDropEvents2)), DevExpress.Utils.Behaviors.Behavior)})
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colFullName, Me.colBirthDate, Me.colHireDate, Me.colPhone, Me.colCity, Me.colEmailAddress, Me.colJobTitle, Me.colGroupName, Me.colPhoto})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.KeyFieldName = "Id"
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsSelection.MultiSelect = True
            Me.treeList1.OptionsSelection.UseIndicatorForSelection = True
            Me.treeList1.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList1.ParentFieldName = "ParentId"
            Me.treeList1.RowHeight = 40
            Me.treeList1.Size = New System.Drawing.Size(392, 441)
            Me.treeList1.TabIndex = 1
            ' 
            ' colFullName
            ' 
            Me.colFullName.FieldName = "FullName"
            Me.colFullName.MinWidth = 60
            Me.colFullName.Name = "colFullName"
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 0
            Me.colFullName.Width = 70
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.MaxWidth = 150
            Me.colBirthDate.MinWidth = 40
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.Visible = True
            Me.colBirthDate.VisibleIndex = 5
            Me.colBirthDate.Width = 57
            ' 
            ' colHireDate
            ' 
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.MaxWidth = 150
            Me.colHireDate.MinWidth = 40
            Me.colHireDate.Name = "colHireDate"
            Me.colHireDate.Visible = True
            Me.colHireDate.VisibleIndex = 4
            Me.colHireDate.Width = 65
            ' 
            ' colPhone
            ' 
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.MaxWidth = 200
            Me.colPhone.MinWidth = 40
            Me.colPhone.Name = "colPhone"
            Me.colPhone.Visible = True
            Me.colPhone.VisibleIndex = 3
            Me.colPhone.Width = 49
            ' 
            ' colCity
            ' 
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            Me.colCity.Width = 48
            ' 
            ' colEmailAddress
            ' 
            Me.colEmailAddress.FieldName = "EmailAddress"
            Me.colEmailAddress.MaxWidth = 300
            Me.colEmailAddress.MinWidth = 40
            Me.colEmailAddress.Name = "colEmailAddress"
            Me.colEmailAddress.Visible = True
            Me.colEmailAddress.VisibleIndex = 2
            Me.colEmailAddress.Width = 58
            ' 
            ' colJobTitle
            ' 
            Me.colJobTitle.FieldName = "JobTitle"
            Me.colJobTitle.MinWidth = 40
            Me.colJobTitle.Name = "colJobTitle"
            Me.colJobTitle.Visible = True
            Me.colJobTitle.VisibleIndex = 1
            Me.colJobTitle.Width = 83
            ' 
            ' colGroupName
            ' 
            Me.colGroupName.FieldName = "GroupName"
            Me.colGroupName.Name = "colGroupName"
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.MaxWidth = 60
            Me.colPhoto.MinWidth = 60
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 6
            Me.colPhoto.Width = 60
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.listBoxControl)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(392, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(221, 441)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' TreeListDragDrop
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TreeListDragDrop"
            Me.Size = New System.Drawing.Size(613, 441)
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private listBoxControl As DevExpress.XtraEditors.ListBoxControl

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private colFullName As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colBirthDate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colHireDate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPhone As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCity As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colEmailAddress As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colJobTitle As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colGroupName As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPhoto As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private dragDropEvents1 As DevExpress.Utils.DragDrop.DragDropEvents

        Private dragDropEvents2 As DevExpress.Utils.DragDrop.DragDropEvents
    End Class
End Namespace

Namespace DevExpress.XtraGrid.Demos

    Partial Class LookUpServerMode

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.LookUpServerMode))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colPercentComplete = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.session1 = New DevExpress.Xpo.Session(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAssignTo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colIssue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.xpServerCollectionSource1 = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
            Me.repositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.xtraConsole1 = New DevExpress.XtraGrid.Demos.XtraConsole()
            Me.sbClear = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceTracing = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceTracing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colPercentComplete
            ' 
            resources.ApplyResources(Me.colPercentComplete, "colPercentComplete")
            Me.colPercentComplete.ColumnEdit = Me.repositoryItemProgressBar1
            Me.colPercentComplete.FieldName = "PercentComplete"
            Me.colPercentComplete.Name = "colPercentComplete"
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpCollection1
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemGridLookUpEdit1, Me.repositoryItemProgressBar1, Me.repositoryItemSpinEdit1, Me.repositoryItemComboBox1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.DeleteObjectOnRemove = True
            Me.xpCollection1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideLookUpTest)
            Me.xpCollection1.Session = Me.session1
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colAssignTo, Me.colIssue, Me.colDueDate, Me.colPercentComplete})
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Gray
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colPercentComplete
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 100
            styleFormatCondition2.Appearance.Font = CType((resources.GetObject("resource.Font1")), System.Drawing.Font)
            styleFormatCondition2.Appearance.Options.UseFont = True
            styleFormatCondition2.ApplyToRow = True
            styleFormatCondition2.Column = Me.colPercentComplete
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
            styleFormatCondition2.Value1 = 0
            styleFormatCondition2.Value2 = 100
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1, styleFormatCondition2})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            AddHandler Me.gridView1.CustomRowCellEditForEditing, New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(AddressOf Me.gridView1_CustomRowCellEditForEditing)
            ' 
            ' colOid
            ' 
            resources.ApplyResources(Me.colOid, "colOid")
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.[ReadOnly] = True
            ' 
            ' colAssignTo
            ' 
            resources.ApplyResources(Me.colAssignTo, "colAssignTo")
            Me.colAssignTo.ColumnEdit = Me.repositoryItemComboBox1
            Me.colAssignTo.FieldName = "AssignTo"
            Me.colAssignTo.Name = "colAssignTo"
            ' 
            ' repositoryItemComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colIssue
            ' 
            Me.colIssue.AppearanceHeader.Font = CType((resources.GetObject("colIssue.AppearanceHeader.Font")), System.Drawing.Font)
            Me.colIssue.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colIssue, "colIssue")
            Me.colIssue.ColumnEdit = Me.repositoryItemGridLookUpEdit1
            Me.colIssue.FieldName = "Issue!"
            Me.colIssue.Name = "colIssue"
            ' 
            ' repositoryItemGridLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemGridLookUpEdit1, "repositoryItemGridLookUpEdit1")
            Me.repositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemGridLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemGridLookUpEdit1.DataSource = Me.xpServerCollectionSource1
            Me.repositoryItemGridLookUpEdit1.DisplayMember = "Subject"
            Me.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1"
            Me.repositoryItemGridLookUpEdit1.PopupFormSize = New System.Drawing.Size(550, 0)
            Me.repositoryItemGridLookUpEdit1.PopupView = Me.repositoryItemGridLookUpEdit1View
            ' 
            ' xpServerCollectionSource1
            ' 
            Me.xpServerCollectionSource1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideGridTest)
            Me.xpServerCollectionSource1.Session = Me.session1
            ' 
            ' repositoryItemGridLookUpEdit1View
            ' 
            Me.repositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment})
            Me.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View"
            Me.repositoryItemGridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowFooter = True
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' colSubject
            ' 
            resources.ApplyResources(Me.colSubject, "colSubject")
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colSubject.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colFrom
            ' 
            resources.ApplyResources(Me.colFrom, "colFrom")
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            ' 
            ' colSent
            ' 
            resources.ApplyResources(Me.colSent, "colSent")
            Me.colSent.FieldName = "Sent"
            Me.colSent.Name = "colSent"
            ' 
            ' colSize
            ' 
            resources.ApplyResources(Me.colSize, "colSize")
            Me.colSize.DisplayFormat.FormatString = "{0:n0} KB"
            Me.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSize.FieldName = "Size"
            Me.colSize.Name = "colSize"
            ' 
            ' colHasAttachment
            ' 
            resources.ApplyResources(Me.colHasAttachment, "colHasAttachment")
            Me.colHasAttachment.FieldName = "HasAttachment"
            Me.colHasAttachment.ImageOptions.SvgImage = CType((resources.GetObject("colHasAttachment.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colHasAttachment.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colHasAttachment.Name = "colHasAttachment"
            ' 
            ' colDueDate
            ' 
            resources.ApplyResources(Me.colDueDate, "colDueDate")
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.Name = "colDueDate"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' xtraConsole1
            ' 
            Me.xtraConsole1.Appearance.ForeColor = System.Drawing.Color.Black
            Me.xtraConsole1.Appearance.Options.UseForeColor = True
            resources.ApplyResources(Me.xtraConsole1, "xtraConsole1")
            Me.xtraConsole1.Name = "xtraConsole1"
            ' 
            ' sbClear
            ' 
            resources.ApplyResources(Me.sbClear, "sbClear")
            Me.sbClear.Name = "sbClear"
            Me.sbClear.StyleController = Me.layoutControl1
            AddHandler Me.sbClear.Click, New System.EventHandler(AddressOf Me.sbClear_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbClear)
            Me.layoutControl1.Controls.Add(Me.ceTracing)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.groupControl1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ceTracing
            ' 
            resources.ApplyResources(Me.ceTracing, "ceTracing")
            Me.ceTracing.Name = "ceTracing"
            Me.ceTracing.Properties.Caption = resources.GetString("ceTracing.Properties.Caption")
            Me.ceTracing.StyleController = Me.layoutControl1
            AddHandler Me.ceTracing.CheckedChanged, New System.EventHandler(AddressOf Me.ceTracing_CheckedChanged)
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.xtraConsole1)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.splitterItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(927, 569)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(927, 356)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(0, 356)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(927, 10)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.groupControl1
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 399)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(927, 170)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceTracing
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 366)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(107, 33)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.sbClear
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(107, 366)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(119, 33)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(226, 366)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(701, 33)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' LookUpServerMode
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "LookUpServerMode"
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceTracing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private xpServerCollectionSource1 As DevExpress.Xpo.XPServerCollectionSource

        Private xtraConsole1 As DevExpress.XtraGrid.Demos.XtraConsole

        Private ceTracing As DevExpress.XtraEditors.CheckEdit

        Private sbClear As DevExpress.XtraEditors.SimpleButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private xpCollection1 As DevExpress.Xpo.XPCollection

        Private colOid As DevExpress.XtraGrid.Columns.GridColumn

        Private colAssignTo As DevExpress.XtraGrid.Columns.GridColumn

        Private colIssue As DevExpress.XtraGrid.Columns.GridColumn

        Private colDueDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colPercentComplete As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit

        Private repositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private colFrom As DevExpress.XtraGrid.Columns.GridColumn

        Private colSent As DevExpress.XtraGrid.Columns.GridColumn

        Private colSize As DevExpress.XtraGrid.Columns.GridColumn

        Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private session1 As DevExpress.Xpo.Session
    End Class
End Namespace

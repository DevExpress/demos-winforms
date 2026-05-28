Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class GridServerMode
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GridServerMode))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpInstantFeedbackSource1 = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
			Me.xtraConsole1 = New DevExpress.Xpo.Demos.XtraConsole()
			Me.sbClear = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.sbShowSQLConnection = New DevExpress.XtraEditors.SimpleButton()
			Me.ceTracing = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.ceTracing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpInstantFeedbackSource1
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1, Me.repositoryItemImageComboBox1})
			Me.gridControl1.Size = New System.Drawing.Size(927, 383)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' xpInstantFeedbackSource1
			' 
			Me.xpInstantFeedbackSource1.DisplayableProperties = "This;Oid;Subject;From;Sent;Size;HasAttachment;Priority"
			Me.xpInstantFeedbackSource1.ObjectType = GetType(DevExpress.Xpo.Demos.ServerSideGridTest)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment, Me.colPriority})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count = {0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Size", Nothing, "(Total size = {0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Size", Me.colSize, "SUM={0}")})
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsMenu.ShowGroupSortSummaryItems = False
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			Me.gridView1.OptionsView.ShowFooter = True
			' 
			' colOid
			' 
			Me.colOid.Caption = "#"
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
			Me.colOid.Visible = True
			Me.colOid.VisibleIndex = 0
			Me.colOid.Width = 71
			' 
			' colSubject
			' 
			Me.colSubject.Caption = "Subject"
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.Visible = True
			Me.colSubject.VisibleIndex = 1
			Me.colSubject.Width = 349
			' 
			' colFrom
			' 
			Me.colFrom.Caption = "From"
			Me.colFrom.FieldName = "From"
			Me.colFrom.Name = "colFrom"
			Me.colFrom.Visible = True
			Me.colFrom.VisibleIndex = 2
			Me.colFrom.Width = 105
			' 
			' colSent
			' 
			Me.colSent.Caption = "Sent"
			Me.colSent.FieldName = "Sent"
			Me.colSent.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
			Me.colSent.Name = "colSent"
			Me.colSent.Visible = True
			Me.colSent.VisibleIndex = 3
			Me.colSent.Width = 86
			' 
			' colSize
			' 
			Me.colSize.Caption = "Size"
			Me.colSize.FieldName = "Size"
			Me.colSize.Name = "colSize"
			Me.colSize.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Size", "SUM={0}")})
			Me.colSize.Visible = True
			Me.colSize.VisibleIndex = 4
			Me.colSize.Width = 134
			' 
			' colHasAttachment
			' 
			Me.colHasAttachment.Caption = "Attachment"
			Me.colHasAttachment.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.colHasAttachment.FieldName = "HasAttachment"
			Me.colHasAttachment.Name = "colHasAttachment"
			Me.colHasAttachment.Visible = True
			Me.colHasAttachment.VisibleIndex = 5
			Me.colHasAttachment.Width = 87
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
			Me.repositoryItemCheckEdit1.ImageIndexChecked = 4
			Me.repositoryItemCheckEdit1.Images = Me.imageList1
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			Me.repositoryItemCheckEdit1.ReadOnly = True
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' colPriority
			' 
			Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colPriority.FieldName = "Priority"
			Me.colPriority.Name = "colPriority"
			Me.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colPriority.Visible = True
			Me.colPriority.VisibleIndex = 6
			Me.colPriority.Width = 85
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 1)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
			' 
			' xtraConsole1
			' 
			Me.xtraConsole1.Appearance.ForeColor = System.Drawing.Color.Black
			Me.xtraConsole1.Appearance.Options.UseForeColor = True
			Me.xtraConsole1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraConsole1.Location = New System.Drawing.Point(2, 22)
			Me.xtraConsole1.Name = "xtraConsole1"
			Me.xtraConsole1.Size = New System.Drawing.Size(804, 157)
			Me.xtraConsole1.TabIndex = 0
			' 
			' sbClear
			' 
			Me.sbClear.Location = New System.Drawing.Point(5, 541)
			Me.sbClear.Name = "sbClear"
			Me.sbClear.Size = New System.Drawing.Size(109, 23)
			Me.sbClear.StyleController = Me.layoutControl1
			Me.sbClear.TabIndex = 1
			Me.sbClear.Text = "Clear Log"
'			Me.sbClear.Click += New System.EventHandler(Me.sbClear_Click);
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.sbShowSQLConnection)
			Me.layoutControl1.Controls.Add(Me.sbClear)
			Me.layoutControl1.Controls.Add(Me.ceTracing)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			Me.layoutControl1.Controls.Add(Me.groupControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5})
			Me.layoutControl1.Location = New System.Drawing.Point(4, 4)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(927, 569)
			Me.layoutControl1.TabIndex = 2
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' sbShowSQLConnection
			' 
			Me.sbShowSQLConnection.Location = New System.Drawing.Point(6, 442)
			Me.sbShowSQLConnection.Name = "sbShowSQLConnection"
			Me.sbShowSQLConnection.Size = New System.Drawing.Size(108, 22)
			Me.sbShowSQLConnection.StyleController = Me.layoutControl1
			Me.sbShowSQLConnection.TabIndex = 5
			Me.sbShowSQLConnection.Text = "Configuration..."
'			Me.sbShowSQLConnection.Click += New System.EventHandler(Me.sbShowSQLConnection_Click);
			' 
			' ceTracing
			' 
			Me.ceTracing.EditValue = True
			Me.ceTracing.Location = New System.Drawing.Point(5, 393)
			Me.ceTracing.Name = "ceTracing"
			Me.ceTracing.Properties.Caption = "Enable Tracing"
			Me.ceTracing.Size = New System.Drawing.Size(109, 19)
			Me.ceTracing.StyleController = Me.layoutControl1
			Me.ceTracing.TabIndex = 0
'			Me.ceTracing.CheckedChanged += New System.EventHandler(Me.ceTracing_CheckedChanged);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.xtraConsole1)
			Me.groupControl1.Location = New System.Drawing.Point(119, 388)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(808, 181)
			Me.groupControl1.TabIndex = 4
			Me.groupControl1.Text = "Tracing:"
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.sbShowSQLConnection
			Me.layoutControlItem5.CustomizationFormText = "Configuration"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 436)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem5.Size = New System.Drawing.Size(119, 33)
			Me.layoutControlItem5.Text = "Configuration"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.splitterItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(927, 569)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gridControl1
			Me.layoutControlItem1.CustomizationFormText = "Grid"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Size = New System.Drawing.Size(927, 383)
			Me.layoutControlItem1.Text = "Grid"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(0, 383)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(927, 5)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.ceTracing
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 388)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem3.Size = New System.Drawing.Size(119, 29)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.groupControl1
			Me.layoutControlItem2.CustomizationFormText = "Tracing:"
			Me.layoutControlItem2.Location = New System.Drawing.Point(119, 388)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem2.Size = New System.Drawing.Size(808, 181)
			Me.layoutControlItem2.Text = "Tracing:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 417)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem1.Size = New System.Drawing.Size(119, 119)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.sbClear
			Me.layoutControlItem4.CustomizationFormText = "Clear Log"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 536)
			Me.layoutControlItem4.MaxSize = New System.Drawing.Size(119, 33)
			Me.layoutControlItem4.MinSize = New System.Drawing.Size(119, 33)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem4.Size = New System.Drawing.Size(119, 33)
			Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem4.Text = "Clear Log"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' GridServerMode
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "GridServerMode"
			Me.Padding = New System.Windows.Forms.Padding(4)
			Me.Size = New System.Drawing.Size(935, 577)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.ceTracing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colFrom As DevExpress.XtraGrid.Columns.GridColumn
		Private colSent As DevExpress.XtraGrid.Columns.GridColumn
		Private colSize As DevExpress.XtraGrid.Columns.GridColumn
		Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn
		Private xtraConsole1 As XtraConsole
		Private WithEvents ceTracing As DevExpress.XtraEditors.CheckEdit
		Private WithEvents sbClear As DevExpress.XtraEditors.SimpleButton
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents sbShowSQLConnection As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private colPriority As DevExpress.XtraGrid.Columns.GridColumn
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private xpInstantFeedbackSource1 As XPInstantFeedbackSource
	End Class
End Namespace


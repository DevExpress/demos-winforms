Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmFindCustomer
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
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
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.pcButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbClear = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSpace = New DevExpress.XtraEditors.PanelControl()
			Me.sbClose = New DevExpress.XtraEditors.SimpleButton()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xcCustomers = New DevExpress.Xpo.XPCollection()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMiddleName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.ucCustomerInfo1 = New DevExpress.VideoRent.Win.Controls.ucCustomerInfo()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciGrid = New DevExpress.XtraLayout.LayoutControlItem()
			Me.siMain = New DevExpress.XtraLayout.SplitterItem()
			Me.lciCustomerInfo = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcButtons.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSpace, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.siMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCustomerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(12, 430)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(8)
			Me.panelControl1.Size = New System.Drawing.Size(799, 12)
			Me.panelControl1.TabIndex = 10
			' 
			' pcButtons
			' 
			Me.pcButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcButtons.Controls.Add(Me.sbClear)
			Me.pcButtons.Controls.Add(Me.panelControl2)
			Me.pcButtons.Controls.Add(Me.sbOK)
			Me.pcButtons.Controls.Add(Me.pcSpace)
			Me.pcButtons.Controls.Add(Me.sbClose)
			Me.pcButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pcButtons.Location = New System.Drawing.Point(12, 442)
			Me.pcButtons.Name = "pcButtons"
			Me.pcButtons.Size = New System.Drawing.Size(799, 22)
			Me.pcButtons.TabIndex = 1
			' 
			' sbClear
			' 
			Me.sbClear.DialogResult = System.Windows.Forms.DialogResult.Ignore
			Me.sbClear.Dock = System.Windows.Forms.DockStyle.Left
			Me.sbClear.Location = New System.Drawing.Point(0, 0)
			Me.sbClear.Name = "sbClear"
			Me.sbClear.Size = New System.Drawing.Size(155, 22)
			Me.sbClear.TabIndex = 0
			Me.sbClear.Text = "C&lear current customer"
'			Me.sbClear.Click += New System.EventHandler(Me.sbClear_Click);
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl2.Location = New System.Drawing.Point(617, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(8, 22)
			Me.panelControl2.TabIndex = 4
			' 
			' sbOK
			' 
			Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.sbOK.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbOK.Location = New System.Drawing.Point(625, 0)
			Me.sbOK.Name = "sbOK"
			Me.sbOK.Size = New System.Drawing.Size(83, 22)
			Me.sbOK.TabIndex = 1
			Me.sbOK.Text = "&OK"
'			Me.sbOK.Click += New System.EventHandler(Me.sbOK_Click);
			' 
			' pcSpace
			' 
			Me.pcSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSpace.Dock = System.Windows.Forms.DockStyle.Right
			Me.pcSpace.Location = New System.Drawing.Point(708, 0)
			Me.pcSpace.Name = "pcSpace"
			Me.pcSpace.Size = New System.Drawing.Size(8, 22)
			Me.pcSpace.TabIndex = 2
			' 
			' sbClose
			' 
			Me.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbClose.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbClose.Location = New System.Drawing.Point(716, 0)
			Me.sbClose.Name = "sbClose"
			Me.sbClose.Size = New System.Drawing.Size(83, 22)
			Me.sbClose.TabIndex = 2
			Me.sbClose.Text = "&Close"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xcCustomers
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(578, 418)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'			Me.gridControl1.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseDoubleClick);
			' 
			' xcCustomers
			' 
			Me.xcCustomers.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone
			Me.xcCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
			Me.xcCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[CustomerId]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colFirstName, Me.colLastName, Me.colGender, Me.colBirthDate, Me.colFullName, Me.colCustomerId, Me.colMiddleName, Me.colEmail, Me.colAddress, Me.colPhone, Me.colComments})
			Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(563, 394, 216, 199)
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsView.ShowAutoFilterRow = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
'			Me.gridView1.ColumnFilterChanged += New System.EventHandler(Me.gridView1_ColumnFilterChanged);
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.OptionsColumn.AllowFocus = False
			Me.colFirstName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.OptionsColumn.AllowFocus = False
			Me.colLastName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			' 
			' colGender
			' 
			Me.colGender.FieldName = "Gender"
			Me.colGender.Name = "colGender"
			Me.colGender.OptionsColumn.AllowFocus = False
			Me.colGender.OptionsColumn.AllowMove = False
			Me.colGender.OptionsColumn.FixedWidth = True
			Me.colGender.OptionsColumn.ShowCaption = False
			Me.colGender.OptionsFilter.AllowAutoFilter = False
			Me.colGender.Visible = True
			Me.colGender.VisibleIndex = 0
			Me.colGender.Width = 30
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			Me.colBirthDate.OptionsColumn.AllowFocus = False
			Me.colBirthDate.Width = 99
			' 
			' colFullName
			' 
			Me.colFullName.Caption = "Name"
			Me.colFullName.FieldName = "FullName"
			Me.colFullName.Name = "colFullName"
			Me.colFullName.OptionsColumn.AllowFocus = False
			Me.colFullName.OptionsColumn.ReadOnly = True
			Me.colFullName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colFullName.Visible = True
			Me.colFullName.VisibleIndex = 2
			Me.colFullName.Width = 180
			' 
			' colCustomerId
			' 
			Me.colCustomerId.AppearanceCell.Options.UseTextOptions = True
			Me.colCustomerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colCustomerId.Caption = "Card Number"
			Me.colCustomerId.FieldName = "CustomerId"
			Me.colCustomerId.Name = "colCustomerId"
			Me.colCustomerId.OptionsColumn.AllowFocus = False
			Me.colCustomerId.Visible = True
			Me.colCustomerId.VisibleIndex = 1
			Me.colCustomerId.Width = 92
			' 
			' colMiddleName
			' 
			Me.colMiddleName.FieldName = "MiddleName"
			Me.colMiddleName.Name = "colMiddleName"
			Me.colMiddleName.OptionsColumn.AllowFocus = False
			Me.colMiddleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			' 
			' colEmail
			' 
			Me.colEmail.FieldName = "Email"
			Me.colEmail.Name = "colEmail"
			Me.colEmail.OptionsColumn.AllowFocus = False
			Me.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.OptionsColumn.AllowFocus = False
			Me.colAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 4
			Me.colAddress.Width = 173
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.OptionsColumn.AllowFocus = False
			Me.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 3
			Me.colPhone.Width = 100
			' 
			' colComments
			' 
			Me.colComments.FieldName = "Comments"
			Me.colComments.Name = "colComments"
			Me.colComments.OptionsColumn.AllowFocus = False
			Me.colComments.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.ucCustomerInfo1)
			Me.lcMain.Controls.Add(Me.gridControl1)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(12, 12)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(799, 418)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' ucCustomerInfo1
			' 
			Me.ucCustomerInfo1.Location = New System.Drawing.Point(584, 0)
			Me.ucCustomerInfo1.Margin = New System.Windows.Forms.Padding(0)
			Me.ucCustomerInfo1.Name = "ucCustomerInfo1"
			Me.ucCustomerInfo1.Size = New System.Drawing.Size(215, 418)
			Me.ucCustomerInfo1.TabIndex = 4
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "Root"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciGrid, Me.siMain, Me.lciCustomerInfo})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(799, 418)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' lciGrid
			' 
			Me.lciGrid.Control = Me.gridControl1
			Me.lciGrid.CustomizationFormText = "lciGrid"
			Me.lciGrid.Location = New System.Drawing.Point(0, 0)
			Me.lciGrid.Name = "lciGrid"
			Me.lciGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciGrid.Size = New System.Drawing.Size(578, 418)
			Me.lciGrid.Text = "lciGrid"
			Me.lciGrid.TextSize = New System.Drawing.Size(0, 0)
			Me.lciGrid.TextToControlDistance = 0
			Me.lciGrid.TextVisible = False
			' 
			' siMain
			' 
			Me.siMain.AllowHotTrack = True
			Me.siMain.CustomizationFormText = "siMain"
			Me.siMain.Location = New System.Drawing.Point(578, 0)
			Me.siMain.Name = "siMain"
			Me.siMain.Size = New System.Drawing.Size(6, 418)
			' 
			' lciCustomerInfo
			' 
			Me.lciCustomerInfo.Control = Me.ucCustomerInfo1
			Me.lciCustomerInfo.CustomizationFormText = "lciCustomerInfo"
			Me.lciCustomerInfo.Location = New System.Drawing.Point(584, 0)
			Me.lciCustomerInfo.Name = "lciCustomerInfo"
			Me.lciCustomerInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciCustomerInfo.Size = New System.Drawing.Size(215, 418)
			Me.lciCustomerInfo.Text = "lciCustomerInfo"
			Me.lciCustomerInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCustomerInfo.TextToControlDistance = 0
			Me.lciCustomerInfo.TextVisible = False
			' 
			' frmFindCustomer
			' 
			Me.AcceptButton = Me.sbOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbClose
			Me.ClientSize = New System.Drawing.Size(823, 476)
			Me.Controls.Add(Me.lcMain)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.pcButtons)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmFindCustomer"
			Me.Padding = New System.Windows.Forms.Padding(12)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Find Customer"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcButtons.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSpace, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.siMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCustomerInfo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private pcButtons As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbClear As DevExpress.XtraEditors.SimpleButton
		Private pcSpace As DevExpress.XtraEditors.PanelControl
		Private sbClose As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbOK As DevExpress.XtraEditors.SimpleButton
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private xcCustomers As DevExpress.Xpo.XPCollection
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colGender As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colFullName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerId As DevExpress.XtraGrid.Columns.GridColumn
		Private colMiddleName As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmail As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colComments As DevExpress.XtraGrid.Columns.GridColumn
		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciGrid As DevExpress.XtraLayout.LayoutControlItem
		Private siMain As DevExpress.XtraLayout.SplitterItem
		Private ucCustomerInfo1 As DevExpress.VideoRent.Win.Controls.ucCustomerInfo
		Private lciCustomerInfo As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

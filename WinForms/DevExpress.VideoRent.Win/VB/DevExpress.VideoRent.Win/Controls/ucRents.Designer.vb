Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucRents
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
			Me.ucGridSwitcherBar = New DevExpress.VideoRent.Win.Controls.ucBarOneCheckedButton()
			Me.gcRents = New DevExpress.XtraGrid.GridControl()
			Me.gvRents = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colRentId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDays = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRentedOn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReturnedOn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutControlGroupMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcgRents = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciGridRentsBar = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRents = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl.SuspendLayout()
			CType(Me.gcRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroupMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGridRentsBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl
			' 
			Me.layoutControl.Controls.Add(Me.ucGridSwitcherBar)
			Me.layoutControl.Controls.Add(Me.gcRents)
			Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl.Name = "layoutControl"
			Me.layoutControl.Root = Me.layoutControlGroupMain
			Me.layoutControl.Size = New System.Drawing.Size(708, 306)
			Me.layoutControl.TabIndex = 0
			Me.layoutControl.Text = "layoutControl1"
			' 
			' ucGridSwitcherBar
			' 
			Me.ucGridSwitcherBar.ButtonCaption = "Only Active"
			Me.ucGridSwitcherBar.Checked = False
			Me.ucGridSwitcherBar.Location = New System.Drawing.Point(24, 44)
			Me.ucGridSwitcherBar.Name = "ucGridSwitcherBar"
			Me.ucGridSwitcherBar.Size = New System.Drawing.Size(660, 20)
			Me.ucGridSwitcherBar.TabIndex = 38
			' 
			' gcRents
			' 
			Me.gcRents.Location = New System.Drawing.Point(24, 68)
			Me.gcRents.MainView = Me.gvRents
			Me.gcRents.Name = "gcRents"
			Me.gcRents.Size = New System.Drawing.Size(660, 214)
			Me.gcRents.TabIndex = 26
			Me.gcRents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvRents})
			' 
			' gvRents
			' 
			Me.gvRents.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colRentId, Me.colCustomer, Me.colDays, Me.colRentedOn, Me.colReturnedOn, Me.colActive})
			Me.gvRents.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.gvRents.GridControl = Me.gcRents
			Me.gvRents.Name = "gvRents"
			Me.gvRents.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gvRents.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gvRents.OptionsBehavior.Editable = False
			Me.gvRents.OptionsBehavior.ReadOnly = True
			Me.gvRents.OptionsView.ShowDetailButtons = False
			Me.gvRents.OptionsView.ShowGroupPanel = False
			' 
			' colRentId
			' 
			Me.colRentId.FieldName = "RentId"
			Me.colRentId.Name = "colRentId"
			Me.colRentId.Visible = True
			Me.colRentId.VisibleIndex = 0
			' 
			' colCustomer
			' 
			Me.colCustomer.Caption = "Customer"
			Me.colCustomer.FieldName = "Customer!"
			Me.colCustomer.Name = "colCustomer"
			Me.colCustomer.Visible = True
			Me.colCustomer.VisibleIndex = 1
			' 
			' colDays
			' 
			Me.colDays.FieldName = "Days"
			Me.colDays.Name = "colDays"
			Me.colDays.Visible = True
			Me.colDays.VisibleIndex = 2
			' 
			' colRentedOn
			' 
			Me.colRentedOn.FieldName = "RentedOn"
			Me.colRentedOn.Name = "colRentedOn"
			Me.colRentedOn.Visible = True
			Me.colRentedOn.VisibleIndex = 3
			' 
			' colReturnedOn
			' 
			Me.colReturnedOn.FieldName = "ReturnedOn"
			Me.colReturnedOn.Name = "colReturnedOn"
			Me.colReturnedOn.Visible = True
			Me.colReturnedOn.VisibleIndex = 4
			' 
			' colActive
			' 
			Me.colActive.Caption = "Active"
			Me.colActive.FieldName = "Active"
			Me.colActive.Name = "colActive"
			Me.colActive.Visible = True
			Me.colActive.VisibleIndex = 5
			' 
			' layoutControlGroupMain
			' 
			Me.layoutControlGroupMain.CustomizationFormText = "layoutControlGroupMain"
			Me.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupMain.GroupBordersVisible = False
			Me.layoutControlGroupMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgRents})
			Me.layoutControlGroupMain.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupMain.Name = "layoutControlGroupMain"
			Me.layoutControlGroupMain.Size = New System.Drawing.Size(708, 306)
			Me.layoutControlGroupMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroupMain.Text = "layoutControlGroupMain"
			Me.layoutControlGroupMain.TextVisible = False
			' 
			' lcgRents
			' 
			Me.lcgRents.CustomizationFormText = "Rents"
			Me.lcgRents.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciGridRentsBar, Me.lciRents})
			Me.lcgRents.Location = New System.Drawing.Point(0, 0)
			Me.lcgRents.Name = "lcgRents"
			Me.lcgRents.Size = New System.Drawing.Size(688, 286)
			Me.lcgRents.Text = "Rents"
			' 
			' lciGridRentsBar
			' 
			Me.lciGridRentsBar.Control = Me.ucGridSwitcherBar
			Me.lciGridRentsBar.CustomizationFormText = "lciGridBar"
			Me.lciGridRentsBar.Location = New System.Drawing.Point(0, 0)
			Me.lciGridRentsBar.Name = "lciGridRentsBar"
			Me.lciGridRentsBar.Size = New System.Drawing.Size(664, 24)
			Me.lciGridRentsBar.Text = "Rents"
			Me.lciGridRentsBar.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
			Me.lciGridRentsBar.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciGridRentsBar.TextSize = New System.Drawing.Size(0, 0)
			Me.lciGridRentsBar.TextToControlDistance = 0
			Me.lciGridRentsBar.TextVisible = False
			' 
			' lciRents
			' 
			Me.lciRents.Control = Me.gcRents
			Me.lciRents.CustomizationFormText = "Current Rents"
			Me.lciRents.Location = New System.Drawing.Point(0, 24)
			Me.lciRents.Name = "lciRents"
			Me.lciRents.Size = New System.Drawing.Size(664, 218)
			Me.lciRents.Text = "Rents"
			Me.lciRents.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciRents.TextSize = New System.Drawing.Size(0, 0)
			Me.lciRents.TextToControlDistance = 0
			Me.lciRents.TextVisible = False
			' 
			' ucRents
			' 
			Me.Controls.Add(Me.layoutControl)
			Me.Name = "ucRents"
			Me.Size = New System.Drawing.Size(708, 306)
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl.ResumeLayout(False)
			CType(Me.gcRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroupMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGridRentsBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroupMain As DevExpress.XtraLayout.LayoutControlGroup
		Private gcRents As DevExpress.XtraGrid.GridControl
		Private gvRents As DevExpress.XtraGrid.Views.Grid.GridView
		Private lciRents As DevExpress.XtraLayout.LayoutControlItem
		Private colCustomer As DevExpress.XtraGrid.Columns.GridColumn
		Private colDays As DevExpress.XtraGrid.Columns.GridColumn
		Private colRentedOn As DevExpress.XtraGrid.Columns.GridColumn
		Private colReturnedOn As DevExpress.XtraGrid.Columns.GridColumn
		Private colRentId As DevExpress.XtraGrid.Columns.GridColumn
		Private ucGridSwitcherBar As DevExpress.VideoRent.Win.Controls.ucBarOneCheckedButton
		Private lciGridRentsBar As DevExpress.XtraLayout.LayoutControlItem
		Private lcgRents As DevExpress.XtraLayout.LayoutControlGroup
		Private colActive As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

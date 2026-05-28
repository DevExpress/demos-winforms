Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucRentalSalesInfo
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
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.lbItemsCount = New DevExpress.XtraEditors.LabelControl()
			Me.teDefaultDays = New DevExpress.XtraEditors.TextEdit()
			Me.teDefaultPrice = New DevExpress.XtraEditors.TextEdit()
			Me.lbItemsInfo = New DevExpress.XtraEditors.LabelControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciDefaultDays = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciDefaultPrice = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciItemsInfo = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciItemsCount = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.teDefaultDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teDefaultPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDefaultDays, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDefaultPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciItemsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciItemsCount, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.lbItemsCount)
			Me.lcMain.Controls.Add(Me.teDefaultDays)
			Me.lcMain.Controls.Add(Me.teDefaultPrice)
			Me.lcMain.Controls.Add(Me.lbItemsInfo)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Padding = New System.Windows.Forms.Padding(3)
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(510, 160)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' lbItemsCount
			' 
			Me.lbItemsCount.AllowHtmlString = True
			Me.lbItemsCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbItemsCount.Location = New System.Drawing.Point(12, 2)
			Me.lbItemsCount.Name = "lbItemsCount"
			Me.lbItemsCount.Size = New System.Drawing.Size(486, 14)
			Me.lbItemsCount.StyleController = Me.lcMain
			Me.lbItemsCount.TabIndex = 8
			Me.lbItemsCount.Text = "Items count: <b>00</b>."
			' 
			' teDefaultDays
			' 
			Me.teDefaultDays.Location = New System.Drawing.Point(116, 38)
			Me.teDefaultDays.Name = "teDefaultDays"
			Me.teDefaultDays.Properties.AppearanceReadOnly.Options.UseTextOptions = True
			Me.teDefaultDays.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.teDefaultDays.Properties.Mask.EditMask = "n0"
			Me.teDefaultDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.teDefaultDays.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.teDefaultDays.Properties.ReadOnly = True
			Me.teDefaultDays.Size = New System.Drawing.Size(382, 20)
			Me.teDefaultDays.StyleController = Me.lcMain
			Me.teDefaultDays.TabIndex = 6
			' 
			' teDefaultPrice
			' 
			Me.teDefaultPrice.Location = New System.Drawing.Point(116, 62)
			Me.teDefaultPrice.Name = "teDefaultPrice"
			Me.teDefaultPrice.Properties.Appearance.Options.UseTextOptions = True
			Me.teDefaultPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.teDefaultPrice.Properties.Mask.EditMask = "c"
			Me.teDefaultPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.teDefaultPrice.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.teDefaultPrice.Properties.ReadOnly = True
			Me.teDefaultPrice.Size = New System.Drawing.Size(382, 20)
			Me.teDefaultPrice.StyleController = Me.lcMain
			Me.teDefaultPrice.TabIndex = 4
			' 
			' lbItemsInfo
			' 
			Me.lbItemsInfo.AllowHtmlString = True
			Me.lbItemsInfo.Location = New System.Drawing.Point(12, 20)
			Me.lbItemsInfo.Name = "lbItemsInfo"
			Me.lbItemsInfo.Size = New System.Drawing.Size(368, 14)
			Me.lbItemsInfo.StyleController = Me.lcMain
			Me.lbItemsInfo.TabIndex = 7
			Me.lbItemsInfo.Text = "Of them <b>00</b> in rent, <b>00</b> active, <b>00</b> for sell, <b>00</b> lost, " & "<b>00</b> damage, <b>00</b> sold out."
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "layoutControlGroupMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciDefaultDays, Me.lciDefaultPrice, Me.lciItemsInfo, Me.lciItemsCount})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(510, 160)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' lciDefaultDays
			' 
			Me.lciDefaultDays.Control = Me.teDefaultDays
			Me.lciDefaultDays.CustomizationFormText = "Default Rental Days"
			Me.lciDefaultDays.Location = New System.Drawing.Point(0, 36)
			Me.lciDefaultDays.Name = "lciDefaultDays"
			Me.lciDefaultDays.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2)
			Me.lciDefaultDays.Size = New System.Drawing.Size(510, 24)
			Me.lciDefaultDays.Text = "Default Rental Days:"
			Me.lciDefaultDays.TextSize = New System.Drawing.Size(100, 13)
			' 
			' lciDefaultPrice
			' 
			Me.lciDefaultPrice.Control = Me.teDefaultPrice
			Me.lciDefaultPrice.CustomizationFormText = "Default Late Fee"
			Me.lciDefaultPrice.Location = New System.Drawing.Point(0, 60)
			Me.lciDefaultPrice.Name = "lciDefaultPrice"
			Me.lciDefaultPrice.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2)
			Me.lciDefaultPrice.Size = New System.Drawing.Size(510, 100)
			Me.lciDefaultPrice.Text = "Default Late Fee:"
			Me.lciDefaultPrice.TextSize = New System.Drawing.Size(100, 13)
			' 
			' lciItemsInfo
			' 
			Me.lciItemsInfo.Control = Me.lbItemsInfo
			Me.lciItemsInfo.CustomizationFormText = "lciItemsInfo"
			Me.lciItemsInfo.Location = New System.Drawing.Point(0, 18)
			Me.lciItemsInfo.Name = "lciItemsInfo"
			Me.lciItemsInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2)
			Me.lciItemsInfo.Size = New System.Drawing.Size(510, 18)
			Me.lciItemsInfo.Text = "lciItemsInfo"
			Me.lciItemsInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciItemsInfo.TextToControlDistance = 0
			Me.lciItemsInfo.TextVisible = False
			' 
			' lciItemsCount
			' 
			Me.lciItemsCount.Control = Me.lbItemsCount
			Me.lciItemsCount.CustomizationFormText = "lciItemsCount"
			Me.lciItemsCount.Location = New System.Drawing.Point(0, 0)
			Me.lciItemsCount.Name = "lciItemsCount"
			Me.lciItemsCount.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 2, 2)
			Me.lciItemsCount.Size = New System.Drawing.Size(510, 18)
			Me.lciItemsCount.Text = "lciItemsCount"
			Me.lciItemsCount.TextSize = New System.Drawing.Size(0, 0)
			Me.lciItemsCount.TextToControlDistance = 0
			Me.lciItemsCount.TextVisible = False
			' 
			' ucRentalSalesInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucRentalSalesInfo"
			Me.Size = New System.Drawing.Size(510, 160)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.teDefaultDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teDefaultPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDefaultDays, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDefaultPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciItemsInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciItemsCount, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private teDefaultDays As DevExpress.XtraEditors.TextEdit
		Private teDefaultPrice As DevExpress.XtraEditors.TextEdit
		Private lciDefaultPrice As DevExpress.XtraLayout.LayoutControlItem
		Private lciDefaultDays As DevExpress.XtraLayout.LayoutControlItem
		Private lbItemsInfo As DevExpress.XtraEditors.LabelControl
		Private lciItemsInfo As DevExpress.XtraLayout.LayoutControlItem
		Private lbItemsCount As DevExpress.XtraEditors.LabelControl
		Private lciItemsCount As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

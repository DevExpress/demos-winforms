Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieAddItems
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
			Me.components = New System.ComponentModel.Container()
			Me.lciFormat = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueFormat = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.seCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lciCount = New DevExpress.XtraLayout.LayoutControlItem()
			Me.seSellPrice = New DevExpress.XtraEditors.SpinEdit()
			Me.lciSellPrice = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceAvailableForSell = New DevExpress.XtraEditors.CheckEdit()
			Me.lciAvailableForSell = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seSellPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciSellPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAvailableForSell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciAvailableForSell, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.seSellPrice)
			Me.lcMain.Controls.Add(Me.seCount)
			Me.lcMain.Controls.Add(Me.lueFormat)
			Me.lcMain.Controls.Add(Me.ceAvailableForSell)
			Me.lcMain.Size = New System.Drawing.Size(333, 152)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciFormat, Me.lciCount, Me.lciSellPrice, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.lciAvailableForSell, Me.simpleSeparator1})
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(333, 152)
			Me.lcgMain.Text = "Root"
			' 
			' lciFormat
			' 
			Me.lciFormat.Control = Me.lueFormat
			Me.lciFormat.CustomizationFormText = "Format:"
			Me.lciFormat.Location = New System.Drawing.Point(0, 0)
			Me.lciFormat.Name = "lciFormat"
			Me.lciFormat.Size = New System.Drawing.Size(333, 24)
			Me.lciFormat.Text = "Format:"
			Me.lciFormat.TextSize = New System.Drawing.Size(38, 13)
			' 
			' lueFormat
			' 
			Me.lueFormat.Location = New System.Drawing.Point(44, 2)
			Me.lueFormat.Name = "lueFormat"
			Me.lueFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueFormat.Size = New System.Drawing.Size(287, 20)
			Me.lueFormat.StyleController = Me.lcMain
			Me.lueFormat.TabIndex = 4
			' 
			' seCount
			' 
			Me.seCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seCount.Location = New System.Drawing.Point(44, 26)
			Me.seCount.Name = "seCount"
			Me.seCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seCount.Properties.IsFloatValue = False
			Me.seCount.Properties.Mask.EditMask = "N00"
			Me.seCount.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.seCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seCount.Size = New System.Drawing.Size(287, 20)
			Me.seCount.StyleController = Me.lcMain
			Me.seCount.TabIndex = 5
			' 
			' lciCount
			' 
			Me.lciCount.Control = Me.seCount
			Me.lciCount.CustomizationFormText = "Count:"
			Me.lciCount.Location = New System.Drawing.Point(0, 24)
			Me.lciCount.Name = "lciCount"
			Me.lciCount.Size = New System.Drawing.Size(333, 24)
			Me.lciCount.Text = "Count:"
			Me.lciCount.TextSize = New System.Drawing.Size(38, 13)
			' 
			' seSellPrice
			' 
			Me.seSellPrice.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seSellPrice.Location = New System.Drawing.Point(44, 94)
			Me.seSellPrice.Name = "seSellPrice"
			Me.seSellPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seSellPrice.Properties.Mask.EditMask = "c"
			Me.seSellPrice.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.seSellPrice.Properties.MaxValue = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.seSellPrice.Size = New System.Drawing.Size(287, 20)
			Me.seSellPrice.StyleController = Me.lcMain
			Me.seSellPrice.TabIndex = 6
			' 
			' lciSellPrice
			' 
			Me.lciSellPrice.Control = Me.seSellPrice
			Me.lciSellPrice.CustomizationFormText = "Price"
			Me.lciSellPrice.Location = New System.Drawing.Point(0, 92)
			Me.lciSellPrice.Name = "lciSellPrice"
			Me.lciSellPrice.Size = New System.Drawing.Size(333, 24)
			Me.lciSellPrice.Text = "Price:"
			Me.lciSellPrice.TextSize = New System.Drawing.Size(38, 13)
			' 
			' ceAvailableForSell
			' 
			Me.ceAvailableForSell.Location = New System.Drawing.Point(2, 72)
			Me.ceAvailableForSell.Name = "ceAvailableForSell"
            Me.ceAvailableForSell.Properties.AllowHtmlDraw = Utils.DefaultBoolean.True
			Me.ceAvailableForSell.Properties.Caption = "Available for <b>Sale</b>"
			Me.ceAvailableForSell.Size = New System.Drawing.Size(329, 18)
			Me.ceAvailableForSell.StyleController = Me.lcMain
			Me.ceAvailableForSell.TabIndex = 7
			' 
			' lciAvailableForSell
			' 
			Me.lciAvailableForSell.Control = Me.ceAvailableForSell
			Me.lciAvailableForSell.CustomizationFormText = "lciAvailableForSell"
			Me.lciAvailableForSell.Location = New System.Drawing.Point(0, 70)
			Me.lciAvailableForSell.Name = "lciAvailableForSell"
			Me.lciAvailableForSell.Size = New System.Drawing.Size(333, 22)
			Me.lciAvailableForSell.Text = " "
			Me.lciAvailableForSell.TextSize = New System.Drawing.Size(0, 0)
			Me.lciAvailableForSell.TextToControlDistance = 0
			Me.lciAvailableForSell.TextVisible = False
			' 
			' simpleSeparator1
			' 
			Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
			Me.simpleSeparator1.Location = New System.Drawing.Point(0, 142)
			Me.simpleSeparator1.Name = "simpleSeparator1"
			Me.simpleSeparator1.Size = New System.Drawing.Size(333, 2)
			Me.simpleSeparator1.Text = "simpleSeparator1"
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 48)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(333, 22)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 116)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(333, 26)
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' frmMovieAddItems
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(357, 198)
			Me.Name = "frmMovieAddItems"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Add to Movie Inventory"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seSellPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciSellPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAvailableForSell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciAvailableForSell, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lciFormat As DevExpress.XtraLayout.LayoutControlItem
		Private seCount As DevExpress.XtraEditors.SpinEdit
		Private lciCount As DevExpress.XtraLayout.LayoutControlItem
		Private seSellPrice As DevExpress.XtraEditors.SpinEdit
		Private lciSellPrice As DevExpress.XtraLayout.LayoutControlItem
		Private ceAvailableForSell As DevExpress.XtraEditors.CheckEdit
		Private lciAvailableForSell As DevExpress.XtraLayout.LayoutControlItem
		Private lueFormat As DevExpress.XtraEditors.ImageComboBoxEdit
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace

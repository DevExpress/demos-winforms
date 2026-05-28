Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieCategoryPriceDetail
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
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl
            Me.seDays1Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays2Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays3Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays4Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays5Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays6Price = New DevExpress.XtraEditors.SpinEdit
            Me.seDays7Price = New DevExpress.XtraEditors.SpinEdit
            Me.seLatePrice = New DevExpress.XtraEditors.SpinEdit
            Me.seDefaultDays = New DevExpress.XtraEditors.SpinEdit
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciDays1Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays2Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays3Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays4Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays5Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays6Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDays7Price = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLatePrice = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciDefaultDays = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType(Me.seDays1Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays2Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays3Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays4Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays5Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays6Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDays7Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seLatePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDefaultDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays1Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays2Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays3Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays4Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays5Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays6Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDays7Price, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLatePrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciDefaultDays, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcMain
            '
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.seDays1Price)
            Me.lcMain.Controls.Add(Me.seDays2Price)
            Me.lcMain.Controls.Add(Me.seDays3Price)
            Me.lcMain.Controls.Add(Me.seDays4Price)
            Me.lcMain.Controls.Add(Me.seDays5Price)
            Me.lcMain.Controls.Add(Me.seDays6Price)
            Me.lcMain.Controls.Add(Me.seDays7Price)
            Me.lcMain.Controls.Add(Me.seLatePrice)
            Me.lcMain.Controls.Add(Me.seDefaultDays)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Location = New System.Drawing.Point(0, 0)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.Root = Me.lcgMain
            Me.lcMain.Size = New System.Drawing.Size(394, 216)
            Me.lcMain.TabIndex = 0
            Me.lcMain.Text = "layoutControl1"
            '
            'seDays1Price
            '
            Me.seDays1Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays1Price.Location = New System.Drawing.Point(158, 2)
            Me.seDays1Price.Name = "seDays1Price"
            Me.seDays1Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays1Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays1Price.Properties.Mask.EditMask = "c"
            Me.seDays1Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays1Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays1Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays1Price.StyleController = Me.lcMain
            Me.seDays1Price.TabIndex = 4
            Me.seDays1Price.TabStop = False
            '
            'seDays2Price
            '
            Me.seDays2Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays2Price.Location = New System.Drawing.Point(158, 26)
            Me.seDays2Price.Name = "seDays2Price"
            Me.seDays2Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays2Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays2Price.Properties.Mask.EditMask = "c"
            Me.seDays2Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays2Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays2Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays2Price.StyleController = Me.lcMain
            Me.seDays2Price.TabIndex = 5
            Me.seDays2Price.TabStop = False
            '
            'seDays3Price
            '
            Me.seDays3Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays3Price.Location = New System.Drawing.Point(158, 50)
            Me.seDays3Price.Name = "seDays3Price"
            Me.seDays3Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays3Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays3Price.Properties.Mask.EditMask = "c"
            Me.seDays3Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays3Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays3Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays3Price.StyleController = Me.lcMain
            Me.seDays3Price.TabIndex = 6
            Me.seDays3Price.TabStop = False
            '
            'seDays4Price
            '
            Me.seDays4Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays4Price.Location = New System.Drawing.Point(158, 74)
            Me.seDays4Price.Name = "seDays4Price"
            Me.seDays4Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays4Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays4Price.Properties.Mask.EditMask = "c"
            Me.seDays4Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays4Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays4Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays4Price.StyleController = Me.lcMain
            Me.seDays4Price.TabIndex = 7
            Me.seDays4Price.TabStop = False
            '
            'seDays5Price
            '
            Me.seDays5Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays5Price.Location = New System.Drawing.Point(158, 98)
            Me.seDays5Price.Name = "seDays5Price"
            Me.seDays5Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays5Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays5Price.Properties.Mask.EditMask = "c"
            Me.seDays5Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays5Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays5Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays5Price.StyleController = Me.lcMain
            Me.seDays5Price.TabIndex = 8
            Me.seDays5Price.TabStop = False
            '
            'seDays6Price
            '
            Me.seDays6Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays6Price.Location = New System.Drawing.Point(158, 122)
            Me.seDays6Price.Name = "seDays6Price"
            Me.seDays6Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays6Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays6Price.Properties.Mask.EditMask = "c"
            Me.seDays6Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays6Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays6Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays6Price.StyleController = Me.lcMain
            Me.seDays6Price.TabIndex = 9
            Me.seDays6Price.TabStop = False
            '
            'seDays7Price
            '
            Me.seDays7Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seDays7Price.Location = New System.Drawing.Point(158, 146)
            Me.seDays7Price.Name = "seDays7Price"
            Me.seDays7Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDays7Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDays7Price.Properties.Mask.EditMask = "c"
            Me.seDays7Price.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seDays7Price.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seDays7Price.Size = New System.Drawing.Size(234, 20)
            Me.seDays7Price.StyleController = Me.lcMain
            Me.seDays7Price.TabIndex = 10
            Me.seDays7Price.TabStop = False
            '
            'seLatePrice
            '
            Me.seLatePrice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seLatePrice.Location = New System.Drawing.Point(158, 170)
            Me.seLatePrice.Name = "seLatePrice"
            Me.seLatePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seLatePrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seLatePrice.Properties.Mask.EditMask = "c"
            Me.seLatePrice.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.seLatePrice.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.seLatePrice.Size = New System.Drawing.Size(234, 20)
            Me.seLatePrice.StyleController = Me.lcMain
            Me.seLatePrice.TabIndex = 11
            Me.seLatePrice.TabStop = False
            '
            'seDefaultDays
            '
            Me.seDefaultDays.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seDefaultDays.Location = New System.Drawing.Point(158, 194)
            Me.seDefaultDays.Name = "seDefaultDays"
            Me.seDefaultDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.seDefaultDays.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seDefaultDays.Properties.IsFloatValue = False
            Me.seDefaultDays.Properties.Mask.EditMask = "N00"
            Me.seDefaultDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.seDefaultDays.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.seDefaultDays.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seDefaultDays.Size = New System.Drawing.Size(234, 20)
            Me.seDefaultDays.StyleController = Me.lcMain
            Me.seDefaultDays.TabIndex = 12
            Me.seDefaultDays.TabStop = False
            '
            'lcgMain
            '
            Me.lcgMain.CustomizationFormText = "lcgMain"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciDays1Price, Me.lciDays2Price, Me.lciDays3Price, Me.lciDays4Price, Me.lciDays5Price, Me.lciDays6Price, Me.lciDays7Price, Me.lciLatePrice, Me.lciDefaultDays})
            Me.lcgMain.Location = New System.Drawing.Point(0, 0)
            Me.lcgMain.Name = "lcgMain"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgMain.Size = New System.Drawing.Size(394, 216)
            Me.lcgMain.Text = "lcgMain"
            Me.lcgMain.TextVisible = False
            '
            'lciDays1Price
            '
            Me.lciDays1Price.Control = Me.seDays1Price
            Me.lciDays1Price.CustomizationFormText = "Price Per Day For 1 Day Rental"
            Me.lciDays1Price.Location = New System.Drawing.Point(0, 0)
            Me.lciDays1Price.Name = "lciDays1Price"
            Me.lciDays1Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays1Price.Text = "Price Per Day For 1 Day Rental:"
            Me.lciDays1Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays2Price
            '
            Me.lciDays2Price.Control = Me.seDays2Price
            Me.lciDays2Price.CustomizationFormText = "Price Per Day For 2 Day Rental"
            Me.lciDays2Price.Location = New System.Drawing.Point(0, 24)
            Me.lciDays2Price.Name = "lciDays2Price"
            Me.lciDays2Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays2Price.Text = "Price Per Day For 2 Day Rental:"
            Me.lciDays2Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays3Price
            '
            Me.lciDays3Price.Control = Me.seDays3Price
            Me.lciDays3Price.CustomizationFormText = "Price Per Day For 3 Day Rental"
            Me.lciDays3Price.Location = New System.Drawing.Point(0, 48)
            Me.lciDays3Price.Name = "lciDays3Price"
            Me.lciDays3Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays3Price.Text = "Price Per Day For 3 Day Rental:"
            Me.lciDays3Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays4Price
            '
            Me.lciDays4Price.Control = Me.seDays4Price
            Me.lciDays4Price.CustomizationFormText = "Price Per Day For 4 Day Rental"
            Me.lciDays4Price.Location = New System.Drawing.Point(0, 72)
            Me.lciDays4Price.Name = "lciDays4Price"
            Me.lciDays4Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays4Price.Text = "Price Per Day For 4 Day Rental:"
            Me.lciDays4Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays5Price
            '
            Me.lciDays5Price.Control = Me.seDays5Price
            Me.lciDays5Price.CustomizationFormText = "Price Per Day For 5 Day Rental"
            Me.lciDays5Price.Location = New System.Drawing.Point(0, 96)
            Me.lciDays5Price.Name = "lciDays5Price"
            Me.lciDays5Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays5Price.Text = "Price Per Day For 5 Day Rental:"
            Me.lciDays5Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays6Price
            '
            Me.lciDays6Price.Control = Me.seDays6Price
            Me.lciDays6Price.CustomizationFormText = "Price Per Day For 6 Day Rental"
            Me.lciDays6Price.Location = New System.Drawing.Point(0, 120)
            Me.lciDays6Price.Name = "lciDays6Price"
            Me.lciDays6Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays6Price.Text = "Price Per Day For 6 Day Rental:"
            Me.lciDays6Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDays7Price
            '
            Me.lciDays7Price.Control = Me.seDays7Price
            Me.lciDays7Price.CustomizationFormText = "Price Per Day For 7 Day Rental"
            Me.lciDays7Price.Location = New System.Drawing.Point(0, 144)
            Me.lciDays7Price.Name = "lciDays7Price"
            Me.lciDays7Price.Size = New System.Drawing.Size(394, 24)
            Me.lciDays7Price.Text = "Price Per Day For 7 Day Rental:"
            Me.lciDays7Price.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciLatePrice
            '
            Me.lciLatePrice.Control = Me.seLatePrice
            Me.lciLatePrice.CustomizationFormText = "Late Price Per Day"
            Me.lciLatePrice.Location = New System.Drawing.Point(0, 168)
            Me.lciLatePrice.Name = "lciLatePrice"
            Me.lciLatePrice.Size = New System.Drawing.Size(394, 24)
            Me.lciLatePrice.Text = "Late Price Per Day:"
            Me.lciLatePrice.TextSize = New System.Drawing.Size(152, 13)
            '
            'lciDefaultDays
            '
            Me.lciDefaultDays.Control = Me.seDefaultDays
            Me.lciDefaultDays.CustomizationFormText = "Default # of Rental Days"
            Me.lciDefaultDays.Location = New System.Drawing.Point(0, 192)
            Me.lciDefaultDays.Name = "lciDefaultDays"
            Me.lciDefaultDays.Size = New System.Drawing.Size(394, 24)
            Me.lciDefaultDays.Text = "Default # of Rental Days:"
            Me.lciDefaultDays.TextSize = New System.Drawing.Size(152, 13)
            '
            'ucMovieCategoryPriceDetail
            '
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lcMain)
            Me.Name = "ucMovieCategoryPriceDetail"
            Me.Size = New System.Drawing.Size(394, 216)
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType(Me.seDays1Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays2Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays3Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays4Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays5Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays6Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDays7Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seLatePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDefaultDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays1Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays2Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays3Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays4Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays5Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays6Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDays7Price, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLatePrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciDefaultDays, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciDays1Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays2Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays3Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays4Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays5Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays6Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciDays7Price As DevExpress.XtraLayout.LayoutControlItem
		Private lciLatePrice As DevExpress.XtraLayout.LayoutControlItem
		Private lciDefaultDays As DevExpress.XtraLayout.LayoutControlItem
		Private seDays1Price As DevExpress.XtraEditors.SpinEdit
		Private seDays2Price As DevExpress.XtraEditors.SpinEdit
		Private seDays3Price As DevExpress.XtraEditors.SpinEdit
		Private seDays4Price As DevExpress.XtraEditors.SpinEdit
		Private seDays5Price As DevExpress.XtraEditors.SpinEdit
		Private seDays6Price As DevExpress.XtraEditors.SpinEdit
		Private seDays7Price As DevExpress.XtraEditors.SpinEdit
		Private seLatePrice As DevExpress.XtraEditors.SpinEdit
		Private seDefaultDays As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace

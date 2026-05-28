Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class CustomerDetail
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
			Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teMiddleName = New DevExpress.XtraEditors.TextEdit()
			Me.lciMiddleName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teLastName = New DevExpress.XtraEditors.TextEdit()
			Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.icbGender = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
			Me.deBirthDate = New DevExpress.XtraEditors.DateEdit()
			Me.lciBirthDate = New DevExpress.XtraLayout.LayoutControlItem()
			Me.tePhone = New DevExpress.XtraEditors.TextEdit()
			Me.meAddress = New DevExpress.XtraEditors.MemoEdit()
			Me.lciAddress = New DevExpress.XtraLayout.LayoutControlItem()
			Me.beEmail = New DevExpress.XtraEditors.ButtonEdit()
			Me.lciEmail = New DevExpress.XtraLayout.LayoutControlItem()
			Me.meComments = New DevExpress.XtraEditors.MemoEdit()
			Me.ucPictureEditBar1 = New DevExpress.VideoRent.Win.Controls.ucPictureEditBar()
			Me.lciBar = New DevExpress.XtraLayout.LayoutControlItem()
			Me.tcgAddress = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.lcgAddress = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgDiscount = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciLevel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.icbDiscountLevel = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lciDiscount = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teDiscount = New DevExpress.XtraEditors.TextEdit()
			Me.lciNotes = New DevExpress.XtraLayout.LayoutControlItem()
			Me.npDiscount = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.lciComments = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teMiddleName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMiddleName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGender, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deBirthDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.beEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcgAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLevel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbDiscountLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciComments, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.npDiscount)
			Me.lcMain.Controls.Add(Me.teDiscount)
			Me.lcMain.Controls.Add(Me.icbDiscountLevel)
			Me.lcMain.Controls.Add(Me.ucPictureEditBar1)
			Me.lcMain.Controls.Add(Me.meComments)
			Me.lcMain.Controls.Add(Me.beEmail)
			Me.lcMain.Controls.Add(Me.meAddress)
			Me.lcMain.Controls.Add(Me.tePhone)
			Me.lcMain.Controls.Add(Me.deBirthDate)
			Me.lcMain.Controls.Add(Me.icbGender)
			Me.lcMain.Controls.Add(Me.teLastName)
			Me.lcMain.Controls.Add(Me.teMiddleName)
			Me.lcMain.Controls.Add(Me.teFirstName)
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Size = New System.Drawing.Size(711, 451)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciFirstName, Me.lciMiddleName, Me.lciLastName, Me.lciGender, Me.lciBirthDate, Me.lciComments, Me.lciBar, Me.tcgAddress, Me.splitterItem1, Me.lciPhoto})
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(711, 451)
			Me.lcgMain.Text = "Root"
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(8, 8)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.ReadOnly = True
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(282, 303)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 4
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "Photo"
			Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Size = New System.Drawing.Size(286, 307)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' teFirstName
			' 
			Me.teFirstName.Location = New System.Drawing.Point(368, 8)
			Me.teFirstName.Name = "teFirstName"
			Me.teFirstName.Size = New System.Drawing.Size(335, 20)
			Me.teFirstName.StyleController = Me.lcMain
			Me.teFirstName.TabIndex = 5
			' 
			' lciFirstName
			' 
			Me.lciFirstName.Control = Me.teFirstName
			Me.lciFirstName.CustomizationFormText = "First Name"
			Me.lciFirstName.Location = New System.Drawing.Point(292, 0)
			Me.lciFirstName.Name = "lciFirstName"
			Me.lciFirstName.Size = New System.Drawing.Size(407, 24)
			Me.lciFirstName.Text = "First Name:"
			Me.lciFirstName.TextSize = New System.Drawing.Size(64, 13)
			' 
			' teMiddleName
			' 
			Me.teMiddleName.Location = New System.Drawing.Point(368, 32)
			Me.teMiddleName.Name = "teMiddleName"
			Me.teMiddleName.Size = New System.Drawing.Size(335, 20)
			Me.teMiddleName.StyleController = Me.lcMain
			Me.teMiddleName.TabIndex = 6
			' 
			' lciMiddleName
			' 
			Me.lciMiddleName.Control = Me.teMiddleName
			Me.lciMiddleName.CustomizationFormText = "Middle Name"
			Me.lciMiddleName.Location = New System.Drawing.Point(292, 24)
			Me.lciMiddleName.Name = "lciMiddleName"
			Me.lciMiddleName.Size = New System.Drawing.Size(407, 24)
			Me.lciMiddleName.Text = "Middle Name:"
			Me.lciMiddleName.TextSize = New System.Drawing.Size(64, 13)
			' 
			' teLastName
			' 
			Me.teLastName.Location = New System.Drawing.Point(368, 56)
			Me.teLastName.Name = "teLastName"
			Me.teLastName.Size = New System.Drawing.Size(335, 20)
			Me.teLastName.StyleController = Me.lcMain
			Me.teLastName.TabIndex = 7
			' 
			' lciLastName
			' 
			Me.lciLastName.Control = Me.teLastName
			Me.lciLastName.CustomizationFormText = "Last Name"
			Me.lciLastName.Location = New System.Drawing.Point(292, 48)
			Me.lciLastName.Name = "lciLastName"
			Me.lciLastName.Size = New System.Drawing.Size(407, 24)
			Me.lciLastName.Text = "Last Name:"
			Me.lciLastName.TextSize = New System.Drawing.Size(64, 13)
			' 
			' icbGender
			' 
			Me.icbGender.Location = New System.Drawing.Point(368, 80)
			Me.icbGender.Name = "icbGender"
			Me.icbGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbGender.Size = New System.Drawing.Size(155, 20)
			Me.icbGender.StyleController = Me.lcMain
			Me.icbGender.TabIndex = 8
			' 
			' lciGender
			' 
			Me.lciGender.Control = Me.icbGender
			Me.lciGender.CustomizationFormText = "Gender"
			Me.lciGender.Location = New System.Drawing.Point(292, 72)
			Me.lciGender.Name = "lciGender"
			Me.lciGender.Size = New System.Drawing.Size(227, 24)
			Me.lciGender.Text = "Gender:"
			Me.lciGender.TextSize = New System.Drawing.Size(64, 13)
			' 
			' deBirthDate
			' 
			Me.deBirthDate.EditValue = Nothing
			Me.deBirthDate.Location = New System.Drawing.Point(595, 80)
			Me.deBirthDate.Name = "deBirthDate"
			Me.deBirthDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.deBirthDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.deBirthDate.Size = New System.Drawing.Size(108, 20)
			Me.deBirthDate.StyleController = Me.lcMain
			Me.deBirthDate.TabIndex = 9
			' 
			' lciBirthDate
			' 
			Me.lciBirthDate.Control = Me.deBirthDate
			Me.lciBirthDate.CustomizationFormText = "Birth Date"
			Me.lciBirthDate.Location = New System.Drawing.Point(519, 72)
			Me.lciBirthDate.Name = "lciBirthDate"
			Me.lciBirthDate.Size = New System.Drawing.Size(180, 24)
			Me.lciBirthDate.Text = "Birth Date:"
			Me.lciBirthDate.TextSize = New System.Drawing.Size(64, 13)
			' 
			' tePhone
			' 
			Me.tePhone.Location = New System.Drawing.Point(379, 136)
			Me.tePhone.Name = "tePhone"
			Me.tePhone.Properties.Mask.EditMask = "(\(\d\d\d\))?\d{1,3}-\d\d\d\d"
			Me.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.tePhone.Size = New System.Drawing.Size(313, 20)
			Me.tePhone.StyleController = Me.lcMain
			Me.tePhone.TabIndex = 10
			' 
			' meAddress
			' 
			Me.meAddress.Location = New System.Drawing.Point(379, 160)
			Me.meAddress.Name = "meAddress"
			Me.meAddress.Size = New System.Drawing.Size(313, 146)
			Me.meAddress.StyleController = Me.lcMain
			Me.meAddress.TabIndex = 11
			' 
			' lciAddress
			' 
			Me.lciAddress.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciAddress.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciAddress.Control = Me.meAddress
			Me.lciAddress.CustomizationFormText = "Address:"
			Me.lciAddress.Location = New System.Drawing.Point(0, 24)
			Me.lciAddress.Name = "lciAddress"
			Me.lciAddress.Size = New System.Drawing.Size(385, 150)
			Me.lciAddress.Text = "Address:"
			Me.lciAddress.TextSize = New System.Drawing.Size(64, 13)
			' 
			' beEmail
			' 
			Me.beEmail.Location = New System.Drawing.Point(379, 310)
			Me.beEmail.Name = "beEmail"
			Me.beEmail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Send Email", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Send Email", Nothing, Nothing, True)})
			Me.beEmail.Properties.Mask.EditMask = ".+@.+\..+"
			Me.beEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.beEmail.Size = New System.Drawing.Size(313, 20)
			Me.beEmail.StyleController = Me.lcMain
			Me.beEmail.TabIndex = 12
'			Me.beEmail.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.beEmail_ButtonClick);
'			Me.beEmail.TextChanged += New System.EventHandler(Me.beEmail_TextChanged);
			' 
			' lciEmail
			' 
			Me.lciEmail.Control = Me.beEmail
			Me.lciEmail.CustomizationFormText = "Email"
			Me.lciEmail.Location = New System.Drawing.Point(0, 174)
			Me.lciEmail.Name = "lciEmail"
			Me.lciEmail.Size = New System.Drawing.Size(385, 24)
			Me.lciEmail.Text = "Email:"
			Me.lciEmail.TextSize = New System.Drawing.Size(64, 13)
			' 
			' meComments
			' 
			Me.meComments.Location = New System.Drawing.Point(8, 361)
			Me.meComments.Name = "meComments"
			Me.meComments.Size = New System.Drawing.Size(695, 82)
			Me.meComments.StyleController = Me.lcMain
			Me.meComments.TabIndex = 13
			' 
			' ucPictureEditBar1
			' 
			Me.ucPictureEditBar1.Location = New System.Drawing.Point(8, 315)
			Me.ucPictureEditBar1.Name = "ucPictureEditBar1"
			Me.ucPictureEditBar1.Size = New System.Drawing.Size(282, 26)
			Me.ucPictureEditBar1.TabIndex = 14
			' 
			' lciBar
			' 
			Me.lciBar.Control = Me.ucPictureEditBar1
			Me.lciBar.CustomizationFormText = "layoutControlItem10"
			Me.lciBar.Location = New System.Drawing.Point(0, 307)
			Me.lciBar.Name = "lciBar"
			Me.lciBar.Size = New System.Drawing.Size(286, 30)
			Me.lciBar.Text = "lciBar"
			Me.lciBar.TextSize = New System.Drawing.Size(0, 0)
			Me.lciBar.TextToControlDistance = 0
			Me.lciBar.TextVisible = False
			' 
			' tcgAddress
			' 
			Me.tcgAddress.CustomizationFormText = "tcgAddress"
			Me.tcgAddress.Location = New System.Drawing.Point(292, 96)
			Me.tcgAddress.Name = "tcgAddress"
			Me.tcgAddress.SelectedTabPage = Me.lcgAddress
			Me.tcgAddress.SelectedTabPageIndex = 0
			Me.tcgAddress.Size = New System.Drawing.Size(407, 241)
			Me.tcgAddress.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgAddress, Me.lcgDiscount})
			Me.tcgAddress.Text = "tcgAddress"
			' 
			' lcgAddress
			' 
			Me.lcgAddress.CustomizationFormText = "Address"
			Me.lcgAddress.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPhone, Me.lciAddress, Me.lciEmail})
			Me.lcgAddress.Location = New System.Drawing.Point(0, 0)
			Me.lcgAddress.Name = "lcgAddress"
			Me.lcgAddress.Size = New System.Drawing.Size(385, 198)
			Me.lcgAddress.Text = "Address"
			' 
			' lciPhone
			' 
			Me.lciPhone.Control = Me.tePhone
			Me.lciPhone.CustomizationFormText = "Phone"
			Me.lciPhone.Location = New System.Drawing.Point(0, 0)
			Me.lciPhone.Name = "lciPhone"
			Me.lciPhone.Size = New System.Drawing.Size(385, 24)
			Me.lciPhone.Text = "Phone:"
			Me.lciPhone.TextSize = New System.Drawing.Size(64, 13)
			' 
			' lcgDiscount
			' 
			Me.lcgDiscount.CustomizationFormText = "Level"
			Me.lcgDiscount.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciLevel, Me.emptySpaceItem1, Me.lciDiscount, Me.lciNotes})
			Me.lcgDiscount.Location = New System.Drawing.Point(0, 0)
			Me.lcgDiscount.Name = "lcgDiscount"
			Me.lcgDiscount.Size = New System.Drawing.Size(385, 198)
			Me.lcgDiscount.Text = "Discount"
			' 
			' lciLevel
			' 
			Me.lciLevel.Control = Me.icbDiscountLevel
			Me.lciLevel.CustomizationFormText = "Level:"
			Me.lciLevel.Location = New System.Drawing.Point(0, 0)
			Me.lciLevel.Name = "lciLevel"
			Me.lciLevel.Size = New System.Drawing.Size(385, 24)
			Me.lciLevel.Text = "Level:"
			Me.lciLevel.TextSize = New System.Drawing.Size(64, 13)
			' 
			' icbDiscountLevel
			' 
			Me.icbDiscountLevel.Location = New System.Drawing.Point(379, 136)
			Me.icbDiscountLevel.Name = "icbDiscountLevel"
			Me.icbDiscountLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbDiscountLevel.Properties.ReadOnly = True
			Me.icbDiscountLevel.Size = New System.Drawing.Size(313, 20)
			Me.icbDiscountLevel.StyleController = Me.lcMain
			Me.icbDiscountLevel.TabIndex = 15
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(385, 96)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lciDiscount
			' 
			Me.lciDiscount.Control = Me.teDiscount
			Me.lciDiscount.CustomizationFormText = "Discount:"
			Me.lciDiscount.Location = New System.Drawing.Point(0, 24)
			Me.lciDiscount.Name = "lciDiscount"
			Me.lciDiscount.Size = New System.Drawing.Size(385, 24)
			Me.lciDiscount.Text = "Discount:"
			Me.lciDiscount.TextSize = New System.Drawing.Size(64, 13)
			' 
			' teDiscount
			' 
			Me.teDiscount.Location = New System.Drawing.Point(379, 160)
			Me.teDiscount.Name = "teDiscount"
			Me.teDiscount.Properties.ReadOnly = True
			Me.teDiscount.Size = New System.Drawing.Size(313, 20)
			Me.teDiscount.StyleController = Me.lcMain
			Me.teDiscount.TabIndex = 16
			' 
			' lciNotes
			' 
			Me.lciNotes.Control = Me.npDiscount
			Me.lciNotes.CustomizationFormText = "lciNotes"
			Me.lciNotes.Location = New System.Drawing.Point(0, 144)
			Me.lciNotes.Name = "lciNotes"
			Me.lciNotes.Size = New System.Drawing.Size(385, 54)
			Me.lciNotes.Text = "lciNotes"
			Me.lciNotes.TextSize = New System.Drawing.Size(0, 0)
			Me.lciNotes.TextToControlDistance = 0
			Me.lciNotes.TextVisible = False
			' 
			' npDiscount
			' 
			Me.npDiscount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.npDiscount.Location = New System.Drawing.Point(311, 280)
			Me.npDiscount.Name = "npDiscount"
			Me.npDiscount.Size = New System.Drawing.Size(381, 50)
			Me.npDiscount.TabIndex = 17
			Me.npDiscount.TabStop = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(286, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 337)
			' 
			' lciComments
			' 
			Me.lciComments.Control = Me.meComments
			Me.lciComments.CustomizationFormText = "Comments"
			Me.lciComments.Location = New System.Drawing.Point(0, 337)
			Me.lciComments.Name = "lciComments"
			Me.lciComments.Size = New System.Drawing.Size(699, 102)
			Me.lciComments.Text = "Comments:"
			Me.lciComments.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciComments.TextSize = New System.Drawing.Size(64, 13)
			' 
			' CustomerDetail
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.MinimumSize = New System.Drawing.Size(392, 292)
			Me.Name = "CustomerDetail"
			Me.Size = New System.Drawing.Size(711, 451)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teMiddleName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMiddleName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGender, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deBirthDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.beEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcgAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgDiscount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLevel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbDiscountLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDiscount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciComments, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private teFirstName As DevExpress.XtraEditors.TextEdit
		Private pePhoto As DevExpress.XtraEditors.PictureEdit
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private lciFirstName As DevExpress.XtraLayout.LayoutControlItem
		Private deBirthDate As DevExpress.XtraEditors.DateEdit
		Private icbGender As DevExpress.XtraEditors.ImageComboBoxEdit
		Private teLastName As DevExpress.XtraEditors.TextEdit
		Private teMiddleName As DevExpress.XtraEditors.TextEdit
		Private lciMiddleName As DevExpress.XtraLayout.LayoutControlItem
		Private lciLastName As DevExpress.XtraLayout.LayoutControlItem
		Private lciGender As DevExpress.XtraLayout.LayoutControlItem
		Private lciBirthDate As DevExpress.XtraLayout.LayoutControlItem
		Private meComments As DevExpress.XtraEditors.MemoEdit
		Private WithEvents beEmail As DevExpress.XtraEditors.ButtonEdit
		Private meAddress As DevExpress.XtraEditors.MemoEdit
		Private tePhone As DevExpress.XtraEditors.TextEdit
		Private lciAddress As DevExpress.XtraLayout.LayoutControlItem
		Private lciEmail As DevExpress.XtraLayout.LayoutControlItem
		Private ucPictureEditBar1 As DevExpress.VideoRent.Win.Controls.ucPictureEditBar
		Private lciBar As DevExpress.XtraLayout.LayoutControlItem
		Private tcgAddress As DevExpress.XtraLayout.TabbedControlGroup
		Private lcgAddress As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhone As DevExpress.XtraLayout.LayoutControlItem
		Private lcgDiscount As DevExpress.XtraLayout.LayoutControlGroup
		Private teDiscount As DevExpress.XtraEditors.TextEdit
		Private icbDiscountLevel As DevExpress.XtraEditors.ImageComboBoxEdit
		Private lciLevel As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private lciDiscount As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private lciComments As DevExpress.XtraLayout.LayoutControlItem
		Private npDiscount As DevExpress.Utils.Frames.NotePanel8_1
		Private lciNotes As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

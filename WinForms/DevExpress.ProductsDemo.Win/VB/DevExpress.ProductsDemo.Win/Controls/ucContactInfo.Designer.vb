Namespace DevExpress.MailClient.Win.Controls
	Partial Public Class ucContactInfo
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucContactInfo))
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.teNotes = New DevExpress.XtraEditors.MemoEdit()
			Me.teAddress = New DevExpress.XtraEditors.TextEdit()
			Me.tePhone = New DevExpress.XtraEditors.TextEdit()
			Me.teEmail = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.teBirthDate = New DevExpress.XtraEditors.TextEdit()
			Me.lbName = New DevExpress.XtraEditors.LabelControl()
			Me.pePhoto = New DevExpress.MailClient.Win.PictureEditSimpleZoom()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			resources.ApplyResources(Me.lcMain, "lcMain")
			Me.lcMain.AllowCustomization = False
			Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (CInt(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta")))
			Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
			Me.lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.lcMain.Appearance.DisabledLayoutGroupCaption.Image = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
			Me.lcMain.Appearance.DisabledLayoutItem.FontSizeDelta = (CInt(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontSizeDelta")))
			Me.lcMain.Appearance.DisabledLayoutItem.FontStyleDelta = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
			Me.lcMain.Appearance.DisabledLayoutItem.GradientMode = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.lcMain.Appearance.DisabledLayoutItem.Image = (CType(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
			Me.lcMain.Controls.Add(Me.teNotes)
			Me.lcMain.Controls.Add(Me.teAddress)
			Me.lcMain.Controls.Add(Me.tePhone)
			Me.lcMain.Controls.Add(Me.teEmail)
			Me.lcMain.Controls.Add(Me.teBirthDate)
			Me.lcMain.Controls.Add(Me.lbName)
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(669, 200, 450, 350)
			Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (CInt(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta")))
			Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
			Me.lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.lcMain.OptionsPrint.AppearanceGroupCaption.Image = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
			Me.lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (CInt(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta")))
			Me.lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
			Me.lcMain.OptionsPrint.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.lcMain.OptionsPrint.AppearanceItemCaption.Image = (CType(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
			'this.lcMain.OptionsView.RightToLeftMirroringApplied = true;
			Me.lcMain.Root = Me.lcgMain
			' 
			' teNotes
			' 
			resources.ApplyResources(Me.teNotes, "teNotes")
			Me.teNotes.Name = "teNotes"
			Me.teNotes.Properties.AccessibleDescription = resources.GetString("teNotes.Properties.AccessibleDescription")
			Me.teNotes.Properties.AccessibleName = resources.GetString("teNotes.Properties.AccessibleName")
			Me.teNotes.Properties.NullValuePrompt = resources.GetString("teNotes.Properties.NullValuePrompt")
			Me.teNotes.Properties.NullValuePromptShowForEmptyValue = (CBool(resources.GetObject("teNotes.Properties.NullValuePromptShowForEmptyValue")))
			Me.teNotes.Properties.ReadOnly = True
			Me.teNotes.StyleController = Me.lcMain
			' 
			' teAddress
			' 
			resources.ApplyResources(Me.teAddress, "teAddress")
			Me.teAddress.Name = "teAddress"
			Me.teAddress.Properties.AccessibleDescription = resources.GetString("teAddress.Properties.AccessibleDescription")
			Me.teAddress.Properties.AccessibleName = resources.GetString("teAddress.Properties.AccessibleName")
			Me.teAddress.Properties.AutoHeight = (CBool(resources.GetObject("teAddress.Properties.AutoHeight")))
			Me.teAddress.Properties.Mask.AutoComplete = (CType(resources.GetObject("teAddress.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
			Me.teAddress.Properties.Mask.BeepOnError = (CBool(resources.GetObject("teAddress.Properties.Mask.BeepOnError")))
			Me.teAddress.Properties.Mask.EditMask = resources.GetString("teAddress.Properties.Mask.EditMask")
			Me.teAddress.Properties.Mask.IgnoreMaskBlank = (CBool(resources.GetObject("teAddress.Properties.Mask.IgnoreMaskBlank")))
			Me.teAddress.Properties.Mask.MaskType = (CType(resources.GetObject("teAddress.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.teAddress.Properties.Mask.PlaceHolder = (CChar(resources.GetObject("teAddress.Properties.Mask.PlaceHolder")))
			Me.teAddress.Properties.Mask.SaveLiteral = (CBool(resources.GetObject("teAddress.Properties.Mask.SaveLiteral")))
			Me.teAddress.Properties.Mask.ShowPlaceHolders = (CBool(resources.GetObject("teAddress.Properties.Mask.ShowPlaceHolders")))
			Me.teAddress.Properties.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("teAddress.Properties.Mask.UseMaskAsDisplayFormat")))
			Me.teAddress.Properties.NullValuePrompt = resources.GetString("teAddress.Properties.NullValuePrompt")
			Me.teAddress.Properties.NullValuePromptShowForEmptyValue = (CBool(resources.GetObject("teAddress.Properties.NullValuePromptShowForEmptyValue")))
			Me.teAddress.Properties.ReadOnly = True
			Me.teAddress.StyleController = Me.lcMain
			' 
			' tePhone
			' 
			resources.ApplyResources(Me.tePhone, "tePhone")
			Me.tePhone.Name = "tePhone"
			Me.tePhone.Properties.AccessibleDescription = resources.GetString("tePhone.Properties.AccessibleDescription")
			Me.tePhone.Properties.AccessibleName = resources.GetString("tePhone.Properties.AccessibleName")
			Me.tePhone.Properties.AutoHeight = (CBool(resources.GetObject("tePhone.Properties.AutoHeight")))
			Me.tePhone.Properties.Mask.AutoComplete = (CType(resources.GetObject("tePhone.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
			Me.tePhone.Properties.Mask.BeepOnError = (CBool(resources.GetObject("tePhone.Properties.Mask.BeepOnError")))
			Me.tePhone.Properties.Mask.EditMask = resources.GetString("tePhone.Properties.Mask.EditMask")
			Me.tePhone.Properties.Mask.IgnoreMaskBlank = (CBool(resources.GetObject("tePhone.Properties.Mask.IgnoreMaskBlank")))
			Me.tePhone.Properties.Mask.MaskType = (CType(resources.GetObject("tePhone.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.tePhone.Properties.Mask.PlaceHolder = (CChar(resources.GetObject("tePhone.Properties.Mask.PlaceHolder")))
			Me.tePhone.Properties.Mask.SaveLiteral = (CBool(resources.GetObject("tePhone.Properties.Mask.SaveLiteral")))
			Me.tePhone.Properties.Mask.ShowPlaceHolders = (CBool(resources.GetObject("tePhone.Properties.Mask.ShowPlaceHolders")))
			Me.tePhone.Properties.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("tePhone.Properties.Mask.UseMaskAsDisplayFormat")))
			Me.tePhone.Properties.NullValuePrompt = resources.GetString("tePhone.Properties.NullValuePrompt")
			Me.tePhone.Properties.NullValuePromptShowForEmptyValue = (CBool(resources.GetObject("tePhone.Properties.NullValuePromptShowForEmptyValue")))
			Me.tePhone.Properties.ReadOnly = True
			Me.tePhone.StyleController = Me.lcMain
			' 
			' teEmail
			' 
			resources.ApplyResources(Me.teEmail, "teEmail")
			Me.teEmail.Name = "teEmail"
			Me.teEmail.Properties.AccessibleDescription = resources.GetString("teEmail.Properties.AccessibleDescription")
			Me.teEmail.Properties.AccessibleName = resources.GetString("teEmail.Properties.AccessibleName")
			Me.teEmail.Properties.AutoHeight = (CBool(resources.GetObject("teEmail.Properties.AutoHeight")))
			Me.teEmail.Properties.Caption = resources.GetString("teEmail.Properties.Caption")
			Me.teEmail.Properties.Mask.AutoComplete = (CType(resources.GetObject("teEmail.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
			Me.teEmail.Properties.Mask.BeepOnError = (CBool(resources.GetObject("teEmail.Properties.Mask.BeepOnError")))
			Me.teEmail.Properties.Mask.EditMask = resources.GetString("teEmail.Properties.Mask.EditMask")
			Me.teEmail.Properties.Mask.IgnoreMaskBlank = (CBool(resources.GetObject("teEmail.Properties.Mask.IgnoreMaskBlank")))
			Me.teEmail.Properties.Mask.MaskType = (CType(resources.GetObject("teEmail.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.teEmail.Properties.Mask.PlaceHolder = (CChar(resources.GetObject("teEmail.Properties.Mask.PlaceHolder")))
			Me.teEmail.Properties.Mask.SaveLiteral = (CBool(resources.GetObject("teEmail.Properties.Mask.SaveLiteral")))
			Me.teEmail.Properties.Mask.ShowPlaceHolders = (CBool(resources.GetObject("teEmail.Properties.Mask.ShowPlaceHolders")))
			Me.teEmail.Properties.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("teEmail.Properties.Mask.UseMaskAsDisplayFormat")))
			Me.teEmail.Properties.NullValuePrompt = resources.GetString("teEmail.Properties.NullValuePrompt")
			Me.teEmail.Properties.NullValuePromptShowForEmptyValue = (CBool(resources.GetObject("teEmail.Properties.NullValuePromptShowForEmptyValue")))
			Me.teEmail.Properties.ReadOnly = True
			Me.teEmail.StyleController = Me.lcMain
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.teEmail.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.teEmail_OpenLink);
			' 
			' teBirthDate
			' 
			resources.ApplyResources(Me.teBirthDate, "teBirthDate")
			Me.teBirthDate.Name = "teBirthDate"
			Me.teBirthDate.Properties.AccessibleDescription = resources.GetString("teBirthDate.Properties.AccessibleDescription")
			Me.teBirthDate.Properties.AccessibleName = resources.GetString("teBirthDate.Properties.AccessibleName")
			Me.teBirthDate.Properties.AutoHeight = (CBool(resources.GetObject("teBirthDate.Properties.AutoHeight")))
			Me.teBirthDate.Properties.Mask.AutoComplete = (CType(resources.GetObject("teBirthDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
			Me.teBirthDate.Properties.Mask.BeepOnError = (CBool(resources.GetObject("teBirthDate.Properties.Mask.BeepOnError")))
			Me.teBirthDate.Properties.Mask.EditMask = resources.GetString("teBirthDate.Properties.Mask.EditMask")
			Me.teBirthDate.Properties.Mask.IgnoreMaskBlank = (CBool(resources.GetObject("teBirthDate.Properties.Mask.IgnoreMaskBlank")))
			Me.teBirthDate.Properties.Mask.MaskType = (CType(resources.GetObject("teBirthDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.teBirthDate.Properties.Mask.PlaceHolder = (CChar(resources.GetObject("teBirthDate.Properties.Mask.PlaceHolder")))
			Me.teBirthDate.Properties.Mask.SaveLiteral = (CBool(resources.GetObject("teBirthDate.Properties.Mask.SaveLiteral")))
			Me.teBirthDate.Properties.Mask.ShowPlaceHolders = (CBool(resources.GetObject("teBirthDate.Properties.Mask.ShowPlaceHolders")))
			Me.teBirthDate.Properties.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("teBirthDate.Properties.Mask.UseMaskAsDisplayFormat")))
			Me.teBirthDate.Properties.NullValuePrompt = resources.GetString("teBirthDate.Properties.NullValuePrompt")
			Me.teBirthDate.Properties.NullValuePromptShowForEmptyValue = (CBool(resources.GetObject("teBirthDate.Properties.NullValuePromptShowForEmptyValue")))
			Me.teBirthDate.Properties.ReadOnly = True
			Me.teBirthDate.StyleController = Me.lcMain
			' 
			' lbName
			' 
			resources.ApplyResources(Me.lbName, "lbName")
			Me.lbName.AppearanceDisabled.Image = (CType(resources.GetObject("lbName.Appearance.DisabledImage"), System.Drawing.Image))
			Me.lbName.Appearance.Font = (CType(resources.GetObject("lbName.Appearance.Font"), System.Drawing.Font))
			Me.lbName.Appearance.FontSizeDelta = (CInt(resources.GetObject("lbName.Appearance.FontSizeDelta")))
			Me.lbName.Appearance.FontStyleDelta = (CType(resources.GetObject("lbName.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
			Me.lbName.Appearance.GradientMode = (CType(resources.GetObject("lbName.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.lbName.AppearanceHovered.Image = (CType(resources.GetObject("lbName.Appearance.HoverImage"), System.Drawing.Image))
			Me.lbName.Appearance.Image = (CType(resources.GetObject("lbName.Appearance.Image"), System.Drawing.Image))
			Me.lbName.AppearancePressed.Image = (CType(resources.GetObject("lbName.Appearance.PressedImage"), System.Drawing.Image))
			Me.lbName.Name = "lbName"
			Me.lbName.StyleController = Me.lcMain
			' 
			' pePhoto
			' 
			resources.ApplyResources(Me.pePhoto, "pePhoto")
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AccessibleDescription = resources.GetString("pePhoto.Properties.AccessibleDescription")
			Me.pePhoto.Properties.AccessibleName = resources.GetString("pePhoto.Properties.AccessibleName")
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.pePhoto.Properties.ReadOnly = True
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.StyleController = Me.lcMain
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pePhoto.Resize += new System.EventHandler(this.pePhoto_Resize);
			' 
			' lcgMain
			' 
			resources.ApplyResources(Me.lcgMain, "lcgMain")
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPhoto, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(227, 397)
			Me.lcgMain.TextVisible = False
			' 
			' lciPhoto
			' 
			resources.ApplyResources(Me.lciPhoto, "lciPhoto")
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 0, 0)
			Me.lciPhoto.Size = New System.Drawing.Size(227, 222)
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextVisible = False
			' 
			' layoutControlItem2
			' 
			resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
			Me.layoutControlItem2.Control = Me.teBirthDate
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 251)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(58, 13)
			' 
			' layoutControlItem3
			' 
			resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
			Me.layoutControlItem3.Control = Me.teEmail
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 275)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(58, 13)
			' 
			' layoutControlItem4
			' 
			resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
			Me.layoutControlItem4.Control = Me.tePhone
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 299)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(58, 13)
			' 
			' layoutControlItem5
			' 
			resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
			Me.layoutControlItem5.Control = Me.teAddress
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 323)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(227, 40)
			Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(58, 13)
			' 
			' layoutControlItem6
			' 
			resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
			Me.layoutControlItem6.Control = Me.teNotes
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 363)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0)
			Me.layoutControlItem6.Size = New System.Drawing.Size(227, 34)
			Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(58, 13)
			' 
			' layoutControlItem1
			' 
			resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
			Me.layoutControlItem1.Control = Me.lbName
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 222)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(227, 29)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' ucContactInfo
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucContactInfo"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents pePhoto As PictureEditSimpleZoom
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private teAddress As XtraEditors.TextEdit
		Private tePhone As XtraEditors.TextEdit
		Private WithEvents teEmail As XtraEditors.HyperLinkEdit
		Private teBirthDate As XtraEditors.TextEdit
		Private lbName As XtraEditors.LabelControl
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private teNotes As XtraEditors.MemoEdit
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
	End Class
End Namespace

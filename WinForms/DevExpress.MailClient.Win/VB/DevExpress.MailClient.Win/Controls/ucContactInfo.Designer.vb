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
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            DirectCast(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lcMain
            ' 
            resources.ApplyResources(Me.lcMain, "lcMain")
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.Appearance.DisabledLayoutGroupCaption.Image = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.lcMain.Appearance.DisabledLayoutItem.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.lcMain.Appearance.DisabledLayoutItem.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.Appearance.DisabledLayoutItem.GradientMode = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.Appearance.DisabledLayoutItem.Image = (DirectCast(resources.GetObject("lcMain.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.lcMain.Controls.Add(Me.teNotes)
            Me.lcMain.Controls.Add(Me.teAddress)
            Me.lcMain.Controls.Add(Me.tePhone)
            Me.lcMain.Controls.Add(Me.teEmail)
            Me.lcMain.Controls.Add(Me.teBirthDate)
            Me.lcMain.Controls.Add(Me.lbName)
            Me.lcMain.Controls.Add(Me.pePhoto)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(669, 200, 450, 350)
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.OptionsPrint.AppearanceGroupCaption.Image = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.GradientMode = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lcMain.OptionsPrint.AppearanceItemCaption.Image = (DirectCast(resources.GetObject("lcMain.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
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
            Me.teNotes.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("teNotes.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teNotes.Properties.ReadOnly = True
            Me.teNotes.StyleController = Me.lcMain
            ' 
            ' teAddress
            ' 
            resources.ApplyResources(Me.teAddress, "teAddress")
            Me.teAddress.Name = "teAddress"
            Me.teAddress.Properties.AccessibleDescription = resources.GetString("teAddress.Properties.AccessibleDescription")
            Me.teAddress.Properties.AccessibleName = resources.GetString("teAddress.Properties.AccessibleName")
            Me.teAddress.Properties.AutoHeight = (DirectCast(resources.GetObject("teAddress.Properties.AutoHeight"), Boolean))
            Me.teAddress.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("teAddress.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.teAddress.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("teAddress.Properties.Mask.BeepOnError"), Boolean))
            Me.teAddress.Properties.Mask.EditMask = resources.GetString("teAddress.Properties.Mask.EditMask")
            Me.teAddress.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("teAddress.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.teAddress.Properties.Mask.MaskType = (DirectCast(resources.GetObject("teAddress.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teAddress.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("teAddress.Properties.Mask.PlaceHolder"), Char))
            Me.teAddress.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("teAddress.Properties.Mask.SaveLiteral"), Boolean))
            Me.teAddress.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("teAddress.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.teAddress.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("teAddress.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.teAddress.Properties.NullValuePrompt = resources.GetString("teAddress.Properties.NullValuePrompt")
            Me.teAddress.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("teAddress.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teAddress.Properties.ReadOnly = True
            Me.teAddress.StyleController = Me.lcMain
            ' 
            ' tePhone
            ' 
            resources.ApplyResources(Me.tePhone, "tePhone")
            Me.tePhone.Name = "tePhone"
            Me.tePhone.Properties.AccessibleDescription = resources.GetString("tePhone.Properties.AccessibleDescription")
            Me.tePhone.Properties.AccessibleName = resources.GetString("tePhone.Properties.AccessibleName")
            Me.tePhone.Properties.AutoHeight = (DirectCast(resources.GetObject("tePhone.Properties.AutoHeight"), Boolean))
            Me.tePhone.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("tePhone.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.tePhone.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("tePhone.Properties.Mask.BeepOnError"), Boolean))
            Me.tePhone.Properties.Mask.EditMask = resources.GetString("tePhone.Properties.Mask.EditMask")
            Me.tePhone.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("tePhone.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.tePhone.Properties.Mask.MaskType = (DirectCast(resources.GetObject("tePhone.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.tePhone.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("tePhone.Properties.Mask.PlaceHolder"), Char))
            Me.tePhone.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("tePhone.Properties.Mask.SaveLiteral"), Boolean))
            Me.tePhone.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("tePhone.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.tePhone.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("tePhone.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.tePhone.Properties.NullValuePrompt = resources.GetString("tePhone.Properties.NullValuePrompt")
            Me.tePhone.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("tePhone.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.tePhone.Properties.ReadOnly = True
            Me.tePhone.StyleController = Me.lcMain
            ' 
            ' teEmail
            ' 
            resources.ApplyResources(Me.teEmail, "teEmail")
            Me.teEmail.Name = "teEmail"
            Me.teEmail.Properties.AccessibleDescription = resources.GetString("teEmail.Properties.AccessibleDescription")
            Me.teEmail.Properties.AccessibleName = resources.GetString("teEmail.Properties.AccessibleName")
            Me.teEmail.Properties.AutoHeight = (DirectCast(resources.GetObject("teEmail.Properties.AutoHeight"), Boolean))
            Me.teEmail.Properties.Caption = resources.GetString("teEmail.Properties.Caption")
            Me.teEmail.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("teEmail.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.teEmail.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("teEmail.Properties.Mask.BeepOnError"), Boolean))
            Me.teEmail.Properties.Mask.EditMask = resources.GetString("teEmail.Properties.Mask.EditMask")
            Me.teEmail.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("teEmail.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.teEmail.Properties.Mask.MaskType = (DirectCast(resources.GetObject("teEmail.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teEmail.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("teEmail.Properties.Mask.PlaceHolder"), Char))
            Me.teEmail.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("teEmail.Properties.Mask.SaveLiteral"), Boolean))
            Me.teEmail.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("teEmail.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.teEmail.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("teEmail.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.teEmail.Properties.NullValuePrompt = resources.GetString("teEmail.Properties.NullValuePrompt")
            Me.teEmail.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("teEmail.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teEmail.Properties.ReadOnly = True
            Me.teEmail.StyleController = Me.lcMain
            ' 
            ' teBirthDate
            ' 
            resources.ApplyResources(Me.teBirthDate, "teBirthDate")
            Me.teBirthDate.Name = "teBirthDate"
            Me.teBirthDate.Properties.AccessibleDescription = resources.GetString("teBirthDate.Properties.AccessibleDescription")
            Me.teBirthDate.Properties.AccessibleName = resources.GetString("teBirthDate.Properties.AccessibleName")
            Me.teBirthDate.Properties.AutoHeight = (DirectCast(resources.GetObject("teBirthDate.Properties.AutoHeight"), Boolean))
            Me.teBirthDate.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.teBirthDate.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.BeepOnError"), Boolean))
            Me.teBirthDate.Properties.Mask.EditMask = resources.GetString("teBirthDate.Properties.Mask.EditMask")
            Me.teBirthDate.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.teBirthDate.Properties.Mask.MaskType = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teBirthDate.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.PlaceHolder"), Char))
            Me.teBirthDate.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.SaveLiteral"), Boolean))
            Me.teBirthDate.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.teBirthDate.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("teBirthDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.teBirthDate.Properties.NullValuePrompt = resources.GetString("teBirthDate.Properties.NullValuePrompt")
            Me.teBirthDate.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("teBirthDate.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teBirthDate.Properties.ReadOnly = True
            Me.teBirthDate.StyleController = Me.lcMain
            ' 
            ' lbName
            ' 
            resources.ApplyResources(Me.lbName, "lbName")
            Me.lbName.AppearanceDisabled.Image = (DirectCast(resources.GetObject("lbName.Appearance.DisabledImage"), System.Drawing.Image))
            Me.lbName.Appearance.Font = (DirectCast(resources.GetObject("lbName.Appearance.Font"), System.Drawing.Font))
            Me.lbName.Appearance.FontSizeDelta = (DirectCast(resources.GetObject("lbName.Appearance.FontSizeDelta"), Integer))
            Me.lbName.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("lbName.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.lbName.Appearance.GradientMode = (DirectCast(resources.GetObject("lbName.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.lbName.AppearanceHovered.Image = (DirectCast(resources.GetObject("lbName.Appearance.HoverImage"), System.Drawing.Image))
            Me.lbName.Appearance.Image = (DirectCast(resources.GetObject("lbName.Appearance.Image"), System.Drawing.Image))
            Me.lbName.AppearancePressed.Image = (DirectCast(resources.GetObject("lbName.Appearance.PressedImage"), System.Drawing.Image))
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
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            DirectCast(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
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

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmEditContact
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmEditContact))
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.tePhone = New DevExpress.XtraEditors.TextEdit()
            Me.teZip = New DevExpress.XtraEditors.TextEdit()
            Me.meLine = New DevExpress.XtraEditors.MemoEdit()
            Me.teLastName = New DevExpress.XtraEditors.TextEdit()
            Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
            Me.teMiddleName = New DevExpress.XtraEditors.TextEdit()
            Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
            Me.icbTitle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
            Me.cbeCity = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbeState = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.teEmail = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.deBirthDate = New DevExpress.XtraEditors.DateEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciMiddleName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTitle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciNotes = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgAddress = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciLine = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciState = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciZip = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lcgInfo = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciEmail = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciBirthDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teZip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.meLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teMiddleName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbeCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbeState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deBirthDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciMiddleName, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciNotes, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcgAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLine, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciCity, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciState, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciZip, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciEmail, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lcMain
            ' 
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.memoEdit1)
            Me.lcMain.Controls.Add(Me.sbCancel)
            Me.lcMain.Controls.Add(Me.tePhone)
            Me.lcMain.Controls.Add(Me.teZip)
            Me.lcMain.Controls.Add(Me.meLine)
            Me.lcMain.Controls.Add(Me.teLastName)
            Me.lcMain.Controls.Add(Me.sbOK)
            Me.lcMain.Controls.Add(Me.teMiddleName)
            Me.lcMain.Controls.Add(Me.teFirstName)
            Me.lcMain.Controls.Add(Me.icbTitle)
            Me.lcMain.Controls.Add(Me.pePhoto)
            Me.lcMain.Controls.Add(Me.cbeCity)
            Me.lcMain.Controls.Add(Me.cbeState)
            Me.lcMain.Controls.Add(Me.teEmail)
            Me.lcMain.Controls.Add(Me.deBirthDate)
            resources.ApplyResources(Me.lcMain, "lcMain")
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1062, 287, 450, 596)
            Me.lcMain.Root = Me.layoutControlGroup1
            ' 
            ' memoEdit1
            ' 
            resources.ApplyResources(Me.memoEdit1, "memoEdit1")
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.StyleController = Me.lcMain
            ' 
            ' sbCancel
            ' 
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            resources.ApplyResources(Me.sbCancel, "sbCancel")
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.StyleController = Me.lcMain
            ' 
            ' tePhone
            ' 
            resources.ApplyResources(Me.tePhone, "tePhone")
            Me.tePhone.Name = "tePhone"
            Me.tePhone.Properties.Mask.EditMask = resources.GetString("tePhone.Properties.Mask.EditMask")
            Me.tePhone.Properties.Mask.MaskType = (DirectCast(resources.GetObject("tePhone.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.tePhone.StyleController = Me.lcMain
            ' 
            ' teZip
            ' 
            resources.ApplyResources(Me.teZip, "teZip")
            Me.teZip.Name = "teZip"
            Me.teZip.Properties.Mask.EditMask = resources.GetString("teZip.Properties.Mask.EditMask")
            Me.teZip.Properties.Mask.MaskType = (DirectCast(resources.GetObject("teZip.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teZip.StyleController = Me.lcMain
            ' 
            ' meLine
            ' 
            resources.ApplyResources(Me.meLine, "meLine")
            Me.meLine.Name = "meLine"
            Me.meLine.StyleController = Me.lcMain
            ' 
            ' teLastName
            ' 
            resources.ApplyResources(Me.teLastName, "teLastName")
            Me.teLastName.Name = "teLastName"
            Me.teLastName.StyleController = Me.lcMain
            ' 
            ' sbOK
            ' 
            Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
            resources.ApplyResources(Me.sbOK, "sbOK")
            Me.sbOK.Name = "sbOK"
            Me.sbOK.StyleController = Me.lcMain
            ' 
            ' teMiddleName
            ' 
            resources.ApplyResources(Me.teMiddleName, "teMiddleName")
            Me.teMiddleName.Name = "teMiddleName"
            Me.teMiddleName.StyleController = Me.lcMain
            ' 
            ' teFirstName
            ' 
            resources.ApplyResources(Me.teFirstName, "teFirstName")
            Me.teFirstName.Name = "teFirstName"
            Me.teFirstName.StyleController = Me.lcMain
            ' 
            ' icbTitle
            ' 
            resources.ApplyResources(Me.icbTitle, "icbTitle")
            Me.icbTitle.Name = "icbTitle"
            Me.icbTitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbTitle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbTitle.StyleController = Me.lcMain
            ' 
            ' pePhoto
            ' 
            Me.pePhoto.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.pePhoto, "pePhoto")
            Me.pePhoto.Name = "pePhoto"
            Me.pePhoto.Properties.AllowFocused = False
            Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pePhoto.StyleController = Me.lcMain
            ' 
            ' cbeCity
            ' 
            resources.ApplyResources(Me.cbeCity, "cbeCity")
            Me.cbeCity.Name = "cbeCity"
            Me.cbeCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("cbeCity.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.cbeCity.Properties.DropDownRows = 11
            Me.cbeCity.StyleController = Me.lcMain
            ' 
            ' cbeState
            ' 
            resources.ApplyResources(Me.cbeState, "cbeState")
            Me.cbeState.Name = "cbeState"
            Me.cbeState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("cbeState.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.cbeState.Properties.DropDownRows = 11
            Me.cbeState.StyleController = Me.lcMain
            ' 
            ' teEmail
            ' 
            resources.ApplyResources(Me.teEmail, "teEmail")
            Me.teEmail.Name = "teEmail"
            Me.teEmail.Properties.SingleClick = False
            Me.teEmail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.teEmail.StyleController = Me.lcMain
            ' 
            ' deBirthDate
            ' 
            resources.ApplyResources(Me.deBirthDate, "deBirthDate")
            Me.deBirthDate.Name = "deBirthDate"
            Me.deBirthDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("deBirthDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.deBirthDate.Properties.Mask.EditMask = resources.GetString("deBirthDate.Properties.Mask.EditMask")
            Me.deBirthDate.Properties.Mask.MaskType = (DirectCast(resources.GetObject("deBirthDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.deBirthDate.StyleController = Me.lcMain
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciFirstName, Me.lciMiddleName, Me.lciLastName, Me.lciTitle, Me.lciPhoto, Me.emptySpaceItem3, Me.emptySpaceItem2, Me.layoutControlItem2, Me.layoutControlItem1, Me.splitterItem1, Me.emptySpaceItem5, Me.lciNotes, Me.lcgAddress, Me.lcgInfo})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(901, 564)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciFirstName
            ' 
            Me.lciFirstName.Control = Me.teFirstName
            resources.ApplyResources(Me.lciFirstName, "lciFirstName")
            Me.lciFirstName.Location = New System.Drawing.Point(314, 0)
            Me.lciFirstName.Name = "lciFirstName"
            Me.lciFirstName.Size = New System.Drawing.Size(567, 24)
            Me.lciFirstName.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciMiddleName
            ' 
            Me.lciMiddleName.Control = Me.teMiddleName
            resources.ApplyResources(Me.lciMiddleName, "lciMiddleName")
            Me.lciMiddleName.Location = New System.Drawing.Point(314, 24)
            Me.lciMiddleName.Name = "lciMiddleName"
            Me.lciMiddleName.Size = New System.Drawing.Size(567, 24)
            Me.lciMiddleName.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciLastName
            ' 
            Me.lciLastName.Control = Me.teLastName
            resources.ApplyResources(Me.lciLastName, "lciLastName")
            Me.lciLastName.Location = New System.Drawing.Point(314, 48)
            Me.lciLastName.Name = "lciLastName"
            Me.lciLastName.Size = New System.Drawing.Size(567, 24)
            Me.lciLastName.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciTitle
            ' 
            Me.lciTitle.Control = Me.icbTitle
            resources.ApplyResources(Me.lciTitle, "lciTitle")
            Me.lciTitle.Location = New System.Drawing.Point(314, 72)
            Me.lciTitle.Name = "lciTitle"
            Me.lciTitle.Size = New System.Drawing.Size(285, 24)
            Me.lciTitle.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciPhoto
            ' 
            Me.lciPhoto.Control = Me.pePhoto
            resources.ApplyResources(Me.lciPhoto, "lciPhoto")
            Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
            Me.lciPhoto.Name = "lciPhoto"
            Me.lciPhoto.Size = New System.Drawing.Size(309, 384)
            Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPhoto.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 512)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 6)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 6)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.emptySpaceItem3.Size = New System.Drawing.Size(881, 6)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 518)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(696, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.sbCancel
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(784, 518)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(97, 26)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.sbOK
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(696, 518)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(88, 26)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(309, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 384)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem5, "emptySpaceItem5")
            Me.emptySpaceItem5.Location = New System.Drawing.Point(599, 72)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(282, 24)
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciNotes
            ' 
            Me.lciNotes.Control = Me.memoEdit1
            resources.ApplyResources(Me.lciNotes, "lciNotes")
            Me.lciNotes.Location = New System.Drawing.Point(0, 384)
            Me.lciNotes.Name = "lciNotes"
            Me.lciNotes.Size = New System.Drawing.Size(881, 128)
            Me.lciNotes.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciNotes.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lcgAddress
            ' 
            resources.ApplyResources(Me.lcgAddress, "lcgAddress")
            Me.lcgAddress.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciLine, Me.lciCity, Me.lciState, Me.lciZip, Me.emptySpaceItem4})
            Me.lcgAddress.Location = New System.Drawing.Point(314, 96)
            Me.lcgAddress.Name = "lcgAddress"
            Me.lcgAddress.Size = New System.Drawing.Size(567, 139)
            ' 
            ' lciLine
            ' 
            Me.lciLine.AppearanceItemCaption.Options.UseTextOptions = True
            Me.lciLine.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lciLine.Control = Me.meLine
            resources.ApplyResources(Me.lciLine, "lciLine")
            Me.lciLine.Location = New System.Drawing.Point(0, 0)
            Me.lciLine.Name = "lciLine"
            Me.lciLine.Size = New System.Drawing.Size(543, 49)
            Me.lciLine.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciCity
            ' 
            Me.lciCity.Control = Me.cbeCity
            resources.ApplyResources(Me.lciCity, "lciCity")
            Me.lciCity.Location = New System.Drawing.Point(0, 49)
            Me.lciCity.Name = "lciCity"
            Me.lciCity.Size = New System.Drawing.Size(273, 24)
            Me.lciCity.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciState
            ' 
            Me.lciState.Control = Me.cbeState
            resources.ApplyResources(Me.lciState, "lciState")
            Me.lciState.Location = New System.Drawing.Point(0, 73)
            Me.lciState.Name = "lciState"
            Me.lciState.Size = New System.Drawing.Size(273, 24)
            Me.lciState.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciZip
            ' 
            Me.lciZip.AppearanceItemCaption.Options.UseTextOptions = True
            Me.lciZip.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.lciZip.Control = Me.teZip
            resources.ApplyResources(Me.lciZip, "lciZip")
            Me.lciZip.Location = New System.Drawing.Point(273, 73)
            Me.lciZip.Name = "lciZip"
            Me.lciZip.Size = New System.Drawing.Size(270, 24)
            Me.lciZip.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem4, "emptySpaceItem4")
            Me.emptySpaceItem4.Location = New System.Drawing.Point(273, 49)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(270, 24)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lcgInfo
            ' 
            resources.ApplyResources(Me.lcgInfo, "lcgInfo")
            Me.lcgInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciEmail, Me.lciPhone, Me.lciBirthDate, Me.emptySpaceItem6, Me.emptySpaceItem7, Me.emptySpaceItem1, Me.emptySpaceItem8})
            Me.lcgInfo.Location = New System.Drawing.Point(314, 235)
            Me.lcgInfo.Name = "lcgInfo"
            Me.lcgInfo.Size = New System.Drawing.Size(567, 149)
            ' 
            ' lciEmail
            ' 
            Me.lciEmail.Control = Me.teEmail
            resources.ApplyResources(Me.lciEmail, "lciEmail")
            Me.lciEmail.Location = New System.Drawing.Point(0, 0)
            Me.lciEmail.Name = "lciEmail"
            Me.lciEmail.Size = New System.Drawing.Size(543, 24)
            Me.lciEmail.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciPhone
            ' 
            Me.lciPhone.Control = Me.tePhone
            resources.ApplyResources(Me.lciPhone, "lciPhone")
            Me.lciPhone.Location = New System.Drawing.Point(0, 24)
            Me.lciPhone.Name = "lciPhone"
            Me.lciPhone.Size = New System.Drawing.Size(273, 24)
            Me.lciPhone.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' lciBirthDate
            ' 
            Me.lciBirthDate.Control = Me.deBirthDate
            resources.ApplyResources(Me.lciBirthDate, "lciBirthDate")
            Me.lciBirthDate.Location = New System.Drawing.Point(0, 48)
            Me.lciBirthDate.Name = "lciBirthDate"
            Me.lciBirthDate.Size = New System.Drawing.Size(273, 24)
            Me.lciBirthDate.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem6, "emptySpaceItem6")
            Me.emptySpaceItem6.Location = New System.Drawing.Point(273, 48)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(270, 24)
            Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem7, "emptySpaceItem7")
            Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 96)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(543, 11)
            Me.emptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(543, 24)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem8
            ' 
            Me.emptySpaceItem8.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem8, "emptySpaceItem8")
            Me.emptySpaceItem8.Location = New System.Drawing.Point(273, 24)
            Me.emptySpaceItem8.Name = "emptySpaceItem8"
            Me.emptySpaceItem8.Size = New System.Drawing.Size(270, 24)
            Me.emptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' dxValidationProvider1
            ' 
            Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
            ' 
            ' frmEditContact
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lcMain)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Name = "frmEditContact"
            DirectCast(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teZip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.meLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teMiddleName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbeCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbeState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deBirthDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciMiddleName, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciTitle, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciNotes, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcgAddress, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLine, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciCity, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciState, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciZip, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcgInfo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciEmail, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private lcMain As DevExpress.XtraLayout.LayoutControl
        Private teLastName As DevExpress.XtraEditors.TextEdit
        Private teMiddleName As DevExpress.XtraEditors.TextEdit
        Private teFirstName As DevExpress.XtraEditors.TextEdit
        Private pePhoto As DevExpress.XtraEditors.PictureEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
        Private lciFirstName As DevExpress.XtraLayout.LayoutControlItem
        Private lciMiddleName As DevExpress.XtraLayout.LayoutControlItem
        Private lciLastName As DevExpress.XtraLayout.LayoutControlItem
        Private tePhone As DevExpress.XtraEditors.TextEdit
        Private teZip As DevExpress.XtraEditors.TextEdit
        Private meLine As DevExpress.XtraEditors.MemoEdit
        Private lciTitle As DevExpress.XtraLayout.LayoutControlItem
        Private icbTitle As DevExpress.XtraEditors.ImageComboBoxEdit
        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
        Private cbeCity As DevExpress.XtraEditors.ComboBoxEdit
        Private cbeState As DevExpress.XtraEditors.ComboBoxEdit
        Private teEmail As DevExpress.XtraEditors.HyperLinkEdit
        Private deBirthDate As DevExpress.XtraEditors.DateEdit
        Private WithEvents sbOK As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private sbCancel As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
        Private memoEdit1 As XtraEditors.MemoEdit
        Private lciNotes As XtraLayout.LayoutControlItem
        Private lcgAddress As XtraLayout.LayoutControlGroup
        Private lciLine As XtraLayout.LayoutControlItem
        Private lciCity As XtraLayout.LayoutControlItem
        Private lciState As XtraLayout.LayoutControlItem
        Private lciZip As XtraLayout.LayoutControlItem
        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
        Private lcgInfo As XtraLayout.LayoutControlGroup
        Private lciEmail As XtraLayout.LayoutControlItem
        Private lciPhone As XtraLayout.LayoutControlItem
        Private lciBirthDate As XtraLayout.LayoutControlItem
        Private emptySpaceItem6 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem7 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem8 As XtraLayout.EmptySpaceItem
    End Class
End Namespace

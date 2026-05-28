Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class RentalDetailsForm
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
			Me.timeEnd = New DevExpress.XtraEditors.TimeEdit()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
			Me.chkActiveRental = New DevExpress.XtraEditors.CheckEdit()
			Me.txSubject = New DevExpress.XtraEditors.TextEdit()
			Me.txtOverduePayment = New DevExpress.XtraEditors.TextEdit()
			Me.txMovieLanguage = New DevExpress.XtraEditors.TextEdit()
			Me.edtDescription = New DevExpress.XtraEditors.MemoEdit()
			Me.txtPayment = New DevExpress.XtraEditors.TextEdit()
			Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
			Me.dtStart = New DevExpress.XtraEditors.DateEdit()
			Me.timeStart = New DevExpress.XtraEditors.TimeEdit()
			Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.chkRentOverdue = New DevExpress.XtraEditors.CheckEdit()
			Me.txtFormat = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciMovieTitle = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciFormat = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRentedOn = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRentedOn2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciReturnedOn = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciReturnedOn2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPayment = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciOverduePayment = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRentOverdue = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCustomer = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciActiveRent = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lciLanguage = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.simpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
			CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkActiveRental.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOverduePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txMovieLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkRentOverdue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMovieTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFormat, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRentedOn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRentedOn2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciReturnedOn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciReturnedOn2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPayment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciOverduePayment, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRentOverdue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciActiveRent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' timeEnd
			' 
			Me.timeEnd.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
			Me.timeEnd.Enabled = False
			Me.timeEnd.Location = New System.Drawing.Point(492, 242)
			Me.timeEnd.Name = "timeEnd"
			Me.timeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeEnd.Properties.ReadOnly = True
			Me.timeEnd.Size = New System.Drawing.Size(113, 20)
			Me.timeEnd.StyleController = Me.lcMain
			Me.timeEnd.TabIndex = 22
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Controls.Add(Me.btnClose)
			Me.lcMain.Controls.Add(Me.chkActiveRental)
			Me.lcMain.Controls.Add(Me.txSubject)
			Me.lcMain.Controls.Add(Me.txtOverduePayment)
			Me.lcMain.Controls.Add(Me.txMovieLanguage)
			Me.lcMain.Controls.Add(Me.edtDescription)
			Me.lcMain.Controls.Add(Me.txtPayment)
			Me.lcMain.Controls.Add(Me.edtResource)
			Me.lcMain.Controls.Add(Me.dtStart)
			Me.lcMain.Controls.Add(Me.timeStart)
			Me.lcMain.Controls.Add(Me.dtEnd)
			Me.lcMain.Controls.Add(Me.timeEnd)
			Me.lcMain.Controls.Add(Me.chkRentOverdue)
			Me.lcMain.Controls.Add(Me.txtFormat)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(12, 12)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(607, 410)
			Me.lcMain.TabIndex = 59
			Me.lcMain.Text = "layoutControl1"
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(2, 2)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.pePhoto.Properties.Appearance.Options.UseBackColor = True
			Me.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(214, 352)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 4
			' 
			' btnClose
			' 
			Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnClose.Location = New System.Drawing.Point(499, 386)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New System.Drawing.Size(106, 22)
			Me.btnClose.StyleController = Me.lcMain
			Me.btnClose.TabIndex = 30
			Me.btnClose.Text = "&Close"
			' 
			' chkActiveRental
			' 
			Me.chkActiveRental.Enabled = False
			Me.chkActiveRental.Location = New System.Drawing.Point(2, 386)
			Me.chkActiveRental.Name = "chkActiveRental"
			Me.chkActiveRental.Properties.AccessibleName = "All day event"
			Me.chkActiveRental.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
			Me.chkActiveRental.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.chkActiveRental.Properties.Appearance.Options.UseFont = True
			Me.chkActiveRental.Properties.AutoWidth = True
			Me.chkActiveRental.Properties.Caption = "Active Rental"
			Me.chkActiveRental.Properties.ReadOnly = True
			Me.chkActiveRental.Size = New System.Drawing.Size(99, 19)
			Me.chkActiveRental.StyleController = Me.lcMain
			Me.chkActiveRental.TabIndex = 58
			' 
			' txSubject
			' 
			Me.txSubject.EditValue = ""
			Me.txSubject.Enabled = False
			Me.txSubject.Location = New System.Drawing.Point(327, 2)
			Me.txSubject.Name = "txSubject"
			Me.txSubject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.txSubject.Properties.Appearance.Options.UseFont = True
			Me.txSubject.Properties.ReadOnly = True
			Me.txSubject.Size = New System.Drawing.Size(278, 20)
			Me.txSubject.StyleController = Me.lcMain
			Me.txSubject.TabIndex = 17
			' 
			' txtOverduePayment
			' 
			Me.txtOverduePayment.Enabled = False
			Me.txtOverduePayment.Location = New System.Drawing.Point(327, 300)
			Me.txtOverduePayment.Name = "txtOverduePayment"
			Me.txtOverduePayment.Properties.Appearance.Options.UseTextOptions = True
			Me.txtOverduePayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.txtOverduePayment.Properties.DisplayFormat.FormatString = "c"
			Me.txtOverduePayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.txtOverduePayment.Properties.EditFormat.FormatString = "c"
			Me.txtOverduePayment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.txtOverduePayment.Properties.Mask.EditMask = "c"
			Me.txtOverduePayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.txtOverduePayment.Properties.ReadOnly = True
			Me.txtOverduePayment.Size = New System.Drawing.Size(161, 20)
			Me.txtOverduePayment.StyleController = Me.lcMain
			Me.txtOverduePayment.TabIndex = 55
			' 
			' txMovieLanguage
			' 
			Me.txMovieLanguage.EditValue = ""
			Me.txMovieLanguage.Enabled = False
			Me.txMovieLanguage.Location = New System.Drawing.Point(327, 50)
			Me.txMovieLanguage.Name = "txMovieLanguage"
			Me.txMovieLanguage.Properties.ReadOnly = True
			Me.txMovieLanguage.Size = New System.Drawing.Size(278, 20)
			Me.txMovieLanguage.StyleController = Me.lcMain
			Me.txMovieLanguage.TabIndex = 46
			' 
			' edtDescription
			' 
			Me.edtDescription.Enabled = False
			Me.edtDescription.Location = New System.Drawing.Point(327, 74)
			Me.edtDescription.MinimumSize = New System.Drawing.Size(0, 32)
			Me.edtDescription.Name = "edtDescription"
			Me.edtDescription.Properties.ReadOnly = True
			Me.edtDescription.Size = New System.Drawing.Size(278, 82)
			Me.edtDescription.StyleController = Me.lcMain
			Me.edtDescription.TabIndex = 50
			' 
			' txtPayment
			' 
			Me.txtPayment.Enabled = False
			Me.txtPayment.Location = New System.Drawing.Point(327, 276)
			Me.txtPayment.Name = "txtPayment"
			Me.txtPayment.Properties.Appearance.Options.UseTextOptions = True
			Me.txtPayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.txtPayment.Properties.DisplayFormat.FormatString = "c"
			Me.txtPayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.txtPayment.Properties.EditFormat.FormatString = "c"
			Me.txtPayment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.txtPayment.Properties.Mask.EditMask = "c"
			Me.txtPayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.txtPayment.Properties.ReadOnly = True
			Me.txtPayment.Size = New System.Drawing.Size(161, 20)
			Me.txtPayment.StyleController = Me.lcMain
			Me.txtPayment.TabIndex = 53
			' 
			' edtResource
			' 
			Me.edtResource.Enabled = False
			Me.edtResource.Location = New System.Drawing.Point(327, 334)
			Me.edtResource.Name = "edtResource"
			Me.edtResource.Properties.AccessibleName = "Owner:"
			Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
			Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtResource.Properties.ReadOnly = True
			Me.edtResource.Size = New System.Drawing.Size(278, 20)
			Me.edtResource.StyleController = Me.lcMain
			Me.edtResource.TabIndex = 43
			' 
			' dtStart
			' 
			Me.dtStart.EditValue = Nothing
			Me.dtStart.Enabled = False
			Me.dtStart.Location = New System.Drawing.Point(327, 218)
			Me.dtStart.Name = "dtStart"
			Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dtStart.Properties.ReadOnly = True
			Me.dtStart.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
			Me.dtStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
'			Me.dtStart.Properties.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.dtStart_Properties_QueryPopUp);
			Me.dtStart.Size = New System.Drawing.Size(161, 20)
			Me.dtStart.StyleController = Me.lcMain
			Me.dtStart.TabIndex = 18
			' 
			' timeStart
			' 
			Me.timeStart.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
			Me.timeStart.Enabled = False
			Me.timeStart.Location = New System.Drawing.Point(492, 218)
			Me.timeStart.Name = "timeStart"
			Me.timeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeStart.Properties.ReadOnly = True
			Me.timeStart.Size = New System.Drawing.Size(113, 20)
			Me.timeStart.StyleController = Me.lcMain
			Me.timeStart.TabIndex = 19
			' 
			' dtEnd
			' 
			Me.dtEnd.EditValue = Nothing
			Me.dtEnd.Enabled = False
			Me.dtEnd.Location = New System.Drawing.Point(327, 242)
			Me.dtEnd.Name = "dtEnd"
			Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dtEnd.Properties.ReadOnly = True
			Me.dtEnd.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
			Me.dtEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dtEnd.Size = New System.Drawing.Size(161, 20)
			Me.dtEnd.StyleController = Me.lcMain
			Me.dtEnd.TabIndex = 20
'			Me.dtEnd.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.dtStart_Properties_QueryPopUp);
			' 
			' chkRentOverdue
			' 
			Me.chkRentOverdue.Enabled = False
			Me.chkRentOverdue.Location = New System.Drawing.Point(492, 300)
			Me.chkRentOverdue.Name = "chkRentOverdue"
			Me.chkRentOverdue.Properties.AccessibleName = "All day event"
			Me.chkRentOverdue.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
			Me.chkRentOverdue.Properties.AutoWidth = True
			Me.chkRentOverdue.Properties.Caption = "Rent Overdue"
			Me.chkRentOverdue.Properties.ReadOnly = True
			Me.chkRentOverdue.Size = New System.Drawing.Size(91, 19)
			Me.chkRentOverdue.StyleController = Me.lcMain
			Me.chkRentOverdue.TabIndex = 44
			' 
			' txtFormat
			' 
			Me.txtFormat.EditValue = ""
			Me.txtFormat.Enabled = False
			Me.txtFormat.Location = New System.Drawing.Point(327, 26)
			Me.txtFormat.Name = "txtFormat"
			Me.txtFormat.Properties.ReadOnly = True
			Me.txtFormat.Size = New System.Drawing.Size(278, 20)
			Me.txtFormat.StyleController = Me.lcMain
			Me.txtFormat.TabIndex = 57
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "Root"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPhoto, Me.lciMovieTitle, Me.lciFormat, Me.lciDescription, Me.lciRentedOn, Me.lciRentedOn2, Me.lciReturnedOn, Me.lciReturnedOn2, Me.lciPayment, Me.lciOverduePayment, Me.lciRentOverdue, Me.lciCustomer, Me.lciActiveRent, Me.layoutControlItem2, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.lciLanguage, Me.emptySpaceItem5, Me.emptySpaceItem1, Me.emptySpaceItem6, Me.emptySpaceItem4, Me.emptySpaceItem7, Me.simpleSeparator2})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(607, 410)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "lciPhoto"
			Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Size = New System.Drawing.Size(218, 356)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' lciMovieTitle
			' 
			Me.lciMovieTitle.Control = Me.txSubject
			Me.lciMovieTitle.CustomizationFormText = "Movie Title:"
			Me.lciMovieTitle.Location = New System.Drawing.Point(230, 0)
			Me.lciMovieTitle.Name = "lciMovieTitle"
			Me.lciMovieTitle.Size = New System.Drawing.Size(377, 24)
			Me.lciMovieTitle.Text = "Movie Title:"
			Me.lciMovieTitle.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciFormat
			' 
			Me.lciFormat.Control = Me.txtFormat
			Me.lciFormat.CustomizationFormText = "Format:"
			Me.lciFormat.Location = New System.Drawing.Point(230, 24)
			Me.lciFormat.Name = "lciFormat"
			Me.lciFormat.Size = New System.Drawing.Size(377, 24)
			Me.lciFormat.Text = "Format:"
			Me.lciFormat.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciDescription
			' 
			Me.lciDescription.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciDescription.Control = Me.edtDescription
			Me.lciDescription.CustomizationFormText = "Description:"
			Me.lciDescription.Location = New System.Drawing.Point(230, 72)
			Me.lciDescription.MinSize = New System.Drawing.Size(95, 52)
			Me.lciDescription.Name = "lciDescription"
			Me.lciDescription.Size = New System.Drawing.Size(377, 86)
			Me.lciDescription.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciDescription.Text = "Description:"
			Me.lciDescription.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciRentedOn
			' 
			Me.lciRentedOn.Control = Me.dtStart
			Me.lciRentedOn.CustomizationFormText = "Rented On:"
			Me.lciRentedOn.Location = New System.Drawing.Point(230, 216)
			Me.lciRentedOn.Name = "lciRentedOn"
			Me.lciRentedOn.Size = New System.Drawing.Size(260, 24)
			Me.lciRentedOn.Text = "Rented On:"
			Me.lciRentedOn.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciRentedOn2
			' 
			Me.lciRentedOn2.Control = Me.timeStart
			Me.lciRentedOn2.CustomizationFormText = "lci"
			Me.lciRentedOn2.Location = New System.Drawing.Point(490, 216)
			Me.lciRentedOn2.Name = "lciRentedOn2"
			Me.lciRentedOn2.Size = New System.Drawing.Size(117, 24)
			Me.lciRentedOn2.Text = "lci"
			Me.lciRentedOn2.TextSize = New System.Drawing.Size(0, 0)
			Me.lciRentedOn2.TextToControlDistance = 0
			Me.lciRentedOn2.TextVisible = False
			' 
			' lciReturnedOn
			' 
			Me.lciReturnedOn.Control = Me.dtEnd
			Me.lciReturnedOn.CustomizationFormText = "Returned On:"
			Me.lciReturnedOn.Location = New System.Drawing.Point(230, 240)
			Me.lciReturnedOn.Name = "lciReturnedOn"
			Me.lciReturnedOn.Size = New System.Drawing.Size(260, 24)
			Me.lciReturnedOn.Text = "Returned On:"
			Me.lciReturnedOn.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciReturnedOn2
			' 
			Me.lciReturnedOn2.Control = Me.timeEnd
			Me.lciReturnedOn2.CustomizationFormText = "lci"
			Me.lciReturnedOn2.Location = New System.Drawing.Point(490, 240)
			Me.lciReturnedOn2.Name = "lciReturnedOn2"
			Me.lciReturnedOn2.Size = New System.Drawing.Size(117, 24)
			Me.lciReturnedOn2.Text = "lci"
			Me.lciReturnedOn2.TextSize = New System.Drawing.Size(0, 0)
			Me.lciReturnedOn2.TextToControlDistance = 0
			Me.lciReturnedOn2.TextVisible = False
			' 
			' lciPayment
			' 
			Me.lciPayment.Control = Me.txtPayment
			Me.lciPayment.CustomizationFormText = "Payment:"
			Me.lciPayment.Location = New System.Drawing.Point(230, 274)
			Me.lciPayment.Name = "lciPayment"
			Me.lciPayment.Size = New System.Drawing.Size(260, 24)
			Me.lciPayment.Text = "Payment:"
			Me.lciPayment.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciOverduePayment
			' 
			Me.lciOverduePayment.Control = Me.txtOverduePayment
			Me.lciOverduePayment.CustomizationFormText = "Overdue Payment:"
			Me.lciOverduePayment.Location = New System.Drawing.Point(230, 298)
			Me.lciOverduePayment.Name = "lciOverduePayment"
			Me.lciOverduePayment.Size = New System.Drawing.Size(260, 24)
			Me.lciOverduePayment.Text = "Overdue Payment:"
			Me.lciOverduePayment.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciRentOverdue
			' 
			Me.lciRentOverdue.Control = Me.chkRentOverdue
			Me.lciRentOverdue.CustomizationFormText = "lciRentOverdue"
			Me.lciRentOverdue.Location = New System.Drawing.Point(490, 298)
			Me.lciRentOverdue.Name = "lciRentOverdue"
			Me.lciRentOverdue.Size = New System.Drawing.Size(117, 24)
			Me.lciRentOverdue.Text = "lciRentOverdue"
			Me.lciRentOverdue.TextSize = New System.Drawing.Size(0, 0)
			Me.lciRentOverdue.TextToControlDistance = 0
			Me.lciRentOverdue.TextVisible = False
			' 
			' lciCustomer
			' 
			Me.lciCustomer.Control = Me.edtResource
			Me.lciCustomer.CustomizationFormText = "Customer:"
			Me.lciCustomer.Location = New System.Drawing.Point(230, 332)
			Me.lciCustomer.Name = "lciCustomer"
			Me.lciCustomer.Size = New System.Drawing.Size(377, 24)
			Me.lciCustomer.Text = "Customer:"
			Me.lciCustomer.TextSize = New System.Drawing.Size(91, 13)
			' 
			' lciActiveRent
			' 
			Me.lciActiveRent.Control = Me.chkActiveRental
			Me.lciActiveRent.CustomizationFormText = "lciActiveRent"
			Me.lciActiveRent.Location = New System.Drawing.Point(0, 384)
			Me.lciActiveRent.Name = "lciActiveRent"
			Me.lciActiveRent.Size = New System.Drawing.Size(497, 26)
			Me.lciActiveRent.Text = "lciActiveRent"
			Me.lciActiveRent.TextSize = New System.Drawing.Size(0, 0)
			Me.lciActiveRent.TextToControlDistance = 0
			Me.lciActiveRent.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.btnClose
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(497, 384)
			Me.layoutControlItem2.MaxSize = New System.Drawing.Size(110, 26)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(110, 26)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(110, 26)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(490, 264)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(117, 34)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(218, 0)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(12, 0)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(12, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(12, 356)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lciLanguage
			' 
			Me.lciLanguage.Control = Me.txMovieLanguage
			Me.lciLanguage.CustomizationFormText = "Language:"
			Me.lciLanguage.Location = New System.Drawing.Point(230, 48)
			Me.lciLanguage.Name = "lciLanguage"
			Me.lciLanguage.Size = New System.Drawing.Size(377, 24)
			Me.lciLanguage.Text = "Language:"
			Me.lciLanguage.TextSize = New System.Drawing.Size(91, 13)
			' 
			' emptySpaceItem5
			' 
			Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
			Me.emptySpaceItem5.Location = New System.Drawing.Point(230, 158)
			Me.emptySpaceItem5.Name = "emptySpaceItem5"
			Me.emptySpaceItem5.Size = New System.Drawing.Size(377, 58)
			Me.emptySpaceItem5.Text = "emptySpaceItem5"
			Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(230, 264)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(260, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem6
			' 
			Me.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6"
			Me.emptySpaceItem6.Location = New System.Drawing.Point(230, 322)
			Me.emptySpaceItem6.Name = "emptySpaceItem6"
			Me.emptySpaceItem6.Size = New System.Drawing.Size(377, 10)
			Me.emptySpaceItem6.Text = "emptySpaceItem6"
			Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem4
			' 
			Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
			Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 356)
			Me.emptySpaceItem4.Name = "emptySpaceItem4"
			Me.emptySpaceItem4.Size = New System.Drawing.Size(607, 14)
			Me.emptySpaceItem4.Text = "emptySpaceItem4"
			Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem7
			' 
			Me.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7"
			Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 372)
			Me.emptySpaceItem7.Name = "emptySpaceItem7"
			Me.emptySpaceItem7.Size = New System.Drawing.Size(607, 12)
			Me.emptySpaceItem7.Text = "emptySpaceItem7"
			Me.emptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
			' 
			' simpleSeparator2
			' 
			Me.simpleSeparator2.CustomizationFormText = "simpleSeparator2"
			Me.simpleSeparator2.Location = New System.Drawing.Point(0, 370)
			Me.simpleSeparator2.Name = "simpleSeparator2"
			Me.simpleSeparator2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
			Me.simpleSeparator2.Size = New System.Drawing.Size(607, 2)
			Me.simpleSeparator2.Text = "simpleSeparator2"
			' 
			' RentalDetailsForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnClose
			Me.ClientSize = New System.Drawing.Size(631, 434)
			Me.Controls.Add(Me.lcMain)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "RentalDetailsForm"
			Me.Padding = New System.Windows.Forms.Padding(12)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Rental Details (Read Only)"
'			Me.Load += New System.EventHandler(Me.CustomAppointmentForm_Load);
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.CustomAppointmentForm_FormClosing);
			CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkActiveRental.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOverduePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txMovieLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkRentOverdue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMovieTitle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFormat, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRentedOn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRentedOn2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciReturnedOn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciReturnedOn2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPayment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciOverduePayment, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRentOverdue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCustomer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciActiveRent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLanguage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private timeEnd As DevExpress.XtraEditors.TimeEdit
		Private timeStart As DevExpress.XtraEditors.TimeEdit
		Private WithEvents dtEnd As DevExpress.XtraEditors.DateEdit
		Private WithEvents dtStart As DevExpress.XtraEditors.DateEdit
		Private txSubject As DevExpress.XtraEditors.TextEdit
		Private btnClose As DevExpress.XtraEditors.SimpleButton
		Protected edtResource As DevExpress.XtraScheduler.UI.AppointmentResourceEdit
		Protected chkRentOverdue As DevExpress.XtraEditors.CheckEdit
		Private txMovieLanguage As DevExpress.XtraEditors.TextEdit
		Private edtDescription As DevExpress.XtraEditors.MemoEdit
		Private txtPayment As DevExpress.XtraEditors.TextEdit
		Private txtOverduePayment As DevExpress.XtraEditors.TextEdit
		Protected chkActiveRental As DevExpress.XtraEditors.CheckEdit
		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private pePhoto As DevExpress.XtraEditors.PictureEdit
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private lciMovieTitle As DevExpress.XtraLayout.LayoutControlItem
		Private lciFormat As DevExpress.XtraLayout.LayoutControlItem
		Private lciLanguage As DevExpress.XtraLayout.LayoutControlItem
		Private lciDescription As DevExpress.XtraLayout.LayoutControlItem
		Private lciRentedOn As DevExpress.XtraLayout.LayoutControlItem
		Private lciRentedOn2 As DevExpress.XtraLayout.LayoutControlItem
		Private lciReturnedOn As DevExpress.XtraLayout.LayoutControlItem
		Private lciReturnedOn2 As DevExpress.XtraLayout.LayoutControlItem
		Private lciPayment As DevExpress.XtraLayout.LayoutControlItem
		Private lciOverduePayment As DevExpress.XtraLayout.LayoutControlItem
		Private lciRentOverdue As DevExpress.XtraLayout.LayoutControlItem
		Private lciCustomer As DevExpress.XtraLayout.LayoutControlItem
		Private lciActiveRent As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private txtFormat As DevExpress.XtraEditors.ImageComboBoxEdit
		Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
		Private simpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
		Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace

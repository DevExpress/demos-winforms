Namespace XtraReportsDemos.CharacterComb

    Partial Class Report

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccBirthDay = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccBirthMonth = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccFirstName = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccFlightNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccAddress = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccPassportNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccBirthYear = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccLastName = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccVisaNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.panel2 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccMonth = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccYear = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccDay = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
            Me.boldLabelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.characterCombStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.grayedBoldLabelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
            Me.Detail.HeightF = 244F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((243)))))), (CInt(((CByte((243)))))))
            Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrPictureBox3, Me.xrCheckBox2, Me.xrCheckBox1, Me.xrLabel16, Me.ccBirthDay, Me.ccBirthMonth, Me.xrLabel15, Me.ccFirstName, Me.xrLabel5, Me.xrLabel8, Me.ccFlightNo, Me.xrLabel6, Me.xrLabel4, Me.xrLabel3, Me.xrLabel14, Me.xrLabel9, Me.ccAddress, Me.ccPassportNo, Me.ccBirthYear, Me.ccLastName, Me.xrLabel11, Me.ccVisaNo, Me.xrLabel7})
            Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel1.Name = "panel1"
            Me.panel1.SizeF = New System.Drawing.SizeF(911F, 244F)
            Me.panel1.StylePriority.UseBackColor = False
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.White
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(656F, 78F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(225F, 166F)
            Me.xrLabel2.StyleName = "grayedBoldLabelStyle"
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "FOR OFFICIAL USE"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.BackColor = System.Drawing.Color.White
            Me.xrPictureBox3.EditOptions.EditorName = "Nationality"
            Me.xrPictureBox3.EditOptions.Enabled = True
            Me.xrPictureBox3.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(126F, 177F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(76F, 47F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            Me.xrPictureBox3.StylePriority.UseBackColor = False
            ' 
            ' xrCheckBox2
            ' 
            Me.xrCheckBox2.EditOptions.Enabled = True
            Me.xrCheckBox2.EditOptions.GroupID = "Gender"
            Me.xrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(538.2917F, 125F)
            Me.xrCheckBox2.Name = "xrCheckBox2"
            Me.xrCheckBox2.SizeF = New System.Drawing.SizeF(65F, 21F)
            Me.xrCheckBox2.StyleName = "boldLabelStyle"
            Me.xrCheckBox2.StylePriority.UseFont = False
            Me.xrCheckBox2.StylePriority.UseTextAlignment = False
            Me.xrCheckBox2.Text = " FEMALE"
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.EditOptions.Enabled = True
            Me.xrCheckBox1.EditOptions.GroupID = "Gender"
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(447F, 125F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(53F, 21F)
            Me.xrCheckBox1.StyleName = "boldLabelStyle"
            Me.xrCheckBox1.StylePriority.UseFont = False
            Me.xrCheckBox1.StylePriority.UseTextAlignment = False
            Me.xrCheckBox1.Text = " MALE"
            ' 
            ' xrLabel16
            ' 
            Me.xrLabel16.CanGrow = False
            Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(126F, 145F)
            Me.xrLabel16.Name = "xrLabel16"
            Me.xrLabel16.SizeF = New System.Drawing.SizeF(40.5F, 14F)
            Me.xrLabel16.StyleName = "grayedBoldLabelStyle"
            Me.xrLabel16.Text = "DAY"
            ' 
            ' ccBirthDay
            ' 
            Me.ccBirthDay.CellHeight = 21F
            Me.ccBirthDay.CellHorizontalSpacing = 2F
            Me.ccBirthDay.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthDay.CellVerticalSpacing = 2F
            Me.ccBirthDay.CellWidth = 21F
            Me.ccBirthDay.EditOptions.EditorName = "Day"
            Me.ccBirthDay.EditOptions.Enabled = True
            Me.ccBirthDay.LocationFloat = New DevExpress.Utils.PointFloat(126F, 124F)
            Me.ccBirthDay.Name = "ccBirthDay"
            Me.ccBirthDay.SizeF = New System.Drawing.SizeF(44F, 21F)
            Me.ccBirthDay.StyleName = "characterCombStyle"
            Me.ccBirthDay.StylePriority.UseBackColor = False
            Me.ccBirthDay.WordWrap = False
            ' 
            ' ccBirthMonth
            ' 
            Me.ccBirthMonth.CellHeight = 21F
            Me.ccBirthMonth.CellHorizontalSpacing = 2F
            Me.ccBirthMonth.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthMonth.CellVerticalSpacing = 2F
            Me.ccBirthMonth.CellWidth = 21F
            Me.ccBirthMonth.EditOptions.EditorName = "Month"
            Me.ccBirthMonth.EditOptions.Enabled = True
            Me.ccBirthMonth.LocationFloat = New DevExpress.Utils.PointFloat(194.5F, 124F)
            Me.ccBirthMonth.Name = "ccBirthMonth"
            Me.ccBirthMonth.SizeF = New System.Drawing.SizeF(44F, 21F)
            Me.ccBirthMonth.StyleName = "characterCombStyle"
            Me.ccBirthMonth.StylePriority.UseBackColor = False
            Me.ccBirthMonth.WordWrap = False
            ' 
            ' xrLabel15
            ' 
            Me.xrLabel15.CanGrow = False
            Me.xrLabel15.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(194.5F, 145F)
            Me.xrLabel15.Name = "xrLabel15"
            Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel15.SizeF = New System.Drawing.SizeF(41F, 14F)
            Me.xrLabel15.StyleName = "grayedBoldLabelStyle"
            Me.xrLabel15.Text = "MONTH"
            Me.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' ccFirstName
            ' 
            Me.ccFirstName.CellHeight = 21F
            Me.ccFirstName.CellHorizontalSpacing = 2F
            Me.ccFirstName.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccFirstName.CellVerticalSpacing = 2F
            Me.ccFirstName.CellWidth = 21F
            Me.ccFirstName.EditOptions.EditorName = "Name"
            Me.ccFirstName.EditOptions.Enabled = True
            Me.ccFirstName.LocationFloat = New DevExpress.Utils.PointFloat(126F, 62F)
            Me.ccFirstName.Name = "ccFirstName"
            Me.ccFirstName.SizeF = New System.Drawing.SizeF(504F, 21F)
            Me.ccFirstName.StyleName = "characterCombStyle"
            Me.ccFirstName.StylePriority.UseBackColor = False
            Me.ccFirstName.WordWrap = False
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(28F, 177F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel5.StyleName = "boldLabelStyle"
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "NATIONALITY"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(28F, 93F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel8.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 10, 0, 100F)
            Me.xrLabel8.StyleName = "boldLabelStyle"
            Me.xrLabel8.StylePriority.UseTextAlignment = False
            Me.xrLabel8.Text = "PASSPORT NO."
            Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ccFlightNo
            ' 
            Me.ccFlightNo.CellHeight = 21F
            Me.ccFlightNo.CellHorizontalSpacing = 2F
            Me.ccFlightNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccFlightNo.CellVerticalSpacing = 2F
            Me.ccFlightNo.CellWidth = 21F
            Me.ccFlightNo.EditOptions.EditorName = "NumbersAndUppercaseLatinLetters"
            Me.ccFlightNo.EditOptions.Enabled = True
            Me.ccFlightNo.LocationFloat = New DevExpress.Utils.PointFloat(745F, 31F)
            Me.ccFlightNo.Name = "ccFlightNo"
            Me.ccFlightNo.SizeF = New System.Drawing.SizeF(136F, 21F)
            Me.ccFlightNo.StyleName = "characterCombStyle"
            Me.ccFlightNo.StylePriority.UseBackColor = False
            Me.ccFlightNo.WordWrap = False
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(226F, 177F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(61F, 21F)
            Me.xrLabel6.StyleName = "boldLabelStyle"
            Me.xrLabel6.Text = "ADDRESS"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(28F, 62F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel4.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 10, 0, 100F)
            Me.xrLabel4.StyleName = "boldLabelStyle"
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "FIRST NAME"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(28F, 31F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel3.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 10, 0, 100F)
            Me.xrLabel3.StyleName = "boldLabelStyle"
            Me.xrLabel3.Text = "LAST NAME"
            ' 
            ' xrLabel14
            ' 
            Me.xrLabel14.CanGrow = False
            Me.xrLabel14.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(264F, 145F)
            Me.xrLabel14.Name = "xrLabel14"
            Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel14.SizeF = New System.Drawing.SizeF(83F, 14F)
            Me.xrLabel14.StyleName = "grayedBoldLabelStyle"
            Me.xrLabel14.Text = "YEAR"
            Me.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(381F, 93F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(67F, 21F)
            Me.xrLabel9.StyleName = "boldLabelStyle"
            Me.xrLabel9.Text = "VISA NO."
            ' 
            ' ccAddress
            ' 
            Me.ccAddress.CellHeight = 21F
            Me.ccAddress.CellHorizontalSpacing = 2F
            Me.ccAddress.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccAddress.CellVerticalSpacing = 5F
            Me.ccAddress.CellWidth = 21F
            Me.ccAddress.EditOptions.EditorName = "UppercaseText"
            Me.ccAddress.EditOptions.Enabled = True
            Me.ccAddress.LocationFloat = New DevExpress.Utils.PointFloat(287F, 177F)
            Me.ccAddress.Multiline = True
            Me.ccAddress.Name = "ccAddress"
            Me.ccAddress.SizeF = New System.Drawing.SizeF(343F, 47F)
            Me.ccAddress.StyleName = "characterCombStyle"
            Me.ccAddress.StylePriority.UseBackColor = False
            Me.ccAddress.StylePriority.UseTextAlignment = False
            Me.ccAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ccPassportNo
            ' 
            Me.ccPassportNo.CellHeight = 21F
            Me.ccPassportNo.CellHorizontalSpacing = 2F
            Me.ccPassportNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccPassportNo.CellVerticalSpacing = 2F
            Me.ccPassportNo.CellWidth = 21F
            Me.ccPassportNo.EditOptions.EditorName = "IntegerPositive"
            Me.ccPassportNo.EditOptions.Enabled = True
            Me.ccPassportNo.LocationFloat = New DevExpress.Utils.PointFloat(126F, 93F)
            Me.ccPassportNo.Name = "ccPassportNo"
            Me.ccPassportNo.SizeF = New System.Drawing.SizeF(228F, 21F)
            Me.ccPassportNo.StyleName = "characterCombStyle"
            Me.ccPassportNo.StylePriority.UseBackColor = False
            Me.ccPassportNo.WordWrap = False
            ' 
            ' ccBirthYear
            ' 
            Me.ccBirthYear.CellHeight = 21F
            Me.ccBirthYear.CellHorizontalSpacing = 2F
            Me.ccBirthYear.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthYear.CellVerticalSpacing = 2F
            Me.ccBirthYear.CellWidth = 21F
            Me.ccBirthYear.EditOptions.EditorName = "Year"
            Me.ccBirthYear.EditOptions.Enabled = True
            Me.ccBirthYear.LocationFloat = New DevExpress.Utils.PointFloat(264F, 124F)
            Me.ccBirthYear.Name = "ccBirthYear"
            Me.ccBirthYear.SizeF = New System.Drawing.SizeF(90F, 21F)
            Me.ccBirthYear.StyleName = "characterCombStyle"
            Me.ccBirthYear.StylePriority.UseBackColor = False
            Me.ccBirthYear.WordWrap = False
            ' 
            ' ccLastName
            ' 
            Me.ccLastName.CellHeight = 21F
            Me.ccLastName.CellHorizontalSpacing = 2F
            Me.ccLastName.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccLastName.CellVerticalSpacing = 2F
            Me.ccLastName.CellWidth = 21F
            Me.ccLastName.EditOptions.EditorName = "Name"
            Me.ccLastName.EditOptions.Enabled = True
            Me.ccLastName.LocationFloat = New DevExpress.Utils.PointFloat(126F, 31F)
            Me.ccLastName.Name = "ccLastName"
            Me.ccLastName.SizeF = New System.Drawing.SizeF(504F, 21F)
            Me.ccLastName.StyleName = "characterCombStyle"
            Me.ccLastName.StylePriority.UseBackColor = False
            Me.ccLastName.WordWrap = False
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(28F, 124F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel11.SnapLineMargin = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 10, 0, 100F)
            Me.xrLabel11.StyleName = "boldLabelStyle"
            Me.xrLabel11.StylePriority.UseTextAlignment = False
            Me.xrLabel11.Text = "DATE OF BIRTH"
            Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ccVisaNo
            ' 
            Me.ccVisaNo.CellHeight = 21F
            Me.ccVisaNo.CellHorizontalSpacing = 2F
            Me.ccVisaNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccVisaNo.CellVerticalSpacing = 2F
            Me.ccVisaNo.CellWidth = 21F
            Me.ccVisaNo.EditOptions.EditorName = "IntegerPositive"
            Me.ccVisaNo.EditOptions.Enabled = True
            Me.ccVisaNo.LocationFloat = New DevExpress.Utils.PointFloat(448F, 93F)
            Me.ccVisaNo.Name = "ccVisaNo"
            Me.ccVisaNo.SizeF = New System.Drawing.SizeF(182F, 21F)
            Me.ccVisaNo.StyleName = "characterCombStyle"
            Me.ccVisaNo.StylePriority.UseBackColor = False
            Me.ccVisaNo.WordWrap = False
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(656F, 31F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(78F, 21F)
            Me.xrLabel7.StyleName = "boldLabelStyle"
            Me.xrLabel7.Text = "FLIGHT NO."
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 0F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.StylePriority.UseTextAlignment = False
            Me.TopMargin.Visible = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 0F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportHeader.HeightF = 62F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((214)))))), (CInt(((CByte((108)))))))
            Me.xrLabel1.CanGrow = False
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 13F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((104)))))), (CInt(((CByte((104)))))), (CInt(((CByte((104)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(16, 10, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(911F, 62F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "   ARRIVAL CARD"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel2})
            Me.ReportFooter.HeightF = 79F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' panel2
            ' 
            Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((243)))))), (CInt(((CByte((243)))))))
            Me.panel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.label1, Me.label2, Me.label3, Me.ccMonth, Me.ccYear, Me.ccDay, Me.xrLabel12})
            Me.panel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.panel2.Name = "panel2"
            Me.panel2.SizeF = New System.Drawing.SizeF(911F, 78F)
            Me.panel2.StylePriority.UseBackColor = False
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.BackColor = System.Drawing.Color.White
            Me.xrPictureBox1.EditOptions.EditorName = "Signature"
            Me.xrPictureBox1.EditOptions.Enabled = True
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(126F, 0F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(504F, 47F)
            Me.xrPictureBox1.StylePriority.UseBackColor = False
            ' 
            ' label1
            ' 
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(656F, 47F)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(44F, 14F)
            Me.label1.StyleName = "grayedBoldLabelStyle"
            Me.label1.Text = "DAY"
            ' 
            ' label2
            ' 
            Me.label2.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(723.5F, 47F)
            Me.label2.Name = "label2"
            Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.label2.SizeF = New System.Drawing.SizeF(44F, 14F)
            Me.label2.StyleName = "grayedBoldLabelStyle"
            Me.label2.Text = "MONTH"
            Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' label3
            ' 
            Me.label3.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(791F, 47F)
            Me.label3.Name = "label3"
            Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.label3.SizeF = New System.Drawing.SizeF(90F, 14F)
            Me.label3.StyleName = "grayedBoldLabelStyle"
            Me.label3.Text = "YEAR"
            Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ccMonth
            ' 
            Me.ccMonth.CellHeight = 21F
            Me.ccMonth.CellHorizontalSpacing = 2F
            Me.ccMonth.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccMonth.CellVerticalSpacing = 2F
            Me.ccMonth.CellWidth = 21F
            Me.ccMonth.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
            Me.ccMonth.LocationFloat = New DevExpress.Utils.PointFloat(723.5F, 26F)
            Me.ccMonth.Name = "ccMonth"
            Me.ccMonth.SizeF = New System.Drawing.SizeF(44F, 21F)
            Me.ccMonth.StyleName = "characterCombStyle"
            Me.ccMonth.StylePriority.UseBackColor = False
            Me.ccMonth.TextFormatString = "{0:MM}"
            Me.ccMonth.WordWrap = False
            ' 
            ' ccYear
            ' 
            Me.ccYear.CellHeight = 21F
            Me.ccYear.CellHorizontalSpacing = 2F
            Me.ccYear.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccYear.CellVerticalSpacing = 2F
            Me.ccYear.CellWidth = 21F
            Me.ccYear.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
            Me.ccYear.LocationFloat = New DevExpress.Utils.PointFloat(791F, 26F)
            Me.ccYear.Name = "ccYear"
            Me.ccYear.SizeF = New System.Drawing.SizeF(90F, 21F)
            Me.ccYear.StyleName = "characterCombStyle"
            Me.ccYear.StylePriority.UseBackColor = False
            Me.ccYear.TextFormatString = "{0:yyyy}"
            Me.ccYear.WordWrap = False
            ' 
            ' ccDay
            ' 
            Me.ccDay.CellHeight = 21F
            Me.ccDay.CellHorizontalSpacing = 2F
            Me.ccDay.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccDay.CellVerticalSpacing = 2F
            Me.ccDay.CellWidth = 21F
            Me.ccDay.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
            Me.ccDay.LocationFloat = New DevExpress.Utils.PointFloat(656F, 26F)
            Me.ccDay.Name = "ccDay"
            Me.ccDay.SizeF = New System.Drawing.SizeF(44F, 21F)
            Me.ccDay.StyleName = "characterCombStyle"
            Me.ccDay.StylePriority.UseBackColor = False
            Me.ccDay.TextFormatString = "{0:dd}"
            Me.ccDay.WordWrap = False
            ' 
            ' xrLabel12
            ' 
            Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(28F, 0F)
            Me.xrLabel12.Multiline = True
            Me.xrLabel12.Name = "xrLabel12"
            Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel12.SizeF = New System.Drawing.SizeF(88F, 21F)
            Me.xrLabel12.StyleName = "boldLabelStyle"
            Me.xrLabel12.StylePriority.UseBorders = False
            Me.xrLabel12.StylePriority.UseFont = False
            Me.xrLabel12.StylePriority.UseForeColor = False
            Me.xrLabel12.StylePriority.UsePadding = False
            Me.xrLabel12.StylePriority.UseTextAlignment = False
            Me.xrLabel12.Text = "SIGNATURE" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' boldLabelStyle
            ' 
            Me.boldLabelStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((243)))))), (CInt(((CByte((243)))))))
            Me.boldLabelStyle.BorderColor = System.Drawing.Color.Black
            Me.boldLabelStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.boldLabelStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.boldLabelStyle.BorderWidth = 1F
            Me.boldLabelStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.boldLabelStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((161)))))), (CInt(((CByte((161)))))), (CInt(((CByte((161)))))))
            Me.boldLabelStyle.Name = "boldLabelStyle"
            Me.boldLabelStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 2, 0, 0, 100F)
            Me.boldLabelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' characterCombStyle
            ' 
            Me.characterCombStyle.BackColor = System.Drawing.Color.White
            Me.characterCombStyle.BorderColor = System.Drawing.Color.White
            Me.characterCombStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.characterCombStyle.BorderWidth = 1F
            Me.characterCombStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.characterCombStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((99)))))), (CInt(((CByte((99)))))), (CInt(((CByte((99)))))))
            Me.characterCombStyle.Name = "characterCombStyle"
            ' 
            ' grayedBoldLabelStyle
            ' 
            Me.grayedBoldLabelStyle.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((243)))))), (CInt(((CByte((243)))))))
            Me.grayedBoldLabelStyle.BorderColor = System.Drawing.Color.Black
            Me.grayedBoldLabelStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.grayedBoldLabelStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.grayedBoldLabelStyle.BorderWidth = 1F
            Me.grayedBoldLabelStyle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 6F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.grayedBoldLabelStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((198)))))), (CInt(((CByte((198)))))), (CInt(((CByte((198)))))))
            Me.grayedBoldLabelStyle.Name = "grayedBoldLabelStyle"
            Me.grayedBoldLabelStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 2, 0, 100F)
            Me.grayedBoldLabelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
            Me.ExportOptions.Pdf.ExportEditingFieldsToAcroForms = True
            Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 0, 0)
            Me.PageHeight = 385
            Me.PageWidth = 911
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
            Me.PaperName = "Custom"
            Me.SnappingMode = CType(((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid)), DevExpress.XtraReports.UI.SnappingMode)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.boldLabelStyle, Me.characterCombStyle, Me.grayedBoldLabelStyle})
            Me.Version = "18.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private panel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private xrLabel16 As DevExpress.XtraReports.UI.XRLabel

        Private ccBirthDay As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccBirthMonth As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel

        Private ccFirstName As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel

        Private ccFlightNo As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel

        Private ccAddress As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccPassportNo As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccBirthYear As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccLastName As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel

        Private ccVisaNo As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private panel2 As DevExpress.XtraReports.UI.XRPanel

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private label2 As DevExpress.XtraReports.UI.XRLabel

        Private label3 As DevExpress.XtraReports.UI.XRLabel

        Private ccMonth As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccYear As DevExpress.XtraReports.UI.XRCharacterComb

        Private ccDay As DevExpress.XtraReports.UI.XRCharacterComb

        Private xrLabel12 As DevExpress.XtraReports.UI.XRLabel

        Private boldLabelStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private characterCombStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private grayedBoldLabelStyle As DevExpress.XtraReports.UI.XRControlStyle

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace

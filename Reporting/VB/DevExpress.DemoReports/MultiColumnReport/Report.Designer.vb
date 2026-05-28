Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.MultiColumnReport

    Public Partial Class Report

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.MultiColumnReport.Report))
            Dim objectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.columnLayoutParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.isGroupedParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel2})
            Me.Detail.HeightF = 149.9053F
            Me.Detail.MultiColumn.ColumnCount = 3
            Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel2
            ' 
            Me.xrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
            Me.xrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.xrPanel2.Name = "xrPanel2"
            Me.xrPanel2.SizeF = New System.Drawing.SizeF(197.9167F, 149.9053F)
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.BorderColor = System.Drawing.Color.Gray
            Me.xrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.xrPanel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
            Me.xrPanel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([Floor] == 5, '241, 218, 248', [Floor] == 4, '251, 203, 225', [Floor] == 3, '" & "218, 226, 248', [Floor] == 2, '248, 218, 220', [Floor] == 1, '218, 248, 235', ?)" & "")})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(196.9328F, 139.9053F)
            Me.xrPanel1.StylePriority.UseBorderColor = False
            Me.xrPanel1.StylePriority.UseBorderDashStyle = False
            Me.xrPanel1.StylePriority.UseBorders = False
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Title")})
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 9F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(7.291667F, 30.91666F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(181.8402F, 20.91666F)
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 12F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(7.291667F, 10.00001F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(181.8402F, 20.91665F)
            Me.xrLabel2.StylePriority.UseBorders = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "[TitleOfCourtesy] [PersonName]"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(7.291667F, 83.95834F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(181.8402F, 25.37498F)
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "Office [Office]"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(254F, 13F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.UseImageResolution = False
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4})
            Me.GroupHeader1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?isGroupedParameter")})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Floor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 53.0303F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 10F)
            Me.xrLabel4.ForeColor = System.Drawing.Color.Gray
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(9.999983F, 26.90532F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(196.9328F, 26.12498F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.Text = "FLOOR [Floor]"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Expanded = False
            Me.GroupFooter1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?isGroupedParameter"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "PageBreak", "Iif(?columnLayoutParameter, 'None', 'AfterBandExceptLastEntry')")})
            Me.GroupFooter1.HeightF = 0F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' columnLayoutParameter
            ' 
            Me.columnLayoutParameter.Description = "First across, then down"
            Me.columnLayoutParameter.Name = "columnLayoutParameter"
            Me.columnLayoutParameter.Type = GetType(Boolean)
            Me.columnLayoutParameter.ValueInfo = "True"
            ' 
            ' isGroupedParameter
            ' 
            Me.isGroupedParameter.Description = "Group offices by floors"
            Me.isGroupedParameter.Name = "isGroupedParameter"
            Me.isGroupedParameter.Type = GetType(Boolean)
            Me.isGroupedParameter.ValueInfo = "True"
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataMember = "GetData"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.MultiColumnReport.DataSource)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.columnLayoutParameter, Me.isGroupedParameter})
            Me.RequestParameters = False
            Me.Version = "21.2"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.Report_BeforePrint)
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Public columnLayoutParameter As DevExpress.XtraReports.Parameters.Parameter

        Private isGroupedParameter As DevExpress.XtraReports.Parameters.Parameter

        Public GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Public GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private xrPanel2 As DevExpress.XtraReports.UI.XRPanel
    End Class
End Namespace

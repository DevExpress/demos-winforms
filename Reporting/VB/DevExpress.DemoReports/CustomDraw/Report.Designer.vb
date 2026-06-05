Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.CustomDraw

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.CustomDraw.Report))
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim staticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbRegion = New DevExpress.XtraReports.UI.XRLabel()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.customControl1 = New XtraReportsDemos.CustomDraw.CustomControl()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.RegionIdParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbTitle, Me.xrLabel1, Me.lbRegion})
            Me.ReportHeader.HeightF = 88F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((173)))))), (CInt(((CByte((148)))))), (CInt(((CByte((116)))))))
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbTitle.BorderWidth = 2F
            Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F)
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(45F, 8F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(554F, 30F)
            Me.lbTitle.Text = "Top 10 countries selected by population in percentage terms"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AboutRegions].[Region]")})
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((172)))))), (CInt(((CByte((135)))))), (CInt(((CByte((88)))))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(510F, 49F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(110F, 29F)
            Me.xrLabel1.Text = "lbRegionName"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' lbRegion
            ' 
            Me.lbRegion.BackColor = System.Drawing.Color.Transparent
            Me.lbRegion.Font = New DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.lbRegion.ForeColor = System.Drawing.Color.Black
            Me.lbRegion.LocationFloat = New DevExpress.Utils.PointFloat(452F, 45F)
            Me.lbRegion.Name = "lbRegion"
            Me.lbRegion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbRegion.SizeF = New System.Drawing.SizeF(58F, 33F)
            Me.lbRegion.Text = "Region:"
            Me.lbRegion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.customControl1})
            Me.SubBand1.HeightF = 404F
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' customControl1
            ' 
            Me.customControl1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((244)))))), (CInt(((CByte((241)))))))
            Me.customControl1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((225)))))), (CInt(((CByte((215)))))), (CInt(((CByte((203)))))))
            Me.customControl1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.customControl1.BorderWidth = 2F
            Me.customControl1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.customControl1.LocationFloat = New DevExpress.Utils.PointFloat(28F, 4F)
            Me.customControl1.Name = "customControl1"
            Me.customControl1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.customControl1.SizeF = New System.Drawing.SizeF(593F, 400F)
            Me.customControl1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(246.875F, 34.375F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "CountriesConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "Id"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""143"" />"
            table1.Name = "AboutRegions"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Region"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Country"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "PopulationPortion"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.FilterString = "[AboutRegions.Id] = ?ParameterId"
            selectQuery1.GroupFilterString = ""
            selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""124"" Height=""121"" />"
            selectQuery1.Name = "AboutRegions"
            queryParameter1.Name = "ParameterId"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("?RegionIdParameter", GetType(Integer))
            selectQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {queryParameter1})
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' RegionIdParameter
            ' 
            Me.RegionIdParameter.Description = "Region"
            Me.RegionIdParameter.Name = "RegionIdParameter"
            Me.RegionIdParameter.Type = GetType(Integer)
            Me.RegionIdParameter.ValueInfo = "1"
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(1, "Africa"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(2, "Oceania"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(3, "Americas"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(4, "Asia"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(5, "Europe"))
            Me.RegionIdParameter.ValueSourceSettings = staticListLookUpSettings1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "AboutRegions"
            Me.DataSource = Me.sqlDataSource1
            Me.DisplayName = "Custom Control"
            Me.Extensions.Add("DataSerializationExtension", "Custom Control")
            Me.Extensions.Add("DataEditorExtension", "Custom Control")
            Me.Extensions.Add("ParameterEditorExtension", "Custom Control")
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 100F, 75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.RegionIdParameter})
            Me.RequestParameters = False
            Me.Version = "25.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbTitle As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private lbRegion As DevExpress.XtraReports.UI.XRLabel

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private customControl1 As XtraReportsDemos.CustomDraw.CustomControl

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private RegionIdParameter As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace

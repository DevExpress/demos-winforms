Namespace XtraReportsDemos.SideBySideReports

    Partial Class EmployeeComparisonReport

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
            Dim dynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.SideBySideReports.EmployeeComparisonReport))
            Dim dynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.lbCaption = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.leftSideParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.dsEmployee1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.rightSideParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubreport2, Me.xrSubreport1})
            Me.Detail.HeightF = 375F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbCaption})
            Me.ReportHeader.HeightF = 75F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrSubreport2
            ' 
            Me.xrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(332F, 0F)
            Me.xrSubreport2.Name = "xrSubreport2"
            Me.xrSubreport2.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", Me.rightSideParameter))
            Me.xrSubreport2.ReportSource = New XtraReportsDemos.SideBySideReports.EmployeeOrdersReport()
            Me.xrSubreport2.SizeF = New System.Drawing.SizeF(318F, 375F)
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", Me.leftSideParameter))
            Me.xrSubreport1.ReportSource = New XtraReportsDemos.SideBySideReports.EmployeeOrdersReport()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(318F, 375F)
            ' 
            ' lbCaption
            ' 
            Me.lbCaption.BackColor = System.Drawing.Color.Transparent
            Me.lbCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCaption.BorderWidth = 2F
            Me.lbCaption.Font = New DevExpress.Drawing.DXFont("Tahoma", 20.25F)
            Me.lbCaption.ForeColor = System.Drawing.Color.Black
            Me.lbCaption.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbCaption.Name = "lbCaption"
            Me.lbCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCaption.SizeF = New System.Drawing.SizeF(650F, 50F)
            Me.lbCaption.Text = "Employee Comparison"
            Me.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(156.25F, 31.25F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox4.UseImageResolution = False
            ' 
            ' leftSideParameter
            ' 
            Me.leftSideParameter.Description = "Left Side"
            Me.leftSideParameter.Name = "leftSideParameter"
            Me.leftSideParameter.Type = GetType(Long)
            Me.leftSideParameter.ValueInfo = "5"
            dynamicListLookUpSettings2.DataMember = "SimpleEmployees"
            dynamicListLookUpSettings2.DataSource = Me.dsEmployee1
            dynamicListLookUpSettings2.DisplayMember = "FullName"
            dynamicListLookUpSettings2.ValueMember = "EmployeeID"
            Me.leftSideParameter.ValueSourceSettings = dynamicListLookUpSettings2
            ' 
            ' dsEmployee1
            ' 
            Me.dsEmployee1.ConnectionName = "NWindConnectionString"
            Me.dsEmployee1.Name = "dsEmployee1"
            columnExpression1.ColumnName = "EmployeeID"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""400"" />"
            table1.Name = "Employees"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            column2.[Alias] = "FullName"
            customExpression1.Expression = "CONCAT([Employees.FirstName], ' ', [Employees.LastName])"
            column2.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Name = "SimpleEmployees"
            selectQuery1.Tables.Add(table1)
            Me.dsEmployee1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dsEmployee1.ResultSchemaSerializable = resources.GetString("dsEmployee1.ResultSchemaSerializable")
            ' 
            ' rightSideParameter
            ' 
            Me.rightSideParameter.Description = "Right Side"
            Me.rightSideParameter.Name = "rightSideParameter"
            Me.rightSideParameter.Type = GetType(Long)
            Me.rightSideParameter.ValueInfo = "9"
            dynamicListLookUpSettings1.DataMember = "SimpleEmployees"
            dynamicListLookUpSettings1.DataSource = Me.dsEmployee1
            dynamicListLookUpSettings1.DisplayMember = "FullName"
            dynamicListLookUpSettings1.FilterString = "[EmployeeID] <> ?leftSideParameter"
            dynamicListLookUpSettings1.ValueMember = "EmployeeID"
            Me.rightSideParameter.ValueSourceSettings = dynamicListLookUpSettings1
            ' 
            ' EmployeeComparisonReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.dsEmployee1})
            Me.DisplayName = "Side-by-Side Report"
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 100F, 75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.leftSideParameter, Me.rightSideParameter})
            Me.RequestParameters = False
            Me.Version = "25.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrSubreport2 As DevExpress.XtraReports.UI.XRSubreport

        Private rightSideParameter As DevExpress.XtraReports.Parameters.Parameter

        Private dsEmployee1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport

        Private leftSideParameter As DevExpress.XtraReports.Parameters.Parameter

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private lbCaption As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    End Class
End Namespace

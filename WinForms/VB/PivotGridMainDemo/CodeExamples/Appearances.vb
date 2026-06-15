Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports System.Collections.Generic

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Appearances", "Appearances.cs")>
    Public Module Appearances

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            pivotGridControl.BeginInit()
            Dim fieldProductName As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            fieldProductName.Name = "fieldProductName"
            Dim fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldUnitPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("UnitPrice")
            fieldUnitPrice.Name = "fieldUnitPrice"
            Dim fieldDiscontinued As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldDiscontinued.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldDiscontinued.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Discontinued")
            fieldDiscontinued.Name = "fieldDiscontinued1"
            pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {fieldUnitPrice, fieldProductName, fieldDiscontinued})
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.DataSource = DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper.GetData("Products")
            pivotGridControl.EndInit()
            pivotGridControl.Parent = sampleHost
            pivotGridControl.BestFit()
            Return New Object() {pivotGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim grid As DevExpress.XtraPivotGrid.PivotGridControl = TryCast(sampleHost.Controls(0), DevExpress.XtraPivotGrid.PivotGridControl)
            If grid.HtmlImages IsNot Nothing Then
                grid.HtmlImages = Nothing
            End If

            grid.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Html drawing for headers", New System.Type() {GetType(DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowHtmlDrawHeaders")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub EnableHeaderHtmlFormatting(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsView.AllowHtmlDrawHeaders = True
            pivotGridControl.Fields(CStr(("fieldUnitPrice"))).Caption = "<b><color=blue>Unit Price"
            pivotGridControl.Fields(CStr(("fieldProductName"))).Caption = "<b><u> Product Name"
            pivotGridControl.Fields(CStr(("fieldDiscontinued1"))).Caption = "<b><color=blue>Discontinued"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Html drawing for field values", New System.Type() {GetType(DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowHtmlDrawFieldValues")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub EnableFieldHtmlFormatting(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.HtmlImages = DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper.GetHtmlImages()
            pivotGridControl.OptionsView.AllowHtmlDrawFieldValues = True
            AddHandler pivotGridControl.FieldValueDisplayText, Sub(sender, args)
                If Not args.IsPopulatingFilterDropdown AndAlso args.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value AndAlso Equals(args.Field.Name, "fieldProductName") Then
                    Dim categoryID As Integer = CInt(args.CreateDrillDownDataSource().GetValue(0, "CategoryID"))
                    Dim prefix As String = String.Format("<image={0}>", categoryID)
                    Dim backColor As String = DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper.GetCategoryColor(categoryID)
                    If Not String.IsNullOrEmpty(backColor) Then prefix += String.Format("<backcolor={0}><color=white>", backColor)
                    args.DisplayText = prefix & args.DisplayText
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom draw for cells", New System.Type() {GetType(DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawCell")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub CustomDrawEvents(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim highlightedPoints = New System.Collections.Generic.List(Of System.Drawing.Point)({New System.Drawing.Point With {.X = 0, .Y = 2}, New System.Drawing.Point With {.X = 0, .Y = 3}})
            Dim time As Integer = 0
            AddHandler pivotGridControl.CustomDrawCell, Sub(s, e)
                Dim highlight As Boolean = highlightedPoints.Contains(New System.Drawing.Point(e.ColumnIndex, e.RowIndex))
                e.Appearance.ForeColor = If(highlight, System.Drawing.Color.FromArgb(255, time Mod 256, time Mod 256), System.Drawing.Color.Black)
            End Sub
            Dim timer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            timer.Enabled = True
            timer.Interval = 125
            AddHandler timer.Tick, Sub(s, e)
                time += 32
                pivotGridControl.Invalidate()
            End Sub
        End Sub

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class DemoHelper

            Public Shared Function GetData(ByVal tableName As String) As DataView
                Return DevExpress.DXperience.Demos.CodeDemo.Data.NWindTables.GetDataView(tableName)
            End Function

            Public Shared Function GetHtmlImages() As ImageCollection
                Dim imageCollection As DevExpress.Utils.ImageCollection = New DevExpress.Utils.ImageCollection()
                Dim dv = DevExpress.XtraPivotGrid.Demos.CodeExamples.Appearances.DemoHelper.GetData("Categories")
                For Each row As System.Data.DataRowView In dv
                    Dim bytes As Byte() = TryCast(row("Icon_25"), Byte())
                    Dim image As System.Drawing.Image = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(bytes)
                    Dim imageName As String = row(CStr(("CategoryID"))).ToString().Trim()
                    imageCollection.AddImage(image, imageName)
                Next

                Return imageCollection
            End Function

            Public Shared Function GetCategoryColor(ByVal categoryID As Integer) As String
                Select Case categoryID
                    Case 1, 5
                        Return "#F4A460"
                    Case 2, 3
                        Return "#8B4513"
                    Case 4
                        Return "#FFA500"
                    Case 6
                        Return "#FFB6C1"
                    Case 7
                        Return "#90EE90"
                    Case 8
                        Return "#6495ED"
                    Case Else
                        Return String.Empty
                End Select
            End Function
        End Class
#End Region
    End Module
End Namespace

Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports DevExpress.XtraPivotGrid.Demos.Modules
Imports System
Imports System.IO
Imports DevExpress.Data.PivotGrid
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("OLAP", "OLAPIntegration.cs")>
    Public Module OLAPIntegration

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsBehavior.UseAsyncMode = True
            pivotGridControl.OptionsView.ShowColumnTotals = False
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
            pivotGridControl.EndInit()
            pivotGridControl.Parent = sampleHost
            Return New Object() {pivotGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraPivotGrid.PivotGridControl).Dispose()
        End Sub

#If Not NET
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("OLAP Drill Down")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CreateDrillDownDataSource", "DrillDownForm")>
        Public Sub OLAPDrillDown(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            ' installed on your system. You can get the latest version of this provider here: 
            ' http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            AddHandler pivotGridControl.CellDoubleClick, Async Sub(s, e)
                Try
                    pivotGridControl.LoadingPanelVisible = True
                    Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = Await e.CreateDrillDownDataSourceAsync()
                    pivotGridControl.LoadingPanelVisible = False
                    Using form As DevExpress.XtraPivotGrid.Demos.Modules.DrillDownForm = New DevExpress.XtraPivotGrid.Demos.Modules.DrillDownForm(ds)
                        form.ShowDialog()
                    End Using
                Catch ex As System.Exception
                    pivotGridControl.LoadingPanelVisible = False
                    Call DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
                End Try
            End Sub
            Call DevExpress.XtraPivotGrid.Demos.Helpers.OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, True)
        End Sub

#End If
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("OLAP KPI")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("KPIGraphic")>
        Public Sub OLAPKPI(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            ' installed on your system. You can get the latest version of this provider here: 
            ' http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            Dim statusField As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("[Measures].[Internet Revenue Status]"), .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea, .AreaIndex = 2, .Caption = "Status", .Name = "fieldStatus"}
            Dim quarterField As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("[Date].[Fiscal].[Fiscal Quarter]"), .Area = DevExpress.XtraPivotGrid.PivotArea.RowArea, .AreaIndex = 2, .Caption = "Fiscal Quarter", .Name = "pivotGridField"}
            pivotGridControl.Fields.AddRange({quarterField, statusField})
            Call DevExpress.XtraPivotGrid.Demos.Helpers.OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, False)
            Dim ddlStatusGraphics As DevExpress.XtraEditors.ComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit() With {.Parent = pivotGridControl.Parent, .Dock = System.Windows.Forms.DockStyle.Top}
            ddlStatusGraphics.Properties.Items.AddRange({DevExpress.XtraPivotGrid.PivotKPIGraphic.None, DevExpress.XtraPivotGrid.PivotKPIGraphic.Cylinder, DevExpress.XtraPivotGrid.PivotKPIGraphic.ReversedGauge, DevExpress.XtraPivotGrid.PivotKPIGraphic.Faces})
            ddlStatusGraphics.SelectedIndex = 1
            AddHandler ddlStatusGraphics.SelectedIndexChanged, Sub(s, e)
                Dim field As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields("[Measures].[Internet Revenue Status]")
                If field IsNot Nothing Then field.KPIGraphic = CType(ddlStatusGraphics.SelectedItem, DevExpress.XtraPivotGrid.PivotKPIGraphic)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("OLAP Custom Totals")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomTotals", "PivotSummaryType")>
        Public Sub OlapCustomTotals(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' To run this example, you should have Microsoft SQL Server Analysis Services OLE DB 8.0 (or later) 
            ' installed on your system. You can get the latest version of this provider here: 
            ' http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB
            If DevExpress.XtraPivotGrid.Demos.Helpers.OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, True) Then
                Dim categoriesField = pivotGridControl.Fields(DevExpress.XtraPivotGrid.Demos.Helpers.OLAPConfigurator.CategoriesFieldName)
                categoriesField.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
                categoriesField.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Max)
                categoriesField.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Min)
                categoriesField.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Count)
                categoriesField.ExpandValueAsync("Beverages")
            End If
        End Sub
    End Module
End Namespace

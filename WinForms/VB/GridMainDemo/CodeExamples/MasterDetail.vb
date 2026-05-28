Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Master-detail mode", "MasterDetail.cs")>
    Public Module MasterDetail

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Data classes"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class Product

            Public Property ProductName As String

            Public Property UnitPrice As Decimal

            Public Property CategoryID As Integer
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class Category

            Public Property ID As Integer

            Public Property CategoryName As String

            Public Property Description As String

            Public Property Products As BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)

            Public Shared Function GetMasterDetailData() As BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category)
                Dim list As System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category) = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category)()
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 1, .CategoryName = "Beverages", .Description = "Soft drinks, coffees, teas, beers, and ales", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Guaraná Fantástica", .CategoryID = 1, .UnitPrice = 4.5D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 2, .CategoryName = "Condiments", .Description = "Sweet and savory sauces, relishes, spreads, and seasonings", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Sir Corey's Scones", .CategoryID = 2, .UnitPrice = 110}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Sir Joes's Scones", .CategoryID = 2, .UnitPrice = 231.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Amanda's Scones", .CategoryID = 2, .UnitPrice = 31.23D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 3, .CategoryName = "Confections", .Description = "Desserts, candies, and sweet breads", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Sir Rodney's Scones", .CategoryID = 3, .UnitPrice = 10}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gumbär Gummibärchen", .CategoryID = 3, .UnitPrice = 31.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "NuNuCa Nuß-Nougat-Creme", .CategoryID = 3, .UnitPrice = 14}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gumbär", .CategoryID = 3, .UnitPrice = 331.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gummibärchen", .CategoryID = 3, .UnitPrice = 321.23D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 4, .CategoryName = "Dairy Products", .Description = "Cheeses", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gorgonzola Telino", .CategoryID = 4, .UnitPrice = 12.5D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gorgonzola", .CategoryID = 4, .UnitPrice = 112.5D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Telino", .CategoryID = 4, .UnitPrice = 122.5D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 5, .CategoryName = "Grains/Cereals", .Description = "Breads, crackers, pasta, and cereal", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Tunnbröd", .CategoryID = 5, .UnitPrice = 9}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Gustaf's Knäckebröd", .CategoryID = 5, .UnitPrice = 21}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Knäckebröd", .CategoryID = 5, .UnitPrice = 221}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 6, .CategoryName = "Meat/Poultry", .Description = "Prepared meats", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Thüringer Rostbratwurst", .CategoryID = 6, .UnitPrice = 123.79D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Thüringer", .CategoryID = 6, .UnitPrice = 223.79D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Rostbratwurst", .CategoryID = 6, .UnitPrice = 133.79D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 7, .CategoryName = "Produce", .Description = "Dried fruit and bean curd", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Rössle Sauerkraut", .CategoryID = 7, .UnitPrice = 45.6D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Rössle", .CategoryID = 7, .UnitPrice = 55.6D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Sauerkraut", .CategoryID = 7, .UnitPrice = 35.6D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category() With {.ID = 8, .CategoryName = "Seafood", .Description = "Seaweed and fish", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Nord-Ost Matjeshering", .CategoryID = 8, .UnitPrice = 25.89D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Nord-Ost", .CategoryID = 8, .UnitPrice = 23.89D}, New DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product() With {.ProductName = "Nord Matjeshering", .CategoryID = 8, .UnitPrice = 29.89D}}})
                Return list
            End Function

            Public Shared ProductsLevelName As String = "Products"
        End Class

#End Region
#Region "MasterDetail"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create pattern detail View", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ViewCollection", "LevelTree", "Nodes")>
        Public Sub CreatePatternDetailView(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            ' Create a new detail pattern view
            Dim detailPatternView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView With {.ViewCaption = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.ProductsLevelName}
            detailPatternView.Appearance.Row.BackColor = System.Drawing.Color.Coral
            detailPatternView.Appearance.Row.Options.UseBackColor = True
            gridControl.ViewCollection.Add(detailPatternView)
            ' Associate the detailPatternView view with the Products level
            gridControl.LevelTree.Nodes.Add(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.ProductsLevelName, detailPatternView)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Detail View height", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DetailHeight")>
        Public Sub RestrictDetailViewHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            Dim detailPatternView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView With {.ViewCaption = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.ProductsLevelName}
            gridControl.ViewCollection.Add(detailPatternView)
            gridControl.LevelTree.Nodes.Add(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.ProductsLevelName, detailPatternView)
            ' Restrict detail View height
            detailPatternView.DetailHeight = 100
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to prevent loading detail data for certain master rows", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MasterRowEmpty", "IsEmpty")>
        Public Sub PreventLoadingMasterRowsData(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            'The MasterRowEmpty event allows you to specify whether a particular detail is empty.
            ' This event fires only if the GridView.OptionsDetail.AllowExpandEmptyDetails option is set to false. 
            AddHandler gridView.MasterRowEmpty, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then e.IsEmpty = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibit expanding certain master rows", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MasterRowExpanding", "Allow")>
        Public Sub ProhibitExpandCertainMasterRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            ' You can handle the MasterRowExpanding event to manage whether particular details can be displayed.
            AddHandler gridView.MasterRowExpanding, Sub(s, e) e.Allow = e.RowHandle Mod 2 = 0 AndAlso e.RelationIndex = 0
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hide master row expand buttons", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowDetailButtons", "ExpandMasterRow", "CollapseMasterRow")>
        Public Sub HideExpandButtons(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            'Hide detail expand buttons
            gridView.OptionsView.ShowDetailButtons = False
            Dim masterRowHandleSpinEdit As DevExpress.XtraEditors.SpinEdit = New DevExpress.XtraEditors.SpinEdit With {.Parent = gridControl.Parent, .Dock = System.Windows.Forms.DockStyle.Top, .EditValue = 0}
            masterRowHandleSpinEdit.Properties.MinValue = 0
            masterRowHandleSpinEdit.Properties.MaxValue = gridView.DataRowCount - 1
            masterRowHandleSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Dim masterRowHandleSpinEditLabel As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl With {.Text = "Master row handle", .Dock = System.Windows.Forms.DockStyle.Top, .Parent = gridControl.Parent}
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Expand master row", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ExpandMasterRow(System.Convert.ToInt32(masterRowHandleSpinEdit.EditValue))
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Collapse master row", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) gridView.CollapseMasterRow(System.Convert.ToInt32(masterRowHandleSpinEdit.EditValue))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Assign detail view dynamically", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category), GetType(DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Product)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MasterRowGetLevelDefaultView", "DefaultView")>
        Public Sub MasterRowGetLevelDefaultView(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.XtraGrid.Demos.CodeExamples.MasterDetail.Category.GetMasterDetailData()
            ' Create a new view to use as a detail pattern View
            Dim newDetailView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(gridControl.CreateView("GridView"), DevExpress.XtraGrid.Views.Grid.GridView)
            newDetailView.Appearance.Row.BackColor = System.Drawing.Color.LightBlue
            newDetailView.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue
            ' Handle this event to specify a view to represent a particular detail
            AddHandler gridView.MasterRowGetLevelDefaultView, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then e.DefaultView = newDetailView
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Master-detail mode using events"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MasterRowGetRelationCount", "MasterRowEmpty", "RelationCount", "IsEmpty", "MasterRowGetChildList", "ChildList", "MasterRowGetRelationName", "RelationName")>
        Public Sub MasterDetailsUsingEvents(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(4)
            ' Handle the MasterRowGetRelationCount event to specify the number of master-detail relationships for each master row
            AddHandler gridView.MasterRowGetRelationCount, Sub(s, e) e.RelationCount = 1
            ' Handle the MasterRowEmpty event to specify whether or not the current detail has data
            AddHandler gridView.MasterRowEmpty, Sub(s, e) e.IsEmpty = False
            ' Handle the MasterRowGetChildList event to provide data for the current detail. 
            ' The detail is identified by the master row handle and relation index. 
            AddHandler gridView.MasterRowGetChildList, Sub(s, e) e.ChildList = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(4).ToList()
            ' Handle the MasterRowGetRelationName event to provide a name for the current detail
            AddHandler gridView.MasterRowGetRelationName, Sub(s, e) e.RelationName = "TestName"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Load details asynchronously"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AllowExpandEmptyDetails", "MasterRowGetRelationCount", "MasterRowEmpty", "MasterRowGetChildList", "MasterRowGetRelationName")>
        Public Sub MasterRowGetChildListAsync(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(4)
            'Set this property to true to allow expanding empty details
            gridView.OptionsDetail.AllowExpandEmptyDetails = True
            'Handle the MasterRowGetRelationCount event to specify the number of master-detail relationships for each master row
            AddHandler gridView.MasterRowGetRelationCount, Sub(s, e) e.RelationCount = 1
            'Handle the MasterRowEmpty event to specify whether or not the current detail has data
            AddHandler gridView.MasterRowEmpty, Sub(s, e) e.IsEmpty = False
            'Handle the MasterRowGetChildList event to provide data for the current detail.
            '  The detail is identified by the master row handle and relation index.
            AddHandler gridView.MasterRowGetChildList, Async Sub(s, e)
                Dim childList As System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = New System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)()
                e.ChildList = childList
                Dim tempList As System.Collections.Generic.IList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = Await System.Threading.Tasks.Task.Run(Function()
                    ' Imitation of long data loading
                    System.Threading.Thread.Sleep(1000)
                    ' Load data
                    Return DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(4)
                End Function)
                ' Add the loaded data to the childList list on the UI thread
                For Each current As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData In tempList
                    childList.Add(current)
                Next
            End Sub
            ' Handle the MasterRowGetRelationName event to provide a name for the current detail
            AddHandler gridView.MasterRowGetRelationName, Sub(s, e) e.RelationName = "TestName"
        End Sub
#End Region
    End Module
End Namespace

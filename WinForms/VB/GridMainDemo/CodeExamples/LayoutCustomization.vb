Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Layout customization", "LayoutCustomization.cs")>
    Public Module LayoutCustomization

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
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

            Public Property Products As BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product)

            Public Shared Function GetMasterDetailData() As BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category)
                Dim list As System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category) = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category)()
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 1, .CategoryName = "Beverages", .Description = "Soft drinks, coffees, teas, beers, and ales", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Guaraná Fantástica", .CategoryID = 1, .UnitPrice = 4.5D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 2, .CategoryName = "Condiments", .Description = "Sweet and savory sauces, relishes, spreads, and seasonings", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Sir Corey's Scones", .CategoryID = 2, .UnitPrice = 110}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Sir Joes's Scones", .CategoryID = 2, .UnitPrice = 231.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Amanda's Scones", .CategoryID = 2, .UnitPrice = 31.23D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 3, .CategoryName = "Confections", .Description = "Desserts, candies, and sweet breads", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Sir Rodney's Scones", .CategoryID = 3, .UnitPrice = 10}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gumbär Gummibärchen", .CategoryID = 3, .UnitPrice = 31.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "NuNuCa Nuß-Nougat-Creme", .CategoryID = 3, .UnitPrice = 14}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gumbär", .CategoryID = 3, .UnitPrice = 331.23D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gummibärchen", .CategoryID = 3, .UnitPrice = 321.23D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 4, .CategoryName = "Dairy Products", .Description = "Cheeses", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gorgonzola Telino", .CategoryID = 4, .UnitPrice = 12.5D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gorgonzola", .CategoryID = 4, .UnitPrice = 112.5D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Telino", .CategoryID = 4, .UnitPrice = 122.5D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 5, .CategoryName = "Grains/Cereals", .Description = "Breads, crackers, pasta, and cereal", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Tunnbröd", .CategoryID = 5, .UnitPrice = 9}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Gustaf's Knäckebröd", .CategoryID = 5, .UnitPrice = 21}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Knäckebröd", .CategoryID = 5, .UnitPrice = 221}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 6, .CategoryName = "Meat/Poultry", .Description = "Prepared meats", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Thüringer Rostbratwurst", .CategoryID = 6, .UnitPrice = 123.79D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Thüringer", .CategoryID = 6, .UnitPrice = 223.79D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Rostbratwurst", .CategoryID = 6, .UnitPrice = 133.79D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 7, .CategoryName = "Produce", .Description = "Dried fruit and bean curd", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Rössle Sauerkraut", .CategoryID = 7, .UnitPrice = 45.6D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Rössle", .CategoryID = 7, .UnitPrice = 55.6D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Sauerkraut", .CategoryID = 7, .UnitPrice = 35.6D}}})
                list.Add(New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Category() With {.ID = 8, .CategoryName = "Seafood", .Description = "Seaweed and fish", .Products = New System.ComponentModel.BindingList(Of DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product) From {New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Nord-Ost Matjeshering", .CategoryID = 8, .UnitPrice = 25.89D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Nord-Ost", .CategoryID = 8, .UnitPrice = 23.89D}, New DevExpress.XtraGrid.Demos.CodeExamples.LayoutCustomization.Product() With {.ProductName = "Nord Matjeshering", .CategoryID = 8, .UnitPrice = 29.89D}}})
                Return list
            End Function

            Public Shared ProductsLevelName As String = "Products"
        End Class

#End Region
#Region "Layout Customization"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("View caption height"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ViewCaptionHeight", "ShowViewCaption")>
        Public Sub IncreaseViewCaptionHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Enable this option to show the GridView's caption
            gridView.OptionsView.ShowViewCaption = True
            gridView.ViewCaption = "Fish database"
            ' This property controls the GridView's caption height
            gridView.ViewCaptionHeight = 20
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Column header panel height"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ColumnPanelRowHeight")>
        Public Sub IncreaseColumnPanelHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' This property controls the column header row height
            gridView.ColumnPanelRowHeight = 50
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase Column Panel height", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ColumnPanelRowHeight += 5
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Footer panel height"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FooterPanelHeight")>
        Public Sub IncreaseFooterPanelHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The property manages visibility of the footer panel
            gridView.OptionsView.ShowFooter = True
            ' This property controls the footer panel height
            gridView.FooterPanelHeight = 50
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase footer panel height", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.FooterPanelHeight += 5
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Group row height"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupRowHeight")>
        Public Sub IncreaseGroupdRowsHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CInt((0))).Group()
            ' This property controls the group rows' height
            gridView.GroupRowHeight = 22
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase group row height", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.GroupRowHeight += 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change row height dynamically"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcRowHeight")>
        Public Sub CustomDynamicRowHeight(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            AddHandler gridView.CalcRowHeight, Sub(sender, e)
                If e.RowHandle Mod 2 = 0 Then
                    e.RowHeight = 50
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("RowIndicator width"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("IndicatorWidth")>
        Public Sub IncreaseRowIndicatorWidth(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Specify the Row Indicator width
            gridView.IndicatorWidth = 25
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase RowIndicator's width", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.IndicatorWidth += 5
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Preview text horizontal offset"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewIndent")>
        Public Sub IncreasePreviewIndent(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.PreviewFieldName = "Notes"
            gridView.OptionsView.ShowPreview = True
            ' This property gets or sets the horizontal offset of preview text.
            gridView.PreviewIndent = 55
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase preview indent", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.PreviewIndent += 5
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Manage cell padding"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("UserCellPadding")>
        Public Sub ManageCellsPaddings(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim all As Integer = 1
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Increase padding", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                ' The property gets or sets a Padding structure by which the default cell padding is adjusted.
                gridView.UserCellPadding = New System.Windows.Forms.Padding(all)
                all += 1
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Save layout"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SaveLayoutToRegistry", "RestoreLayoutFromRegistry", "SaveLayoutToStream", "RestoreLayoutFromStream", "SaveLayoutToXml", "RestoreLayoutFromXml")>
        Public Sub SaveRestoreLayout(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim regKey As String = "DevExpress\XtraGrid\Layouts\MainLayout"
            Dim filePath As String = "XtraGrid_SaveLayoutToXML.xml"
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Save/restore layout to/from registry", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                gridView.SaveLayoutToRegistry(regKey)
                gridView.RestoreLayoutFromRegistry(regKey)
            End Sub
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Save/restore layout to/from stream", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e)
                Using str As System.IO.MemoryStream = New System.IO.MemoryStream()
                    gridView.SaveLayoutToStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                    ' Load the view's layout from a previously saved memory stream.
                    gridView.RestoreLayoutFromStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                End Using
            End Sub
            Dim b2 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Save/restore layout to/from xml", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b2.Click, Sub(s, e)
                gridView.SaveLayoutToXml(filePath)
                gridView.RestoreLayoutFromXml(filePath)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent restoring layout"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeforeLoadLayout", "SaveLayoutToStream", "RestoreLayoutFromStream", "Allow")>
        Public Sub PreventRestoreLayout(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' This event allows you to prevent the layout from being restored from storage
            AddHandler gridView.BeforeLoadLayout, Sub(s, e) e.Allow = False
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Restore layout from stream", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                Using str As System.IO.MemoryStream = New System.IO.MemoryStream()
                    gridView.SaveLayoutToStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                    gridView.Columns(CInt((0))).Visible = False
                    ' Load the view's layout from a previously saved memory stream.
                    gridView.RestoreLayoutFromStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                End Using
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize layout during restoration"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LayoutUpgrade", "LayoutVersion", "SaveLayoutToStream", "RestoreLayoutFromStream")>
        Public Sub CustomizeLayoutDuringRestoration(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' This event allows you to update the layout while it is being restored from storage
            AddHandler gridView.LayoutUpgrade, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                view.Columns(CInt((0))).Visible = False
            End Sub
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Restore layout from stream", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                Using str As System.IO.MemoryStream = New System.IO.MemoryStream()
                    gridView.OptionsLayout.LayoutVersion = "Previous"
                    gridView.SaveLayoutToStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                    gridView.OptionsLayout.LayoutVersion = "Current"
                    gridView.RestoreLayoutFromStream(str)
                    str.Seek(0, System.IO.SeekOrigin.Begin)
                End Using
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display group headers in a specific style"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupRowCollapsing", "CustomDrawGroupRow")>
        Public Sub DisplayGroupHeadersInASpecificStyle(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Mark"))).Group()
            gridView.ExpandAllGroups()
            gridView.GroupRowHeight = 30
            AddHandler gridView.CustomDrawGroupRow, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)
                e.Appearance.BackColor = view.PaintAppearance.Row.BackColor
                info.GroupText = String.Empty
                info.RowState = DevExpress.XtraGrid.Views.Base.GridRowCellState.[Default]
                info.ButtonBounds = System.Drawing.Rectangle.Empty
                e.DefaultDraw()
                Dim viewInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo = TryCast(view.GetViewInfo(), DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo)
                Dim groupText As String = info.GroupValueText
                e.Appearance.ForeColor = view.PaintAppearance.HideSelectionRow.ForeColor
                e.Appearance.FontSizeDelta = 2
                e.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
                Dim textSize As System.Drawing.Size = e.Appearance.CalcTextSizeInt(e.Cache, groupText, info.DataBounds.Width)
                Dim textBounds As System.Drawing.Rectangle = New System.Drawing.Rectangle(info.DataBounds.X + viewInfo.LevelIndent, info.DataBounds.Bottom - textSize.Height, textSize.Width, textSize.Height)
                e.Appearance.DrawString(e.Cache, groupText, textBounds)
                e.Cache.DrawLine(e.Cache.GetPen(e.Appearance.ForeColor), New System.Drawing.Point(textBounds.X, info.TotalBounds.Bottom - 2), New System.Drawing.Point(info.TotalBounds.Right, info.TotalBounds.Bottom - 2))
                e.Handled = True
            End Sub
            AddHandler gridView.GroupRowCollapsing, Sub(s, e) e.Allow = False
        End Sub
#End Region
    End Module
End Namespace

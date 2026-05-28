Imports System
Imports DevExpress.XtraLayout
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils
Imports System.Linq
Imports DevExpress.Utils.Design

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Table layout", "TableLayout.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "ColumnDefinition", "RowDefinition", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public Module TableLayout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim layoutControl As DevExpress.XtraLayout.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraLayout.LayoutControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Two table items")>
        Public Sub TableLayoutSimple(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' A layout consisting of two items.
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' The first item is implicitly positioned in the cell (col=0, row=0).
            ' The second item is explicitly positioned in the cell (col=1, row=1).
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Rows and columns")>
        Public Sub TableLayoutRowsAndColumns(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' A layout consisting of five items explicitly positioned within table cells.
            ' Two items occupy more than one cell.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            'After enabling Table mode, two columns already exist. Add one more column.
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 50
            layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions.Add(columnDefinition3)
            'Two rows already exist. Add one more row.
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition3.Height = 50
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions.Add(rowDefinition3)
            ' Create controls and position them within table cells.
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            Dim item3 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 3", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo3"})
            Dim item4 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 4", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo4"})
            Dim item5 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 5", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo5"})
            item1.OptionsTableLayoutItem.RowIndex = 0
            item1.OptionsTableLayoutItem.ColumnIndex = 0
            item2.OptionsTableLayoutItem.RowIndex = 0
            item2.OptionsTableLayoutItem.ColumnIndex = 2
            item3.OptionsTableLayoutItem.RowIndex = 1
            item3.OptionsTableLayoutItem.ColumnIndex = 0
            item3.OptionsTableLayoutItem.RowSpan = 2
            item4.OptionsTableLayoutItem.RowIndex = 1
            item4.OptionsTableLayoutItem.ColumnIndex = 1
            item5.OptionsTableLayoutItem.RowIndex = 2
            item5.OptionsTableLayoutItem.ColumnIndex = 1
            item5.OptionsTableLayoutItem.ColumnSpan = 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Row and column visibility")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Visible")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(202)>
        Public Sub RowAndColumnVisibility(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example shows how to hide rows and columns using the Visible property.
            Dim tableGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.Root.AddGroup()
            tableGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            'Create a table layout.
            tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear()
            tableGroup.OptionsTableLayoutGroup.RowDefinitions.Clear()
            For i As Integer = 0 To 4 - 1
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(New DevExpress.XtraLayout.ColumnDefinition(tableGroup, 25, System.Windows.Forms.SizeType.Percent))
                tableGroup.OptionsTableLayoutGroup.RowDefinitions.Add(New DevExpress.XtraLayout.RowDefinition(tableGroup, 25, System.Windows.Forms.SizeType.Percent))
                Dim newMemoItem As DevExpress.XtraLayout.LayoutControlItem = tableGroup.AddItem(String.Format("Memo {0}x{0}", i), New DevExpress.XtraEditors.MemoEdit() With {.Name = String.Format("Memo {0}x{0}", i)})
                newMemoItem.OptionsTableLayoutItem.ColumnIndex = i
                newMemoItem.OptionsTableLayoutItem.RowIndex = newMemoItem.OptionsTableLayoutItem.ColumnIndex
            Next

            'Toggle row and column visibility
            Dim btnHide As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Name = "ButtonHide", .Text = "Hide/show row and column"}
            Dim btnHideItem As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("ButtonHide", btnHide)
            btnHideItem.TextVisible = False
            AddHandler btnHide.Click, Sub(s, e)
                tableGroup.OptionsTableLayoutGroup.RowDefinitions(CInt((2))).Visible = Not tableGroup.OptionsTableLayoutGroup.RowDefinitions(CInt((2))).Visible
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions(CInt((2))).Visible = Not tableGroup.OptionsTableLayoutGroup.ColumnDefinitions(CInt((2))).Visible
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Absolute row height")>
        Public Sub TableLayoutAbsoluteRowHeight(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example sets a row's height to an absolute value.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access the first row.
            Dim row1 As DevExpress.XtraLayout.RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(0)
            row1.SizeType = System.Windows.Forms.SizeType.Absolute
            row1.Height = 100
            layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            Dim item As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            item.OptionsTableLayoutItem.RowIndex = 1
            item.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Auto-sized row")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DxImageAssemblyUtil", "ImageSize", "ImageType", "Size")>
        Public Sub TableLayoutAutoSizedRow(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example demonstrates the auto-sizing feature of rows.
            ' When Table Layout mode is enabled, two rows and two columns are automatically created. 
            ' Three items (Picture editor and two Memo controls) are displayed in their individual table cells.
            ' The Picture editor's maximum height is limited.
            ' It is positioned in the first row, whose RowDefinition.SizeType property is set to AutoSize.  
            ' The row is auto-sized to fit the Picture editor in its entirety.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(CInt((0))).SizeType = System.Windows.Forms.SizeType.AutoSize
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Picture", New DevExpress.XtraEditors.PictureEdit() With {.Name = "Picture", .Image = DevExpress.Utils.DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored)})
            ' Limit the PictureEdit control height.
            item1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            item1.ControlMaxSize = New System.Drawing.Size(0, 40)
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 0
            Dim item3 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            item3.OptionsTableLayoutItem.RowIndex = 1
            item3.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Relative row height")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Sub TableLayoutRelativeRowHeight(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example sets the height of table rows to proportional values.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access these rows.
            Dim row1 As DevExpress.XtraLayout.RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(0)
            Dim row2 As DevExpress.XtraLayout.RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(1)
            layoutControl.Root.BeginUpdate()
            row2.SizeType = System.Windows.Forms.SizeType.Percent
            row1.SizeType = row2.SizeType
            row1.Height = 40
            row2.Height = 60
            layoutControl.Root.EndUpdate()
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Relative column size and column span")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Sub TableLayoutColumnSizeAndSpan(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example sets the width of table columns to proportinal values.
            ' In addtion, the column span setting is demonstrated.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access these columns.
            Dim column1 As DevExpress.XtraLayout.ColumnDefinition = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions(0)
            Dim column2 As DevExpress.XtraLayout.ColumnDefinition = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions(1)
            layoutControl.Root.BeginUpdate()
            column2.SizeType = System.Windows.Forms.SizeType.Percent
            column1.SizeType = column2.SizeType
            column1.Width = 40
            column2.Width = 60
            layoutControl.Root.EndUpdate()
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            item1.OptionsTableLayoutItem.RowIndex = 0
            item1.OptionsTableLayoutItem.ColumnIndex = 0
            item1.OptionsTableLayoutItem.ColumnSpan = 2
            Dim item2 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Table layout with nested group")>
        Public Sub TableLayoutNestedGroup(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' In this example, a table cell displays a nested layout group with two Memo controls.
            layoutControl.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            Dim item1 As DevExpress.XtraLayout.LayoutControlItem = layoutControl.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            Dim innerGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.AddGroup()
            innerGroup.AddItem("Memo 2", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo2"})
            innerGroup.AddItem("Memo 3", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo3"})
            ' Position the created group in a target cell.
            innerGroup.OptionsTableLayoutItem.RowIndex = 1
            innerGroup.OptionsTableLayoutItem.ColumnIndex = 1
            innerGroup.BestFit()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("M rows x N columns layout")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Sub TableLayoutMxN(ByVal layoutControl As DevExpress.XtraLayout.LayoutControl)
            ' This example creates a table consisting of a certain number of columns and rows.
            Dim tableGroup As DevExpress.XtraLayout.LayoutControlGroup = layoutControl.Root.AddGroup()
            tableGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear()
            tableGroup.OptionsTableLayoutGroup.RowDefinitions.Clear()
            Dim rowCount As Integer = 10
            Dim columnCount As Integer = 10
            tableGroup.BeginUpdate()
            For n As Integer = 0 To columnCount - 1
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(New DevExpress.XtraLayout.ColumnDefinition(tableGroup, 10, System.Windows.Forms.SizeType.Percent))
            Next

            For m As Integer = 0 To rowCount - 1
                tableGroup.OptionsTableLayoutGroup.RowDefinitions.Add(New DevExpress.XtraLayout.RowDefinition(tableGroup, 10, System.Windows.Forms.SizeType.Percent))
            Next

            tableGroup.EndUpdate()
            Dim memo1LCI As DevExpress.XtraLayout.LayoutControlItem = tableGroup.AddItem("Memo 1", New DevExpress.XtraEditors.MemoEdit() With {.Name = "Memo1"})
            memo1LCI.OptionsTableLayoutItem.ColumnIndex = 5
            memo1LCI.OptionsTableLayoutItem.RowIndex = 4
        End Sub
    End Module
End Namespace

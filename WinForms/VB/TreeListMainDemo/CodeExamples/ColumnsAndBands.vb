Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Columns and bands", "ColumnsAndBands.cs")>
    Public Module ColumnsAndBands

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            AddHandler treeList.Load, Sub(s, e) treeList.ExpandAll()
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add columns manually"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddVisible")>
        Public Sub AddColumnsManually(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns.AddVisible(fieldName:="Name")
            ' Prohibit edit the column's cells
            colName.OptionsColumn.AllowEdit = False
            ' Use this property to override the TreeList.OptionsCustomization.AllowColumnResizing property's value 
            colName.OptionsColumn.AllowSize = False
            Dim colTypeOfObject As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns.AddVisible(fieldName:="TypeOfObject")
            ' Use this property to override the TreeList.OptionsCustomization.AllowColumnMoving property's value
            colTypeOfObject.OptionsColumn.AllowMove = False
            ' Specifies whether columns can be moved by dragging their headers.
            treeList.OptionsCustomization.AllowColumnMoving = True
            ' Specifies whether columns can be resized by dragging the right edge of their headers.
            treeList.OptionsCustomization.AllowColumnResizing = True
            ' There are no new columns will be added here because the columns set is already predefined
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add bands manually"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddBand", "Add")>
        Public Sub Bands(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' All the columns will be created automatically
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            ' Adding bands
            Dim mainBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand(caption:="Main")
            Dim detailsBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand(caption:="Details")
            ' Adding sub-bands
            Dim markBand As DevExpress.XtraTreeList.Columns.TreeListBand = detailsBand.Bands.AddBand(caption:="Is Checked")
            Dim addInfoBand As DevExpress.XtraTreeList.Columns.TreeListBand = detailsBand.Bands.AddBand(caption:="Additional info")
            ' Adding columns into bands
            mainBand.Columns.Add(treeList.Columns("Name"))
            mainBand.Columns.Add(treeList.Columns("TypeOfObject"))
            markBand.Columns.Add(treeList.Columns("Mark"))
            addInfoBand.Columns.Add(treeList.Columns("Notes"))
            addInfoBand.Columns.Add(treeList.Columns("RecordDate"))
            addInfoBand.Columns.Add(treeList.Columns("MeanRadiusByEarth"))
            addInfoBand.Columns.Add(treeList.Columns("MeanRadiusInKM"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Fixed columns"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Fixed", "FixedLineWidth")>
        Public Sub FixedColumns(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' All the columns will be created automatically
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            treeList.OptionsView.AutoWidth = False
            treeList.Columns(CStr(("Notes"))).Width = 384
            ' Make the specific columns fixed
            treeList.Columns(CStr(("Name"))).Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            treeList.Columns(CStr(("TypeOfObject"))).Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right
            ' Setup the fixed line width
            treeList.FixedLineWidth = 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Fixed bands"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Fixed", "FixedLineWidth")>
        Public Sub FixedBands(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' All the columns will be created automatically
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            treeList.OptionsView.AutoWidth = False
            treeList.Columns(CStr(("Notes"))).Width = 700
            ' Creating bands
            Dim mainBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Main")
            mainBand.Columns.Add(treeList.Columns("Name"))
            Dim detailsBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Details")
            detailsBand.Columns.Add(treeList.Columns("TypeOfObject"))
            detailsBand.Columns.Add(treeList.Columns("Notes"))
            Dim InfoBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Information")
            InfoBand.Columns.Add(treeList.Columns("Mark"))
            InfoBand.Columns.Add(treeList.Columns("RecordDate"))
            ' Make the specific band fixed
            mainBand.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            InfoBand.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right
            ' Setup the fixed line width
            treeList.FixedLineWidth = 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Column separators"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SeparatorWidth")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(181)>
        Public Sub SeparatorColumns(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' All the columns will be created automatically
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            treeList.OptionsView.AutoWidth = True
            ' Enable a separator for a column
            treeList.Columns(CStr(("MeanRadiusInKM"))).SeparatorWidth = 2
            treeList.Appearance.Separator.BackColor = System.Drawing.Color.LightPink
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Band separators"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SeparatorWidth")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(181)>
        Public Sub SeparatorBands(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' All the columns will be created automatically
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            treeList.OptionsView.AutoWidth = True
            ' Creating bands
            Dim mainBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Main")
            mainBand.Columns.Add(treeList.Columns("Name"))
            Dim detailsBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Details")
            detailsBand.Columns.Add(treeList.Columns("TypeOfObject"))
            detailsBand.Columns.Add(treeList.Columns("MeanRadiusInKM"))
            detailsBand.Columns.Add(treeList.Columns("Notes"))
            Dim InfoBand As DevExpress.XtraTreeList.Columns.TreeListBand = treeList.Bands.AddBand("Information")
            InfoBand.Columns.Add(treeList.Columns("Mark"))
            detailsBand.Columns.Add(treeList.Columns("MeanRadiusByEarth"))
            InfoBand.Columns.Add(treeList.Columns("RecordDate"))
            ' Enable separators for a column and band
            detailsBand.SeparatorWidth = 2
            treeList.Columns(CStr(("MeanRadiusInKM"))).SeparatorWidth = 1
            treeList.Appearance.Separator.BackColor = System.Drawing.Color.LightPink
        End Sub
    End Module
End Namespace

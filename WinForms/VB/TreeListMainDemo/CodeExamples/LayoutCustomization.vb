Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraDataLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Layout customization", "LayoutCustomization.cs")>
    Public Module LayoutCustomization

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
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

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class DemoHelper

            Private Shared imagesCore As DevExpress.Utils.ImageCollection

            Public Shared ReadOnly Property Images As DevExpress.Utils.ImageCollection
                Get
                    If Examples.LayoutCustomization.DemoHelper.imagesCore Is Nothing Then
                        Examples.LayoutCustomization.DemoHelper.imagesCore = New DevExpress.Utils.ImageCollection()
                        Call Examples.LayoutCustomization.DemoHelper.AddImage(System.Drawing.Brushes.LightCoral, Examples.LayoutCustomization.DemoHelper.imagesCore)
                        Call Examples.LayoutCustomization.DemoHelper.AddImage(System.Drawing.Brushes.LightGreen, Examples.LayoutCustomization.DemoHelper.imagesCore)
                        Call Examples.LayoutCustomization.DemoHelper.AddImage(System.Drawing.Brushes.LightSkyBlue, Examples.LayoutCustomization.DemoHelper.imagesCore)
                        Call Examples.LayoutCustomization.DemoHelper.AddImage(System.Drawing.Brushes.LightPink, Examples.LayoutCustomization.DemoHelper.imagesCore)
                        Call Examples.LayoutCustomization.DemoHelper.AddImage(System.Drawing.Brushes.LightGray, Examples.LayoutCustomization.DemoHelper.imagesCore)
                    End If

                    Return Examples.LayoutCustomization.DemoHelper.imagesCore
                End Get
            End Property

            Private Shared Sub AddImage(ByVal brush As System.Drawing.Brush, ByVal images As DevExpress.Utils.ImageCollection)
                Dim img As System.Drawing.Image = New System.Drawing.Bitmap(16, 16)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(img)
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                    g.FillEllipse(brush, New System.Drawing.Rectangle(0, 0, img.Width - 1, img.Height - 1))
                End Using

                images.AddImage(img)
            End Sub
        End Class

#End Region
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change Node height dynamically")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcNodeHeight")>
        Public Sub CalcNodeHeight(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' The CalcNodeHeight event fires only if the TreeList.OptionsBehavior.AutoNodeHeight option is disabled.
            treeList.OptionsBehavior.AutoNodeHeight = False
            treeList.RowHeight = 30
            ' Handle the CalcNodeHeight event to assign different node heights to the TreeList control.
            AddHandler treeList.CalcNodeHeight, Sub(sender, e) e.NodeHeight =(e.Node.Level + 1) * e.NodeHeight
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display tree lines")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowTreeLines", "TreeLineStyle")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(181)>
        Public Sub ShowTreeLines(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Show hierarchy lines
            treeList.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.[True]
            ' Hierarchy line style 
            treeList.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Percent50 ' Solid, Light, Dark, Wide, Large
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Assign node images dynamically", New System.Type() {GetType(Examples.LayoutCustomization.DemoHelper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GetSelectImage")>
        Public Sub GetSelectImage(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Assign the source of select images for nodes to this property.
            treeList.SelectImageList = Examples.LayoutCustomization.DemoHelper.Images
            ' Handle this event to dynamically assign select images to nodes.
            AddHandler treeList.GetSelectImage, Sub(s, e)
                ' default case
                e.NodeImageIndex = 4
                ' then specific cases
                If Object.Equals(e.Node("TypeOfObject"), "Asteroid") Then e.NodeImageIndex = If(e.FocusedNode, 0, 1)
                If Object.Equals(e.Node("TypeOfObject"), "Planet") Then e.NodeImageIndex = If(e.FocusedNode, 0, 2)
                If Object.Equals(e.Node("TypeOfObject"), "Satellite") Then e.NodeImageIndex = If(e.FocusedNode, 0, 3)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display row images in cells", New System.Type() {GetType(Examples.LayoutCustomization.DemoHelper)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowImagesShowMode")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(181)>
        Public Sub RowImagesShowMode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Specify the source of select images for nodes.
            treeList.SelectImageList = Examples.LayoutCustomization.DemoHelper.Images
            ' Handle this event to dynamically assign select images to nodes.
            AddHandler treeList.GetSelectImage, Sub(s, e)
                e.NodeImageIndex = -1
                If Object.Equals(e.Node("Mark"), True) Then e.NodeImageIndex = If(e.FocusedNode, 0, 1)
            End Sub
            ' Specify this property to display row images in cells. Available modes: InCell, InIndent.
            treeList.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display node checkboxes")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CheckBoxFieldName")>
        Public Sub ShowCheckBoxes(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Sets the name of the field whose values define the states of built-in check boxes and hide the corresponding column
            treeList.CheckBoxFieldName = "Mark"
            treeList.Columns(CStr(("Mark"))).Visible = False
            ' Enable this property to make nodes show checkboxes
            treeList.OptionsView.ShowCheckBoxes = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Preview text horizontal offset")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewIndent")>
        Public Sub IncreasePreviewIndent(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.PreviewFieldName = "Notes"
            treeList.OptionsView.ShowPreview = True
            ' This property gets or sets the horizontal offset of preview text.
            treeList.PreviewIndent = 55
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = treeList.Parent, .Text = "Increase preview indent", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) treeList.PreviewIndent += 5
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("View customization", "LayoutCustomization.cs")>
    Public Module TreeViewCustomization

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim source As System.Windows.Forms.BindingSource = New System.Windows.Forms.BindingSource()
            source.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            Dim dataLayout As DevExpress.XtraDataLayout.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
            dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            dataLayout.Parent = sampleHost
            dataLayout.DataSource = source
            dataLayout.RetrieveFields()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Left
            treeList.Parent = sampleHost
            treeList.Width = sampleHost.Bounds.Width \ 3
            treeList.DataSource = source
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("TreeView style")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TreeViewFieldName")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(181)>
        Public Sub TreeViewStyle(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            'To display single - column data in the TreeView style, 
            '  specify the display column with the TreeList.TreeViewColumn or TreeList.TreeViewFieldName property.
            treeList.TreeViewFieldName = "Name"
        End Sub
    End Module
End Namespace

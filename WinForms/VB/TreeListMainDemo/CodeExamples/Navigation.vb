Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Keyboard Navigation", "Navigation.cs")>
    Public Module Navigation

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            AddHandler treeList.Load, Sub(s, e)
                treeList.Nodes(CInt((0))).Expand()
                treeList.Nodes(CInt((0))).Nodes(CInt((0))).Expand()
            End Sub
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
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Expand/collapse nodes with left/right arrow keys")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsNavigation", "AllowExpandCollapseWithArrowKeys"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        Public Sub AllowExpandCollapseWithArrowKeys(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsNavigation.AllowExpandCollapseWithArrowKeys = DevExpress.Utils.DefaultBoolean.[True]
        End Sub
    End Module
End Namespace

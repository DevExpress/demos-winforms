Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Preview - read-only row section", "Preview.cs")>
    Public Module Preview

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            treeList.ExpandToLevel(0)
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show preview sections")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewFieldName", "ShowPreview", "AutoCalcPreviewLineCount")>
        Public Sub ShowPreview(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            ' Specify the field name whose values are displayed in preview sections.
            treeList.PreviewFieldName = "Notes"
            ' Preview sections are enabled by setting the TreeListOptionsView.ShowPreview option to true.
            treeList.OptionsView.ShowPreview = True
            ' The TreeList.OptionsView.AutoCalcPreviewLineCount property gets or sets if the number of text lines are calculated automatically
            treeList.OptionsView.AutoCalcPreviewLineCount = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom preview text using an event")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GetPreviewText", "PreviewText")>
        Public Sub DynamicPreviewText(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.PreviewFieldName = "Notes"
            treeList.OptionsView.ShowPreview = True
            treeList.OptionsView.AutoCalcPreviewLineCount = True
            ' Handle this event to supply custom text to preview sections 
            ' or to modify the text provided by the PreviewFieldName field.
            AddHandler treeList.GetPreviewText, Sub(s, e)
                Dim radius As Double = CDbl(e.Node("MeanRadiusByEarth"))
                Dim type As String = CStr(e.Node("TypeOfObject"))
                Dim size As String = If(radius < 1, "Small", "Big")
                e.PreviewText = System.[String].Format("{0} {1}. {2}", size, type, e.PreviewText)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom preview height")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewLineCount")>
        Public Sub PreviewLineCount(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.PreviewFieldName = "Notes"
            treeList.OptionsView.ShowPreview = True
            ' This property controls the height of a preview section (in text lines)
            treeList.PreviewLineCount = 3
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Dynamic Preview height using an event")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MeasurePreviewHeight", "PreviewHeight")>
        Public Sub DynamicPreviewLineCount(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.PreviewFieldName = "Notes"
            treeList.OptionsView.ShowPreview = True
            ' Handle this event to specify a custom height for individual preview sections
            AddHandler treeList.MeasurePreviewHeight, Sub(s, e)
                Dim radius As Double = CDbl(e.Node("MeanRadiusByEarth"))
                If radius > 1 Then
                    e.PreviewHeight = DevExpress.Utils.ScaleUtils.ScaleValue(50)
                Else
                    e.PreviewHeight = 0
                End If
            End Sub
        End Sub
    End Module
End Namespace

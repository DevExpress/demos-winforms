Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.Utils.Behaviors
Imports DevExpress.Utils.Behaviors.Common
Imports DevExpress.XtraTreeList.Features.Behaviors

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucMultiSelectOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub InitDataCore()
            '<optionsPage>
            ceAllowMultiSelect.Checked = TreeList.OptionsSelection.MultiSelect
            imcMultiSelectMode.Properties.Items.AddEnum(GetType(TreeListMultiSelectMode))
            imcMultiSelectMode.EditValue = TreeList.OptionsSelection.MultiSelectMode
            '</optionsPage>
            InitEnabled()
            InitBehaviors()
        End Sub

        Private Sub InitEnabled()
            btnShowSelectedValues.Enabled = ceAllowMultiSelect.Checked
            imcMultiSelectMode.Enabled = btnShowSelectedValues.Enabled
        End Sub

        Private Sub InitBehaviors()
            behaviorManager.SetBehaviors(TreeList, New Behavior() {MultiCellEditBehavior.Create(GetType(TreeListMultiCellEditSource))})
            UpdateMultiCellEditBehavior()
        End Sub

        Private Sub cbMultiSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsSelection.MultiSelectMode = CType(imcMultiSelectMode.EditValue, TreeListMultiSelectMode)
        End Sub

        Private Sub ceAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsSelection.MultiSelect = ceAllowMultiSelect.Checked
            InitEnabled()
        End Sub

        Private Sub ceMultiCellEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateMultiCellEditBehavior()
        End Sub

        Private Sub UpdateMultiCellEditBehavior()
            If ceMultiCellEdit.Checked Then
                behaviorManager.Attach(Of MultiCellEditBehavior)(TreeList)
            Else
                behaviorManager.Detach(Of MultiCellEditBehavior)(TreeList)
            End If
        End Sub

        Private Sub btnShowSelectedValues_Click(ByVal sender As Object, ByVal e As EventArgs)
            Call DemosHelper.ShowDescriptionForm(MousePosition, New Size(400, 600), GetSelectionString(TreeList), If(TreeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect, "Selected Cells", "Selected Rows"))
        End Sub

        Private Function GetSelectionString(ByVal treeList As TreeList) As String
            Dim result As String = ""
            For Each node As TreeListNode In treeList.Selection
                If Not Equals(result, "") Then result += Environment.NewLine
                result += String.Format("#{0}: {1} {2}", treeList.GetVisibleIndexByNode(node), node.GetDisplayText("FirstName"), node.GetDisplayText("LastName"))
                If treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect Then
                    For Each cell As TreeListColumn In treeList.GetSelectedCells(node)
                        result += $"{Environment.NewLine}   {cell.FieldName}: {node.GetDisplayText(cell)}"
                    Next
                End If
            Next

            Return result
        End Function
    End Class
End Namespace

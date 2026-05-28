Imports System.Drawing
Imports DevExpress.XtraToolbox
Imports DevExpress.Utils.Layout
Imports DevExpress.Utils.Extensions
Imports System.Runtime.CompilerServices

Namespace DevExpress.XtraLayout.Demos

    Public Module ToolboxItemExtensions

        <Extension()>
        Public Function CreateToolboxItemImage(ByVal this As ToolboxItem, ByVal foreColor As Color) As Image
            Return ToolboxControlHelper.CreateToolboxItemImage(this.Caption, this.ImageOptions.GetImage(), foreColor)
        End Function
    End Module

    Public Module StackPanelLayoutItemExtensions

        <Extension()>
        Public Function GetDragDropTargetIndex(ByVal this As StackPanelLayoutItem, ByVal point As Point) As Integer
            If this.MarginBounds.BottomHalfRect().Contains(point) Then Return this.Index + 1
            Return this.Index
        End Function
    End Module
End Namespace

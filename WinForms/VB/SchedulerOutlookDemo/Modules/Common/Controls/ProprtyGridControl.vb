Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.ViewInfo
Imports System.Drawing

Namespace DevExpress.XtraScheduler.Demos

    Public Class PropertyListControl
        Inherits PropertyGridControl

        Protected Overrides Function CreateViewInfo(ByVal isPrinting As Boolean) As BaseViewInfo
            Return New MySingleViewInfo(Me, isPrinting)
        End Function
    End Class

    Public Class MySingleViewInfo
        Inherits SingleRecordViewInfo

        Public Sub New(ByVal grid As VGridControlBase, ByVal isPrinting As Boolean)
            MyBase.New(grid, isPrinting)
        End Sub

        Protected Overrides Function GetScrollRect(ByVal windowRect As Rectangle) As Rectangle
            Return Rectangle.Inflate(MyBase.GetScrollRect(windowRect), 1, 1)
        End Function
    End Class
End Namespace

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers

Namespace DevExpress.HTML.Demos

    Public Partial Class ListBoxModule
        Inherits TutorialControlBase

        Private employeesOnline As Dictionary(Of Integer, Boolean)

        Public Sub New()
            InitializeComponent()
            listBoxTemplateCodeViewer1.Fill(listBoxControl, htmlContentPopup)
            listBoxControl.ShowFocusRect = False
            listBoxControl.DataSource = DataHelper.Employees
            AddHandler listBoxControl.CustomizeItem, AddressOf ListBoxControl1_CustomizeItem
            AddHandler listBoxControl.HtmlElementMouseClick, AddressOf ListBoxControl1_HtmlElementMouseClick
            employeesOnline = Enumerable.Range(0, listBoxControl.ItemCount).ToDictionary(Function(x) x, Function(x) TutorialConstants.Random.NextDouble() >= 0.5)
        End Sub

        Private Sub ListBoxControl1_HtmlElementMouseClick(ByVal sender As Object, ByVal e As XtraEditors.ListBoxHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "info") Then
                Dim size = ScaleDPI.ScaleSize(New Size(352, 360))
                Dim location = New Point(e.Bounds.Right - ScaleDPI.ScaleHorizontal(6), e.Bounds.Y + ScaleDPI.ScaleHorizontal(8) - (size.Height - e.Bounds.Height) \ 2)
                Dim tooltipScreenBounds = listBoxControl.RectangleToScreen(New Rectangle(location, size))
                htmlContentPopup.DataContext = e.Item
                htmlContentPopup.Show(Me, tooltipScreenBounds)
            End If
        End Sub

        Private Sub ListBoxControl1_CustomizeItem(ByVal sender As Object, ByVal e As XtraEditors.CustomizeTemplatedItemEventArgs)
            Dim statusBadge = e.HtmlElement?.FindElementById("status")
            Dim online As Boolean = employeesOnline(e.Index)
            If statusBadge IsNot Nothing AndAlso online Then statusBadge.Style.SetBackgroundColor("@Green")
        End Sub
    End Class
End Namespace

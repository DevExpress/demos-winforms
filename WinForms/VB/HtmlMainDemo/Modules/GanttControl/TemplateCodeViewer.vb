Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGantt
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraTreeList

Namespace DevExpress.HTML.Demos

    Public Partial Class TemplateCodeViewer
        Inherits XtraUserControl

        Private currentTemplate As HtmlTemplate = New HtmlTemplate()

        Public Sub New()
            InitializeComponent()
            htmlViewer.ReadOnly = False
            htmlViewer.BorderStyle = BorderStyles.NoBorder
            htmlViewer.ScrollBars = ScrollBars.Both
            htmlViewer.AllowCodeFolding = DefaultBoolean.True
            htmlViewer.ShowIndentGuides = DefaultBoolean.True
            htmlViewer.ShowLineNumbers = DefaultBoolean.True
            cssViewer.ReadOnly = False
            cssViewer.BorderStyle = BorderStyles.NoBorder
            cssViewer.ScrollBars = ScrollBars.Both
            cssViewer.AllowCodeFolding = DefaultBoolean.True
            cssViewer.ShowIndentGuides = DefaultBoolean.True
            cssViewer.ShowLineNumbers = DefaultBoolean.True
        End Sub

        Protected Sub FillEditors(ByVal template As HtmlTemplate)
            htmlViewer.Template = template.Template
            cssViewer.Styles = template.Styles
        End Sub

        Private Sub htmlViewer_CodeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateTemplate()
            LayoutChanged()
        End Sub

        Protected Overridable Sub UpdateTemplate(ByVal templateIndex As Integer, ByVal htmlTemplate As String, ByVal cssStyles As String)
            Templates(templateIndex).Set(htmlTemplate, cssStyles)
        End Sub

        Private Sub UpdateTemplate()
            UpdateTemplate(iceTemplates.SelectedIndex, htmlViewer.Template, cssViewer.Styles)
        End Sub

        Private Sub cssViewer_CodeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateTemplate()
            LayoutChanged()
        End Sub

        Private Sub iceTemplates_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            currentTemplate.Assign(CType(iceTemplates.EditValue, HtmlTemplate))
            FillEditors(currentTemplate)
        End Sub

        Private Sub resetButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Select Case tabControl.SelectedTabPageIndex
                Case 0
                    UpdateHtmlTemplate(iceTemplates.SelectedIndex, currentTemplate.Template)
                    htmlViewer.Template = currentTemplate.Template
                Case 1
                    UpdateCssStyle(iceTemplates.SelectedIndex, currentTemplate.Styles)
                    cssViewer.Styles = currentTemplate.Styles
            End Select

            LayoutChanged()
        End Sub

        Protected Overridable Sub UpdateHtmlTemplate(ByVal templateIndex As Integer, ByVal htmlTemplate As String)
            Templates(templateIndex).Template = htmlTemplate
        End Sub

        Protected Overridable Sub UpdateCssStyle(ByVal templateIndex As Integer, ByVal cssStyle As String)
            Templates(templateIndex).Styles = cssStyle
        End Sub

        Protected Overridable Sub LayoutChanged()
        End Sub

        Protected Sub AddTemplate(ByVal template As HtmlTemplate)
            iceTemplates.Properties.Items.Add(New ImageComboBoxItem(CStr(template.Tag), template, -1))
        End Sub

        Protected Property Templates As List(Of HtmlTemplate)

        Protected Sub FillTemplates(ByVal templates As IEnumerable(Of HtmlTemplate))
            Me.Templates = New List(Of HtmlTemplate)()
            For Each template As HtmlTemplate In templates
                Me.Templates.Add(template)
                AddTemplate(template)
            Next

            If iceTemplates.Properties.Items.Count > 0 Then
                iceTemplates.EditValue = CType(iceTemplates.Properties.Items(0).Value, HtmlTemplate)
                currentTemplate.Assign(CType(iceTemplates.EditValue, HtmlTemplate))
                FillEditors(currentTemplate)
            End If
        End Sub
    End Class

    Public Class GanttTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private owner As GanttControl

        Public Sub Fill(ByVal owner As GanttControl)
            Me.owner = owner
            FillTemplates(owner.HtmlTemplates)
        End Sub

        Protected Overrides Sub LayoutChanged()
            owner.LayoutChanged()
        End Sub
    End Class

    Public Class WinExplorerViewTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private view As WinExplorerView

        Public Sub Fill(ByVal view As WinExplorerView)
            Me.view = view
            Dim templates As List(Of HtmlTemplate) = New List(Of HtmlTemplate)()
            templates.Add(view.OptionsViewStyles.ExtraLarge.HtmlTemplate)
            templates.AddRange(view.HtmlTemplates)
            FillTemplates(templates)
        End Sub

        Protected Overrides Sub LayoutChanged()
            view.LayoutChanged()
        End Sub
    End Class

    Public Class AccordionControlTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private accordion As AccordionControl

        Public Sub Fill(ByVal accordion As AccordionControl, ByVal collection As HtmlTemplateCollection)
            Me.accordion = accordion
            Dim templates As List(Of HtmlTemplate) = New List(Of HtmlTemplate)()
            Dim props = accordion.HtmlTemplates.GetType().GetProperties()
            For Each prop In props
                If prop.PropertyType Is GetType(HtmlTemplate) Then
                    Dim temp As HtmlTemplate = CType(prop.GetValue(accordion.HtmlTemplates), HtmlTemplate)
                    If String.IsNullOrEmpty(temp.Template) Then Continue For
                    temp.Name = prop.Name
                    temp.Tag = prop.Name
                    templates.Add(temp)
                End If
            Next

            If collection IsNot Nothing Then templates.AddRange(collection)
            FillTemplates(templates)
        End Sub

        Protected Overrides Sub LayoutChanged()
        End Sub
    End Class

    Public Class TileViewTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private view As TileView

        Public Sub Fill(ByVal view As TileView)
            Me.view = view
            Dim templates As List(Of HtmlTemplate) = New List(Of HtmlTemplate)()
            templates.Add(view.TileHtmlTemplate)
            FillTemplates(templates)
        End Sub

        Protected Overrides Sub LayoutChanged()
            view.LayoutChanged()
        End Sub
    End Class

    Public Class ListBoxTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private listBox As ListBoxControl

        Public Sub Fill(ByVal listBox As ListBoxControl, ByVal popup As HtmlContentPopup)
            Me.listBox = listBox
            FillTemplates(listBox.HtmlTemplates.Concat({popup.HtmlTemplate}))
        End Sub
    End Class

    Public Class HtmlContentControlCodeViewer
        Inherits TemplateCodeViewer

        Private htmlContentControl As HtmlContentControl

        Public Sub New()
            MyBase.New()
            lciTemplate.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        End Sub

        Public Sub Fill(ByVal htmlContentControl As HtmlContentControl)
            Me.htmlContentControl = htmlContentControl
            FillTemplates(New List(Of HtmlTemplate)() From {htmlContentControl.HtmlTemplate})
        End Sub

        Public Overloads Sub UpdateHtmlTemplate()
            MyBase.UpdateHtmlTemplate(0, htmlContentControl.HtmlTemplate.Template)
            FillEditors(htmlContentControl.HtmlTemplate)
        End Sub
    End Class

    Public Class TreeListTemplateCodeViewer
        Inherits TemplateCodeViewer

        Private treeList As TreeList

        Public Sub Fill(ByVal treeList As TreeList)
            Me.treeList = treeList
            Dim templates = New List(Of HtmlTemplate)()
            templates.Add(treeList.NodeHtmlTemplate)
            templates.AddRange(treeList.HtmlTemplates)
            FillTemplates(templates)
        End Sub

        Protected Overrides Sub LayoutChanged()
            treeList.LayoutChanged()
        End Sub
    End Class
End Namespace

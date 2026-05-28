Imports DevExpress.HTML.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Partial Class FormModule

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.FormModule))
            Me.codeViewerPanel = New DevExpress.XtraEditors.SidePanel()
            Me.templateViewer = New DevExpress.HTML.Demos.FormTemplateViewer()
            Me.hostPanel = New DevExpress.XtraEditors.XtraUserControl()
            Me.htmlTemplateCollection = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.defaultTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.aboutFormTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.contentTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.svgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.codeViewerPanel.SuspendLayout()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' codeViewerPanel
            ' 
            Me.codeViewerPanel.Controls.Add(Me.templateViewer)
            Me.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.codeViewerPanel.Location = New System.Drawing.Point(339, 0)
            Me.codeViewerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.codeViewerPanel.Name = "codeViewerPanel"
            Me.codeViewerPanel.Size = New System.Drawing.Size(320, 405)
            Me.codeViewerPanel.TabIndex = 1
            Me.codeViewerPanel.TabStop = False
            ' 
            ' templateViewer
            ' 
            Me.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateViewer.Margin = New System.Windows.Forms.Padding(6)
            Me.templateViewer.Name = "templateViewer"
            Me.templateViewer.Size = New System.Drawing.Size(319, 405)
            Me.templateViewer.TabIndex = 1
            ' 
            ' hostPanel
            ' 
            Me.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hostPanel.Location = New System.Drawing.Point(0, 0)
            Me.hostPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.hostPanel.Name = "hostPanel"
            Me.hostPanel.Size = New System.Drawing.Size(339, 405)
            Me.hostPanel.TabIndex = 0
            Me.hostPanel.TabStop = False
            AddHandler Me.hostPanel.SizeChanged, New System.EventHandler(AddressOf Me.OnPanelSizeChanged)
            ' 
            ' htmlTemplateCollection
            ' 
            Me.htmlTemplateCollection.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.defaultTemplate, Me.aboutFormTemplate, Me.contentTemplate})
            ' 
            ' defaultTemplate
            ' 
            Me.defaultTemplate.Name = "defaultTemplate"
            Me.defaultTemplate.PreviewType = GetType(DevExpress.XtraEditors.DirectXForm)
            Me.defaultTemplate.Tag = "Default HTML-CSS Template"
            Me.defaultTemplate.Template = resources.GetString("defaultTemplate.Template")
            ' 
            ' aboutFormTemplate
            ' 
            Me.aboutFormTemplate.Name = "aboutFormTemplate"
            Me.aboutFormTemplate.PreviewType = GetType(DevExpress.XtraEditors.DirectXForm)
            Me.aboutFormTemplate.Styles = resources.GetString("aboutFormTemplate.Styles")
            Me.aboutFormTemplate.Template = resources.GetString("aboutFormTemplate.Template")
            ' 
            ' contentTemplate
            ' 
            Me.contentTemplate.Name = "contentTemplate"
            Me.contentTemplate.Styles = resources.GetString("contentTemplate.Styles")
            Me.contentTemplate.Template = "<div class=""content"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""test"">Click the button below to open this for" & "m.</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""btn-outline"" id=""showform"">Show DirectX Form</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div" & ">"
            ' 
            ' svgImages
            ' 
            Me.svgImages.Add("Back", CType((resources.GetObject("svgImages.Back")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Close", CType((resources.GetObject("svgImages.Close")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Forward", CType((resources.GetObject("svgImages.Forward")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Info", CType((resources.GetObject("svgImages.Info")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Search", CType((resources.GetObject("svgImages.Search")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("User", CType((resources.GetObject("svgImages.User")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Add", CType((resources.GetObject("svgImages.Add")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Logo", CType((resources.GetObject("svgImages.Logo")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' FormModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.hostPanel)
            Me.Controls.Add(Me.codeViewerPanel)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "FormModule"
            Me.Size = New System.Drawing.Size(659, 405)
            Me.codeViewerPanel.ResumeLayout(False)
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private defaultTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private aboutFormTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private codeViewerPanel As DevExpress.XtraEditors.SidePanel

        Private templateViewer As DevExpress.HTML.Demos.FormTemplateViewer

        Private hostPanel As DevExpress.XtraEditors.XtraUserControl

        Private svgImages As DevExpress.Utils.SvgImageCollection

        Private htmlTemplateCollection As DevExpress.Utils.Html.HtmlTemplateCollection

        Private contentTemplate As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

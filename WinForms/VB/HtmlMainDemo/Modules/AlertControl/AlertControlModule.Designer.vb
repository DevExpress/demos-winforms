Imports DevExpress.HTML.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Partial Class AlertControlModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.AlertControlModule))
            Me.codeViewerPanel = New DevExpress.XtraEditors.SidePanel()
            Me.templateViewer = New DevExpress.HTML.Demos.AlertControlTemplateViewer()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.svgImageCollection2 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.toastTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.glowTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.simpleTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.darkTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.showAlertButton = New DevExpress.XtraEditors.SimpleButton()
            Me.mainPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.propertiesSeparator = New DevExpress.XtraEditors.SeparatorControl()
            Me.htmlPreview = New DevExpress.XtraEditors.HtmlContentControl()
            Me.buttonPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.propertiesPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.alertInfoProperties = New DevExpress.HTML.Demos.AlertInfoProperties()
            Me.alertControlProperties = New DevExpress.HTML.Demos.AlertControlProperties()
            Me.codeViewerPanel.SuspendLayout()
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.propertiesSeparator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.htmlPreview), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonPanel.SuspendLayout()
            CType((Me.propertiesPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.propertiesPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' codeViewerPanel
            ' 
            Me.codeViewerPanel.Controls.Add(Me.templateViewer)
            Me.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.codeViewerPanel.Location = New System.Drawing.Point(582, 0)
            Me.codeViewerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.codeViewerPanel.Name = "codeViewerPanel"
            Me.codeViewerPanel.Size = New System.Drawing.Size(495, 612)
            Me.codeViewerPanel.TabIndex = 1
            Me.codeViewerPanel.Text = "sidePanel1"
            ' 
            ' templateViewer
            ' 
            Me.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateViewer.Margin = New System.Windows.Forms.Padding(6)
            Me.templateViewer.Name = "templateViewer"
            Me.templateViewer.Size = New System.Drawing.Size(494, 612)
            Me.templateViewer.TabIndex = 0
            ' 
            ' alertControl1
            ' 
            Me.alertControl1.HtmlImages = Me.svgImageCollection2
            Me.alertControl1.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.toastTemplate, Me.glowTemplate, Me.simpleTemplate, Me.darkTemplate})
            ' 
            ' svgImageCollection2
            ' 
            Me.svgImageCollection2.Add("message_icon", "image://svgimages/outlook inspired/glyph_message.svg")
            Me.svgImageCollection2.Add("message_image", "image://svgimages/business objects/bo_lead.svg")
            Me.svgImageCollection2.Add("message_close", "image://svgimages/icon builder/actions_delete.svg")
            ' 
            ' toastTemplate
            ' 
            Me.toastTemplate.Name = "toastTemplate"
            Me.toastTemplate.Styles = resources.GetString("toastTemplate.Styles")
            Me.toastTemplate.Tag = "Toast"
            Me.toastTemplate.Template = resources.GetString("toastTemplate.Template")
            ' 
            ' glowTemplate
            ' 
            Me.glowTemplate.Name = "glowTemplate"
            Me.glowTemplate.Styles = resources.GetString("glowTemplate.Styles")
            Me.glowTemplate.Tag = "Glow"
            Me.glowTemplate.Template = resources.GetString("glowTemplate.Template")
            ' 
            ' simpleTemplate
            ' 
            Me.simpleTemplate.Name = "simpleTemplate"
            Me.simpleTemplate.Styles = resources.GetString("simpleTemplate.Styles")
            Me.simpleTemplate.Tag = "Simple"
            Me.simpleTemplate.Template = resources.GetString("simpleTemplate.Template")
            ' 
            ' darkTemplate
            ' 
            Me.darkTemplate.Name = "darkTemplate"
            Me.darkTemplate.Styles = resources.GetString("darkTemplate.Styles")
            Me.darkTemplate.Tag = "Dark"
            Me.darkTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <div class=""popup"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""text"">${Text}</di" & "v>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "<div id=""closeButton"" class=""content close-button"">CLOSE</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "<" & "/div>"
            ' 
            ' showAlertButton
            ' 
            Me.buttonPanel.SetColumn(Me.showAlertButton, 1)
            Me.showAlertButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.showAlertButton.Location = New System.Drawing.Point(184, 2)
            Me.showAlertButton.Margin = New System.Windows.Forms.Padding(2)
            Me.showAlertButton.Name = "showAlertButton"
            Me.buttonPanel.SetRow(Me.showAlertButton, 0)
            Me.showAlertButton.Size = New System.Drawing.Size(210, 23)
            Me.showAlertButton.TabIndex = 6
            Me.showAlertButton.Text = "Show the Alert"
            AddHandler Me.showAlertButton.Click, New System.EventHandler(AddressOf Me.ShowAlertButton_Click)
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 500F)})
            Me.mainPanel.Controls.Add(Me.propertiesSeparator)
            Me.mainPanel.Controls.Add(Me.htmlPreview)
            Me.mainPanel.Controls.Add(Me.buttonPanel)
            Me.mainPanel.Controls.Add(Me.propertiesPanel)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Margin = New System.Windows.Forms.Padding(2)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 177F)})
            Me.mainPanel.Size = New System.Drawing.Size(582, 612)
            Me.mainPanel.TabIndex = 6
            ' 
            ' propertiesSeparator
            ' 
            Me.mainPanel.SetColumn(Me.propertiesSeparator, 0)
            Me.propertiesSeparator.Location = New System.Drawing.Point(0, 434)
            Me.propertiesSeparator.Margin = New System.Windows.Forms.Padding(0)
            Me.propertiesSeparator.Name = "propertiesSeparator"
            Me.propertiesSeparator.Padding = New System.Windows.Forms.Padding(0)
            Me.mainPanel.SetRow(Me.propertiesSeparator, 3)
            Me.propertiesSeparator.Size = New System.Drawing.Size(582, 2)
            Me.propertiesSeparator.TabIndex = 11
            ' 
            ' htmlPreview
            ' 
            Me.mainPanel.SetColumn(Me.htmlPreview, 0)
            Me.htmlPreview.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlPreview.Location = New System.Drawing.Point(2, 32)
            Me.htmlPreview.Margin = New System.Windows.Forms.Padding(2)
            Me.htmlPreview.Name = "htmlPreview"
            Me.mainPanel.SetRow(Me.htmlPreview, 1)
            Me.htmlPreview.Size = New System.Drawing.Size(578, 293)
            Me.htmlPreview.TabIndex = 10
            ' 
            ' buttonPanel
            ' 
            Me.mainPanel.SetColumn(Me.buttonPanel, 0)
            Me.buttonPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 400F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)})
            Me.buttonPanel.Controls.Add(Me.showAlertButton)
            Me.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.buttonPanel.Location = New System.Drawing.Point(2, 327)
            Me.buttonPanel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 2)
            Me.buttonPanel.Name = "buttonPanel"
            Me.mainPanel.SetRow(Me.buttonPanel, 2)
            Me.buttonPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.buttonPanel.Size = New System.Drawing.Size(578, 105)
            Me.buttonPanel.TabIndex = 9
            ' 
            ' propertiesPanel
            ' 
            Me.mainPanel.SetColumn(Me.propertiesPanel, 0)
            Me.propertiesPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.propertiesPanel.Controls.Add(Me.alertInfoProperties)
            Me.propertiesPanel.Controls.Add(Me.alertControlProperties)
            Me.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertiesPanel.Location = New System.Drawing.Point(2, 438)
            Me.propertiesPanel.Margin = New System.Windows.Forms.Padding(2)
            Me.propertiesPanel.Name = "propertiesPanel"
            Me.mainPanel.SetRow(Me.propertiesPanel, 4)
            Me.propertiesPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.propertiesPanel.Size = New System.Drawing.Size(578, 172)
            Me.propertiesPanel.TabIndex = 8
            ' 
            ' alertInfoProperties
            ' 
            Me.propertiesPanel.SetColumn(Me.alertInfoProperties, 1)
            Me.alertInfoProperties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertInfoProperties.Location = New System.Drawing.Point(292, 3)
            Me.alertInfoProperties.Name = "alertInfoProperties"
            Me.propertiesPanel.SetRow(Me.alertInfoProperties, 0)
            Me.alertInfoProperties.Size = New System.Drawing.Size(283, 166)
            Me.alertInfoProperties.TabIndex = 0
            ' 
            ' alertControlProperties
            ' 
            Me.propertiesPanel.SetColumn(Me.alertControlProperties, 0)
            Me.alertControlProperties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertControlProperties.Location = New System.Drawing.Point(3, 3)
            Me.alertControlProperties.Name = "alertControlProperties"
            Me.propertiesPanel.SetRow(Me.alertControlProperties, 0)
            Me.alertControlProperties.Size = New System.Drawing.Size(283, 166)
            Me.alertControlProperties.TabIndex = 0
            ' 
            ' AlertControlModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.codeViewerPanel)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "AlertControlModule"
            Me.Size = New System.Drawing.Size(1077, 612)
            Me.codeViewerPanel.ResumeLayout(False)
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.propertiesSeparator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.htmlPreview), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonPanel.ResumeLayout(False)
            CType((Me.propertiesPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.propertiesPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private codeViewerPanel As DevExpress.XtraEditors.SidePanel

        Private templateViewer As DevExpress.HTML.Demos.AlertControlTemplateViewer

        Private alertInfoProperties As DevExpress.HTML.Demos.AlertInfoProperties

        Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl

        Private darkTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private simpleTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private svgImageCollection2 As DevExpress.Utils.SvgImageCollection

        Private toastTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private alertControlProperties As DevExpress.HTML.Demos.AlertControlProperties

        Private showAlertButton As DevExpress.XtraEditors.SimpleButton

        Private mainPanel As DevExpress.Utils.Layout.TablePanel

        Private glowTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private propertiesPanel As DevExpress.Utils.Layout.TablePanel

        Private buttonPanel As DevExpress.Utils.Layout.TablePanel

        Private htmlPreview As DevExpress.XtraEditors.HtmlContentControl

        Private propertiesSeparator As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace

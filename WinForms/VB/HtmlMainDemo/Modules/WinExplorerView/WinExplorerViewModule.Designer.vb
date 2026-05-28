Imports DevExpress.HTML.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Partial Class WinExplorerViewModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.WinExplorerViewModule))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.popupDetails = New DevExpress.Utils.Html.HtmlTemplate()
            Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.codeViewerPanel = New DevExpress.XtraEditors.SidePanel()
            Me.templateViewer = New DevExpress.HTML.Demos.WinExplorerViewTemplateCodeViewer()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.codeViewerPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.winExplorerView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(624, 501)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            ' 
            ' winExplorerView1
            ' 
            Me.winExplorerView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((234)))))), (CInt(((CByte((234)))))), (CInt(((CByte((234)))))))
            Me.winExplorerView1.Appearance.EmptySpace.Options.UseBackColor = True
            Me.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView1.GridControl = Me.gridControl1
            Me.winExplorerView1.HtmlImages = Me.svgImageCollection1
            Me.winExplorerView1.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.popupDetails})
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.OptionsHtmlTemplate.AllowContentSelection = DevExpress.Utils.DefaultBoolean.[True]
            Me.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Press
            Me.winExplorerView1.OptionsView.ContentHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.HorizontalIndent = 0
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles")
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Tag = "Card"
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template")
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.VerticalIndent = 0
            Me.winExplorerView1.ViewCaptionHeight = 0
            AddHandler Me.winExplorerView1.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.OnWinExplorerViewKeyDown)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("close", CType((resources.GetObject("svgImageCollection1.close")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' popupDetails
            ' 
            Me.popupDetails.Name = "popupDetails"
            Me.popupDetails.Styles = resources.GetString("popupDetails.Styles")
            Me.popupDetails.Tag = "Popup Details"
            Me.popupDetails.Template = resources.GetString("popupDetails.Template")
            ' 
            ' htmlTemplate1
            ' 
            Me.htmlTemplate1.Name = "htmlTemplate1"
            Me.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles")
            Me.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template")
            ' 
            ' codeViewerPanel
            ' 
            Me.codeViewerPanel.Controls.Add(Me.templateViewer)
            Me.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.codeViewerPanel.Location = New System.Drawing.Point(624, 0)
            Me.codeViewerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.codeViewerPanel.Name = "codeViewerPanel"
            Me.codeViewerPanel.Size = New System.Drawing.Size(277, 501)
            Me.codeViewerPanel.TabIndex = 1
            Me.codeViewerPanel.Text = "sidePanel1"
            ' 
            ' templateViewer
            ' 
            Me.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateViewer.Margin = New System.Windows.Forms.Padding(6)
            Me.templateViewer.Name = "templateViewer"
            Me.templateViewer.Size = New System.Drawing.Size(276, 501)
            Me.templateViewer.TabIndex = 0
            ' 
            ' alertControl1
            ' 
            Me.alertControl1.AutoFormDelay = 2000
            Me.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast
            Me.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopLeft
            Me.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.Reveal
            Me.alertControl1.HtmlTemplate.Styles = resources.GetString("alertControl1.HtmlTemplate.Styles")
            Me.alertControl1.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "    <div class=""shadow"">${Text}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' WinExplorerViewModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.codeViewerPanel)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "WinExplorerViewModule"
            Me.Size = New System.Drawing.Size(901, 501)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.codeViewerPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private winExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private codeViewerPanel As DevExpress.XtraEditors.SidePanel

        Private templateViewer As DevExpress.HTML.Demos.WinExplorerViewTemplateCodeViewer

        Private popupDetails As DevExpress.Utils.Html.HtmlTemplate

        Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace

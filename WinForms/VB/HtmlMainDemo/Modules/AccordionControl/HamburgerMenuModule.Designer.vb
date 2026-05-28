Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Partial Class HamburgerMenuModule

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.HamburgerMenuModule))
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.aceUsers = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acEmployees = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acCustomers = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acVendors = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceProducts = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acVideoPlayers = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acMonitors = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acProjectors = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acTelevisions = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement13 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acVideoPlayers2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acMonitors2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acProjectors2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acTelevisions2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.accordionControlTemplateCodeViewer1 = New DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceUsers, Me.aceProducts, Me.accordionControlElement13})
            Me.accordionControl1.HtmlImages = Me.svgImageCollection1
            Me.accordionControl1.HtmlTemplates.FooterElement.Styles = resources.GetString("accordionControl1.HtmlTemplates.FooterElement.Styles")
            Me.accordionControl1.HtmlTemplates.FooterElement.Template = "<div class=""item"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""image-container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "<img class=""item-image"" src" & "=""${Image}"" width=""24"" height=""24""/>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.accordionControl1.HtmlTemplates.FooterPanel.Styles = resources.GetString("accordionControl1.HtmlTemplates.FooterPanel.Styles")
            Me.accordionControl1.HtmlTemplates.FooterPanel.Template = "<div class=""footer-panel"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div id=""content"" class=""content""></div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Me.accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Styles = resources.GetString("accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Styles")
            Me.accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Template = resources.GetString("accordionControl1.HtmlTemplates.HamburgerHeaderPanel.Template")
            Me.accordionControl1.HtmlTemplates.HamburgerMenuButton.Styles = resources.GetString("accordionControl1.HtmlTemplates.HamburgerMenuButton.Styles")
            Me.accordionControl1.HtmlTemplates.HamburgerMenuButton.Template = resources.GetString("accordionControl1.HtmlTemplates.HamburgerMenuButton.Template")
            Me.accordionControl1.HtmlTemplates.Item.Styles = resources.GetString("accordionControl1.HtmlTemplates.Item.Styles")
            Me.accordionControl1.HtmlTemplates.Item.Template = resources.GetString("accordionControl1.HtmlTemplates.Item.Template")
            Me.accordionControl1.HtmlTemplates.MinimizedElement.Styles = resources.GetString("accordionControl1.HtmlTemplates.MinimizedElement.Styles")
            Me.accordionControl1.HtmlTemplates.MinimizedElement.Template = resources.GetString("accordionControl1.HtmlTemplates.MinimizedElement.Template")
            Me.accordionControl1.Location = New System.Drawing.Point(0, 0)
            Me.accordionControl1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.OptionsMinimizing.PopupFormAutoHeightMode = DevExpress.XtraBars.Navigation.AccordionPopupFormAutoHeightMode.FitContent
            Me.accordionControl1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
            Me.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent
            Me.accordionControl1.Size = New System.Drawing.Size(290, 559)
            Me.accordionControl1.TabIndex = 0
            Me.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
            AddHandler Me.accordionControl1.QueryHtmlElementData, New DevExpress.XtraBars.Navigation.QueryAccordionHtmlElementDataEventHandler(AddressOf Me.accordionControl1_QueryHtmlElementData)
            AddHandler Me.accordionControl1.HtmlElementMouseClick, New DevExpress.XtraBars.Navigation.AccordionHtmlElementEventHandler(AddressOf Me.accordionControl1_HtmlElementMouseClick)
            ' 
            ' aceUsers
            ' 
            Me.aceUsers.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acEmployees, Me.acCustomers, Me.acVendors})
            Me.aceUsers.Expanded = True
            Me.aceUsers.ImageOptions.SvgImage = CType((resources.GetObject("aceUsers.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.aceUsers.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.aceUsers.Name = "aceUsers"
            Me.aceUsers.Text = "MAIN"
            ' 
            ' acEmployees
            ' 
            Me.acEmployees.Appearance.[Default].ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((64)))))), (CInt(((CByte((64)))))))
            Me.acEmployees.Appearance.[Default].Options.UseForeColor = True
            Me.acEmployees.ImageOptions.SvgImage = CType((resources.GetObject("acEmployees.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acEmployees.Name = "acEmployees"
            Me.acEmployees.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acEmployees.Text = "Employees"
            ' 
            ' acCustomers
            ' 
            Me.acCustomers.ImageOptions.SvgImage = CType((resources.GetObject("acCustomers.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acCustomers.Name = "acCustomers"
            Me.acCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acCustomers.Text = "Customers"
            ' 
            ' acVendors
            ' 
            Me.acVendors.ImageOptions.SvgImage = CType((resources.GetObject("acVendors.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acVendors.Name = "acVendors"
            Me.acVendors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acVendors.Text = "Vendors"
            ' 
            ' aceProducts
            ' 
            Me.aceProducts.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acVideoPlayers, Me.acMonitors, Me.acProjectors, Me.acTelevisions})
            Me.aceProducts.Expanded = True
            Me.aceProducts.ImageOptions.SvgImage = CType((resources.GetObject("aceProducts.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.aceProducts.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.aceProducts.Name = "aceProducts"
            Me.aceProducts.Text = "ADMIN"
            ' 
            ' acVideoPlayers
            ' 
            Me.acVideoPlayers.ImageOptions.SvgImage = CType((resources.GetObject("acVideoPlayers.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acVideoPlayers.Name = "acVideoPlayers"
            Me.acVideoPlayers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acVideoPlayers.Text = "Video Players"
            ' 
            ' acMonitors
            ' 
            Me.acMonitors.ImageOptions.SvgImage = CType((resources.GetObject("acMonitors.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acMonitors.Name = "acMonitors"
            Me.acMonitors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acMonitors.Text = "Monitors"
            ' 
            ' acProjectors
            ' 
            Me.acProjectors.ImageOptions.SvgImage = CType((resources.GetObject("acProjectors.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acProjectors.Name = "acProjectors"
            Me.acProjectors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acProjectors.Text = "Projectors"
            ' 
            ' acTelevisions
            ' 
            Me.acTelevisions.ImageOptions.SvgImage = CType((resources.GetObject("acTelevisions.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acTelevisions.Name = "acTelevisions"
            Me.acTelevisions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acTelevisions.Text = "Televisions"
            ' 
            ' accordionControlElement13
            ' 
            Me.accordionControlElement13.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acVideoPlayers2, Me.acMonitors2, Me.acProjectors2, Me.acTelevisions2})
            Me.accordionControlElement13.Expanded = True
            Me.accordionControlElement13.ImageOptions.SvgImage = CType((resources.GetObject("accordionControlElement13.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.accordionControlElement13.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.accordionControlElement13.Name = "accordionControlElement13"
            Me.accordionControlElement13.Text = "CATEGORIES"
            ' 
            ' acVideoPlayers2
            ' 
            Me.acVideoPlayers2.ImageOptions.SvgImage = CType((resources.GetObject("acVideoPlayers2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acVideoPlayers2.Name = "acVideoPlayers2"
            Me.acVideoPlayers2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acVideoPlayers2.Text = "Video Players"
            ' 
            ' acMonitors2
            ' 
            Me.acMonitors2.ImageOptions.SvgImage = CType((resources.GetObject("acMonitors2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acMonitors2.Name = "acMonitors2"
            Me.acMonitors2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acMonitors2.Text = "Monitors"
            ' 
            ' acProjectors2
            ' 
            Me.acProjectors2.ImageOptions.SvgImage = CType((resources.GetObject("acProjectors2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acProjectors2.Name = "acProjectors2"
            Me.acProjectors2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acProjectors2.Text = "Projectors"
            ' 
            ' acTelevisions2
            ' 
            Me.acTelevisions2.ImageOptions.SvgImage = CType((resources.GetObject("acTelevisions2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.acTelevisions2.Name = "acTelevisions2"
            Me.acTelevisions2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acTelevisions2.Text = "Televisions"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.ImageSize = New System.Drawing.Size(20, 20)
            Me.svgImageCollection1.Add("Category", CType((resources.GetObject("svgImageCollection1.Category")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Phone", CType((resources.GetObject("svgImageCollection1.Phone")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("User", CType((resources.GetObject("svgImageCollection1.User")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Collapse", CType((resources.GetObject("svgImageCollection1.Collapse")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Expand", CType((resources.GetObject("svgImageCollection1.Expand")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Search", CType((resources.GetObject("svgImageCollection1.Search")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.accordionControlTemplateCodeViewer1)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel2.Location = New System.Drawing.Point(482, 0)
            Me.sidePanel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(332, 559)
            Me.sidePanel2.TabIndex = 2
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' accordionControlTemplateCodeViewer1
            ' 
            Me.accordionControlTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControlTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.accordionControlTemplateCodeViewer1.Name = "accordionControlTemplateCodeViewer1"
            Me.accordionControlTemplateCodeViewer1.Size = New System.Drawing.Size(331, 559)
            Me.accordionControlTemplateCodeViewer1.TabIndex = 0
            ' 
            ' HamburgerMenuModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel2)
            Me.Controls.Add(Me.accordionControl1)
            Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
            Me.Name = "HamburgerMenuModule"
            Me.Size = New System.Drawing.Size(814, 559)
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private aceUsers As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private accordionControlTemplateCodeViewer1 As DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer

        Private acEmployees As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acCustomers As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acVendors As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private aceProducts As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acVideoPlayers As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acMonitors As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acProjectors As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acTelevisions As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement13 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private acVideoPlayers2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acMonitors2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acProjectors2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private acTelevisions2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    End Class
End Namespace

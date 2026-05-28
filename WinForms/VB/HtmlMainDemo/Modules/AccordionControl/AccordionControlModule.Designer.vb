Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Partial Class AccordionControlModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.AccordionControlModule))
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.shippingControl1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl()
            Me.accordionContentContainer3 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.paymentControl1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.PaymentControl()
            Me.accordionContentContainer4 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.billingControl1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl()
            Me.accordionContentContainer5 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.deliveryControl2 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.DeliveryControl()
            Me.accordionContentContainer6 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.orderSummaryControl1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.OrderSummaryControl()
            Me.comboBoxEdit1 = New DevExpress.HTML.Demos.Modules.AccordionControl.HtmlComboBoxEdit()
            Me.htmlButtonPanel1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButtonPanel()
            Me.htmlCheckBox = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlCheckBoxControl()
            Me.htmlButton1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButton()
            Me.accordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.informationControl1 = New DevExpress.HTML.Demos.Modules.AccordionControl.Controls.InformationControl()
            Me.informationElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.shippingElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.paymentElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.billingElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.deliveryElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.summaryElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlHolder = New DevExpress.XtraEditors.XtraUserControl()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.accordionControlTemplateCodeViewer1 = New DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer()
            Me.htmlTemplateCollection1 = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl1.SuspendLayout()
            Me.accordionContentContainer2.SuspendLayout()
            Me.accordionContentContainer3.SuspendLayout()
            Me.accordionContentContainer4.SuspendLayout()
            Me.accordionContentContainer5.SuspendLayout()
            Me.accordionContentContainer6.SuspendLayout()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer1.SuspendLayout()
            Me.accordionControlHolder.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer2)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer3)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer4)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer5)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer6)
            Me.accordionControl1.Controls.Add(Me.comboBoxEdit1)
            Me.accordionControl1.Controls.Add(Me.htmlButtonPanel1)
            Me.accordionControl1.Controls.Add(Me.htmlCheckBox)
            Me.accordionControl1.Controls.Add(Me.htmlButton1)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer1)
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.informationElement, Me.shippingElement, Me.paymentElement, Me.billingElement, Me.deliveryElement, Me.summaryElement})
            Me.accordionControl1.HtmlTemplates.Item.Styles = resources.GetString("accordionControl1.HtmlTemplates.Item.Styles")
            Me.accordionControl1.HtmlTemplates.Item.Template = resources.GetString("accordionControl1.HtmlTemplates.Item.Template")
            Me.accordionControl1.HtmlTemplates.ItemContent.Styles = resources.GetString("accordionControl1.HtmlTemplates.ItemContent.Styles")
            Me.accordionControl1.HtmlTemplates.ItemContent.Template = "<div class=""item"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""item_layout""></div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            Me.accordionControl1.Location = New System.Drawing.Point(32, 32)
            Me.accordionControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.accordionControl1.Size = New System.Drawing.Size(501, 580)
            Me.accordionControl1.TabIndex = 0
            AddHandler Me.accordionControl1.QueryHtmlElementData, New DevExpress.XtraBars.Navigation.QueryAccordionHtmlElementDataEventHandler(AddressOf Me.accordionControl1_QueryHtmlElementData)
            AddHandler Me.accordionControl1.ExpandStateChanging, New DevExpress.XtraBars.Navigation.ExpandStateChangingEventHandler(AddressOf Me.accordionControl1_ExpandStateChanging)
            ' 
            ' accordionContentContainer2
            ' 
            Me.accordionContentContainer2.Controls.Add(Me.shippingControl1)
            Me.accordionContentContainer2.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer2.Name = "accordionContentContainer2"
            Me.accordionContentContainer2.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer2.Size = New System.Drawing.Size(482, 355)
            Me.accordionContentContainer2.TabIndex = 3
            ' 
            ' shippingControl1
            ' 
            Me.shippingControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.shippingControl1.Location = New System.Drawing.Point(72, 30)
            Me.shippingControl1.Name = "shippingControl1"
            Me.shippingControl1.Size = New System.Drawing.Size(330, 307)
            Me.shippingControl1.TabIndex = 0
            ' 
            ' accordionContentContainer3
            ' 
            Me.accordionContentContainer3.Controls.Add(Me.paymentControl1)
            Me.accordionContentContainer3.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer3.Name = "accordionContentContainer3"
            Me.accordionContentContainer3.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer3.Size = New System.Drawing.Size(482, 245)
            Me.accordionContentContainer3.TabIndex = 4
            ' 
            ' paymentControl1
            ' 
            Me.paymentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.paymentControl1.Location = New System.Drawing.Point(72, 30)
            Me.paymentControl1.Name = "paymentControl1"
            Me.paymentControl1.Size = New System.Drawing.Size(330, 197)
            Me.paymentControl1.TabIndex = 0
            ' 
            ' accordionContentContainer4
            ' 
            Me.accordionContentContainer4.Controls.Add(Me.billingControl1)
            Me.accordionContentContainer4.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer4.Name = "accordionContentContainer4"
            Me.accordionContentContainer4.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer4.Size = New System.Drawing.Size(482, 349)
            Me.accordionContentContainer4.TabIndex = 5
            ' 
            ' billingControl1
            ' 
            Me.billingControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.billingControl1.Location = New System.Drawing.Point(72, 30)
            Me.billingControl1.Name = "billingControl1"
            Me.billingControl1.Size = New System.Drawing.Size(330, 301)
            Me.billingControl1.TabIndex = 0
            ' 
            ' accordionContentContainer5
            ' 
            Me.accordionContentContainer5.Controls.Add(Me.deliveryControl2)
            Me.accordionContentContainer5.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer5.Name = "accordionContentContainer5"
            Me.accordionContentContainer5.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer5.Size = New System.Drawing.Size(482, 252)
            Me.accordionContentContainer5.TabIndex = 6
            ' 
            ' deliveryControl2
            ' 
            Me.deliveryControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.deliveryControl2.Location = New System.Drawing.Point(72, 30)
            Me.deliveryControl2.Name = "deliveryControl2"
            Me.deliveryControl2.Size = New System.Drawing.Size(330, 204)
            Me.deliveryControl2.TabIndex = 0
            ' 
            ' accordionContentContainer6
            ' 
            Me.accordionContentContainer6.Controls.Add(Me.orderSummaryControl1)
            Me.accordionContentContainer6.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer6.Name = "accordionContentContainer6"
            Me.accordionContentContainer6.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer6.Size = New System.Drawing.Size(482, 233)
            Me.accordionContentContainer6.TabIndex = 7
            ' 
            ' orderSummaryControl1
            ' 
            Me.orderSummaryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.orderSummaryControl1.Location = New System.Drawing.Point(72, 30)
            Me.orderSummaryControl1.Name = "orderSummaryControl1"
            Me.orderSummaryControl1.Size = New System.Drawing.Size(330, 185)
            Me.orderSummaryControl1.TabIndex = 0
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.EditValue = ""
            Me.comboBoxEdit1.Location = New System.Drawing.Point(286, 332)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.comboBoxEdit1.Properties.AutoHeight = False
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.NullValuePrompt = "Select Address..."
            Me.comboBoxEdit1.Properties.ShowNullValuePrompt = CType(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)), DevExpress.XtraEditors.ShowNullValuePromptOptions)
            Me.comboBoxEdit1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.comboBoxEdit1.Size = New System.Drawing.Size(191, 42)
            Me.comboBoxEdit1.TabIndex = 3
            ' 
            ' htmlButtonPanel1
            ' 
            Me.htmlButtonPanel1.Location = New System.Drawing.Point(318, 752)
            Me.htmlButtonPanel1.Name = "htmlButtonPanel1"
            Me.htmlButtonPanel1.Size = New System.Drawing.Size(176, 47)
            Me.htmlButtonPanel1.TabIndex = 1
            ' 
            ' htmlCheckBox
            ' 
            Me.htmlCheckBox.Location = New System.Drawing.Point(278, 1055)
            Me.htmlCheckBox.Name = "htmlCheckBox"
            Me.htmlCheckBox.Size = New System.Drawing.Size(215, 42)
            Me.htmlCheckBox.TabIndex = 3
            ' 
            ' htmlButton1
            ' 
            Me.htmlButton1.Location = New System.Drawing.Point(325, 596)
            Me.htmlButton1.Name = "htmlButton1"
            Me.htmlButton1.Size = New System.Drawing.Size(129, 56)
            Me.htmlButton1.TabIndex = 1
            Me.htmlButton1.Text = "Place Order"
            ' 
            ' accordionContentContainer1
            ' 
            Me.accordionContentContainer1.Controls.Add(Me.informationControl1)
            Me.accordionContentContainer1.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer1.Name = "accordionContentContainer1"
            Me.accordionContentContainer1.Padding = New System.Windows.Forms.Padding(72, 30, 80, 18)
            Me.accordionContentContainer1.Size = New System.Drawing.Size(482, 240)
            Me.accordionContentContainer1.TabIndex = 1
            ' 
            ' informationControl1
            ' 
            Me.informationControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.informationControl1.Location = New System.Drawing.Point(72, 30)
            Me.informationControl1.Name = "informationControl1"
            Me.informationControl1.Size = New System.Drawing.Size(330, 192)
            Me.informationControl1.TabIndex = 0
            ' 
            ' informationElement
            ' 
            Me.informationElement.ContentContainer = Me.accordionContentContainer1
            Me.informationElement.Expanded = True
            Me.informationElement.ImageOptions.SvgImage = CType((resources.GetObject("informationElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.informationElement.Name = "informationElement"
            Me.informationElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.informationElement.Text = "Personal Information"
            ' 
            ' shippingElement
            ' 
            Me.shippingElement.ContentContainer = Me.accordionContentContainer2
            Me.shippingElement.Expanded = True
            Me.shippingElement.HeaderControl = Me.comboBoxEdit1
            Me.shippingElement.ImageOptions.SvgImage = CType((resources.GetObject("shippingElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.shippingElement.Name = "shippingElement"
            Me.shippingElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.shippingElement.Text = "Shipping Address"
            ' 
            ' paymentElement
            ' 
            Me.paymentElement.ContentContainer = Me.accordionContentContainer3
            Me.paymentElement.Expanded = True
            Me.paymentElement.HeaderControl = Me.htmlButtonPanel1
            Me.paymentElement.ImageOptions.SvgImage = CType((resources.GetObject("paymentElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.paymentElement.Name = "paymentElement"
            Me.paymentElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.paymentElement.Text = "Payment Method"
            ' 
            ' billingElement
            ' 
            Me.billingElement.ContentContainer = Me.accordionContentContainer4
            Me.billingElement.Expanded = True
            Me.billingElement.HeaderControl = Me.htmlCheckBox
            Me.billingElement.ImageOptions.SvgImage = CType((resources.GetObject("billingElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.billingElement.Name = "billingElement"
            Me.billingElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.billingElement.Text = "Billing Address"
            ' 
            ' deliveryElement
            ' 
            Me.deliveryElement.ContentContainer = Me.accordionContentContainer5
            Me.deliveryElement.Expanded = True
            Me.deliveryElement.ImageOptions.SvgImage = CType((resources.GetObject("deliveryElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.deliveryElement.Name = "deliveryElement"
            Me.deliveryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.deliveryElement.Text = "Delivery"
            ' 
            ' summaryElement
            ' 
            Me.summaryElement.ContentContainer = Me.accordionContentContainer6
            Me.summaryElement.Expanded = True
            Me.summaryElement.HeaderControl = Me.htmlButton1
            Me.summaryElement.ImageOptions.SvgImage = CType((resources.GetObject("summaryElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.summaryElement.Name = "summaryElement"
            Me.summaryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.summaryElement.Text = "Checkout"
            ' 
            ' accordionControlHolder
            ' 
            Me.accordionControlHolder.Controls.Add(Me.accordionControl1)
            Me.accordionControlHolder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControlHolder.Location = New System.Drawing.Point(0, 0)
            Me.accordionControlHolder.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionControlHolder.MinimumSize = New System.Drawing.Size(75, 0)
            Me.accordionControlHolder.Name = "accordionControlHolder"
            Me.accordionControlHolder.Padding = New System.Windows.Forms.Padding(32)
            Me.accordionControlHolder.Size = New System.Drawing.Size(565, 644)
            Me.accordionControlHolder.TabIndex = 1
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.accordionControlTemplateCodeViewer1)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel2.Location = New System.Drawing.Point(565, 0)
            Me.sidePanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(250, 644)
            Me.sidePanel2.TabIndex = 2
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' accordionControlTemplateCodeViewer1
            ' 
            Me.accordionControlTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControlTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.accordionControlTemplateCodeViewer1.Margin = New System.Windows.Forms.Padding(4)
            Me.accordionControlTemplateCodeViewer1.Name = "accordionControlTemplateCodeViewer1"
            Me.accordionControlTemplateCodeViewer1.Size = New System.Drawing.Size(249, 644)
            Me.accordionControlTemplateCodeViewer1.TabIndex = 0
            ' 
            ' htmlTemplateCollection1
            ' 
            Me.htmlTemplateCollection1.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.htmlTemplate1})
            ' 
            ' htmlTemplate1
            ' 
            Me.htmlTemplate1.Name = "htmlTemplate1"
            Me.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles")
            Me.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template")
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("dropdown", CType((resources.GetObject("svgImageCollection1.dropdown")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("checkmark", CType((resources.GetObject("svgImageCollection1.checkmark")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("paypal", CType((resources.GetObject("svgImageCollection1.paypal")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("cash", CType((resources.GetObject("svgImageCollection1.cash")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("card", CType((resources.GetObject("svgImageCollection1.card")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' AccordionControlModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.accordionControlHolder)
            Me.Controls.Add(Me.sidePanel2)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AccordionControlModule"
            Me.Size = New System.Drawing.Size(815, 644)
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl1.ResumeLayout(False)
            Me.accordionContentContainer2.ResumeLayout(False)
            Me.accordionContentContainer3.ResumeLayout(False)
            Me.accordionContentContainer4.ResumeLayout(False)
            Me.accordionContentContainer5.ResumeLayout(False)
            Me.accordionContentContainer6.ResumeLayout(False)
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer1.ResumeLayout(False)
            Me.accordionControlHolder.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private informationElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlHolder As DevExpress.XtraEditors.XtraUserControl

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private accordionControlTemplateCodeViewer1 As DevExpress.HTML.Demos.AccordionControlTemplateCodeViewer

        Private shippingElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private paymentElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private billingElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private deliveryElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private summaryElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer3 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer4 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer5 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer6 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private comboBoxEdit1 As DevExpress.HTML.Demos.Modules.AccordionControl.HtmlComboBoxEdit

        Private htmlTemplateCollection1 As DevExpress.Utils.Html.HtmlTemplateCollection

        Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate

        Private informationControl1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.InformationControl

        Private shippingControl1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private paymentControl1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.PaymentControl

        Private billingControl1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl

        Private htmlButtonPanel1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButtonPanel

        Private htmlCheckBox As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlCheckBoxControl

        Private deliveryControl2 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.DeliveryControl

        Private orderSummaryControl1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.OrderSummaryControl

        Private htmlButton1 As DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButton
    End Class
End Namespace

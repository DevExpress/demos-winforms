Namespace DevExpress.HTML.Demos

    Partial Class Lab

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Lab))
            Me.htmlCodeViewer = New DevExpress.XtraEditors.Internal.HtmlCodeViewer()
            Me.cssCodeViewer = New DevExpress.XtraEditors.Internal.CssCodeViewer()
            Me.htmlContentControl = New DevExpress.HTML.Demos.CustomHtmlControl()
            Me.textEditPhone = New DevExpress.XtraEditors.TextEdit()
            Me.textEditEmail = New DevExpress.XtraEditors.TextEdit()
            Me.textEditFullName = New DevExpress.XtraEditors.TextEdit()
            Me.textEditDisplayName = New DevExpress.XtraEditors.TextEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.leftPanel = New DevExpress.XtraEditors.SidePanel()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.resetButton = New DevExpress.XtraEditors.SimpleButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciResetButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.htmlCodeViewerLCG = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cssCodeViewerLCG = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.htmlContentControl.SuspendLayout()
            CType((Me.textEditPhone.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditEmail.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditFullName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditDisplayName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.leftPanel.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciResetButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.htmlCodeViewerLCG), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cssCodeViewerLCG), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' htmlCodeViewer
            ' 
            Me.htmlCodeViewer.EnableIXtraResizeableControlInterfaceProxy = False
            Me.htmlCodeViewer.Location = New System.Drawing.Point(13, 36)
            Me.htmlCodeViewer.Name = "htmlCodeViewer"
            Me.htmlCodeViewer.Size = New System.Drawing.Size(471, 572)
            Me.htmlCodeViewer.TabIndex = 1
            ' 
            ' cssCodeViewer
            ' 
            Me.cssCodeViewer.EnableIXtraResizeableControlInterfaceProxy = False
            Me.cssCodeViewer.Location = New System.Drawing.Point(13, 36)
            Me.cssCodeViewer.Name = "cssCodeViewer"
            Me.cssCodeViewer.Size = New System.Drawing.Size(471, 572)
            Me.cssCodeViewer.TabIndex = 2
            ' 
            ' htmlContentControl
            ' 
            Me.htmlContentControl.Controls.Add(Me.textEditPhone)
            Me.htmlContentControl.Controls.Add(Me.textEditEmail)
            Me.htmlContentControl.Controls.Add(Me.textEditFullName)
            Me.htmlContentControl.Controls.Add(Me.textEditDisplayName)
            Me.htmlContentControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlContentControl.HtmlImages = Me.svgImageCollection1
            Me.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles")
            Me.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template")
            Me.htmlContentControl.Location = New System.Drawing.Point(10, 10)
            Me.htmlContentControl.Name = "htmlContentControl"
            Me.htmlContentControl.Size = New System.Drawing.Size(539, 627)
            Me.htmlContentControl.TabIndex = 0
            ' 
            ' textEditPhone
            ' 
            Me.textEditPhone.EditValue = "(562) 559-5830"
            Me.textEditPhone.Location = New System.Drawing.Point(291, 290)
            Me.textEditPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditPhone.Name = "textEditPhone"
            Me.textEditPhone.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditPhone.Properties.Appearance.Options.UseFont = True
            Me.textEditPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditPhone.Size = New System.Drawing.Size(201, 18)
            Me.textEditPhone.TabIndex = 7
            ' 
            ' textEditEmail
            ' 
            Me.textEditEmail.EditValue = "leahs@dx-email.com"
            Me.textEditEmail.Location = New System.Drawing.Point(47, 290)
            Me.textEditEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditEmail.Name = "textEditEmail"
            Me.textEditEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditEmail.Properties.Appearance.Options.UseFont = True
            Me.textEditEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditEmail.Size = New System.Drawing.Size(202, 18)
            Me.textEditEmail.TabIndex = 6
            ' 
            ' textEditFullName
            ' 
            Me.textEditFullName.EditValue = "Leah Simpson"
            Me.textEditFullName.Location = New System.Drawing.Point(291, 181)
            Me.textEditFullName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditFullName.Name = "textEditFullName"
            Me.textEditFullName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditFullName.Properties.Appearance.Options.UseFont = True
            Me.textEditFullName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditFullName.Size = New System.Drawing.Size(201, 18)
            Me.textEditFullName.TabIndex = 5
            ' 
            ' textEditDisplayName
            ' 
            Me.textEditDisplayName.EditValue = "Leah Test Coordinator"
            Me.textEditDisplayName.Location = New System.Drawing.Point(47, 181)
            Me.textEditDisplayName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditDisplayName.Name = "textEditDisplayName"
            Me.textEditDisplayName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditDisplayName.Properties.Appearance.Options.UseFont = True
            Me.textEditDisplayName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditDisplayName.Size = New System.Drawing.Size(202, 18)
            Me.textEditDisplayName.TabIndex = 4
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("employee", "image://svgimages/business objects/bo_lead.svg")
            Me.svgImageCollection1.Add("phone", "image://svgimages/outlook inspired/glyph_phone.svg")
            Me.svgImageCollection1.Add("contact", "image://svgimages/business objects/bo_contact.svg")
            Me.svgImageCollection1.Add("message", "image://svgimages/outlook inspired/glyph_message.svg")
            Me.svgImageCollection1.Add("signin", "image://svgimages/scheduling/timezones.svg")
            ' 
            ' leftPanel
            ' 
            Me.leftPanel.Controls.Add(Me.layoutControl1)
            Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.leftPanel.Location = New System.Drawing.Point(559, 0)
            Me.leftPanel.Name = "leftPanel"
            Me.leftPanel.Size = New System.Drawing.Size(498, 647)
            Me.leftPanel.TabIndex = 2
            Me.leftPanel.Text = "sidePanel1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.htmlCodeViewer)
            Me.layoutControl1.Controls.Add(Me.cssCodeViewer)
            Me.layoutControl1.Controls.Add(Me.resetButton)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(1, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1172, 221, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(497, 647)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' resetButton
            ' 
            Me.resetButton.Location = New System.Drawing.Point(12, 613)
            Me.resetButton.Name = "resetButton"
            Me.resetButton.Size = New System.Drawing.Size(473, 22)
            Me.resetButton.StyleController = Me.layoutControl1
            Me.resetButton.TabIndex = 6
            Me.resetButton.Text = "Reset To Default"
            AddHandler Me.resetButton.Click, New System.EventHandler(AddressOf Me.resetButton_Click)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciResetButton, Me.tabbedControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(497, 647)
            Me.Root.TextVisible = False
            ' 
            ' lciResetButton
            ' 
            Me.lciResetButton.Control = Me.resetButton
            Me.lciResetButton.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.lciResetButton.CustomizationFormText = "lciResetButton"
            Me.lciResetButton.Location = New System.Drawing.Point(0, 601)
            Me.lciResetButton.Name = "lciResetButton"
            Me.lciResetButton.Size = New System.Drawing.Size(477, 26)
            Me.lciResetButton.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.tabbedControlGroup1.SelectedTabPage = Me.htmlCodeViewerLCG
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(477, 601)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.htmlCodeViewerLCG, Me.cssCodeViewerLCG})
            ' 
            ' htmlCodeViewerLCG
            ' 
            Me.htmlCodeViewerLCG.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.htmlCodeViewerLCG.Location = New System.Drawing.Point(0, 0)
            Me.htmlCodeViewerLCG.Name = "htmlCodeViewerLCG"
            Me.htmlCodeViewerLCG.Size = New System.Drawing.Size(471, 572)
            Me.htmlCodeViewerLCG.Text = "HTML"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.htmlCodeViewer
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(471, 572)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' cssCodeViewerLCG
            ' 
            Me.cssCodeViewerLCG.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.cssCodeViewerLCG.Location = New System.Drawing.Point(0, 0)
            Me.cssCodeViewerLCG.Name = "cssCodeViewerLCG"
            Me.cssCodeViewerLCG.Size = New System.Drawing.Size(471, 572)
            Me.cssCodeViewerLCG.Text = "CSS"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cssCodeViewer
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(471, 572)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.htmlContentControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(10)
            Me.panelControl1.Size = New System.Drawing.Size(559, 647)
            Me.panelControl1.TabIndex = 8
            ' 
            ' Lab
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.leftPanel)
            Me.Name = "Lab"
            Me.Padding = New System.Windows.Forms.Padding(0)
            Me.Size = New System.Drawing.Size(1057, 647)
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.htmlContentControl.ResumeLayout(False)
            CType((Me.textEditPhone.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditEmail.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditFullName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditDisplayName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.leftPanel.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciResetButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.htmlCodeViewerLCG), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cssCodeViewerLCG), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlCodeViewer As DevExpress.XtraEditors.Internal.HtmlCodeViewer

        Private cssCodeViewer As DevExpress.XtraEditors.Internal.CssCodeViewer

        Private htmlContentControl As DevExpress.HTML.Demos.CustomHtmlControl

        Private leftPanel As DevExpress.XtraEditors.SidePanel

        Private delayTimer As System.Windows.Forms.Timer

        Private textEditPhone As DevExpress.XtraEditors.TextEdit

        Private textEditEmail As DevExpress.XtraEditors.TextEdit

        Private textEditFullName As DevExpress.XtraEditors.TextEdit

        Private textEditDisplayName As DevExpress.XtraEditors.TextEdit

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private resetButton As DevExpress.XtraEditors.SimpleButton

        Private lciResetButton As DevExpress.XtraLayout.LayoutControlItem

        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup

        Private htmlCodeViewerLCG As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private cssCodeViewerLCG As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

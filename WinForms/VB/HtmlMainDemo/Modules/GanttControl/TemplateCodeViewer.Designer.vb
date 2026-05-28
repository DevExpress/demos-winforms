Imports DevExpress.XtraEditors.Internal

Namespace DevExpress.HTML.Demos

    Partial Class TemplateCodeViewer

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
            Me.cssViewer = New DevExpress.XtraEditors.Internal.CssCodeViewer()
            Me.htmlViewer = New DevExpress.XtraEditors.Internal.HtmlCodeViewer()
            Me.mainLayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.resetButton = New DevExpress.XtraEditors.SimpleButton()
            Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.htmlPage = New DevExpress.XtraTab.XtraTabPage()
            Me.cssPage = New DevExpress.XtraTab.XtraTabPage()
            Me.iceTemplates = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciTemplate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTabs = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciResetButton = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mainLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainLayoutControl.SuspendLayout()
            CType((Me.tabControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl.SuspendLayout()
            Me.htmlPage.SuspendLayout()
            Me.cssPage.SuspendLayout()
            CType((Me.iceTemplates.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTemplate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTabs), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciResetButton), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cssViewer
            ' 
            Me.cssViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cssViewer.Location = New System.Drawing.Point(0, 0)
            Me.cssViewer.Margin = New System.Windows.Forms.Padding(5, 5, 10, 5)
            Me.cssViewer.Name = "cssViewer"
            Me.cssViewer.Size = New System.Drawing.Size(412, 382)
            Me.cssViewer.TabIndex = 1
            AddHandler Me.cssViewer.CodeChanged, New System.EventHandler(AddressOf Me.cssViewer_CodeChanged)
            ' 
            ' htmlViewer
            ' 
            Me.htmlViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlViewer.Location = New System.Drawing.Point(0, 0)
            Me.htmlViewer.Margin = New System.Windows.Forms.Padding(10, 5, 5, 5)
            Me.htmlViewer.Name = "htmlViewer"
            Me.htmlViewer.Size = New System.Drawing.Size(412, 382)
            Me.htmlViewer.TabIndex = 0
            AddHandler Me.htmlViewer.CodeChanged, New System.EventHandler(AddressOf Me.htmlViewer_CodeChanged)
            ' 
            ' mainLayoutControl
            ' 
            Me.mainLayoutControl.AllowCustomization = False
            Me.mainLayoutControl.Controls.Add(Me.resetButton)
            Me.mainLayoutControl.Controls.Add(Me.tabControl)
            Me.mainLayoutControl.Controls.Add(Me.iceTemplates)
            Me.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.mainLayoutControl.Name = "mainLayoutControl"
            Me.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(893, 435, 650, 400)
            Me.mainLayoutControl.Root = Me.Root
            Me.mainLayoutControl.Size = New System.Drawing.Size(438, 504)
            Me.mainLayoutControl.TabIndex = 2
            Me.mainLayoutControl.Text = "layoutControl1"
            ' 
            ' resetButton
            ' 
            Me.resetButton.Location = New System.Drawing.Point(12, 470)
            Me.resetButton.Name = "resetButton"
            Me.resetButton.Size = New System.Drawing.Size(414, 22)
            Me.resetButton.StyleController = Me.mainLayoutControl
            Me.resetButton.TabIndex = 6
            Me.resetButton.Text = "Reset to Default"
            AddHandler Me.resetButton.Click, New System.EventHandler(AddressOf Me.resetButton_Click)
            ' 
            ' tabControl
            ' 
            Me.tabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tabControl.Location = New System.Drawing.Point(12, 59)
            Me.tabControl.Name = "tabControl"
            Me.tabControl.SelectedTabPage = Me.htmlPage
            Me.tabControl.Size = New System.Drawing.Size(414, 407)
            Me.tabControl.TabIndex = 5
            Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.htmlPage, Me.cssPage})
            ' 
            ' htmlPage
            ' 
            Me.htmlPage.Controls.Add(Me.htmlViewer)
            Me.htmlPage.Name = "htmlPage"
            Me.htmlPage.Size = New System.Drawing.Size(412, 382)
            Me.htmlPage.Text = "HTML"
            ' 
            ' cssPage
            ' 
            Me.cssPage.Controls.Add(Me.cssViewer)
            Me.cssPage.Name = "cssPage"
            Me.cssPage.Size = New System.Drawing.Size(412, 382)
            Me.cssPage.Text = "CSS"
            ' 
            ' iceTemplates
            ' 
            Me.iceTemplates.Location = New System.Drawing.Point(12, 27)
            Me.iceTemplates.Name = "iceTemplates"
            Me.iceTemplates.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.iceTemplates.Size = New System.Drawing.Size(414, 20)
            Me.iceTemplates.StyleController = Me.mainLayoutControl
            Me.iceTemplates.TabIndex = 4
            AddHandler Me.iceTemplates.SelectedIndexChanged, New System.EventHandler(AddressOf Me.iceTemplates_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTemplate, Me.lciTabs, Me.lciResetButton})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(438, 504)
            Me.Root.TextVisible = False
            ' 
            ' lciTemplate
            ' 
            Me.lciTemplate.Control = Me.iceTemplates
            Me.lciTemplate.Location = New System.Drawing.Point(0, 0)
            Me.lciTemplate.Name = "lciTemplate"
            Me.lciTemplate.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 1, 10)
            Me.lciTemplate.Size = New System.Drawing.Size(418, 47)
            Me.lciTemplate.Text = "Template:"
            Me.lciTemplate.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciTemplate.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' lciTabs
            ' 
            Me.lciTabs.Control = Me.tabControl
            Me.lciTabs.CustomizationFormText = "lciTabs"
            Me.lciTabs.Location = New System.Drawing.Point(0, 47)
            Me.lciTabs.Name = "lciTabs"
            Me.lciTabs.Size = New System.Drawing.Size(418, 411)
            Me.lciTabs.TextSize = New System.Drawing.Size(0, 0)
            Me.lciTabs.TextVisible = False
            ' 
            ' lciResetButton
            ' 
            Me.lciResetButton.Control = Me.resetButton
            Me.lciResetButton.CustomizationFormText = "lciResetButton"
            Me.lciResetButton.Location = New System.Drawing.Point(0, 458)
            Me.lciResetButton.Name = "lciResetButton"
            Me.lciResetButton.Size = New System.Drawing.Size(418, 26)
            Me.lciResetButton.TextSize = New System.Drawing.Size(0, 0)
            Me.lciResetButton.TextVisible = False
            ' 
            ' TemplateCodeViewer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainLayoutControl)
            Me.Name = "TemplateCodeViewer"
            Me.Size = New System.Drawing.Size(438, 504)
            CType((Me.mainLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainLayoutControl.ResumeLayout(False)
            CType((Me.tabControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl.ResumeLayout(False)
            Me.htmlPage.ResumeLayout(False)
            Me.cssPage.ResumeLayout(False)
            CType((Me.iceTemplates.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTemplate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTabs), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciResetButton), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private cssViewer As DevExpress.XtraEditors.Internal.CssCodeViewer

        Private htmlViewer As DevExpress.XtraEditors.Internal.HtmlCodeViewer

        Private mainLayoutControl As DevExpress.XtraLayout.LayoutControl

        Private resetButton As DevExpress.XtraEditors.SimpleButton

        Private tabControl As DevExpress.XtraTab.XtraTabControl

        Private htmlPage As DevExpress.XtraTab.XtraTabPage

        Private cssPage As DevExpress.XtraTab.XtraTabPage

        Protected iceTemplates As DevExpress.XtraEditors.ImageComboBoxEdit

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Protected lciTemplate As DevExpress.XtraLayout.LayoutControlItem

        Private lciTabs As DevExpress.XtraLayout.LayoutControlItem

        Private lciResetButton As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

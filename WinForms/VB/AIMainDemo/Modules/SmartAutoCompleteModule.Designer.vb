Namespace DevExpress.AI.Demos

    Partial Class SmartAutoCompleteModule

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

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.roundedSkinPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciRoundedSkinPanel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxEditUserRole = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.aiEvents1 = New DevExpress.AIIntegration.WinForms.AIEvents()
            CType((Me.roundedSkinPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRoundedSkinPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.comboBoxEditUserRole.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' roundedSkinPanel
            ' 
            Me.roundedSkinPanel.Controls.Add(Me.panelControl1)
            Me.roundedSkinPanel.Location = New System.Drawing.Point(0, 103)
            Me.roundedSkinPanel.Name = "roundedSkinPanel"
            Me.roundedSkinPanel.Size = New System.Drawing.Size(784, 329)
            Me.roundedSkinPanel.TabIndex = 7
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.memoEdit1)
            Me.panelControl1.Controls.Add(Me.sidePanel1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(17, 17)
            Me.panelControl1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(750, 295)
            Me.panelControl1.TabIndex = 1
            ' 
            ' memoEdit1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.memoEdit1, New DevExpress.Utils.Behaviors.Behavior() {CType(CType((DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehavior), GetType(DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehaviorSource), New Object() {(CObj((800))), (CObj((""))), (CObj((Me.aiEvents1)))})), DevExpress.AIIntegration.WinForms.SmartAutoCompleteBehavior), DevExpress.Utils.Behaviors.Behavior)})
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.EditValue = ""
            Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
            Me.memoEdit1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.memoEdit1.Properties.NullValuePrompt = "Begin typing to display AI-powered suggestions."
            Me.memoEdit1.Size = New System.Drawing.Size(440, 295)
            Me.memoEdit1.StyleController = Me.layoutControl2
            Me.memoEdit1.TabIndex = 4
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl2.Controls.Add(Me.roundedSkinPanel)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(831, 141, 650, 400)
            Me.layoutControl2.OptionsCustomizationForm.ShowPropertyGrid = True
            Me.layoutControl2.Root = Me.layoutControlGroup1
            Me.layoutControl2.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl2.TabIndex = 6
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(784, 103)
            Me.ucDisclaimerPanel1.TabIndex = 6
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciRoundedSkinPanel, Me.lciUcDisclaimerPanel1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciRoundedSkinPanel
            ' 
            Me.lciRoundedSkinPanel.Control = Me.roundedSkinPanel
            Me.lciRoundedSkinPanel.Location = New System.Drawing.Point(0, 103)
            Me.lciRoundedSkinPanel.Name = "lciRoundedSkinPanel"
            Me.lciRoundedSkinPanel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciRoundedSkinPanel.Size = New System.Drawing.Size(784, 329)
            Me.lciRoundedSkinPanel.TextVisible = False
            ' 
            ' lciUcDisclaimerPanel1
            ' 
            Me.lciUcDisclaimerPanel1.Control = Me.ucDisclaimerPanel1
            Me.lciUcDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1"
            Me.lciUcDisclaimerPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciUcDisclaimerPanel1.Size = New System.Drawing.Size(784, 103)
            Me.lciUcDisclaimerPanel1.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(440, 0)
            Me.sidePanel1.MaximumSize = New System.Drawing.Size(500, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(300, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(310, 295)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(309, 295)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(309, 295)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(309, 254)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditUserRole)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(900, 305, 738, 524)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(309, 254)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText
            Me.labelControl1.Appearance.Options.UseForeColor = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Location = New System.Drawing.Point(16, 69)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(277, 13)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 6
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' comboBoxEditUserRole
            ' 
            Me.comboBoxEditUserRole.Location = New System.Drawing.Point(16, 35)
            Me.comboBoxEditUserRole.Name = "comboBoxEditUserRole"
            Me.comboBoxEditUserRole.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditUserRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditUserRole.Size = New System.Drawing.Size(277, 28)
            Me.comboBoxEditUserRole.StyleController = Me.layoutControl1
            Me.comboBoxEditUserRole.TabIndex = 5
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(309, 254)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxEditUserRole
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(283, 53)
            Me.layoutControlItem2.Text = "User role:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(49, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 53)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(283, 175)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' SmartAutoCompleteModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl2)
            Me.Name = "SmartAutoCompleteModule"
            CType((Me.roundedSkinPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRoundedSkinPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.comboBoxEditUserRole.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private comboBoxEditUserRole As DevExpress.XtraEditors.ComboBoxEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciRoundedSkinPanel As DevExpress.XtraLayout.LayoutControlItem

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private roundedSkinPanel As DevExpress.XtraEditors.RoundedSkinPanel

        Private aiEvents1 As DevExpress.AIIntegration.WinForms.AIEvents

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

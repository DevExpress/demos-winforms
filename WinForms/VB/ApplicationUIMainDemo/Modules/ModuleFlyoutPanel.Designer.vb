Namespace DevExpress.ApplicationUI.Demos

    Partial Class ModuleFlyoutPanel

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
            Me.horzFlyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.vertFlyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.groupCommands = New DevExpress.XtraEditors.GroupControl()
            Me.btnHideToolWindow = New DevExpress.XtraEditors.SimpleButton()
            Me.btnShowToolWindow = New DevExpress.XtraEditors.SimpleButton()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.lblYCoord = New DevExpress.XtraEditors.LabelControl()
            Me.lblXCoord = New DevExpress.XtraEditors.LabelControl()
            Me.spinEditYCoord = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditXCoord = New DevExpress.XtraEditors.SpinEdit()
            Me.cbAnchorTypes = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ceCloseOnOuterClick = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.cbAnimationTypes = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            CType((Me.horzFlyoutPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.horzFlyoutPanel.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType((Me.vertFlyoutPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.vertFlyoutPanel.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.groupCommands), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupCommands.SuspendLayout()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.spinEditYCoord.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditXCoord.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbAnchorTypes.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCloseOnOuterClick.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbAnimationTypes.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' horzFlyoutPanel
            ' 
            Me.horzFlyoutPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.horzFlyoutPanel.Appearance.Options.UseBackColor = True
            Me.horzFlyoutPanel.Controls.Add(Me.panelControl1)
            Me.horzFlyoutPanel.Location = New System.Drawing.Point(77, 11)
            Me.horzFlyoutPanel.Name = "horzFlyoutPanel"
            Me.horzFlyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent
            Me.horzFlyoutPanel.OwnerControl = Me.xtraTabPage1
            Me.horzFlyoutPanel.Size = New System.Drawing.Size(400, 60)
            Me.horzFlyoutPanel.TabIndex = 0
            AddHandler Me.horzFlyoutPanel.Hidden, New DevExpress.Utils.FlyoutPanelEventHandler(AddressOf Me.OnFlyoutPanelHidden)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl3)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(400, 60)
            Me.panelControl1.TabIndex = 1
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.labelControl3.Location = New System.Drawing.Point(42, 23)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(39, 13)
            Me.labelControl3.TabIndex = 0
            Me.labelControl3.Text = "Content"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.horzFlyoutPanel)
            Me.xtraTabPage1.Controls.Add(Me.vertFlyoutPanel)
            Me.xtraTabPage1.Controls.Add(Me.groupCommands)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(782, 430)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' vertFlyoutPanel
            ' 
            Me.vertFlyoutPanel.Controls.Add(Me.panelControl2)
            Me.vertFlyoutPanel.Location = New System.Drawing.Point(594, 11)
            Me.vertFlyoutPanel.Name = "vertFlyoutPanel"
            Me.vertFlyoutPanel.OwnerControl = Me.xtraTabPage1
            Me.vertFlyoutPanel.Size = New System.Drawing.Size(69, 400)
            Me.vertFlyoutPanel.TabIndex = 1
            AddHandler Me.vertFlyoutPanel.Hidden, New DevExpress.Utils.FlyoutPanelEventHandler(AddressOf Me.OnFlyoutPanelHidden)
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.labelControl4)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(69, 400)
            Me.panelControl2.TabIndex = 1
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.labelControl4.Location = New System.Drawing.Point(15, 48)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(39, 13)
            Me.labelControl4.TabIndex = 0
            Me.labelControl4.Text = "Content"
            ' 
            ' groupCommands
            ' 
            Me.groupCommands.Controls.Add(Me.btnHideToolWindow)
            Me.groupCommands.Controls.Add(Me.btnShowToolWindow)
            Me.groupCommands.Location = New System.Drawing.Point(77, 285)
            Me.groupCommands.Name = "groupCommands"
            Me.groupCommands.Size = New System.Drawing.Size(321, 69)
            Me.groupCommands.TabIndex = 6
            Me.groupCommands.Text = "Commands"
            ' 
            ' btnHideToolWindow
            ' 
            Me.btnHideToolWindow.Location = New System.Drawing.Point(169, 30)
            Me.btnHideToolWindow.Name = "btnHideToolWindow"
            Me.btnHideToolWindow.Size = New System.Drawing.Size(139, 23)
            Me.btnHideToolWindow.TabIndex = 6
            Me.btnHideToolWindow.Text = "Hide Tool Window"
            AddHandler Me.btnHideToolWindow.Click, New System.EventHandler(AddressOf Me.OnHideToolWindowClick)
            ' 
            ' btnShowToolWindow
            ' 
            Me.btnShowToolWindow.Location = New System.Drawing.Point(15, 30)
            Me.btnShowToolWindow.Name = "btnShowToolWindow"
            Me.btnShowToolWindow.Size = New System.Drawing.Size(139, 23)
            Me.btnShowToolWindow.TabIndex = 5
            Me.btnShowToolWindow.Text = "Show Tool Window"
            AddHandler Me.btnShowToolWindow.Click, New System.EventHandler(AddressOf Me.OnShowToolWindowClick)
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.lblYCoord)
            Me.groupControl1.Controls.Add(Me.lblXCoord)
            Me.groupControl1.Controls.Add(Me.spinEditYCoord)
            Me.groupControl1.Controls.Add(Me.spinEditXCoord)
            Me.groupControl1.Controls.Add(Me.cbAnchorTypes)
            Me.groupControl1.Controls.Add(Me.ceCloseOnOuterClick)
            Me.groupControl1.Controls.Add(Me.labelControl2)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.cbAnimationTypes)
            Me.groupControl1.Location = New System.Drawing.Point(77, 86)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(321, 187)
            Me.groupControl1.TabIndex = 2
            Me.groupControl1.Text = "Properties"
            ' 
            ' lblYCoord
            ' 
            Me.lblYCoord.Location = New System.Drawing.Point(208, 157)
            Me.lblYCoord.Name = "lblYCoord"
            Me.lblYCoord.Size = New System.Drawing.Size(38, 13)
            Me.lblYCoord.TabIndex = 8
            Me.lblYCoord.Text = "Y Coord"
            ' 
            ' lblXCoord
            ' 
            Me.lblXCoord.Location = New System.Drawing.Point(208, 125)
            Me.lblXCoord.Name = "lblXCoord"
            Me.lblXCoord.Size = New System.Drawing.Size(38, 13)
            Me.lblXCoord.TabIndex = 7
            Me.lblXCoord.Text = "X Coord"
            ' 
            ' spinEditYCoord
            ' 
            Me.spinEditYCoord.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditYCoord.Location = New System.Drawing.Point(102, 154)
            Me.spinEditYCoord.Name = "spinEditYCoord"
            Me.spinEditYCoord.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditYCoord.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditYCoord.Properties.IsFloatValue = False
            Me.spinEditYCoord.Properties.Mask.EditMask = "N00"
            Me.spinEditYCoord.Size = New System.Drawing.Size(100, 20)
            Me.spinEditYCoord.TabIndex = 6
            AddHandler Me.spinEditYCoord.EditValueChanged, New System.EventHandler(AddressOf Me.OnYCoordEditValueChanged)
            ' 
            ' spinEditXCoord
            ' 
            Me.spinEditXCoord.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditXCoord.Location = New System.Drawing.Point(102, 122)
            Me.spinEditXCoord.Name = "spinEditXCoord"
            Me.spinEditXCoord.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditXCoord.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditXCoord.Properties.IsFloatValue = False
            Me.spinEditXCoord.Properties.Mask.EditMask = "N00"
            Me.spinEditXCoord.Size = New System.Drawing.Size(100, 20)
            Me.spinEditXCoord.TabIndex = 5
            AddHandler Me.spinEditXCoord.EditValueChanged, New System.EventHandler(AddressOf Me.OnCoordEditValueChanged)
            ' 
            ' cbAnchorTypes
            ' 
            Me.cbAnchorTypes.Location = New System.Drawing.Point(102, 33)
            Me.cbAnchorTypes.Name = "cbAnchorTypes"
            Me.cbAnchorTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAnchorTypes.Properties.DropDownRows = 8
            Me.cbAnchorTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbAnchorTypes.Size = New System.Drawing.Size(206, 20)
            Me.cbAnchorTypes.TabIndex = 0
            AddHandler Me.cbAnchorTypes.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnAnchorTypeSelectedValueChanged)
            ' 
            ' ceCloseOnOuterClick
            ' 
            Me.ceCloseOnOuterClick.Location = New System.Drawing.Point(100, 94)
            Me.ceCloseOnOuterClick.Name = "ceCloseOnOuterClick"
            Me.ceCloseOnOuterClick.Properties.Caption = "Close When Clicking Outside the Panel"
            Me.ceCloseOnOuterClick.Size = New System.Drawing.Size(208, 20)
            Me.ceCloseOnOuterClick.TabIndex = 4
            AddHandler Me.ceCloseOnOuterClick.CheckedChanged, New System.EventHandler(AddressOf Me.OnCloseOnOuterClickCheckedChanged)
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(15, 68)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(74, 13)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "Animation Type"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(15, 36)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(34, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Anchor"
            ' 
            ' cbAnimationTypes
            ' 
            Me.cbAnimationTypes.Location = New System.Drawing.Point(102, 65)
            Me.cbAnimationTypes.Name = "cbAnimationTypes"
            Me.cbAnimationTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAnimationTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbAnimationTypes.Size = New System.Drawing.Size(206, 20)
            Me.cbAnimationTypes.TabIndex = 1
            AddHandler Me.cbAnimationTypes.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnAnimationTypesSelectedValueChanged)
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(784, 432)
            Me.xtraTabControl1.TabIndex = 6
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            ' 
            ' ModuleFlyoutPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleFlyoutPanel"
            CType((Me.horzFlyoutPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.horzFlyoutPanel.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.xtraTabPage1.ResumeLayout(False)
            CType((Me.vertFlyoutPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.vertFlyoutPanel.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            CType((Me.groupCommands), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupCommands.ResumeLayout(False)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType((Me.spinEditYCoord.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditXCoord.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbAnchorTypes.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCloseOnOuterClick.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbAnimationTypes.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private horzFlyoutPanel As DevExpress.Utils.FlyoutPanel

        Private vertFlyoutPanel As DevExpress.Utils.FlyoutPanel

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private cbAnimationTypes As DevExpress.XtraEditors.ComboBoxEdit

        Private cbAnchorTypes As DevExpress.XtraEditors.ComboBoxEdit

        Private btnShowToolWindow As DevExpress.XtraEditors.SimpleButton

        Private ceCloseOnOuterClick As DevExpress.XtraEditors.CheckEdit

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private groupCommands As DevExpress.XtraEditors.GroupControl

        Private btnHideToolWindow As DevExpress.XtraEditors.SimpleButton

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private lblYCoord As DevExpress.XtraEditors.LabelControl

        Private lblXCoord As DevExpress.XtraEditors.LabelControl

        Private spinEditYCoord As DevExpress.XtraEditors.SpinEdit

        Private spinEditXCoord As DevExpress.XtraEditors.SpinEdit

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

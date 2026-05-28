Namespace DevExpress.ApplicationUI.Demos.VisualEffects

    Partial Class GuideFlyoutPanel

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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.label = New DevExpress.XtraEditors.LabelControl()
            Me.skipButton = New DevExpress.XtraEditors.SimpleButton()
            Me.nextButton = New DevExpress.XtraEditors.SimpleButton()
            Me.backButton = New DevExpress.XtraEditors.SimpleButton()
            Me.navigator = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.nextItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.backItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.shipItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigatorItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptyItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.labelItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nextItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.shipItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigatorItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptyItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.Controls.Add(Me.label)
            Me.layoutControl.Controls.Add(Me.skipButton)
            Me.layoutControl.Controls.Add(Me.nextButton)
            Me.layoutControl.Controls.Add(Me.backButton)
            Me.layoutControl.Controls.Add(Me.navigator)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(954, 91, 697, 350)
            Me.layoutControl.Root = Me.layoutControlGroup
            Me.layoutControl.Size = New System.Drawing.Size(234, 148)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' label
            ' 
            Me.label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.label.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.label.Location = New System.Drawing.Point(12, 12)
            Me.label.Name = "label"
            Me.label.Size = New System.Drawing.Size(210, 74)
            Me.label.StyleController = Me.layoutControl
            Me.label.TabIndex = 0
            Me.label.Text = "Empty"
            ' 
            ' skipButton
            ' 
            Me.skipButton.Location = New System.Drawing.Point(12, 114)
            Me.skipButton.Name = "skipButton"
            Me.skipButton.Size = New System.Drawing.Size(46, 22)
            Me.skipButton.StyleController = Me.layoutControl
            Me.skipButton.TabIndex = 7
            Me.skipButton.Text = "Skip"
            AddHandler Me.skipButton.Click, New System.EventHandler(AddressOf Me.OnSkipButtonClick)
            ' 
            ' nextButton
            ' 
            Me.nextButton.Location = New System.Drawing.Point(176, 114)
            Me.nextButton.Name = "nextButton"
            Me.nextButton.Size = New System.Drawing.Size(46, 22)
            Me.nextButton.StyleController = Me.layoutControl
            Me.nextButton.TabIndex = 6
            Me.nextButton.Text = "Next"
            AddHandler Me.nextButton.Click, New System.EventHandler(AddressOf Me.OnNextButtonClick)
            ' 
            ' backButton
            ' 
            Me.backButton.Location = New System.Drawing.Point(126, 114)
            Me.backButton.Name = "backButton"
            Me.backButton.Size = New System.Drawing.Size(46, 22)
            Me.backButton.StyleController = Me.layoutControl
            Me.backButton.TabIndex = 5
            Me.backButton.Text = "Back"
            AddHandler Me.backButton.Click, New System.EventHandler(AddressOf Me.OnBackButtonClick)
            ' 
            ' navigator
            ' 
            Me.navigator.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.Gray
            Me.navigator.AppearanceButton.Hovered.Options.UseForeColor = True
            Me.navigator.AppearanceButton.Normal.ForeColor = System.Drawing.Color.Silver
            Me.navigator.AppearanceButton.Normal.Options.UseForeColor = True
            Me.navigator.AppearanceButton.Pressed.BackColor = System.Drawing.Color.Gray
            Me.navigator.AppearanceButton.Pressed.Options.UseBackColor = True
            Me.navigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.navigator.ButtonInterval = 5
            Me.navigator.Location = New System.Drawing.Point(12, 90)
            Me.navigator.Name = "navigator"
            Me.navigator.Size = New System.Drawing.Size(210, 20)
            Me.navigator.TabIndex = 4
            Me.navigator.Text = "windowsUIButtonPanel1"
            Me.navigator.UseButtonBackgroundImages = False
            AddHandler Me.navigator.ButtonChecked, New DevExpress.XtraBars.Docking2010.ButtonEventHandler(AddressOf Me.OnNavigatorButtonChecked)
            ' 
            ' layoutControlGroup
            ' 
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.nextItem, Me.backItem, Me.shipItem, Me.navigatorItem, Me.emptyItem, Me.labelItem})
            Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup.Name = "Root"
            Me.layoutControlGroup.Size = New System.Drawing.Size(234, 148)
            Me.layoutControlGroup.TextVisible = False
            ' 
            ' nextItem
            ' 
            Me.nextItem.Control = Me.nextButton
            Me.nextItem.Location = New System.Drawing.Point(164, 102)
            Me.nextItem.MaxSize = New System.Drawing.Size(50, 26)
            Me.nextItem.MinSize = New System.Drawing.Size(50, 26)
            Me.nextItem.Name = "nextItem"
            Me.nextItem.Size = New System.Drawing.Size(50, 26)
            Me.nextItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.nextItem.TextSize = New System.Drawing.Size(0, 0)
            Me.nextItem.TextVisible = False
            ' 
            ' backItem
            ' 
            Me.backItem.Control = Me.backButton
            Me.backItem.Location = New System.Drawing.Point(114, 102)
            Me.backItem.MaxSize = New System.Drawing.Size(50, 26)
            Me.backItem.MinSize = New System.Drawing.Size(50, 26)
            Me.backItem.Name = "backItem"
            Me.backItem.Size = New System.Drawing.Size(50, 26)
            Me.backItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.backItem.TextSize = New System.Drawing.Size(0, 0)
            Me.backItem.TextVisible = False
            ' 
            ' shipItem
            ' 
            Me.shipItem.Control = Me.skipButton
            Me.shipItem.Location = New System.Drawing.Point(0, 102)
            Me.shipItem.MaxSize = New System.Drawing.Size(50, 26)
            Me.shipItem.MinSize = New System.Drawing.Size(50, 26)
            Me.shipItem.Name = "shipItem"
            Me.shipItem.Size = New System.Drawing.Size(50, 26)
            Me.shipItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.shipItem.TextSize = New System.Drawing.Size(0, 0)
            Me.shipItem.TextVisible = False
            ' 
            ' navigatorItem
            ' 
            Me.navigatorItem.Control = Me.navigator
            Me.navigatorItem.Location = New System.Drawing.Point(0, 78)
            Me.navigatorItem.MaxSize = New System.Drawing.Size(0, 24)
            Me.navigatorItem.MinSize = New System.Drawing.Size(1, 24)
            Me.navigatorItem.Name = "navigatorItem"
            Me.navigatorItem.Size = New System.Drawing.Size(214, 24)
            Me.navigatorItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.navigatorItem.TextSize = New System.Drawing.Size(0, 0)
            Me.navigatorItem.TextVisible = False
            ' 
            ' emptyItem
            ' 
            Me.emptyItem.AllowHotTrack = False
            Me.emptyItem.Location = New System.Drawing.Point(50, 102)
            Me.emptyItem.Name = "emptyItem"
            Me.emptyItem.Size = New System.Drawing.Size(64, 26)
            Me.emptyItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' labelItem
            ' 
            Me.labelItem.Control = Me.label
            Me.labelItem.Location = New System.Drawing.Point(0, 0)
            Me.labelItem.MinSize = New System.Drawing.Size(14, 17)
            Me.labelItem.Name = "labelItem"
            Me.labelItem.Size = New System.Drawing.Size(214, 78)
            Me.labelItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.labelItem.TextSize = New System.Drawing.Size(0, 0)
            Me.labelItem.TextVisible = False
            ' 
            ' GuideFlyoutPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "GuideFlyoutPanel"
            Me.Size = New System.Drawing.Size(234, 148)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nextItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.shipItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigatorItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptyItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private navigator As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private navigatorItem As DevExpress.XtraLayout.LayoutControlItem

        Private backButton As DevExpress.XtraEditors.SimpleButton

        Private backItem As DevExpress.XtraLayout.LayoutControlItem

        Private nextButton As DevExpress.XtraEditors.SimpleButton

        Private nextItem As DevExpress.XtraLayout.LayoutControlItem

        Private skipButton As DevExpress.XtraEditors.SimpleButton

        Private shipItem As DevExpress.XtraLayout.LayoutControlItem

        Private emptyItem As DevExpress.XtraLayout.EmptySpaceItem

        Private label As DevExpress.XtraEditors.LabelControl

        Private labelItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

Namespace DevExpress.HTML.Demos

    Partial Class PreviewCoreControllerProperties

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
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ttInitialDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.ttIconSize = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ttAutoPopDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.ttLocation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ttType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liLocation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAutoPopDelay = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liIconSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liInitialDelay = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ttInitialDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ttIconSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ttAutoPopDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ttLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ttType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liLocation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAutoPopDelay), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liIconSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liInitialDelay), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("actions_check", "image://svgimages/icon builder/actions_check.svg")
            Me.svgImageCollection1.Add("actions_checkcircled", "image://svgimages/icon builder/actions_checkcircled.svg")
            Me.svgImageCollection1.Add("warning", "image://svgimages/status/warning.svg")
            Me.svgImageCollection1.Add("security_warningcircled1", "image://svgimages/icon builder/security_warningcircled1.svg")
            Me.svgImageCollection1.Add("actions_deletecircled", "image://svgimages/icon builder/actions_deletecircled.svg")
            Me.svgImageCollection1.Add("actions_info", "image://svgimages/icon builder/actions_info.svg")
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AutoSize = True
            Me.layoutControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
            Me.layoutControl1.Controls.Add(Me.ttInitialDelay)
            Me.layoutControl1.Controls.Add(Me.ttIconSize)
            Me.layoutControl1.Controls.Add(Me.ttAutoPopDelay)
            Me.layoutControl1.Controls.Add(Me.ttLocation)
            Me.layoutControl1.Controls.Add(Me.ttType)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(180, 154)
            Me.layoutControl1.TabIndex = 15
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ttInitialDelay
            ' 
            Me.ttInitialDelay.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.ttInitialDelay.Location = New System.Drawing.Point(110, 43)
            Me.ttInitialDelay.Margin = New System.Windows.Forms.Padding(2)
            Me.ttInitialDelay.Name = "ttInitialDelay"
            Me.ttInitialDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ttInitialDelay.Properties.IsFloatValue = False
            Me.ttInitialDelay.Properties.MaskSettings.[Set]("mask", "N00")
            Me.ttInitialDelay.Properties.MaxValue = New Decimal(New Integer() {15000, 0, 0, 0})
            Me.ttInitialDelay.Size = New System.Drawing.Size(50, 20)
            Me.ttInitialDelay.StyleController = Me.layoutControl1
            Me.ttInitialDelay.TabIndex = 3
            ' 
            ' ttIconSize
            ' 
            Me.ttIconSize.Location = New System.Drawing.Point(110, 67)
            Me.ttIconSize.Margin = New System.Windows.Forms.Padding(2)
            Me.ttIconSize.Name = "ttIconSize"
            Me.ttIconSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ttIconSize.Size = New System.Drawing.Size(50, 20)
            Me.ttIconSize.StyleController = Me.layoutControl1
            Me.ttIconSize.TabIndex = 4
            ' 
            ' ttAutoPopDelay
            ' 
            Me.ttAutoPopDelay.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.ttAutoPopDelay.Location = New System.Drawing.Point(110, 19)
            Me.ttAutoPopDelay.Margin = New System.Windows.Forms.Padding(2)
            Me.ttAutoPopDelay.Name = "ttAutoPopDelay"
            Me.ttAutoPopDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ttAutoPopDelay.Properties.IsFloatValue = False
            Me.ttAutoPopDelay.Properties.MaskSettings.[Set]("mask", "N00")
            Me.ttAutoPopDelay.Properties.MaxValue = New Decimal(New Integer() {15000, 0, 0, 0})
            Me.ttAutoPopDelay.Size = New System.Drawing.Size(50, 20)
            Me.ttAutoPopDelay.StyleController = Me.layoutControl1
            Me.ttAutoPopDelay.TabIndex = 2
            ' 
            ' ttLocation
            ' 
            Me.ttLocation.Location = New System.Drawing.Point(110, 91)
            Me.ttLocation.Margin = New System.Windows.Forms.Padding(2)
            Me.ttLocation.Name = "ttLocation"
            Me.ttLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ttLocation.Size = New System.Drawing.Size(50, 20)
            Me.ttLocation.StyleController = Me.layoutControl1
            Me.ttLocation.TabIndex = 5
            ' 
            ' ttType
            ' 
            Me.ttType.Location = New System.Drawing.Point(110, 115)
            Me.ttType.Margin = New System.Windows.Forms.Padding(2)
            Me.ttType.Name = "ttType"
            Me.ttType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ttType.Size = New System.Drawing.Size(50, 20)
            Me.ttType.StyleController = Me.layoutControl1
            Me.ttType.TabIndex = 6
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liType, Me.liLocation, Me.liAutoPopDelay, Me.liIconSize, Me.liInitialDelay})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17)
            Me.Root.Size = New System.Drawing.Size(180, 154)
            Me.Root.TextVisible = False
            ' 
            ' liType
            ' 
            Me.liType.Control = Me.ttType
            Me.liType.Location = New System.Drawing.Point(0, 96)
            Me.liType.Name = "liType"
            Me.liType.Size = New System.Drawing.Size(144, 24)
            Me.liType.Text = "Type:"
            Me.liType.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' liLocation
            ' 
            Me.liLocation.Control = Me.ttLocation
            Me.liLocation.Location = New System.Drawing.Point(0, 72)
            Me.liLocation.Name = "liLocation"
            Me.liLocation.Size = New System.Drawing.Size(144, 24)
            Me.liLocation.Text = "Location:"
            Me.liLocation.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' liAutoPopDelay
            ' 
            Me.liAutoPopDelay.Control = Me.ttAutoPopDelay
            Me.liAutoPopDelay.Location = New System.Drawing.Point(0, 0)
            Me.liAutoPopDelay.Name = "liAutoPopDelay"
            Me.liAutoPopDelay.Size = New System.Drawing.Size(144, 24)
            Me.liAutoPopDelay.Text = "Auto Pop Delay:"
            Me.liAutoPopDelay.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' liIconSize
            ' 
            Me.liIconSize.Control = Me.ttIconSize
            Me.liIconSize.Location = New System.Drawing.Point(0, 48)
            Me.liIconSize.Name = "liIconSize"
            Me.liIconSize.Size = New System.Drawing.Size(144, 24)
            Me.liIconSize.Text = "Icon Size:"
            Me.liIconSize.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' liInitialDelay
            ' 
            Me.liInitialDelay.Control = Me.ttInitialDelay
            Me.liInitialDelay.Location = New System.Drawing.Point(0, 24)
            Me.liInitialDelay.Name = "liInitialDelay"
            Me.liInitialDelay.Size = New System.Drawing.Size(144, 24)
            Me.liInitialDelay.Text = "Initial Delay:"
            Me.liInitialDelay.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' PreviewCoreControllerProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "PreviewCoreControllerProperties"
            Me.Size = New System.Drawing.Size(180, 154)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ttInitialDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ttIconSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ttAutoPopDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ttLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ttType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liLocation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAutoPopDelay), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liIconSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liInitialDelay), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private ttInitialDelay As DevExpress.XtraEditors.SpinEdit

        Private ttIconSize As DevExpress.XtraEditors.ComboBoxEdit

        Private ttAutoPopDelay As DevExpress.XtraEditors.SpinEdit

        Private ttLocation As DevExpress.XtraEditors.ComboBoxEdit

        Private ttType As DevExpress.XtraEditors.ComboBoxEdit

        Private liType As DevExpress.XtraLayout.LayoutControlItem

        Private liLocation As DevExpress.XtraLayout.LayoutControlItem

        Private liAutoPopDelay As DevExpress.XtraLayout.LayoutControlItem

        Private liIconSize As DevExpress.XtraLayout.LayoutControlItem

        Private liInitialDelay As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

Namespace DevExpress.XtraLayout.Demos

    Partial Class Browser

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.urlEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.urlEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.urlEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(435, 264)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            AddHandler Me.layoutControl1.TabPageCloseButtonClick, New DevExpress.XtraLayout.Utils.LayoutGroupEventHandler(AddressOf Me.layoutControl1_TabPageCloseButtonClick)
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Location = New System.Drawing.Point(335, 35)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(86, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl1
            Me.comboBoxEdit1.TabIndex = 9
            AddHandler Me.comboBoxEdit1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEdit1_SelectedIndexChanged)
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.AutoSizeInLayoutControl = True
            Me.checkEdit2.Location = New System.Drawing.Point(144, 35)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Vertical headers"
            Me.checkEdit2.Size = New System.Drawing.Size(100, 20)
            Me.checkEdit2.StyleController = Me.layoutControl1
            Me.checkEdit2.TabIndex = 8
            AddHandler Me.checkEdit2.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit2_CheckedChanged)
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.AutoSizeInLayoutControl = True
            Me.checkEdit1.Location = New System.Drawing.Point(14, 35)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Multi-line tab headers"
            Me.checkEdit1.Size = New System.Drawing.Size(126, 20)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 7
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' urlEdit
            ' 
            Me.urlEdit.Location = New System.Drawing.Point(2, 71)
            Me.urlEdit.Name = "urlEdit"
            Me.urlEdit.Properties.NullText = "Type URL here"
            Me.urlEdit.Size = New System.Drawing.Size(431, 20)
            Me.urlEdit.StyleController = Me.layoutControl1
            Me.urlEdit.TabIndex = 6
            AddHandler Me.urlEdit.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.urlEdit_ButtonClick)
            AddHandler Me.urlEdit.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.urlEdit_KeyDown)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup1, Me.layoutControlItem3, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(435, 264)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 93)
            Me.tabbedControlGroup1.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup3
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(435, 171)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            AddHandler Me.tabbedControlGroup1.SelectedPageChanged, New DevExpress.XtraLayout.LayoutTabPageChangedEventHandler(AddressOf Me.tabbedControlGroup1_SelectedPageChanged)
            AddHandler Me.tabbedControlGroup1.SelectedPageChanging, New DevExpress.XtraLayout.LayoutTabPageChangingEventHandler(AddressOf Me.tabbedControlGroup1_SelectedPageChanging)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CustomizationFormText = "..."
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(429, 142)
            Me.layoutControlGroup3.Text = "..."
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.urlEdit
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 69)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(435, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Options"
            Me.layoutControlGroup2.ExpandButtonVisible = True
            Me.layoutControlGroup2.ExpandOnDoubleClick = True
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.OptionsToolTip.ToolTip = "Double-click the group caption to expand/collapse the group."
            Me.layoutControlGroup2.OptionsToolTip.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
            Me.layoutControlGroup2.Size = New System.Drawing.Size(435, 69)
            Me.layoutControlGroup2.Text = "Options"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkEdit1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(130, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEdit2
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(130, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(104, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.comboBoxEdit1
            Me.layoutControlItem4.CustomizationFormText = "Header location"
            Me.layoutControlItem4.Location = New System.Drawing.Point(234, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(177, 24)
            Me.layoutControlItem4.Text = "Header location"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' Browser
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Browser"
            Me.Size = New System.Drawing.Size(435, 264)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.UserControl1_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.urlEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private urlEdit As DevExpress.XtraEditors.ButtonEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

#End Region
        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

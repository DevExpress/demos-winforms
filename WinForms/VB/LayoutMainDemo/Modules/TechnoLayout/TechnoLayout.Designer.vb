Imports DevExpress.XtraEditors.Designer.Utils

Namespace DevExpress.XtraLayout.Demos

    Partial Class TechnoLayout

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
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.facesUserControl1 = New DevExpress.XtraLayout.Demos.Modules.TechnoLayout.FacesUserControl()
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.rgFlowDirection = New DevExpress.XtraEditors.RadioGroup()
            Me.cheCustomizationMode = New DevExpress.XtraEditors.CheckEdit()
            Me.ztbcSize = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.ztbcSpacing = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            CType((Me.lcgMain), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.rgFlowDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cheCustomizationMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ztbcSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ztbcSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ztbcSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ztbcSpacing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AutoScroll = False
            Me.layoutControl3.Controls.Add(Me.facesUserControl1)
            Me.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(332, 256, 892, 743)
            Me.layoutControl3.OptionsView.AlwaysScrollActiveControlIntoView = False
            Me.layoutControl3.Root = Me.lcgMain
            Me.layoutControl3.Size = New System.Drawing.Size(648, 590)
            Me.layoutControl3.TabIndex = 2
            Me.layoutControl3.Text = "layoutControl3"
            ' 
            ' facesUserControl1
            ' 
            Me.facesUserControl1.Location = New System.Drawing.Point(0, 0)
            Me.facesUserControl1.Name = "facesUserControl1"
            Me.facesUserControl1.Padding = New System.Windows.Forms.Padding(10)
            Me.facesUserControl1.Size = New System.Drawing.Size(648, 590)
            Me.facesUserControl1.TabIndex = 26
            ' 
            ' lcgMain
            ' 
            Me.lcgMain.CustomizationFormText = "Root"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.lcgMain.Name = "Root"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgMain.Size = New System.Drawing.Size(648, 590)
            Me.lcgMain.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.facesUserControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(648, 590)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 590)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 590)
            Me.navigationPane1.TabIndex = 27
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 557)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.rgFlowDirection)
            Me.layoutControl1.Controls.Add(Me.cheCustomizationMode)
            Me.layoutControl1.Controls.Add(Me.ztbcSize)
            Me.layoutControl1.Controls.Add(Me.ztbcSpacing)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(4214, 1328, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 557)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' rgFlowDirection
            ' 
            Me.rgFlowDirection.AutoSizeInLayoutControl = True
            Me.rgFlowDirection.Location = New System.Drawing.Point(12, 140)
            Me.rgFlowDirection.Name = "rgFlowDirection"
            Me.rgFlowDirection.Size = New System.Drawing.Size(225, 10)
            Me.rgFlowDirection.StyleController = Me.layoutControl1
            Me.rgFlowDirection.TabIndex = 26
            AddHandler Me.rgFlowDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgFlowDirection_SelectedIndexChanged)
            ' 
            ' cheCustomizationMode
            ' 
            Me.cheCustomizationMode.EditValue = True
            Me.cheCustomizationMode.Location = New System.Drawing.Point(12, 34)
            Me.cheCustomizationMode.Name = "cheCustomizationMode"
            Me.cheCustomizationMode.Properties.Caption = "Customization Mode"
            Me.cheCustomizationMode.Size = New System.Drawing.Size(225, 20)
            Me.cheCustomizationMode.StyleController = Me.layoutControl1
            Me.cheCustomizationMode.TabIndex = 25
            AddHandler Me.cheCustomizationMode.CheckedChanged, New System.EventHandler(AddressOf Me.cheCustomizationMode_CheckedChanged)
            ' 
            ' ztbcSize
            ' 
            Me.ztbcSize.EditValue = 150
            Me.ztbcSize.Location = New System.Drawing.Point(12, 74)
            Me.ztbcSize.Name = "ztbcSize"
            Me.ztbcSize.Properties.LargeChange = 10
            Me.ztbcSize.Properties.Maximum = 250
            Me.ztbcSize.Properties.Middle = 150
            Me.ztbcSize.Properties.Minimum = 50
            Me.ztbcSize.Properties.SmallChange = 10
            Me.ztbcSize.Size = New System.Drawing.Size(225, 16)
            Me.ztbcSize.StyleController = Me.layoutControl1
            Me.ztbcSize.TabIndex = 4
            Me.ztbcSize.Value = 150
            AddHandler Me.ztbcSize.EditValueChanged, New System.EventHandler(AddressOf Me.ztbcSize_EditValueChanged)
            ' 
            ' ztbcSpacing
            ' 
            Me.ztbcSpacing.EditValue = 15
            Me.ztbcSpacing.Location = New System.Drawing.Point(12, 107)
            Me.ztbcSpacing.Name = "ztbcSpacing"
            Me.ztbcSpacing.Properties.Maximum = 30
            Me.ztbcSpacing.Properties.Middle = 15
            Me.ztbcSpacing.Size = New System.Drawing.Size(225, 16)
            Me.ztbcSpacing.StyleController = Me.layoutControl1
            Me.ztbcSpacing.TabIndex = 5
            Me.ztbcSpacing.Value = 15
            AddHandler Me.ztbcSpacing.EditValueChanged, New System.EventHandler(AddressOf Me.ztbcSpacing_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 557)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 162)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Layout"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cheCustomizationMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ztbcSize
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 33)
            Me.layoutControlItem3.Text = "Size:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ztbcSpacing
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 57)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 33)
            Me.layoutControlItem4.Text = "Spacing"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.rgFlowDirection
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 30)
            Me.layoutControlItem5.Text = "Flow Direction"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 162)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 395)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(648, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 590)
            Me.sidePanel1.TabIndex = 26
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' TechnoLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl3)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TechnoLayout"
            Me.Size = New System.Drawing.Size(898, 590)
            CType((Me.layoutControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            CType((Me.lcgMain), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.rgFlowDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cheCustomizationMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ztbcSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ztbcSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ztbcSpacing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ztbcSpacing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl3 As DevExpress.XtraLayout.LayoutControl

        Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup

        Private ztbcSpacing As DevExpress.XtraEditors.ZoomTrackBarControl

        Private ztbcSize As DevExpress.XtraEditors.ZoomTrackBarControl

        Private cheCustomizationMode As DevExpress.XtraEditors.CheckEdit

        Private facesUserControl1 As DevExpress.XtraLayout.Demos.Modules.TechnoLayout.FacesUserControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private rgFlowDirection As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

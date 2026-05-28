Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class OlapCustomTotals

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.totalsListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.controlPanellayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
            Me.separator1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.totalsListBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.controlPanellayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.controlPanellayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.paddingPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' totalsListBox
            ' 
            Me.totalsListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.totalsListBox.CheckOnClick = True
            Me.totalsListBox.ColumnWidth = 100
            Me.totalsListBox.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
            Me.totalsListBox.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Average", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Count", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Max"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Min"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDev"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDevp"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Sum"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Var"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Varp")})
            Me.totalsListBox.Location = New System.Drawing.Point(12, 32)
            Me.totalsListBox.Name = "totalsListBox"
            Me.totalsListBox.Size = New System.Drawing.Size(175, 268)
            Me.totalsListBox.StyleController = Nothing
            Me.totalsListBox.TabIndex = 0
            AddHandler Me.totalsListBox.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.chListBox_ItemCheck)
            ' 
            ' controlPanellayoutControl1ConvertedLayout
            ' 
            Me.controlPanellayoutControl1ConvertedLayout.AllowCustomization = False
            Me.controlPanellayoutControl1ConvertedLayout.Controls.Add(Me.totalsListBox)
            Me.controlPanellayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.controlPanellayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.controlPanellayoutControl1ConvertedLayout.Name = "controlPanellayoutControl1ConvertedLayout"
            Me.controlPanellayoutControl1ConvertedLayout.Padding = New System.Windows.Forms.Padding(9)
            Me.controlPanellayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.controlPanellayoutControl1ConvertedLayout.Size = New System.Drawing.Size(199, 312)
            Me.controlPanellayoutControl1ConvertedLayout.TabIndex = 12
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 312)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 312)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Show Custom Totals"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.totalsListBox
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 272)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 61)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(500, 339)
            Me.mainPanel.TabIndex = 9
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.pivotGridControl.Size = New System.Drawing.Size(500, 339)
            Me.pivotGridControl.TabIndex = 6
            ' 
            ' paddingPanel
            ' 
            Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.paddingPanel.Location = New System.Drawing.Point(0, 53)
            Me.paddingPanel.Name = "paddingPanel"
            Me.paddingPanel.Size = New System.Drawing.Size(700, 8)
            Me.paddingPanel.TabIndex = 8
            ' 
            ' separator1
            ' 
            Me.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.separator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.separator1.Location = New System.Drawing.Point(0, 45)
            Me.separator1.Name = "separator1"
            Me.separator1.Size = New System.Drawing.Size(700, 8)
            Me.separator1.TabIndex = 10
            ' 
            ' panelError
            ' 
            Me.panelError.Controls.Add(Me.hyperLinkEdit1)
            Me.panelError.Controls.Add(Me.labelControl2)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(0, 0)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(700, 45)
            Me.panelError.TabIndex = 11
            ' 
            ' hyperLinkEdit1
            ' 
            Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(456, 20)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
            Me.hyperLinkEdit1.TabIndex = 1
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.Appearance.Options.UseForeColor = True
            Me.labelControl2.AutoEllipsis = True
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.Location = New System.Drawing.Point(14, 8)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(673, 28)
            Me.labelControl2.TabIndex = 0
            Me.labelControl2.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" & ".0 (or later) " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "installed on your system. You can get the latest version of this" & " provider here:"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(500, 61)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 339)
            Me.sidePanel1.TabIndex = 7
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 339)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 339)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.controlPanellayoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 312)
            ' 
            ' OlapCustomTotals
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.paddingPanel)
            Me.Controls.Add(Me.separator1)
            Me.Controls.Add(Me.panelError)
            Me.Name = "OlapCustomTotals"
            Me.Size = New System.Drawing.Size(700, 400)
            CType((Me.totalsListBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.controlPanellayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.controlPanellayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.paddingPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separator1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private paddingPanel As DevExpress.XtraEditors.PanelControl

        Private totalsListBox As DevExpress.XtraEditors.CheckedListBoxControl

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private separator1 As DevExpress.XtraEditors.PanelControl

        Private panelError As DevExpress.XtraEditors.PanelControl

        Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private controlPanellayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

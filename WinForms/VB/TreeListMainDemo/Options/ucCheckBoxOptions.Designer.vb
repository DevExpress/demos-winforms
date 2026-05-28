Namespace DevExpress.XtraTreeList.Demos.Options

    Partial Class ucCheckBoxOptions

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
        Private Overloads Sub InitializeComponent()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ceAllowRecursiveNodeChecking = New DevExpress.XtraEditors.CheckEdit()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.imbShowCheckBoxes = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lgPreview = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lgOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liShowCheckBoxes = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowRecursiveNodeChecking = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.ceAllowRecursiveNodeChecking.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imbShowCheckBoxes.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lgPreview), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lgOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowCheckBoxes), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowRecursiveNodeChecking), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.ceAllowRecursiveNodeChecking)
            Me.layoutControl.Controls.Add(Me.treeList1)
            Me.layoutControl.Controls.Add(Me.imbShowCheckBoxes)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 596, 696)
            Me.layoutControl.Root = Me.layoutControlGroup
            Me.layoutControl.Size = New System.Drawing.Size(418, 342)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' ceAllowRecursiveNodeChecking
            ' 
            Me.ceAllowRecursiveNodeChecking.Location = New System.Drawing.Point(12, 34)
            Me.ceAllowRecursiveNodeChecking.Name = "ceAllowRecursiveNodeChecking"
            Me.ceAllowRecursiveNodeChecking.Properties.Caption = "Allow Recursive Node Checking"
            Me.ceAllowRecursiveNodeChecking.Size = New System.Drawing.Size(394, 20)
            Me.ceAllowRecursiveNodeChecking.StyleController = Me.layoutControl
            Me.ceAllowRecursiveNodeChecking.TabIndex = 14
            ' 
            ' treeList1
            ' 
            Me.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
            Me.treeList1.Appearance.Empty.Options.UseBackColor = True
            Me.treeList1.Appearance.Row.BackColor = System.Drawing.Color.Transparent
            Me.treeList1.Appearance.Row.Options.UseBackColor = True
            Me.treeList1.Location = New System.Drawing.Point(19, 124)
            Me.treeList1.MaximumSize = New System.Drawing.Size(380, 0)
            Me.treeList1.MinimumSize = New System.Drawing.Size(380, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsBehavior.[ReadOnly] = True
            Me.treeList1.OptionsCustomization.AllowFilter = False
            Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never
            Me.treeList1.Size = New System.Drawing.Size(380, 206)
            Me.treeList1.TabIndex = 4
            Me.treeList1.TreeViewFieldName = "Name"
            ' 
            ' imbShowCheckBoxes
            ' 
            Me.imbShowCheckBoxes.Location = New System.Drawing.Point(115, 58)
            Me.imbShowCheckBoxes.Name = "imbShowCheckBoxes"
            Me.imbShowCheckBoxes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imbShowCheckBoxes.Properties.DropDownRows = 25
            Me.imbShowCheckBoxes.Size = New System.Drawing.Size(291, 20)
            Me.imbShowCheckBoxes.StyleController = Me.layoutControl
            Me.imbShowCheckBoxes.TabIndex = 2
            ' 
            ' layoutControlGroup
            ' 
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lgPreview, Me.lgOptions})
            Me.layoutControlGroup.Name = "Root"
            Me.layoutControlGroup.Size = New System.Drawing.Size(418, 342)
            Me.layoutControlGroup.TextVisible = False
            ' 
            ' lgPreview
            ' 
            Me.lgPreview.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lgPreview.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.lgPreview.Location = New System.Drawing.Point(0, 90)
            Me.lgPreview.Name = "lgPreview"
            Me.lgPreview.Size = New System.Drawing.Size(418, 252)
            Me.lgPreview.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgPreview.Text = "Preview"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeList1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(398, 210)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' lgOptions
            ' 
            Me.lgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lgOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liShowCheckBoxes, Me.liAllowRecursiveNodeChecking})
            Me.lgOptions.Location = New System.Drawing.Point(0, 0)
            Me.lgOptions.Name = "lgOptions"
            Me.lgOptions.Size = New System.Drawing.Size(418, 90)
            Me.lgOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgOptions.Text = "Options"
            ' 
            ' liShowCheckBoxes
            ' 
            Me.liShowCheckBoxes.Control = Me.imbShowCheckBoxes
            Me.liShowCheckBoxes.CustomizationFormText = "liShowCheckBoxes"
            Me.liShowCheckBoxes.Location = New System.Drawing.Point(0, 24)
            Me.liShowCheckBoxes.Name = "liShowCheckBoxes"
            Me.liShowCheckBoxes.Size = New System.Drawing.Size(398, 24)
            Me.liShowCheckBoxes.Text = "Show CheckBoxes:"
            Me.liShowCheckBoxes.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' liAllowRecursiveNodeChecking
            ' 
            Me.liAllowRecursiveNodeChecking.Control = Me.ceAllowRecursiveNodeChecking
            Me.liAllowRecursiveNodeChecking.Location = New System.Drawing.Point(0, 0)
            Me.liAllowRecursiveNodeChecking.Name = "liAllowRecursiveNodeChecking"
            Me.liAllowRecursiveNodeChecking.Size = New System.Drawing.Size(398, 24)
            Me.liAllowRecursiveNodeChecking.Text = "lAllowRecursiveNodeChecking"
            Me.liAllowRecursiveNodeChecking.TextVisible = False
            ' 
            ' ucCheckBoxOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "ucCheckBoxOptions"
            Me.Size = New System.Drawing.Size(418, 342)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.ceAllowRecursiveNodeChecking.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imbShowCheckBoxes.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lgPreview), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lgOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowCheckBoxes), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowRecursiveNodeChecking), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private imbShowCheckBoxes As DevExpress.XtraEditors.ImageComboBoxEdit

        Private liShowCheckBoxes As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private lgPreview As DevExpress.XtraLayout.LayoutControlGroup

        Private lgOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private ceAllowRecursiveNodeChecking As DevExpress.XtraEditors.CheckEdit

        Private liAllowRecursiveNodeChecking As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

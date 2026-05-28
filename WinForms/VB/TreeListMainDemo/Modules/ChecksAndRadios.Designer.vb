Namespace DevExpress.XtraTreeList.Demos

    Partial Class ChecksAndRadios

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
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.optionsPanel = New DevExpress.XtraEditors.SidePanel()
            Me.ucCheckBoxOptions1 = New DevExpress.XtraTreeList.Demos.Options.ucCheckBoxOptions()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.optionsPanel.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList
            ' 
            Me.treeList.Location = New System.Drawing.Point(39, 2)
            Me.treeList.MaximumSize = New System.Drawing.Size(380, 0)
            Me.treeList.MinimumSize = New System.Drawing.Size(380, 0)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList.Size = New System.Drawing.Size(380, 428)
            Me.treeList.TabIndex = 0
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel.Controls.Add(Me.ucCheckBoxOptions1)
            Me.optionsPanel.Controls.Add(Me.labelControl1)
            Me.optionsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.optionsPanel.Location = New System.Drawing.Point(459, 0)
            Me.optionsPanel.Name = "optionsPanel"
            Me.optionsPanel.Size = New System.Drawing.Size(420, 432)
            Me.optionsPanel.TabIndex = 1
            Me.optionsPanel.Text = "sidePanel"
            ' 
            ' ucCheckBoxOptions1
            ' 
            Me.ucCheckBoxOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucCheckBoxOptions1.Location = New System.Drawing.Point(1, 0)
            Me.ucCheckBoxOptions1.Name = "ucCheckBoxOptions1"
            Me.ucCheckBoxOptions1.Size = New System.Drawing.Size(419, 432)
            Me.ucCheckBoxOptions1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl1.Location = New System.Drawing.Point(1, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.labelControl1.Size = New System.Drawing.Size(419, 432)
            Me.labelControl1.TabIndex = 0
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.treeList)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(459, 432)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0)
            Me.Root.Size = New System.Drawing.Size(459, 432)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem
            ' 
            Me.layoutControlItem.Control = Me.treeList
            Me.layoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem.Name = "layoutControlItem"
            Me.layoutControlItem.Size = New System.Drawing.Size(459, 432)
            Me.layoutControlItem.TextVisible = False
            Me.layoutControlItem.TrimClientAreaToControl = False
            ' 
            ' ChecksAndRadios
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Controls.Add(Me.optionsPanel)
            Me.Name = "ChecksAndRadios"
            Me.Size = New System.Drawing.Size(879, 432)
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).EndInit()
            Me.optionsPanel.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList As DevExpress.XtraTreeList.TreeList

        Private optionsPanel As DevExpress.XtraEditors.SidePanel

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private ucCheckBoxOptions1 As DevExpress.XtraTreeList.Demos.Options.ucCheckBoxOptions

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

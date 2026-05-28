Namespace DevExpress.XtraMap.Demos

    Partial Class FooteredMapTutorialControl

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
            Me.OnDispose()
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.layoutControlBase = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlBase), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControlBase.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' layoutControlBase
            ' 
            Me.layoutControlBase.Controls.Add(Me.labelControl2)
            Me.layoutControlBase.Controls.Add(Me.labelControl1)
            Me.layoutControlBase.Controls.Add(Me.panelControl1)
            Me.layoutControlBase.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControlBase.Location = New System.Drawing.Point(0, 150)
            Me.layoutControlBase.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutControlBase.Name = "layoutControlBase"
            Me.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(547, 207, 650, 400)
            Me.layoutControlBase.Root = Me.Root
            Me.layoutControlBase.Size = New System.Drawing.Size(500, 350)
            Me.layoutControlBase.TabIndex = 1
            Me.layoutControlBase.Text = "layoutControlBase"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(69, 335)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(429, 13)
            Me.labelControl2.StyleController = Me.layoutControlBase
            Me.labelControl2.TabIndex = 6
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(2, 335)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.StyleController = Me.layoutControlBase
            Me.labelControl1.TabIndex = 5
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(500, 332)
            Me.panelControl1.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.simpleSeparator1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(500, 350)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.panelControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(500, 332)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.labelControl1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 333)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(67, 17)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem3.Control = Me.labelControl2
            Me.layoutControlItem3.Location = New System.Drawing.Point(67, 333)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(433, 17)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 332)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(500, 1)
            Me.simpleSeparator1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' FooteredMapTutorialControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControlBase)
            Me.Name = "FooteredMapTutorialControl"
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.layoutControlBase, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlBase), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControlBase.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleSeparator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private layoutControlBase As DevExpress.XtraLayout.LayoutControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Protected panelControl1 As DevExpress.XtraEditors.PanelControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    End Class
End Namespace

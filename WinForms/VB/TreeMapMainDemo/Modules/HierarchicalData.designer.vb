Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HierarchicalData

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
            Dim treeMapHierarchicalDataAdapter1 As DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter = New DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter()
            Dim treeMapHierarchicalDataMapping1 As DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping = New DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping()
            Dim treeMapHierarchicalDataMapping2 As DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping = New DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping()
            Dim title1 As DevExpress.XtraTreeMap.Title = New DevExpress.XtraTreeMap.Title()
            Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeMapControl1
            ' 
            Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.treeMapControl1.BorderOptions.Thickness = 2
            Me.treeMapControl1.BorderOptions.Visible = False
            treeMapHierarchicalDataMapping1.ChildrenDataMember = "EnergyStatistic"
            treeMapHierarchicalDataMapping1.LabelDataMember = "Country"
            treeMapHierarchicalDataMapping2.LabelDataMember = "TypeName"
            treeMapHierarchicalDataMapping2.ValueDataMember = "Value"
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping1)
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping2)
            Me.treeMapControl1.DataAdapter = treeMapHierarchicalDataAdapter1
            Me.treeMapControl1.Location = New System.Drawing.Point(0, 0)
            Me.treeMapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.treeMapControl1.Name = "treeMapControl1"
            Me.treeMapControl1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.treeMapControl1.Size = New System.Drawing.Size(731, 512)
            Me.treeMapControl1.TabIndex = 1
            title1.Indent = 0
            title1.Text = "Energy Consumption in 2004 (millions of tons, oil equivalent)"
            Me.treeMapControl1.Titles.Add(title1)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.treeMapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 10)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(731, 512)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(731, 512)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeMapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(731, 512)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' HierarchicalData
            ' 
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "HierarchicalData"
            Me.Size = New System.Drawing.Size(731, 522)
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeMapControl1 As DevExpress.XtraTreeMap.TreeMapControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

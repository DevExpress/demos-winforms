Namespace DevExpress.ProductsDemo.Win.Controls
	Partial Public Class ucCalendar
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			Me.treeResources = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.dateNavigator1.DateTime = New Date(2011, 12, 29, 0, 0, 0, 0)
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dateNavigator1.Location = New System.Drawing.Point(0, 12)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.Size = New System.Drawing.Size(239, 443)
			Me.dateNavigator1.TabIndex = 1
			' 
			' treeResources
			' 
			Me.treeResources.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.treeResources.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeResources.Dock = System.Windows.Forms.DockStyle.Top
			Me.treeResources.Location = New System.Drawing.Point(0, 1)
			Me.treeResources.Name = "treeResources"
			Me.treeResources.OptionsBehavior.Editable = False
			Me.treeResources.OptionsView.ShowCheckBoxes = True
			Me.treeResources.OptionsView.ShowColumns = False
			Me.treeResources.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
			Me.treeResources.OptionsView.ShowHorzLines = False
			Me.treeResources.OptionsView.ShowIndicator = False
			Me.treeResources.OptionsView.ShowVertLines = False
			Me.treeResources.Size = New System.Drawing.Size(239, 10)
			Me.treeResources.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeResources.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeResources_BeforeExpand);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeResources.BeforeCollapse += new DevExpress.XtraTreeList.BeforeCollapseEventHandler(this.treeResources_BeforeCollapse);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeResources.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterExpand);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeResources.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCollapse);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeResources.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeResources_AfterCheckNode);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 68
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.OptionsColumn.AllowFocus = False
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 11)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(239, 1)
			Me.panelControl1.TabIndex = 9
			' 
			' ucCalendar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dateNavigator1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.treeResources)
			Me.Name = "ucCalendar"
			Me.Padding = New System.Windows.Forms.Padding(0, 1, 1, 1)
			Me.Size = New System.Drawing.Size(240, 456)
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private WithEvents treeResources As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

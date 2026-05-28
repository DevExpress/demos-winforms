Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class SpecifiedTypeObject
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.session1 = New DevExpress.Xpo.Session(Me.components)
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.cbViews = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.cbViews.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.cbViews)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(613, 38)
			Me.panel1.TabIndex = 1
			' 
			' cbViews
			' 
			Me.cbViews.Location = New System.Drawing.Point(68, 8)
			Me.cbViews.Name = "cbViews"
			Me.cbViews.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbViews.Properties.Items.AddRange(New Object() { "All Workers", "Only Evangelists", "Managers or ProductManagers", "ProductManagers", "Only Managers"})
			Me.cbViews.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbViews.Size = New System.Drawing.Size(224, 20)
			Me.cbViews.TabIndex = 1
'			Me.cbViews.SelectedIndexChanged += New System.EventHandler(Me.cbViews_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(15, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(34, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Views: "
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(2, 22)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(609, 276)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.BestFitMaxRowCount = 100
			Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.AllowCellMerge = True
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
			' 
			' groupControl1
			' 
			Me.groupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.groupControl1.AppearanceCaption.Options.UseFont = True
			Me.groupControl1.Controls.Add(Me.gridControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 46)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(613, 300)
			Me.groupControl1.TabIndex = 4
			Me.groupControl1.Text = "groupControl1"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 38)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(613, 8)
			Me.panelControl2.TabIndex = 5
			' 
			' SpecifiedTypeObject
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panel1)
			Me.Name = "SpecifiedTypeObject"
			Me.Size = New System.Drawing.Size(613, 346)
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.cbViews.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbViews As DevExpress.XtraEditors.ComboBoxEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private session1 As DevExpress.Xpo.Session
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace

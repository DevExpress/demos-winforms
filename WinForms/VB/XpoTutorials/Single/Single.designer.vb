Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class [Single]
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtpSimple = New DevExpress.XtraTab.XtraTabPage()
			Me.gclSingleMain = New DevExpress.XtraGrid.GridControl()
			Me.gviewSingleMain = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.xtpReferenceEquivalent = New DevExpress.XtraTab.XtraTabPage()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.gclReference = New DevExpress.XtraGrid.GridControl()
			Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.gclSingle = New DevExpress.XtraGrid.GridControl()
			Me.gridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtpSimple.SuspendLayout()
			CType(Me.gclSingleMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gviewSingleMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtpReferenceEquivalent.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.gclReference, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.gclSingle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtpSimple
			Me.xtraTabControl1.Size = New System.Drawing.Size(915, 645)
			Me.xtraTabControl1.TabIndex = 8
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtpSimple, Me.xtpReferenceEquivalent})
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged);
			' 
			' xtpSimple
			' 
			Me.xtpSimple.Controls.Add(Me.gclSingleMain)
			Me.xtpSimple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.xtpSimple.Name = "xtpSimple"
			Me.xtpSimple.Size = New System.Drawing.Size(909, 614)
			Me.xtpSimple.Text = "Single"
			' 
			' gclSingleMain
			' 
			Me.gclSingleMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gclSingleMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gclSingleMain.Location = New System.Drawing.Point(0, 0)
			Me.gclSingleMain.MainView = Me.gviewSingleMain
			Me.gclSingleMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gclSingleMain.Name = "gclSingleMain"
			Me.gclSingleMain.Size = New System.Drawing.Size(909, 614)
			Me.gclSingleMain.TabIndex = 2
			Me.gclSingleMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gviewSingleMain})
			' 
			' gviewSingleMain
			' 
			Me.gviewSingleMain.GridControl = Me.gclSingleMain
			Me.gviewSingleMain.Name = "gviewSingleMain"
			Me.gviewSingleMain.OptionsBehavior.Editable = False
			' 
			' xtpReferenceEquivalent
			' 
			Me.xtpReferenceEquivalent.Controls.Add(Me.splitContainerControl1)
			Me.xtpReferenceEquivalent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.xtpReferenceEquivalent.Name = "xtpReferenceEquivalent"
			Me.xtpReferenceEquivalent.Size = New System.Drawing.Size(909, 614)
			Me.xtpReferenceEquivalent.Text = "Reference's Equivalent"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.gclReference)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.gclSingle)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl2)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(909, 614)
			Me.splitContainerControl1.SplitterPosition = 351
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
			' gclReference
			' 
			Me.gclReference.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gclReference.Location = New System.Drawing.Point(0, 41)
			Me.gclReference.MainView = Me.gridView4
			Me.gclReference.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gclReference.Name = "gclReference"
			Me.gclReference.Size = New System.Drawing.Size(351, 573)
			Me.gclReference.TabIndex = 1
			Me.gclReference.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView4})
			' 
			' gridView4
			' 
			Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView4.GridControl = Me.gclReference
			Me.gridView4.Name = "gridView4"
			Me.gridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView4.OptionsBehavior.Editable = False
			Me.gridView4.OptionsView.ShowDetailButtons = False
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Product Name"
			Me.gridColumn1.FieldName = "ProductName"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Quantity Per Unit"
			Me.gridColumn2.FieldName = "QuantityPerUnit"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Unit Price"
			Me.gridColumn3.FieldName = "UnitPrice"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(351, 41)
			Me.panelControl1.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl1.Location = New System.Drawing.Point(19, 12)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(115, 17)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Reference Query"
			' 
			' gclSingle
			' 
			Me.gclSingle.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gclSingle.Location = New System.Drawing.Point(0, 41)
			Me.gclSingle.MainView = Me.gridView5
			Me.gclSingle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gclSingle.Name = "gclSingle"
			Me.gclSingle.Size = New System.Drawing.Size(553, 573)
			Me.gclSingle.TabIndex = 2
			Me.gclSingle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView5})
			' 
			' gridView5
			' 
			Me.gridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
			Me.gridView5.GridControl = Me.gclSingle
			Me.gridView5.Name = "gridView5"
			Me.gridView5.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView5.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView5.OptionsBehavior.Editable = False
			Me.gridView5.OptionsView.ShowDetailButtons = False
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Product Name"
			Me.gridColumn4.FieldName = "ProductName"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 0
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Quantity Per Unit"
			Me.gridColumn5.FieldName = "QuantityPerUnit"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 1
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Unit Price"
			Me.gridColumn6.FieldName = "UnitPrice"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 2
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.labelControl2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(553, 41)
			Me.panelControl2.TabIndex = 1
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl2.Location = New System.Drawing.Point(28, 12)
			Me.labelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(87, 17)
			Me.labelControl2.TabIndex = 1
			Me.labelControl2.Text = "Single Query"
			' 
			' Single
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Name = "Single"
			Me.Size = New System.Drawing.Size(915, 645)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtpSimple.ResumeLayout(False)
			CType(Me.gclSingleMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gviewSingleMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtpReferenceEquivalent.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.gclReference, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.gclSingle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtpSimple As DevExpress.XtraTab.XtraTabPage
		Private xtpReferenceEquivalent As DevExpress.XtraTab.XtraTabPage
		Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private gclReference As DevExpress.XtraGrid.GridControl
		Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gclSingle As DevExpress.XtraGrid.GridControl
		Private gridView5 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gclSingleMain As DevExpress.XtraGrid.GridControl
		Private gviewSingleMain As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

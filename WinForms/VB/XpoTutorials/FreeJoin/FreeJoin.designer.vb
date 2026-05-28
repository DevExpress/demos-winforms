Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class FreeJoin
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
            Me.gclFreeJoinMain = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.xtpAssociationsEquivalent = New DevExpress.XtraTab.XtraTabPage()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.gclAssociation = New DevExpress.XtraGrid.GridControl()
            Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.gclFreeJoin = New DevExpress.XtraGrid.GridControl()
            Me.gridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtpSimple.SuspendLayout()
            CType(Me.gclFreeJoinMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtpAssociationsEquivalent.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gclAssociation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.gclFreeJoin, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtpSimple
            Me.xtraTabControl1.Size = New System.Drawing.Size(1045, 685)
            Me.xtraTabControl1.TabIndex = 8
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpSimple, Me.xtpAssociationsEquivalent})
            '
            'xtpSimple
            '
            Me.xtpSimple.Controls.Add(Me.gclFreeJoinMain)
            Me.xtpSimple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpSimple.Name = "xtpSimple"
            Me.xtpSimple.Size = New System.Drawing.Size(1039, 654)
            Me.xtpSimple.Text = "Free Join"
            '
            'gclFreeJoinMain
            '
            Me.gclFreeJoinMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclFreeJoinMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclFreeJoinMain.Location = New System.Drawing.Point(0, 0)
            Me.gclFreeJoinMain.MainView = Me.gridView1
            Me.gclFreeJoinMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclFreeJoinMain.Name = "gclFreeJoinMain"
            Me.gclFreeJoinMain.Size = New System.Drawing.Size(1039, 654)
            Me.gclFreeJoinMain.TabIndex = 2
            Me.gclFreeJoinMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.GridControl = Me.gclFreeJoinMain
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            '
            'xtpAssociationsEquivalent
            '
            Me.xtpAssociationsEquivalent.Controls.Add(Me.splitContainerControl1)
            Me.xtpAssociationsEquivalent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpAssociationsEquivalent.Name = "xtpAssociationsEquivalent"
            Me.xtpAssociationsEquivalent.Size = New System.Drawing.Size(1039, 654)
            Me.xtpAssociationsEquivalent.Text = "Association's Equivalent"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.gclAssociation)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gclFreeJoin)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl2)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1039, 654)
            Me.splitContainerControl1.SplitterPosition = 336
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'gclAssociation
            '
            Me.gclAssociation.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclAssociation.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclAssociation.Location = New System.Drawing.Point(0, 43)
            Me.gclAssociation.MainView = Me.gridView4
            Me.gclAssociation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclAssociation.Name = "gclAssociation"
            Me.gclAssociation.Size = New System.Drawing.Size(450, 611)
            Me.gclAssociation.TabIndex = 1
            Me.gclAssociation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView4})
            '
            'gridView4
            '
            Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
            Me.gridView4.GridControl = Me.gclAssociation
            Me.gridView4.Name = "gridView4"
            Me.gridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView4.OptionsBehavior.Editable = False
            Me.gridView4.OptionsView.ShowDetailButtons = False
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Company Name"
            Me.gridColumn1.FieldName = "CompanyName"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "City"
            Me.gridColumn2.FieldName = "City"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Address"
            Me.gridColumn3.FieldName = "Address"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(450, 43)
            Me.panelControl1.TabIndex = 0
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Location = New System.Drawing.Point(21, 13)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(124, 17)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Association Query"
            '
            'gclFreeJoin
            '
            Me.gclFreeJoin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclFreeJoin.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclFreeJoin.Location = New System.Drawing.Point(0, 43)
            Me.gclFreeJoin.MainView = Me.gridView5
            Me.gclFreeJoin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclFreeJoin.Name = "gclFreeJoin"
            Me.gclFreeJoin.Size = New System.Drawing.Size(584, 611)
            Me.gclFreeJoin.TabIndex = 2
            Me.gclFreeJoin.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView5})
            '
            'gridView5
            '
            Me.gridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView5.GridControl = Me.gclFreeJoin
            Me.gridView5.Name = "gridView5"
            Me.gridView5.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView5.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView5.OptionsBehavior.Editable = False
            Me.gridView5.OptionsView.ShowDetailButtons = False
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Company Name"
            Me.gridColumn4.FieldName = "CompanyName"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 0
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "City"
            Me.gridColumn5.FieldName = "City"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 1
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "Address"
            Me.gridColumn6.FieldName = "Address"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 2
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.labelControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(584, 43)
            Me.panelControl2.TabIndex = 1
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.labelControl2.Location = New System.Drawing.Point(32, 13)
            Me.labelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(108, 17)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "Free Join Query"
            '
            'FreeJoin
            '
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "FreeJoin"
            Me.Size = New System.Drawing.Size(1045, 685)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtpSimple.ResumeLayout(False)
            CType(Me.gclFreeJoinMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtpAssociationsEquivalent.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gclAssociation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.gclFreeJoin, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtpSimple As DevExpress.XtraTab.XtraTabPage
        Private xtpAssociationsEquivalent As DevExpress.XtraTab.XtraTabPage
        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private gclAssociation As DevExpress.XtraGrid.GridControl
        Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gclFreeJoin As DevExpress.XtraGrid.GridControl
        Private gridView5 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gclFreeJoinMain As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

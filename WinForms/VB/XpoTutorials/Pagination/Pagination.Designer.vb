Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class Pagination
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagination))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.xpPageSelector1 = New DevExpress.Xpo.XPPageSelector
            Me.xpBusinessObjects = New DevExpress.Xpo.XPCollection
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colChecked = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.bSave = New DevExpress.XtraEditors.SimpleButton
            Me.lCurrentPage = New DevExpress.XtraEditors.LabelControl
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpBusinessObjects, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.xpPageSelector1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 48)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(543, 254)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'xpPageSelector1
            '
            Me.xpPageSelector1.Collection = Me.xpBusinessObjects
            '
            'xpBusinessObjects
            '
            Me.xpBusinessObjects.ObjectType = GetType(DevExpress.Xpo.Demos.BusinessObject)
            Me.xpBusinessObjects.Session = Me.unitOfWork1
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colText, Me.colChecked, Me.colCurrency})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '
            'colOid
            '
            Me.colOid.Caption = "Oid"
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.AllowEdit = False
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            Me.colOid.Width = 56
            '
            'colText
            '
            Me.colText.Caption = "Text"
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 1
            Me.colText.Width = 188
            '
            'colChecked
            '
            Me.colChecked.Caption = "Checked"
            Me.colChecked.FieldName = "Checked"
            Me.colChecked.Name = "colChecked"
            Me.colChecked.Visible = True
            Me.colChecked.VisibleIndex = 3
            Me.colChecked.Width = 134
            '
            'colCurrency
            '
            Me.colCurrency.Caption = "Currency"
            Me.colCurrency.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colCurrency.DisplayFormat.FormatString = "c2"
            Me.colCurrency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCurrency.FieldName = "Currency"
            Me.colCurrency.Name = "colCurrency"
            Me.colCurrency.Visible = True
            Me.colCurrency.VisibleIndex = 2
            Me.colCurrency.Width = 137
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.bSave)
            Me.panelControl1.Controls.Add(Me.lCurrentPage)
            Me.panelControl1.Controls.Add(Me.simpleButton2)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(543, 40)
            Me.panelControl1.TabIndex = 1
            '
            'bSave
            '
            Me.bSave.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.bSave.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
            Me.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.bSave.Location = New System.Drawing.Point(503, 8)
            Me.bSave.Name = "bSave"
            Me.bSave.Size = New System.Drawing.Size(32, 23)
            Me.bSave.TabIndex = 11
            Me.bSave.ToolTip = "Save Changes to Database"
            '
            'lCurrentPage
            '
            Me.lCurrentPage.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lCurrentPage.Location = New System.Drawing.Point(120, 14)
            Me.lCurrentPage.Name = "lCurrentPage"
            Me.lCurrentPage.Size = New System.Drawing.Size(68, 13)
            Me.lCurrentPage.TabIndex = 2
            Me.lCurrentPage.Text = "Current Page:"
            '
            'simpleButton2
            '
            Me.simpleButton2.Location = New System.Drawing.Point(216, 8)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(96, 23)
            Me.simpleButton2.TabIndex = 1
            Me.simpleButton2.Text = "Next Page"
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(8, 8)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(96, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Prev Page"
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 40)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(543, 8)
            Me.panelControl2.TabIndex = 5
            '
            'Pagination
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Pagination"
            Me.Size = New System.Drawing.Size(543, 302)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpBusinessObjects, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private xpPageSelector1 As DevExpress.Xpo.XPPageSelector
        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
        Private xpBusinessObjects As DevExpress.Xpo.XPCollection
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colText As DevExpress.XtraGrid.Columns.GridColumn
        Private colChecked As DevExpress.XtraGrid.Columns.GridColumn
        Private colCurrency As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private lCurrentPage As DevExpress.XtraEditors.LabelControl
        Private WithEvents bSave As DevExpress.XtraEditors.SimpleButton
        Private components As System.ComponentModel.Container = Nothing
        Private panelControl2 As DevExpress.XtraEditors.PanelControl

    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class OneToManyRelations
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        Private Sub InitializeComponent()
            Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.xpCustomers = New DevExpress.Xpo.XPCollection
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colOrderDate})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            '
            'colProductName
            '
            Me.colProductName.Caption = "Produc tName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            '
            'colOrderDate
            '
            Me.colOrderDate.Caption = "Order Date"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.xpCustomers
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            GridLevelNode1.LevelTemplate = Me.gridView2
            GridLevelNode1.RelationName = "Orders"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(427, 342)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            '
            'xpCustomers
            '
            Me.xpCustomers.ObjectType = GetType(DevExpress.Xpo.Demos.Customer)
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colName, Me.colAge})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.ShowDetailTabs = False
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
            Me.colOid.Width = 55
            '
            'colName
            '
            Me.colName.Caption = "Customer Name"
            Me.colName.FieldName = "Name"
            Me.colName.ImageIndex = 0
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            Me.colName.Width = 229
            '
            'colAge
            '
            Me.colAge.Caption = "Age"
            Me.colAge.FieldName = "Age"
            Me.colAge.Name = "colAge"
            Me.colAge.Visible = True
            Me.colAge.VisibleIndex = 2
            Me.colAge.Width = 111
            '
            'OneToManyRelations
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "OneToManyRelations"
            Me.Size = New System.Drawing.Size(427, 342)
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private xpCustomers As DevExpress.Xpo.XPCollection
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colAge As DevExpress.XtraGrid.Columns.GridColumn
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private components As System.ComponentModel.IContainer = Nothing

    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class SimpleDataAwareApplication
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
            Me.xpCustomers = New DevExpress.Xpo.XPCollection
            Me.gControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xpCustomers
            '
            Me.xpCustomers.DisplayableProperties = "This;Oid;Name;Age"
            Me.xpCustomers.ObjectType = GetType(DevExpress.Xpo.Demos.Customer)
            '
            'gControl1
            '
            Me.gControl1.DataSource = Me.xpCustomers
            Me.gControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gControl1.Location = New System.Drawing.Point(0, 0)
            Me.gControl1.MainView = Me.gridView1
            Me.gControl1.Name = "gControl1"
            Me.gControl1.Size = New System.Drawing.Size(414, 342)
            Me.gControl1.TabIndex = 0
            Me.gControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colName, Me.colAge})
            Me.gridView1.GridControl = Me.gControl1
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
            'SimpleDataAwareApplication
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gControl1)
            Me.Name = "SimpleDataAwareApplication"
            Me.Size = New System.Drawing.Size(414, 342)
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private xpCustomers As DevExpress.Xpo.XPCollection
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colAge As DevExpress.XtraGrid.Columns.GridColumn
        Private gControl1 As DevExpress.XtraGrid.GridControl
        Private components As System.ComponentModel.IContainer = Nothing

    End Class
End Namespace

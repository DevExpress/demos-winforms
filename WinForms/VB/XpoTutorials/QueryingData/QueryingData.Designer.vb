Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class QueryingData
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
            Me.components = New System.ComponentModel.Container
            Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.xpCustomers = New DevExpress.Xpo.XPCollection
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem
            Me.bar2 = New DevExpress.XtraBars.Bar
            Me.barStaticItemClient = New DevExpress.XtraBars.BarStaticItem
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem
            Me.barStaticItemDataStore = New DevExpress.XtraBars.BarStaticItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colOrderDate})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsCustomization.AllowFilter = False
            Me.gridView2.OptionsView.ShowGroupPanel = False
            '
            'colProductName
            '
            Me.colProductName.Caption = "Product Name"
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
            Me.gridControl1.Location = New System.Drawing.Point(0, 29)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(662, 287)
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
            Me.gridView1.OptionsCustomization.AllowFilter = False
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
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barEditItem1, Me.barEditItem2, Me.barStaticItemClient, Me.barStaticItemDataStore, Me.barStaticItem1})
            Me.barManager1.MaxItemId = 5
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.barManager1.StatusBar = Me.bar2
            '
            'bar1
            '
            Me.bar1.BarName = "Custom 2"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem1, "", False, True, True, 162), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem2, "", True, True, True, 136)})
            Me.bar1.Text = "Custom 2"
            '
            'barEditItem1
            '
            Me.barEditItem1.Caption = "Filter Criteria (client):"
            Me.barEditItem1.Edit = Me.repositoryItemImageComboBox1
            Me.barEditItem1.EditValue = "(no filter)"
            Me.barEditItem1.Hint = "Select the criteria used to filter objects on the client side"
            Me.barEditItem1.Id = 0
            Me.barEditItem1.Name = "barEditItem1"
            Me.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.barEditItem1.Tag = "Client"
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Clear Filter", Nothing, Nothing, True)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("(no filter)", Nothing, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customers who are older than 30 and younger than 40", "Age > 30 AND Age < 40", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customers who are younger than 25", "Age < 25", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customers whose name is Bob or Peter", "Name like '%Bob%' OR Name like '%Peter%'", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customers who ordered Chai", "Orders[ProductName = 'Chai']", -1)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'barEditItem2
            '
            Me.barEditItem2.Caption = "Filter Criteria (data store):"
            Me.barEditItem2.Edit = Me.repositoryItemImageComboBox1
            Me.barEditItem2.EditValue = "(no filter)"
            Me.barEditItem2.Hint = "Select the criteria used to filter objects on the data store side"
            Me.barEditItem2.Id = 1
            Me.barEditItem2.Name = "barEditItem2"
            Me.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.barEditItem2.Tag = "DataStore"
            '
            'bar2
            '
            Me.bar2.BarName = "StatusBar"
            Me.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItemClient), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItemDataStore)})
            Me.bar2.OptionsBar.AllowQuickCustomization = False
            Me.bar2.OptionsBar.DrawDragBorder = False
            Me.bar2.OptionsBar.DrawSizeGrip = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "StatusBar"
            '
            'barStaticItemClient
            '
            Me.barStaticItemClient.Caption = "Filter String (client):"
            Me.barStaticItemClient.Id = 2
            Me.barStaticItemClient.Name = "barStaticItemClient"
            Me.barStaticItemClient.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'barStaticItem1
            '
            Me.barStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
            Me.barStaticItem1.Id = 4
            Me.barStaticItem1.Name = "barStaticItem1"
            Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
            Me.barStaticItem1.Width = 32
            '
            'barStaticItemDataStore
            '
            Me.barStaticItemDataStore.Caption = "Filter String (data store):"
            Me.barStaticItemDataStore.Id = 3
            Me.barStaticItemDataStore.Name = "barStaticItemDataStore"
            Me.barStaticItemDataStore.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(662, 29)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 316)
            Me.barDockControlBottom.Size = New System.Drawing.Size(662, 26)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 287)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(662, 29)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 287)
            '
            'QueryingData
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "QueryingData"
            Me.Size = New System.Drawing.Size(662, 342)
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCustomers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private bar1 As DevExpress.XtraBars.Bar
        Private WithEvents barEditItem1 As DevExpress.XtraBars.BarEditItem
        Private WithEvents barEditItem2 As DevExpress.XtraBars.BarEditItem
        Private bar2 As DevExpress.XtraBars.Bar
        Private WithEvents repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private barStaticItemClient As DevExpress.XtraBars.BarStaticItem
        Private barStaticItemDataStore As DevExpress.XtraBars.BarStaticItem
        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
        Private components As System.ComponentModel.IContainer = Nothing

    End Class
End Namespace

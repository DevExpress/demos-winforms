Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class MasterDetailGrouping

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.MasterDetailGrouping))
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.chJoined = New DevExpress.XtraEditors.CheckButton()
            Me.chOwner = New DevExpress.XtraEditors.CheckButton()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            Me.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomer, Me.colOrderDate, Me.colRequiredDate, Me.colShippedDate, Me.colShipVia, Me.colFreight, Me.colShipName, Me.colShipAddress, Me.colShipCity, Me.colShipRegion, Me.colShipPostalCode, Me.colShipCountry})
            Me.gridView2.DetailHeight = 300
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.GroupCount = 1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsView.ShowChildrenInGroupPanel = True
            Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colShipVia, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView2.EndGrouping, New System.EventHandler(AddressOf Me.gridView_EndGrouping)
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            ' 
            ' colCustomer
            ' 
            resources.ApplyResources(Me.colCustomer, "colCustomer")
            Me.colCustomer.FieldName = "CustomerID"
            Me.colCustomer.Name = "colCustomer"
            ' 
            ' colOrderDate
            ' 
            resources.ApplyResources(Me.colOrderDate, "colOrderDate")
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' colRequiredDate
            ' 
            resources.ApplyResources(Me.colRequiredDate, "colRequiredDate")
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            ' 
            ' colShippedDate
            ' 
            resources.ApplyResources(Me.colShippedDate, "colShippedDate")
            Me.colShippedDate.FieldName = "ShippedDate"
            Me.colShippedDate.Name = "colShippedDate"
            ' 
            ' colShipVia
            ' 
            resources.ApplyResources(Me.colShipVia, "colShipVia")
            Me.colShipVia.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.colShipVia.FieldName = "ShipVia"
            Me.colShipVia.ImageOptions.ImageIndex =(CInt((resources.GetObject("colShipVia.ImageOptions.ImageIndex"))))
            Me.colShipVia.Name = "colShipVia"
            ' 
            ' repositoryItemImageComboBox3
            ' 
            Me.repositoryItemImageComboBox3.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox3.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items8")))))})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            ' 
            ' colFreight
            ' 
            resources.ApplyResources(Me.colFreight, "colFreight")
            Me.colFreight.ColumnEdit = Me.repositoryItemSpinEdit3
            Me.colFreight.DisplayFormat.FormatString = "c"
            Me.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight.FieldName = "Freight"
            Me.colFreight.Name = "colFreight"
            ' 
            ' repositoryItemSpinEdit3
            ' 
            Me.repositoryItemSpinEdit3.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemSpinEdit3, "repositoryItemSpinEdit3")
            Me.repositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3"
            ' 
            ' colShipName
            ' 
            resources.ApplyResources(Me.colShipName, "colShipName")
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            ' 
            ' colShipAddress
            ' 
            resources.ApplyResources(Me.colShipAddress, "colShipAddress")
            Me.colShipAddress.FieldName = "ShipAddress"
            Me.colShipAddress.Name = "colShipAddress"
            ' 
            ' colShipCity
            ' 
            resources.ApplyResources(Me.colShipCity, "colShipCity")
            Me.colShipCity.FieldName = "ShipCity"
            Me.colShipCity.Name = "colShipCity"
            ' 
            ' colShipRegion
            ' 
            resources.ApplyResources(Me.colShipRegion, "colShipRegion")
            Me.colShipRegion.FieldName = "ShipRegion"
            Me.colShipRegion.Name = "colShipRegion"
            ' 
            ' colShipPostalCode
            ' 
            resources.ApplyResources(Me.colShipPostalCode, "colShipPostalCode")
            Me.colShipPostalCode.FieldName = "ShipPostalCode"
            Me.colShipPostalCode.Name = "colShipPostalCode"
            ' 
            ' colShipCountry
            ' 
            resources.ApplyResources(Me.colShipCountry, "colShipCountry")
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            ' 
            ' gridControl2
            ' 
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            gridLevelNode1.LevelTemplate = Me.gridView2
            gridLevelNode1.RelationName = "Orders"
            Me.gridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.gridControl2.MainView = Me.gridView1
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit3, Me.repositoryItemImageComboBox3})
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            AddHandler Me.gridControl2.ViewRegistered, New DevExpress.XtraGrid.ViewOperationEventHandler(AddressOf Me.gridControl2_ViewRegistered)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
            Me.gridView1.DetailHeight = 200
            Me.gridView1.GridControl = Me.gridControl2
            Me.gridView1.GroupCount = 2
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsDetail.AllowZoomDetail = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colContactTitle, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegion, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView1.EndGrouping, New System.EventHandler(AddressOf Me.gridView_EndGrouping)
            ' 
            ' colCustomerID
            ' 
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.OptionsFilter.AllowFilter = False
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.ImageOptions.ImageIndex =(CInt((resources.GetObject("colContactName.ImageOptions.ImageIndex"))))
            Me.colContactName.ImageOptions.SvgImage = CType((resources.GetObject("colContactName.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colContactName.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            ' 
            ' colPhone
            ' 
            resources.ApplyResources(Me.colPhone, "colPhone")
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.ImageOptions.SvgImage = CType((resources.GetObject("colPhone.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colPhone.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colPhone.Name = "colPhone"
            ' 
            ' colFax
            ' 
            resources.ApplyResources(Me.colFax, "colFax")
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.chJoined)
            Me.panelControl1.Controls.Add(Me.chOwner)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' chJoined
            ' 
            Me.chJoined.AllowFocus = False
            Me.chJoined.Appearance.Font = CType((resources.GetObject("chJoined.Appearance.Font")), System.Drawing.Font)
            Me.chJoined.Appearance.Options.UseFont = True
            Me.chJoined.Appearance.Options.UseTextOptions = True
            Me.chJoined.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chJoined.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chJoined.ImageOptions.SvgImage = CType((resources.GetObject("chJoined.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            resources.ApplyResources(Me.chJoined, "chJoined")
            Me.chJoined.Name = "chJoined"
            Me.chJoined.Tag = "Merged Group Panel"
            AddHandler Me.chJoined.CheckedChanged, New System.EventHandler(AddressOf Me.ch_CheckedChanged)
            ' 
            ' chOwner
            ' 
            Me.chOwner.AllowFocus = False
            Me.chOwner.Appearance.Font = CType((resources.GetObject("chOwner.Appearance.Font")), System.Drawing.Font)
            Me.chOwner.Appearance.Options.UseFont = True
            Me.chOwner.Appearance.Options.UseTextOptions = True
            Me.chOwner.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chOwner.Checked = True
            Me.chOwner.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chOwner.ImageOptions.SvgImage = CType((resources.GetObject("chOwner.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            resources.ApplyResources(Me.chOwner, "chOwner")
            Me.chOwner.Name = "chOwner"
            Me.chOwner.Tag = "Separate Group Panels"
            AddHandler Me.chOwner.CheckedChanged, New System.EventHandler(AddressOf Me.ch_CheckedChanged)
            ' 
            ' MasterDetailGrouping
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MasterDetailGrouping"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MasterDetailGrouping_Load)
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn

        Private colFax As DevExpress.XtraGrid.Columns.GridColumn

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhone As DevExpress.XtraGrid.Columns.GridColumn

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomer As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private chOwner As DevExpress.XtraEditors.CheckButton

        Private chJoined As DevExpress.XtraEditors.CheckButton
    End Class
End Namespace

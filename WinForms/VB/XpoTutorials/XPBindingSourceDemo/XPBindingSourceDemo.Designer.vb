Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class XPBindingSourceDemo
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
            Me.components = New System.ComponentModel.Container()
            Me.session1 = New DevExpress.Xpo.Session(Me.components)
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.cbDataSource = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpBindingSource1 = New DevExpress.Xpo.XPBindingSource(Me.components)
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.cbDataSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.cbDataSource)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(613, 38)
            Me.panel1.TabIndex = 1
            '
            'cbDataSource
            '
            Me.cbDataSource.Location = New System.Drawing.Point(84, 9)
            Me.cbDataSource.Name = "cbDataSource"
            Me.cbDataSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbDataSource.Properties.Items.AddRange(New Object() {"XPCollection", "List of Objects", "Single Object", "Nothing"})
            Me.cbDataSource.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbDataSource.Size = New System.Drawing.Size(224, 20)
            Me.cbDataSource.TabIndex = 3
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(12, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(66, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Data Source: "
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.xpBindingSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(2, 21)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(609, 277)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'xpBindingSource1
            '
            Me.xpBindingSource1.DataSource = Me.xpCollection1
            '
            'xpCollection1
            '
            Me.xpCollection1.ObjectType = GetType(DevExpress.Xpo.Demos.Customers)
            Me.xpCollection1.Session = Me.session1
            '
            'gridView1
            '
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAddress, Me.colCity, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colCountry, Me.colCustomerID, Me.colFax, Me.colPhone, Me.colPostalCode, Me.colRegion})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.BestFitMaxRowCount = 100
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            '
            'colAddress
            '
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 0
            '
            'colCity
            '
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            Me.colCity.Visible = True
            Me.colCity.VisibleIndex = 1
            '
            'colCompanyName
            '
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.Visible = True
            Me.colCompanyName.VisibleIndex = 2
            '
            'colContactName
            '
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            Me.colContactName.Visible = True
            Me.colContactName.VisibleIndex = 3
            '
            'colContactTitle
            '
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            Me.colContactTitle.Visible = True
            Me.colContactTitle.VisibleIndex = 4
            '
            'colCountry
            '
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            Me.colCountry.Visible = True
            Me.colCountry.VisibleIndex = 5
            '
            'colCustomerID
            '
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 6
            '
            'colFax
            '
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            Me.colFax.Visible = True
            Me.colFax.VisibleIndex = 7
            '
            'colPhone
            '
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            Me.colPhone.Visible = True
            Me.colPhone.VisibleIndex = 8
            '
            'colPostalCode
            '
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            Me.colPostalCode.Visible = True
            Me.colPostalCode.VisibleIndex = 9
            '
            'colRegion
            '
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            Me.colRegion.Visible = True
            Me.colRegion.VisibleIndex = 10
            '
            'groupControl1
            '
            Me.groupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.groupControl1.AppearanceCaption.Options.UseFont = True
            Me.groupControl1.Controls.Add(Me.gridControl1)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupControl1.Location = New System.Drawing.Point(0, 46)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(613, 300)
            Me.groupControl1.TabIndex = 4
            Me.groupControl1.Text = "groupControl1"
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 38)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(613, 8)
            Me.panelControl2.TabIndex = 5
            '
            'XPBindingSourceDemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.groupControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panel1)
            Me.Name = "XPBindingSourceDemo"
            Me.Size = New System.Drawing.Size(613, 346)
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.cbDataSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private session1 As DevExpress.Xpo.Session
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private components As ComponentModel.IContainer
        Private WithEvents xpCollection1 As XPCollection
        Private WithEvents xpBindingSource1 As XPBindingSource
        Private WithEvents cbDataSource As XtraEditors.ComboBoxEdit
        Private WithEvents label1 As XtraEditors.LabelControl
        Friend WithEvents colAddress As XtraGrid.Columns.GridColumn
        Friend WithEvents colCity As XtraGrid.Columns.GridColumn
        Friend WithEvents colCompanyName As XtraGrid.Columns.GridColumn
        Friend WithEvents colContactName As XtraGrid.Columns.GridColumn
        Friend WithEvents colContactTitle As XtraGrid.Columns.GridColumn
        Friend WithEvents colCountry As XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomerID As XtraGrid.Columns.GridColumn
        Friend WithEvents colFax As XtraGrid.Columns.GridColumn
        Friend WithEvents colPhone As XtraGrid.Columns.GridColumn
        Friend WithEvents colPostalCode As XtraGrid.Columns.GridColumn
        Friend WithEvents colRegion As XtraGrid.Columns.GridColumn
    End Class
End Namespace

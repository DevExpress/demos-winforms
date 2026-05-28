Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class Images
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Images))
            Me.xpCars = New DevExpress.Xpo.XPCollection(Me.components)
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTradeMark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.bSave = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.xpCars, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xpCars
            ' 
            Me.xpCars.LoadingEnabled = False
            Me.xpCars.ObjectType = GetType(DevExpress.Xpo.Demos.Cars)
            Me.xpCars.Session = Me.unitOfWork1
            ' 
            ' unitOfWork1
            ' 
            Me.unitOfWork1.TrackPropertiesModifications = False
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpCars
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 54)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemImageEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(897, 478)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colTradeMark, Me.colModel, Me.colInStock, Me.colPrice, Me.colPicture})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            ' 
            ' colOid
            ' 
            Me.colOid.Caption = "Oid"
            Me.colOid.FieldName = "ID"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.AllowEdit = False
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            ' 
            ' colTradeMark
            ' 
            Me.colTradeMark.Caption = "TradeMark"
            Me.colTradeMark.FieldName = "TrademarkName"
            Me.colTradeMark.Name = "colTradeMark"
            Me.colTradeMark.Visible = True
            Me.colTradeMark.VisibleIndex = 1
            ' 
            ' colModel
            ' 
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 2
            ' 
            ' colInStock
            ' 
            Me.colInStock.Caption = "InStock"
            Me.colInStock.FieldName = "IsInStock"
            Me.colInStock.Name = "colInStock"
            Me.colInStock.Visible = True
            Me.colInStock.VisibleIndex = 3
            ' 
            ' colPrice
            ' 
            Me.colPrice.Caption = "Price"
            Me.colPrice.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 4
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.DisplayFormat.FormatString = "c2"
            Me.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colPicture
            ' 
            Me.colPicture.Caption = "Picture"
            Me.colPicture.ColumnEdit = Me.repositoryItemImageEdit1
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 5
            ' 
            ' repositoryItemImageEdit1
            ' 
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.bSave)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(897, 44)
            Me.panelControl1.TabIndex = 3
            ' 
            ' bSave
            ' 
            Me.bSave.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.bSave.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.bSave.Image = (CType(resources.GetObject("bSave.Image"), System.Drawing.Image))
            Me.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.bSave.Location = New System.Drawing.Point(850, 10)
            Me.bSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.bSave.Name = "bSave"
            Me.bSave.Size = New System.Drawing.Size(37, 28)
            Me.bSave.TabIndex = 10
            Me.bSave.ToolTip = "Save Changes to Database"
            '			Me.bSave.Click += New System.EventHandler(Me.bSave_Click);
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 44)
            Me.panelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(897, 10)
            Me.panelControl2.TabIndex = 4
            ' 
            ' Images
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 16.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "Images"
            Me.Size = New System.Drawing.Size(897, 532)
            '			Me.Load += New System.EventHandler(Me.Images_Load);
            CType(Me.xpCars, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colTradeMark As DevExpress.XtraGrid.Columns.GridColumn
        Private colModel As DevExpress.XtraGrid.Columns.GridColumn
        Private colInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Private xpCars As DevExpress.Xpo.XPCollection
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents bSave As DevExpress.XtraEditors.SimpleButton
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private components As System.ComponentModel.IContainer

    End Class
End Namespace

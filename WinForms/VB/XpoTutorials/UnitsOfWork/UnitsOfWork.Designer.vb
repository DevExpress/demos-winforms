Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class UnitsOfWork
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnitsOfWork))
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.xpProjects = New DevExpress.Xpo.XPCollection
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colOwner = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.iProjectStatus = New System.Windows.Forms.ImageList(Me.components)
            Me.colProjectType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.iProjectType = New System.Windows.Forms.ImageList(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colOrderDate})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
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
            Me.gridControl1.DataSource = Me.xpProjects
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
            Me.gridControl1.Location = New System.Drawing.Point(0, 48)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(577, 246)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            '
            'xpProjects
            '
            Me.xpProjects.ObjectType = GetType(DevExpress.Xpo.Demos.Project)
            Me.xpProjects.Session = Me.unitOfWork1
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colProjectName, Me.colOwner, Me.colCreatedDate, Me.colStatus, Me.colProjectType})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsSelection.MultiSelect = True
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
            '
            'colProjectName
            '
            Me.colProjectName.Caption = "Project Name"
            Me.colProjectName.FieldName = "ProjectName"
            Me.colProjectName.Name = "colProjectName"
            Me.colProjectName.Visible = True
            Me.colProjectName.VisibleIndex = 1
            '
            'colOwner
            '
            Me.colOwner.Caption = "Owner"
            Me.colOwner.FieldName = "Owner"
            Me.colOwner.Name = "colOwner"
            Me.colOwner.Visible = True
            Me.colOwner.VisibleIndex = 2
            '
            'colCreatedDate
            '
            Me.colCreatedDate.Caption = "Created Date"
            Me.colCreatedDate.FieldName = "CreatedDate"
            Me.colCreatedDate.Name = "colCreatedDate"
            Me.colCreatedDate.Visible = True
            Me.colCreatedDate.VisibleIndex = 3
            '
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 4
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.iProjectStatus
            '
            'iProjectStatus
            '
            Me.iProjectStatus.ImageStream = CType(resources.GetObject("iProjectStatus.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.iProjectStatus.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectStatus.Images.SetKeyName(0, "")
            Me.iProjectStatus.Images.SetKeyName(1, "")
            Me.iProjectStatus.Images.SetKeyName(2, "")
            Me.iProjectStatus.Images.SetKeyName(3, "")
            '
            'colProjectType
            '
            Me.colProjectType.Caption = "Project Type"
            Me.colProjectType.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colProjectType.FieldName = "ProjectType"
            Me.colProjectType.Name = "colProjectType"
            Me.colProjectType.Visible = True
            Me.colProjectType.VisibleIndex = 5
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.iProjectType
            '
            'iProjectType
            '
            Me.iProjectType.ImageStream = CType(resources.GetObject("iProjectType.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.iProjectType.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectType.Images.SetKeyName(0, "")
            Me.iProjectType.Images.SetKeyName(1, "")
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(577, 40)
            Me.panelControl1.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(12, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(72, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Project Status:"
            '
            'imageComboBoxEdit1
            '
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(90, 9)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Properties.SmallImages = Me.iProjectStatus
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(128, 20)
            Me.imageComboBoxEdit1.TabIndex = 1
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(254, 8)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(200, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Change Status of Selected Projects"
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 40)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(577, 8)
            Me.panelControl2.TabIndex = 5
            '
            'UnitsOfWork
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "UnitsOfWork"
            Me.Size = New System.Drawing.Size(577, 294)
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private xpProjects As DevExpress.Xpo.XPCollection
        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colProjectName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOwner As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private colProjectType As DevExpress.XtraGrid.Columns.GridColumn
        Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private iProjectStatus As System.Windows.Forms.ImageList
        Private iProjectType As System.Windows.Forms.ImageList
        Private components As System.ComponentModel.IContainer
        Private panelControl2 As DevExpress.XtraEditors.PanelControl

    End Class
End Namespace

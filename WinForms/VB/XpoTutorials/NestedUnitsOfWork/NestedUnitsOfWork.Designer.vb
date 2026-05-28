Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class NestedUnitsOfWork
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NestedUnitsOfWork))
            Me.iProjectStatus = New System.Windows.Forms.ImageList(Me.components)
            Me.iProjectType = New System.Windows.Forms.ImageList(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpProjects = New DevExpress.Xpo.XPCollection()
            Me.session1 = New DevExpress.Xpo.Session()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOwner = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colProjectType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' iProjectStatus
            ' 
            Me.iProjectStatus.ImageStream = (CType(resources.GetObject("iProjectStatus.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.iProjectStatus.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectStatus.Images.SetKeyName(0, "")
            Me.iProjectStatus.Images.SetKeyName(1, "")
            Me.iProjectStatus.Images.SetKeyName(2, "")
            Me.iProjectStatus.Images.SetKeyName(3, "")
            ' 
            ' iProjectType
            ' 
            Me.iProjectType.ImageStream = (CType(resources.GetObject("iProjectType.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.iProjectType.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectType.Images.SetKeyName(0, "")
            Me.iProjectType.Images.SetKeyName(1, "")
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpProjects
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
            Me.gridControl1.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 8, True, True, "Edit Record", "EditRecord")})
            Me.gridControl1.EmbeddedNavigator.Name = ""
            '			Me.gridControl1.EmbeddedNavigator.ButtonClick += New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(Me.gridControl1_EmbeddedNavigator_ButtonClick);
            Me.gridControl1.Location = New System.Drawing.Point(4, 4)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
            Me.gridControl1.Size = New System.Drawing.Size(777, 334)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' xpProjects
            ' 
            Me.xpProjects.ObjectType = GetType(DevExpress.Xpo.Demos.Project)
            Me.xpProjects.Session = Me.session1
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colProjectName, Me.colOwner, Me.colCreatedDate, Me.colStatus, Me.colProjectType, Me.colName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
            ' 
            ' colOid
            ' 
            Me.colOid.Caption = "ID"
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            Me.colOid.Width = 37
            ' 
            ' colProjectName
            ' 
            Me.colProjectName.Caption = "Project Name"
            Me.colProjectName.FieldName = "ProjectName"
            Me.colProjectName.Name = "colProjectName"
            Me.colProjectName.OptionsColumn.ReadOnly = True
            Me.colProjectName.Visible = True
            Me.colProjectName.VisibleIndex = 1
            Me.colProjectName.Width = 178
            ' 
            ' colOwner
            ' 
            Me.colOwner.Caption = "Owner"
            Me.colOwner.FieldName = "Owner"
            Me.colOwner.Name = "colOwner"
            Me.colOwner.OptionsColumn.ReadOnly = True
            Me.colOwner.Visible = True
            Me.colOwner.VisibleIndex = 3
            Me.colOwner.Width = 113
            ' 
            ' colCreatedDate
            ' 
            Me.colCreatedDate.Caption = "Created Date"
            Me.colCreatedDate.FieldName = "CreatedDate"
            Me.colCreatedDate.Name = "colCreatedDate"
            Me.colCreatedDate.OptionsColumn.ReadOnly = True
            Me.colCreatedDate.Visible = True
            Me.colCreatedDate.VisibleIndex = 4
            Me.colCreatedDate.Width = 94
            ' 
            ' colStatus
            ' 
            Me.colStatus.Caption = "Status"
            Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.OptionsColumn.ReadOnly = True
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 5
            Me.colStatus.Width = 79
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.iProjectStatus
            ' 
            ' colProjectType
            ' 
            Me.colProjectType.Caption = "Project Type"
            Me.colProjectType.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colProjectType.FieldName = "ProjectType"
            Me.colProjectType.Name = "colProjectType"
            Me.colProjectType.OptionsColumn.ReadOnly = True
            Me.colProjectType.Visible = True
            Me.colProjectType.VisibleIndex = 6
            Me.colProjectType.Width = 102
            ' 
            ' repositoryItemImageComboBox2
            ' 
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.iProjectType
            ' 
            ' colName
            ' 
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.OptionsColumn.ReadOnly = True
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 2
            Me.colName.Width = 168
            ' 
            ' NestedUnitsOfWork
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "NestedUnitsOfWork"
            Me.Size = New System.Drawing.Size(785, 342)
            '			Me.Load += New System.EventHandler(Me.NestedUnitsOfWork_Load);
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private iProjectStatus As System.Windows.Forms.ImageList
        Private iProjectType As System.Windows.Forms.ImageList
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private colProjectName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOwner As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private colProjectType As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private session1 As DevExpress.Xpo.Session
        Private xpProjects As DevExpress.Xpo.XPCollection
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private components As System.ComponentModel.IContainer

    End Class
End Namespace

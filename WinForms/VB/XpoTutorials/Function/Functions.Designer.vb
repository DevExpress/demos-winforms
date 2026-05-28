Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class Functions
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
            Me.components = New System.ComponentModel.Container()
            Me.gclGetYearGroup = New DevExpress.XtraGrid.GridControl()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.session1 = New DevExpress.Xpo.Session(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcBirthYear = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtpGetYear = New DevExpress.XtraTab.XtraTabPage()
            Me.xtpMathematic = New DevExpress.XtraTab.XtraTabPage()
            Me.gclMathematic = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.xtpText = New DevExpress.XtraTab.XtraTabPage()
            Me.gclStrings = New DevExpress.XtraGrid.GridControl()
            Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.xtpCustom = New DevExpress.XtraTab.XtraTabPage()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.gclCustomInMemory = New DevExpress.XtraGrid.GridControl()
            Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.gclCustomQuery = New DevExpress.XtraGrid.GridControl()
            Me.gridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.gclGetYearGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtpGetYear.SuspendLayout()
            Me.xtpMathematic.SuspendLayout()
            CType(Me.gclMathematic, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtpText.SuspendLayout()
            CType(Me.gclStrings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtpCustom.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gclCustomInMemory, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.gclCustomQuery, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gclGetYearGroup
            '
            Me.gclGetYearGroup.DataSource = Me.xpCollection1
            Me.gclGetYearGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclGetYearGroup.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclGetYearGroup.Location = New System.Drawing.Point(0, 0)
            Me.gclGetYearGroup.MainView = Me.gridView1
            Me.gclGetYearGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclGetYearGroup.Name = "gclGetYearGroup"
            Me.gclGetYearGroup.Size = New System.Drawing.Size(1014, 679)
            Me.gclGetYearGroup.TabIndex = 7
            Me.gclGetYearGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'xpCollection1
            '
            Me.xpCollection1.ObjectType = GetType(DevExpress.Xpo.Demos.Functions.Employees)
            Me.xpCollection1.Session = Me.session1
            '
            'session1
            '
            Me.session1.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
            Me.session1.TrackPropertiesModifications = False
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colLastName, Me.colBirthDate, Me.colHomePhone, Me.colNotes, Me.colTitle, Me.colTitleOfCourtesy, Me.gcBirthYear})
            Me.gridView1.GridControl = Me.gclGetYearGroup
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcBirthYear, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colFirstName
            '
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            '
            'colLastName
            '
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 3
            '
            'colBirthDate
            '
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.Visible = True
            Me.colBirthDate.VisibleIndex = 0
            '
            'colHomePhone
            '
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            Me.colHomePhone.Visible = True
            Me.colHomePhone.VisibleIndex = 2
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 4
            '
            'colTitle
            '
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.Visible = True
            Me.colTitle.VisibleIndex = 5
            '
            'colTitleOfCourtesy
            '
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            Me.colTitleOfCourtesy.Visible = True
            Me.colTitleOfCourtesy.VisibleIndex = 6
            '
            'gcBirthYear
            '
            Me.gcBirthYear.Caption = "BirthYear"
            Me.gcBirthYear.FieldName = "BirthYear"
            Me.gcBirthYear.Name = "gcBirthYear"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtpGetYear
            Me.xtraTabControl1.Size = New System.Drawing.Size(1045, 685)
            Me.xtraTabControl1.TabIndex = 8
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGetYear, Me.xtpMathematic, Me.xtpText, Me.xtpCustom})
            '
            'xtpGetYear
            '
            Me.xtpGetYear.Controls.Add(Me.gclGetYearGroup)
            Me.xtpGetYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpGetYear.Name = "xtpGetYear"
            Me.xtpGetYear.Size = New System.Drawing.Size(1014, 679)
            Me.xtpGetYear.Text = "Datetime"
            '
            'xtpMathematic
            '
            Me.xtpMathematic.Controls.Add(Me.gclMathematic)
            Me.xtpMathematic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpMathematic.Name = "xtpMathematic"
            Me.xtpMathematic.Size = New System.Drawing.Size(1014, 679)
            Me.xtpMathematic.Text = "Mathematic"
            '
            'gclMathematic
            '
            Me.gclMathematic.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclMathematic.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclMathematic.Location = New System.Drawing.Point(0, 0)
            Me.gclMathematic.MainView = Me.gridView2
            Me.gclMathematic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclMathematic.Name = "gclMathematic"
            Me.gclMathematic.Size = New System.Drawing.Size(1014, 679)
            Me.gclMathematic.TabIndex = 0
            Me.gclMathematic.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            '
            'gridView2
            '
            Me.gridView2.GridControl = Me.gclMathematic
            Me.gridView2.Name = "gridView2"
            '
            'xtpText
            '
            Me.xtpText.Controls.Add(Me.gclStrings)
            Me.xtpText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpText.Name = "xtpText"
            Me.xtpText.Size = New System.Drawing.Size(1014, 679)
            Me.xtpText.Text = "String"
            '
            'gclStrings
            '
            Me.gclStrings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclStrings.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclStrings.Location = New System.Drawing.Point(0, 0)
            Me.gclStrings.MainView = Me.gridView3
            Me.gclStrings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclStrings.Name = "gclStrings"
            Me.gclStrings.Size = New System.Drawing.Size(1014, 679)
            Me.gclStrings.TabIndex = 0
            Me.gclStrings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView3})
            '
            'gridView3
            '
            Me.gridView3.GridControl = Me.gclStrings
            Me.gridView3.Name = "gridView3"
            '
            'xtpCustom
            '
            Me.xtpCustom.Controls.Add(Me.splitContainerControl1)
            Me.xtpCustom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.xtpCustom.Name = "xtpCustom"
            Me.xtpCustom.Size = New System.Drawing.Size(1014, 679)
            Me.xtpCustom.Text = "Custom Functions Everywhere*"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.gclCustomInMemory)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gclCustomQuery)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl2)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1014, 679)
            Me.splitContainerControl1.SplitterPosition = 372
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'gclCustomInMemory
            '
            Me.gclCustomInMemory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclCustomInMemory.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclCustomInMemory.Location = New System.Drawing.Point(0, 43)
            Me.gclCustomInMemory.MainView = Me.gridView4
            Me.gclCustomInMemory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclCustomInMemory.Name = "gclCustomInMemory"
            Me.gclCustomInMemory.Size = New System.Drawing.Size(498, 636)
            Me.gclCustomInMemory.TabIndex = 1
            Me.gclCustomInMemory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView4})
            '
            'gridView4
            '
            Me.gridView4.GridControl = Me.gclCustomInMemory
            Me.gridView4.Name = "gridView4"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(498, 43)
            Me.panelControl1.TabIndex = 0
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Location = New System.Drawing.Point(21, 13)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(152, 17)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "In Memory Evaluation"
            '
            'gclCustomQuery
            '
            Me.gclCustomQuery.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclCustomQuery.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclCustomQuery.Location = New System.Drawing.Point(0, 43)
            Me.gclCustomQuery.MainView = Me.gridView5
            Me.gclCustomQuery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclCustomQuery.Name = "gclCustomQuery"
            Me.gclCustomQuery.Size = New System.Drawing.Size(511, 636)
            Me.gclCustomQuery.TabIndex = 2
            Me.gclCustomQuery.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView5})
            '
            'gridView5
            '
            Me.gridView5.GridControl = Me.gclCustomQuery
            Me.gridView5.Name = "gridView5"
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.labelControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(511, 43)
            Me.panelControl2.TabIndex = 1
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.labelControl2.Location = New System.Drawing.Point(32, 13)
            Me.labelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(110, 17)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "Database Query"
            '
            'Functions
            '
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Functions"
            Me.Size = New System.Drawing.Size(1045, 685)
            CType(Me.gclGetYearGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtpGetYear.ResumeLayout(False)
            Me.xtpMathematic.ResumeLayout(False)
            CType(Me.gclMathematic, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtpText.ResumeLayout(False)
            CType(Me.gclStrings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtpCustom.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gclCustomInMemory, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.gclCustomQuery, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gclGetYearGroup As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private xpCollection1 As XPCollection
        Private session1 As Session
        Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn
        Private gcBirthYear As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtpGetYear As DevExpress.XtraTab.XtraTabPage
        Private xtpMathematic As DevExpress.XtraTab.XtraTabPage
        Private gclMathematic As DevExpress.XtraGrid.GridControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private xtpText As DevExpress.XtraTab.XtraTabPage
        Private gclStrings As DevExpress.XtraGrid.GridControl
        Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Private xtpCustom As DevExpress.XtraTab.XtraTabPage
        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private gclCustomInMemory As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gclCustomQuery As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace

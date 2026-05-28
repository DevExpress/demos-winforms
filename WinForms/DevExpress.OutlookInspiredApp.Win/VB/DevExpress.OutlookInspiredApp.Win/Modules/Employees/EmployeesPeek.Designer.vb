Namespace DevExpress.DevAV.Modules

    Partial Class EmployeesPeek

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFullName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.searchControl)
            Me.moduleLayout.Controls.Add(Me.gridControl)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(250, 330)
            Me.moduleLayout.TabIndex = 1
            Me.searchControl.Client = Me.gridControl
            Me.searchControl.Location = New System.Drawing.Point(10, 2)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControl.Size = New System.Drawing.Size(230, 20)
            Me.searchControl.StyleController = Me.moduleLayout
            Me.searchControl.TabIndex = 2
            Me.gridControl.DataSource = Me.bindingSource
            Me.gridControl.Location = New System.Drawing.Point(10, 55)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(230, 265)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.gridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2})
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPhoto, Me.colFullName, Me.colTitle})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsFind.AllowFindPanel = False
            Me.gridView.OptionsView.ColumnAutoWidth = True
            Me.gridView.OptionsView.ShowBands = False
            Me.gridView.OptionsView.ShowColumnHeaders = False
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.OptionsView.ShowIndicator = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.RowHeight = 25
            Me.gridBand1.Columns.Add(Me.colPhoto)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.OptionsBand.AllowSize = False
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 50
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowEdit = False
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.RowCount = 2
            Me.colPhoto.Visible = True
            Me.colPhoto.Width = 50
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.Padding = New System.Windows.Forms.Padding(4)
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.repositoryItemPictureEdit1.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
            Me.gridBand2.Columns.Add(Me.colFullName)
            Me.gridBand2.Columns.Add(Me.colTitle)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 218
            Me.colFullName.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.colFullName.AppearanceCell.Options.UseFont = True
            Me.colFullName.FieldName = "FullNameBindable"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.OptionsColumn.AllowEdit = False
            Me.colFullName.OptionsColumn.AllowFocus = False
            Me.colFullName.Visible = True
            Me.colFullName.Width = 218
            Me.colTitle.AppearanceCell.Options.UseTextOptions = True
            Me.colTitle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowEdit = False
            Me.colTitle.OptionsColumn.AllowFocus = False
            Me.colTitle.RowIndex = 1
            Me.colTitle.Visible = True
            Me.colTitle.Width = 218
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.simpleLabelItem1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 8)
            Me.Root.Size = New System.Drawing.Size(250, 330)
            Me.Root.Text = "Root"
            Me.layoutControlItem1.Control = Me.gridControl
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 53)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(234, 269)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.searchControl
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(234, 24)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.CustomizationFormText = "EMPLOYEES"
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 24)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8)
            Me.simpleLabelItem1.Size = New System.Drawing.Size(234, 29)
            Me.simpleLabelItem1.Text = "EMPLOYEES"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(57, 13)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "EmployeesPeek"
            Me.Size = New System.Drawing.Size(250, 330)
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private searchControl As DevExpress.XtraEditors.SearchControl

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private bindingSource As System.Windows.Forms.BindingSource

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private gridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colFullName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    End Class
End Namespace

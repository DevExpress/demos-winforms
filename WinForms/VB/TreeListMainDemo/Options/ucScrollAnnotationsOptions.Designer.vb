Namespace DevExpress.XtraTreeList.Demos.Options

    Partial Class ucScrollAnnotationsOptions

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cpeFocused = New DevExpress.XtraEditors.ColorPickEdit()
            Me.stylesSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.cpeErrors = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpeSearch = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ceFocusedEnabled = New DevExpress.XtraEditors.CheckEdit()
            Me.ceErrorsEnabled = New DevExpress.XtraEditors.CheckEdit()
            Me.ceBookmarksEnabled = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.simpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemForSearch = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemForErrors = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemForFocused = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cpeFocused.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stylesSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cpeErrors.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cpeSearch.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFocusedEnabled.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceErrorsEnabled.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceBookmarksEnabled.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemForSearch), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemForErrors), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemForFocused), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cpeFocused)
            Me.layoutControl1.Controls.Add(Me.cpeErrors)
            Me.layoutControl1.Controls.Add(Me.cpeSearch)
            Me.layoutControl1.Controls.Add(Me.ceFocusedEnabled)
            Me.layoutControl1.Controls.Add(Me.ceErrorsEnabled)
            Me.layoutControl1.Controls.Add(Me.ceBookmarksEnabled)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1284, 203, 595, 684)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(238, 462)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cpeFocused
            ' 
            Me.cpeFocused.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.stylesSource, "FocusColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.cpeFocused.EditValue = System.Drawing.Color.Empty
            Me.cpeFocused.Location = New System.Drawing.Point(8, 177)
            Me.cpeFocused.Name = "cpeFocused"
            Me.cpeFocused.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.cpeFocused.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpeFocused.Size = New System.Drawing.Size(222, 20)
            Me.cpeFocused.StyleController = Me.layoutControl1
            Me.cpeFocused.TabIndex = 8
            ' 
            ' stylesSource
            ' 
            Me.stylesSource.DataSource = GetType(DevExpress.XtraTreeList.Demos.Options.AnnotationsStyle)
            AddHandler Me.stylesSource.ListChanged, New System.ComponentModel.ListChangedEventHandler(AddressOf Me.OnAnnotationsStyleChanged)
            ' 
            ' cpeErrors
            ' 
            Me.cpeErrors.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.stylesSource, "ErrorsColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.cpeErrors.EditValue = System.Drawing.Color.Empty
            Me.cpeErrors.Location = New System.Drawing.Point(8, 109)
            Me.cpeErrors.Name = "cpeErrors"
            Me.cpeErrors.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.cpeErrors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpeErrors.Size = New System.Drawing.Size(222, 20)
            Me.cpeErrors.StyleController = Me.layoutControl1
            Me.cpeErrors.TabIndex = 7
            ' 
            ' cpeSearch
            ' 
            Me.cpeSearch.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.stylesSource, "SearchResultsColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.cpeSearch.EditValue = System.Drawing.Color.Empty
            Me.cpeSearch.Location = New System.Drawing.Point(8, 41)
            Me.cpeSearch.Name = "cpeSearch"
            Me.cpeSearch.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.cpeSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpeSearch.Size = New System.Drawing.Size(222, 20)
            Me.cpeSearch.StyleController = Me.layoutControl1
            Me.cpeSearch.TabIndex = 6
            ' 
            ' ceFocusedEnabled
            ' 
            Me.ceFocusedEnabled.Location = New System.Drawing.Point(8, 156)
            Me.ceFocusedEnabled.Name = "ceFocusedEnabled"
            Me.ceFocusedEnabled.Properties.Caption = "Enabled"
            Me.ceFocusedEnabled.Size = New System.Drawing.Size(222, 19)
            Me.ceFocusedEnabled.StyleController = Me.layoutControl1
            Me.ceFocusedEnabled.TabIndex = 5
            AddHandler Me.ceFocusedEnabled.EditValueChanged, New System.EventHandler(AddressOf Me.OnAnnotationsEnabledChanged)
            ' 
            ' ceErrorsEnabled
            ' 
            Me.ceErrorsEnabled.EditValue = True
            Me.ceErrorsEnabled.Location = New System.Drawing.Point(8, 88)
            Me.ceErrorsEnabled.Name = "ceErrorsEnabled"
            Me.ceErrorsEnabled.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceErrorsEnabled.Properties.Appearance.Options.UseTextOptions = True
            Me.ceErrorsEnabled.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.ceErrorsEnabled.Properties.Caption = "Enabled"
            Me.ceErrorsEnabled.Size = New System.Drawing.Size(222, 19)
            Me.ceErrorsEnabled.StyleController = Me.layoutControl1
            Me.ceErrorsEnabled.TabIndex = 3
            AddHandler Me.ceErrorsEnabled.EditValueChanged, New System.EventHandler(AddressOf Me.OnAnnotationsEnabledChanged)
            ' 
            ' ceBookmarksEnabled
            ' 
            Me.ceBookmarksEnabled.EditValue = True
            Me.ceBookmarksEnabled.Location = New System.Drawing.Point(8, 230)
            Me.ceBookmarksEnabled.Name = "ceBookmarksEnabled"
            Me.ceBookmarksEnabled.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceBookmarksEnabled.Properties.Appearance.Options.UseTextOptions = True
            Me.ceBookmarksEnabled.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.ceBookmarksEnabled.Properties.Caption = "Enabled"
            Me.ceBookmarksEnabled.Size = New System.Drawing.Size(222, 19)
            Me.ceBookmarksEnabled.StyleController = Me.layoutControl1
            Me.ceBookmarksEnabled.TabIndex = 4
            AddHandler Me.ceBookmarksEnabled.EditValueChanged, New System.EventHandler(AddressOf Me.OnAnnotationsEnabledChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(238, 462)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 256)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(238, 206)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.simpleLabelItem1, Me.simpleLabelItem2, Me.simpleLabelItem3, Me.layoutControlItem4, Me.layoutControlItemForSearch, Me.layoutControlItemForErrors, Me.layoutControlItemForFocused})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(238, 204)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Annotations"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceErrorsEnabled
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 62)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(224, 21)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.AllowHtmlStringInCaption = True
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Size = New System.Drawing.Size(224, 15)
            Me.simpleLabelItem1.Text = "<b>Search Results"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(84, 13)
            ' 
            ' simpleLabelItem2
            ' 
            Me.simpleLabelItem2.AllowHotTrack = False
            Me.simpleLabelItem2.AllowHtmlStringInCaption = True
            Me.simpleLabelItem2.Location = New System.Drawing.Point(0, 37)
            Me.simpleLabelItem2.Name = "simpleLabelItem2"
            Me.simpleLabelItem2.Size = New System.Drawing.Size(224, 25)
            Me.simpleLabelItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
            Me.simpleLabelItem2.Text = "<b>Row Errors"
            Me.simpleLabelItem2.TextSize = New System.Drawing.Size(84, 13)
            ' 
            ' simpleLabelItem3
            ' 
            Me.simpleLabelItem3.AllowHotTrack = False
            Me.simpleLabelItem3.AllowHtmlStringInCaption = True
            Me.simpleLabelItem3.Location = New System.Drawing.Point(0, 105)
            Me.simpleLabelItem3.Name = "simpleLabelItem3"
            Me.simpleLabelItem3.Size = New System.Drawing.Size(224, 25)
            Me.simpleLabelItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
            Me.simpleLabelItem3.Text = "<b>Focused Row"
            Me.simpleLabelItem3.TextSize = New System.Drawing.Size(84, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceFocusedEnabled
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 130)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(224, 21)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItemForSearch
            ' 
            Me.layoutControlItemForSearch.Control = Me.cpeSearch
            Me.layoutControlItemForSearch.Location = New System.Drawing.Point(0, 15)
            Me.layoutControlItemForSearch.Name = "layoutControlItemForSearch"
            Me.layoutControlItemForSearch.Size = New System.Drawing.Size(224, 22)
            Me.layoutControlItemForSearch.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemForSearch.TextVisible = False
            ' 
            ' layoutControlItemForErrors
            ' 
            Me.layoutControlItemForErrors.Control = Me.cpeErrors
            Me.layoutControlItemForErrors.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlItemForErrors.Name = "layoutControlItemForErrors"
            Me.layoutControlItemForErrors.Size = New System.Drawing.Size(224, 22)
            Me.layoutControlItemForErrors.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemForErrors.TextVisible = False
            ' 
            ' layoutControlItemForFocused
            ' 
            Me.layoutControlItemForFocused.Control = Me.cpeFocused
            Me.layoutControlItemForFocused.Enabled = False
            Me.layoutControlItemForFocused.Location = New System.Drawing.Point(0, 151)
            Me.layoutControlItemForFocused.Name = "layoutControlItemForFocused"
            Me.layoutControlItemForFocused.Size = New System.Drawing.Size(224, 22)
            Me.layoutControlItemForFocused.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemForFocused.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(238, 52)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Bookmarks"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceBookmarksEnabled
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(224, 21)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' ucScrollAnnotationsOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "ucScrollAnnotationsOptions"
            Me.Size = New System.Drawing.Size(238, 462)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cpeFocused.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stylesSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cpeErrors.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cpeSearch.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFocusedEnabled.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceErrorsEnabled.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceBookmarksEnabled.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemForSearch), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemForErrors), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemForFocused), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private cpeFocused As DevExpress.XtraEditors.ColorPickEdit

        Private cpeErrors As DevExpress.XtraEditors.ColorPickEdit

        Private cpeSearch As DevExpress.XtraEditors.ColorPickEdit

        Private ceFocusedEnabled As DevExpress.XtraEditors.CheckEdit

        Private ceErrorsEnabled As DevExpress.XtraEditors.CheckEdit

        Private ceBookmarksEnabled As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemForSearch As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemForErrors As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemForFocused As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private stylesSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

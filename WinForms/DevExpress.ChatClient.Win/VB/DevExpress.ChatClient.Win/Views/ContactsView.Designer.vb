Namespace DevExpress.ChatClient.Views

    Partial Class ContactsView

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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.tablePanel = New DevExpress.Utils.Layout.TablePanel()
            Me.searchPanel = New DevExpress.XtraEditors.HtmlContentControl()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.contactsTileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.contactMenuPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            Me.contactTooltip = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel.SuspendLayout()
            CType((Me.searchPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.searchPanel.SuspendLayout()
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contactsTileView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contactMenuPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contactTooltip), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tablePanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel.Controls.Add(Me.searchPanel)
            Me.tablePanel.Controls.Add(Me.gridControl)
            Me.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel.Name = "tablePanel"
            Me.tablePanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 49F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel.Size = New System.Drawing.Size(270, 600)
            Me.tablePanel.TabIndex = 1
            Me.tablePanel.SetColumn(Me.searchPanel, 0)
            Me.searchPanel.Controls.Add(Me.searchControl)
            Me.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.searchPanel.Location = New System.Drawing.Point(0, 0)
            Me.searchPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.searchPanel.Name = "searchPanel"
            Me.tablePanel.SetRow(Me.searchPanel, 0)
            Me.searchPanel.Size = New System.Drawing.Size(270, 49)
            Me.searchPanel.TabIndex = 3
            Me.searchControl.Client = Me.gridControl
            Me.searchControl.Location = New System.Drawing.Point(76, 15)
            Me.searchControl.Margin = New System.Windows.Forms.Padding(0)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton()})
            Me.searchControl.Properties.Client = Me.gridControl
            Me.searchControl.Properties.ShowSearchButton = False
            Me.searchControl.Size = New System.Drawing.Size(179, 18)
            Me.searchControl.TabIndex = 0
            Me.tablePanel.SetColumn(Me.gridControl, 0)
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 49)
            Me.gridControl.MainView = Me.contactsTileView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(0)
            Me.gridControl.Name = "gridControl"
            Me.tablePanel.SetRow(Me.gridControl, 1)
            Me.gridControl.Size = New System.Drawing.Size(270, 551)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.contactsTileView})
            Me.contactsTileView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.contactsTileView.GridControl = Me.gridControl
            Me.contactsTileView.Name = "contactsTileView"
            Me.contactsTileView.OptionsList.DrawItemSeparators = DevExpress.XtraGrid.Views.Tile.DrawItemSeparatorsMode.None
            Me.contactsTileView.OptionsTiles.AllowPressAnimation = False
            Me.contactsTileView.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(0)
            Me.contactsTileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.contactsTileView.OptionsTiles.IndentBetweenGroups = 0
            Me.contactsTileView.OptionsTiles.IndentBetweenItems = 0
            Me.contactsTileView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0)
            Me.contactsTileView.OptionsTiles.ItemSize = New System.Drawing.Size(248, 72)
            Me.contactsTileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.contactsTileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.contactsTileView.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.contactsTileView.OptionsTiles.RowCount = 0
            AddHandler Me.contactsTileView.ItemCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(AddressOf Me.OnContactItemTemplateCustomize)
            AddHandler Me.contactsTileView.CustomItemTemplate, New DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(AddressOf Me.OnContactItemTemplate)
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.ContactsViewModel)
            Me.contactMenuPopup.ContainerControl = Me
            Me.contactMenuPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactMenuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactTooltip.AutoHidingDelay = 1500
            Me.contactTooltip.ContainerControl = Me
            Me.contactTooltip.HideAutomatically = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactTooltip.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactTooltip.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactTooltip.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.ContactViewModel)
            AddHandler Me.contactTooltip.ViewModelSet, New DevExpress.Utils.MVVM.ViewModelSetEventHandler(AddressOf Me.OnContactTooltipViewModelSet)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.tablePanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ContactsView"
            Me.Size = New System.Drawing.Size(270, 600)
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel.ResumeLayout(False)
            CType((Me.searchPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.searchPanel.ResumeLayout(False)
            CType((Me.searchControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contactsTileView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contactMenuPopup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contactTooltip), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel As DevExpress.Utils.Layout.TablePanel

        Private searchPanel As DevExpress.XtraEditors.HtmlContentControl

        Private searchControl As DevExpress.XtraEditors.SearchControl

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private contactsTileView As DevExpress.XtraGrid.Views.Tile.TileView

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private contactMenuPopup As DevExpress.XtraEditors.HtmlContentPopup

        Private contactTooltip As DevExpress.XtraEditors.HtmlContentPopup
    End Class
End Namespace

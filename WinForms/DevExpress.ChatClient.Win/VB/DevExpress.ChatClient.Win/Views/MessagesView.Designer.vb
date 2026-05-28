Namespace DevExpress.ChatClient.Views

    Partial Class MessagesView

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ChatClient.Views.MessagesView))
            Me.tablePanel = New DevExpress.Utils.Layout.TablePanel()
            Me.typingBox = New DevExpress.XtraEditors.HtmlContentControl()
            Me.messageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.toolbarPanel = New DevExpress.XtraEditors.HtmlContentControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.messagesItemsView = New DevExpress.XtraGrid.Views.Items.ItemsView()
            Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAvatar = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatusText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.messageEdit = New DevExpress.XtraEditors.MemoEdit()
            Me.messageMenuPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel.SuspendLayout()
            CType((Me.typingBox), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.typingBox.SuspendLayout()
            CType((Me.messageBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.messagesItemsView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.messageEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.messageMenuPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tablePanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel.Controls.Add(Me.typingBox)
            Me.tablePanel.Controls.Add(Me.toolbarPanel)
            Me.tablePanel.Controls.Add(Me.gridControl)
            Me.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel.Name = "tablePanel"
            Me.tablePanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 49F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.tablePanel.Size = New System.Drawing.Size(430, 600)
            Me.tablePanel.TabIndex = 1
            Me.tablePanel.SetColumn(Me.typingBox, 0)
            Me.typingBox.Controls.Add(Me.messageEdit)
            Me.typingBox.AutoScroll = False
            Me.typingBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.typingBox.Location = New System.Drawing.Point(0, 540)
            Me.typingBox.Margin = New System.Windows.Forms.Padding(0)
            Me.typingBox.Name = "typingBox"
            Me.tablePanel.SetRow(Me.typingBox, 2)
            Me.typingBox.Size = New System.Drawing.Size(430, 60)
            Me.typingBox.TabIndex = 4
            Me.messageBindingSource.DataSource = GetType(DevExpress.ChatClient.ViewModels.MessagesViewModel)
            Me.messageMenuPopup.ContainerControl = Me
            Me.messageMenuPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.messageMenuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.tablePanel.SetColumn(Me.toolbarPanel, 0)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.tablePanel.SetRow(Me.toolbarPanel, 0)
            Me.toolbarPanel.Size = New System.Drawing.Size(430, 49)
            Me.toolbarPanel.TabIndex = 3
            Me.tablePanel.SetColumn(Me.gridControl, 0)
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 48)
            Me.gridControl.MainView = Me.messagesItemsView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(0)
            Me.gridControl.Name = "gridControl"
            Me.tablePanel.SetRow(Me.gridControl, 1)
            Me.gridControl.Size = New System.Drawing.Size(430, 493)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.messagesItemsView})
            Me.messagesItemsView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.messagesItemsView.OptionsSelection.AllowContentSelection = DevExpress.Utils.DefaultBoolean.[True]
            Me.messagesItemsView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserName, Me.colAvatar, Me.colText, Me.colStatusText})
            Me.messagesItemsView.GridControl = Me.gridControl
            Me.messagesItemsView.Name = "messagesItemsView"
            AddHandler Me.messagesItemsView.QueryItemTemplate, New DevExpress.XtraGrid.Views.Items.QueryItemTemplateEventHandler(AddressOf Me.OnQueryItemTemplate)
            AddHandler Me.messagesItemsView.CustomizeItem, New DevExpress.XtraGrid.Views.Items.CustomizeItemEventHandler(AddressOf Me.OnCustomizeItem)
            Me.colUserName.FieldName = "Owner.UserName"
            Me.colUserName.Name = "colUserName"
            Me.colUserName.Visible = True
            Me.colUserName.VisibleIndex = 0
            Me.colAvatar.FieldName = "Owner.Avatar"
            Me.colAvatar.Name = "colAvatar"
            Me.colAvatar.Visible = True
            Me.colAvatar.VisibleIndex = 1
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 2
            Me.colStatusText.FieldName = "StatusText"
            Me.colStatusText.Name = "colStatusText"
            Me.colStatusText.Visible = True
            Me.colStatusText.VisibleIndex = 2
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.MessagesViewModel)
            Me.messageEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.messageBindingSource, "MessageText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.messageEdit.Location = New System.Drawing.Point(149, 3)
            Me.messageEdit.Name = "messageEdit"
            Me.messageEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.messageEdit.Properties.NullValuePrompt = "Type your message here..."
            Me.messageEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.messageEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.messageEdit.Size = New System.Drawing.Size(100, 96)
            Me.messageEdit.TabIndex = 0
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.tablePanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "MessagesView"
            Me.Size = New System.Drawing.Size(430, 600)
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel.ResumeLayout(False)
            CType((Me.typingBox), System.ComponentModel.ISupportInitialize).EndInit()
            Me.typingBox.ResumeLayout(False)
            CType((Me.messageBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.messagesItemsView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.messageEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.messageMenuPopup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel As DevExpress.Utils.Layout.TablePanel

        Private toolbarPanel As DevExpress.XtraEditors.HtmlContentControl

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private messagesItemsView As DevExpress.XtraGrid.Views.Items.ItemsView

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private colUserName As DevExpress.XtraGrid.Columns.GridColumn

        Private colAvatar As DevExpress.XtraGrid.Columns.GridColumn

        Private colText As DevExpress.XtraGrid.Columns.GridColumn

        Private colStatusText As DevExpress.XtraGrid.Columns.GridColumn

        Private typingBox As DevExpress.XtraEditors.HtmlContentControl

        Private messageBindingSource As System.Windows.Forms.BindingSource

        Private messageEdit As DevExpress.XtraEditors.MemoEdit

        Private messageMenuPopup As DevExpress.XtraEditors.HtmlContentPopup
    End Class
End Namespace

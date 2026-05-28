Namespace DevExpress.XtraGrid.Demos

    Partial Class ExpressionConditionsEditor

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ExpressionConditionsEditor))
            Me.FormatItemList = New DevExpress.XtraEditors.ListBoxControl()
            Me.tablePanel = New DevExpress.Utils.Layout.TablePanel()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
            Me.repositoryItemColorPickEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit()
            CType((Me.FormatItemList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel.SuspendLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemColorPickEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' FormatItemList
            ' 
            Me.FormatItemList.Appearance.Options.UseTextOptions = True
            Me.FormatItemList.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.FormatItemList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.tablePanel.SetColumn(Me.FormatItemList, 0)
            Me.tablePanel.SetColumnSpan(Me.FormatItemList, 2)
            resources.ApplyResources(Me.FormatItemList, "FormatItemList")
            Me.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
            Me.FormatItemList.Name = "FormatItemList"
            Me.tablePanel.SetRow(Me.FormatItemList, 1)
            Me.FormatItemList.ShowFocusRect = False
            AddHandler Me.FormatItemList.SelectedIndexChanged, New System.EventHandler(AddressOf Me.FormatItemList_SelectedIndexChanged)
            AddHandler Me.FormatItemList.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.FormatItemList_MouseDoubleClick)
            ' 
            ' tablePanel
            ' 
            Me.tablePanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel.Controls.Add(Me.labelControl4)
            Me.tablePanel.Controls.Add(Me.checkEdit1)
            Me.tablePanel.Controls.Add(Me.btnAdd)
            Me.tablePanel.Controls.Add(Me.labelControl1)
            Me.tablePanel.Controls.Add(Me.FormatItemList)
            Me.tablePanel.Controls.Add(Me.labelControl2)
            Me.tablePanel.Controls.Add(Me.propertyGrid1)
            Me.tablePanel.Controls.Add(Me.imageComboBoxEdit1)
            Me.tablePanel.Controls.Add(Me.labelControl3)
            Me.tablePanel.Controls.Add(Me.btnDelete)
            Me.tablePanel.Controls.Add(Me.btnEdit)
            resources.ApplyResources(Me.tablePanel, "tablePanel")
            Me.tablePanel.Name = "tablePanel"
            Me.tablePanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            ' 
            ' labelControl4
            ' 
            Me.tablePanel.SetColumn(Me.labelControl4, 0)
            resources.ApplyResources(Me.labelControl4, "labelControl4")
            Me.labelControl4.Name = "labelControl4"
            Me.tablePanel.SetRow(Me.labelControl4, 8)
            ' 
            ' checkEdit1
            ' 
            Me.tablePanel.SetColumn(Me.checkEdit1, 1)
            resources.ApplyResources(Me.checkEdit1, "checkEdit1")
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption")
            Me.tablePanel.SetRow(Me.checkEdit1, 8)
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' btnAdd
            ' 
            Me.tablePanel.SetColumn(Me.btnAdd, 0)
            Me.tablePanel.SetColumnSpan(Me.btnAdd, 2)
            resources.ApplyResources(Me.btnAdd, "btnAdd")
            Me.btnAdd.Name = "btnAdd"
            Me.tablePanel.SetRow(Me.btnAdd, 2)
            AddHandler Me.btnAdd.Click, New System.EventHandler(AddressOf Me.btnAdd_Click)
            ' 
            ' labelControl1
            ' 
            Me.tablePanel.SetColumn(Me.labelControl1, 0)
            Me.tablePanel.SetColumnSpan(Me.labelControl1, 2)
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            Me.tablePanel.SetRow(Me.labelControl1, 0)
            ' 
            ' labelControl2
            ' 
            Me.tablePanel.SetColumn(Me.labelControl2, 0)
            Me.tablePanel.SetColumnSpan(Me.labelControl2, 2)
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.Name = "labelControl2"
            Me.tablePanel.SetRow(Me.labelControl2, 5)
            ' 
            ' propertyGrid1
            ' 
            Me.tablePanel.SetColumn(Me.propertyGrid1, 0)
            Me.tablePanel.SetColumnSpan(Me.propertyGrid1, 2)
            Me.propertyGrid1.Cursor = System.Windows.Forms.Cursors.[Default]
            resources.ApplyResources(Me.propertyGrid1, "propertyGrid1")
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.OptionsBehavior.ResizeRowHeaders = False
            Me.propertyGrid1.OptionsBehavior.ResizeRowValues = False
            Me.propertyGrid1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.tablePanel.SetRow(Me.propertyGrid1, 6)
            Me.propertyGrid1.ScrollsStyle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            AddHandler Me.propertyGrid1.CustomRecordCellEdit, New DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(AddressOf Me.propertyGrid1_CustomRecordCellEdit)
            ' 
            ' imageComboBoxEdit1
            ' 
            resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
            Me.tablePanel.SetColumn(Me.imageComboBoxEdit1, 1)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("imageComboBoxEdit1.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.tablePanel.SetRow(Me.imageComboBoxEdit1, 7)
            AddHandler Me.imageComboBoxEdit1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.imageComboBoxEdit1_SelectedIndexChanged)
            ' 
            ' labelControl3
            ' 
            Me.tablePanel.SetColumn(Me.labelControl3, 0)
            resources.ApplyResources(Me.labelControl3, "labelControl3")
            Me.labelControl3.Name = "labelControl3"
            Me.tablePanel.SetRow(Me.labelControl3, 7)
            ' 
            ' btnDelete
            ' 
            Me.tablePanel.SetColumn(Me.btnDelete, 0)
            Me.tablePanel.SetColumnSpan(Me.btnDelete, 2)
            resources.ApplyResources(Me.btnDelete, "btnDelete")
            Me.btnDelete.Name = "btnDelete"
            Me.tablePanel.SetRow(Me.btnDelete, 3)
            AddHandler Me.btnDelete.Click, New System.EventHandler(AddressOf Me.btnDelete_Click)
            ' 
            ' btnEdit
            ' 
            Me.tablePanel.SetColumn(Me.btnEdit, 0)
            Me.tablePanel.SetColumnSpan(Me.btnEdit, 2)
            resources.ApplyResources(Me.btnEdit, "btnEdit")
            Me.btnEdit.Name = "btnEdit"
            Me.tablePanel.SetRow(Me.btnEdit, 4)
            AddHandler Me.btnEdit.Click, New System.EventHandler(AddressOf Me.btnEdit_Click)
            ' 
            ' repositoryItemColorPickEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemColorPickEdit1, "repositoryItemColorPickEdit1")
            Me.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black
            Me.repositoryItemColorPickEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemColorPickEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1"
            ' 
            ' ExpressionConditionsEditor
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel)
            Me.Name = "ExpressionConditionsEditor"
            CType((Me.FormatItemList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel.ResumeLayout(False)
            Me.tablePanel.PerformLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.propertyGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemColorPickEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private FormatItemList As DevExpress.XtraEditors.ListBoxControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private propertyGrid1 As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private repositoryItemColorPickEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit

        Private tablePanel As DevExpress.Utils.Layout.TablePanel

        Private btnAdd As DevExpress.XtraEditors.SimpleButton

        Private btnDelete As DevExpress.XtraEditors.SimpleButton

        Private btnEdit As DevExpress.XtraEditors.SimpleButton

        Private labelControl4 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

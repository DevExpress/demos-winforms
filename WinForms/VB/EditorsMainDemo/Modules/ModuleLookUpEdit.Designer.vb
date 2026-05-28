Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleLookUpEdit

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
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
            Me.notePanel1 = New DevExpress.DXperience.Demos.DescriptionLabel()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.lookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
            Me.notePanel2 = New DevExpress.DXperience.Demos.DescriptionLabel()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.lookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
            Me.notePanel3 = New DevExpress.DXperience.Demos.DescriptionLabel()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.lookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit()
            Me.notePanel4 = New DevExpress.DXperience.Demos.DescriptionLabel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.properties = New DevExpress.XtraEditors.Demos.LookUpProperties()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.lookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.lookUpEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType((Me.lookUpEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType((Me.lookUpEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            Me.tabNavigationPage3.SuspendLayout()
            Me.tabNavigationPage4.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' notePanel1
            ' 
            Me.notePanel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.notePanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.notePanel1.Location = New System.Drawing.Point(17, 493)
            Me.notePanel1.Name = "notePanel1"
            Me.notePanel1.Size = New System.Drawing.Size(467, 0)
            Me.notePanel1.TabIndex = 4
            Me.notePanel1.Visible = False
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl3.Appearance.Options.UseBackColor = True
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(17, 493)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(467, 12)
            Me.panelControl3.TabIndex = 6
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.lookUpEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(17, 17)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(17)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
            Me.panelControl1.Size = New System.Drawing.Size(467, 204)
            Me.panelControl1.TabIndex = 1
            Me.panelControl1.Text = "Sample"
            ' 
            ' lookUpEdit1
            ' 
            Me.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.lookUpEdit1.Location = New System.Drawing.Point(22, 83)
            Me.lookUpEdit1.Name = "lookUpEdit1"
            Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuantityPerUnit", "Quantity Per Unit", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price", 30, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discontinued", "Discontinued", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
            Me.lookUpEdit1.Properties.DisplayMember = "ProductName"
            Me.lookUpEdit1.Properties.DropDownRows = 15
            Me.lookUpEdit1.Properties.PopupWidth = 500
            Me.lookUpEdit1.Properties.ValueMember = "ProductID"
            Me.lookUpEdit1.Size = New System.Drawing.Size(423, 20)
            Me.lookUpEdit1.TabIndex = 0
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dataNavigator1.Location = New System.Drawing.Point(17, 505)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(467, 21)
            Me.dataNavigator1.TabIndex = 5
            Me.dataNavigator1.Text = "dataNavigator1"
            Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.lookUpEdit2)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupControl1.Location = New System.Drawing.Point(17, 17)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
            Me.groupControl1.Size = New System.Drawing.Size(467, 204)
            Me.groupControl1.TabIndex = 6
            Me.groupControl1.Text = "Sample"
            ' 
            ' lookUpEdit2
            ' 
            Me.lookUpEdit2.Dock = System.Windows.Forms.DockStyle.Top
            Me.lookUpEdit2.Location = New System.Drawing.Point(22, 83)
            Me.lookUpEdit2.Name = "lookUpEdit2"
            Me.lookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaseDate", "Purchase Date", 30, DevExpress.Utils.FormatType.DateTime, "D", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentAmount", "Payment Amount", 20, DevExpress.Utils.FormatType.Numeric, "c", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
            Me.lookUpEdit2.Properties.DisplayMember = "Name"
            Me.lookUpEdit2.Properties.DropDownRows = 5
            Me.lookUpEdit2.Properties.PopupWidth = 400
            Me.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Me.lookUpEdit2.Properties.ValueMember = "ID"
            Me.lookUpEdit2.Size = New System.Drawing.Size(423, 20)
            Me.lookUpEdit2.TabIndex = 0
            ' 
            ' notePanel2
            ' 
            Me.notePanel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.notePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.notePanel2.Location = New System.Drawing.Point(17, 526)
            Me.notePanel2.Name = "notePanel2"
            Me.notePanel2.Size = New System.Drawing.Size(467, 0)
            Me.notePanel2.TabIndex = 5
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.Controls.Add(Me.lookUpEdit3)
            Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupControl2.Location = New System.Drawing.Point(17, 17)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
            Me.groupControl2.Size = New System.Drawing.Size(467, 204)
            Me.groupControl2.TabIndex = 6
            Me.groupControl2.Text = "Sample"
            ' 
            ' lookUpEdit3
            ' 
            Me.lookUpEdit3.Dock = System.Windows.Forms.DockStyle.Top
            Me.lookUpEdit3.Location = New System.Drawing.Point(22, 83)
            Me.lookUpEdit3.Name = "lookUpEdit3"
            Me.lookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit3.Properties.DropDownRows = 20
            Me.lookUpEdit3.Properties.PopupWidth = 200
            Me.lookUpEdit3.Size = New System.Drawing.Size(423, 20)
            Me.lookUpEdit3.TabIndex = 0
            ' 
            ' notePanel3
            ' 
            Me.notePanel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.notePanel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.notePanel3.Location = New System.Drawing.Point(17, 526)
            Me.notePanel3.Name = "notePanel3"
            Me.notePanel3.Size = New System.Drawing.Size(467, 0)
            Me.notePanel3.TabIndex = 5
            ' 
            ' groupControl3
            ' 
            Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl3.Appearance.Options.UseBackColor = True
            Me.groupControl3.Controls.Add(Me.lookUpEdit4)
            Me.groupControl3.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupControl3.Location = New System.Drawing.Point(17, 17)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
            Me.groupControl3.Size = New System.Drawing.Size(467, 204)
            Me.groupControl3.TabIndex = 7
            Me.groupControl3.Text = "Sample"
            ' 
            ' lookUpEdit4
            ' 
            Me.lookUpEdit4.Dock = System.Windows.Forms.DockStyle.Top
            Me.lookUpEdit4.Location = New System.Drawing.Point(22, 83)
            Me.lookUpEdit4.Name = "lookUpEdit4"
            Me.lookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NotInList", "# (Not In List Column)", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country")})
            Me.lookUpEdit4.Properties.DisplayMember = "Country"
            Me.lookUpEdit4.Properties.DropDownRows = 20
            Me.lookUpEdit4.Properties.PopupWidth = 300
            Me.lookUpEdit4.Properties.ValueMember = "Country"
            Me.lookUpEdit4.Size = New System.Drawing.Size(423, 20)
            Me.lookUpEdit4.TabIndex = 0
            ' 
            ' notePanel4
            ' 
            Me.notePanel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.notePanel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.notePanel4.Location = New System.Drawing.Point(17, 526)
            Me.notePanel4.Name = "notePanel4"
            Me.notePanel4.Size = New System.Drawing.Size(467, 0)
            Me.notePanel4.TabIndex = 5
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage3)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage4)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(0, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1, Me.tabNavigationPage2, Me.tabNavigationPage3, Me.tabNavigationPage4})
            Me.tabPane1.RegularSize = New System.Drawing.Size(501, 576)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(501, 576)
            Me.tabPane1.TabIndex = 1
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Data Binding"
            Me.tabNavigationPage1.Controls.Add(Me.notePanel1)
            Me.tabNavigationPage1.Controls.Add(Me.panelControl3)
            Me.tabNavigationPage1.Controls.Add(Me.panelControl1)
            Me.tabNavigationPage1.Controls.Add(Me.dataNavigator1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Padding = New System.Windows.Forms.Padding(17)
            Me.tabNavigationPage1.Size = New System.Drawing.Size(501, 543)
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "Simple Binding"
            Me.tabNavigationPage2.Controls.Add(Me.groupControl1)
            Me.tabNavigationPage2.Controls.Add(Me.notePanel2)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Padding = New System.Windows.Forms.Padding(17)
            Me.tabNavigationPage2.Size = New System.Drawing.Size(501, 543)
            ' 
            ' tabNavigationPage3
            ' 
            Me.tabNavigationPage3.Caption = "Array Binding"
            Me.tabNavigationPage3.Controls.Add(Me.groupControl2)
            Me.tabNavigationPage3.Controls.Add(Me.notePanel3)
            Me.tabNavigationPage3.Name = "tabNavigationPage3"
            Me.tabNavigationPage3.Padding = New System.Windows.Forms.Padding(17)
            Me.tabNavigationPage3.Size = New System.Drawing.Size(501, 543)
            ' 
            ' tabNavigationPage4
            ' 
            Me.tabNavigationPage4.Caption = "Not In List"
            Me.tabNavigationPage4.Controls.Add(Me.groupControl3)
            Me.tabNavigationPage4.Controls.Add(Me.notePanel4)
            Me.tabNavigationPage4.Name = "tabNavigationPage4"
            Me.tabNavigationPage4.Padding = New System.Windows.Forms.Padding(17)
            Me.tabNavigationPage4.Size = New System.Drawing.Size(501, 543)
            ' 
            ' properties
            ' 
            Me.properties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.properties.Location = New System.Drawing.Point(1, 0)
            Me.properties.Name = "properties"
            Me.properties.Size = New System.Drawing.Size(314, 576)
            Me.properties.TabIndex = 0
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.properties)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(501, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(315, 576)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' ModuleLookUpEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ModuleLookUpEdit"
            Me.Size = New System.Drawing.Size(816, 576)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleLookUpEdit_Load)
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.lookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.lookUpEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType((Me.lookUpEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            CType((Me.lookUpEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            Me.tabNavigationPage3.ResumeLayout(False)
            Me.tabNavigationPage4.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.GroupControl

        Private notePanel1 As DevExpress.DXperience.Demos.DescriptionLabel

        Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit

        Private notePanel2 As DevExpress.DXperience.Demos.DescriptionLabel

        Private notePanel3 As DevExpress.DXperience.Demos.DescriptionLabel

        Private notePanel4 As DevExpress.DXperience.Demos.DescriptionLabel

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private lookUpEdit2 As DevExpress.XtraEditors.LookUpEdit

        Private groupControl2 As DevExpress.XtraEditors.GroupControl

        Private lookUpEdit3 As DevExpress.XtraEditors.LookUpEdit

        Private groupControl3 As DevExpress.XtraEditors.GroupControl

        Private lookUpEdit4 As DevExpress.XtraEditors.LookUpEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private properties As DevExpress.XtraEditors.Demos.LookUpProperties

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace

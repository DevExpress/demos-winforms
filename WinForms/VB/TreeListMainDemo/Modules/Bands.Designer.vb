Namespace DevExpress.XtraTreeList.Demos

    Partial Class Bands

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
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn9 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand4 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand5 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.treeListColumn8 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.ucBandOptions1 = New DevExpress.XtraTreeList.Demos.Options.ucBandOptions()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane.SuspendLayout()
            Me.optionsPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand1, Me.treeListBand2, Me.treeListBand5})
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn9, Me.treeListColumn6, Me.treeListColumn7, Me.treeListColumn8})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsBehavior.AutoNodeHeight = False
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsCustomization.AllowChangeBandParent = True
            Me.treeList1.OptionsCustomization.AllowChangeColumnParent = True
            Me.treeList1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.treeList1.OptionsCustomization.CustomizationFormSnapMode = CType(((DevExpress.Utils.Controls.SnapMode.OwnerControl Or DevExpress.Utils.Controls.SnapMode.OwnerForm)), DevExpress.Utils.Controls.SnapMode)
            Me.treeList1.OptionsView.AllowBandColumnsMultiRow = True
            Me.treeList1.OptionsView.AllowHtmlDrawHeaders = True
            Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
            Me.treeList1.OptionsView.EnableAppearanceOddRow = True
            Me.treeList1.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.Size = New System.Drawing.Size(546, 432)
            Me.treeList1.TabIndex = 16
            ' 
            ' treeListBand1
            ' 
            Me.treeListBand1.Caption = "<b>Main</b>"
            Me.treeListBand1.Columns.Add(Me.treeListColumn1)
            Me.treeListBand1.Columns.Add(Me.treeListColumn2)
            Me.treeListBand1.Name = "treeListBand1"
            Me.treeListBand1.Width = 178
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 90
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "Type of object"
            Me.treeListColumn2.FieldName = "TypeOfObject"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.RowIndex = 1
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            Me.treeListColumn2.Width = 88
            ' 
            ' treeListBand2
            ' 
            Me.treeListBand2.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand3, Me.treeListBand4})
            Me.treeListBand2.Caption = "<b>Details </b>"
            Me.treeListBand2.Name = "treeListBand2"
            Me.treeListBand2.Width = 536
            ' 
            ' treeListBand3
            ' 
            Me.treeListBand3.Caption = "Absolute Values"
            Me.treeListBand3.Columns.Add(Me.treeListColumn3)
            Me.treeListBand3.Columns.Add(Me.treeListColumn4)
            Me.treeListBand3.Columns.Add(Me.treeListColumn9)
            Me.treeListBand3.Name = "treeListBand3"
            Me.treeListBand3.Width = 256
            ' 
            ' treeListColumn3
            ' 
            Me.treeListColumn3.Caption = "Mean radius"
            Me.treeListColumn3.FieldName = "MeanRadiusInKM"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 107
            ' 
            ' treeListColumn4
            ' 
            Me.treeListColumn4.Caption = "Volume "
            Me.treeListColumn4.FieldName = "Volume10pow9KM3"
            Me.treeListColumn4.Format.FormatString = "f"
            Me.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 88
            ' 
            ' treeListColumn9
            ' 
            Me.treeListColumn9.Caption = "Mass"
            Me.treeListColumn9.FieldName = "Mass10pow21kg"
            Me.treeListColumn9.Name = "treeListColumn9"
            Me.treeListColumn9.RowIndex = 1
            Me.treeListColumn9.Visible = True
            Me.treeListColumn9.VisibleIndex = 4
            Me.treeListColumn9.Width = 61
            ' 
            ' treeListBand4
            ' 
            Me.treeListBand4.Caption = "Related To Earth Values"
            Me.treeListBand4.Columns.Add(Me.treeListColumn5)
            Me.treeListBand4.Columns.Add(Me.treeListColumn6)
            Me.treeListBand4.Columns.Add(Me.treeListColumn7)
            Me.treeListBand4.Name = "treeListBand4"
            Me.treeListBand4.Width = 280
            ' 
            ' treeListColumn5
            ' 
            Me.treeListColumn5.Caption = "Mean radius"
            Me.treeListColumn5.FieldName = "MeanRadiusByEarth"
            Me.treeListColumn5.Format.FormatString = "f"
            Me.treeListColumn5.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 5
            Me.treeListColumn5.Width = 102
            ' 
            ' treeListColumn6
            ' 
            Me.treeListColumn6.Caption = "Volume "
            Me.treeListColumn6.FieldName = "VolumeRByEarth"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 6
            Me.treeListColumn6.Width = 104
            ' 
            ' treeListColumn7
            ' 
            Me.treeListColumn7.Caption = "Mass"
            Me.treeListColumn7.FieldName = "MassByEarth"
            Me.treeListColumn7.Name = "treeListColumn7"
            Me.treeListColumn7.RowIndex = 1
            Me.treeListColumn7.Visible = True
            Me.treeListColumn7.VisibleIndex = 7
            Me.treeListColumn7.Width = 74
            ' 
            ' treeListBand5
            ' 
            Me.treeListBand5.Caption = "<b>Picture</b>"
            Me.treeListBand5.Columns.Add(Me.treeListColumn8)
            Me.treeListBand5.MinWidth = 68
            Me.treeListBand5.Name = "treeListBand5"
            Me.treeListBand5.OptionsBand.FixedWidth = True
            Me.treeListBand5.Width = 68
            ' 
            ' treeListColumn8
            ' 
            Me.treeListColumn8.Caption = "Icon"
            Me.treeListColumn8.FieldName = "ImageData"
            Me.treeListColumn8.Name = "treeListColumn8"
            Me.treeListColumn8.OptionsColumn.FixedWidth = True
            Me.treeListColumn8.Visible = True
            Me.treeListColumn8.VisibleIndex = 8
            Me.treeListColumn8.Width = 68
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(546, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(237, 432)
            Me.sidePanel1.TabIndex = 17
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' navigationPane
            ' 
            Me.navigationPane.Controls.Add(Me.optionsPage)
            Me.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane.Name = "navigationPane"
            Me.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.optionsPage})
            Me.navigationPane.RegularSize = New System.Drawing.Size(236, 432)
            Me.navigationPane.SelectedPage = Me.optionsPage
            Me.navigationPane.Size = New System.Drawing.Size(236, 432)
            Me.navigationPane.TabIndex = 11
            Me.navigationPane.Text = "navigationPane"
            ' 
            ' optionsPage
            ' 
            Me.optionsPage.Caption = "Options"
            Me.optionsPage.Controls.Add(Me.ucBandOptions1)
            Me.optionsPage.Name = "optionsPage"
            Me.optionsPage.Size = New System.Drawing.Size(236, 399)
            ' 
            ' ucBandOptions1
            ' 
            Me.ucBandOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucBandOptions1.Location = New System.Drawing.Point(0, 0)
            Me.ucBandOptions1.Name = "ucBandOptions1"
            Me.ucBandOptions1.Size = New System.Drawing.Size(236, 399)
            Me.ucBandOptions1.TabIndex = 0
            ' 
            ' Bands
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "Bands"
            Me.Size = New System.Drawing.Size(783, 432)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane.ResumeLayout(False)
            Me.optionsPage.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn8 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn9 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand4 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand5 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private ucBandOptions1 As DevExpress.XtraTreeList.Demos.Options.ucBandOptions
    End Class
End Namespace

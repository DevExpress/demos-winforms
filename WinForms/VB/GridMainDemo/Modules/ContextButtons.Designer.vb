Namespace DevExpress.XtraGrid.Demos

    Partial Class ContextButtons

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
            Dim contextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ContextButtons))
            Dim contextButton3 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton4 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim checkContextButton1 As DevExpress.Utils.CheckContextButton = New DevExpress.Utils.CheckContextButton()
            Dim ratingContextButton1 As DevExpress.Utils.RatingContextButton = New DevExpress.Utils.RatingContextButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.zoomTrackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.zoomTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.winExplorerView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(461, 458)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            ' 
            ' winExplorerView1
            ' 
            Me.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView1.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            Me.winExplorerView1.ContextButtonOptions.Indent = 3
            Me.winExplorerView1.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center
            contextButton1.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            contextButton1.AppearanceHover.Options.UseFont = True
            contextButton1.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            contextButton1.AppearanceNormal.Options.UseFont = True
            contextButton1.Id = New System.Guid("62095aba-f30f-4377-b233-14b1eab8c0db")
            contextButton1.Name = "itemText"
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton2.AppearanceHover.Options.UseForeColor = True
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton2.AppearanceNormal.Options.UseForeColor = True
            contextButton2.Id = New System.Guid("aff114b4-1a64-4e9b-ae04-098d9ddc4ec4")
            contextButton2.ImageOptionsCollection.ItemNormal.Image = CType((resources.GetObject("resource.Image")), System.Drawing.Image)
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.close
            contextButton2.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
            contextButton2.Name = "itemRemove"
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton3.AppearanceHover.Options.UseForeColor = True
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton3.AppearanceNormal.Options.UseForeColor = True
            contextButton3.Id = New System.Guid("8919a814-c5ac-42a5-96fe-71a6f31d1f7e")
            contextButton3.ImageOptionsCollection.ItemNormal.Image = CType((resources.GetObject("resource.Image1")), System.Drawing.Image)
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.download
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
            contextButton3.Name = "itemDownload"
            contextButton4.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton4.AppearanceHover.Options.UseForeColor = True
            contextButton4.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton4.AppearanceNormal.Options.UseForeColor = True
            contextButton4.Id = New System.Guid("52064e3b-1c98-4a1f-9296-07465624a0d5")
            contextButton4.ImageOptionsCollection.ItemNormal.Image = CType((resources.GetObject("resource.Image2")), System.Drawing.Image)
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.about
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
            contextButton4.Name = "itemInfo"
            checkContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
            checkContextButton1.Id = New System.Guid("d5e27663-722f-40c8-8363-cc4eded0e782")
            checkContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.check
            checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.uncheck
            checkContextButton1.Name = "itemCheck"
            ratingContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
            ratingContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center
            ratingContextButton1.Id = New System.Guid("93da3997-ef55-4c87-8eef-d2881dc0e6dd")
            ratingContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.starCheck
            ratingContextButton1.ImageOptionsCollection.ItemHovered.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.starCheck
            ratingContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraGrid.Demos.Properties.Resources.starUncheck
            ratingContextButton1.Name = "itemRating"
            ratingContextButton1.Rating = New Decimal(New Integer() {0, 0, 0, 0})
            Me.winExplorerView1.ContextButtons.Add(contextButton1)
            Me.winExplorerView1.ContextButtons.Add(contextButton2)
            Me.winExplorerView1.ContextButtons.Add(contextButton3)
            Me.winExplorerView1.ContextButtons.Add(contextButton4)
            Me.winExplorerView1.ContextButtons.Add(checkContextButton1)
            Me.winExplorerView1.ContextButtons.Add(ratingContextButton1)
            Me.winExplorerView1.GridControl = Me.gridControl1
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge
            AddHandler Me.winExplorerView1.ContextButtonCustomize, New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventHandler(AddressOf Me.winExplorerView1_ContextButtonCustomize)
            AddHandler Me.winExplorerView1.ContextButtonClick, New DevExpress.Utils.ContextItemClickEventHandler(AddressOf Me.winExplorerView1_ContextButtonClick)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(461, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 458)
            Me.sidePanel1.TabIndex = 10
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 458)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(249, 458)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(249, 425)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.zoomTrackBarControl1)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(749, 172, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 425)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' zoomTrackBarControl1
            ' 
            Me.zoomTrackBarControl1.EditValue = 292
            Me.zoomTrackBarControl1.Location = New System.Drawing.Point(12, 208)
            Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
            Me.zoomTrackBarControl1.Properties.Maximum = 392
            Me.zoomTrackBarControl1.Properties.Middle = 292
            Me.zoomTrackBarControl1.Properties.Minimum = 192
            Me.zoomTrackBarControl1.Size = New System.Drawing.Size(225, 16)
            Me.zoomTrackBarControl1.StyleController = Me.layoutControl1
            Me.zoomTrackBarControl1.TabIndex = 6
            Me.zoomTrackBarControl1.Value = 292
            AddHandler Me.zoomTrackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.OnZoomTrackBarEditValueChanged)
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.AutoSizeInLayoutControl = True
            Me.radioGroup1.EditValue = 0
            Me.radioGroup1.Location = New System.Drawing.Point(12, 34)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Opacity Animation"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Out Animation"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Sequence Animation")})
            Me.radioGroup1.Size = New System.Drawing.Size(225, 128)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 4
            AddHandler Me.radioGroup1.EditValueChanged, New System.EventHandler(AddressOf Me.OnAnimationTypeEditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 425)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 233)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 192)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 174)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Animation Type"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.radioGroup1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 132)
            Me.layoutControlItem1.Text = "Animation Type"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 174)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 59)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Thumbnails"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.zoomTrackBarControl1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 17)
            Me.layoutControlItem3.Text = "Thumbnails"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' ContextButtons
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ContextButtons"
            Me.Size = New System.Drawing.Size(711, 458)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.zoomTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.zoomTrackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private winExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace

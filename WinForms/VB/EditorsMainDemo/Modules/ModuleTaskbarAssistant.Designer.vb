Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTaskbarAssistant

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
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel5 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel6 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel7 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel8 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel9 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleTaskbarAssistant))
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.btnRemoveThumbnailButton = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddThumbnailButton = New DevExpress.XtraEditors.SimpleButton()
            Me.trackBarProgressValue = New DevExpress.XtraEditors.TrackBarControl()
            Me.cbProgressMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.imgOverlayIcons = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.imgCollection = New DevExpress.Utils.ImageCollection(Me.components)
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.btnRemoveItemFromTasks = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddItemToTasks = New DevExpress.XtraEditors.SimpleButton()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.btnRemoveCustomCategory = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddCustomCategory = New DevExpress.XtraEditors.SimpleButton()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.trackBarProgressValue), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarProgressValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbProgressMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType((Me.imgOverlayIcons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imgCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType((Me.groupControl5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.btnRemoveThumbnailButton)
            Me.groupControl1.Controls.Add(Me.btnAddThumbnailButton)
            Me.groupControl1.Location = New System.Drawing.Point(12, 12)
            Me.groupControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(325, 79)
            Me.groupControl1.TabIndex = 0
            Me.groupControl1.Text = "Thumbnail Buttons"
            ' 
            ' btnRemoveThumbnailButton
            ' 
            Me.btnRemoveThumbnailButton.Enabled = False
            Me.btnRemoveThumbnailButton.Location = New System.Drawing.Point(163, 35)
            Me.btnRemoveThumbnailButton.Margin = New System.Windows.Forms.Padding(2)
            Me.btnRemoveThumbnailButton.Name = "btnRemoveThumbnailButton"
            Me.btnRemoveThumbnailButton.Size = New System.Drawing.Size(149, 27)
            Me.btnRemoveThumbnailButton.TabIndex = 0
            Me.btnRemoveThumbnailButton.Text = "Remove Thumbnail Button"
            AddHandler Me.btnRemoveThumbnailButton.Click, New System.EventHandler(AddressOf Me.OnRemoveThumbnailButtonClick)
            ' 
            ' btnAddThumbnailButton
            ' 
            Me.btnAddThumbnailButton.Enabled = False
            Me.btnAddThumbnailButton.Location = New System.Drawing.Point(10, 35)
            Me.btnAddThumbnailButton.Margin = New System.Windows.Forms.Padding(2)
            Me.btnAddThumbnailButton.Name = "btnAddThumbnailButton"
            Me.btnAddThumbnailButton.Size = New System.Drawing.Size(149, 27)
            Me.btnAddThumbnailButton.TabIndex = 0
            Me.btnAddThumbnailButton.Text = "Add Thumbnail Button"
            AddHandler Me.btnAddThumbnailButton.Click, New System.EventHandler(AddressOf Me.OnAddThumbnailButtonClick)
            ' 
            ' trackBarProgressValue
            ' 
            Me.trackBarProgressValue.EditValue = Nothing
            Me.trackBarProgressValue.Location = New System.Drawing.Point(168, 23)
            Me.trackBarProgressValue.Margin = New System.Windows.Forms.Padding(2)
            Me.trackBarProgressValue.Name = "trackBarProgressValue"
            Me.trackBarProgressValue.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarProgressValue.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "0"
            trackBarLabel2.Label = "10"
            trackBarLabel2.Value = 10
            trackBarLabel3.Label = "20"
            trackBarLabel3.Value = 20
            trackBarLabel4.Label = "30"
            trackBarLabel4.Value = 30
            trackBarLabel5.Label = "40"
            trackBarLabel5.Value = 40
            trackBarLabel6.Label = "50"
            trackBarLabel6.Value = 50
            trackBarLabel7.Label = "60"
            trackBarLabel7.Value = 60
            trackBarLabel8.Label = "70"
            trackBarLabel8.Value = 70
            trackBarLabel9.Label = "80"
            trackBarLabel9.Value = 80
            trackBarLabel10.Label = "90"
            trackBarLabel10.Value = 90
            trackBarLabel11.Label = "100"
            trackBarLabel11.Value = 100
            Me.trackBarProgressValue.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11})
            Me.trackBarProgressValue.Properties.Maximum = 100
            Me.trackBarProgressValue.Properties.ShowLabels = True
            Me.trackBarProgressValue.Size = New System.Drawing.Size(334, 72)
            Me.trackBarProgressValue.TabIndex = 1
            AddHandler Me.trackBarProgressValue.EditValueChanged, New System.EventHandler(AddressOf Me.OnCurrentProgressValueTrackBarEditValueChanged)
            ' 
            ' cbProgressMode
            ' 
            Me.cbProgressMode.Location = New System.Drawing.Point(10, 35)
            Me.cbProgressMode.Margin = New System.Windows.Forms.Padding(2)
            Me.cbProgressMode.Name = "cbProgressMode"
            Me.cbProgressMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbProgressMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbProgressMode.Size = New System.Drawing.Size(149, 20)
            Me.cbProgressMode.TabIndex = 0
            AddHandler Me.cbProgressMode.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnProgressModeComboBoxEditSelectedValueChanged)
            ' 
            ' groupControl3
            ' 
            Me.groupControl3.Controls.Add(Me.trackBarProgressValue)
            Me.groupControl3.Controls.Add(Me.cbProgressMode)
            Me.groupControl3.Location = New System.Drawing.Point(12, 103)
            Me.groupControl3.Margin = New System.Windows.Forms.Padding(2)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(522, 102)
            Me.groupControl3.TabIndex = 2
            Me.groupControl3.Text = "Progress"
            ' 
            ' imgOverlayIcons
            ' 
            Me.imgOverlayIcons.Location = New System.Drawing.Point(5, 37)
            Me.imgOverlayIcons.Name = "imgOverlayIcons"
            Me.imgOverlayIcons.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imgOverlayIcons.Properties.SmallImages = Me.imgCollection
            Me.imgOverlayIcons.Size = New System.Drawing.Size(160, 20)
            Me.imgOverlayIcons.TabIndex = 0
            AddHandler Me.imgOverlayIcons.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnOverlayIconsComboBoxSelectedValueChanged)
            ' 
            ' imgCollection
            ' 
            Me.imgCollection.ImageStream = CType((resources.GetObject("imgCollection.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imgCollection.Images.SetKeyName(0, "Apply_16x16.png")
            Me.imgCollection.Images.SetKeyName(1, "Add_16x16.png")
            Me.imgCollection.Images.SetKeyName(2, "Refresh2_16x16.png")
            Me.imgCollection.Images.SetKeyName(3, "SelectAll_16x16.png")
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.Controls.Add(Me.imgOverlayIcons)
            Me.groupControl4.Location = New System.Drawing.Point(349, 12)
            Me.groupControl4.Margin = New System.Windows.Forms.Padding(2)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(185, 79)
            Me.groupControl4.TabIndex = 7
            Me.groupControl4.Text = "Overlay Image"
            ' 
            ' btnRemoveItemFromTasks
            ' 
            Me.btnRemoveItemFromTasks.Location = New System.Drawing.Point(218, 33)
            Me.btnRemoveItemFromTasks.Name = "btnRemoveItemFromTasks"
            Me.btnRemoveItemFromTasks.Size = New System.Drawing.Size(202, 27)
            Me.btnRemoveItemFromTasks.TabIndex = 0
            Me.btnRemoveItemFromTasks.Text = "Remove Item from Tasks Category"
            AddHandler Me.btnRemoveItemFromTasks.Click, New System.EventHandler(AddressOf Me.OnRemoveItemFromTasksButtonClick)
            ' 
            ' btnAddItemToTasks
            ' 
            Me.btnAddItemToTasks.Location = New System.Drawing.Point(10, 33)
            Me.btnAddItemToTasks.Name = "btnAddItemToTasks"
            Me.btnAddItemToTasks.Size = New System.Drawing.Size(202, 27)
            Me.btnAddItemToTasks.TabIndex = 0
            Me.btnAddItemToTasks.Text = "Add Item to Tasks Category"
            AddHandler Me.btnAddItemToTasks.Click, New System.EventHandler(AddressOf Me.OnAddItemToTasksButtonClick)
            ' 
            ' groupControl5
            ' 
            Me.groupControl5.Controls.Add(Me.btnAddItemToTasks)
            Me.groupControl5.Controls.Add(Me.btnRemoveItemFromTasks)
            Me.groupControl5.Location = New System.Drawing.Point(12, 217)
            Me.groupControl5.Margin = New System.Windows.Forms.Padding(2)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Size = New System.Drawing.Size(522, 79)
            Me.groupControl5.TabIndex = 8
            Me.groupControl5.Text = "Tasks Category"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Controls.Add(Me.btnRemoveCustomCategory)
            Me.groupControl2.Controls.Add(Me.btnAddCustomCategory)
            Me.groupControl2.Location = New System.Drawing.Point(12, 308)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(522, 79)
            Me.groupControl2.TabIndex = 9
            Me.groupControl2.Text = "Custom Categories"
            ' 
            ' btnRemoveCustomCategory
            ' 
            Me.btnRemoveCustomCategory.Location = New System.Drawing.Point(218, 34)
            Me.btnRemoveCustomCategory.Name = "btnRemoveCustomCategory"
            Me.btnRemoveCustomCategory.Size = New System.Drawing.Size(202, 27)
            Me.btnRemoveCustomCategory.TabIndex = 1
            Me.btnRemoveCustomCategory.Text = "Remove Custom Category"
            AddHandler Me.btnRemoveCustomCategory.Click, New System.EventHandler(AddressOf Me.OnRemoveCustomCategoryButtonClick)
            ' 
            ' btnAddCustomCategory
            ' 
            Me.btnAddCustomCategory.Location = New System.Drawing.Point(10, 34)
            Me.btnAddCustomCategory.Name = "btnAddCustomCategory"
            Me.btnAddCustomCategory.Size = New System.Drawing.Size(202, 27)
            Me.btnAddCustomCategory.TabIndex = 0
            Me.btnAddCustomCategory.Text = "Add Custom Category"
            AddHandler Me.btnAddCustomCategory.Click, New System.EventHandler(AddressOf Me.OnAddCustomCategoryButtonClick)
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(588, 438)
            Me.xtraTabControl1.TabIndex = 15
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl3)
            Me.xtraTabPage1.Controls.Add(Me.groupControl5)
            Me.xtraTabPage1.Controls.Add(Me.groupControl4)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(586, 436)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' ModuleTaskbarAssistant
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ModuleTaskbarAssistant"
            Me.Size = New System.Drawing.Size(588, 438)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.trackBarProgressValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarProgressValue), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbProgressMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            Me.groupControl3.PerformLayout()
            CType((Me.imgOverlayIcons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imgCollection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType((Me.groupControl5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private btnAddThumbnailButton As DevExpress.XtraEditors.SimpleButton

        Private groupControl3 As DevExpress.XtraEditors.GroupControl

        Private trackBarProgressValue As DevExpress.XtraEditors.TrackBarControl

        Private cbProgressMode As DevExpress.XtraEditors.ComboBoxEdit

        Private groupControl5 As DevExpress.XtraEditors.GroupControl

        Private groupControl4 As DevExpress.XtraEditors.GroupControl

        Private btnRemoveThumbnailButton As DevExpress.XtraEditors.SimpleButton

        Private imgOverlayIcons As DevExpress.XtraEditors.ImageComboBoxEdit

        Private imgCollection As DevExpress.Utils.ImageCollection

        Private btnRemoveItemFromTasks As DevExpress.XtraEditors.SimpleButton

        Private btnAddItemToTasks As DevExpress.XtraEditors.SimpleButton

        Private groupControl2 As DevExpress.XtraEditors.GroupControl

        Private btnRemoveCustomCategory As DevExpress.XtraEditors.SimpleButton

        Private btnAddCustomCategory As DevExpress.XtraEditors.SimpleButton

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    End Class
End Namespace

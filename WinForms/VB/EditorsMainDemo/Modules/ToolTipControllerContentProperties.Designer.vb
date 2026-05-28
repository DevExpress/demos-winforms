Namespace EditorsTutorials.Modules

    Partial Class ToolTipControllerContentProperties

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorsTutorials.Modules.ToolTipControllerContentProperties))
            Me.icbIconSize = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbCustomImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.icbIconType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.teTitleText = New DevExpress.XtraEditors.TextEdit()
            Me.meToolTipText = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.icbIconSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbCustomImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbIconType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teTitleText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.meToolTipText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' icbIconSize
            ' 
            Me.icbIconSize.Location = New System.Drawing.Point(176, 101)
            Me.icbIconSize.Name = "icbIconSize"
            Me.icbIconSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbIconSize.Size = New System.Drawing.Size(97, 20)
            Me.icbIconSize.StyleController = Me.layoutControl1
            Me.icbIconSize.TabIndex = 22
            AddHandler Me.icbIconSize.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbIconSize_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbCustomImage)
            Me.layoutControl1.Controls.Add(Me.icbIconSize)
            Me.layoutControl1.Controls.Add(Me.icbIconType)
            Me.layoutControl1.Controls.Add(Me.teTitleText)
            Me.layoutControl1.Controls.Add(Me.meToolTipText)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 161)
            Me.layoutControl1.TabIndex = 24
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbCustomImage
            ' 
            Me.icbCustomImage.EditValue = 0
            Me.icbCustomImage.Location = New System.Drawing.Point(96, 129)
            Me.icbCustomImage.Name = "icbCustomImage"
            Me.icbCustomImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbCustomImage.Properties.DropDownRows = 12
            Me.icbCustomImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 4, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 5, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 6, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 7, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 8, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 9, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 10, 9)})
            Me.icbCustomImage.Properties.SmallImages = Me.svgImageCollection1
            Me.icbCustomImage.Size = New System.Drawing.Size(177, 20)
            Me.icbCustomImage.StyleController = Me.layoutControl1
            Me.icbCustomImage.TabIndex = 23
            AddHandler Me.icbCustomImage.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbCustomImage_SelectedIndexChanged)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Time", CType((resources.GetObject("svgImageCollection1.Time")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Design", CType((resources.GetObject("svgImageCollection1.Design")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Mail", CType((resources.GetObject("svgImageCollection1.Mail")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Pie", CType((resources.GetObject("svgImageCollection1.Pie")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Actions_32x32_Home", CType((resources.GetObject("svgImageCollection1.Actions_32x32_Home")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Tag", CType((resources.GetObject("svgImageCollection1.Tag")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("PersonalID", CType((resources.GetObject("svgImageCollection1.PersonalID")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Database", CType((resources.GetObject("svgImageCollection1.Database")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("task", CType((resources.GetObject("svgImageCollection1.task")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Video", CType((resources.GetObject("svgImageCollection1.Video")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' icbIconType
            ' 
            Me.icbIconType.Location = New System.Drawing.Point(96, 101)
            Me.icbIconType.Name = "icbIconType"
            Me.icbIconType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbIconType.Properties.DropDownRows = 12
            Me.icbIconType.Size = New System.Drawing.Size(76, 20)
            Me.icbIconType.StyleController = Me.layoutControl1
            Me.icbIconType.TabIndex = 21
            AddHandler Me.icbIconType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbIconType_SelectedIndexChanged)
            ' 
            ' teTitleText
            ' 
            Me.teTitleText.EditValue = ""
            Me.teTitleText.Location = New System.Drawing.Point(96, 73)
            Me.teTitleText.Name = "teTitleText"
            Me.teTitleText.Size = New System.Drawing.Size(177, 20)
            Me.teTitleText.StyleController = Me.layoutControl1
            Me.teTitleText.TabIndex = 20
            AddHandler Me.teTitleText.TextChanged, New System.EventHandler(AddressOf Me.teTitleText_TextChanged)
            ' 
            ' meToolTipText
            ' 
            Me.meToolTipText.EditValue = ""
            Me.meToolTipText.Location = New System.Drawing.Point(96, 12)
            Me.meToolTipText.Name = "meToolTipText"
            Me.meToolTipText.Size = New System.Drawing.Size(177, 53)
            Me.meToolTipText.StyleController = Me.layoutControl1
            Me.meToolTipText.TabIndex = 19
            AddHandler Me.meToolTipText.TextChanged, New System.EventHandler(AddressOf Me.meToolTipText_TextChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 161)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.meToolTipText
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(265, 59)
            Me.layoutControlItem1.Text = "ToolTip text:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.teTitleText
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 59)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 6)
            Me.layoutControlItem2.Size = New System.Drawing.Size(265, 30)
            Me.layoutControlItem2.Text = "Title text:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbIconType
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 89)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(164, 24)
            Me.layoutControlItem3.Text = "Icon type/size:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbIconSize
            Me.layoutControlItem4.Location = New System.Drawing.Point(164, 89)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(101, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.icbCustomImage
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 113)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(265, 28)
            Me.layoutControlItem5.Text = "Custom image:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' ToolTipControllerContentProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ToolTipControllerContentProperties"
            Me.Size = New System.Drawing.Size(285, 161)
            CType((Me.icbIconSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbCustomImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbIconType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teTitleText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.meToolTipText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private icbIconSize As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbCustomImage As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbIconType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private teTitleText As DevExpress.XtraEditors.TextEdit

        Private meToolTipText As DevExpress.XtraEditors.MemoEdit

        Private components As System.ComponentModel.IContainer

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace

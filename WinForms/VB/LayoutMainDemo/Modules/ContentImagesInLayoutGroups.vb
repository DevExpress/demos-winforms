Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class ContentImages
        Inherits TutorialControl

        Private layoutControl1 As LayoutControl

        Private layoutControlGroup2 As LayoutControlGroup

        Private pictureEdit1 As XtraEditors.PictureEdit

        Private layoutControlItem2 As LayoutControlItem

        Private labelControl5 As XtraEditors.LabelControl

        Private labelControl4 As XtraEditors.LabelControl

        Private labelControl3 As XtraEditors.LabelControl

        Private labelControl2 As XtraEditors.LabelControl

        Private labelControl1 As XtraEditors.LabelControl

        Private layoutControlItem1 As LayoutControlItem

        Private layoutControlItem3 As LayoutControlItem

        Private layoutControlItem4 As LayoutControlItem

        Private layoutControlItem5 As LayoutControlItem

        Private layoutControlItem6 As LayoutControlItem

        Private emptySpaceItem1 As EmptySpaceItem

        Private emptySpaceItem3 As EmptySpaceItem

        Private emptySpaceItem4 As EmptySpaceItem

        Private layoutControlGroup1 As LayoutControlGroup

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContentImages))
            layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            labelControl5 = New XtraEditors.LabelControl()
            labelControl4 = New XtraEditors.LabelControl()
            labelControl3 = New XtraEditors.LabelControl()
            labelControl2 = New XtraEditors.LabelControl()
            labelControl1 = New XtraEditors.LabelControl()
            pictureEdit1 = New XtraEditors.PictureEdit()
            layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControl1.SuspendLayout()
            CType(pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            layoutControl1.Controls.Add(labelControl5)
            layoutControl1.Controls.Add(labelControl4)
            layoutControl1.Controls.Add(labelControl3)
            layoutControl1.Controls.Add(labelControl2)
            layoutControl1.Controls.Add(labelControl1)
            layoutControl1.Controls.Add(pictureEdit1)
            layoutControl1.Dock = DockStyle.Fill
            layoutControl1.Location = New System.Drawing.Point(0, 0)
            layoutControl1.Name = "layoutControl1"
            layoutControl1.OptionsView.ShareLookAndFeelWithChildren = False
            layoutControl1.Root = layoutControlGroup1
            layoutControl1.Size = New System.Drawing.Size(567, 428)
            layoutControl1.TabIndex = 0
            layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl5
            ' 
            labelControl5.Appearance.ForeColor = System.Drawing.Color.White
            labelControl5.Appearance.Options.UseForeColor = True
            labelControl5.Location = New System.Drawing.Point(175, 161)
            labelControl5.Name = "labelControl5"
            labelControl5.Size = New System.Drawing.Size(155, 13)
            labelControl5.TabIndex = 10
            labelControl5.Text = "ComputerName: ComputerName"
            AddHandler labelControl5.Click, New EventHandler(AddressOf labelControl5_Click)
            ' 
            ' labelControl4
            ' 
            labelControl4.Appearance.ForeColor = System.Drawing.Color.White
            labelControl4.Appearance.Options.UseForeColor = True
            labelControl4.Location = New System.Drawing.Point(175, 138)
            labelControl4.Name = "labelControl4"
            labelControl4.Size = New System.Drawing.Size(105, 13)
            labelControl4.TabIndex = 9
            labelControl4.Text = "NVIDIA GeForce 8800"
            ' 
            ' labelControl3
            ' 
            labelControl3.Appearance.ForeColor = System.Drawing.Color.White
            labelControl3.Appearance.Options.UseForeColor = True
            labelControl3.Location = New System.Drawing.Point(175, 115)
            labelControl3.Name = "labelControl3"
            labelControl3.Size = New System.Drawing.Size(63, 13)
            labelControl3.TabIndex = 8
            labelControl3.Text = "1.98 Gb RAM"
            ' 
            ' labelControl2
            ' 
            labelControl2.Appearance.ForeColor = System.Drawing.Color.White
            labelControl2.Appearance.Options.UseForeColor = True
            labelControl2.Location = New System.Drawing.Point(175, 92)
            labelControl2.Name = "labelControl2"
            labelControl2.Size = New System.Drawing.Size(213, 13)
            labelControl2.TabIndex = 7
            labelControl2.Text = "Intel Core(TM)2 CPU          6300  @ 1.86GHz"
            ' 
            ' labelControl1
            ' 
            labelControl1.Appearance.ForeColor = System.Drawing.Color.White
            labelControl1.Appearance.Options.UseForeColor = True
            labelControl1.Location = New System.Drawing.Point(175, 69)
            labelControl1.Name = "labelControl1"
            labelControl1.Size = New System.Drawing.Size(122, 13)
            labelControl1.TabIndex = 6
            labelControl1.Text = "Microsoft Vista Enterprise"
            ' 
            ' pictureEdit1
            ' 
            pictureEdit1.EditValue =(CObj(resources.GetObject("pictureEdit1.EditValue")))
            pictureEdit1.Location = New System.Drawing.Point(39, 39)
            pictureEdit1.Name = "pictureEdit1"
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            pictureEdit1.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopRight
            pictureEdit1.Size = New System.Drawing.Size(96, 350)
            pictureEdit1.TabIndex = 5
            ' 
            ' layoutControlGroup1
            ' 
            layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlGroup2})
            layoutControlGroup1.Name = "layoutControlGroup1"
            layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            layoutControlGroup1.Size = New System.Drawing.Size(567, 428)
            layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            layoutControlGroup2.BackgroundImageOptions.Image = CType(resources.GetObject("layoutControlGroup2.BackgroundImageOptions.Image"), System.Drawing.Image)
            layoutControlGroup2.BackgroundImageOptions.Visible = True
            layoutControlGroup2.CaptionImageOptions.Image = CType(resources.GetObject("layoutControlGroup2.CaptionImageOptions.Image"), System.Drawing.Image)
            layoutControlGroup2.ContentImageOptions.Image = CType(resources.GetObject("layoutControlGroup2.ContentImageOptions.Image"), System.Drawing.Image)
            layoutControlGroup2.CustomizationFormText = "ComputerName"
            layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, emptySpaceItem3, emptySpaceItem1, emptySpaceItem4})
            layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            layoutControlGroup2.Name = "layoutControlGroup2"
            layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            layoutControlGroup2.Size = New System.Drawing.Size(565, 426)
            layoutControlGroup2.Text = "ComputerName"
            layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.AllowHotTrack = False
            layoutControlItem2.Control = pictureEdit1
            layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            layoutControlItem2.MaxSize = New System.Drawing.Size(166, 0)
            layoutControlItem2.MinSize = New System.Drawing.Size(166, 30)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem2.Size = New System.Drawing.Size(166, 420)
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(30, 30, 30, 30)
            layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.AllowHotTrack = False
            layoutControlItem1.Control = labelControl1
            layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            layoutControlItem1.Location = New System.Drawing.Point(166, 60)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem1.Size = New System.Drawing.Size(223, 23)
            layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.AllowHotTrack = False
            layoutControlItem3.Control = labelControl2
            layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            layoutControlItem3.Location = New System.Drawing.Point(166, 83)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem3.Size = New System.Drawing.Size(223, 23)
            layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.AllowHotTrack = False
            layoutControlItem4.Control = labelControl3
            layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            layoutControlItem4.Location = New System.Drawing.Point(166, 106)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem4.Size = New System.Drawing.Size(223, 23)
            layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            layoutControlItem5.AllowHotTrack = False
            layoutControlItem5.Control = labelControl4
            layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            layoutControlItem5.Location = New System.Drawing.Point(166, 129)
            layoutControlItem5.Name = "layoutControlItem5"
            layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem5.Size = New System.Drawing.Size(223, 23)
            layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            layoutControlItem6.AllowHotTrack = False
            layoutControlItem6.Control = labelControl5
            layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            layoutControlItem6.Location = New System.Drawing.Point(166, 152)
            layoutControlItem6.Name = "layoutControlItem6"
            layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlItem6.Size = New System.Drawing.Size(223, 23)
            layoutControlItem6.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            emptySpaceItem3.Location = New System.Drawing.Point(389, 60)
            emptySpaceItem3.Name = "emptySpaceItem3"
            emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            emptySpaceItem3.Size = New System.Drawing.Size(170, 115)
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            emptySpaceItem1.Location = New System.Drawing.Point(166, 175)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            emptySpaceItem1.Size = New System.Drawing.Size(393, 245)
            ' 
            ' emptySpaceItem4
            ' 
            emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
            emptySpaceItem4.Location = New System.Drawing.Point(166, 0)
            emptySpaceItem4.MaxSize = New System.Drawing.Size(0, 60)
            emptySpaceItem4.MinSize = New System.Drawing.Size(10, 60)
            emptySpaceItem4.Name = "emptySpaceItem4"
            emptySpaceItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            emptySpaceItem4.Size = New System.Drawing.Size(393, 60)
            emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ContentImages
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(layoutControl1)
            Name = "ContentImages"
            Size = New System.Drawing.Size(567, 428)
            CType(layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControl1.ResumeLayout(False)
            CType(pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private Sub labelControl5_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace

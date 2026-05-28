Namespace DevExpress.ApplicationUI.Demos

    Partial Class News

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.News))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.pictureEdit2)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(829, 268, 886, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(613, 431)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Appearance.Options.UseTextOptions = True
            Me.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl4.Location = New System.Drawing.Point(120, 136)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(481, 26)
            Me.labelControl4.StyleController = Me.layoutControl1
            Me.labelControl4.TabIndex = 9
            Me.labelControl4.Text = "The U.S. stock market indices made strong gains by closing time on Tuesday. The E" & "uropean stock market indices…" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            Me.labelControl3.Appearance.Options.UseFont = True
            Me.labelControl3.Appearance.Options.UseTextOptions = True
            Me.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl3.Location = New System.Drawing.Point(120, 115)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(481, 17)
            Me.labelControl3.StyleController = Me.layoutControl1
            Me.labelControl3.TabIndex = 8
            Me.labelControl3.Text = "U.S. Stocks Advance Tuesday"
            ' 
            ' pictureEdit2
            ' 
            Me.pictureEdit2.EditValue =(CObj((resources.GetObject("pictureEdit2.EditValue"))))
            Me.pictureEdit2.Location = New System.Drawing.Point(12, 115)
            Me.pictureEdit2.Name = "pictureEdit2"
            Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit2.Size = New System.Drawing.Size(104, 83)
            Me.pictureEdit2.StyleController = Me.layoutControl1
            Me.pictureEdit2.TabIndex = 7
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Options.UseTextOptions = True
            Me.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl2.Location = New System.Drawing.Point(120, 33)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(481, 39)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 6
            Me.labelControl2.Text = "On April 12th of 1961, Yuri Gagarin was the first human to fly into outer space. " & "Today is the 50th Anniversary…" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.EditValue =(CObj((resources.GetObject("pictureEdit1.EditValue"))))
            Me.pictureEdit1.Location = New System.Drawing.Point(12, 12)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Size = New System.Drawing.Size(104, 80)
            Me.pictureEdit1.StyleController = Me.layoutControl1
            Me.pictureEdit1.TabIndex = 5
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Location = New System.Drawing.Point(120, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(481, 17)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "50th Anniversary of Yuri Gagarin's Flight into Space"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(613, 431)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.pictureEdit1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(108, 84)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(108, 84)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(108, 84)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlItem1.Location = New System.Drawing.Point(108, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(485, 21)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.labelControl2
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(108, 21)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(485, 63)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.pictureEdit2
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 103)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(108, 87)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(108, 87)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(108, 87)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.labelControl3
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(108, 103)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(485, 21)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 190)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(593, 221)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 84)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(593, 19)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.labelControl4
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(108, 124)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(485, 66)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' News
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "News"
            Me.Size = New System.Drawing.Size(613, 431)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

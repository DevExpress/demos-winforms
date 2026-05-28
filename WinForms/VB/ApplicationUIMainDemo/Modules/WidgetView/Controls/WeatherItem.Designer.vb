Namespace DevExpress.ApplicationUI.Demos

    Partial Class WeatherItem

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
            Dim windowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.WeatherItem))
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.windowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(185, 25)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Location = New System.Drawing.Point(40, 2)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(104, 21)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.BackColor = System.Drawing.Color.Transparent
            Me.layoutControl1.Controls.Add(Me.windowsUIButtonPanel1)
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(640, 114, 870, 562)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(185, 185)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' windowsUIButtonPanel1
            ' 
            Me.windowsUIButtonPanel1.ButtonBackgroundImages = Me.imageCollection1
            Me.windowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanel1.Location = New System.Drawing.Point(2, 27)
            Me.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanel1.Size = New System.Drawing.Size(181, 32)
            Me.windowsUIButtonPanel1.TabIndex = 9
            Me.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "1234.png")
            Me.imageCollection1.Images.SetKeyName(1, "1234.png")
            Me.imageCollection1.Images.SetKeyName(2, "1234.png")
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl4.Appearance.Options.UseFont = True
            Me.labelControl4.Location = New System.Drawing.Point(57, 132)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(70, 13)
            Me.labelControl4.StyleController = Me.layoutControl1
            Me.labelControl4.TabIndex = 7
            Me.labelControl4.Text = "labelControl4"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl3.Appearance.Options.UseFont = True
            Me.labelControl3.Location = New System.Drawing.Point(45, 101)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(94, 21)
            Me.labelControl3.StyleController = Me.layoutControl1
            Me.labelControl3.TabIndex = 6
            Me.labelControl3.Text = "labelControl3"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.Location = New System.Drawing.Point(35, 66)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(114, 25)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 5
            Me.labelControl2.Text = "labelControl2"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(185, 185)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.labelControl3
            Me.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(185, 31)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.labelControl4
            Me.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 127)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(185, 20)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.labelControl2
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 61)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 5)
            Me.layoutControlItem2.Size = New System.Drawing.Size(185, 35)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 147)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(185, 38)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.windowsUIButtonPanel1
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 25)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(185, 36)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' WeatherItem
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "WeatherItem"
            Me.Size = New System.Drawing.Size(185, 185)
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private windowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace

Namespace DevExpress.XtraGrid.Demos

    Partial Class ValidationControl

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ValidationControl))
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Appearance.Font = CType((resources.GetObject("label1.Appearance.Font")), System.Drawing.Font)
            Me.label1.Appearance.Options.UseFont = True
            resources.ApplyResources(Me.label1, "label1")
            Me.label1.Name = "label1"
            Me.label1.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.spinEdit2)
            Me.layoutControl1.Controls.Add(Me.label2)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit2)
            Me.layoutControl1.Controls.Add(Me.spinEdit1)
            Me.layoutControl1.Controls.Add(Me.label1)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.AutoSizeInLayoutControl = DevExpress.XtraLayout.AutoSizeModes.UseMinAndMaxSize
            Me.layoutControl1.Root = Me.Root
            ' 
            ' spinEdit2
            ' 
            resources.ApplyResources(Me.spinEdit2, "spinEdit2")
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit2.Properties.ValidateOnEnterKey = True
            Me.spinEdit2.StyleController = Me.layoutControl1
            AddHandler Me.spinEdit2.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit_EditValueChanged)
            ' 
            ' label2
            ' 
            resources.ApplyResources(Me.label2, "label2")
            Me.label2.Name = "label2"
            Me.label2.StyleController = Me.layoutControl1
            ' 
            ' imageComboBoxEdit2
            ' 
            resources.ApplyResources(Me.imageComboBoxEdit2, "imageComboBoxEdit2")
            Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
            Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("imageComboBoxEdit2.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.imageComboBoxEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items"), (CObj((resources.GetObject("imageComboBoxEdit2.Properties.Items1")))), (CInt((resources.GetObject("imageComboBoxEdit2.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items3"), (CObj((resources.GetObject("imageComboBoxEdit2.Properties.Items4")))), (CInt((resources.GetObject("imageComboBoxEdit2.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items6"), (CObj((resources.GetObject("imageComboBoxEdit2.Properties.Items7")))), (CInt((resources.GetObject("imageComboBoxEdit2.Properties.Items8")))))})
            Me.imageComboBoxEdit2.StyleController = Me.layoutControl1
            AddHandler Me.imageComboBoxEdit2.SelectedIndexChanged, New System.EventHandler(AddressOf Me.imageComboBoxEdit2_SelectedIndexChanged)
            ' 
            ' spinEdit1
            ' 
            resources.ApplyResources(Me.spinEdit1, "spinEdit1")
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.ValidateOnEnterKey = True
            Me.spinEdit1.StyleController = Me.layoutControl1
            AddHandler Me.spinEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit_EditValueChanged)
            ' 
            ' imageComboBoxEdit1
            ' 
            resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("imageComboBoxEdit1.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), (CObj((resources.GetObject("imageComboBoxEdit1.Properties.Items1")))), (CInt((resources.GetObject("imageComboBoxEdit1.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), (CObj((resources.GetObject("imageComboBoxEdit1.Properties.Items4")))), (CInt((resources.GetObject("imageComboBoxEdit1.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items6"), (CObj((resources.GetObject("imageComboBoxEdit1.Properties.Items7")))), (CInt((resources.GetObject("imageComboBoxEdit1.Properties.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items9"), (CObj((resources.GetObject("imageComboBoxEdit1.Properties.Items10")))), (CInt((resources.GetObject("imageComboBoxEdit1.Properties.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items12"), (CObj((resources.GetObject("imageComboBoxEdit1.Properties.Items13")))), (CInt((resources.GetObject("imageComboBoxEdit1.Properties.Items14")))))})
            Me.imageComboBoxEdit1.StyleController = Me.layoutControl1
            AddHandler Me.imageComboBoxEdit1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.imageComboBoxEdit1_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2)
            Me.Root.Size = New System.Drawing.Size(773, 73)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem1.Control = Me.imageComboBoxEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(84, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(216, 69)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem2.Control = Me.spinEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(300, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(212, 69)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem3.Control = Me.label2
            Me.layoutControlItem3.Location = New System.Drawing.Point(512, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(22, 69)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem4.Control = Me.imageComboBoxEdit2
            Me.layoutControlItem4.Location = New System.Drawing.Point(534, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(165, 69)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem5.Control = Me.spinEdit2
            Me.layoutControlItem5.Location = New System.Drawing.Point(699, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(54, 69)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem6.Control = Me.label1
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(84, 69)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' ValidationControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ValidationControl"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private label1 As DevExpress.XtraEditors.LabelControl

        Public imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Public spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Public imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Public spinEdit2 As DevExpress.XtraEditors.SpinEdit

        Private label2 As DevExpress.XtraEditors.LabelControl

        Private components As System.ComponentModel.Container = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

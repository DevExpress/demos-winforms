Imports System.Windows.Forms

Namespace DevExpress.AI.Demos

    Partial Class ReportDesignerAIModule

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
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.btnRunDesigner = New DevExpress.XtraEditors.SimpleButton()
            Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
            Me.galleryContainerPanel = New System.Windows.Forms.Panel()
            Me.gallery = New DevExpress.DXperience.Demos.FeatureGalleryControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            Me.tableLayoutPanel.SuspendLayout()
            Me.galleryContainerPanel.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(784, 308)
            Me.ucDisclaimerPanel1.TabIndex = 5
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.roundedSkinPanel1)
            Me.layoutControl1.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2862, 52, 835, 582)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.tableLayoutPanel)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 308)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(784, 124)
            Me.roundedSkinPanel1.TabIndex = 1
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            ' 
            ' tableLayoutPanel
            ' 
            Me.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent
            Me.tableLayoutPanel.ColumnCount = 1
            Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanel.Controls.Add(Me.btnRunDesigner, 0, 3)
            Me.tableLayoutPanel.Controls.Add(Me.lblTitle, 0, 1)
            Me.tableLayoutPanel.Controls.Add(Me.galleryContainerPanel, 0, 2)
            Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel.Location = New System.Drawing.Point(34, 34)
            Me.tableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutPanel.MinimumSize = New System.Drawing.Size(64, 64)
            Me.tableLayoutPanel.Name = "tableLayoutPanel"
            Me.tableLayoutPanel.RowCount = 5
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.tableLayoutPanel.Size = New System.Drawing.Size(716, 64)
            Me.tableLayoutPanel.TabIndex = 1
            ' 
            ' btnRunDesigner
            ' 
            Me.btnRunDesigner.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnRunDesigner.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
            Me.btnRunDesigner.Appearance.Options.UseBackColor = True
            Me.btnRunDesigner.AutoSize = True
            Me.btnRunDesigner.Location = New System.Drawing.Point(271, 57)
            Me.btnRunDesigner.Margin = New System.Windows.Forms.Padding(0, 27, 0, 54)
            Me.btnRunDesigner.Name = "btnRunDesigner"
            Me.btnRunDesigner.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
            Me.btnRunDesigner.Size = New System.Drawing.Size(174, 56)
            Me.btnRunDesigner.TabIndex = 2
            Me.btnRunDesigner.Text = "Run Designer"
            AddHandler Me.btnRunDesigner.Click, New System.EventHandler(AddressOf Me.runDesignerBtn_Click)
            ' 
            ' lblTitle
            ' 
            Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Appearance.Options.UseFont = True
            Me.lblTitle.Appearance.Options.UseTextOptions = True
            Me.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
            Me.lblTitle.Location = New System.Drawing.Point(91, -48)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(0, 54, 0, 27)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(534, 45)
            Me.lblTitle.TabIndex = 1
            Me.lblTitle.Text = "AI-powered Report Designer"
            ' 
            ' galleryContainerPanel
            ' 
            Me.galleryContainerPanel.AutoScroll = True
            Me.galleryContainerPanel.AutoSize = True
            Me.galleryContainerPanel.Controls.Add(Me.gallery)
            Me.galleryContainerPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.galleryContainerPanel.Location = New System.Drawing.Point(3, 27)
            Me.galleryContainerPanel.Name = "galleryContainerPanel"
            Me.galleryContainerPanel.Size = New System.Drawing.Size(710, 0)
            Me.galleryContainerPanel.TabIndex = 4
            ' 
            ' gallery
            ' 
            Me.gallery.AutoSize = True
            Me.gallery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.gallery.Dock = System.Windows.Forms.DockStyle.Top
            Me.gallery.Location = New System.Drawing.Point(0, 0)
            Me.gallery.Margin = New System.Windows.Forms.Padding(0)
            Me.gallery.Name = "gallery"
            Me.gallery.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
            Me.gallery.Size = New System.Drawing.Size(710, 0)
            Me.gallery.TabIndex = 3
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciUcDisclaimerPanel1, Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(784, 432)
            Me.Root.TextVisible = False
            ' 
            ' lciUcDisclaimerPanel1
            ' 
            Me.lciUcDisclaimerPanel1.Control = Me.ucDisclaimerPanel1
            Me.lciUcDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1"
            Me.lciUcDisclaimerPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciUcDisclaimerPanel1.Size = New System.Drawing.Size(784, 308)
            Me.lciUcDisclaimerPanel1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.roundedSkinPanel1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 308)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(784, 124)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' ReportDesignerAIModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.layoutControl1)
            AddHandler Me.Resize, New System.EventHandler(AddressOf Me.OnResize)
            Me.Name = "ReportDesignerAIModule"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            Me.tableLayoutPanel.ResumeLayout(False)
            Me.tableLayoutPanel.PerformLayout()
            Me.galleryContainerPanel.ResumeLayout(False)
            Me.galleryContainerPanel.PerformLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private gallery As DevExpress.DXperience.Demos.FeatureGalleryControl

        Private lblTitle As DevExpress.XtraEditors.LabelControl

        Private btnRunDesigner As DevExpress.XtraEditors.SimpleButton

        Private galleryContainerPanel As System.Windows.Forms.Panel

        Private tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    End Class
End Namespace

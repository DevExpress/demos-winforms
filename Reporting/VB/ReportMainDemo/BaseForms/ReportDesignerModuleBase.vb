Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports RibbonReportDesigner

Namespace XtraReportsDemos

    Public Class ReportDesignerModuleBase
        Inherits ReportModuleBase

#Region "inner classes"
        Private Class DemoRoundedPanel
            Inherits RoundedSkinPanel

            Private Class DemoRoundedPanelViewInfo
                Inherits RoundedSkinPanelViewInfo

                Private skinElement As Lazy(Of SkinElement)

                Public Sub New(ByVal owner As RoundedSkinPanel)
                    MyBase.New(owner)
                    ResetSkinElement()
                End Sub

                Protected Overrides Function GetSkinElement() As SkinElement
                    Return skinElement.Value
                End Function

                Private Function GetPrintingSkinElement(ByVal skin As Skin) As SkinElement
                    Return skin(PrintingSkins.SkinBackgroundPreview)
                End Function

                Public Sub ResetSkinElement()
                    skinElement = New Lazy(Of SkinElement)(AddressOf CreateSkinElement)
                End Sub

                Private Function CreateSkinElement() As SkinElement
                    Dim skin = SkinManager.Default.GetSkin(SkinProductId.Printing, Owner.LookAndFeel)
                    Dim printingSkinElement = GetPrintingSkinElement(skin)
                    Dim skinElement = MyBase.GetSkinElement()?.Copy(skin, "DemoRoundedPanel")
                    If skinElement IsNot Nothing Then
                        skinElement.Info.Color.BackColor = printingSkinElement.Info.Color.BackColor
                        skinElement.Info.Image = printingSkinElement.Image
                    End If

                    Return skinElement
                End Function
            End Class

            Private Overloads ReadOnly Property ViewInfo As DemoRoundedPanelViewInfo
                Get
                    Return CType(MyBase.ViewInfo, DemoRoundedPanelViewInfo)
                End Get
            End Property

            Protected Overrides Sub OnLookAndFeelStyleChangedCore(ByVal sender As Object)
                ViewInfo.ResetSkinElement()
                MyBase.OnLookAndFeelStyleChangedCore(sender)
            End Sub

            Protected Overrides Function CreateViewInfo() As RoundedSkinPanelViewInfo
                Return New DemoRoundedPanelViewInfo(Me)
            End Function
        End Class

#End Region
#Region "fields"
        Private gallery As FeatureGalleryControl

        Private lblTitle As LabelControl

        Private btnRunDesigner As SimpleButton

        Private galleryContainerPanel As Panel

        Private roundedPanel As DemoRoundedPanel

        Protected lcc As DevExpress.XtraLayout.LayoutControl

        Protected lcgRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private lciContent As DevExpress.XtraLayout.LayoutControlItem

        Protected lciHeader As DevExpress.XtraLayout.LayoutControlItem

        Private tableLayoutPanel As TableLayoutPanel

#End Region
#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            lblTitle = New LabelControl()
            btnRunDesigner = New SimpleButton()
            gallery = New FeatureGalleryControl()
            Me.tableLayoutPanel = New Windows.Forms.TableLayoutPanel()
            galleryContainerPanel = New Panel()
            roundedPanel = New DemoRoundedPanel()
            lcc = New DevExpress.XtraLayout.LayoutControl()
            lcgRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            lciHeader = New DevExpress.XtraLayout.LayoutControlItem()
            lciContent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tableLayoutPanel.SuspendLayout()
            galleryContainerPanel.SuspendLayout()
            CType(roundedPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            roundedPanel.SuspendLayout()
            CType(lcc, System.ComponentModel.ISupportInitialize).BeginInit()
            lcc.SuspendLayout()
            CType(lcgRoot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lciHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lciContent, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lblTitle
            ' 
            lblTitle.Anchor = AnchorStyles.None
            lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold)
            lblTitle.Appearance.Options.UseFont = True
            lblTitle.Appearance.Options.UseTextOptions = True
            lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            lblTitle.AutoSizeMode = LabelAutoSizeMode.Horizontal
            lblTitle.Location = New System.Drawing.Point(600, 116)
            lblTitle.Margin = New Padding(0, 54, 0, 27)
            lblTitle.Name = "lblTitle"
            lblTitle.Size = New System.Drawing.Size(127, 45)
            lblTitle.TabIndex = 1
            lblTitle.Text = "lblTitle"
            ' 
            ' btnRunDesigner
            ' 
            btnRunDesigner.Anchor = AnchorStyles.None
            btnRunDesigner.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
            btnRunDesigner.Appearance.Options.UseBackColor = True
            btnRunDesigner.AutoSize = True
            btnRunDesigner.Location = New System.Drawing.Point(577, 221)
            btnRunDesigner.Margin = New Padding(0, 27, 0, 54)
            btnRunDesigner.Name = "btnRunDesigner"
            btnRunDesigner.Padding = New Padding(16, 0, 16, 0)
            btnRunDesigner.Size = New System.Drawing.Size(174, 56)
            btnRunDesigner.TabIndex = 2
            btnRunDesigner.Text = "Run Designer"
            AddHandler btnRunDesigner.Click, New EventHandler(AddressOf runDesignerBtn_Click)
            ' 
            ' gallery
            ' 
            gallery.AutoSize = True
            gallery.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            gallery.Dock = DockStyle.Top
            gallery.Location = New System.Drawing.Point(0, 0)
            gallery.Margin = New Padding(0)
            gallery.Name = "gallery"
            gallery.Padding = New Padding(50, 0, 50, 0)
            gallery.Size = New System.Drawing.Size(1322, 0)
            gallery.TabIndex = 3
            ' 
            ' tableLayoutPanel
            ' 
            Me.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent
            Me.tableLayoutPanel.ColumnCount = 1
            Me.tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
            Me.tableLayoutPanel.Controls.Add(btnRunDesigner, 0, 3)
            Me.tableLayoutPanel.Controls.Add(lblTitle, 0, 1)
            Me.tableLayoutPanel.Controls.Add(galleryContainerPanel, 0, 2)
            Me.tableLayoutPanel.Dock = DockStyle.Fill
            Me.tableLayoutPanel.Location = New System.Drawing.Point(34, 34)
            Me.tableLayoutPanel.Margin = New Padding(0)
            Me.tableLayoutPanel.MinimumSize = New System.Drawing.Size(64, 64)
            Me.tableLayoutPanel.Name = "tableLayoutPanel"
            Me.tableLayoutPanel.RowCount = 5
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle())
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
            Me.tableLayoutPanel.Size = New System.Drawing.Size(1328, 393)
            Me.tableLayoutPanel.TabIndex = 1
            ' 
            ' galleryContainerPanel
            ' 
            galleryContainerPanel.AutoScroll = True
            galleryContainerPanel.AutoSize = True
            galleryContainerPanel.Controls.Add(gallery)
            galleryContainerPanel.Dock = DockStyle.Top
            galleryContainerPanel.Location = New System.Drawing.Point(3, 191)
            galleryContainerPanel.Name = "galleryContainerPanel"
            galleryContainerPanel.Size = New System.Drawing.Size(1322, 0)
            galleryContainerPanel.TabIndex = 4
            ' 
            ' roundedPanel
            ' 
            roundedPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            roundedPanel.Appearance.Options.UseBackColor = True
            roundedPanel.Controls.Add(Me.tableLayoutPanel)
            roundedPanel.Location = New System.Drawing.Point(0, 220)
            roundedPanel.Margin = New Padding(0)
            roundedPanel.Name = "roundedPanel"
            roundedPanel.Size = New System.Drawing.Size(1396, 461)
            roundedPanel.TabIndex = 3
            roundedPanel.Text = "roundedSkinPanel1"
            ' 
            ' lcc
            ' 
            lcc.AllowCustomization = False
            lcc.Controls.Add(roundedPanel)
            lcc.Dock = DockStyle.Fill
            lcc.Location = New System.Drawing.Point(0, 0)
            lcc.Margin = New Padding(0)
            lcc.Name = "lcc"
            lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1698, 338, 1687, 1183)
            lcc.Root = lcgRoot
            lcc.Size = New System.Drawing.Size(1396, 681)
            lcc.TabIndex = 8
            lcc.Text = "layoutControl1"
            ' 
            ' lcgRoot
            ' 
            lcgRoot.GroupBordersVisible = False
            lcgRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {lciHeader, lciContent})
            lcgRoot.Name = "Root"
            lcgRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            lcgRoot.Size = New System.Drawing.Size(1396, 681)
            lcgRoot.TextVisible = False
            ' 
            ' lciHeader
            ' 
            lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(255))))), (CInt(((CByte(192))))), (CInt(((CByte(192))))))
            lciHeader.AppearanceItemCaption.Options.UseBackColor = True
            lciHeader.Location = New System.Drawing.Point(0, 0)
            lciHeader.Name = "lciUcDisclaimerPanel1"
            lciHeader.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            lciHeader.Size = New System.Drawing.Size(1396, 220)
            lciHeader.TextVisible = False
            ' 
            ' lciContent
            ' 
            lciContent.Control = roundedPanel
            lciContent.Location = New System.Drawing.Point(0, 220)
            lciContent.Name = "lciContent"
            lciContent.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            lciContent.Size = New System.Drawing.Size(1396, 461)
            lciContent.TextVisible = False
            ' 
            ' ReportDesignerModuleBase
            ' 
            Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Appearance.Options.UseFont = True
            Me.Controls.Add(lcc)
            Name = "ReportDesignerModuleBase"
            Size = New System.Drawing.Size(1396, 681)
            AddHandler Resize, New EventHandler(AddressOf OnResize)
            Me.tableLayoutPanel.ResumeLayout(False)
            Me.tableLayoutPanel.PerformLayout()
            galleryContainerPanel.ResumeLayout(False)
            galleryContainerPanel.PerformLayout()
            CType(roundedPanel, System.ComponentModel.ISupportInitialize).EndInit()
            roundedPanel.ResumeLayout(False)
            CType(lcc, System.ComponentModel.ISupportInitialize).EndInit()
            lcc.ResumeLayout(False)
            CType(lcgRoot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lciHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lciContent, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Public Sub New()
            InitializeComponent()
            lblTitle.Text = Title
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignMode Then
                Me.SuspendLayout()
                lciHeader.Visibility = If(lciHeader.Control Is Nothing, DevExpress.XtraLayout.Utils.LayoutVisibility.Never, DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                Me.ResumeLayout()
            End If
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            gallery.InitializeGallery(GetFeatureInfos())
        End Sub

        Protected Overridable ReadOnly Property Title As String = ""

        Protected Overridable Function GetFeatureInfos() As IEnumerable(Of FeatureTileInfo)
            Return Enumerable.Empty(Of FeatureTileInfo)()
        End Function

        Private Sub runDesignerBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim size = New Size()
            Using form = New DemoWaitForm()
                size = form.Size
            End Using

            Dim waitFormLocation As Point = tableLayoutPanel.PointToScreen(New Point((Width - size.Width) \ 2, (Height - size.Height) \ 2))
            SplashScreenManager.ShowForm(Me, GetType(DemoWaitForm), True, False, SplashFormStartPosition.Manual, waitFormLocation)
            Using report As XtraReport = CreateReport()
                Using form As MainFormBase = CreateDesignerForm()
                    form.WindowState = FormWindowState.Maximized
                    form.OpenReport(report)
                    AddHandler form.Load, Sub(s, args) SplashScreenManager.CloseForm(False)
                    form.ShowDialog()
                End Using
            End Using
        End Sub

        Protected Overridable Function CreateDesignerForm() As MainFormBase
            Return New OfficeInspiredMainForm()
        End Function

        Protected Overridable Function CreateReport() As XtraReport
            Return New NorthwindTraders.InvoiceReport()
        End Function

        Protected Overrides ReadOnly Property IsActive As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides Function Deactivate() As Task
            SplashScreenManager.CloseForm(False)
            Return MyBase.Deactivate()
        End Function

        Public Overrides Function IsExternalPreviewApplicable() As Boolean
            Return False
        End Function

        Private Overloads Sub OnResize(ByVal sender As Object, ByVal e As EventArgs)
            Dim availableHeight As Integer = tableLayoutPanel.ClientSize.Height
            Dim reservedHeight As Integer = lblTitle.Height + btnRunDesigner.Height + lblTitle.Margin.Vertical + btnRunDesigner.Margin.Vertical
            Dim maxGalleryHeight As Integer = availableHeight - reservedHeight
            galleryContainerPanel.MaximumSize = New Size(tableLayoutPanel.ClientSize.Width, maxGalleryHeight)
            galleryContainerPanel.MinimumSize = New Size(0, 0)
        End Sub
    End Class
End Namespace

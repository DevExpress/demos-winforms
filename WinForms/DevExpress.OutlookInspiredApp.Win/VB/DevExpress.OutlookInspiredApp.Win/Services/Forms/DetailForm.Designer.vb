Namespace DevExpress.DevAV

    Partial Class DetailForm

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.DevAV.DetailForm))
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biGetStarted = New DevExpress.XtraBars.BarButtonItem()
            Me.biGetSupport = New DevExpress.XtraBars.BarButtonItem()
            Me.biBuyNow = New DevExpress.XtraBars.BarButtonItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biGetStarted, Me.biGetSupport, Me.biBuyNow, Me.biAbout})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 5
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1004, 121)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.biGetStarted.Caption = "Getting Started"
            Me.biGetStarted.Id = 1
            Me.biGetStarted.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biGetStarted.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetStarted.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg"
            Me.biGetStarted.Name = "biGetStarted"
            Me.biGetSupport.Caption = "Support"
            Me.biGetSupport.Id = 2
            Me.biGetSupport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biGetSupport.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetSupport.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg"
            Me.biGetSupport.Name = "biGetSupport"
            Me.biBuyNow.Caption = "Buy Now"
            Me.biBuyNow.Id = 3
            Me.biBuyNow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biBuyNow.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biBuyNow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg"
            Me.biBuyNow.Name = "biBuyNow"
            Me.biAbout.Caption = "About"
            Me.biAbout.Id = 4
            Me.biAbout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biAbout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAbout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg"
            Me.biAbout.Name = "biAbout"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "DX"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biGetStarted)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biGetSupport)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biBuyNow)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biAbout)
            Me.ribbonPageGroup1.MergeOrder = 1
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "DevExpress"
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 761)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1004, 37)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1004, 798)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.IconOptions.Icon = CType((resources.GetObject("DetailForm.IconOptions.Icon")), System.Drawing.Icon)
            Me.Name = "DetailForm"
            Me.Ribbon = Me.ribbonControl
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "DevAV"
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biGetStarted As DevExpress.XtraBars.BarButtonItem

        Private biGetSupport As DevExpress.XtraBars.BarButtonItem

        Private biBuyNow As DevExpress.XtraBars.BarButtonItem

        Private biAbout As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

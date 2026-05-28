Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraDiagram.Demos

    Partial Class DesignerFrm

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.DXperience.Demos.RibbonMainForm))
            Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
            Me.rpgAppearance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.pmAppearance = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
            Me.bbiRoundedMode = New DevExpress.XtraBars.BarCheckItem()
            CType((Me.pmAppearance), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            ' skinDropDownButtonItem1
            ' 
            Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
            ' 
            ' skinPaletteRibbonGalleryBarItem1
            ' 
            Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
            '
            ' bbiRoundedMode
            '
            resources.ApplyResources(Me.bbiRoundedMode, "bbiRoundedMode")
            Me.bbiRoundedMode.ImageOptions.SvgImage = CType((resources.GetObject("bbiRoundedMode.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bbiRoundedMode.Name = "bbiRoundedMode"
            AddHandler Me.bbiRoundedMode.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRoundedModeCheckedChanged)
            Me.bbiRoundedMode.Visibility = If(DevExpress.Utils.WindowsVersionProvider.IsWindows11, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
            Me.Ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.skinDropDownButtonItem1, Me.skinPaletteRibbonGalleryBarItem1, Me.bbiRoundedMode})
            ' 
            ' rpgAppearance
            ' 
            resources.ApplyResources(Me.rpgAppearance, "rpgAppearance")
            Me.rpgAppearance.ItemLinks.Add(Me.skinDropDownButtonItem1)
            Me.rpgAppearance.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
            Me.rpgAppearance.ItemLinks.Add(Me.bbiRoundedMode)
            Me.rpgAppearance.Name = "rpgAppearance"
            AddHandler Me.rpgAppearance.CaptionButtonClick, New DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(AddressOf Me.RpgAppearance_CaptionButtonClick)
            ' 
            ' pmAppearance
            ' 
            Me.pmAppearance.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
            Me.pmAppearance.Name = "pmAppearance"
            Me.pmAppearance.Ribbon = Me.Ribbon
            Me.pmAppearance.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' 
            ' DesignerFrm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1549, 833)
            Me.Name = "DesignerFrm"
            CType((Me.pmAppearance), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private skinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem

        Private rpgAppearance As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private skinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem

        Private bbiRoundedMode As DevExpress.XtraBars.BarCheckItem

        Private pmAppearance As DevExpress.XtraBars.PopupMenu
    End Class
End Namespace

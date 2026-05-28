Namespace DevExpress.XtraPdfViewer.Demos

    Partial Class MainForm

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraPdfViewer.Demos.MainForm))
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful"
            ' 
            ' gcDescription
            ' 
            Me.gcDescription.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.gcDescription.Appearance.Options.UseFont = True
            Me.gcDescription.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.gcDescription.AppearanceDisabled.Options.UseFont = True
            Me.gcDescription.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.gcDescription.AppearanceHovered.Options.UseFont = True
            Me.gcDescription.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Me.gcDescription.AppearancePressed.Options.UseFont = True
            Me.gcDescription.Location = New System.Drawing.Point(0, 0)
            Me.gcDescription.Size = New System.Drawing.Size(884, 40)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.OptionsPageCategories.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.SearchEditItem.UseEditorPadding = False
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1398, 959)
            Me.IconOptions.Icon = CType((resources.GetObject("MainForm.IconOptions.Icon")), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(0, 0)
            Me.Name = "MainForm"
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace

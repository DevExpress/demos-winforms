Namespace DevExpress.HTML.Demos

    Partial Class RepositoryItems

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.RepositoryItems))
            Me.htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            Me.emailEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.passEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.cPassEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.checkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.pictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.templateCodeViewer = New DevExpress.HTML.Demos.HtmlContentControlCodeViewer()
            Me.sidePanel = New DevExpress.XtraEditors.SidePanel()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emailEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.passEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cPassEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel.SuspendLayout()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' htmlContentControl
            ' 
            Me.htmlContentControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles")
            Me.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template")
            Me.htmlContentControl.Location = New System.Drawing.Point(5, 0)
            Me.htmlContentControl.Name = "htmlContentControl"
            Me.htmlContentControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.emailEdit, Me.passEdit, Me.cPassEdit, Me.checkEdit, Me.pictureEdit})
            Me.htmlContentControl.Size = New System.Drawing.Size(395, 445)
            Me.htmlContentControl.TabIndex = 0
            AddHandler Me.htmlContentControl.ElementMouseDown, New DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(AddressOf Me.OnHtmlElementMouseDown)
            ' 
            ' emailEdit
            ' 
            Me.emailEdit.AutoHeight = False
            Me.emailEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.emailEdit.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            Me.emailEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.emailEdit.Name = "emailEdit"
            Me.emailEdit.NullValuePrompt = "Email Address"
            ' 
            ' passEdit
            ' 
            Me.passEdit.AutoHeight = False
            Me.passEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.passEdit.Name = "passEdit"
            Me.passEdit.NullValuePrompt = "Password"
            Me.passEdit.PasswordChar = "*"c
            ' 
            ' cPassEdit
            ' 
            Me.cPassEdit.AutoHeight = False
            Me.cPassEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.cPassEdit.Name = "cPassEdit"
            Me.cPassEdit.NullValuePrompt = "Confirm Password"
            Me.cPassEdit.PasswordChar = "*"c
            ' 
            ' checkEdit
            ' 
            Me.checkEdit.AllowFocused = False
            Me.checkEdit.AutoHeight = False
            Me.checkEdit.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
            Me.checkEdit.ImageOptions.SvgImageChecked = Global.DevExpress.HTML.Demos.Properties.Resources._checked
            Me.checkEdit.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
            Me.checkEdit.ImageOptions.SvgImageUnchecked = Global.DevExpress.HTML.Demos.Properties.Resources._unchecked
            Me.checkEdit.Name = "checkEdit"
            Me.checkEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
            ' 
            ' pictureEdit
            ' 
            Me.pictureEdit.AllowFocused = False
            Me.pictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pictureEdit.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
            Me.pictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            AddHandler Me.pictureEdit.ImageChanged, New System.EventHandler(AddressOf Me.OnPictureEditImageChanged)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("default_photo", CType((resources.GetObject("svgImageCollection1.default_photo")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' templateCodeViewer
            ' 
            Me.templateCodeViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateCodeViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateCodeViewer.Name = "templateCodeViewer"
            Me.templateCodeViewer.Size = New System.Drawing.Size(399, 445)
            Me.templateCodeViewer.TabIndex = 0
            ' 
            ' sidePanel
            ' 
            Me.sidePanel.Controls.Add(Me.templateCodeViewer)
            Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel.Location = New System.Drawing.Point(400, 0)
            Me.sidePanel.Name = "sidePanel"
            Me.sidePanel.Size = New System.Drawing.Size(400, 445)
            Me.sidePanel.TabIndex = 1
            Me.sidePanel.Text = "sidePanel"
            ' 
            ' bindingSource
            ' 
            Me.bindingSource.DataMember = "UserInfo"
            ' 
            ' RepositoryItems
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.htmlContentControl)
            Me.Controls.Add(Me.sidePanel)
            Me.Name = "RepositoryItems"
            Me.Size = New System.Drawing.Size(800, 450)
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emailEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.passEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cPassEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel.ResumeLayout(False)
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl As DevExpress.XtraEditors.HtmlContentControl

        Private emailEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private passEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private cPassEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private checkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

        Private pictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private templateCodeViewer As DevExpress.HTML.Demos.HtmlContentControlCodeViewer

        Private sidePanel As DevExpress.XtraEditors.SidePanel

        Private bindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

Namespace DevExpress.HTML.Demos

    Partial Class DemoDirectXForm

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.DemoDirectXForm))
            Me.directXFormContainerControl1 = New DevExpress.XtraEditors.DirectXFormContainerControl()
            Me.svgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.searchEdit = New DevExpress.XtraEditors.SearchControl()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' directXFormContainerControl1
            ' 
            Me.directXFormContainerControl1.Location = New System.Drawing.Point(31, 93)
            Me.directXFormContainerControl1.Name = "directXFormContainerControl1"
            Me.directXFormContainerControl1.Size = New System.Drawing.Size(638, 224)
            Me.directXFormContainerControl1.TabIndex = 0
            ' 
            ' svgImages
            ' 
            Me.svgImages.Add("Back", CType((resources.GetObject("svgImages.Back")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Close", CType((resources.GetObject("svgImages.Close")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Forward", CType((resources.GetObject("svgImages.Forward")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Info", CType((resources.GetObject("svgImages.Info")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Search", CType((resources.GetObject("svgImages.Search")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("User", CType((resources.GetObject("svgImages.User")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Add", CType((resources.GetObject("svgImages.Add")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Logo", CType((resources.GetObject("svgImages.Logo")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' searchEdit
            ' 
            Me.searchEdit.Location = New System.Drawing.Point(234, 43)
            Me.searchEdit.Name = "searchEdit"
            Me.searchEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.searchEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.searchEdit.Properties.Appearance.Options.UseBackColor = True
            Me.searchEdit.Properties.Appearance.Options.UseFont = True
            Me.searchEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.searchEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.searchEdit.Properties.AutoHeight = False
            Me.searchEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.searchEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton()})
            Me.searchEdit.Properties.ShowSearchButton = False
            Me.searchEdit.Size = New System.Drawing.Size(125, 40)
            Me.searchEdit.TabIndex = 1
            ' 
            ' DemoDirectXForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ChildControls.Add(Me.directXFormContainerControl1)
            Me.ChildControls.Add(Me.searchEdit)
            Me.ClientSize = New System.Drawing.Size(700, 400)
            Me.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.HtmlImages = Me.svgImages
            Me.HtmlTemplate.Styles = resources.GetString("DemoDirectXForm.HtmlTemplate.Styles")
            Me.HtmlTemplate.Template = resources.GetString("DemoDirectXForm.HtmlTemplate.Template")
            Me.MinimumSize = New System.Drawing.Size(660, 400)
            Me.Name = "DemoDirectXForm"
            Me.Text = "Form1"
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private directXFormContainerControl1 As DevExpress.XtraEditors.DirectXFormContainerControl

        Private svgImages As DevExpress.Utils.SvgImageCollection

        Private searchEdit As DevExpress.XtraEditors.SearchControl
    End Class
End Namespace

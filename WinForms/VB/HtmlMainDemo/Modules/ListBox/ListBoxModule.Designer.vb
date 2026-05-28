Namespace DevExpress.HTML.Demos

    Partial Class ListBoxModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.ListBoxModule))
            Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
            Me.svgImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.listBoxTemplateCodeViewer1 = New DevExpress.HTML.Demos.ListBoxTemplateCodeViewer()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.htmlContentPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.htmlContentPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl
            ' 
            Me.listBoxControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.listBoxControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl.HtmlImages = Me.svgImageCollection
            Me.listBoxControl.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.htmlTemplate1})
            Me.listBoxControl.ItemHeight = 72
            Me.listBoxControl.Location = New System.Drawing.Point(2, 23)
            Me.listBoxControl.Name = "listBoxControl"
            Me.listBoxControl.Size = New System.Drawing.Size(290, 469)
            Me.listBoxControl.TabIndex = 0
            ' 
            ' svgImageCollection
            ' 
            Me.svgImageCollection.Add("about", "image://svgimages/outlook inspired/about.svg")
            Me.svgImageCollection.Add("Beak.Left", CType((resources.GetObject("svgImageCollection.Beak.Left")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("Message", CType((resources.GetObject("svgImageCollection.Message")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("PhoneCall", CType((resources.GetObject("svgImageCollection.PhoneCall")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("VideoCall", CType((resources.GetObject("svgImageCollection.VideoCall")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("Contact", CType((resources.GetObject("svgImageCollection.Contact")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' htmlTemplate1
            ' 
            Me.htmlTemplate1.Name = "htmlTemplate1"
            Me.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles")
            Me.htmlTemplate1.Tag = "Item Template"
            Me.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template")
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.listBoxTemplateCodeViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(228, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(642, 467)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' listBoxTemplateCodeViewer1
            ' 
            Me.listBoxTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.listBoxTemplateCodeViewer1.Name = "listBoxTemplateCodeViewer1"
            Me.listBoxTemplateCodeViewer1.Size = New System.Drawing.Size(641, 467)
            Me.listBoxTemplateCodeViewer1.TabIndex = 0
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 300F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel1.Controls.Add(Me.groupControl1)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 500F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)})
            Me.tablePanel1.Size = New System.Drawing.Size(228, 467)
            Me.tablePanel1.TabIndex = 2
            ' 
            ' groupControl1
            ' 
            Me.tablePanel1.SetColumn(Me.groupControl1, 1)
            Me.groupControl1.Controls.Add(Me.listBoxControl)
            Me.groupControl1.Location = New System.Drawing.Point(3, 3)
            Me.groupControl1.Name = "groupControl1"
            Me.tablePanel1.SetRow(Me.groupControl1, 1)
            Me.groupControl1.Size = New System.Drawing.Size(294, 494)
            Me.groupControl1.TabIndex = 1
            Me.groupControl1.Text = "Contacts"
            ' 
            ' htmlContentPopup
            ' 
            Me.htmlContentPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.htmlContentPopup.HtmlImages = Me.svgImageCollection
            Me.htmlContentPopup.HtmlTemplate.Styles = resources.GetString("htmlContentPopup.HtmlTemplate.Styles")
            Me.htmlContentPopup.HtmlTemplate.Tag = "Popup Template"
            Me.htmlContentPopup.HtmlTemplate.Template = resources.GetString("htmlContentPopup.HtmlTemplate.Template")
            ' 
            ' ListBoxModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ListBoxModule"
            Me.Size = New System.Drawing.Size(870, 467)
            CType((Me.listBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.htmlContentPopup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private listBoxControl As DevExpress.XtraEditors.ListBoxControl

        Private svgImageCollection As DevExpress.Utils.SvgImageCollection

        Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private listBoxTemplateCodeViewer1 As DevExpress.HTML.Demos.ListBoxTemplateCodeViewer

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private htmlContentPopup As DevExpress.XtraEditors.HtmlContentPopup
    End Class
End Namespace

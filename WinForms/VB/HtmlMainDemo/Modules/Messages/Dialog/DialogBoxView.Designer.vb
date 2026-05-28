Imports DevExpress.Utils.Html

Namespace DevExpress.HTML.Demos

    Partial Class DialogBoxView

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.DialogBoxView))
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.dialogTemplateViewer = New DevExpress.HTML.Demos.DialogBoxTemplateViewer()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.buttonPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.showDialog = New DevExpress.XtraEditors.SimpleButton()
            Me.hostDialog = New DevExpress.XtraEditors.XtraUserControl()
            Me.svgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.htmlDialogTemplateCollection = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.loginFormTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.feedbackFormTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.htmlContentTemplateCollection = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.loginTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.feedbackTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonPanel.SuspendLayout()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.dialogTemplateViewer)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(297, 0)
            Me.sidePanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(450, 350)
            Me.sidePanel1.TabIndex = 0
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' dialogTemplateViewer
            ' 
            Me.dialogTemplateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dialogTemplateViewer.Location = New System.Drawing.Point(1, 0)
            Me.dialogTemplateViewer.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
            Me.dialogTemplateViewer.Name = "dialogTemplateViewer"
            Me.dialogTemplateViewer.Size = New System.Drawing.Size(449, 350)
            Me.dialogTemplateViewer.TabIndex = 0
            AddHandler Me.dialogTemplateViewer.ActiveTemplateChanged, New System.EventHandler(AddressOf Me.OnActiveTemplateChanged)
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)})
            Me.tablePanel1.Controls.Add(Me.buttonPanel)
            Me.tablePanel1.Controls.Add(Me.hostDialog)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F)})
            Me.tablePanel1.Size = New System.Drawing.Size(297, 350)
            Me.tablePanel1.TabIndex = 1
            ' 
            ' buttonPanel
            ' 
            Me.tablePanel1.SetColumn(Me.buttonPanel, 0)
            Me.buttonPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 180F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)})
            Me.buttonPanel.Controls.Add(Me.showDialog)
            Me.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.buttonPanel.Location = New System.Drawing.Point(2, 250)
            Me.buttonPanel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 2)
            Me.buttonPanel.Name = "buttonPanel"
            Me.tablePanel1.SetRow(Me.buttonPanel, 1)
            Me.buttonPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.buttonPanel.Size = New System.Drawing.Size(293, 98)
            Me.buttonPanel.TabIndex = 12
            ' 
            ' showDialog
            ' 
            Me.buttonPanel.SetColumn(Me.showDialog, 1)
            Me.showDialog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.showDialog.Location = New System.Drawing.Point(59, 2)
            Me.showDialog.Margin = New System.Windows.Forms.Padding(2)
            Me.showDialog.Name = "showDialog"
            Me.buttonPanel.SetRow(Me.showDialog, 0)
            Me.showDialog.Size = New System.Drawing.Size(176, 26)
            Me.showDialog.TabIndex = 6
            Me.showDialog.Text = "Show the DialogBox"
            AddHandler Me.showDialog.Click, New System.EventHandler(AddressOf Me.OnShowDialogBoxButtonClick)
            ' 
            ' hostDialog
            ' 
            Me.tablePanel1.SetColumn(Me.hostDialog, 0)
            Me.hostDialog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hostDialog.Location = New System.Drawing.Point(0, 0)
            Me.hostDialog.Margin = New System.Windows.Forms.Padding(0)
            Me.hostDialog.Name = "hostDialog"
            Me.tablePanel1.SetRow(Me.hostDialog, 0)
            Me.hostDialog.Size = New System.Drawing.Size(297, 250)
            Me.hostDialog.TabIndex = 2
            Me.hostDialog.TabStop = False
            ' 
            ' svgImages
            ' 
            Me.svgImages.Add("close", CType((resources.GetObject("svgImages.close")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("pass", "image://svgimages/icon builder/security_key.svg")
            Me.svgImages.Add("login", "image://svgimages/business objects/bo_lead.svg")
            ' 
            ' htmlDialogTemplateCollection
            ' 
            Me.htmlDialogTemplateCollection.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.loginFormTemplate, Me.feedbackFormTemplate})
            ' 
            ' loginFormTemplate
            ' 
            Me.loginFormTemplate.Name = "loginFormTemplate"
            Me.loginFormTemplate.Styles = resources.GetString("loginFormTemplate.Styles")
            Me.loginFormTemplate.Tag = "Login Form"
            Me.loginFormTemplate.Template = resources.GetString("loginFormTemplate.Template")
            ' 
            ' feedbackFormTemplate
            ' 
            Me.feedbackFormTemplate.Name = "feedbackFormTemplate"
            Me.feedbackFormTemplate.Styles = resources.GetString("feedbackFormTemplate.Styles")
            Me.feedbackFormTemplate.Tag = "Feedback Form"
            Me.feedbackFormTemplate.Template = resources.GetString("feedbackFormTemplate.Template")
            ' 
            ' htmlContentTemplateCollection
            ' 
            Me.htmlContentTemplateCollection.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.loginTemplate, Me.feedbackTemplate})
            ' 
            ' loginTemplate
            ' 
            Me.loginTemplate.Name = "loginTemplate"
            Me.loginTemplate.Styles = resources.GetString("loginTemplate.Styles")
            Me.loginTemplate.Template = resources.GetString("loginTemplate.Template")
            ' 
            ' feedbackTemplate
            ' 
            Me.feedbackTemplate.Name = "feedbackTemplate"
            Me.feedbackTemplate.Styles = resources.GetString("feedbackTemplate.Styles")
            Me.feedbackTemplate.Template = resources.GetString("feedbackTemplate.Template")
            ' 
            ' DialogBoxView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "DialogBoxView"
            Me.Size = New System.Drawing.Size(747, 350)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonPanel.ResumeLayout(False)
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private dialogTemplateViewer As DevExpress.HTML.Demos.DialogBoxTemplateViewer

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private hostDialog As DevExpress.XtraEditors.XtraUserControl

        Private svgImages As DevExpress.Utils.SvgImageCollection

        Private buttonPanel As DevExpress.Utils.Layout.TablePanel

        Private showDialog As DevExpress.XtraEditors.SimpleButton

        Private htmlDialogTemplateCollection As DevExpress.Utils.Html.HtmlTemplateCollection

        Private htmlContentTemplateCollection As DevExpress.Utils.Html.HtmlTemplateCollection

        Private feedbackFormTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private loginFormTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private loginTemplate As DevExpress.Utils.Html.HtmlTemplate

        Private feedbackTemplate As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

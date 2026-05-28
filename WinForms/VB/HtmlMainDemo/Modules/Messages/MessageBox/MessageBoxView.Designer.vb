Imports DevExpress.Utils.Html

Namespace DevExpress.HTML.Demos

    Partial Class MessageBoxView

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.MessageBoxView))
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.tablePanel2 = New DevExpress.Utils.Layout.TablePanel()
            Me.messageBoxResult = New DevExpress.HTML.Demos.MessageBoxResult()
            Me.propertiesMessageBox = New DevExpress.HTML.Demos.MessageBoxProperties()
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            Me.hostMessage = New DevExpress.XtraEditors.XtraUserControl()
            Me.buttonPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.showMessage = New DevExpress.XtraEditors.SimpleButton()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.templateViewer = New DevExpress.HTML.Demos.MessageBoxTemplateViewer()
            Me.svgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.htmlMessageTemplateCollection = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.confirmMessageTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.confirmMessageTemplate2 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.notificationMessageTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel2.SuspendLayout()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonPanel.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)})
            Me.tablePanel1.Controls.Add(Me.tablePanel2)
            Me.tablePanel1.Controls.Add(Me.separatorControl1)
            Me.tablePanel1.Controls.Add(Me.hostMessage)
            Me.tablePanel1.Controls.Add(Me.buttonPanel)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 170F)})
            Me.tablePanel1.Size = New System.Drawing.Size(321, 471)
            Me.tablePanel1.TabIndex = 14
            ' 
            ' tablePanel2
            ' 
            Me.tablePanel1.SetColumn(Me.tablePanel2, 0)
            Me.tablePanel2.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.tablePanel2.Controls.Add(Me.messageBoxResult)
            Me.tablePanel2.Controls.Add(Me.propertiesMessageBox)
            Me.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel2.Location = New System.Drawing.Point(3, 304)
            Me.tablePanel2.Name = "tablePanel2"
            Me.tablePanel1.SetRow(Me.tablePanel2, 3)
            Me.tablePanel2.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)})
            Me.tablePanel2.Size = New System.Drawing.Size(315, 164)
            Me.tablePanel2.TabIndex = 12
            ' 
            ' messageBoxResult
            ' 
            Me.tablePanel2.SetColumn(Me.messageBoxResult, 1)
            Me.messageBoxResult.Dock = System.Windows.Forms.DockStyle.Fill
            Me.messageBoxResult.Location = New System.Drawing.Point(162, 4)
            Me.messageBoxResult.Margin = New System.Windows.Forms.Padding(4)
            Me.messageBoxResult.Name = "messageBoxResult"
            Me.tablePanel2.SetRow(Me.messageBoxResult, 0)
            Me.messageBoxResult.Size = New System.Drawing.Size(150, 156)
            Me.messageBoxResult.TabIndex = 1
            ' 
            ' propertiesMessageBox
            ' 
            Me.tablePanel2.SetColumn(Me.propertiesMessageBox, 0)
            Me.propertiesMessageBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertiesMessageBox.Location = New System.Drawing.Point(4, 4)
            Me.propertiesMessageBox.Margin = New System.Windows.Forms.Padding(4)
            Me.propertiesMessageBox.Name = "propertiesMessageBox"
            Me.tablePanel2.SetRow(Me.propertiesMessageBox, 0)
            Me.propertiesMessageBox.Size = New System.Drawing.Size(150, 156)
            Me.propertiesMessageBox.TabIndex = 0
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.AutoSizeMode = True
            Me.tablePanel1.SetColumn(Me.separatorControl1, 0)
            Me.separatorControl1.Location = New System.Drawing.Point(0, 300)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.SetRow(Me.separatorControl1, 2)
            Me.separatorControl1.Size = New System.Drawing.Size(321, 1)
            Me.separatorControl1.TabIndex = 11
            ' 
            ' hostMessage
            ' 
            Me.tablePanel1.SetColumn(Me.hostMessage, 0)
            Me.hostMessage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hostMessage.Location = New System.Drawing.Point(0, 0)
            Me.hostMessage.Margin = New System.Windows.Forms.Padding(0)
            Me.hostMessage.Name = "hostMessage"
            Me.tablePanel1.SetRow(Me.hostMessage, 0)
            Me.hostMessage.Size = New System.Drawing.Size(321, 200)
            Me.hostMessage.TabIndex = 1
            Me.hostMessage.TabStop = False
            ' 
            ' buttonPanel
            ' 
            Me.tablePanel1.SetColumn(Me.buttonPanel, 0)
            Me.buttonPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 180F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)})
            Me.buttonPanel.Controls.Add(Me.showMessage)
            Me.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.buttonPanel.Location = New System.Drawing.Point(2, 200)
            Me.buttonPanel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 2)
            Me.buttonPanel.Name = "buttonPanel"
            Me.tablePanel1.SetRow(Me.buttonPanel, 1)
            Me.buttonPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.buttonPanel.Size = New System.Drawing.Size(317, 98)
            Me.buttonPanel.TabIndex = 10
            ' 
            ' showMessage
            ' 
            Me.buttonPanel.SetColumn(Me.showMessage, 1)
            Me.showMessage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.showMessage.Location = New System.Drawing.Point(71, 2)
            Me.showMessage.Margin = New System.Windows.Forms.Padding(2)
            Me.showMessage.Name = "showMessage"
            Me.buttonPanel.SetRow(Me.showMessage, 0)
            Me.showMessage.Size = New System.Drawing.Size(176, 26)
            Me.showMessage.TabIndex = 6
            Me.showMessage.Text = "Show the MessageBox"
            AddHandler Me.showMessage.Click, New System.EventHandler(AddressOf Me.OnShowMessageBoxButtonClick)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.templateViewer)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(321, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(450, 471)
            Me.sidePanel1.TabIndex = 13
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' templateViewer
            ' 
            Me.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewer.Location = New System.Drawing.Point(1, 0)
            Me.templateViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.templateViewer.Name = "templateViewer"
            Me.templateViewer.Size = New System.Drawing.Size(449, 471)
            Me.templateViewer.TabIndex = 0
            ' 
            ' svgImages
            ' 
            Me.svgImages.Add("close", CType((resources.GetObject("svgImages.close")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' htmlMessageTemplateCollection
            ' 
            Me.htmlMessageTemplateCollection.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.confirmMessageTemplate1, Me.confirmMessageTemplate2, Me.notificationMessageTemplate1})
            ' 
            ' confirmMessageTemplate1
            ' 
            Me.confirmMessageTemplate1.Name = "confirmMessageTemplate1"
            Me.confirmMessageTemplate1.PreviewType = GetType(DevExpress.XtraEditors.XtraMessageBox)
            Me.confirmMessageTemplate1.Styles = resources.GetString("confirmMessageTemplate1.Styles")
            Me.confirmMessageTemplate1.Tag = "Confirmation Message #1"
            Me.confirmMessageTemplate1.Template = resources.GetString("confirmMessageTemplate1.Template")
            ' 
            ' confirmMessageTemplate2
            ' 
            Me.confirmMessageTemplate2.Name = "confirmMessageTemplate2"
            Me.confirmMessageTemplate2.PreviewType = GetType(DevExpress.XtraEditors.XtraMessageBox)
            Me.confirmMessageTemplate2.Styles = resources.GetString("confirmMessageTemplate2.Styles")
            Me.confirmMessageTemplate2.Tag = "Confirmation Message #2"
            Me.confirmMessageTemplate2.Template = resources.GetString("confirmMessageTemplate2.Template")
            ' 
            ' notificationMessageTemplate1
            ' 
            Me.notificationMessageTemplate1.Name = "notificationMessageTemplate1"
            Me.notificationMessageTemplate1.PreviewType = GetType(DevExpress.XtraEditors.XtraMessageBox)
            Me.notificationMessageTemplate1.Styles = resources.GetString("notificationMessageTemplate1.Styles")
            Me.notificationMessageTemplate1.Tag = "Notification Message"
            Me.notificationMessageTemplate1.Template = resources.GetString("notificationMessageTemplate1.Template")
            ' 
            ' MessageBoxView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "MessageBoxView"
            Me.Size = New System.Drawing.Size(771, 471)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel2.ResumeLayout(False)
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonPanel.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private tablePanel2 As DevExpress.Utils.Layout.TablePanel

        Private messageBoxResult As DevExpress.HTML.Demos.MessageBoxResult

        Private propertiesMessageBox As DevExpress.HTML.Demos.MessageBoxProperties

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl

        Private hostMessage As DevExpress.XtraEditors.XtraUserControl

        Private buttonPanel As DevExpress.Utils.Layout.TablePanel

        Private showMessage As DevExpress.XtraEditors.SimpleButton

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private templateViewer As DevExpress.HTML.Demos.MessageBoxTemplateViewer

        Private svgImages As DevExpress.Utils.SvgImageCollection

        Private htmlMessageTemplateCollection As DevExpress.Utils.Html.HtmlTemplateCollection

        Private confirmMessageTemplate1 As DevExpress.Utils.Html.HtmlTemplate

        Private confirmMessageTemplate2 As DevExpress.Utils.Html.HtmlTemplate

        Private notificationMessageTemplate1 As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

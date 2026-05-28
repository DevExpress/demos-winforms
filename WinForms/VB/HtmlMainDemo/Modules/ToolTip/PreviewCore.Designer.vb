Namespace DevExpress.HTML.Demos

    Partial Class PreviewCore

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.PreviewCore))
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.templateViewerField = New DevExpress.HTML.Demos.ToolTipTemplateViewer()
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            Me.bottomPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            Me.propertiesPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.previewCoreProperties1 = New DevExpress.HTML.Demos.PreviewCoreControllerProperties()
            Me.hostToolTipField = New DevExpress.XtraEditors.XtraUserControl()
            Me.htmlImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.sidePanel1.SuspendLayout()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bottomPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bottomPanel.SuspendLayout()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.propertiesPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.propertiesPanel.SuspendLayout()
            CType((Me.htmlImageCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.labelControl1)
            Me.sidePanel1.Controls.Add(Me.templateViewerField)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(269, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(450, 467)
            Me.sidePanel1.TabIndex = 0
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
            Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(5)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(0, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Visible = False
            ' 
            ' templateViewer
            ' 
            Me.templateViewerField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateViewerField.Location = New System.Drawing.Point(1, 0)
            Me.templateViewerField.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.templateViewerField.Name = "templateViewer"
            Me.templateViewerField.Size = New System.Drawing.Size(449, 467)
            Me.templateViewerField.TabIndex = 0
            ' 
            ' htmlContentControl1
            ' 
            Me.bottomPanel.SetColumn(Me.htmlContentControl1, 1)
            Me.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles")
            Me.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template")
            Me.htmlContentControl1.Location = New System.Drawing.Point(77, 2)
            Me.htmlContentControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.htmlContentControl1.Name = "htmlContentControl1"
            Me.bottomPanel.SetRow(Me.htmlContentControl1, 0)
            Me.htmlContentControl1.Size = New System.Drawing.Size(116, 66)
            Me.htmlContentControl1.TabIndex = 1
            Me.htmlContentControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' bottomPanel
            ' 
            Me.bottomPanel.AutoSize = True
            Me.bottomPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 120F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.bottomPanel.Controls.Add(Me.htmlContentControl1)
            Me.bottomPanel.Controls.Add(Me.separatorControl1)
            Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bottomPanel.Location = New System.Drawing.Point(0, 204)
            Me.bottomPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.bottomPanel.Name = "bottomPanel"
            Me.bottomPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.bottomPanel.Size = New System.Drawing.Size(269, 101)
            Me.bottomPanel.TabIndex = 1
            ' 
            ' separatorControl1
            ' 
            Me.bottomPanel.SetColumn(Me.separatorControl1, 0)
            Me.bottomPanel.SetColumnSpan(Me.separatorControl1, 3)
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.separatorControl1.Location = New System.Drawing.Point(0, 100)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.bottomPanel.SetRow(Me.separatorControl1, 2)
            Me.separatorControl1.Size = New System.Drawing.Size(270, 1)
            Me.separatorControl1.TabIndex = 1
            ' 
            ' propertiesPanel
            ' 
            Me.propertiesPanel.AutoSize = True
            Me.propertiesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.propertiesPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.propertiesPanel.Controls.Add(Me.previewCoreProperties1)
            Me.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.propertiesPanel.Location = New System.Drawing.Point(0, 305)
            Me.propertiesPanel.Margin = New System.Windows.Forms.Padding(2)
            Me.propertiesPanel.MinimumSize = New System.Drawing.Size(0, 100)
            Me.propertiesPanel.Name = "propertiesPanel"
            Me.propertiesPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.propertiesPanel.Size = New System.Drawing.Size(269, 162)
            Me.propertiesPanel.TabIndex = 3
            ' 
            ' previewCoreProperties1
            ' 
            Me.previewCoreProperties1.AutoSize = True
            Me.previewCoreProperties1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.propertiesPanel.SetColumn(Me.previewCoreProperties1, 1)
            Me.previewCoreProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewCoreProperties1.Location = New System.Drawing.Point(139, 4)
            Me.previewCoreProperties1.Margin = New System.Windows.Forms.Padding(4)
            Me.previewCoreProperties1.Name = "previewCoreProperties1"
            Me.propertiesPanel.SetRow(Me.previewCoreProperties1, 0)
            Me.previewCoreProperties1.Size = New System.Drawing.Size(127, 154)
            Me.previewCoreProperties1.TabIndex = 0
            ' 
            ' hostToolTip
            ' 
            Me.hostToolTipField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hostToolTipField.Location = New System.Drawing.Point(0, 0)
            Me.hostToolTipField.Margin = New System.Windows.Forms.Padding(0)
            Me.hostToolTipField.Name = "hostToolTip"
            Me.hostToolTipField.Size = New System.Drawing.Size(269, 204)
            Me.hostToolTipField.TabIndex = 0
            ' 
            ' PreviewCore
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.hostToolTipField)
            Me.Controls.Add(Me.bottomPanel)
            Me.Controls.Add(Me.propertiesPanel)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "PreviewCore"
            Me.Size = New System.Drawing.Size(719, 467)
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel1.PerformLayout()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bottomPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.bottomPanel.ResumeLayout(False)
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.propertiesPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.propertiesPanel.ResumeLayout(False)
            Me.propertiesPanel.PerformLayout()
            CType((Me.htmlImageCollection), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private hostToolTipField As DevExpress.XtraEditors.XtraUserControl

        Private templateViewerField As DevExpress.HTML.Demos.ToolTipTemplateViewer

        Private bottomPanel As DevExpress.Utils.Layout.TablePanel

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private propertiesPanel As DevExpress.Utils.Layout.TablePanel

        Private previewCoreProperties1 As DevExpress.HTML.Demos.PreviewCoreControllerProperties

        Private htmlImageCollection As DevExpress.Utils.SvgImageCollection

        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl
    End Class
End Namespace

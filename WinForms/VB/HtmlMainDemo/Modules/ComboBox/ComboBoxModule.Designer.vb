Namespace DevExpress.HTML.Demos

    Partial Class ComboBoxModule

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.ComboBoxModule))
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.comboBoxTemplateViewer1 = New DevExpress.HTML.Demos.ComboBoxTemplateViewer()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.comboBoxTemplateViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(410, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(642, 494)
            Me.sidePanel1.TabIndex = 0
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' comboBoxTemplateViewer1
            ' 
            Me.comboBoxTemplateViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBoxTemplateViewer1.Location = New System.Drawing.Point(1, 0)
            Me.comboBoxTemplateViewer1.Name = "comboBoxTemplateViewer1"
            Me.comboBoxTemplateViewer1.Size = New System.Drawing.Size(641, 494)
            Me.comboBoxTemplateViewer1.TabIndex = 0
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 300F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel1.Controls.Add(Me.groupControl1)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)})
            Me.tablePanel1.Size = New System.Drawing.Size(410, 494)
            Me.tablePanel1.TabIndex = 1
            ' 
            ' groupControl1
            ' 
            Me.tablePanel1.SetColumn(Me.groupControl1, 1)
            Me.groupControl1.Controls.Add(Me.comboBoxEdit1)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupControl1.Location = New System.Drawing.Point(58, 77)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Padding = New System.Windows.Forms.Padding(10, 70, 10, 15)
            Me.tablePanel1.SetRow(Me.groupControl1, 1)
            Me.groupControl1.Size = New System.Drawing.Size(294, 194)
            Me.groupControl1.TabIndex = 0
            Me.groupControl1.Text = "Sample"
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBoxEdit1.Location = New System.Drawing.Point(12, 93)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.DropDownItemHeight = 72
            Me.comboBoxEdit1.Properties.DropDownRows = 5
            Me.comboBoxEdit1.Properties.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.htmlTemplate1})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(270, 20)
            Me.comboBoxEdit1.TabIndex = 0
            ' 
            ' htmlTemplate1
            ' 
            Me.htmlTemplate1.Name = "htmlTemplate1"
            Me.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles")
            Me.htmlTemplate1.Tag = "Item Template"
            Me.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template")
            ' 
            ' ComboBoxModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ComboBoxModule"
            Me.Size = New System.Drawing.Size(1052, 494)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private comboBoxTemplateViewer1 As DevExpress.HTML.Demos.ComboBoxTemplateViewer

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit

        Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

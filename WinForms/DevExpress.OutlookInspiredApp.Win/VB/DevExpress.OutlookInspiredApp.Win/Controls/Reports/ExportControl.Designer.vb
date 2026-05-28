Namespace DevExpress.DevAV

    Partial Class ReportExportControl

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
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.btnExport = New DevExpress.XtraEditors.DropDownButton()
            Me.settingsPanel = New DevExpress.DevAV.SettingPanel()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.captionLabelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.ItemForSettings = New DevExpress.XtraLayout.LayoutControlItem()
            Me.separator = New DevExpress.XtraLayout.SimpleSeparator()
            Me.ItemForButtonExport = New DevExpress.XtraLayout.LayoutControlItem()
            Me.buttonLabelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.captionLabelItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForSettings), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForButtonExport), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonLabelItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.btnExport)
            Me.moduleLayout.Controls.Add(Me.settingsPanel)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup1
            Me.moduleLayout.Size = New System.Drawing.Size(310, 600)
            Me.moduleLayout.TabIndex = 4
            Me.btnExport.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnExport.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-export-40.png"
            Me.btnExport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnExport.Location = New System.Drawing.Point(40, 89)
            Me.btnExport.MaximumSize = New System.Drawing.Size(75, 75)
            Me.btnExport.MinimumSize = New System.Drawing.Size(75, 75)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(75, 75)
            Me.btnExport.StyleController = Me.moduleLayout
            Me.btnExport.TabIndex = 1
            Me.btnExport.Text = "Export"
            AddHandler Me.btnExport.Click, New System.EventHandler(AddressOf Me.btnExport_Click)
            Me.settingsPanel.Location = New System.Drawing.Point(40, 215)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(228, 345)
            Me.settingsPanel.TabIndex = 4
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.captionLabelItem, Me.ItemForSettings, Me.separator, Me.ItemForButtonExport, Me.buttonLabelItem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(310, 600)
            Me.captionLabelItem.AllowHotTrack = False
            Me.captionLabelItem.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.captionLabelItem.AppearanceItemCaption.Options.UseFont = True
            Me.captionLabelItem.CustomizationFormText = "Export"
            Me.captionLabelItem.Location = New System.Drawing.Point(0, 0)
            Me.captionLabelItem.Name = "captionLabelItem"
            Me.captionLabelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24)
            Me.captionLabelItem.Size = New System.Drawing.Size(228, 89)
            Me.captionLabelItem.Text = "Export"
            Me.captionLabelItem.TextSize = New System.Drawing.Size(138, 65)
            Me.ItemForSettings.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.ItemForSettings.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForSettings.Control = Me.settingsPanel
            Me.ItemForSettings.CustomizationFormText = "Settings"
            Me.ItemForSettings.Location = New System.Drawing.Point(0, 164)
            Me.ItemForSettings.Name = "ItemForSettings"
            Me.ItemForSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0)
            Me.ItemForSettings.Size = New System.Drawing.Size(228, 396)
            Me.ItemForSettings.Text = "Settings"
            Me.ItemForSettings.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForSettings.TextSize = New System.Drawing.Size(138, 32)
            Me.separator.AllowHotTrack = False
            Me.separator.CustomizationFormText = "separator"
            Me.separator.Location = New System.Drawing.Point(228, 0)
            Me.separator.Name = "separator"
            Me.separator.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.separator.Size = New System.Drawing.Size(42, 560)
            Me.separator.Spacing = New DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 0)
            Me.ItemForButtonExport.Control = Me.btnExport
            Me.ItemForButtonExport.CustomizationFormText = "ItemForButtonExport"
            Me.ItemForButtonExport.Location = New System.Drawing.Point(0, 89)
            Me.ItemForButtonExport.Name = "ItemForButtonExport"
            Me.ItemForButtonExport.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForButtonExport.Size = New System.Drawing.Size(75, 75)
            Me.ItemForButtonExport.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForButtonExport.TextVisible = False
            Me.buttonLabelItem.AllowHotTrack = False
            Me.buttonLabelItem.AllowHtmlStringInCaption = True
            Me.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = True
            Me.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.buttonLabelItem.CustomizationFormText = "Specify how you want<br>the report to be printed"
            Me.buttonLabelItem.Location = New System.Drawing.Point(75, 89)
            Me.buttonLabelItem.Name = "buttonLabelItem"
            Me.buttonLabelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0)
            Me.buttonLabelItem.Size = New System.Drawing.Size(153, 75)
            Me.buttonLabelItem.Text = "The DevExpress Reporting<br>platform allows you to<br>export any report to<br>PDF" & ", XLS, RTF and countless<br>image file formats."
            Me.buttonLabelItem.TextSize = New System.Drawing.Size(138, 65)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "ReportExportControl"
            Me.Size = New System.Drawing.Size(310, 600)
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.captionLabelItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForSettings), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForButtonExport), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonLabelItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private settingsPanel As DevExpress.DevAV.SettingPanel

        Private btnExport As DevExpress.XtraEditors.DropDownButton

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private captionLabelItem As DevExpress.XtraLayout.SimpleLabelItem

        Private buttonLabelItem As DevExpress.XtraLayout.SimpleLabelItem

        Private ItemForSettings As DevExpress.XtraLayout.LayoutControlItem

        Private separator As DevExpress.XtraLayout.SimpleSeparator

        Private ItemForButtonExport As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

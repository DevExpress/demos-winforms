Namespace DevExpress.XtraScheduler.Demos

    Partial Class ExportControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.ExportControl))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnExportViaReporting = New DevExpress.XtraEditors.DropDownButton()
            Me.btnExportViaiCalendar = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.buttonLabelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.buttonLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonLabelItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnExportViaReporting)
            Me.layoutControl1.Controls.Add(Me.btnExportViaiCalendar)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(803, 232, 744, 540)
            Me.layoutControl1.OptionsView.ControlDefaultMaxSizeCalcMode = DevExpress.XtraLayout.ControlMaxSizeCalcMode.UseControlMaximumSizeIfNotZero
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(307, 595)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnExportViaReporting
            ' 
            Me.btnExportViaReporting.Appearance.Options.UseTextOptions = True
            Me.btnExportViaReporting.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.btnExportViaReporting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.btnExportViaReporting.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnExportViaReporting.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Export
            Me.btnExportViaReporting.Location = New System.Drawing.Point(40, 184)
            Me.btnExportViaReporting.MaximumSize = New System.Drawing.Size(75, 75)
            Me.btnExportViaReporting.MinimumSize = New System.Drawing.Size(75, 75)
            Me.btnExportViaReporting.Name = "btnExportViaReporting"
            Me.btnExportViaReporting.Size = New System.Drawing.Size(75, 75)
            Me.btnExportViaReporting.StyleController = Me.layoutControl1
            Me.btnExportViaReporting.TabIndex = 5
            AddHandler Me.btnExportViaReporting.Click, New System.EventHandler(AddressOf Me.btnExportViaReporting_Click)
            ' 
            ' btnExportViaiCalendar
            ' 
            Me.btnExportViaiCalendar.Appearance.Options.UseTextOptions = True
            Me.btnExportViaiCalendar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.btnExportViaiCalendar.ImageOptions.Image = CType((resources.GetObject("btnExportViaiCalendar.ImageOptions.Image")), System.Drawing.Image)
            Me.btnExportViaiCalendar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnExportViaiCalendar.Location = New System.Drawing.Point(40, 89)
            Me.btnExportViaiCalendar.MaximumSize = New System.Drawing.Size(75, 75)
            Me.btnExportViaiCalendar.MinimumSize = New System.Drawing.Size(75, 75)
            Me.btnExportViaiCalendar.Name = "btnExportViaiCalendar"
            Me.btnExportViaiCalendar.Size = New System.Drawing.Size(75, 75)
            Me.btnExportViaiCalendar.StyleController = Me.layoutControl1
            Me.btnExportViaiCalendar.TabIndex = 4
            Me.btnExportViaiCalendar.Text = "Export To iCalendar"
            AddHandler Me.btnExportViaiCalendar.Click, New System.EventHandler(AddressOf Me.OnBtnExportViaiCalendarClick)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.simpleLabelItem1, Me.buttonLabelItem, Me.layoutControlItem1, Me.buttonLabelItem1, Me.emptySpaceItem2, Me.layoutControlItem2, Me.emptySpaceItem1, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(307, 595)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 36F)
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem1.MinSize = New System.Drawing.Size(1, 89)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24)
            Me.simpleLabelItem1.Size = New System.Drawing.Size(250, 89)
            Me.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.simpleLabelItem1.Text = "Export"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(224, 65)
            ' 
            ' buttonLabelItem
            ' 
            Me.buttonLabelItem.AllowHtmlStringInCaption = True
            Me.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = True
            Me.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.buttonLabelItem.CustomizationFormText = "Export appointments to an iCalendar (.ics) file."
            Me.buttonLabelItem.Location = New System.Drawing.Point(75, 89)
            Me.buttonLabelItem.MinSize = New System.Drawing.Size(1, 13)
            Me.buttonLabelItem.Name = "buttonLabelItem"
            Me.buttonLabelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0)
            Me.buttonLabelItem.Size = New System.Drawing.Size(175, 75)
            Me.buttonLabelItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.buttonLabelItem.StartNewLine = True
            Me.buttonLabelItem.Text = "Export appointments to an iCalendar (.ics) file."
            Me.buttonLabelItem.TextSize = New System.Drawing.Size(224, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnExportViaiCalendar
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 89)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(75, 75)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(75, 75)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(75, 75)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' buttonLabelItem1
            ' 
            Me.buttonLabelItem1.AllowHtmlStringInCaption = True
            Me.buttonLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.buttonLabelItem1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.buttonLabelItem1.CustomizationFormText = "Specify how you want<br>the report to be printed"
            Me.buttonLabelItem1.Location = New System.Drawing.Point(75, 184)
            Me.buttonLabelItem1.MinSize = New System.Drawing.Size(1, 13)
            Me.buttonLabelItem1.Name = "buttonLabelItem1"
            Me.buttonLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0)
            Me.buttonLabelItem1.Size = New System.Drawing.Size(175, 75)
            Me.buttonLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.buttonLabelItem1.StartNewLine = True
            Me.buttonLabelItem1.Text = "The DevExpress Reporting<br>platform allows you to<br>export any report to<br>PDF" & ", XLS, RTF and multiple<br>image file formats."
            Me.buttonLabelItem1.TextSize = New System.Drawing.Size(224, 65)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 259)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(250, 296)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.btnExportViaReporting
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 184)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(75, 75)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(250, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(17, 555)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 164)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(250, 20)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(250, 20)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(250, 20)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ExportControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ExportControl"
            Me.Size = New System.Drawing.Size(307, 595)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonLabelItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private btnExportViaiCalendar As DevExpress.XtraEditors.SimpleButton

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private buttonLabelItem As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private btnExportViaReporting As DevExpress.XtraEditors.DropDownButton

        Private buttonLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

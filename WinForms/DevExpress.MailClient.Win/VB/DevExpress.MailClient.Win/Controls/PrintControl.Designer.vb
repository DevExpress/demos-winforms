Imports DevExpress.XtraBars.Ribbon
Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class PrintControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PrintControl))
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.pnlControl = New System.Windows.Forms.Panel()
            Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.zoomTextEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.pageButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ddbPrintStyle = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbDuplex = New DevExpress.XtraEditors.DropDownButton()
            Me.printerLabel = New DevExpress.MailClient.Win.Controls.BackstageViewLabel()
            Me.ddbPrinter = New DevExpress.XtraEditors.DropDownButton()
            Me.copySpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.printButton = New DevExpress.XtraEditors.SimpleButton()
            Me.backstageViewLabel1 = New DevExpress.MailClient.Win.Controls.BackstageViewLabel()
            Me.backstageViewLabel2 = New DevExpress.MailClient.Win.Controls.BackstageViewLabel()
            Me.ddbOrientation = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbPaperSize = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbMargins = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbCollate = New DevExpress.XtraEditors.DropDownButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciPrintButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciOrientation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciMargins = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPaperSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrintLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCopiesSpinEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciSettingsLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrinterLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrinter = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDuplex = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCollated = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrintStyle = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.pnlControl.SuspendLayout()
            Me.panel1.SuspendLayout()
            DirectCast(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPrintButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciMargins, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPaperSize, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPrintLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciSettingsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPrinterLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciDuplex, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciCollated, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciPrintStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            resources.ApplyResources(Me.splitContainer1, "splitContainer1")
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.layoutControl1)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.pnlControl)
            Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
            resources.ApplyResources(Me.splitContainer1.Panel2, "splitContainer1.Panel2")
            ' 
            ' pnlControl
            ' 
            Me.pnlControl.Controls.Add(Me.printControl1)
            Me.pnlControl.Controls.Add(Me.panel1)
            resources.ApplyResources(Me.pnlControl, "pnlControl")
            Me.pnlControl.Name = "pnlControl"
            ' 
            ' printControl1
            ' 
            resources.ApplyResources(Me.printControl1, "printControl1")
            Me.printControl1.Name = "printControl1"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.zoomTextEdit)
            Me.panel1.Controls.Add(Me.pageButtonEdit)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.zoomTrackBarControl1)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            ' 
            ' zoomTextEdit
            ' 
            resources.ApplyResources(Me.zoomTextEdit, "zoomTextEdit")
            Me.zoomTextEdit.Name = "zoomTextEdit"
            Me.zoomTextEdit.Properties.DisplayFormat.FormatString = "{0}%"
            Me.zoomTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.zoomTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.zoomTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.zoomTextEdit.Properties.IsFloatValue = False
            Me.zoomTextEdit.Properties.Mask.EditMask = resources.GetString("zoomTextEdit.Properties.Mask.EditMask")
            Me.zoomTextEdit.Properties.MaxValue = New Decimal(New Integer() { 500, 0, 0, 0})
            Me.zoomTextEdit.Properties.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
            ' 
            ' pageButtonEdit
            ' 
            resources.ApplyResources(Me.pageButtonEdit, "pageButtonEdit")
            Me.pageButtonEdit.Name = "pageButtonEdit"
            Me.pageButtonEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.pageButtonEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.pageButtonEdit.Properties.AutoHeight = (DirectCast(resources.GetObject("pageButtonEdit.Properties.AutoHeight"), Boolean))
            Me.pageButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
                New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)), resources.GetString("pageButtonEdit.Properties.Buttons1"), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons2"), Integer)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons3"), Boolean)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons4"), Boolean)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons5"), Boolean)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons6"), DevExpress.XtraEditors.ImageLocation)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons7"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, resources.GetString("pageButtonEdit.Properties.Buttons8"), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons9"), Object)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons10"), DevExpress.Utils.SuperToolTip)), (DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons11"), Boolean))),
                New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("pageButtonEdit.Properties.Buttons12"), DevExpress.XtraEditors.Controls.ButtonPredefines)))
            })
            Me.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0}"
            Me.pageButtonEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' panel2
            ' 
            resources.ApplyResources(Me.panel2, "panel2")
            Me.panel2.Name = "panel2"
            ' 
            ' zoomTrackBarControl1
            ' 
            resources.ApplyResources(Me.zoomTrackBarControl1, "zoomTrackBarControl1")
            Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
            Me.zoomTrackBarControl1.Properties.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.zoomTrackBarControl1.Properties.Maximum = 80
            Me.zoomTrackBarControl1.Properties.Middle = 5
            Me.zoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.zoomTrackBarControl1.Properties.SmallChange = 2
            Me.zoomTrackBarControl1.Value = 40
            ' 
            ' labelControl4
            ' 
            resources.ApplyResources(Me.labelControl4, "labelControl4")
            Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
            Me.labelControl4.LineVisible = True
            Me.labelControl4.Name = "labelControl4"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.ddbPrintStyle)
            Me.layoutControl1.Controls.Add(Me.ddbDuplex)
            Me.layoutControl1.Controls.Add(Me.printerLabel)
            Me.layoutControl1.Controls.Add(Me.ddbPrinter)
            Me.layoutControl1.Controls.Add(Me.copySpinEdit)
            Me.layoutControl1.Controls.Add(Me.printButton)
            Me.layoutControl1.Controls.Add(Me.backstageViewLabel1)
            Me.layoutControl1.Controls.Add(Me.backstageViewLabel2)
            Me.layoutControl1.Controls.Add(Me.ddbOrientation)
            Me.layoutControl1.Controls.Add(Me.ddbPaperSize)
            Me.layoutControl1.Controls.Add(Me.ddbMargins)
            Me.layoutControl1.Controls.Add(Me.ddbCollate)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(532, 478, 648, 350)
            'this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ddbPrintStyle
            ' 
            Me.ddbPrintStyle.Appearance.Font = (DirectCast(resources.GetObject("ddbPrintStyle.Appearance.Font"), System.Drawing.Font))
            Me.ddbPrintStyle.Appearance.Options.UseFont = True
            Me.ddbPrintStyle.Appearance.Options.UseTextOptions = True
            Me.ddbPrintStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbPrintStyle.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbPrintStyle, "ddbPrintStyle")
            Me.ddbPrintStyle.Name = "ddbPrintStyle"
            Me.ddbPrintStyle.StyleController = Me.layoutControl1
            ' 
            ' ddbDuplex
            ' 
            Me.ddbDuplex.Appearance.Options.UseTextOptions = True
            Me.ddbDuplex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbDuplex.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbDuplex, "ddbDuplex")
            Me.ddbDuplex.Name = "ddbDuplex"
            Me.ddbDuplex.StyleController = Me.layoutControl1
            ' 
            ' printerLabel
            ' 
            Me.printerLabel.Appearance.Font = (DirectCast(resources.GetObject("printerLabel.Appearance.Font"), System.Drawing.Font))
            resources.ApplyResources(Me.printerLabel, "printerLabel")
            Me.printerLabel.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.printerLabel.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.printerLabel.LineVisible = True
            Me.printerLabel.Name = "printerLabel"
            Me.printerLabel.ShowLineShadow = False
            Me.printerLabel.StyleController = Me.layoutControl1
            ' 
            ' ddbPrinter
            ' 
            Me.ddbPrinter.Appearance.Options.UseTextOptions = True
            Me.ddbPrinter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbPrinter.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbPrinter, "ddbPrinter")
            Me.ddbPrinter.Name = "ddbPrinter"
            Me.ddbPrinter.StyleController = Me.layoutControl1
            ' 
            ' copySpinEdit
            ' 
            resources.ApplyResources(Me.copySpinEdit, "copySpinEdit")
            Me.copySpinEdit.Name = "copySpinEdit"
            Me.copySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.copySpinEdit.Properties.IsFloatValue = False
            Me.copySpinEdit.Properties.Mask.EditMask = resources.GetString("copySpinEdit.Properties.Mask.EditMask")
            Me.copySpinEdit.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
            Me.copySpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.copySpinEdit.StyleController = Me.layoutControl1
            ' 
            ' printButton
            ' 
            Me.printButton.Image = My.Resources.PrintDirectLarge
            Me.printButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            resources.ApplyResources(Me.printButton, "printButton")
            Me.printButton.Name = "printButton"
            Me.printButton.StyleController = Me.layoutControl1
            ' 
            ' backstageViewLabel1
            ' 
            Me.backstageViewLabel1.Appearance.Font = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.Font"), System.Drawing.Font))
            resources.ApplyResources(Me.backstageViewLabel1, "backstageViewLabel1")
            Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.backstageViewLabel1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.backstageViewLabel1.LineVisible = True
            Me.backstageViewLabel1.Name = "backstageViewLabel1"
            Me.backstageViewLabel1.ShowLineShadow = False
            Me.backstageViewLabel1.StyleController = Me.layoutControl1
            ' 
            ' backstageViewLabel2
            ' 
            Me.backstageViewLabel2.Appearance.Font = (DirectCast(resources.GetObject("backstageViewLabel2.Appearance.Font"), System.Drawing.Font))
            resources.ApplyResources(Me.backstageViewLabel2, "backstageViewLabel2")
            Me.backstageViewLabel2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.backstageViewLabel2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.backstageViewLabel2.LineVisible = True
            Me.backstageViewLabel2.Name = "backstageViewLabel2"
            Me.backstageViewLabel2.ShowLineShadow = False
            Me.backstageViewLabel2.StyleController = Me.layoutControl1
            ' 
            ' ddbOrientation
            ' 
            Me.ddbOrientation.Appearance.Options.UseTextOptions = True
            Me.ddbOrientation.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbOrientation.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbOrientation, "ddbOrientation")
            Me.ddbOrientation.Name = "ddbOrientation"
            Me.ddbOrientation.StyleController = Me.layoutControl1
            ' 
            ' ddbPaperSize
            ' 
            Me.ddbPaperSize.Appearance.Options.UseTextOptions = True
            Me.ddbPaperSize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbPaperSize.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbPaperSize, "ddbPaperSize")
            Me.ddbPaperSize.Name = "ddbPaperSize"
            Me.ddbPaperSize.StyleController = Me.layoutControl1
            ' 
            ' ddbMargins
            ' 
            Me.ddbMargins.Appearance.Options.UseTextOptions = True
            Me.ddbMargins.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbMargins.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbMargins, "ddbMargins")
            Me.ddbMargins.Name = "ddbMargins"
            Me.ddbMargins.StyleController = Me.layoutControl1
            ' 
            ' ddbCollate
            ' 
            Me.ddbCollate.Appearance.Options.UseTextOptions = True
            Me.ddbCollate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbCollate.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            resources.ApplyResources(Me.ddbCollate, "ddbCollate")
            Me.ddbCollate.Name = "ddbCollate"
            Me.ddbCollate.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPrintButton, Me.lciOrientation, Me.lciMargins, Me.lciPaperSize, Me.lciPrintLabel, Me.lciCopiesSpinEdit, Me.emptySpaceItem1, Me.lciSettingsLabel, Me.lciPrinterLabel, Me.lciPrinter, Me.lciDuplex, Me.lciCollated, Me.lciPrintStyle})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(520, 679)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciPrintButton
            ' 
            Me.lciPrintButton.Control = Me.printButton
            resources.ApplyResources(Me.lciPrintButton, "lciPrintButton")
            Me.lciPrintButton.Location = New System.Drawing.Point(416, 0)
            Me.lciPrintButton.MaxSize = New System.Drawing.Size(84, 80)
            Me.lciPrintButton.MinSize = New System.Drawing.Size(84, 80)
            Me.lciPrintButton.Name = "lciPrintButton"
            Me.lciPrintButton.Size = New System.Drawing.Size(84, 80)
            Me.lciPrintButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPrintButton.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPrintButton.TextVisible = False
            ' 
            ' lciOrientation
            ' 
            Me.lciOrientation.Control = Me.ddbOrientation
            resources.ApplyResources(Me.lciOrientation, "lciOrientation")
            Me.lciOrientation.Location = New System.Drawing.Point(0, 320)
            Me.lciOrientation.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciOrientation.MinSize = New System.Drawing.Size(100, 56)
            Me.lciOrientation.Name = "lciOrientation"
            Me.lciOrientation.Size = New System.Drawing.Size(500, 56)
            Me.lciOrientation.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciOrientation.TextSize = New System.Drawing.Size(0, 0)
            Me.lciOrientation.TextVisible = False
            ' 
            ' lciMargins
            ' 
            Me.lciMargins.Control = Me.ddbMargins
            resources.ApplyResources(Me.lciMargins, "lciMargins")
            Me.lciMargins.Location = New System.Drawing.Point(0, 376)
            Me.lciMargins.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciMargins.MinSize = New System.Drawing.Size(100, 56)
            Me.lciMargins.Name = "lciMargins"
            Me.lciMargins.Size = New System.Drawing.Size(500, 56)
            Me.lciMargins.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciMargins.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMargins.TextVisible = False
            ' 
            ' lciPaperSize
            ' 
            Me.lciPaperSize.Control = Me.ddbPaperSize
            resources.ApplyResources(Me.lciPaperSize, "lciPaperSize")
            Me.lciPaperSize.Location = New System.Drawing.Point(0, 432)
            Me.lciPaperSize.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciPaperSize.MinSize = New System.Drawing.Size(100, 56)
            Me.lciPaperSize.Name = "lciPaperSize"
            Me.lciPaperSize.Size = New System.Drawing.Size(500, 56)
            Me.lciPaperSize.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPaperSize.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPaperSize.TextVisible = False
            ' 
            ' lciPrintLabel
            ' 
            Me.lciPrintLabel.Control = Me.backstageViewLabel1
            resources.ApplyResources(Me.lciPrintLabel, "lciPrintLabel")
            Me.lciPrintLabel.Location = New System.Drawing.Point(0, 0)
            Me.lciPrintLabel.MaxSize = New System.Drawing.Size(0, 36)
            Me.lciPrintLabel.MinSize = New System.Drawing.Size(14, 36)
            Me.lciPrintLabel.Name = "lciPrintLabel"
            Me.lciPrintLabel.Size = New System.Drawing.Size(416, 36)
            Me.lciPrintLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPrintLabel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPrintLabel.TextVisible = False
            ' 
            ' lciCopiesSpinEdit
            ' 
            Me.lciCopiesSpinEdit.Control = Me.copySpinEdit
            resources.ApplyResources(Me.lciCopiesSpinEdit, "lciCopiesSpinEdit")
            Me.lciCopiesSpinEdit.Location = New System.Drawing.Point(236, 36)
            Me.lciCopiesSpinEdit.MaxSize = New System.Drawing.Size(180, 24)
            Me.lciCopiesSpinEdit.MinSize = New System.Drawing.Size(180, 24)
            Me.lciCopiesSpinEdit.Name = "lciCopiesSpinEdit"
            Me.lciCopiesSpinEdit.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 2)
            Me.lciCopiesSpinEdit.Size = New System.Drawing.Size(180, 44)
            Me.lciCopiesSpinEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciCopiesSpinEdit.TextSize = New System.Drawing.Size(36, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 36)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(236, 44)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciSettingsLabel
            ' 
            Me.lciSettingsLabel.Control = Me.backstageViewLabel2
            resources.ApplyResources(Me.lciSettingsLabel, "lciSettingsLabel")
            Me.lciSettingsLabel.Location = New System.Drawing.Point(0, 172)
            Me.lciSettingsLabel.MaxSize = New System.Drawing.Size(0, 36)
            Me.lciSettingsLabel.MinSize = New System.Drawing.Size(14, 36)
            Me.lciSettingsLabel.Name = "lciSettingsLabel"
            Me.lciSettingsLabel.Size = New System.Drawing.Size(500, 36)
            Me.lciSettingsLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciSettingsLabel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciSettingsLabel.TextVisible = False
            ' 
            ' lciPrinterLabel
            ' 
            Me.lciPrinterLabel.Control = Me.printerLabel
            resources.ApplyResources(Me.lciPrinterLabel, "lciPrinterLabel")
            Me.lciPrinterLabel.Location = New System.Drawing.Point(0, 80)
            Me.lciPrinterLabel.MaxSize = New System.Drawing.Size(0, 36)
            Me.lciPrinterLabel.MinSize = New System.Drawing.Size(14, 36)
            Me.lciPrinterLabel.Name = "lciPrinterLabel"
            Me.lciPrinterLabel.Size = New System.Drawing.Size(500, 36)
            Me.lciPrinterLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPrinterLabel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPrinterLabel.TextVisible = False
            ' 
            ' lciPrinter
            ' 
            Me.lciPrinter.Control = Me.ddbPrinter
            resources.ApplyResources(Me.lciPrinter, "lciPrinter")
            Me.lciPrinter.Location = New System.Drawing.Point(0, 116)
            Me.lciPrinter.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciPrinter.MinSize = New System.Drawing.Size(100, 56)
            Me.lciPrinter.Name = "lciPrinter"
            Me.lciPrinter.Size = New System.Drawing.Size(500, 56)
            Me.lciPrinter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPrinter.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPrinter.TextVisible = False
            ' 
            ' lciDuplex
            ' 
            Me.lciDuplex.Control = Me.ddbDuplex
            resources.ApplyResources(Me.lciDuplex, "lciDuplex")
            Me.lciDuplex.Location = New System.Drawing.Point(0, 208)
            Me.lciDuplex.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciDuplex.MinSize = New System.Drawing.Size(68, 56)
            Me.lciDuplex.Name = "lciDuplex"
            Me.lciDuplex.Size = New System.Drawing.Size(500, 56)
            Me.lciDuplex.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciDuplex.TextSize = New System.Drawing.Size(0, 0)
            Me.lciDuplex.TextVisible = False
            ' 
            ' lciCollated
            ' 
            Me.lciCollated.Control = Me.ddbCollate
            resources.ApplyResources(Me.lciCollated, "lciCollated")
            Me.lciCollated.Location = New System.Drawing.Point(0, 264)
            Me.lciCollated.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciCollated.MinSize = New System.Drawing.Size(100, 56)
            Me.lciCollated.Name = "lciCollated"
            Me.lciCollated.Size = New System.Drawing.Size(500, 56)
            Me.lciCollated.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciCollated.TextSize = New System.Drawing.Size(0, 0)
            Me.lciCollated.TextVisible = False
            ' 
            ' lciPrintStyle
            ' 
            Me.lciPrintStyle.Control = Me.ddbPrintStyle
            resources.ApplyResources(Me.lciPrintStyle, "lciPrintStyle")
            Me.lciPrintStyle.Location = New System.Drawing.Point(0, 488)
            Me.lciPrintStyle.MaxSize = New System.Drawing.Size(0, 56)
            Me.lciPrintStyle.MinSize = New System.Drawing.Size(79, 26)
            Me.lciPrintStyle.Name = "lciPrintStyle"
            Me.lciPrintStyle.Size = New System.Drawing.Size(500, 171)
            Me.lciPrintStyle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPrintStyle.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPrintStyle.TextVisible = False
            ' 
            ' PrintControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "PrintControl"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            Me.pnlControl.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            DirectCast(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPrintButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciMargins, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPaperSize, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPrintLabel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciSettingsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPrinterLabel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPrinter, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciDuplex, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciCollated, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciPrintStyle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private WithEvents printControl1 As DevExpress.XtraPrinting.Control.PrintControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl
        Private panel2 As System.Windows.Forms.Panel
        Private WithEvents pageButtonEdit As DevExpress.XtraEditors.ButtonEdit
        Private ddbOrientation As DevExpress.XtraEditors.DropDownButton
        Private ddbCollate As DevExpress.XtraEditors.DropDownButton
        Private ddbPaperSize As DevExpress.XtraEditors.DropDownButton
        Private ddbMargins As DevExpress.XtraEditors.DropDownButton
        Private WithEvents printButton As DevExpress.XtraEditors.SimpleButton
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private backstageViewLabel1 As BackstageViewLabel
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciPrintButton As DevExpress.XtraLayout.LayoutControlItem
        Private lciOrientation As DevExpress.XtraLayout.LayoutControlItem
        Private lciMargins As DevExpress.XtraLayout.LayoutControlItem
        Private lciPaperSize As DevExpress.XtraLayout.LayoutControlItem
        Private lciCollated As DevExpress.XtraLayout.LayoutControlItem
        Private lciPrintLabel As DevExpress.XtraLayout.LayoutControlItem
        Private copySpinEdit As DevExpress.XtraEditors.SpinEdit
        Private lciCopiesSpinEdit As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private backstageViewLabel2 As BackstageViewLabel
        Private lciSettingsLabel As DevExpress.XtraLayout.LayoutControlItem
        Private printerLabel As BackstageViewLabel
        Private ddbPrinter As DevExpress.XtraEditors.DropDownButton
        Private lciPrinterLabel As DevExpress.XtraLayout.LayoutControlItem
        Private lciPrinter As DevExpress.XtraLayout.LayoutControlItem
        Private ddbDuplex As DevExpress.XtraEditors.DropDownButton
        Private lciDuplex As DevExpress.XtraLayout.LayoutControlItem
        Private pnlControl As System.Windows.Forms.Panel
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
        Private WithEvents zoomTextEdit As DevExpress.XtraEditors.SpinEdit
        Private ddbPrintStyle As DevExpress.XtraEditors.DropDownButton
        Private lciPrintStyle As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

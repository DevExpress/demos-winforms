Namespace DevExpress.ApplicationUI.Demos

    Partial Class AlertControlTutorial

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.AlertControlTutorial))
            Dim alertButton1 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton2 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton3 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton4 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Me.sePostponedFormCount = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.ceHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.ceWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.alertInfoProperties1 = New DevExpress.ApplicationUI.Demos.AlertInfoProperties()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.alertControlProperties1 = New DevExpress.ApplicationUI.Demos.AlertControlProperties()
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType((Me.sePostponedFormCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sePostponedFormCount
            ' 
            Me.sePostponedFormCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.sePostponedFormCount.Location = New System.Drawing.Point(316, 21)
            Me.sePostponedFormCount.Name = "sePostponedFormCount"
            Me.sePostponedFormCount.Properties.IsFloatValue = False
            Me.sePostponedFormCount.Properties.Mask.EditMask = "N00"
            Me.sePostponedFormCount.Properties.[ReadOnly] = True
            Me.sePostponedFormCount.Size = New System.Drawing.Size(61, 20)
            Me.sePostponedFormCount.TabIndex = 18
            Me.sePostponedFormCount.TabStop = False
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(183, 24)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(114, 13)
            Me.labelControl3.TabIndex = 17
            Me.labelControl3.Text = "Postponed Form Count:"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(200, 565)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(4, 13)
            Me.labelControl2.TabIndex = 12
            Me.labelControl2.Text = ","
            ' 
            ' ceHeight
            ' 
            Me.ceHeight.EditValue = New Decimal(New Integer() {110, 0, 0, 0})
            Me.ceHeight.Location = New System.Drawing.Point(213, 562)
            Me.ceHeight.Name = "ceHeight"
            Me.ceHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ceHeight.Properties.IsFloatValue = False
            Me.ceHeight.Properties.Mask.EditMask = "N00"
            Me.ceHeight.Properties.MaxValue = New Decimal(New Integer() {400, 0, 0, 0})
            Me.ceHeight.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.ceHeight.Size = New System.Drawing.Size(84, 20)
            Me.ceHeight.TabIndex = 11
            ' 
            ' ceWidth
            ' 
            Me.ceWidth.EditValue = New Decimal(New Integer() {250, 0, 0, 0})
            Me.ceWidth.Location = New System.Drawing.Point(110, 562)
            Me.ceWidth.Name = "ceWidth"
            Me.ceWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ceWidth.Properties.IsFloatValue = False
            Me.ceWidth.Properties.Mask.EditMask = "N00"
            Me.ceWidth.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.ceWidth.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.ceWidth.Size = New System.Drawing.Size(84, 20)
            Me.ceWidth.TabIndex = 9
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(11, 565)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(76, 13)
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Alert Form Size:"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Controls.Add(Me.alertInfoProperties1)
            Me.groupControl2.Location = New System.Drawing.Point(359, 54)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(298, 487)
            Me.groupControl2.TabIndex = 7
            Me.groupControl2.Text = "Alert Info:"
            ' 
            ' alertInfoProperties1
            ' 
            Me.alertInfoProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertInfoProperties1.Location = New System.Drawing.Point(2, 23)
            Me.alertInfoProperties1.Name = "alertInfoProperties1"
            Me.alertInfoProperties1.Size = New System.Drawing.Size(294, 462)
            Me.alertInfoProperties1.TabIndex = 0
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.alertControlProperties1)
            Me.groupControl1.Location = New System.Drawing.Point(12, 54)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(328, 487)
            Me.groupControl1.TabIndex = 6
            Me.groupControl1.Text = "Alert Control Properties:"
            ' 
            ' alertControlProperties1
            ' 
            Me.alertControlProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertControlProperties1.Location = New System.Drawing.Point(2, 23)
            Me.alertControlProperties1.Name = "alertControlProperties1"
            Me.alertControlProperties1.Size = New System.Drawing.Size(324, 462)
            Me.alertControlProperties1.TabIndex = 0
            AddHandler Me.alertControlProperties1.AllowHtmlTextChanged, New System.EventHandler(AddressOf Me.alertControlProperties1_AllowHtmlTextChanged)
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(12, 16)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(141, 28)
            Me.button1.TabIndex = 5
            Me.button1.Text = "&Show Alert Form"
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 608)
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItem1, Me.barCheckItem1, Me.barCheckItem2, Me.barButtonItem1, Me.barButtonItem2, Me.barCheckItem3, Me.barButtonItem3})
            Me.barManager1.MaxItemId = 7
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(744, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 608)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(744, 0)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(744, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 608)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Contact"
            Me.barSubItem1.Id = 0
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem2)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.BindableChecked = True
            Me.barCheckItem1.Caption = "Customer"
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.GroupIndex = 1
            Me.barCheckItem1.Id = 1
            Me.barCheckItem1.ImageOptions.ImageIndex = 10
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.Caption = "Employee"
            Me.barCheckItem2.GroupIndex = 1
            Me.barCheckItem2.Id = 2
            Me.barCheckItem2.ImageOptions.ImageIndex = 11
            Me.barCheckItem2.Name = "barCheckItem2"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Preview"
            Me.barButtonItem1.Id = 3
            Me.barButtonItem1.ImageOptions.ImageIndex = 7
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Print"
            Me.barButtonItem2.Id = 4
            Me.barButtonItem2.ImageOptions.ImageIndex = 8
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.BindableChecked = True
            Me.barCheckItem3.Caption = "Attachment"
            Me.barCheckItem3.Checked = True
            Me.barCheckItem3.Id = 5
            Me.barCheckItem3.ImageOptions.ImageIndex = 9
            Me.barCheckItem3.Name = "barCheckItem3"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Find"
            Me.barButtonItem3.Id = 6
            Me.barButtonItem3.ImageOptions.ImageIndex = 4
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' alertControl1
            ' 
            alertButton1.Hint = "Open Info"
            alertButton1.ImageOptions.ImageIndex = 5
            alertButton1.Name = "Open"
            alertButton2.Hint = "Copy Info"
            alertButton2.ImageOptions.ImageIndex = 2
            alertButton2.Name = "Copy"
            alertButton3.Hint = "Delete Info"
            alertButton3.ImageOptions.ImageIndex = 6
            alertButton3.Name = "Delete"
            alertButton4.Down = True
            alertButton4.Hint = "Mail"
            alertButton4.ImageOptions.ImageDownIndex = 1
            alertButton4.ImageOptions.ImageIndex = 0
            alertButton4.Name = "Mail"
            alertButton4.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton
            Me.alertControl1.Buttons.Add(alertButton1)
            Me.alertControl1.Buttons.Add(alertButton2)
            Me.alertControl1.Buttons.Add(alertButton3)
            Me.alertControl1.Buttons.Add(alertButton4)
            Me.alertControl1.FormMaxCount = 7
            Me.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal
            Me.alertControl1.Images = Me.imageCollection1
            Me.alertControl1.PopupMenu = Me.popupMenu1
            AddHandler Me.alertControl1.BeforeFormShow, New DevExpress.XtraBars.Alerter.AlertFormEventHandler(AddressOf Me.alertControl1_BeforeFormShow)
            AddHandler Me.alertControl1.FormLoad, New DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(AddressOf Me.alertControl1_FormLoad)
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' AlertControlTutorial
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sePostponedFormCount)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.ceHeight)
            Me.Controls.Add(Me.ceWidth)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.groupControl2)
            Me.Controls.Add(Me.groupControl1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "AlertControlTutorial"
            Me.Size = New System.Drawing.Size(744, 608)
            CType((Me.sePostponedFormCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private alertControl1 As DevExpress.XtraBars.Alerter.AlertControl

        Private button1 As DevExpress.XtraEditors.SimpleButton

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private alertControlProperties1 As DevExpress.ApplicationUI.Demos.AlertControlProperties

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private groupControl2 As DevExpress.XtraEditors.GroupControl

        Private alertInfoProperties1 As DevExpress.ApplicationUI.Demos.AlertInfoProperties

        Private ceHeight As DevExpress.XtraEditors.SpinEdit

        Private ceWidth As DevExpress.XtraEditors.SpinEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private sePostponedFormCount As DevExpress.XtraEditors.SpinEdit
    End Class
End Namespace

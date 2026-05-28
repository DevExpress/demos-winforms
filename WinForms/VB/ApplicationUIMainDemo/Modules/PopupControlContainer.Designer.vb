Namespace DevExpress.ApplicationUI.Demos

    Partial Class PopupControlContainer

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.BarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.alignmentControl1 = New DevExpress.Tutorials.Controls.AlignmentControl()
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.label1 = New System.Windows.Forms.Label()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControl1)
            Me.barManager1.DockControls.Add(Me.barDockControl2)
            Me.barManager1.DockControls.Add(Me.barDockControl3)
            Me.barManager1.DockControls.Add(Me.barDockControl4)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem})
            Me.barManager1.MaxItemId = 1
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Custom 1"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(48, 135)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem, True)})
            Me.bar1.Text = "Custom 1"
            ' 
            ' BarButtonItem
            ' 
            Me.BarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.BarButtonItem.Caption = "Text Alignment"
            Me.BarButtonItem.DropDownControl = Me.popupControlContainer1
            Me.BarButtonItem.Id = 0
            Me.BarButtonItem.Name = "BarButtonItem"
            ' 
            ' popupControlContainer1
            ' 
            Me.popupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.popupControlContainer1.Appearance.Options.UseBackColor = True
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.alignmentControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(12, 48)
            Me.popupControlContainer1.Manager = Me.barManager1
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Padding = New System.Windows.Forms.Padding(4)
            Me.popupControlContainer1.Size = New System.Drawing.Size(148, 104)
            Me.popupControlContainer1.TabIndex = 4
            Me.popupControlContainer1.Visible = False
            AddHandler Me.popupControlContainer1.Popup, New System.EventHandler(AddressOf Me.popupControlContainer1_Popup)
            ' 
            ' alignmentControl1
            ' 
            Me.alignmentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alignmentControl1.Location = New System.Drawing.Point(4, 4)
            Me.alignmentControl1.Name = "alignmentControl1"
            Me.alignmentControl1.Size = New System.Drawing.Size(140, 96)
            Me.alignmentControl1.TabIndex = 6
            AddHandler Me.alignmentControl1.AlignmentChanged, New System.EventHandler(AddressOf Me.alignmentControl1_AlignmentChanged)
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Manager = Me.barManager1
            Me.barDockControl1.Size = New System.Drawing.Size(520, 20)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 280)
            Me.barDockControl2.Manager = Me.barManager1
            Me.barDockControl2.Size = New System.Drawing.Size(520, 0)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 20)
            Me.barDockControl3.Manager = Me.barManager1
            Me.barDockControl3.Size = New System.Drawing.Size(0, 260)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(520, 20)
            Me.barDockControl4.Manager = Me.barManager1
            Me.barDockControl4.Size = New System.Drawing.Size(0, 260)
            ' 
            ' label1
            ' 
            Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label1.Location = New System.Drawing.Point(0, 20)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(520, 260)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Label1"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' PopupControlContainer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Name = "PopupControlContainer"
            Me.Size = New System.Drawing.Size(520, 280)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControl1 As DevExpress.XtraBars.BarDockControl

        Private barDockControl2 As DevExpress.XtraBars.BarDockControl

        Private barDockControl3 As DevExpress.XtraBars.BarDockControl

        Private barDockControl4 As DevExpress.XtraBars.BarDockControl

        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer

        Private label1 As System.Windows.Forms.Label

        Private BarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private bar1 As DevExpress.XtraBars.Bar

        Private alignmentControl1 As DevExpress.Tutorials.Controls.AlignmentControl

        Private components As System.ComponentModel.IContainer
    End Class
End Namespace

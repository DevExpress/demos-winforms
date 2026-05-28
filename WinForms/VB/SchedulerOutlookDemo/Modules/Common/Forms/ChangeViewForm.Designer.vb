Namespace DevExpress.XtraScheduler.Demos

    Partial Class ChangeViewForm

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.AllowItemSelection = True
            Me.accordionControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement1})
            Me.accordionControl1.ExpandGroupOnHeaderClick = False
            Me.accordionControl1.ExpandItemOnHeaderClick = False
            Me.accordionControl1.Location = New System.Drawing.Point(0, 0)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ResizeMode = DevExpress.XtraBars.Navigation.AccordionControlResizeMode.OuterResizeZone
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.accordionControl1.Size = New System.Drawing.Size(179, 413)
            Me.accordionControl1.TabIndex = 0
            AddHandler Me.accordionControl1.SelectedElementChanged, New DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(AddressOf Me.accordionControl1_SelectedElementChanged)
            ' 
            ' accordionControlElement1
            ' 
            Me.accordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement2, Me.accordionControlElement3, Me.accordionControlElement4})
            Me.accordionControlElement1.Expanded = True
            Me.accordionControlElement1.HeaderVisible = False
            Me.accordionControlElement1.Name = "accordionControlElement1"
            Me.accordionControlElement1.Text = "Element1"
            ' 
            ' accordionControlElement2
            ' 
            Me.accordionControlElement2.Name = "accordionControlElement2"
            Me.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement2.Tag = "Calendars"
            Me.accordionControlElement2.Text = "Calendars"
            ' 
            ' accordionControlElement3
            ' 
            Me.accordionControlElement3.Name = "accordionControlElement3"
            Me.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement3.Tag = "Views"
            Me.accordionControlElement3.Text = "Views"
            ' 
            ' accordionControlElement4
            ' 
            Me.accordionControlElement4.Name = "accordionControlElement4"
            Me.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement4.Tag = "Appointments"
            Me.accordionControlElement4.Text = "Appointment Appearance"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(180, 0)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(504, 413)
            Me.panelControl1.TabIndex = 7
            ' 
            ' btnOk
            ' 
            Me.btnOk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk.Location = New System.Drawing.Point(534, 13)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(66, 23)
            Me.btnOk.TabIndex = 5
            Me.btnOk.Text = "OK"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(606, 13)
            Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 3, 12, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(66, 23)
            Me.btnCancel.TabIndex = 6
            Me.btnCancel.Text = "Cancel"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.accordionControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(180, 413)
            Me.sidePanel1.TabIndex = 8
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.btnOk)
            Me.sidePanel2.Controls.Add(Me.btnCancel)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 413)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(684, 48)
            Me.sidePanel2.TabIndex = 8
            Me.sidePanel2.Text = "sidePanel1"
            ' 
            ' ChangeViewForm
            ' 
            Me.AcceptButton = Me.btnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(684, 461)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.sidePanel2)
            Me.IconOptions.ShowIcon = False
            Me.Name = "ChangeViewForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Global Demo Options"
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private btnOk As DevExpress.XtraEditors.SimpleButton

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace

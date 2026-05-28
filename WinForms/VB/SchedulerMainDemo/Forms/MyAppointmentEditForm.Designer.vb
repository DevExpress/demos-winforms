Namespace DevExpress.XtraScheduler.Demos

    Partial Class MyAppointmentEditForm

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
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnReccurrence = New DevExpress.XtraEditors.SimpleButton()
            Me.lblSubject = New System.Windows.Forms.Label()
            Me.txSubject = New DevExpress.XtraEditors.TextEdit()
            Me.edLabel = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.edStatus = New DevExpress.XtraScheduler.UI.AppointmentStatusEdit()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.lblLabel = New System.Windows.Forms.Label()
            Me.lblStart = New System.Windows.Forms.Label()
            Me.lblEnd = New System.Windows.Forms.Label()
            Me.lblCustomName = New System.Windows.Forms.Label()
            Me.lblCustomStatus = New System.Windows.Forms.Label()
            Me.txCustomName = New DevExpress.XtraEditors.TextEdit()
            Me.txCustomStatus = New DevExpress.XtraEditors.TextEdit()
            Me.dtStart = New DevExpress.XtraEditors.DateEdit()
            Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
            Me.timeStart = New DevExpress.XtraEditors.TimeEdit()
            Me.timeEnd = New DevExpress.XtraEditors.TimeEdit()
            Me._checkAllDay = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.txSubject.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edLabel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txCustomName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txCustomStatus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dtStart.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dtStart.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dtEnd.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dtEnd.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.timeStart.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.timeEnd.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me._checkAllDay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnOK
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(16, 224)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 27)
            Me.btnOK.TabIndex = 10
            Me.btnOK.Text = "OK"
            AddHandler Me.btnOK.Click, New System.EventHandler(AddressOf Me.btnOK_Click)
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(113, 224)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 27)
            Me.btnCancel.TabIndex = 11
            Me.btnCancel.Text = "Cancel"
            ' 
            ' btnReccurrence
            ' 
            Me.btnReccurrence.Location = New System.Drawing.Point(208, 224)
            Me.btnReccurrence.Name = "btnReccurrence"
            Me.btnReccurrence.Size = New System.Drawing.Size(80, 27)
            Me.btnReccurrence.TabIndex = 12
            Me.btnReccurrence.Text = "Recurrence"
            AddHandler Me.btnReccurrence.Click, New System.EventHandler(AddressOf Me.btnAddRec_Click)
            ' 
            ' lblSubject
            ' 
            Me.lblSubject.Location = New System.Drawing.Point(8, 9)
            Me.lblSubject.Name = "lblSubject"
            Me.lblSubject.Size = New System.Drawing.Size(48, 18)
            Me.lblSubject.TabIndex = 4
            Me.lblSubject.Text = "Subject:"
            ' 
            ' txSubject
            ' 
            Me.txSubject.EditValue = ""
            Me.txSubject.Location = New System.Drawing.Point(96, 8)
            Me.txSubject.Name = "txSubject"
            Me.txSubject.Size = New System.Drawing.Size(192, 20)
            Me.txSubject.TabIndex = 0
            ' 
            ' edLabel
            ' 
            Me.edLabel.Location = New System.Drawing.Point(96, 136)
            Me.edLabel.Name = "edLabel"
            Me.edLabel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edLabel.Size = New System.Drawing.Size(192, 20)
            Me.edLabel.TabIndex = 7
            ' 
            ' edStatus
            ' 
            Me.edStatus.Location = New System.Drawing.Point(96, 112)
            Me.edStatus.Name = "edStatus"
            Me.edStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edStatus.Size = New System.Drawing.Size(192, 20)
            Me.edStatus.TabIndex = 6
            ' 
            ' lblStatus
            ' 
            Me.lblStatus.Location = New System.Drawing.Point(8, 112)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(48, 18)
            Me.lblStatus.TabIndex = 10
            Me.lblStatus.Text = "Status:"
            ' 
            ' lblLabel
            ' 
            Me.lblLabel.Location = New System.Drawing.Point(8, 136)
            Me.lblLabel.Name = "lblLabel"
            Me.lblLabel.Size = New System.Drawing.Size(48, 19)
            Me.lblLabel.TabIndex = 11
            Me.lblLabel.Text = "Label:"
            ' 
            ' lblStart
            ' 
            Me.lblStart.Location = New System.Drawing.Point(8, 41)
            Me.lblStart.Name = "lblStart"
            Me.lblStart.Size = New System.Drawing.Size(56, 18)
            Me.lblStart.TabIndex = 12
            Me.lblStart.Text = "Start:"
            ' 
            ' lblEnd
            ' 
            Me.lblEnd.Location = New System.Drawing.Point(8, 65)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New System.Drawing.Size(48, 18)
            Me.lblEnd.TabIndex = 13
            Me.lblEnd.Text = "End:"
            ' 
            ' lblCustomName
            ' 
            Me.lblCustomName.Location = New System.Drawing.Point(8, 168)
            Me.lblCustomName.Name = "lblCustomName"
            Me.lblCustomName.Size = New System.Drawing.Size(80, 19)
            Me.lblCustomName.TabIndex = 15
            Me.lblCustomName.Text = "Custom name:"
            ' 
            ' lblCustomStatus
            ' 
            Me.lblCustomStatus.Location = New System.Drawing.Point(8, 192)
            Me.lblCustomStatus.Name = "lblCustomStatus"
            Me.lblCustomStatus.Size = New System.Drawing.Size(80, 19)
            Me.lblCustomStatus.TabIndex = 16
            Me.lblCustomStatus.Text = "Custom status:"
            ' 
            ' txCustomName
            ' 
            Me.txCustomName.EditValue = ""
            Me.txCustomName.Location = New System.Drawing.Point(96, 168)
            Me.txCustomName.Name = "txCustomName"
            Me.txCustomName.Size = New System.Drawing.Size(192, 20)
            Me.txCustomName.TabIndex = 8
            ' 
            ' txCustomStatus
            ' 
            Me.txCustomStatus.EditValue = ""
            Me.txCustomStatus.Location = New System.Drawing.Point(96, 192)
            Me.txCustomStatus.Name = "txCustomStatus"
            Me.txCustomStatus.Size = New System.Drawing.Size(192, 20)
            Me.txCustomStatus.TabIndex = 9
            ' 
            ' dtStart
            ' 
            Me.dtStart.EditValue = New System.DateTime(2010, 6, 27, 0, 0, 0, 0)
            Me.dtStart.Location = New System.Drawing.Point(96, 40)
            Me.dtStart.Name = "dtStart"
            Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtStart.Size = New System.Drawing.Size(96, 20)
            Me.dtStart.TabIndex = 1
            AddHandler Me.dtStart.EditValueChanged, New System.EventHandler(AddressOf Me.dtStart_EditValueChanged)
            ' 
            ' dtEnd
            ' 
            Me.dtEnd.EditValue = New System.DateTime(2010, 6, 27, 0, 0, 0, 0)
            Me.dtEnd.Location = New System.Drawing.Point(96, 64)
            Me.dtEnd.Name = "dtEnd"
            Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtEnd.Size = New System.Drawing.Size(96, 20)
            Me.dtEnd.TabIndex = 3
            AddHandler Me.dtEnd.EditValueChanged, New System.EventHandler(AddressOf Me.dtEnd_EditValueChanged)
            ' 
            ' timeStart
            ' 
            Me.timeStart.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
            Me.timeStart.Location = New System.Drawing.Point(208, 40)
            Me.timeStart.Name = "timeStart"
            Me.timeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeStart.Size = New System.Drawing.Size(80, 20)
            Me.timeStart.TabIndex = 2
            AddHandler Me.timeStart.EditValueChanged, New System.EventHandler(AddressOf Me.timeStart_EditValueChanged)
            ' 
            ' timeEnd
            ' 
            Me.timeEnd.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
            Me.timeEnd.Location = New System.Drawing.Point(208, 64)
            Me.timeEnd.Name = "timeEnd"
            Me.timeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeEnd.Size = New System.Drawing.Size(80, 20)
            Me.timeEnd.TabIndex = 4
            AddHandler Me.timeEnd.EditValueChanged, New System.EventHandler(AddressOf Me.timeEnd_EditValueChanged)
            ' 
            ' checkAllDay
            ' 
            Me._checkAllDay.Location = New System.Drawing.Point(94, 88)
            Me._checkAllDay.Name = "checkAllDay"
            Me._checkAllDay.Properties.Caption = "All day event"
            Me._checkAllDay.Size = New System.Drawing.Size(88, 19)
            Me._checkAllDay.TabIndex = 5
            AddHandler Me._checkAllDay.CheckedChanged, New System.EventHandler(AddressOf Me.checkAllDay_CheckedChanged)
            ' 
            ' MyAppointmentEditForm
            ' 
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(298, 264)
            Me.Controls.Add(Me._checkAllDay)
            Me.Controls.Add(Me.timeEnd)
            Me.Controls.Add(Me.timeStart)
            Me.Controls.Add(Me.dtEnd)
            Me.Controls.Add(Me.dtStart)
            Me.Controls.Add(Me.txCustomStatus)
            Me.Controls.Add(Me.txCustomName)
            Me.Controls.Add(Me.lblCustomStatus)
            Me.Controls.Add(Me.lblCustomName)
            Me.Controls.Add(Me.lblEnd)
            Me.Controls.Add(Me.lblStart)
            Me.Controls.Add(Me.lblLabel)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.edStatus)
            Me.Controls.Add(Me.edLabel)
            Me.Controls.Add(Me.txSubject)
            Me.Controls.Add(Me.lblSubject)
            Me.Controls.Add(Me.btnReccurrence)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MyAppointmentEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Custom Appointment Form"
            AddHandler Me.Activated, New System.EventHandler(AddressOf Me.MyAppointmentEditForm_Activated)
            CType((Me.txSubject.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edLabel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txCustomName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txCustomStatus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dtStart.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dtStart.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dtEnd.Properties.VistaTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dtEnd.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.timeStart.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.timeEnd.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me._checkAllDay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private btnOK As DevExpress.XtraEditors.SimpleButton

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private txSubject As DevExpress.XtraEditors.TextEdit

        Private btnReccurrence As DevExpress.XtraEditors.SimpleButton

        Private edLabel As DevExpress.XtraScheduler.UI.AppointmentLabelEdit

        Private edStatus As DevExpress.XtraScheduler.UI.AppointmentStatusEdit

        Private lblSubject As System.Windows.Forms.Label

        Private lblStatus As System.Windows.Forms.Label

        Private lblLabel As System.Windows.Forms.Label

        Private lblStart As System.Windows.Forms.Label

        Private lblEnd As System.Windows.Forms.Label

        Private lblCustomName As System.Windows.Forms.Label

        Private lblCustomStatus As System.Windows.Forms.Label

        Private txCustomName As DevExpress.XtraEditors.TextEdit

        Private txCustomStatus As DevExpress.XtraEditors.TextEdit

        Private dtStart As DevExpress.XtraEditors.DateEdit

        Private dtEnd As DevExpress.XtraEditors.DateEdit

        Private timeStart As DevExpress.XtraEditors.TimeEdit

        Private timeEnd As DevExpress.XtraEditors.TimeEdit
    End Class
End Namespace

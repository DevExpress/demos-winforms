Namespace DevExpress.XtraScheduler.Demos.Forms

    Partial Class MyInplaceEditor

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.Forms.MyInplaceEditor))
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.edtDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.appointmentLabelEdit = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.edtDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appointmentLabelEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtSubject.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.edtDescription)
            Me.groupControl1.Controls.Add(Me.labelControl3)
            Me.groupControl1.Controls.Add(Me.appointmentLabelEdit)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.edtSubject)
            Me.groupControl1.Controls.Add(Me.labelControl2)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' edtDescription
            ' 
            resources.ApplyResources(Me.edtDescription, "edtDescription")
            Me.edtDescription.MinimumSize = New System.Drawing.Size(0, 32)
            Me.edtDescription.Name = "edtDescription"
            ' 
            ' labelControl3
            ' 
            resources.ApplyResources(Me.labelControl3, "labelControl3")
            Me.labelControl3.Name = "labelControl3"
            ' 
            ' appointmentLabelEdit
            ' 
            resources.ApplyResources(Me.appointmentLabelEdit, "appointmentLabelEdit")
            Me.appointmentLabelEdit.Name = "appointmentLabelEdit"
            Me.appointmentLabelEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' edtSubject
            ' 
            resources.ApplyResources(Me.edtSubject, "edtSubject")
            Me.edtSubject.Name = "edtSubject"
            ' 
            ' labelControl2
            ' 
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.Name = "labelControl2"
            ' 
            ' MyInplaceEditor
            ' 
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.groupControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "MyInplaceEditor"
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType((Me.edtDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appointmentLabelEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtSubject.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private edtDescription As DevExpress.XtraEditors.MemoEdit

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private appointmentLabelEdit As DevExpress.XtraScheduler.UI.AppointmentLabelEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private edtSubject As DevExpress.XtraEditors.TextEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

Namespace DevExpress.DevAV.Modules

    Partial Class ProductsExport

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
        Private Overloads Sub InitializeComponent()
            Me.exportSettingsControl = New DevExpress.DevAV.ReportExportControl()
            Me.previewControl = New DevExpress.DevAV.ReportPreviewControl()
            Me.SuspendLayout()
            Me.exportSettingsControl.Dock = System.Windows.Forms.DockStyle.Left
            Me.exportSettingsControl.Location = New System.Drawing.Point(0, 0)
            Me.exportSettingsControl.Name = "exportSettingsControl"
            Me.exportSettingsControl.SelectedExport = DevExpress.XtraPrinting.ExportTarget.Xls
            Me.exportSettingsControl.Size = New System.Drawing.Size(310, 600)
            Me.exportSettingsControl.TabIndex = 0
            Me.previewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewControl.Location = New System.Drawing.Point(310, 0)
            Me.previewControl.Name = "previewControl"
            Me.previewControl.Size = New System.Drawing.Size(714, 600)
            Me.previewControl.TabIndex = 1
            Me.previewControl.Visible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.previewControl)
            Me.Controls.Add(Me.exportSettingsControl)
            Me.Name = "EmployeesExport"
            Me.Size = New System.Drawing.Size(1024, 600)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private exportSettingsControl As DevExpress.DevAV.ReportExportControl

        Private previewControl As DevExpress.DevAV.ReportPreviewControl
    End Class
End Namespace

Namespace DevExpress.DevAV.Modules

    Partial Class ProductsPrint

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
            Me.printControl = New DevExpress.DevAV.ReportPrintControl()
            Me.previewControl = New DevExpress.DevAV.ReportPreviewControl()
            Me.SuspendLayout()
            Me.printControl.Dock = System.Windows.Forms.DockStyle.Left
            Me.printControl.Location = New System.Drawing.Point(0, 0)
            Me.printControl.Name = "printControl"
            Me.printControl.SelectedPrinterName = ""
            Me.printControl.Size = New System.Drawing.Size(310, 600)
            Me.printControl.TabIndex = 1
            AddHandler Me.printControl.PrintClick, New System.EventHandler(AddressOf Me.settingsControl_PrintClick)
            AddHandler Me.printControl.PrintOptionsClick, New System.EventHandler(AddressOf Me.settingsControl_PrintOptionsClick)
            Me.previewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewControl.Location = New System.Drawing.Point(310, 0)
            Me.previewControl.Name = "reportPreviewControl1"
            Me.previewControl.Size = New System.Drawing.Size(714, 600)
            Me.previewControl.TabIndex = 2
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.previewControl)
            Me.Controls.Add(Me.printControl)
            Me.Name = "CustomersPrint"
            Me.Size = New System.Drawing.Size(1024, 600)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private printControl As DevExpress.DevAV.ReportPrintControl

        Private previewControl As DevExpress.DevAV.ReportPreviewControl
    End Class
End Namespace

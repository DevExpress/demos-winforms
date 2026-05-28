Namespace DevExpress.XtraPdfViewer.Demos

    Partial Class ViewerModule

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
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.SuspendLayout()
            ' 
            ' pdfViewer1
            ' 
            Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.NavigationPaneWidth = 400
            Me.pdfViewer1.Size = New System.Drawing.Size(784, 432)
            Me.pdfViewer1.TabIndex = 0
            Me.pdfViewer1.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
            ' 
            ' PdfViewerModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pdfViewer1)
            Me.Name = "PdfViewerModule"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
    End Class
End Namespace

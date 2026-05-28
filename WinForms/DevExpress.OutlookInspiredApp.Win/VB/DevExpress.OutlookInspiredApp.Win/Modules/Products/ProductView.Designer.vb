Namespace DevExpress.DevAV.Modules

    Partial Class ProductView

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
            Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
            Me.pdfViewer.Name = "pdfViewer"
            Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
            Me.pdfViewer.Size = New System.Drawing.Size(450, 600)
            Me.pdfViewer.TabIndex = 0
            Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pdfViewer)
            Me.Name = "ProductView"
            Me.Size = New System.Drawing.Size(450, 600)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
    End Class
End Namespace

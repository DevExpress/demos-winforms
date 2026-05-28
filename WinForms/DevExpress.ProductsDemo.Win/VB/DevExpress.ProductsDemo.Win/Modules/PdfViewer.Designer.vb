Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class PdfViewerModule
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
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.SuspendLayout()
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.Size = New System.Drawing.Size(985, 551)
			Me.pdfViewer.TabIndex = 0
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' PdfViewerModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pdfViewer)
			Me.Name = "PdfViewerModule"
			Me.Size = New System.Drawing.Size(985, 551)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pdfViewer As XtraPdfViewer.PdfViewer
	End Class
End Namespace

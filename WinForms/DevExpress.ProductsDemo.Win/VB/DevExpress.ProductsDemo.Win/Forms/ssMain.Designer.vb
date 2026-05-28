Namespace DevExpress.ProductsDemo.Win.Forms
	Partial Public Class ssMain
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ssMain))
			CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' marqueeProgressBarControl1
			' 
			Me.marqueeProgressBarControl1.Properties.Appearance.BorderColor = (CType(resources.GetObject("marqueeProgressBarControl1.Properties.Appearance.BorderColor"), System.Drawing.Color))
			Me.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
			Me.marqueeProgressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
			Me.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			' 
			' labelControl2
			' 
			resources.ApplyResources(Me.labelControl2, "labelControl2")
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Properties.Appearance.BackColor = (CType(resources.GetObject("pictureEdit1.Properties.Appearance.BackColor"), System.Drawing.Color))
			Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
			' 
			' panelControl
			' 
			Me.panelControl.Appearance.BackColor = (CType(resources.GetObject("panelControl.Appearance.BackColor"), System.Drawing.Color))
			Me.panelControl.Appearance.Options.UseBackColor = True
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = (CType(resources.GetObject("panelControl1.Appearance.BackColor"), System.Drawing.Color))
			Me.panelControl1.Appearance.Options.UseBackColor = True
			' 
			' labelDemoText
			' 
			Me.labelDemoText.Appearance.Font = (CType(resources.GetObject("labelDemoText.Appearance.Font"), System.Drawing.Font))
			Me.labelDemoText.Appearance.ForeColor = (CType(resources.GetObject("labelDemoText.Appearance.ForeColor"), System.Drawing.Color))
			' 
			' pictureEdit2
			' 
			Me.pictureEdit2.Properties.Appearance.BackColor = (CType(resources.GetObject("pictureEdit2.Properties.Appearance.BackColor"), System.Drawing.Color))
			Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
			' 
			' labelProductText
			' 
			Me.labelProductText.Appearance.Font = (CType(resources.GetObject("labelProductText.Appearance.Font"), System.Drawing.Font))
			Me.labelProductText.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(252)))), (CInt((CByte(216)))), (CInt((CByte(188)))))
			' 
			' ssMain
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ssMain"
			CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl.ResumeLayout(False)
			Me.panelControl.PerformLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
	End Class
End Namespace

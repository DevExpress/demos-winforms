Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmNewMovieCategory
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
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
			Me.pcFormButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbOk = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSeparator = New DevExpress.XtraEditors.PanelControl()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.ucMovieCategoryDetail = New DevExpress.VideoRent.Win.Controls.ucMovieCategoryDetail()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcFormButtons.SuspendLayout()
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pcFormButtons
			' 
			Me.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcFormButtons.Controls.Add(Me.sbOk)
			Me.pcFormButtons.Controls.Add(Me.pcSeparator)
			Me.pcFormButtons.Controls.Add(Me.sbCancel)
			Me.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pcFormButtons.Location = New System.Drawing.Point(12, 317)
			Me.pcFormButtons.Name = "pcFormButtons"
			Me.pcFormButtons.Size = New System.Drawing.Size(584, 22)
			Me.pcFormButtons.TabIndex = 1
			' 
			' sbOk
			' 
			Me.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.sbOk.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbOk.Location = New System.Drawing.Point(369, 0)
			Me.sbOk.Name = "sbOk"
			Me.sbOk.Size = New System.Drawing.Size(124, 22)
			Me.sbOk.TabIndex = 3
			Me.sbOk.Text = "S&ave and Close"
			' 
			' pcSeparator
			' 
			Me.pcSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSeparator.Dock = System.Windows.Forms.DockStyle.Right
			Me.pcSeparator.Location = New System.Drawing.Point(493, 0)
			Me.pcSeparator.Name = "pcSeparator"
			Me.pcSeparator.Size = New System.Drawing.Size(8, 22)
			Me.pcSeparator.TabIndex = 2
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbCancel.Location = New System.Drawing.Point(501, 0)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(83, 22)
			Me.sbCancel.TabIndex = 1
			Me.sbCancel.Text = "&Close"
			' 
			' ucMovieCategoryDetail
			' 
			Me.ucMovieCategoryDetail.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ucMovieCategoryDetail.Location = New System.Drawing.Point(12, 12)
			Me.ucMovieCategoryDetail.Name = "ucMovieCategoryDetail"
			Me.ucMovieCategoryDetail.Size = New System.Drawing.Size(584, 297)
			Me.ucMovieCategoryDetail.TabIndex = 2
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(12, 309)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(584, 8)
			Me.panelControl1.TabIndex = 3
			' 
			' frmNewMovieCategory
			' 
			Me.AcceptButton = Me.sbOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.ClientSize = New System.Drawing.Size(608, 351)
			Me.Controls.Add(Me.ucMovieCategoryDetail)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.pcFormButtons)
			Me.Name = "frmNewMovieCategory"
			Me.Padding = New System.Windows.Forms.Padding(12)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.Text = "New Category"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmNewCategory_FormClosing);
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcFormButtons.ResumeLayout(False)
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pcFormButtons As DevExpress.XtraEditors.PanelControl
		Private sbOk As DevExpress.XtraEditors.SimpleButton
		Private pcSeparator As DevExpress.XtraEditors.PanelControl
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private ucMovieCategoryDetail As DevExpress.VideoRent.Win.Controls.ucMovieCategoryDetail
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

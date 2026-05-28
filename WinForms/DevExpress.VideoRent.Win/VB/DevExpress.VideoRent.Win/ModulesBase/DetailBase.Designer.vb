Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class DetailBase
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(815, 486)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
			Me.lcgMain.Size = New System.Drawing.Size(815, 486)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' DetailBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.MinimumSize = New System.Drawing.Size(400, 300)
			Me.Name = "DetailBase"
			Me.Size = New System.Drawing.Size(815, 486)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected lcMain As DevExpress.XtraLayout.LayoutControl
		Protected lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace

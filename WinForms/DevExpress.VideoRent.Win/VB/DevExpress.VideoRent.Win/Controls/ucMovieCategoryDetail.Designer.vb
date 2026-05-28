Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieCategoryDetail
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.teName = New DevExpress.XtraEditors.TextEdit()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.tcgMain = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.validationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.validationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.teName)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(352, 298)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' teName
			' 
			Me.teName.Location = New System.Drawing.Point(37, 2)
			Me.teName.Name = "teName"
			Me.teName.Size = New System.Drawing.Size(313, 20)
			Me.teName.StyleController = Me.lcMain
			Me.teName.TabIndex = 4
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciName, Me.tcgMain})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(352, 298)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' lciName
			' 
			Me.lciName.Control = Me.teName
			Me.lciName.CustomizationFormText = "Name"
			Me.lciName.Location = New System.Drawing.Point(0, 0)
			Me.lciName.Name = "lciName"
			Me.lciName.Size = New System.Drawing.Size(352, 24)
			Me.lciName.Text = "Name:"
			Me.lciName.TextSize = New System.Drawing.Size(31, 13)
			' 
			' tcgMain
			' 
			Me.tcgMain.CustomizationFormText = "tcgMain"
			Me.tcgMain.Location = New System.Drawing.Point(0, 24)
			Me.tcgMain.Name = "tcgMain"
			Me.tcgMain.SelectedTabPage = Me.layoutControlGroup1
			Me.tcgMain.SelectedTabPageIndex = 0
			Me.tcgMain.Size = New System.Drawing.Size(352, 274)
			Me.tcgMain.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1})
			Me.tcgMain.Text = "tcgMain"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Format"
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(328, 229)
			Me.layoutControlGroup1.Text = "Format"
			' 
			' ucMovieCategoryDetail
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucMovieCategoryDetail"
			Me.Size = New System.Drawing.Size(352, 298)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.validationProvider, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private teName As DevExpress.XtraEditors.TextEdit
		Private lciName As DevExpress.XtraLayout.LayoutControlItem
		Private validationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
		Private tcgMain As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	End Class
End Namespace

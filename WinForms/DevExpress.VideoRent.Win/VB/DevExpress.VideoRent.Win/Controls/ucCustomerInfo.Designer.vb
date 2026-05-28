Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucCustomerInfo
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
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.npMain = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.lcInfo = New DevExpress.XtraEditors.LabelControl()
			Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciInfo = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciHint = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciHint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.npMain)
			Me.lcMain.Controls.Add(Me.lcInfo)
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(227, 397)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' npMain
			' 
			Me.npMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.npMain.Location = New System.Drawing.Point(2, 319)
			Me.npMain.MaxRows = 10
			Me.npMain.Name = "npMain"
			Me.npMain.Size = New System.Drawing.Size(223, 76)
			Me.npMain.TabIndex = 6
			Me.npMain.TabStop = False
			' 
			' lcInfo
			' 
			Me.lcInfo.AllowHtmlString = True
			Me.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lcInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.lcInfo.Location = New System.Drawing.Point(2, 212)
			Me.lcInfo.Name = "lcInfo"
			Me.lcInfo.Size = New System.Drawing.Size(223, 93)
			Me.lcInfo.StyleController = Me.lcMain
			Me.lcInfo.TabIndex = 5
'			Me.lcInfo.DoubleClick += New System.EventHandler(Me.lcInfo_DoubleClick);
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(0, 0)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.NullText = " "
			Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.pePhoto.Properties.ReadOnly = True
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(227, 210)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 4
'			Me.pePhoto.Resize += New System.EventHandler(Me.pePhoto_Resize);
'			Me.pePhoto.DoubleClick += New System.EventHandler(Me.pePhoto_DoubleClick);
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPhoto, Me.lciInfo, Me.lciHint, Me.emptySpaceItem1})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(227, 397)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "lciPhoto"
			Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciPhoto.Size = New System.Drawing.Size(227, 210)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' lciInfo
			' 
			Me.lciInfo.Control = Me.lcInfo
			Me.lciInfo.CustomizationFormText = "lciInfo"
			Me.lciInfo.Location = New System.Drawing.Point(0, 210)
			Me.lciInfo.Name = "lciInfo"
			Me.lciInfo.Size = New System.Drawing.Size(227, 97)
			Me.lciInfo.Text = "lciInfo"
			Me.lciInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciInfo.TextToControlDistance = 0
			Me.lciInfo.TextVisible = False
			' 
			' lciHint
			' 
			Me.lciHint.Control = Me.npMain
			Me.lciHint.CustomizationFormText = "lciHint"
			Me.lciHint.Location = New System.Drawing.Point(0, 317)
			Me.lciHint.MinSize = New System.Drawing.Size(136, 24)
			Me.lciHint.Name = "lciHint"
			Me.lciHint.Size = New System.Drawing.Size(227, 80)
			Me.lciHint.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciHint.Text = "lciHint"
			Me.lciHint.TextSize = New System.Drawing.Size(0, 0)
			Me.lciHint.TextToControlDistance = 0
			Me.lciHint.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 307)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(227, 10)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ucCustomerInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucCustomerInfo"
			Me.Size = New System.Drawing.Size(227, 397)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciHint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents lcInfo As DevExpress.XtraEditors.LabelControl
		Private WithEvents pePhoto As DevExpress.XtraEditors.PictureEdit
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private lciInfo As DevExpress.XtraLayout.LayoutControlItem
		Private npMain As DevExpress.Utils.Frames.NotePanel8_1
		Private lciHint As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace

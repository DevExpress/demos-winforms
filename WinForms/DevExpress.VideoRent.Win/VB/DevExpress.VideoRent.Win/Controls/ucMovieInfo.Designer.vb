Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieInfo
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
			Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.lcInfo = New DevExpress.XtraEditors.LabelControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciInfo = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Controls.Add(Me.lcInfo)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(639, 116)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(561, 2)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.pePhoto.Properties.Appearance.Options.UseBackColor = True
			Me.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pePhoto.Properties.NullText = " "
			Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.pePhoto.Properties.ReadOnly = True
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(76, 112)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 4
'			Me.pePhoto.Resize += New System.EventHandler(Me.pePhoto_Resize);
'			Me.pePhoto.DoubleClick += New System.EventHandler(Me.pePhoto_DoubleClick);
			' 
			' lcInfo
			' 
			Me.lcInfo.AllowHtmlString = True
			Me.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lcInfo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.lcInfo.Location = New System.Drawing.Point(2, 2)
			Me.lcInfo.Name = "lcInfo"
			Me.lcInfo.Size = New System.Drawing.Size(555, 112)
			Me.lcInfo.StyleController = Me.lcMain
			Me.lcInfo.TabIndex = 5
'			Me.lcInfo.DoubleClick += New System.EventHandler(Me.lcInfo_DoubleClick);
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciInfo, Me.lciPhoto})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(639, 116)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' lciInfo
			' 
			Me.lciInfo.Control = Me.lcInfo
			Me.lciInfo.CustomizationFormText = "lciInfo"
			Me.lciInfo.Location = New System.Drawing.Point(0, 0)
			Me.lciInfo.MinSize = New System.Drawing.Size(67, 17)
			Me.lciInfo.Name = "lciInfo"
			Me.lciInfo.Size = New System.Drawing.Size(559, 116)
			Me.lciInfo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciInfo.Text = "lciInfo"
			Me.lciInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciInfo.TextToControlDistance = 0
			Me.lciInfo.TextVisible = False
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "lciPhoto"
			Me.lciPhoto.Location = New System.Drawing.Point(559, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Size = New System.Drawing.Size(80, 116)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' ucMovieInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucMovieInfo"
			Me.Size = New System.Drawing.Size(639, 116)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents lcInfo As DevExpress.XtraEditors.LabelControl
		Private WithEvents pePhoto As DevExpress.XtraEditors.PictureEdit
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private lciInfo As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

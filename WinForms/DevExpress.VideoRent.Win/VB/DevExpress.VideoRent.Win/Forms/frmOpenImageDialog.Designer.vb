Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmOpenImageDialog
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
			Me.treeList = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPath = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
			Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
			Me.teImageScale = New DevExpress.XtraEditors.TextEdit()
			Me.sbOk = New DevExpress.XtraEditors.SimpleButton()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciTreeList = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciImageScale = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPictureEdit = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl.SuspendLayout()
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teImageScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciTreeList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciImageScale, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList
			' 
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colPath})
			Me.treeList.Location = New System.Drawing.Point(12, 12)
			Me.treeList.Name = "treeList"
			Me.treeList.OptionsBehavior.Editable = False
			Me.treeList.OptionsView.ShowHorzLines = False
			Me.treeList.OptionsView.ShowIndicator = False
            Me.treeList.OptionsView.ShowVertLines = False
			Me.treeList.Size = New System.Drawing.Size(208, 458)
			Me.treeList.TabIndex = 0
'			Me.treeList.CompareNodeValues += New DevExpress.XtraTreeList.CompareNodeValuesEventHandler(Me.treeList_CompareNodeValues);
'			Me.treeList.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList_FocusedNodeChanged);
'			Me.treeList.GetStateImage += New DevExpress.XtraTreeList.GetStateImageEventHandler(Me.treeList_GetStateImage);
'			Me.treeList.VirtualTreeGetChildNodes += New DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(Me.treeList_VirtualTreeGetChildNodes);
'			Me.treeList.VirtualTreeGetCellValue += New DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(Me.treeList_VirtualTreeGetCellValue);
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.MinWidth = 39
			Me.colName.Name = "colName"
			Me.colName.OptionsColumn.AllowEdit = False
			Me.colName.OptionsColumn.AllowFocus = False
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colPath
			' 
			Me.colPath.Caption = "Path"
			Me.colPath.FieldName = "Path"
			Me.colPath.Name = "colPath"
			' 
			' layoutControl
			' 
			Me.layoutControl.Controls.Add(Me.pictureEdit)
			Me.layoutControl.Controls.Add(Me.teImageScale)
			Me.layoutControl.Controls.Add(Me.treeList)
			Me.layoutControl.Controls.Add(Me.sbOk)
			Me.layoutControl.Controls.Add(Me.sbCancel)
			Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl.Name = "layoutControl"
			Me.layoutControl.Root = Me.layoutControlGroup1
			Me.layoutControl.Size = New System.Drawing.Size(572, 520)
			Me.layoutControl.TabIndex = 2
			Me.layoutControl.Text = "layoutControl1"
			' 
			' pictureEdit
			' 
			Me.pictureEdit.Location = New System.Drawing.Point(230, 12)
			Me.pictureEdit.Name = "pictureEdit"
			Me.pictureEdit.Properties.AllowFocused = False
			Me.pictureEdit.Properties.NullText = " "
			Me.pictureEdit.Properties.ShowMenu = False
			Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pictureEdit.Size = New System.Drawing.Size(330, 434)
			Me.pictureEdit.StyleController = Me.layoutControl
			Me.pictureEdit.TabIndex = 0
			Me.pictureEdit.TabStop = True
'			Me.pictureEdit.LoadCompleted += New System.EventHandler(Me.pictureEdit_LoadCompleted);
'			Me.pictureEdit.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.pictureEdit_EditValueChanging);
			' 
			' teImageScale
			' 
			Me.teImageScale.Location = New System.Drawing.Point(230, 450)
			Me.teImageScale.Name = "teImageScale"
			Me.teImageScale.Properties.ReadOnly = True
			Me.teImageScale.Size = New System.Drawing.Size(330, 20)
			Me.teImageScale.StyleController = Me.layoutControl
			Me.teImageScale.TabIndex = 0
			Me.teImageScale.TabStop = False
'			Me.teImageScale.Click += New System.EventHandler(Me.teImageScale_Click);
			' 
			' sbOk
			' 
			Me.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.sbOk.Location = New System.Drawing.Point(423, 486)
			Me.sbOk.Name = "sbOk"
			Me.sbOk.Size = New System.Drawing.Size(66, 22)
			Me.sbOk.StyleController = Me.layoutControl
			Me.sbOk.TabIndex = 3
			Me.sbOk.Text = "OK"
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Location = New System.Drawing.Point(493, 486)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(67, 22)
			Me.sbCancel.StyleController = Me.layoutControl
			Me.sbCancel.TabIndex = 4
			Me.sbCancel.Text = "Cancel"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciTreeList, Me.lciImageScale, Me.lciPictureEdit, Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.splitterItem1, Me.emptySpaceItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(572, 520)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' lciTreeList
			' 
			Me.lciTreeList.Control = Me.treeList
			Me.lciTreeList.CustomizationFormText = "layoutControlItem1"
			Me.lciTreeList.Location = New System.Drawing.Point(0, 0)
			Me.lciTreeList.Name = "lciTreeList"
			Me.lciTreeList.Size = New System.Drawing.Size(212, 462)
			Me.lciTreeList.Text = "lciTreeList"
			Me.lciTreeList.TextSize = New System.Drawing.Size(0, 0)
			Me.lciTreeList.TextToControlDistance = 0
			Me.lciTreeList.TextVisible = False
			' 
			' lciImageScale
			' 
			Me.lciImageScale.Control = Me.teImageScale
			Me.lciImageScale.CustomizationFormText = "lciImageScale"
			Me.lciImageScale.Location = New System.Drawing.Point(218, 438)
			Me.lciImageScale.Name = "lciImageScale"
			Me.lciImageScale.Size = New System.Drawing.Size(334, 24)
			Me.lciImageScale.Text = "lciImageScale"
			Me.lciImageScale.TextSize = New System.Drawing.Size(0, 0)
			Me.lciImageScale.TextToControlDistance = 0
			Me.lciImageScale.TextVisible = False
			' 
			' lciPictureEdit
			' 
			Me.lciPictureEdit.Control = Me.pictureEdit
			Me.lciPictureEdit.CustomizationFormText = "lciPictureEdit"
			Me.lciPictureEdit.Location = New System.Drawing.Point(218, 0)
			Me.lciPictureEdit.Name = "lciPictureEdit"
			Me.lciPictureEdit.Size = New System.Drawing.Size(334, 438)
			Me.lciPictureEdit.Text = "lciPictureEdit"
			Me.lciPictureEdit.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPictureEdit.TextToControlDistance = 0
			Me.lciPictureEdit.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.sbOk
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(411, 474)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(70, 26)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.sbCancel
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(481, 474)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(71, 26)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 474)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(411, 26)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(212, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 462)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 462)
			Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 12)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(1, 12)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(552, 12)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' frmOpenImageDialog
			' 
			Me.AcceptButton = Me.sbOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.ClientSize = New System.Drawing.Size(572, 520)
			Me.Controls.Add(Me.layoutControl)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.Name = "frmOpenImageDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Open Image"
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl.ResumeLayout(False)
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teImageScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciTreeList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciImageScale, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList As DevExpress.XtraTreeList.TreeList
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPath As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private layoutControl As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private lciTreeList As DevExpress.XtraLayout.LayoutControlItem
		Private sbOk As DevExpress.XtraEditors.SimpleButton
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private WithEvents teImageScale As DevExpress.XtraEditors.TextEdit
		Private lciImageScale As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents pictureEdit As DevExpress.XtraEditors.PictureEdit
		Private lciPictureEdit As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace

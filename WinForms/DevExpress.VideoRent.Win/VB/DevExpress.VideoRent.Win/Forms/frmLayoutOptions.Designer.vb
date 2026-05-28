Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmLayoutOptions
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
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.ceAllowRestoreDockingLayout = New DevExpress.XtraEditors.CheckEdit()
			Me.ceDefaultEditGridViewInDetailForms = New DevExpress.XtraEditors.CheckEdit()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
			Me.ceAllowRestoreGridViewLayout = New DevExpress.XtraEditors.CheckEdit()
			Me.ceAllowRestoreLayoutControlLayout = New DevExpress.XtraEditors.CheckEdit()
			Me.ceAllowRestoreFormLayout = New DevExpress.XtraEditors.CheckEdit()
			Me.sbClearLayouts = New DevExpress.XtraEditors.SimpleButton()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.ceAllowRestoreDockingLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceDefaultEditGridViewInDetailForms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowRestoreGridViewLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowRestoreLayoutControlLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowRestoreFormLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.ceAllowRestoreDockingLayout)
			Me.lcMain.Controls.Add(Me.ceDefaultEditGridViewInDetailForms)
			Me.lcMain.Controls.Add(Me.sbCancel)
			Me.lcMain.Controls.Add(Me.sbOK)
			Me.lcMain.Controls.Add(Me.ceAllowRestoreGridViewLayout)
			Me.lcMain.Controls.Add(Me.ceAllowRestoreLayoutControlLayout)
			Me.lcMain.Controls.Add(Me.ceAllowRestoreFormLayout)
			Me.lcMain.Controls.Add(Me.sbClearLayouts)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(338, 285)
			Me.lcMain.TabIndex = 1
			Me.lcMain.Text = "layoutControl1"
			' 
			' ceAllowRestoreDockingLayout
			' 
			Me.ceAllowRestoreDockingLayout.Location = New System.Drawing.Point(12, 78)
			Me.ceAllowRestoreDockingLayout.Name = "ceAllowRestoreDockingLayout"
			Me.ceAllowRestoreDockingLayout.Properties.Caption = "Save and restore dock window layouts"
			Me.ceAllowRestoreDockingLayout.Size = New System.Drawing.Size(314, 18)
			Me.ceAllowRestoreDockingLayout.StyleController = Me.lcMain
			Me.ceAllowRestoreDockingLayout.TabIndex = 11
			' 
			' ceDefaultEditGridViewInDetailForms
			' 
			Me.ceDefaultEditGridViewInDetailForms.Location = New System.Drawing.Point(12, 100)
			Me.ceDefaultEditGridViewInDetailForms.Name = "ceDefaultEditGridViewInDetailForms"
			Me.ceDefaultEditGridViewInDetailForms.Properties.Caption = "Enable data editing within the grid"
			Me.ceDefaultEditGridViewInDetailForms.Size = New System.Drawing.Size(314, 18)
			Me.ceDefaultEditGridViewInDetailForms.StyleController = Me.lcMain
			Me.ceDefaultEditGridViewInDetailForms.TabIndex = 10
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Location = New System.Drawing.Point(246, 251)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(80, 22)
			Me.sbCancel.StyleController = Me.lcMain
			Me.sbCancel.TabIndex = 9
			Me.sbCancel.Text = "&Cancel"
			' 
			' sbOK
			' 
			Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.sbOK.Location = New System.Drawing.Point(166, 251)
			Me.sbOK.Name = "sbOK"
			Me.sbOK.Size = New System.Drawing.Size(76, 22)
			Me.sbOK.StyleController = Me.lcMain
			Me.sbOK.TabIndex = 8
			Me.sbOK.Text = "&OK"
			' 
			' ceAllowRestoreGridViewLayout
			' 
			Me.ceAllowRestoreGridViewLayout.Location = New System.Drawing.Point(12, 56)
			Me.ceAllowRestoreGridViewLayout.Name = "ceAllowRestoreGridViewLayout"
			Me.ceAllowRestoreGridViewLayout.Properties.Caption = "Save and restore grid control layouts"
			Me.ceAllowRestoreGridViewLayout.Size = New System.Drawing.Size(314, 18)
			Me.ceAllowRestoreGridViewLayout.StyleController = Me.lcMain
			Me.ceAllowRestoreGridViewLayout.TabIndex = 7
			' 
			' ceAllowRestoreLayoutControlLayout
			' 
			Me.ceAllowRestoreLayoutControlLayout.Location = New System.Drawing.Point(12, 34)
			Me.ceAllowRestoreLayoutControlLayout.Name = "ceAllowRestoreLayoutControlLayout"
			Me.ceAllowRestoreLayoutControlLayout.Properties.Caption = "Save and restore control layout within forms"
			Me.ceAllowRestoreLayoutControlLayout.Size = New System.Drawing.Size(314, 18)
			Me.ceAllowRestoreLayoutControlLayout.StyleController = Me.lcMain
			Me.ceAllowRestoreLayoutControlLayout.TabIndex = 6
			' 
			' ceAllowRestoreFormLayout
			' 
			Me.ceAllowRestoreFormLayout.Location = New System.Drawing.Point(12, 12)
			Me.ceAllowRestoreFormLayout.Name = "ceAllowRestoreFormLayout"
			Me.ceAllowRestoreFormLayout.Properties.Caption = "Save and restore Detail View layouts"
			Me.ceAllowRestoreFormLayout.Size = New System.Drawing.Size(314, 18)
			Me.ceAllowRestoreFormLayout.StyleController = Me.lcMain
			Me.ceAllowRestoreFormLayout.TabIndex = 5
			' 
			' sbClearLayouts
			' 
			Me.sbClearLayouts.Location = New System.Drawing.Point(12, 215)
			Me.sbClearLayouts.Name = "sbClearLayouts"
			Me.sbClearLayouts.Size = New System.Drawing.Size(314, 22)
			Me.sbClearLayouts.StyleController = Me.lcMain
			Me.sbClearLayouts.TabIndex = 4
			Me.sbClearLayouts.Text = "Clear Layouts"
'			Me.sbClearLayouts.Click += New System.EventHandler(Me.sbClearLayouts_Click);
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Size = New System.Drawing.Size(338, 285)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.ceAllowRestoreFormLayout
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(318, 22)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.ceAllowRestoreLayoutControlLayout
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 22)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(318, 22)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.ceAllowRestoreGridViewLayout
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 44)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(318, 22)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.sbClearLayouts
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 203)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(318, 26)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 110)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(318, 93)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 229)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(318, 10)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 239)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(154, 26)
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.sbOK
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(154, 239)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(80, 26)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.sbCancel
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(234, 239)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(84, 26)
			Me.layoutControlItem6.Text = "layoutControlItem6"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.ceDefaultEditGridViewInDetailForms
			Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 88)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(318, 22)
			Me.layoutControlItem7.Text = "layoutControlItem7"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextToControlDistance = 0
			Me.layoutControlItem7.TextVisible = False
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.ceAllowRestoreDockingLayout
			Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 66)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(318, 22)
			Me.layoutControlItem8.Text = "layoutControlItem8"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextToControlDistance = 0
			Me.layoutControlItem8.TextVisible = False
			' 
			' frmLayoutOptions
			' 
			Me.AcceptButton = Me.sbOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.ClientSize = New System.Drawing.Size(338, 285)
			Me.Controls.Add(Me.lcMain)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmLayoutOptions"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Layout options"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.ceAllowRestoreDockingLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceDefaultEditGridViewInDetailForms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowRestoreGridViewLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowRestoreLayoutControlLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowRestoreFormLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents sbClearLayouts As DevExpress.XtraEditors.SimpleButton
		Protected lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private ceAllowRestoreGridViewLayout As DevExpress.XtraEditors.CheckEdit
		Private ceAllowRestoreLayoutControlLayout As DevExpress.XtraEditors.CheckEdit
		Private ceAllowRestoreFormLayout As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private sbOK As DevExpress.XtraEditors.SimpleButton
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private ceDefaultEditGridViewInDetailForms As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private ceAllowRestoreDockingLayout As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

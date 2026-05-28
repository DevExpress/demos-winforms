Namespace DevExpress.ProductsDemo.Win.Forms
	Partial Public Class frmCustomDate
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmCustomDate))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.dateEdit2)
			Me.layoutControl1.Controls.Add(Me.dateEdit1)
			Me.layoutControl1.Controls.Add(Me.sbCancel)
			Me.layoutControl1.Controls.Add(Me.sbOK)
			resources.ApplyResources(Me.layoutControl1, "layoutControl1")
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(738, 385, 450, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			' 
			' dateEdit2
			' 
			resources.ApplyResources(Me.dateEdit2, "dateEdit2")
			Me.dateEdit2.Name = "dateEdit2"
			Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("dateEdit2.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit2.StyleController = Me.layoutControl1
			' 
			' dateEdit1
			' 
			resources.ApplyResources(Me.dateEdit1, "dateEdit1")
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("dateEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.StyleController = Me.layoutControl1
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			resources.ApplyResources(Me.sbCancel, "sbCancel")
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.StyleController = Me.layoutControl1
			' 
			' sbOK
			' 
			Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
			resources.ApplyResources(Me.sbOK, "sbOK")
			Me.sbOK.Name = "sbOK"
			Me.sbOK.StyleController = Me.layoutControl1
			' 
			' layoutControlGroup1
			' 
			resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlItem4, Me.emptySpaceItem2, Me.layoutControlItem5, Me.layoutControlItem1, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(275, 119)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(255, 25)
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.sbOK
			resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
			Me.layoutControlItem4.Location = New System.Drawing.Point(99, 73)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(77, 26)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 73)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(99, 26)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.sbCancel
			resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
			Me.layoutControlItem5.Location = New System.Drawing.Point(176, 73)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(79, 26)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.dateEdit1
			resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(255, 24)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.dateEdit2
			resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(255, 24)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
			' 
			' dxValidationProvider1
			' 
			Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
			' 
			' frmCustomDate
			' 
			Me.AcceptButton = Me.sbOK
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.Controls.Add(Me.layoutControl1)
			Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.Name = "frmCustomDate"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private sbOK As DevExpress.XtraEditors.SimpleButton
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
		Private dateEdit2 As DevExpress.XtraEditors.DateEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

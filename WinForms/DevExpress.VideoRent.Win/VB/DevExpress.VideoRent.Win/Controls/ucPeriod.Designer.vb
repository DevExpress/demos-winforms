Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucPeriod
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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.deEnd = New DevExpress.XtraEditors.DateEdit
            Me.deStart = New DevExpress.XtraEditors.DateEdit
            Me.icbPeriod = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.deEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.deEnd)
            Me.layoutControl1.Controls.Add(Me.deStart)
            Me.layoutControl1.Controls.Add(Me.icbPeriod)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(327, 217)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'deEnd
            '
            Me.deEnd.EditValue = Nothing
            Me.deEnd.Location = New System.Drawing.Point(70, 85)
            Me.deEnd.Name = "deEnd"
            Me.deEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.deEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.deEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.deEnd.Size = New System.Drawing.Size(245, 20)
            Me.deEnd.StyleController = Me.layoutControl1
            Me.deEnd.TabIndex = 6
            '
            'deStart
            '
            Me.deStart.EditValue = Nothing
            Me.deStart.Location = New System.Drawing.Point(70, 61)
            Me.deStart.Name = "deStart"
            Me.deStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.deStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.deStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.deStart.Size = New System.Drawing.Size(245, 20)
            Me.deStart.StyleController = Me.layoutControl1
            Me.deStart.TabIndex = 5
            '
            'icbPeriod
            '
            Me.icbPeriod.EditValue = 0
            Me.icbPeriod.Location = New System.Drawing.Point(70, 12)
            Me.icbPeriod.Name = "icbPeriod"
            Me.icbPeriod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.icbPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbPeriod.Properties.DropDownRows = 15
            Me.icbPeriod.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("(Custom)", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("3 Months", 3, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("6 Months", 6, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Year", 12, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("2 Years", 24, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("5 Years", 60, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("10 Years", 120, -1)})
            Me.icbPeriod.Size = New System.Drawing.Size(245, 20)
            Me.icbPeriod.StyleController = Me.layoutControl1
            Me.icbPeriod.TabIndex = 4
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.simpleSeparator1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(327, 217)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.icbPeriod
            Me.layoutControlItem1.CustomizationFormText = "Period:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(307, 24)
            Me.layoutControlItem1.Text = "Period:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.deStart
            Me.layoutControlItem2.CustomizationFormText = "Start Date:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 49)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(307, 24)
            Me.layoutControlItem2.Text = "Start Date:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.deEnd
            Me.layoutControlItem3.CustomizationFormText = "End Date:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 73)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(307, 24)
            Me.layoutControlItem3.Text = "End Date:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(307, 12)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 38)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(307, 11)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 97)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(307, 100)
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'simpleSeparator1
            '
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 36)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(307, 2)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            '
            'ucPeriod
            '
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ucPeriod"
            Me.Size = New System.Drawing.Size(327, 217)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.deEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents deEnd As DevExpress.XtraEditors.DateEdit
		Private WithEvents deStart As DevExpress.XtraEditors.DateEdit
		Private WithEvents icbPeriod As DevExpress.XtraEditors.ImageComboBoxEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
	End Class
End Namespace

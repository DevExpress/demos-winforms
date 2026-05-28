Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmPeriod
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
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl
            Me.ucPeriodKPI = New DevExpress.VideoRent.Win.Controls.ucPeriod
            Me.sbCancel = New DevExpress.XtraEditors.SimpleButton
            Me.sbOK = New DevExpress.XtraEditors.SimpleButton
            Me.ucPeriodReport = New DevExpress.VideoRent.Win.Controls.ucPeriod
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.tgcMain = New DevExpress.XtraLayout.TabbedControlGroup
            Me.lcgKPI = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lcgReceipt = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tgcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgKPI, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcMain
            '
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.ucPeriodKPI)
            Me.lcMain.Controls.Add(Me.sbCancel)
            Me.lcMain.Controls.Add(Me.sbOK)
            Me.lcMain.Controls.Add(Me.ucPeriodReport)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Location = New System.Drawing.Point(0, 0)
            Me.lcMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.Root = Me.lcgMain
            Me.lcMain.Size = New System.Drawing.Size(346, 304)
            Me.lcMain.TabIndex = 1
            Me.lcMain.Text = "layoutControl1"
            '
            'ucPeriodKPI
            '
            Me.ucPeriodKPI.Location = New System.Drawing.Point(24, 48)
            Me.ucPeriodKPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ucPeriodKPI.Name = "ucPeriodKPI"
            Me.ucPeriodKPI.Size = New System.Drawing.Size(298, 187)
            Me.ucPeriodKPI.TabIndex = 10
            '
            'sbCancel
            '
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.sbCancel.Location = New System.Drawing.Point(252, 269)
            Me.sbCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.Size = New System.Drawing.Size(82, 23)
            Me.sbCancel.StyleController = Me.lcMain
            Me.sbCancel.TabIndex = 9
            Me.sbCancel.Text = "&Cancel"
            '
            'sbOK
            '
            Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.sbOK.Location = New System.Drawing.Point(170, 269)
            Me.sbOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbOK.Name = "sbOK"
            Me.sbOK.Size = New System.Drawing.Size(78, 23)
            Me.sbOK.StyleController = Me.lcMain
            Me.sbOK.TabIndex = 8
            Me.sbOK.Text = "&OK"
            '
            'ucPeriodReport
            '
            Me.ucPeriodReport.Location = New System.Drawing.Point(24, 48)
            Me.ucPeriodReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ucPeriodReport.Name = "ucPeriodReport"
            Me.ucPeriodReport.Size = New System.Drawing.Size(298, 187)
            Me.ucPeriodReport.TabIndex = 11
            '
            'lcgMain
            '
            Me.lcgMain.CustomizationFormText = "lcgMain"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem3, Me.layoutControlItem5, Me.layoutControlItem6, Me.tgcMain, Me.emptySpaceItem1})
            Me.lcgMain.Location = New System.Drawing.Point(0, 0)
            Me.lcgMain.Name = "lcgMain"
            Me.lcgMain.Size = New System.Drawing.Size(346, 304)
            Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgMain.Text = "lcgMain"
            Me.lcgMain.TextVisible = False
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 257)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(158, 27)
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.sbOK
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(158, 257)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(82, 27)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.sbCancel
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(240, 257)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(86, 27)
            Me.layoutControlItem6.Text = "layoutControlItem6"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextToControlDistance = 0
            Me.layoutControlItem6.TextVisible = False
            '
            'tgcMain
            '
            Me.tgcMain.CustomizationFormText = "tabbedControlGroup1"
            Me.tgcMain.Location = New System.Drawing.Point(0, 0)
            Me.tgcMain.Name = "tgcMain"
            Me.tgcMain.SelectedTabPage = Me.lcgReceipt
            Me.tgcMain.SelectedTabPageIndex = 1
            Me.tgcMain.Size = New System.Drawing.Size(326, 239)
            Me.tgcMain.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgKPI, Me.lcgReceipt})
            Me.tgcMain.Text = "tgcMain"
            '
            'lcgKPI
            '
            Me.lcgKPI.CustomizationFormText = "KPI Period"
            Me.lcgKPI.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.lcgKPI.Location = New System.Drawing.Point(0, 0)
            Me.lcgKPI.Name = "lcgKPI"
            Me.lcgKPI.Size = New System.Drawing.Size(302, 191)
            Me.lcgKPI.Text = "KPI Period"
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.ucPeriodKPI
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(302, 191)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'lcgReceipt
            '
            Me.lcgReceipt.CustomizationFormText = "Receipt Period"
            Me.lcgReceipt.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.lcgReceipt.Location = New System.Drawing.Point(0, 0)
            Me.lcgReceipt.Name = "lcgReceipt"
            Me.lcgReceipt.Size = New System.Drawing.Size(302, 191)
            Me.lcgReceipt.Text = "Receipt Period"
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.ucPeriodReport
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(302, 191)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 239)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(326, 18)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'frmPeriod
            '
            Me.AcceptButton = Me.sbOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.sbCancel
            Me.ClientSize = New System.Drawing.Size(346, 304)
            Me.Controls.Add(Me.lcMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPeriod"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Specify Date Intervals "
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tgcMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgKPI, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgReceipt, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Protected lcMain As DevExpress.XtraLayout.LayoutControl
		Protected lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private sbOK As DevExpress.XtraEditors.SimpleButton
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private ucPeriodKPI As DevExpress.VideoRent.Win.Controls.ucPeriod
		Private ucPeriodReport As DevExpress.VideoRent.Win.Controls.ucPeriod
		Private tgcMain As DevExpress.XtraLayout.TabbedControlGroup
		Private lcgKPI As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private lcgReceipt As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmReceiptGridOptions
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
			Me.ceGroupRowFooter = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceIndicator = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceDetailTabs = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceVertLines = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceAutoFilterRow = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ceViewCaption = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceGroupRowFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIndicator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceDetailTabs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceVertLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceViewCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.ceViewCaption)
			Me.lcMain.Controls.Add(Me.ceAutoFilterRow)
			Me.lcMain.Controls.Add(Me.ceDetailTabs)
			Me.lcMain.Controls.Add(Me.ceIndicator)
			Me.lcMain.Controls.Add(Me.ceGroupRowFooter)
			Me.lcMain.Controls.Add(Me.ceVertLines)
			Me.lcMain.Size = New System.Drawing.Size(222, 195)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem6})
			Me.lcgMain.Size = New System.Drawing.Size(222, 195)
			' 
			' ceGroupRowFooter
			' 
			Me.ceGroupRowFooter.Location = New System.Drawing.Point(2, 46)
			Me.ceGroupRowFooter.Name = "ceGroupRowFooter"
			Me.ceGroupRowFooter.Properties.Caption = "Show group row footer"
			Me.ceGroupRowFooter.Size = New System.Drawing.Size(218, 18)
			Me.ceGroupRowFooter.StyleController = Me.lcMain
			Me.ceGroupRowFooter.TabIndex = 4
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.ceGroupRowFooter
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 44)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(222, 22)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' ceIndicator
			' 
			Me.ceIndicator.Location = New System.Drawing.Point(2, 68)
			Me.ceIndicator.Name = "ceIndicator"
			Me.ceIndicator.Properties.Caption = "Show indicator"
			Me.ceIndicator.Size = New System.Drawing.Size(218, 18)
			Me.ceIndicator.StyleController = Me.lcMain
			Me.ceIndicator.TabIndex = 5
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.ceIndicator
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 66)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(222, 22)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' ceDetailTabs
			' 
			Me.ceDetailTabs.Location = New System.Drawing.Point(2, 24)
			Me.ceDetailTabs.Name = "ceDetailTabs"
			Me.ceDetailTabs.Properties.Caption = "Show detail tabs"
			Me.ceDetailTabs.Size = New System.Drawing.Size(218, 18)
			Me.ceDetailTabs.StyleController = Me.lcMain
			Me.ceDetailTabs.TabIndex = 6
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.ceDetailTabs
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 22)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(222, 22)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' ceVertLines
			' 
			Me.ceVertLines.Location = New System.Drawing.Point(2, 90)
			Me.ceVertLines.Name = "ceVertLines"
			Me.ceVertLines.Properties.Caption = "Show vertical lines"
			Me.ceVertLines.Size = New System.Drawing.Size(218, 18)
			Me.ceVertLines.StyleController = Me.lcMain
			Me.ceVertLines.TabIndex = 7
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.ceVertLines
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 88)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(222, 22)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' ceAutoFilterRow
			' 
			Me.ceAutoFilterRow.Location = New System.Drawing.Point(2, 2)
			Me.ceAutoFilterRow.Name = "ceAutoFilterRow"
			Me.ceAutoFilterRow.Properties.Caption = "Show auto filter row"
			Me.ceAutoFilterRow.Size = New System.Drawing.Size(218, 18)
			Me.ceAutoFilterRow.StyleController = Me.lcMain
			Me.ceAutoFilterRow.TabIndex = 8
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.ceAutoFilterRow
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(222, 22)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' ceViewCaption
			' 
			Me.ceViewCaption.Location = New System.Drawing.Point(2, 112)
			Me.ceViewCaption.Name = "ceViewCaption"
			Me.ceViewCaption.Properties.Caption = "Show view caption"
			Me.ceViewCaption.Size = New System.Drawing.Size(218, 18)
			Me.ceViewCaption.StyleController = Me.lcMain
			Me.ceViewCaption.TabIndex = 6
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.ceViewCaption
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 110)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(222, 77)
			Me.layoutControlItem6.Text = "layoutControlItem6"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' frmReceiptGridOptions
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(246, 241)
			Me.Name = "frmReceiptGridOptions"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceGroupRowFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIndicator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceDetailTabs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceVertLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceViewCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ceIndicator As DevExpress.XtraEditors.CheckEdit
		Private ceGroupRowFooter As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private ceDetailTabs As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private ceVertLines As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private ceAutoFilterRow As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private ceViewCaption As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

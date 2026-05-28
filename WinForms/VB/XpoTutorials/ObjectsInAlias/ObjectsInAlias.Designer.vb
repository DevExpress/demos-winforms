Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class ObjectsInAlias
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.gcMain = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gcMain
			' 
			Me.gcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gcMain.Location = New System.Drawing.Point(0, 0)
			Me.gcMain.MainView = Me.gridView1
			Me.gcMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.gcMain.Name = "gcMain"
			Me.gcMain.Size = New System.Drawing.Size(736, 465)
			Me.gcMain.TabIndex = 0
			Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gcMain
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' ObjectsInAlias
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gcMain)
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Name = "ObjectsInAlias"
			Me.Size = New System.Drawing.Size(736, 465)
			CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gcMain As DevExpress.XtraGrid.GridControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace

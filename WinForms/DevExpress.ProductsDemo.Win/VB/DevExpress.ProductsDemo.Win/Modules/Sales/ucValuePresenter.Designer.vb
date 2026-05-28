Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucValuePresenter
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
			Me.labelTitle = New System.Windows.Forms.Label()
			Me.labelValue = New System.Windows.Forms.Label()
			Me.labelLine = New System.Windows.Forms.Label()
			Me.tableLayoutPanel7.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tableLayoutPanel7
			' 
			Me.tableLayoutPanel7.ColumnCount = 3
			Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F))
			Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F))
			Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel7.Controls.Add(Me.labelTitle, 2, 0)
			Me.tableLayoutPanel7.Controls.Add(Me.labelValue, 2, 1)
			Me.tableLayoutPanel7.Controls.Add(Me.labelLine, 0, 0)
			Me.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
			Me.tableLayoutPanel7.RowCount = 2
			Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F))
			Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F))
			Me.tableLayoutPanel7.Size = New System.Drawing.Size(374, 150)
			Me.tableLayoutPanel7.TabIndex = 4
			' 
			' labelTitle
			' 
			Me.labelTitle.AutoSize = True
			Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelTitle.ForeColor = System.Drawing.Color.Gray
			Me.labelTitle.Location = New System.Drawing.Point(9, 0)
			Me.labelTitle.Name = "labelTitle"
			Me.labelTitle.Size = New System.Drawing.Size(362, 45)
			Me.labelTitle.TabIndex = 0
			Me.labelTitle.Text = "title"
			Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' labelValue
			' 
			Me.labelValue.AutoSize = True
			Me.labelValue.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelValue.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelValue.Location = New System.Drawing.Point(9, 45)
			Me.labelValue.Name = "labelValue"
			Me.labelValue.Size = New System.Drawing.Size(362, 105)
			Me.labelValue.TabIndex = 1
			Me.labelValue.Text = "value"
			Me.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' labelLine
			' 
			Me.labelLine.BackColor = System.Drawing.Color.Silver
			Me.labelLine.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelLine.Location = New System.Drawing.Point(0, 0)
			Me.labelLine.Margin = New System.Windows.Forms.Padding(0)
			Me.labelLine.Name = "labelLine"
			Me.tableLayoutPanel7.SetRowSpan(Me.labelLine, 2)
			Me.labelLine.Size = New System.Drawing.Size(1, 150)
			Me.labelLine.TabIndex = 2
			' 
			' ucValuePresenter
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel7)
			Me.Name = "ucValuePresenter"
			Me.Size = New System.Drawing.Size(374, 150)
			Me.tableLayoutPanel7.ResumeLayout(False)
			Me.tableLayoutPanel7.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
		Private labelTitle As System.Windows.Forms.Label
		Private labelValue As System.Windows.Forms.Label
		Private labelLine As System.Windows.Forms.Label
	End Class
End Namespace

Namespace DevExpress.XtraGauges.Demos

    Partial Class GaugesDashboard

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGauges.Demos.GaugesDashboard))
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.electricityGauge = New DevExpress.XtraGauges.Demos.GaugeContent()
            Me.hotWGauge = New DevExpress.XtraGauges.Demos.GaugeContent()
            Me.coldWGauge = New DevExpress.XtraGauges.Demos.GaugeContent()
            Me.gasGauge = New DevExpress.XtraGauges.Demos.GaugeContent()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.Controls.Add(Me.electricityGauge, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.hotWGauge, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.coldWGauge, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.gasGauge, 0, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 2
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(681, 600)
            Me.tableLayoutPanel1.TabIndex = 5
            ' 
            ' electricityGauge
            ' 
            Me.electricityGauge.Caption = "Electricity"
            Me.electricityGauge.Color = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((171)))))), (CInt(((CByte((24)))))))
            Me.electricityGauge.Dock = System.Windows.Forms.DockStyle.Fill
            Me.electricityGauge.Hot = False
            Me.electricityGauge.Image = CType((resources.GetObject("electricityGauge.Image")), System.Drawing.Image)
            Me.electricityGauge.Location = New System.Drawing.Point(343, 303)
            Me.electricityGauge.Name = "electricityGauge"
            Me.electricityGauge.Padding = New System.Windows.Forms.Padding(0, 15, 70, 20)
            Me.electricityGauge.Selected = False
            Me.electricityGauge.Size = New System.Drawing.Size(335, 294)
            Me.electricityGauge.TabIndex = 3
            ' 
            ' hotWGauge
            ' 
            Me.hotWGauge.Caption = "Hot Water"
            Me.hotWGauge.Color = System.Drawing.Color.FromArgb((CInt(((CByte((249)))))), (CInt(((CByte((53)))))), (CInt(((CByte((67)))))))
            Me.hotWGauge.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hotWGauge.Hot = False
            Me.hotWGauge.Image = CType((resources.GetObject("hotWGauge.Image")), System.Drawing.Image)
            Me.hotWGauge.Location = New System.Drawing.Point(3, 303)
            Me.hotWGauge.Name = "hotWGauge"
            Me.hotWGauge.Padding = New System.Windows.Forms.Padding(70, 15, 0, 20)
            Me.hotWGauge.Selected = False
            Me.hotWGauge.Size = New System.Drawing.Size(334, 294)
            Me.hotWGauge.TabIndex = 2
            ' 
            ' coldWGauge
            ' 
            Me.coldWGauge.Caption = "Cold Water"
            Me.coldWGauge.Color = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((190)))))), (CInt(((CByte((251)))))))
            Me.coldWGauge.Dock = System.Windows.Forms.DockStyle.Fill
            Me.coldWGauge.Hot = False
            Me.coldWGauge.Image = CType((resources.GetObject("coldWGauge.Image")), System.Drawing.Image)
            Me.coldWGauge.Location = New System.Drawing.Point(343, 3)
            Me.coldWGauge.Name = "coldWGauge"
            Me.coldWGauge.Padding = New System.Windows.Forms.Padding(0, 30, 70, 0)
            Me.coldWGauge.Selected = False
            Me.coldWGauge.Size = New System.Drawing.Size(335, 294)
            Me.coldWGauge.TabIndex = 1
            ' 
            ' gasGauge
            ' 
            Me.gasGauge.Caption = "Gas"
            Me.gasGauge.Color = System.Drawing.Color.FromArgb((CInt(((CByte((4)))))), (CInt(((CByte((178)))))), (CInt(((CByte((121)))))))
            Me.gasGauge.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gasGauge.Hot = False
            Me.gasGauge.Image = CType((resources.GetObject("gasGauge.Image")), System.Drawing.Image)
            Me.gasGauge.Location = New System.Drawing.Point(3, 3)
            Me.gasGauge.Name = "gasGauge"
            Me.gasGauge.Padding = New System.Windows.Forms.Padding(70, 30, 0, 0)
            Me.gasGauge.Selected = False
            Me.gasGauge.Size = New System.Drawing.Size(334, 294)
            Me.gasGauge.TabIndex = 0
            ' 
            ' GaugesDashboard
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "GaugesDashboard"
            Me.Size = New System.Drawing.Size(681, 600)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private electricityGauge As DevExpress.XtraGauges.Demos.GaugeContent

        Private hotWGauge As DevExpress.XtraGauges.Demos.GaugeContent

        Private coldWGauge As DevExpress.XtraGauges.Demos.GaugeContent

        Private gasGauge As DevExpress.XtraGauges.Demos.GaugeContent
    End Class
End Namespace

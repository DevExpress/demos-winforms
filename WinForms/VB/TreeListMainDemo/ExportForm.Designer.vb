Namespace DevExpress.XtraTreeList.Demos

    Partial Class ExportForm

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.ExportForm))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            CType((Me.pictureBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBox1.Image = CType((resources.GetObject("pictureBox1.Image")), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(10, 10)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(204, 30)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            ' 
            ' ExportForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(224, 50)
            Me.ControlBox = False
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ExportForm"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.TopMost = True
            CType((Me.pictureBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.Container = Nothing

        Private pictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace

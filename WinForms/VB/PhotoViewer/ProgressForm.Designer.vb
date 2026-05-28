Namespace PhotoViewer

    Partial Class ProgressForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.progressControl1 = New PhotoViewer.ProgressControl()
            Me.SuspendLayout()
            ' 
            ' progressControl1
            ' 
            Me.progressControl1.Location = New System.Drawing.Point(0, 0)
            Me.progressControl1.Maximum = 100
            Me.progressControl1.Name = "progressControl1"
            Me.progressControl1.Size = New System.Drawing.Size(355, 57)
            Me.progressControl1.TabIndex = 0
            Me.progressControl1.Value = 0
            ' 
            ' ProgressForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(355, 57)
            Me.Controls.Add(Me.progressControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "ProgressForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "ProgressForm"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private progressControl1 As PhotoViewer.ProgressControl
    End Class
End Namespace

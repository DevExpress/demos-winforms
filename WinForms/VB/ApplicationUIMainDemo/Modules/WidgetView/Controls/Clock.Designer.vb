Namespace DevExpress.ApplicationUI.Demos

    Partial Class Clock

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.SuspendLayout()
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(245, 174)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' DateTime
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.labelControl1)
            Me.Name = "DateTime"
            Me.Size = New System.Drawing.Size(245, 174)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

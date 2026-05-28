Namespace DevExpress.ApplicationUI.Demos

    Partial Class ucCardWidget

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.labelControl1 = New DevExpress.ApplicationUI.Demos.OverviewLabel()
            Me.SuspendLayout()
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 5)
            Me.labelControl1.Size = New System.Drawing.Size(392, 156)
            Me.labelControl1.StateIndex = 0
            Me.labelControl1.TabIndex = 19
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' smallWidget
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.labelControl1)
            Me.Name = "smallWidget"
            Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.Size = New System.Drawing.Size(402, 156)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private labelControl1 As DevExpress.ApplicationUI.Demos.OverviewLabel
    End Class
End Namespace

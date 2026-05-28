Namespace DevExpress.ApplicationUI.Demos

    Partial Class StartupMDIDemos

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
            Me.sbClose = New DevExpress.XtraEditors.SimpleButton()
            Me.sbStart = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' sbClose
            ' 
            Me.sbClose.Location = New System.Drawing.Point(21, 49)
            Me.sbClose.Name = "sbClose"
            Me.sbClose.Size = New System.Drawing.Size(136, 26)
            Me.sbClose.TabIndex = 3
            Me.sbClose.Text = "Close Sample"
            AddHandler Me.sbClose.Click, New System.EventHandler(AddressOf Me.sbClose_Click)
            ' 
            ' sbStart
            ' 
            Me.sbStart.Location = New System.Drawing.Point(21, 17)
            Me.sbStart.Name = "sbStart"
            Me.sbStart.Size = New System.Drawing.Size(136, 26)
            Me.sbStart.TabIndex = 2
            Me.sbStart.Text = "Launch Sample"
            AddHandler Me.sbStart.Click, New System.EventHandler(AddressOf Me.sbStart_Click)
            ' 
            ' StartupMDIDemos
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sbStart)
            Me.Controls.Add(Me.sbClose)
            Me.Name = "StartupMDIDemos"
            Me.Size = New System.Drawing.Size(774, 437)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sbClose As DevExpress.XtraEditors.SimpleButton

        Private sbStart As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

Namespace DevExpress.XtraLayout.Demos

    Partial Class Layout

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.components = New System.ComponentModel.Container()
            Me.sbOpen = New DevExpress.XtraEditors.SimpleButton()
            Me.sbDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            ' 
            ' sbOpen
            ' 
            Me.sbOpen.Location = New System.Drawing.Point(8, 8)
            Me.sbOpen.Name = "sbOpen"
            Me.sbOpen.Size = New System.Drawing.Size(96, 24)
            Me.sbOpen.TabIndex = 0
            Me.sbOpen.Text = "Open Form"
            AddHandler Me.sbOpen.Click, New System.EventHandler(AddressOf Me.sbOpen_Click)
            ' 
            ' sbDelete
            ' 
            Me.sbDelete.Location = New System.Drawing.Point(108, 8)
            Me.sbDelete.Name = "sbDelete"
            Me.sbDelete.Size = New System.Drawing.Size(132, 24)
            Me.sbDelete.TabIndex = 1
            Me.sbDelete.Text = "Delete xml file"
            AddHandler Me.sbDelete.Click, New System.EventHandler(AddressOf Me.sbDelete_Click)
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 500
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.timer1_Tick)
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(8, 39)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(182, 17)
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "Enable quick customization mode"
            Me.checkBox1.UseVisualStyleBackColor = True
            ' 
            ' Layout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.sbDelete)
            Me.Controls.Add(Me.sbOpen)
            Me.Name = "Layout"
            Me.Size = New System.Drawing.Size(459, 272)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Layout_Load)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private sbOpen As DevExpress.XtraEditors.SimpleButton

        Private sbDelete As DevExpress.XtraEditors.SimpleButton

        Private timer1 As System.Windows.Forms.Timer

        Private components As System.ComponentModel.IContainer = Nothing

        Private checkBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace

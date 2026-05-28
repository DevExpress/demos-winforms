Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Partial Class frmPad

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.RibbonSimplePad.frmPad))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.HideSelection = False
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(347, 201)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = ""
            AddHandler Me.richTextBox1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.richTextBox1_MouseUp)
            ' 
            ' frmPad
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(347, 201)
            Me.Controls.Add(Me.richTextBox1)
            Me.Icon = CType((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.Name = "frmPad"
            Me.Text = "frmPad"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.frmPad_Closing)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richTextBox1 As System.Windows.Forms.RichTextBox

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace

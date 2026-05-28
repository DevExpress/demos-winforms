Namespace DevExpress.ApplicationUI.Demos

    Partial Class Mail

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
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.SuspendLayout()
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.labelControl1.Location = New System.Drawing.Point(13, 3)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "●  <href><b>Inbox(1)</href></b>"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.AllowHtmlString = True
            Me.labelControl2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.labelControl2.Location = New System.Drawing.Point(13, 22)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(49, 13)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "●  <href>Outbox</href>"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.AllowHtmlString = True
            Me.labelControl3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.labelControl3.Location = New System.Drawing.Point(13, 41)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(65, 13)
            Me.labelControl3.TabIndex = 2
            Me.labelControl3.Text = "●  <href>Sent Items</href>"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.AllowHtmlString = True
            Me.labelControl4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.labelControl4.Location = New System.Drawing.Point(13, 60)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(80, 13)
            Me.labelControl4.TabIndex = 3
            Me.labelControl4.Text = "●  <href>Deleted Items</href>"
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.AllowHtmlString = True
            Me.labelControl5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.labelControl5.Location = New System.Drawing.Point(13, 79)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(43, 13)
            Me.labelControl5.TabIndex = 4
            Me.labelControl5.Text = "●  <href>Drafts</href>"
            ' 
            ' Mail
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.labelControl5)
            Me.Controls.Add(Me.labelControl4)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Name = "Mail"
            Me.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
            Me.Size = New System.Drawing.Size(144, 130)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private labelControl5 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

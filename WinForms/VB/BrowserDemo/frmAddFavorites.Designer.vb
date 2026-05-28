Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Partial Class frmAddFavorites

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
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.textBox1 = New DevExpress.XtraEditors.TextEdit()
            Me.textBox2 = New DevExpress.XtraEditors.TextEdit()
            CType((Me.pictureBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textBox1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textBox2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(48, 4)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(230, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Browser will add this page to your Favorites list."
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Location = New System.Drawing.Point(4, 4)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(40, 40)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(4, 50)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(31, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Name:"
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(4, 74)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(23, 13)
            Me.label3.TabIndex = 3
            Me.label3.Text = "URL:"
            ' 
            ' btnOK
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(312, 4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(80, 24)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "&OK"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(312, 32)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 24)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancel"
            ' 
            ' textBox1
            ' 
            Me.textBox1.EditValue = "textBox1"
            Me.textBox1.Location = New System.Drawing.Point(44, 48)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(252, 20)
            Me.textBox1.TabIndex = 6
            ' 
            ' textBox2
            ' 
            Me.textBox2.EditValue = "textBox2"
            Me.textBox2.Location = New System.Drawing.Point(44, 72)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(252, 20)
            Me.textBox2.TabIndex = 7
            ' 
            ' frmAddFavorites
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(398, 99)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAddFavorites"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Add Favorite"
            CType((Me.pictureBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textBox1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textBox2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private label1 As DevExpress.XtraEditors.LabelControl

        Private pictureBox1 As System.Windows.Forms.PictureBox

        Private label2 As DevExpress.XtraEditors.LabelControl

        Private label3 As DevExpress.XtraEditors.LabelControl

        Private btnOK As DevExpress.XtraEditors.SimpleButton

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private textBox1 As DevExpress.XtraEditors.TextEdit

        Private textBox2 As DevExpress.XtraEditors.TextEdit

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace

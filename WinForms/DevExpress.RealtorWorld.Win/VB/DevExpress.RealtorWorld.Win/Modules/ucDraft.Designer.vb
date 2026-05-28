Namespace DevExpress.RealtorWorld.Win

    Partial Class ucDraft

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
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureEdit1.EditValue = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Under_Construction
            Me.pictureEdit1.Location = New System.Drawing.Point(0, 0)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowFocused = False
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Properties.ShowMenu = False
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit1.Size = New System.Drawing.Size(573, 334)
            Me.pictureEdit1.TabIndex = 0
            ' 
            ' ucDraft
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pictureEdit1)
            Me.Name = "ucDraft"
            Me.Size = New System.Drawing.Size(573, 334)
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    End Class
End Namespace

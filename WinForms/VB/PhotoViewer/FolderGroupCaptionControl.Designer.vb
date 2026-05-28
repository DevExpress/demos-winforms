Namespace PhotoViewer

    Partial Class FolderGroupCaptionControl

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
        Private Overloads Sub InitializeComponent()
            Me.SuspendLayout()
            ' 
            ' nameLabel
            ' 
            Me.nameLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.nameLabel.Appearance.Options.UseFont = True
            Me.nameLabel.Size = New System.Drawing.Size(89, 21)
            Me.nameLabel.Text = "FolderName"
            ' 
            ' dataLabel
            ' 
            Me.dataLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.dataLabel.Appearance.Options.UseFont = True
            ' 
            ' groupIcon
            ' 
            Me.groupIcon.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.groupIcon.Appearance.Image = Global.PhotoViewer.Properties.Resources.Folder_32x32
            Me.groupIcon.Appearance.Options.UseFont = True
            Me.groupIcon.Appearance.Options.UseImage = True
            Me.groupIcon.Cursor = System.Windows.Forms.Cursors.Hand
            ' 
            ' editLabel
            ' 
            Me.editLabel.Appearance.Image = Global.PhotoViewer.Properties.Resources.Edit_16x16
            Me.editLabel.Appearance.Options.UseImage = True
            Me.editLabel.Location = New System.Drawing.Point(162, 18)
            Me.editLabel.Visible = False
            ' 
            ' removeLabel
            ' 
            Me.removeLabel.Appearance.Image = Global.PhotoViewer.Properties.Resources.RemoveAlbum_16x16
            Me.removeLabel.Appearance.Options.UseImage = True
            Me.removeLabel.Location = New System.Drawing.Point(189, 18)
            Me.removeLabel.ToolTip = "Remove folder from list"
            ' 
            ' collageLabel
            ' 
            Me.collageLabel.Appearance.Image = Global.PhotoViewer.Properties.Resources.Collage_16x16
            Me.collageLabel.Appearance.Options.UseImage = True
            Me.collageLabel.Location = New System.Drawing.Point(226, 18)
            Me.collageLabel.ToolTip = "Make collage"
            ' 
            ' slideshowLabel
            ' 
            Me.slideshowLabel.Appearance.Image = Global.PhotoViewer.Properties.Resources.Slideshow_16x16
            Me.slideshowLabel.Appearance.Options.UseImage = True
            Me.slideshowLabel.Location = New System.Drawing.Point(253, 18)
            Me.slideshowLabel.ToolTip = "Make slideshow"
            ' 
            ' filmLabel
            ' 
            Me.filmLabel.Appearance.Image = Global.PhotoViewer.Properties.Resources.Film_16x16
            Me.filmLabel.Appearance.Options.UseImage = True
            Me.filmLabel.Location = New System.Drawing.Point(280, 18)
            Me.filmLabel.ToolTip = "Make film"
            ' 
            ' separatorLabel
            ' 
            Me.separatorLabel.Location = New System.Drawing.Point(216, 22)
            ' 
            ' FolderGroupCaptionControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "FolderGroupCaptionControl"
            Me.Size = New System.Drawing.Size(310, 56)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace

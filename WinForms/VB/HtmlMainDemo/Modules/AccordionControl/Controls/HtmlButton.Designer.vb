Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Partial Class HtmlButton

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Modules.AccordionControl.Controls.HtmlButton))
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' htmlContentControl1
            ' 
            Me.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles")
            Me.htmlContentControl1.HtmlTemplate.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""button"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""button_text"">${Text" & "}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            Me.htmlContentControl1.Location = New System.Drawing.Point(0, 0)
            Me.htmlContentControl1.Name = "htmlContentControl1"
            Me.htmlContentControl1.Size = New System.Drawing.Size(291, 50)
            Me.htmlContentControl1.TabIndex = 0
            ' 
            ' HtmlButton
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.htmlContentControl1)
            Me.Name = "HtmlButton"
            Me.Size = New System.Drawing.Size(291, 50)
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl
    End Class
End Namespace

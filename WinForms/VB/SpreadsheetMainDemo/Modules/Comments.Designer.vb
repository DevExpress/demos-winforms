Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class CommentsModule

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
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Size = New System.Drawing.Size(725, 142)
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Size = New System.Drawing.Size(725, 289)
            ' 
            ' CommentsModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "CommentsModule"
            Me.Size = New System.Drawing.Size(725, 456)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace

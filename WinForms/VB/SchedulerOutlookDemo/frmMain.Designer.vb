Namespace DevExpress.XtraScheduler.Demos

    Partial Class frmMain

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
            Me.sharedDictionaryStorage = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
            Me.SuspendLayout()
            ' 
            ' frmMain
            ' 
            Me.Name = "frmMain"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private sharedDictionaryStorage As DevExpress.XtraSpellChecker.SharedDictionaryStorage
    End Class
End Namespace

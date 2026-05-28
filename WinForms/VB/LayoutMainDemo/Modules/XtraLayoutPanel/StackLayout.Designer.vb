Namespace DevExpress.XtraLayout.Demos

    Partial Class StackLayout

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
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(880, 335, 650, 400)
            ' 
            ' liPropertyGrid
            ' 
            Me.liPropertyGrid.Size = New System.Drawing.Size(249, 202)
            ' 
            ' lcgOptions
            ' 
            Me.lcgOptions.Location = New System.Drawing.Point(0, 194)
            Me.lcgOptions.Size = New System.Drawing.Size(249, 392)
            ' 
            ' lcgToolbox
            ' 
            Me.lcgToolbox.Size = New System.Drawing.Size(249, 194)
            ' 
            ' liResetLayout
            ' 
            Me.liResetLayout.Location = New System.Drawing.Point(0, 202)
            Me.liResetLayout.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 2)
            Me.liResetLayout.Size = New System.Drawing.Size(249, 24)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 226)
            Me.emptySpaceItem.Size = New System.Drawing.Size(249, 144)
            ' 
            ' StackLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "StackLayout"
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace

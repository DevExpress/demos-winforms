Namespace DevExpress.XtraRichEdit.Demos

    Partial Class DynamicContentModule

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
            Me.components = New System.ComponentModel.Container()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(845, 389)
            Me.richEditControl.TabIndex = 0
            AddHandler Me.richEditControl.CalculateDocumentVariable, New DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(AddressOf Me.richEditControl_CalculateDocumentVariable)
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' DynamicContentModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl)
            Me.Name = "DynamicContentModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    End Class
End Namespace

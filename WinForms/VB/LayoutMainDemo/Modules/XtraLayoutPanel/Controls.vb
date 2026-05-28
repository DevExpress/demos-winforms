Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraLayout.Demos.Controls

    Friend Interface ICustomControl
    End Interface

    Friend Class CustomSimpleButton
        Inherits SimpleButton
        Implements ICustomControl

        Public Sub New()
            Text = "SimpleButton"
            Name = "CustomSimpleButton"
        End Sub
    End Class

    Friend Class CustomLabelControl
        Inherits LabelControl
        Implements ICustomControl

        Public Sub New()
            SetStyle(ControlStyles.Selectable, True)
            Text = "LabelControl"
            Name = "CustomLabelControl"
        End Sub
    End Class

    Friend Class CustomCheckEdit
        Inherits CheckEdit
        Implements ICustomControl

        Public Sub New()
            Text = "CheckEdit"
            Name = "CustomCheckEdit"
        End Sub
    End Class

    Friend Class CustomTextEdit
        Inherits TextEdit
        Implements ICustomControl

        Public Sub New()
            Text = "TextEdit"
            Name = "CustomTextEdit"
        End Sub
    End Class

    Friend Module CustomControlFactory

        Public Function CreateControl(ByVal controlType As Type) As Control
            If controlType Is GetType(SimpleButton) Then
                Return New CustomSimpleButton()
            ElseIf controlType Is GetType(CheckEdit) Then
                Return New CustomCheckEdit()
            ElseIf controlType Is GetType(TextEdit) Then
                Return New CustomTextEdit()
            ElseIf controlType Is GetType(LabelControl) Then
                Return New CustomLabelControl()
            Else
                Throw New ArgumentException("controlType")
            End If
        End Function
    End Module
End Namespace

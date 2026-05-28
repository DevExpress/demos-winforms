Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    ''' <summary>
    ''' Summary description for PopupControlContainer.
    ''' </summary>
    Public Partial Class PopupControlContainer
        Inherits TutorialControlBase

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            CurrentLabel.Font = New Font(CurrentLabel.Font.Name, 14, FontStyle.Bold)
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private ReadOnly Property CurrentLabel As Label
            Get
                Return label1
            End Get
        End Property

        Private Sub popupControlContainer1_Popup(ByVal sender As Object, ByVal e As System.EventArgs)
            alignmentControl1.Alignment = CurrentLabel.TextAlign
        End Sub

        Private Sub alignmentControl1_AlignmentChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            CurrentLabel.TextAlign = alignmentControl1.Alignment
        End Sub
    End Class
End Namespace

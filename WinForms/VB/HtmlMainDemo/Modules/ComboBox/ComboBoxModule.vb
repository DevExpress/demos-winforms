Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers

Namespace DevExpress.HTML.Demos

    Public Partial Class ComboBoxModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            comboBoxTemplateViewer1.Fill(comboBoxEdit1)
            comboBoxEdit1.Properties.Items.AddRange(DataHelper.Employees)
            comboBoxEdit1.SelectedIndex = 2
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            BeginInvoke(New Action(Sub()
                If Not comboBoxEdit1.IsPopupOpen Then comboBoxEdit1.ShowPopup()
            End Sub))
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            comboBoxEdit1.ClosePopup()
        End Sub
    End Class
End Namespace

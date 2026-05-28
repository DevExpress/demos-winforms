Imports DevExpress.DXperience.Demos
Imports System
Imports System.Windows.Forms

Namespace DevExpress.DevAV

    Public Partial Class YearsControl
        Inherits UserControl

        Private callback As Action(Of String)

        Private defaultValue As String

        Public Sub New()
            InitializeComponent()
            AddYearItems()
        End Sub

        Public Sub New(ByVal callback As Action(Of String), ByVal defaultValue As String)
            Me.New()
            Me.defaultValue = defaultValue
            Me.callback = callback
        End Sub

        Private Sub AddYearItems()
            Dim yearItems = New XtraEditors.Controls.CheckedListBoxItem(4) {}
            Dim startYear As Integer = TutorialConstants.Now.Year - yearItems.Length + 1
            For i As Integer = 0 To yearItems.Length - 1
                Dim year As String =(startYear + i).ToString()
                yearItems(i) = New XtraEditors.Controls.CheckedListBoxItem(year, year)
            Next

            checkedComboBoxEdit1.Properties.Items.AddRange(yearItems)
            AddHandler checkedComboBoxEdit1.EditValueChanged, AddressOf checkedComboBoxEdit1_EditValueChanged
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            checkedComboBoxEdit1.EditValue = defaultValue
        End Sub

        Private Sub checkedComboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If callback IsNot Nothing Then callback(CStr(checkedComboBoxEdit1.EditValue))
        End Sub
    End Class
End Namespace

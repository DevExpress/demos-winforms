Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.DevAV

    Public Partial Class InvoiceSettingsControl
        Inherits UserControl

        Private ReadOnly settingList As List(Of Tuple(Of String, Boolean, Action(Of Boolean)))

        Private Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal settingList As List(Of Tuple(Of String, Boolean, Action(Of Boolean))))
            Me.New()
            Me.settingList = settingList
            checkedListBoxControl1.Items.Clear()
            For Each setting As Tuple(Of String, Boolean, Action(Of Boolean)) In settingList
                checkedListBoxControl1.Items.Add(setting.Item1, setting.Item2)
            Next
        End Sub

        Private Sub checkedListBoxControl1_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            settingList(e.Index).Item3.Invoke(e.State = CheckState.Checked)
        End Sub
    End Class
End Namespace

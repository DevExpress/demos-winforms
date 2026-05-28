Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.DockingDemo

    Public Partial Class ucProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            propertyGrid.PropertyGrid.AutoGenerateRows = True
            AddControls(Me, comboBox)
            comboBox.SelectedIndex = 0
        End Sub

        Private Sub comboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            propertyGrid.PropertyGrid.SelectedObject = comboBox.SelectedItem
        End Sub

        Private Sub AddControls(ByVal container As Control, ByVal cb As ComboBoxEdit)
            For Each obj As Object In container.Controls
                cb.Properties.Items.Add(obj)
                If TypeOf obj Is Control Then AddControls(TryCast(obj, Control), cb)
            Next
        End Sub
    End Class
End Namespace

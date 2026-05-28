Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.Xpo.Demos
    Partial Public Class QueryingData
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub QueryingData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' If the 'Customer' table is empty, adds new records and reloads the xpCustomers collection.
            If xpCustomers.Count = 0 Then
                CreateCustomers()
                xpCustomers.Reload()
            End If
        End Sub

        Private Sub repositoryItemImageComboBox1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemImageComboBox1.ButtonClick
            Dim editor As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            If e.Button.Kind <> ButtonPredefines.Close Then
                Return
            End If
            ClearFilter(IsClient(barManager1.ActiveEditItemLink.Item))
            editor.EditValue = Nothing
            barManager1.ActiveEditItemLink.PostEditor()
        End Sub

        Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles barEditItem1.EditValueChanged, barEditItem2.EditValueChanged
            Dim barItem As BarEditItem = TryCast(sender, BarEditItem)
            Dim isClient As Boolean = Me.IsClient(barItem)

            'gridView1.CollapseAllDetails();

            If barItem.EditValue Is Nothing Then
                ClearFilter(isClient)
                Return
            End If
            Dim filterString As String = barItem.EditValue.ToString()
            If isClient Then
                xpCustomers.Filter = CriteriaOperator.Parse(filterString)
            Else
                xpCustomers.Criteria = CriteriaOperator.Parse(filterString)
            End If
            UpdateStatusBar(isClient, filterString)
        End Sub

        Private Function IsClient(ByVal barItem As BarItem) As Boolean
            Return barItem.Tag.ToString() = "Client"
        End Function

        Private Sub ClearFilter(ByVal isClient As Boolean)
            If isClient Then
                xpCustomers.Filter = Nothing
            Else
                xpCustomers.Criteria = Nothing
            End If
            UpdateStatusBar(isClient, "(no filter)")
        End Sub

        Private Sub UpdateStatusBar(ByVal isClient As Boolean, ByVal filterString As String)
            If isClient Then
                barStaticItemClient.Caption = "Filter String (client): " & filterString
            Else
                barStaticItemDataStore.Caption = "Filter String (data store): " & filterString
            End If
        End Sub

        Public Overrides Sub ReloadData()
            xpCustomers.Reload()
        End Sub
    End Class
End Namespace

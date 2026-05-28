Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraRichEdit.Demos.Forms

    Public Enum MergeDestination
        NewTab
        File
    End Enum

    Public Enum MergeRecords
        All
        Current
        Selected
        FromInterval
    End Enum

    Public Partial Class MergeDatabaseRecordsForm
        Inherits XtraForm

        Private _mergeRecords As MergeRecords

        Private _mergeDestination As MergeDestination

        Public Sub New()
            InitializeComponent()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MergeDestination As MergeDestination
            Get
                Return _mergeDestination
            End Get

            Set(ByVal value As MergeDestination)
                _mergeDestination = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MergeRecords As MergeRecords
            Get
                Return _mergeRecords
            End Get

            Set(ByVal value As MergeRecords)
                _mergeRecords = value
            End Set
        End Property

        Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs)
            MergeRecords = GetMergeRecords()
            MergeDestination = CType(rgMergeTo.SelectedIndex, MergeDestination)
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Function GetMergeRecords() As MergeRecords
            Return If(rgMergeRecords.SelectedIndex = 0, MergeRecords.Selected, MergeRecords.All)
        End Function

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class frmProduct
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property NewProductName As String
            Get
                Return teProductName.Text
            End Get
        End Property

        Public ReadOnly Property CategoryID As Integer
            Get
                Return CInt(icbCategory.EditValue)
            End Get
        End Property

        Public ReadOnly Property QuantityPerUnit As String
            Get
                Return teQuantityPerUnit.Text
            End Get
        End Property

        Public ReadOnly Property UnitPrice As Decimal
            Get
                Return seUnitPrice.Value
            End Get
        End Property

        Public ReadOnly Property Discontinued As Boolean
            Get
                Return ceDiscontinued.Checked
            End Get
        End Property

        Private Sub frmProduct_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            e.Cancel = Not dxValidationProvider1.Validate() AndAlso DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace

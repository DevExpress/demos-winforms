Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for UserControl1.
    ''' </summary>
    Public Partial Class ValidationControl
        Inherits XtraUserControl

        Public Sub New()
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Private fCaption As String = String.Empty

        Public Event ValidateCondition As EventHandler

        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim visibleNextCondition As Boolean = CInt(imageComboBoxEdit1.EditValue) < 2
            spinEdit2.Visible = visibleNextCondition
            imageComboBoxEdit2.Visible = spinEdit2.Visible
            label2.Visible = imageComboBoxEdit2.Visible
            RaiseValidateCondition()
        End Sub

        Private Sub imageComboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            label2.Enabled = Not imageComboBoxEdit2.EditValue.Equals(0)
            spinEdit2.Visible = label2.Enabled
            RaiseValidateCondition()
        End Sub

        Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseValidateCondition()
        End Sub

        Protected Sub RaiseValidateCondition()
            RaiseEvent ValidateCondition(Me, New EventArgs())
        End Sub

        <Localizable(True)>
        <DefaultValue("")>
        Public Property Caption As String
            Get
                Return fCaption
            End Get

            Set(ByVal value As String)
                fCaption = value
                label1.Text = fCaption
            End Set
        End Property

        Public Function IsTrueCondition(ByVal val As Object) As Object()
            Dim reply As String = ""
            If val Is Nothing OrElse Convert.IsDBNull(val) Then Return New Object() {False, reply}
            Dim dValue As Decimal = Convert.ToDecimal(val)
            Dim value1 As Decimal = Convert.ToDecimal(spinEdit1.EditValue)
            Dim value2 As Decimal = Convert.ToDecimal(spinEdit2.EditValue)
            Dim condition1 As Integer = imageComboBoxEdit1.SelectedIndex
            Dim condition2 As Integer = imageComboBoxEdit2.SelectedIndex
            Dim greater As Boolean = False
            If condition1 = 2 Then
                reply = String.Format(Properties.Resources.ValueLess, value1)
                Return New Object() {dValue < value1, reply}
            End If

            If condition1 = 3 Then
                reply = String.Format(Properties.Resources.ValueLessEqual, value1)
                Return New Object() {dValue <= value1, reply}
            End If

            If condition1 = 4 Then
                reply = String.Format(Properties.Resources.ValueNotEqual, value1)
                Return New Object() {dValue <> value1, reply}
            End If

            If condition1 = 0 Then
                reply = String.Format(Properties.Resources.ValueGreater, value1)
                greater = dValue > value1
            End If

            If condition1 = 1 Then
                reply = String.Format(Properties.Resources.ValueGreaterEqual, value1)
                greater = dValue >= value1
            End If

            If condition2 = 0 Then Return New Object() {greater, reply}
            If greater Then
                If condition2 = 1 Then
                    reply = String.Format(Properties.Resources.ValueLess, value2)
                    Return New Object() {greater AndAlso dValue < value2, reply}
                End If

                If condition2 = 2 Then
                    reply = String.Format(Properties.Resources.ValueLessEqual, value2)
                    Return New Object() {greater AndAlso dValue <= value2, reply}
                End If
            End If

            Return New Object() {False, reply}
        End Function
    End Class
End Namespace

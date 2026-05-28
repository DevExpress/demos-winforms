Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for Appearances.
    ''' </summary>
    Public Partial Class Appearances
        Inherits XtraEditors.XtraForm

        Public Sub New(ByVal view As BaseView, ByVal parent As Form)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Left = parent.Left + (parent.Width - Width) \ 2
            Top = parent.Top + (parent.Height - Height) \ 2
            Me.view = view
            InitAppearanceList(view)
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private view As BaseView

        Private Sub InitAppearanceList(ByVal view As BaseView)
            lbcAppearances.Items.Clear()
            Dim app As ColumnViewAppearances = TryCast(view.Appearance, ColumnViewAppearances)
            If app Is Nothing Then Return
            Dim collection As PropertyDescriptorCollection = TypeDescriptor.GetProperties(view.Appearance)
            For i As Integer = 0 To collection.Count - 1
                If collection(i).PropertyType Is GetType(AppearanceObject) Then lbcAppearances.Items.Add(collection(i).Name)
            Next

            lbcAppearances.SelectedIndex = 0
        End Sub

        Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraPropertyGrid1.PropertyGrid.SelectedObjects = SelectedObjects
        End Sub

        Private Function GetAppearanceObjectByName(ByVal view As BaseView, ByVal name As String) As AppearanceObject
            Dim app As ColumnViewAppearances = TryCast(view.Appearance, ColumnViewAppearances)
            If app Is Nothing Then
                Return Nothing
            Else
                Return app.GetAppearance(name)
            End If
        End Function

        Private ReadOnly Property SelectedObjects As Object()
            Get
                If lbcAppearances.SelectedItem Is Nothing Then Return Nothing
                Dim ret As ArrayList = New ArrayList()
                For i As Integer = 0 To lbcAppearances.SelectedIndices.Count - 1
                    Dim obj As Object = GetAppearanceObjectByName(view, lbcAppearances.GetItem(lbcAppearances.SelectedIndices(i)).ToString())
                    ret.Add(obj)
                Next

                Return ret.ToArray()
            End Get
        End Property
    End Class
End Namespace

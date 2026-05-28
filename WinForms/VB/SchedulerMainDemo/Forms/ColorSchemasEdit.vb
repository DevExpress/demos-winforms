Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ColorSchemasEditForm
        Inherits XtraEditors.XtraForm

        Private fColorSchemas As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase)

        Public Sub New(ByVal lColorSchemas As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase), ByVal parent As Form)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Left = CInt(parent.Left + (parent.Width - Width) \ 2)
            Top = CInt(parent.Top + (parent.Height - Height) \ 2)
            fColorSchemas = lColorSchemas
            UpdateColorSchemaList()
        End Sub

        Public ReadOnly Property ColorSchemas As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase)
            Get
                Return fColorSchemas
            End Get
        End Property

        Private Sub UpdateColorSchemaList()
            lbTimeScales.Items.Clear()
            For i As Integer = 0 To ColorSchemas.Count - 1
                lbTimeScales.Items.Add(String.Format("{0}-{1}", ColorSchemas(i), i))
            Next

            lbTimeScales.SelectedIndex = 0
        End Sub

        Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            propertyGrid1.SelectedObjects = GetSelectedObjects()
        End Sub

        Private Function GetSelectedObjects() As Object()
            If lbTimeScales.SelectedItem Is Nothing Then Return Nothing
            Return New Object() {ColorSchemas(lbTimeScales.SelectedIndex)}
        End Function

        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            ColorSchemas.Add(New SchedulerColorSchema())
            UpdateColorSchemaList()
        End Sub

        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            ColorSchemas.RemoveAt(lbTimeScales.SelectedIndex)
            UpdateColorSchemaList()
        End Sub

        Private Sub btnDefaults_Click(ByVal sender As Object, ByVal e As EventArgs)
            ColorSchemas.LoadDefaults()
            UpdateColorSchemaList()
        End Sub
    End Class
End Namespace

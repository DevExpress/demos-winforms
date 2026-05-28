Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AppearanceModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property IsSchedulerAppearances As Boolean
            Get
                Return rgrpEdit.SelectedIndex = 0
            End Get
        End Property

        Protected ReadOnly Property IsViewAppearances As Boolean
            Get
                Return rgrpEdit.SelectedIndex = 1
            End Get
        End Property

        Protected ReadOnly Property IsResourceColorSchemas As Boolean
            Get
                Return rgrpEdit.SelectedIndex = 2
            End Get
        End Property

        Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
        End Sub

        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            If IsResourceColorSchemas Then
                EditColorSchemas(schedulerControl.ResourceColorSchemas)
            Else
                Dim app As BaseViewAppearance = If(IsSchedulerAppearances, schedulerControl.Appearance, schedulerControl.ActiveView.Appearance)
                EditAppearances(app)
            End If
        End Sub

        Private Sub EditAppearances(ByVal appearances As BaseAppearanceCollection)
            Dim frm As AppearancesEditForm = New AppearancesEditForm(appearances, FindForm())
            frm.ShowDialog()
        End Sub

        Private Sub EditColorSchemas(ByVal colorSchemas As SchedulerColorSchemaCollection)
            Dim frm As ColorSchemasEditForm = New ColorSchemasEditForm(colorSchemas, FindForm())
            frm.ShowDialog()
        End Sub
    End Class
End Namespace

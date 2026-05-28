Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Demos.Modules.Overview
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMultiSelectLookup
        Inherits TutorialControl

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMultiSelectLookup"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "multiselectlookup"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            assistantsBindingSource.DataSource = GetAssistants()
            Dim employee = GetReviewedEmployee()
            employeeBindingSource.DataSource = employee
            reviewsBindingSource.DataSource = employee.Reviews
            AssistantsLookup.Focus()
            OnEditValueChanged(AssistantsLookup, e)
        End Sub

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim assistants = TryCast(CType(sender, LookUpEditBase).EditValue, HashSet(Of Integer))
            If assistants Is Nothing OrElse assistants.Count = 0 Then
                validationHint1.Properties.State = VisualEffects.ValidationHintState.Invalid
            Else
                validationHint1.Properties.State = Nothing
            End If

            ' update corresponding grid row
            gridView1.RefreshRow(gridView1.GetRowHandle(reviewsBindingSource.Position))
        End Sub

        ' <AssistantsLookup>
        Private Sub SetupAssistantsLookup()
            AssistantsLookup.Properties.DataSource = GetAssistants()
            AssistantsLookup.Properties.EditValueType = LookUpEditValueType.ValueList
            AssistantsLookup.Properties.EnableEditValueCollectionEditing = DefaultBoolean.True
            AssistantsLookup.Properties.ValueMember = "ID"
            AssistantsLookup.Properties.DisplayMember = "FullName"
            AssistantsLookup.Properties.NullValuePrompt = "Add assistants..."
            AssistantsLookup.Properties.SearchMode = SearchMode.AutoSearch
        End Sub

        ' </AssistantsLookup>
        ' <gridControl1>
        Private Sub SetupAssistantsLookupForGridColumn()
            colAssistants.Caption = "Assistants"
            colAssistants.ColumnEdit = repositoryItemAssistantsLookUp
            colAssistants.FieldName = "AssistantIDs"
            '
            repositoryItemAssistantsLookUp.DataSource = GetAssistants()
            repositoryItemAssistantsLookUp.EditValueType = LookUpEditValueType.ValueList
            repositoryItemAssistantsLookUp.EnableEditValueCollectionEditing = DefaultBoolean.True
            repositoryItemAssistantsLookUp.ValueMember = "ID"
            repositoryItemAssistantsLookUp.DisplayMember = "FullName"
            repositoryItemAssistantsLookUp.SearchMode = SearchMode.AutoSearch
        End Sub

        ' </gridControl1>
        Protected Overrides Sub CalcContentCore()
            If tablePanel1 IsNot Nothing Then tablePanel1.Height = dataLayoutControl1.Root.MinSize.Height + dataLayoutControl1.Margin.Vertical
            CalcTablePanelBounds(tablePanel1)
        End Sub
    End Class
End Namespace

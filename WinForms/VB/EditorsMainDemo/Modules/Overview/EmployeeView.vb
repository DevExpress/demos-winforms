Namespace DevExpress.XtraEditors.Demos.Modules.Overview

    Public Partial Class EmployeeView
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            StatusImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeStatus)()
            Call EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, Nothing)
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(Nothing, gridControlTasks.RepositoryItems)
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeDepartment)()
            StateImageComboBoxEdit.Properties.Items.AddEnum(Of StateEnum)()
            bindingSource.Add(CreateDefaultEmployee())
        End Sub

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace

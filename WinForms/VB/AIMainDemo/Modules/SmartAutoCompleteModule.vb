Imports System
Imports DevExpress.AIIntegration.WinForms

Namespace DevExpress.AI.Demos

    Public Partial Class SmartAutoCompleteModule
        Inherits AITutorialControl

        Public Sub New()
            InitializeComponent()
            InitUserRoles()
            UpdatePaddings()
        End Sub

        Private Sub InitUserRoles()
            AddHandler comboBoxEditUserRole.SelectedIndexChanged, AddressOf ComboBoxEditUserRole_SelectedIndexChanged
            comboBoxEditUserRole.Properties.Items.AddRange(New UserRoleItem() {New UserRoleItem() With {.Name = "Technical support agent", .Description = "Technical support service agent responding to a customer's question"}, New UserRoleItem() With {.Name = "Sales manager", .Description = "Sales manager responding to a client's request for a product quote"}, New UserRoleItem() With {.Name = "Customer Success Manager", .Description = "Customer Success Manager onboarding a new client"}, New UserRoleItem() With {.Name = "Product Manager", .Description = "Product Manager announcing new feature updates to existing users"}, New UserRoleItem() With {.Name = "Marketing Specialist", .Description = "Marketing Specialist drafting a promotional email for a limited-time offer"}})
            comboBoxEditUserRole.SelectedIndex = 0
        End Sub

        Private Sub ComboBoxEditUserRole_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim role As UserRoleItem = TryCast(comboBoxEditUserRole.SelectedItem, UserRoleItem)
            Dim behavior = behaviorManager1.GetBehavior(Of SmartAutoCompleteBehavior)(memoEdit1)
            behavior.Properties.UserRole = role.Description
            labelControl1.Text = role.Description
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub
    End Class

    Public Class UserRoleItem

        Public Property Name As String

        Public Property Description As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace

Imports System.ComponentModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.WinExplorer

Namespace DevExpress.DevAV.Modules

    Public Partial Class CustomerView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedCustomerViewModel))
            InitializeComponent()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            ItemForHomeOffice.AppearanceItemCaption.ForeColor = DisabledTextColor
            ItemForHomeOffice.AppearanceItemCaption.Options.UseForeColor = True
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Public ReadOnly Property ViewModel As CustomerViewModel
            Get
                Return GetViewModel(Of CustomerViewModel)()
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property IsHorizontalLayout As Boolean
            Get
                Return winExplorerView.OptionsView.Style = WinExplorerViewStyle.Large
            End Get

            Set(ByVal value As Boolean)
                winExplorerView.OptionsView.Style = If(value, WinExplorerViewStyle.Large, WinExplorerViewStyle.Medium)
            End Set
        End Property

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateUI(ViewModel.Entity)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            If ViewModel IsNot Nothing Then UpdateUI(ViewModel.Entity)
        End Sub

        Private Sub UpdateUI(ByVal customer As Customer)
            If customer IsNot Nothing Then
                If Not Equals(bindingSource.DataSource, customer) Then
                    bindingSource.DataSource = customer
                Else
                    bindingSource.ResetBindings(False)
                End If

                gridControl.DataSource = customer.CustomerStores
            End If

            moduleLayout.Visible = customer IsNot Nothing
        End Sub
    End Class
End Namespace

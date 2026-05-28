Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ChartDemoModuleWithOptions
        Inherits ChartDemoModule

        Private optionsPanelStateField As NavigationPaneState

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property OptionsPanelState As NavigationPaneState
            Get
                Return optionsPanelStateField
            End Get

            Set(ByVal value As NavigationPaneState)
                optionsPanelStateField = value
                tabPaneOptions.State = optionsPanelStateField
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            tabPaneOptions.AllowCollapse = DefaultBoolean.True
            tabPaneOptions.State = optionsPanelStateField
            AddHandler tabPaneOptions.StateChanged, AddressOf tabPaneOptions_StateChanged
        End Sub

        Private Sub tabPaneOptions_StateChanged(ByVal sender As Object, ByVal e As StateChangedEventArgs)
            optionsPanelStateField = e.State
        End Sub
    End Class
End Namespace

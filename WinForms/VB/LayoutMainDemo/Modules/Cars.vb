Imports System
Imports System.Data

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class Cars
        Inherits BaseTutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            InitVehiclesData(vehiclesDataSet1)
            InitPanels()
            layoutControl1.SetDefaultLayout()
            AddHandler dataNavigator1.PositionChanged, AddressOf dataNavigator1_PositionChanged
            dataNavigator1_PositionChanged(Nothing, EventArgs.Empty)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "BaseControl"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"BaseControl"}
            End Get
        End Property

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutControl1.BeginUpdate()
            dateEdit1.Enabled = checkEdit1.Checked
            calcEdit1.Enabled = dateEdit1.Enabled
            layoutControl1.EndUpdate()
        End Sub

        Private Sub dataNavigator1_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            hyperLinkEdit1.EditValue = CType(CType(modelBindingSource.Current, DataRowView).Row, VehiclesDataSet.ModelRow).TrademarkRow.Site
        End Sub

        Protected Overrides ReadOnly Property FileMask As String
            Get
                Return "cars_"
            End Get
        End Property

        Public Overrides ReadOnly Property BaseLayout As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property
    End Class
End Namespace

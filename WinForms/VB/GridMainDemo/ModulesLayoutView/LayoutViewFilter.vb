Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports DevExpress.Utils.Filtering

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class LayoutViewFilter
        Inherits BaseLayoutModule

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            InitVehiclesData()
            SetToolTipController(Me, gridControl)
        End Sub

#Region "Demo Settings"
        Protected Overrides ReadOnly Property FluentScrollBars As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"LayoutViewFilter"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "FilteringUI"
            End Get
        End Property

#End Region  ' Demo Settings
        Private models As List(Of VehiclesData.Model)

        Private trademarks As List(Of VehiclesData.Trademark)

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            VehiclesData.InitXMLDataAndCreateEditors(dataFileName, gridControl, models, trademarks)
            ' Bind grid to data
            modelBindingSource.DataSource = models
            '<accordionControl>
            ' Bind the LayoutView.ActiveFilterCriteria to FilteringUIContext.FilterCriteria (two-way)
            filteringUIContext.SetFilterCriteriaBinding(layoutView)
            ' Retrieving the Filtering UI editors into the AccordionControl
            filteringUIContext.RetrieveFields()
            '</accordionControl>
            '<filterPanel>
            ' Bind the LayoutView.ActiveFilterCriteria to FilterPanelControl.FilterCriteria (two-way)
            filterPanel.SetFilterCriteriaBinding(layoutView)
            ' Setup initial filter
            layoutView.ActiveFilterString = "InRange([Price], 40000, 100000) And [Category] In (1,2)"
            '</filterPanel>
            accordionControl.ExpandAll()
        End Sub

#Region "Obtaining required additional data for Filtering UI editors"
        '<accordionControl>
        Private Sub filteringUIContext_QueryRangeData(ByVal sender As Object, ByVal e As QueryRangeDataEventArgs)
            If Equals(e.PropertyPath, "Price") Then
                e.Result.Minimum = models.Min(Function(m) m.Price)
                e.Result.Maximum = models.Max(Function(m) m.Price)
            End If
        End Sub

        Private Sub filteringUIContext_QueryLookupData(ByVal sender As Object, ByVal e As QueryLookupDataEventArgs)
            If Equals(e.PropertyPath, "Trademark") Then e.Result.DataSource = trademarks
        End Sub
    '</accordionControl>
#End Region
    End Class

#Region "Metadata For Filtering Model"
    '<accordionControl>
    Public Class FilteringModel

        Const Main As String = "Main Parameters"

        <Display(GroupName:=Main)>
        <FilterLookup(10, ValueMember:="ID", DisplayMember:="Name")>
        Public Property Trademark As Integer

        <Display(Name:="Model Available", GroupName:=Main)>
        <FilterBooleanChoice(False)>
        Public Property InStock As Boolean

        <Display(GroupName:=Main)>
        <FilterRange(0, 170000), DataType(DataType.Currency)>
        Public Property Price As Decimal

        <Display(GroupName:=Main)>
        <EnumDataType(GetType(VehiclesData.Category))>
        Public Property Category As Integer
    End Class
'</accordionControl>
#End Region
End Namespace

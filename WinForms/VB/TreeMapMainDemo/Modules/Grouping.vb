Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class Grouping
        Inherits TreeMapDemoModuleWithOptions

        Private ReadOnly Property DataAdapter As TreeMapFlatDataAdapter
            Get
                Return CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter)
            End Get
        End Property

        Private ReadOnly Property Colorizer As TreeMapPaletteColorizer
            Get
                Return CType(treeMapControl1.Colorizer, TreeMapPaletteColorizer)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return treeMapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            FillGroupByComboBox()
            DataAdapter.DataSource = CreateDataSet("Billionares.xml")
            Colorizer.Palette = Palette.Office2016Palette
            UpdateGrouping(True)
        End Sub

        Private Sub UpdateGrouping(ByVal enableGrouping As Boolean)
            DataAdapter.GroupDataMembers.Clear()
            If enableGrouping Then
                For Each definition As String In CType(groupByCBE.SelectedItem, GroupDefinitionInfo).Definitions
                    DataAdapter.GroupDataMembers.Add(definition.Replace(" ", ""))
                Next
            End If

            Colorizer.ColorizeGroups = enableGrouping
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim item As TreeMapItem = CType(e.SelectedObject, TreeMapItem)
            If Not item.IsGroup Then
                Dim superToolTip As SuperToolTip = New SuperToolTip()
                superToolTip.Items.Add(New ToolTipTitleItem() With {.Text = item.Label})
                superToolTip.Items.Add(New ToolTipSeparatorItem())
                Dim dataRowView As DataRowView = CType(item.Tag, DataRowView)
                superToolTip.Items.Add(New ToolTipItem() With {.Text = dataRowView("Residence").ToString() & ", " & dataRowView("NetWorth").ToString() & "B$"})
                e.SuperTip = superToolTip
            End If
        End Sub

        Private Sub FillGroupByComboBox()
            groupByCBE.Properties.Items.AddRange(GroupDefinitionInfo.GetDefinitions())
            groupByCBE.SelectedIndex = 0
        End Sub

        Private Sub groupByCBE_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGrouping(enableGroupingCE.Checked)
        End Sub

        Private Sub enableGroupingCE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim enableGrouping As Boolean = enableGroupingCE.Checked
            groupByLCI.Enabled = enableGrouping
            UpdateGrouping(enableGroupingCE.Checked)
        End Sub
    End Class

    Friend Class GroupDefinitionInfo

        Public Shared Function GetDefinitions() As GroupDefinitionInfo()
            Return New GroupDefinitionInfo(2) {New GroupDefinitionInfo(New String() {residenceGroupDefinition}), New GroupDefinitionInfo(New String() {ageGroupDefinition}), New GroupDefinitionInfo(New String() {residenceGroupDefinition, ageGroupDefinition})}
        End Function

        Const residenceGroupDefinition As String = "Residence", ageGroupDefinition As String = "Age Category"

        Private ReadOnly _definitions As String()

        Public ReadOnly Property Definitions As String()
            Get
                Return _definitions
            End Get
        End Property

        Private Sub New(ByVal definitions As String())
            _definitions = definitions
        End Sub

        Public Overrides Function ToString() As String
            Dim definitionsString As String = String.Empty
            For i As Integer = 0 To Definitions.Length - 1
                If Not String.IsNullOrEmpty(definitionsString) Then definitionsString += " And "
                definitionsString += Definitions(i)
            Next

            Return definitionsString
        End Function
    End Class
End Namespace

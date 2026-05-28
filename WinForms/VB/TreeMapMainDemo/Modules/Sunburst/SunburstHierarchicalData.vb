Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports DevExpress.TreeMap
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class SunburstHierarchicalData
        Inherits TreeMapDemoModuleWithOptions

        Private ReadOnly Property HierarchicalDataAdapter As SunburstHierarchicalDataAdapter
            Get
                Return CType(sunburstControl1.DataAdapter, SunburstHierarchicalDataAdapter)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return sunburstControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeControls(sunburstControl1, colorizerCBE, varyColorInGroupLCI, modeLCI)
            HierarchicalDataAdapter.DataSource = LoadDataFromXML()
            HierarchicalDataAdapter.Mappings(0).Type = GetType(TypeInfo)
        End Sub

        Private Sub ToolTipController_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim sunburstItem As ISunburstItem = CType(e.SelectedObject, ISunburstItem)
            Dim namespaceString As String = "DevExpress.XtraBars"
            For Each item As ISunburstItem In sunburstControl1.GetItemPath(sunburstItem)
                namespaceString += "." & item.Label.ToString()
            Next

            Dim superToolTip As SuperToolTip = New SuperToolTip() With {.MaxWidth = 400}
            superToolTip.Items.Add(New ToolTipTitleItem() With {.Text = namespaceString})
            superToolTip.Items.Add(New ToolTipSeparatorItem())
            superToolTip.Items.Add(New ToolTipItem() With {.Text = "Types Count: " & sunburstItem.Value})
            e.SuperTip = superToolTip
        End Sub

        Private Sub LoadData(ByVal element As XElement, ByVal datas As List(Of TypeInfo))
            Dim data As TypeInfo = New TypeInfo() With {.NamespaceString = element.Element("Namespace").Value, .TypesCount = Convert.ToDouble(element.Element("TypesCount").Value, CultureInfo.InvariantCulture)}
            datas.Add(data)
            For Each item As XElement In element.Element("NestedNamespaces").Elements()
                LoadData(item, data.NestedNamespaces)
            Next
        End Sub

        Private Function LoadDataFromXML() As List(Of TypeInfo)
            Dim document As XDocument = XDocument.Load(GetRelativePath("XtraBarsTypes.xml"))
            Dim datas As List(Of TypeInfo) = New List(Of TypeInfo)()
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("ArrayOfTypeInfo").Elements()
                    LoadData(element, datas)
                Next
            End If

            Return datas
        End Function
    End Class

    Public Class TypeInfo

        Private ReadOnly _nestedNamespaces As List(Of TypeInfo) = New List(Of TypeInfo)()

        Public Property NamespaceString As String

        Public Property TypesCount As Double

        Public ReadOnly Property NestedNamespaces As List(Of TypeInfo)
            Get
                Return _nestedNamespaces
            End Get
        End Property
    End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports DevExpress.Data
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class VirtualServerMode
        Inherits TutorialControl

        '<sbRefresh>
        Private Shared RowCount As Integer = 1000000

        Private Shared BatchCount As Integer = 250

        '</sbRefresh>
        Private Shared models As List(Of VehiclesData.Model) = Nothing

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            models = VehiclesData.InitOrdersVirtualData(dataFileName, gridControl1)
            VehiclesData.InitColumnViewEditors(bandedGridView1)
        End Sub

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
            seRowCount.Value = RowCount
            seBatchCount.Value = BatchCount
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"VirtualServerMode"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "VirtualServerMode"
            End Get
        End Property

        '<gridControl1>
        Private Shared Function GetItems(ByVal configuration As VirtualServerModeConfigurationInfo) As IEnumerable(Of VehiclesData.OrderItem)
            Dim allOrderItems = Enumerable.Range(0, RowCount).[Select](Function(i) New VehiclesData.OrderItem(RowCount, models, i + 1)).AsQueryable()
            Dim converter = New CriteriaToExpressionConverterForObjects()
            ' Applying Filter
            Dim items = allOrderItems.AppendWhere(converter, configuration.Filter)
            ' Applying Sorting
            If configuration.SortInfo IsNot Nothing AndAlso configuration.SortInfo.Length > 0 Then items = items.MakeOrderBy(converter, configuration.SortInfo)
            Return items.Cast(Of VehiclesData.OrderItem)()
        End Function

        Private Sub virtualServerModeSource1_ConfigurationChanged(ByVal sender As Object, ByVal e As VirtualServerModeRowsEventArgs)
            Dim enumerator = GetItems(e.ConfigurationInfo).GetEnumerator()
            e.UserData = enumerator
        End Sub

        Private Sub virtualServerModeSource1_MoreRows(ByVal sender As Object, ByVal e As VirtualServerModeRowsEventArgs)
            e.RowsTask = Threading.Tasks.Task.Factory.StartNew(Function()
                Dim enumerator = TryCast(e.UserData, IEnumerator(Of VehiclesData.OrderItem))
                Dim nextBatch = New List(Of VehiclesData.OrderItem)()
                Dim moreRows As Boolean = True
                While nextBatch.Count < BatchCount
                    If nextBatch.Count Mod 10 = 0 Then
                        Thread.Sleep(4)
                    'uncomment the following code to process cancellation requests
                    'e.CancellationToken.ThrowIfCancellationRequested();
                    End If

                    If enumerator.MoveNext() Then
                        nextBatch.Add(enumerator.Current)
                    Else
                        enumerator = Nothing
                        moreRows = False
                        Exit While
                    End If
                End While

                Return New VirtualServerModeRowsTaskResult(nextBatch, moreRows, enumerator)
            End Function, e.CancellationToken)
        End Sub

        Private Sub virtualServerModeSource1_GetUniqueValues(ByVal sender As Object, ByVal e As VirtualServerModeGetUniqueValuesEventArgs)
            e.UniqueValuesTask = New Threading.Tasks.Task(Of Object())(Function()
                Select Case e.ValuesPropertyName
                    Case "ModelPrice"
                        Return New Object() {15000D, 150000D}
                    Case "Discount"
                        Return New Object() {0.00, 0.05, 0.10, 0.15}
                    Case "SalesDate"
                        Dim today As Date = TutorialConstants.Today
                        Dim sevenYearsAgo As Date = New DateTime(today.Year - 7, 1, 1)
                        Dim totalDays As Integer = CInt(Math.Ceiling(today.Subtract(sevenYearsAgo).TotalDays))
                        Dim days As Object() = New Object(totalDays - 1) {}
                        For i As Integer = 0 To days.Length - 1
                            days(i) = sevenYearsAgo.AddDays(i)
                        Next

                        Return days
                    Case "Trademark"
                        Return models.[Select](Function(m) m.Trademark).Distinct().Cast(Of Object)().ToArray()
                    Case "Name"
                        Return models.[Select](Function(m) m.Name).Distinct().Cast(Of Object)().ToArray()
                    Case "Modification"
                        Return models.[Select](Function(m) m.Modification).Distinct().Cast(Of Object)().ToArray()
                    Case Else
                        Return Nothing
                End Select
            End Function, e.CancellationToken)
        End Sub

        '</gridControl1>
        '<sbRefresh>
        Private Sub sbRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
            RowCount = CInt(seRowCount.Value)
            BatchCount = CInt(seBatchCount.Value)
            gridControl1.RefreshDataSource()
        End Sub
    '</sbRefresh>
    End Class
End Namespace

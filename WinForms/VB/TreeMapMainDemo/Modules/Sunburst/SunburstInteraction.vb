Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class SunburstInteraction
        Inherits DevExpress.XtraTreeMap.Demos.TreeMapTutorialControl

        Private ReadOnly dataSource As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.SaleItem)

        Public Sub New()
            Me.InitializeComponent()
            Me.dataSource = DevExpress.XtraTreeMap.Demos.SaleItem.GetProductsByCompanies()
            CType(Me.sunburstControl1.DataAdapter, DevExpress.XtraTreeMap.SunburstFlatDataAdapter).DataSource = Me.dataSource
            Me.UpdateChartColorizer(Sub(ByVal i As Integer)
                Me.SeriesColorizer.Keys.Add(System.Linq.Enumerable.ElementAt(Of DevExpress.XtraTreeMap.GroupInfo)(Me.sunburstControl1.Groups, CInt((i))).GroupValue)
                Me.SeriesColorizer.Palette.Add(DevExpress.XtraTreeMap.Demos.PaletteHelper.InteractionDemoPalette(i))
            End Sub)
            Me.sunburstControl1.SelectedGroups.Add(DevExpress.XtraTreeMap.Demos.SaleItem.Companies(0))
            Me.sunburstControl1.SelectedGroups.Add(DevExpress.XtraTreeMap.Demos.SaleItem.Companies(1))
        End Sub

        Private ReadOnly Property SeriesColorizer As SeriesKeyColorColorizer
            Get
                Return CType(Me.chartControl1.SeriesTemplate.SeriesColorizer, DevExpress.XtraCharts.SeriesKeyColorColorizer)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return Me.sunburstControl1
            End Get
        End Property

        Private Sub SunburstControl1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeMap.SelectionChangedEventArgs)
            Me.chartControl1.DataSource = Nothing
            Dim selectedItems As System.Collections.IList = TryCast(e.SelectedItems, System.Collections.IList)
            If selectedItems IsNot Nothing Then Me.chartControl1.DataSource = If(selectedItems.Count > 0, selectedItems, Me.dataSource)
        End Sub

        Private Sub UpdateChartColorizer(ByVal updateColorizerAction As System.Action(Of Integer))
            Call DevExpress.XtraTreeMap.Demos.PaletteHelper.UpdateInteractionDemoPalette(Me.sunburstControl1.LookAndFeel)
            Me.SeriesColorizer.Palette = New DevExpress.XtraCharts.Palette("")
            For i As Integer = 0 To Me.sunburstControl1.Groups.Count() - 1
                updateColorizerAction(i)
            Next
        End Sub

        Private Sub SunburstInteraction_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.ClientSize.Width < Me.ClientSize.Height Then Return
            Me.chartControl1.Width = System.Math.Max(200, Me.ClientSize.Width - Me.ClientSize.Height)
            Me.sunburstControl1.Width = Me.ClientSize.Width - Me.chartControl1.Width
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            Me.UpdateChartColorizer(Sub(ByVal i As Integer) Me.SeriesColorizer.Palette.Add(DevExpress.XtraTreeMap.Demos.PaletteHelper.InteractionDemoPalette(i)))
        End Sub
    End Class

    Friend Class SaleItem

        Private Shared _categorizedProducts As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))

        Private Shared ReadOnly Property CategorizedProducts As Dictionary(Of String, System.Collections.Generic.List(Of String))
            Get
                If DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts Is Nothing Then
                    DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))()
                    DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts("Cameras") = New System.Collections.Generic.List(Of String)() From {"Camera", "Camcorder", "Binoculars", "Flash", "Tripod"}
                    DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts("Cell Phones") = New System.Collections.Generic.List(Of String)() From {"Smartphone", "Sim Card"}
                    DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts("Computers") = New System.Collections.Generic.List(Of String)() From {"Desktop", "Laptop", "Tablet", "Printer"}
                End If

                Return DevExpress.XtraTreeMap.Demos.SaleItem._categorizedProducts
            End Get
        End Property

        Public Shared ReadOnly Companies As String() = New String() {"North", "South", "West", "East"}

        Public Shared Function GetProductsByCompanies() As List(Of DevExpress.XtraTreeMap.Demos.SaleItem)
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = DevExpress.Data.Utils.NonCryptographicRandom.System
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.SaleItem)()
            For Each company As String In DevExpress.XtraTreeMap.Demos.SaleItem.Companies
                For Each category As String In DevExpress.XtraTreeMap.Demos.SaleItem.CategorizedProducts.Keys
                    For Each product As String In DevExpress.XtraTreeMap.Demos.SaleItem.CategorizedProducts(category)
                        Dim income As Integer = rnd.[Next](20, 100)
                        Dim revenue As Integer = income + rnd.[Next](20, 50)
                        items.Add(New DevExpress.XtraTreeMap.Demos.SaleItem() With {.Company = company, .Product = product, .Income = income, .Revenue = revenue, .Category = category})
                    Next
                Next
            Next

            Return items
        End Function

        Public Property Product As String

        Public Property Company As String

        Public Property OrderDate As DateTime

        Public Property Month As String

        Public Property Income As Double

        Public Property Revenue As Double

        Public Property Category As String
    End Class
End Namespace

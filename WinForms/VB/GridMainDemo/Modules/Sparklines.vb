Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.Sparkline
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class Sparklines
        Inherits TutorialControl

        Const januaryIndex As Integer = 3

        Const decemberIndex As Integer = 14

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridControl.MainView
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            cheHighlightMaxPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
            cheHighlightMinPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
            cheHighlightStartPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
            cheHighlightEndPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
            UpdateColors()
            UpdateMaxColorEnabled()
            UpdateMinColorEnabled()
            UpdateStartColorEnabled()
            UpdateEndColorEnabled()
            InitCustomersPaymentData(dsContacts1)
            InitializeViewCombobox()
            AddHandler repositoryItemSparklineEdit1.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Sparklines"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Sparklines"
            End Get
        End Property

        Private Sub InitializeViewCombobox()
            For Each view As SparklineViewType In [Enum].GetValues(GetType(SparklineViewType))
                cbeView.Properties.Items.Add(view)
            Next

            cbeView.SelectedItem = repositoryItemSparklineEdit1.View.Type
        End Sub

        Private Sub Sparklines_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl.ForceInitialize()
            gridView.ExpandAllGroups()
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub

        '<cbeView>
        Private Sub cbeView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If repositoryItemSparklineEdit1.View.Type <> CType(cbeView.SelectedItem, SparklineViewType) Then repositoryItemSparklineEdit1.View = SparklineViewBase.CreateView(CType(cbeView.SelectedItem, SparklineViewType))
            UpdateColors()
            repositoryItemSparklineEdit1.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked
            repositoryItemSparklineEdit1.View.HighlightMinPoint = cheHighlightMinPoint.Checked
            repositoryItemSparklineEdit1.View.HighlightStartPoint = cheHighlightStartPoint.Checked
            repositoryItemSparklineEdit1.View.HighlightEndPoint = cheHighlightEndPoint.Checked
        End Sub

        '</cbeView>
        '<cheHighlightMaxPoint>
        Private Sub cheHighlightMaxPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked
            UpdateMaxColorEnabled()
        End Sub

        '</cheHighlightMaxPoint>
        '<cheHighlightMinPoint>
        Private Sub cheHighlightMinPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.HighlightMinPoint = cheHighlightMinPoint.Checked
            UpdateMinColorEnabled()
        End Sub

        '</cheHighlightMinPoint>
        '<cheHighlightStartPoint>
        Private Sub cheHighlightStartPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.HighlightStartPoint = cheHighlightStartPoint.Checked
            UpdateStartColorEnabled()
        End Sub

        '</cheHighlightStartPoint>
        '<cheHighlightEndPoint>
        Private Sub cheHighlightEndPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.HighlightEndPoint = cheHighlightEndPoint.Checked
            UpdateEndColorEnabled()
        End Sub

        '</cheHighlightEndPoint>
        Private Sub UpdateMaxColorEnabled()
            ceMax.Enabled = cheHighlightMaxPoint.Checked
        End Sub

        Private Sub UpdateMinColorEnabled()
            ceMin.Enabled = cheHighlightMinPoint.Checked
        End Sub

        Private Sub UpdateStartColorEnabled()
            ceStart.Enabled = cheHighlightStartPoint.Checked
        End Sub

        Private Sub UpdateEndColorEnabled()
            ceEnd.Enabled = cheHighlightEndPoint.Checked
        End Sub

        '<ceStart>
        Private Sub ceStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.StartPointColor = CalculateColor(ceStart)
        End Sub

        '</ceStart>
        '<ceMin>
        Private Sub ceMin_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.MinPointColor = CalculateColor(ceMin)
        End Sub

        '</ceMin>
        '<ceEnd>
        Private Sub ceEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.EndPointColor = CalculateColor(ceEnd)
        End Sub

        '</ceEnd>
        '<ceMax>
        Private Sub ceMax_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.MaxPointColor = CalculateColor(ceMax)
        End Sub

        '</ceMax>
        '<ceColor>
        Private Sub ceColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemSparklineEdit1.View.Color = CalculateColor(ceColor)
        End Sub

        '</ceColor>
        Private Sub UpdateColors()
            Dim maxPointColor As Color = repositoryItemSparklineEdit1.View.MaxPointColor
            repositoryItemSparklineEdit1.View.MaxPointColor = Color.Empty
            ceMax.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualMaxPointColor
            repositoryItemSparklineEdit1.View.MaxPointColor = maxPointColor
            ceMax.Color = repositoryItemSparklineEdit1.View.ActualMaxPointColor
            Dim minPointColor As Color = repositoryItemSparklineEdit1.View.MinPointColor
            repositoryItemSparklineEdit1.View.MinPointColor = Color.Empty
            ceMin.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualMinPointColor
            repositoryItemSparklineEdit1.View.MinPointColor = minPointColor
            ceMin.Color = repositoryItemSparklineEdit1.View.ActualMinPointColor
            Dim startPointColor As Color = repositoryItemSparklineEdit1.View.StartPointColor
            repositoryItemSparklineEdit1.View.StartPointColor = Color.Empty
            ceStart.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualStartPointColor
            repositoryItemSparklineEdit1.View.StartPointColor = startPointColor
            ceStart.Color = repositoryItemSparklineEdit1.View.ActualStartPointColor
            Dim endPointColor As Color = repositoryItemSparklineEdit1.View.EndPointColor
            repositoryItemSparklineEdit1.View.EndPointColor = Color.Empty
            ceEnd.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualEndPointColor
            repositoryItemSparklineEdit1.View.EndPointColor = endPointColor
            ceEnd.Color = repositoryItemSparklineEdit1.View.ActualEndPointColor
            Dim _color As Color = repositoryItemSparklineEdit1.View.Color
            repositoryItemSparklineEdit1.View.Color = Color.Empty
            ceColor.Properties.AutomaticColor = repositoryItemSparklineEdit1.View.ActualColor
            repositoryItemSparklineEdit1.View.Color = _color
            ceColor.Color = repositoryItemSparklineEdit1.View.ActualColor
        End Sub

        Private Function CalculateColor(ByVal colorPick As ColorPickEdit) As Color
            Return If(colorPick.Color = colorPick.Properties.AutomaticColor, Color.Empty, colorPick.Color)
        End Function

        '<gridControl>
        Private Sub gridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.IsGetData Then
                Dim values As List(Of Double) = New List(Of Double)()
                Dim row As DataRowView = CType(e.Row, DataRowView)
                For i As Integer = januaryIndex To decemberIndex
                    values.Add(CDbl(row.Row.ItemArray(i)))
                Next

                e.Value = values
            End If
        End Sub

        '</gridControl>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace

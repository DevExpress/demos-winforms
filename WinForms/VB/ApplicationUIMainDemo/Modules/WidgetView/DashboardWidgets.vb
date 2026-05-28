Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DashboardWidgets
        Inherits TutorialControlBase

        Private WidgetColors As Color() = {Color.FromArgb(255, 173, 180), Color.FromArgb(255, 243, 182), Color.FromArgb(230, 189, 228), Color.FromArgb(255, 219, 189), Color.FromArgb(189, 230, 255), Color.FromArgb(204, 245, 194)}

        Public Sub New()
            InitializeComponent()
            widgetView1.AllowDocumentStateChangeAnimation = Utils.DefaultBoolean.True
            AutoMergeRibbon = True
            AddHandler widgetView1.QueryControl, AddressOf OnQueryControl
            SetWidgetsAppearances()
            For Each item As Document In widgetView1.Documents
                item.Width = CInt(Math.Round(item.Width * Skins.DpiProvider.Default.DpiScaleFactor))
                item.Height = CInt(Math.Round(item.Height * Skins.DpiProvider.Default.DpiScaleFactor))
            Next

            ApplyLayoutMode(widgetView1.LayoutMode)
        End Sub

        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim typeName As String = e.Document.ControlTypeName
            If Not String.IsNullOrEmpty(typeName) Then
                Dim controlType = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Program).Assembly, typeName)
                e.Control = TryCast(Activator.CreateInstance(controlType), Control)
            Else
                e.Control = New Control()
            End If
        End Sub

        Private Sub OnLayoutModeCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Dim layoutMode As LayoutMode = CType(e.Item.Tag, LayoutMode)
            ApplyLayoutMode(layoutMode)
        End Sub

        Private Sub ApplyLayoutMode(ByVal layoutMode As LayoutMode)
            widgetView1.BeginUpdateAnimation()
            widgetView1.LayoutMode = layoutMode
            Select Case layoutMode
                Case LayoutMode.FlowLayout
                    InitFlowLayout()
                Case LayoutMode.FreeLayout
                    InitFreeLayout()
                Case Else
                    pgMixAction.Visible = True
                    biItemMixer.Visibility = XtraBars.BarItemVisibility.Always
                    biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
                    pgFlowDirection.Visible = False
            End Select

            widgetView1.EndUpdateAnimation()
        End Sub

        Private Sub InitFlowLayout()
            pgMixAction.Visible = True
            biItemMixer.Visibility = XtraBars.BarItemVisibility.Always
            biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
            pgFlowDirection.Visible = True
        End Sub

        Private Sub InitFreeLayout()
            pgFlowDirection.Visible = False
            biItemMixer.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
            biDragMode.Visibility = XtraBars.BarItemVisibility.Always
        End Sub

        Private Sub OnFlowDirectionCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            widgetView1.BeginUpdateAnimation()
            Dim flowDirection As FlowDirection = CType(e.Item.Tag, FlowDirection)
            widgetView1.FlowLayoutProperties.FlowDirection = flowDirection
            widgetView1.EndUpdateAnimation()
        End Sub

        Private Sub OnMixButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Select Case widgetView1.LayoutMode
                Case LayoutMode.FlowLayout
                    FlowLayoutMix()
                Case LayoutMode.StackLayout
                    StackLayoutMix()
                Case LayoutMode.TableLayout
                    TableLayoutMix()
            End Select
        End Sub

        Private Sub StackLayoutMix()
            Dim randomIndex As Integer = 0
            Try
                widgetView1.BeginUpdateAnimation()
                For Each document As Document In widgetView1.Documents
                    Dim oldGroup As StackGroup = document.Parent
                    If oldGroup IsNot Nothing Then oldGroup.Items.Remove(document)
                    randomIndex = TutorialConstants.Random.Next(widgetView1.StackGroups.Count)
                    widgetView1.StackGroups(randomIndex).Items.Add(document)
                Next
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub

        Private Sub TableLayoutMix()
            Try
                widgetView1.BeginUpdateAnimation()
                Dim points As List(Of Point) = New List(Of Point)()
                For i As Integer = 0 To 3 - 1
                    For j As Integer = 0 To 3 - 1
                        points.Add(New Point(i, j))
                    Next
                Next

                For Each document As Document In widgetView1.Documents
                    Dim newLocation As Point = points(TutorialConstants.Random.Next(points.Count))
                    document.RowIndex = newLocation.Y
                    document.ColumnIndex = newLocation.X
                    points.Remove(newLocation)
                Next
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub

        Private Sub FlowLayoutMix()
            Dim index As Integer = 0
            Dim document As Document = New Document()
            Try
                widgetView1.BeginUpdateAnimation()
                For i As Integer = 0 To widgetView1.FlowLayoutProperties.FlowLayoutItems.Count - 1
                    index = TutorialConstants.Random.Next(widgetView1.Documents.Count)
                    If i = index Then Continue For
                    document = widgetView1.FlowLayoutProperties.FlowLayoutItems(i)
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Remove(document)
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Insert(index, document)
                Next
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If TryCast(e.Item, XtraBars.BarCheckItem).Checked Then
                SetWidgetsAppearances()
            Else
                ResetWidgetAppearances()
            End If
        End Sub

        Private Sub SetWidgetsAppearances()
            Dim documents As List(Of BaseDocument) = New List(Of BaseDocument)()
            documents.AddRange(widgetView1.Documents.ToArray())
            documents.AddRange(widgetView1.FloatDocuments.ToArray())
            For i As Integer = 0 To documents.Count - 1
                Dim document As Document = TryCast(documents(i), Document)
                document.AppearanceActiveCaption.BackColor = WidgetColors(i Mod WidgetColors.Length)
                document.AppearanceCaption.BackColor = WidgetColors(i Mod WidgetColors.Length)
            Next
        End Sub

        Private Sub ResetWidgetAppearances()
            Dim documents As List(Of BaseDocument) = New List(Of BaseDocument)()
            documents.AddRange(widgetView1.FloatDocuments.ToArray())
            documents.AddRange(widgetView1.Documents.ToArray())
            For Each document As Document In documents
                document.AppearanceActiveCaption.Reset()
                document.AppearanceCaption.Reset()
            Next
        End Sub

        Private Sub ToggleFreeLayoutDragMode(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If biDragMode.Down Then
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.DockingHints
            Else
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.Default
            End If
        End Sub
    End Class
End Namespace

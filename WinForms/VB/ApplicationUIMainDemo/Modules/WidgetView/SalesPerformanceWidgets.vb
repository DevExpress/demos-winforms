Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class SalesPerformanceWidgets
        Inherits WidgetViewTutorialControl

        Const STR_UcCardWidget As String = "DevExpress.ApplicationUI.Demos.ucCardWidget"

        '
        Private ReadOnly QueryControlDictionary As Dictionary(Of String, Control) = New Dictionary(Of String, Control)()

        Public Sub New()
            InitializeComponent()
            For Each item In widgetView1.Documents
                Dim typeName As String = item.ControlTypeName
                If Equals(typeName, STR_UcCardWidget) Then Continue For
                If Not String.IsNullOrEmpty(typeName) Then
                    Dim controlType = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Program).Assembly, typeName)
                    Dim control = TryCast(Activator.CreateInstance(controlType), Control)
                    QueryControlDictionary.Add(item.ControlTypeName, control)
                End If
            Next
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 2100
            End Get
        End Property

        Private Sub widgetView1_QueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            If Equals(e.Document.ControlTypeName, STR_UcCardWidget) Then
                Dim smallWidget = New ucCardWidget()
                Dim random = TutorialConstants.Random
                smallWidget.Price = random.Next(100, 1000)
                smallWidget.PPrice = random.NextDouble() - random.NextDouble()
                smallWidget.Delta = random.Next(-50, 100) + random.NextDouble()
                e.Control = smallWidget
                Return
            End If

            If Not String.IsNullOrEmpty(e.Document.ControlTypeName) Then
                e.Control = QueryControlDictionary(e.Document.ControlTypeName)
            End If
        End Sub
    End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.Extensions
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Behaviors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.AI.Demos

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Work with Extensions", "Extensions.cs")>
    Public Module Extensions

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim memoEdit As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit()
            memoEdit.Dock = System.Windows.Forms.DockStyle.Fill
            memoEdit.Parent = sampleHost
            memoEdit.Text = "DevExpress engineers feature-complete Presentation Controls, IDE Productivity Tools, Business Application Frameworks, and Reporting Systems for Visual Studio, Delphi, HTML5 or iOS & Android development. Whether using WPF, ASP.NET, WinForms, HTML5 or Windows 10, DevExpress tools help you build and deliver your best in the shortest time possible."
            Dim behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager = New DevExpress.Utils.Behaviors.BehaviorManager()
            Dim disposables As System.Collections.Generic.List(Of System.IDisposable) = New System.Collections.Generic.List(Of System.IDisposable)()
            disposables.Add(behaviorManager)
            sampleHost.Tag = disposables
            Return New Object() {memoEdit, behaviorManager, disposables}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim disposables = TryCast(sampleHost.Tag, System.Collections.Generic.List(Of System.IDisposable))
            If disposables IsNot Nothing Then
                For Each disposable In disposables
                    disposable.Dispose()
                Next
            End If

            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Modify default extension", New System.Type() {GetType(DevExpress.AI.Demos.Extensions.WilliamShakespeareStyleExtension)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ProofreadRequest", "ProofreadBehavior", "WilliamShakespeareStyleExtension")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Register")>
        Public Sub ModifyDefaultExtension(ByVal memoEdit As DevExpress.XtraEditors.MemoEdit, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager, ByVal disposables As System.Collections.Generic.List(Of System.IDisposable))
            Dim defaultContainer = DevExpress.AIIntegration.AIExtensionsContainerDesktop.[Default]
            Dim disposableToken = defaultContainer.Register(Of DevExpress.AIIntegration.Extensions.ProofreadRequest, DevExpress.AI.Demos.Extensions.WilliamShakespeareStyleExtension)()
            ' Here we store the token to dispose at later stage
            disposables.Add(disposableToken)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ProofreadBehavior)(memoEdit)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create custom extension", New System.Type() {GetType(DevExpress.AI.Demos.Extensions.AuthoredStyleExtension), GetType(DevExpress.AI.Demos.Extensions.AuthoredStyleRequest)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("AuthoredStyleRequest", "AuthoredStyleRequest", "AIOverlayForm")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Register", "GetExtension")>
        Public Sub CreateCustomExtension(ByVal memoEdit As DevExpress.XtraEditors.MemoEdit, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager, ByVal disposables As System.Collections.Generic.List(Of System.IDisposable))
            Dim defaultContainer = DevExpress.AIIntegration.AIExtensionsContainerDesktop.[Default]
            Dim disposableToken = defaultContainer.Register(Of DevExpress.AI.Demos.Extensions.AuthoredStyleRequest, DevExpress.AI.Demos.Extensions.AuthoredStyleExtension)()
            ' Here we store the token to dispose at later stage
            disposables.Add(disposableToken)
            Dim MenuCaption As String = "Authored Style"
            AddHandler memoEdit.Properties.BeforeShowMenu, Sub(s, e)
                Dim menuItem = TryCast(e.Menu.Items.FirstOrDefault(Function(x) Equals(x.Caption, MenuCaption)), DevExpress.Utils.Menu.DXSubMenuItem)
                If menuItem Is Nothing Then
                    menuItem = New DevExpress.Utils.Menu.DXSubMenuItem(MenuCaption)
                    Dim authors As String() = New String() {"Mark Twain", "Ernest Hemingway", "Maya Angelou"}
                    For Each author As String In authors
                        menuItem.Items.Add(New DevExpress.Utils.Menu.DXMenuItem(author, Async Sub(ss, ee)
                            Dim extension = CType(defaultContainer.GetExtension(GetType(DevExpress.AI.Demos.Extensions.AuthoredStyleRequest)), DevExpress.AI.Demos.Extensions.AuthoredStyleExtension)
                            Dim request = New DevExpress.AI.Demos.Extensions.AuthoredStyleRequest(author, memoEdit.SelectedText)
                            Dim result As String = Await DevExpress.AIIntegration.WinForms.AIOverlayFormHelper.Execute(memoEdit, extension, request)
                            memoEdit.SelectedText = result
                        End Sub))
                    Next

                    e.Menu.Items.Add(menuItem)
                End If
            End Sub
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class WilliamShakespeareStyleExtension
            Inherits DevExpress.AIIntegration.Extensions.ProofreadExtension

            Public Sub New(ByVal serviceProvider As System.IServiceProvider)
                MyBase.New(serviceProvider)
            End Sub

            Protected Overrides Function GetSystemPrompt(ByVal request As DevExpress.AIIntegration.Extensions.ProofreadRequest) As String
                Return "Rewrite this text in the William Shakespeare style."
            End Function
        End Class

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class AuthoredStyleExtension
            Inherits DevExpress.AIIntegration.Extensions.ChangeTextExtension(Of DevExpress.AI.Demos.Extensions.AuthoredStyleRequest)

            Public Sub New(ByVal serviceProvider As System.IServiceProvider)
                MyBase.New(serviceProvider)
            End Sub

            Protected Overrides Function GetSystemPrompt(ByVal request As DevExpress.AI.Demos.Extensions.AuthoredStyleRequest) As String
                Return System.[String].Format("Rewrite this text in the {0} style", request.Author)
            End Function
        End Class

        ' Custom text processing request
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class AuthoredStyleRequest
            Inherits DevExpress.AIIntegration.Extensions.TextRequest

            Public Sub New(ByVal Author As String, ByVal Text As String)
                MyBase.New(Text)
                Me.Author = Author
            End Sub

            Public Property Author As String
        End Class
    End Module
End Namespace

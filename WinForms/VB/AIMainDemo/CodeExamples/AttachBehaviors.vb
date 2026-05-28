Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.Extensions
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Behaviors
Imports DevExpress.XtraEditors

Namespace DevExpress.AI.Demos

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Attach Behavior", "AttachBehaviors.cs")>
    Public Module AttachBehaviors

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
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Attach simple behaviors in runtime")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Attach", "ExplainBehavior", "ShortenBehavior", "ExpandBehavior", "ChangeToneBehavior", "ProofreadBehavior", "ChangeStyleBehavior")>
        Public Sub AttachSimpleBehavior(ByVal memoEdit As DevExpress.XtraEditors.MemoEdit, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager, ByVal disposables As System.Collections.Generic.List(Of System.IDisposable))
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ExplainBehavior)(memoEdit)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ShortenBehavior)(memoEdit)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ExpandBehavior)(memoEdit)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ChangeToneBehavior)(memoEdit)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ProofreadBehavior)(memoEdit)
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ChangeStyleBehavior)(memoEdit)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Attach translation behavior in runtime")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Attach", "TranslateBehavior", "Languages", "LanguageInfo")>
        Public Sub AttachConfigurableBehavior(ByVal memoEdit As DevExpress.XtraEditors.MemoEdit, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager, ByVal disposables As System.Collections.Generic.List(Of System.IDisposable))
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.TranslateBehavior)(memoEdit, Sub(b) b.Properties.Languages = New DevExpress.AIIntegration.WinForms.LanguageInfo() {New DevExpress.AIIntegration.WinForms.LanguageInfo("en"), New DevExpress.AIIntegration.WinForms.LanguageInfo("es"), New DevExpress.AIIntegration.WinForms.LanguageInfo("fr")})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Configure AIExtensions composition", New System.Type() {GetType(DevExpress.AI.Demos.AttachBehaviors.ErnestHemingwayStyleExtension)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ProofreadRequest", "ProofreadBehavior", "ErnestHemingwayStyleExtension")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("QueryIAIExtensionsContainer", "Container")>
        Public Sub UsingCompositionRoot(ByVal memoEdit As DevExpress.XtraEditors.MemoEdit, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager, ByVal disposables As System.Collections.Generic.List(Of System.IDisposable))
            ' attach simple behaviors in runtime
            behaviorManager.Attach(Of DevExpress.AIIntegration.WinForms.ProofreadBehavior)(memoEdit)
            ' prepare a local AIExtensionsContainer with customized
            Dim localContainer = New DevExpress.AIIntegration.AIExtensionsContainerLocal(DevExpress.AIIntegration.AIExtensionsContainerDesktop.[Default])
            Dim disposable = localContainer.Register(Of DevExpress.AIIntegration.Extensions.ProofreadRequest, DevExpress.AI.Demos.AttachBehaviors.ErnestHemingwayStyleExtension)()
            disposables.Add(disposable)
            ' configure AIExtensionsContainer's composition for specific control
            AddHandler DevExpress.AIIntegration.AIExtensionsContainerDesktop.QueryIAIExtensionsContainer, Sub(s, e)
                If e.Source Is memoEdit Then e.Container = localContainer
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class ErnestHemingwayStyleExtension
            Inherits DevExpress.AIIntegration.Extensions.ProofreadExtension

            Public Sub New(ByVal serviceProvider As System.IServiceProvider)
                MyBase.New(serviceProvider)
            End Sub

            Protected Overrides Function GetSystemPrompt(ByVal request As DevExpress.AIIntegration.Extensions.ProofreadRequest) As String
                Return "Rewrite this text in the Ernest Hemingway style."
            End Function
        End Class
    End Module
End Namespace

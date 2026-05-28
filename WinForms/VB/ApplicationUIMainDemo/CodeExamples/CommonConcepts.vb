Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Common Concepts", "CommonConcepts.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("UserControl")>
    Public Module DocumentLayout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim documentManager As DevExpress.XtraBars.Docking2010.DocumentManager = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Dim documentManagerHost As DevExpress.XtraEditors.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = System.Windows.Forms.DockStyle.Fill
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = documentManagerHost
            Return New Object() {documentManager}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim documentManager = DevExpress.XtraBars.Docking2010.DocumentManager.FromControl(sampleHost)
            If documentManager IsNot Nothing Then documentManager.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add Document via new Control")>
        Public Sub AddDocumentViaControl(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager)
            Dim control = New System.Windows.Forms.UserControl()
            control.Text = "Document1"
            documentManager.View.AddDocument(control)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add Document via QueryControl event")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("QueryControl")>
        Public Sub AddDocumentViaQueryControl(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager)
            AddHandler documentManager.View.QueryControl, Sub(sender, e)
                If Equals(e.Document.ControlName, "UserControl1") Then e.Control = New System.Windows.Forms.UserControl()
            End Sub
            documentManager.View.AddDocument("Document1", "UserControl1")
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add Document via ControlName")>
        Public Sub AddDocumentViaControlName(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager)
            documentManager.View.AddDocument("Document1", "UserControl1")
            Dim control = New System.Windows.Forms.UserControl()
            control.Name = "UserControl1"
            documentManager.View.AddDocument(control)
        End Sub
    End Module
End Namespace

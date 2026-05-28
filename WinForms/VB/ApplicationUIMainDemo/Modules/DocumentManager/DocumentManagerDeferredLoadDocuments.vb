Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerDeferredLoadDocuments
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            AddHandler tabbedView.QueryControl, AddressOf tabbedView_QueryControl
        End Sub

        Private i As Integer = 0

        Private Sub tabbedView_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim child As Panel = New Panel()
            child.Padding = New Padding(16)
            Dim label As LabelControl = New LabelControl()
            label.Text = GetText(i)
            label.AutoSizeMode = LabelAutoSizeMode.Vertical
            child.Controls.Add(label)
            label.Dock = DockStyle.Fill
            e.Control = child
            i += 1
        End Sub

        Private Function GetText(ByVal i As Integer) As String
            System.Threading.Thread.Sleep(1000)
            Return String.Format("{0} {1}", texts(i Mod texts.Length), texts((i + 2) Mod texts.Length))
        End Function

        Private texts As String() = New String() {"Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.", "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."}
    End Class
End Namespace

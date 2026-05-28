Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace PhotoViewer

    Public Partial Class PhotoGroupCaptionControlBase
        Inherits UserControl

        Public Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
            InitializeComponent()
        End Sub

        Private mainFormField As MainForm

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property MainForm As MainForm
            Get
                Return mainFormField
            End Get

            Set(ByVal value As MainForm)
                mainFormField = value
            End Set
        End Property

        Protected Overridable Sub OnGroupIconClick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Overridable Sub OnEditButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Overridable Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Overridable Sub OnCollageButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Protected Overridable Sub OnSlideShowButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Protected Overridable Sub OnFilmButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class
End Namespace

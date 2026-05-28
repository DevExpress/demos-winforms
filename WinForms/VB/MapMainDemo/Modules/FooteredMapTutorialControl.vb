Imports System.Drawing
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraMap.Demos

    Public Partial Class FooteredMapTutorialControl
        Inherits MapTutorialControl

        Protected Overridable ReadOnly Property CopyrightImage As Image
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property CopyrightText As String
            Get
                Return String.Empty
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            UpdateCopyrights()
        End Sub

        Private Sub OnDispose()
            DisposeCopyrightImage()
        End Sub

        Private Sub DisposeCopyrightImage()
            If labelControl1.ImageOptions.Image IsNot Nothing Then
                labelControl1.ImageOptions.Image.Dispose()
                labelControl1.ImageOptions.Image = Nothing
            End If
        End Sub

        Protected Sub UpdateCopyrights()
            DisposeCopyrightImage()
            If CopyrightImage IsNot Nothing Then labelControl1.ImageOptions.Image = CType(CopyrightImage.Clone(), Image)
            labelControl2.Text = CopyrightText
            If UseEmptyRootPadding Then
                simpleSeparator1.Visibility = LayoutVisibility.Always
                layoutControlItem3.Padding = New Padding(layoutControlItem3.Padding.Left, layoutControlItem3.Padding.Top + 8, layoutControlItem3.Padding.Right, layoutControlItem3.Padding.Bottom)
            End If
        End Sub
    End Class
End Namespace

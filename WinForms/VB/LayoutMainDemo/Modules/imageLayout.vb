Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class ImageLayout
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            barcelonaPE.Properties.Caption.Text = "Barcelona" & Environment.NewLine & "L'Arc de Triomf"
            londonPE.Properties.Caption.Text = "London" & Environment.NewLine & "Tower Bridge"
            moscowPE.Properties.Caption.Text = "Moscow" & Environment.NewLine & "Bolshoi Theatre"
            parisPE.Properties.Caption.Text = "Paris" & Environment.NewLine & "Eiffel Tower"
            berlinPE.Properties.Caption.Text = "Berlin" & Environment.NewLine & "Red City Hall"
            newYorkPE.Properties.Caption.Text = "New York" & Environment.NewLine & "Empire State Building"
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ImageLayout"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ImageLayout"}
            End Get
        End Property

        Private Shared hoverPictureEdit As Object = New Object()

        Private Sub PictureEdit1_PaintEx(ByVal sender As Object, ByVal e As XtraGrid.PaintExEventArgs)
            Dim pictureEdit As PictureEdit = TryCast(sender, PictureEdit)
            If pictureEdit IsNot Nothing Then
                If Equals(pictureEdit.Tag, hoverPictureEdit) Then
                    Dim drawRectangle As Rectangle = New Rectangle(Point.Empty, pictureEdit.Size)
                    e.Cache.FillRectangle(Color.FromArgb(150, 0, 0, 0), drawRectangle)
                    drawRectangle.Inflate(ScaleHelper.ScaleHorizontal(-10), ScaleHelper.ScaleHorizontal(-10))
                    pictureEdit.Properties.Caption.Appearance.DrawString(e.Cache, pictureEdit.Properties.Caption.Text, drawRectangle)
                End If
            End If
        End Sub

        Private Sub pictureEdit1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            Dim pictureEdit As PictureEdit = TryCast(sender, PictureEdit)
            If pictureEdit IsNot Nothing Then pictureEdit.Tag = hoverPictureEdit
        End Sub

        Private Sub pictureEdit1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Dim pictureEdit As PictureEdit = TryCast(sender, PictureEdit)
            If pictureEdit IsNot Nothing Then pictureEdit.Tag = Nothing
        End Sub

        '<imagesLayoutControl>
        Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
            MyBase.OnParentChanged(e)
            Dim ownerForm As XtraForm = TryCast(FindForm(), XtraForm)
            If ownerForm IsNot Nothing Then
                ownerForm.ApplyAcrylicAccent(imagesLayoutControl)
                ownerForm.ApplyAcrylicAccent(mainLayoutControl)
            End If
        End Sub

        '</imagesLayoutControl>
        Private Sub dataLayoutControl2_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim min As Integer = Math.Min(lciImagesLayoutControl.Width, lciImagesLayoutControl.Height)
            min = Math.Min(ScaleHelper.ScaleHorizontal(800), min)
            imagesLayoutControl.MaximumSize = New Size(min, min)
        End Sub
    End Class
End Namespace

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.TileControlDemo.Properties

Namespace DevExpress.XtraBars.Demos.TileControlDemo

    Public Partial Class UserControl1
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            SetBackground()
            InitTileItems()
        End Sub

        Private Sub InitTileItems()
            itemCalendar.Elements(0).Text = Date.Now.Day.ToString()
            itemCalendar.Elements(1).Text = Date.Now.DayOfWeek.ToString()
            Dim deskThumbnail As Image = GetDesktopThumbnail()
            If deskThumbnail IsNot Nothing Then itemDesktop.Image = deskThumbnail
        End Sub

        Private ReadOnly Property UserProfileThemesPath As String
            Get
                Return Environment.GetEnvironmentVariable("USERPROFILE") & "\AppData\Roaming\Microsoft\Windows\Themes\"
            End Get
        End Property

        Private Function GetDesktopThumbnail() As Image
            Try
                Dim files As String() = Directory.GetFiles(UserProfileThemesPath, "TranscodedWallpaper*")
                If files.Length <> 0 Then Return Image.FromFile(files(0))
            Catch
                Return Nothing
            End Try

            Return Nothing
        End Function

        Private Sub SetBackground()
            tileControl1.BackgroundImage = TileControlBackgroundImage
        End Sub

        Private Sub OnTileControlKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = Keys.Escape Then Call Application.Exit()
        End Sub

        Private tileControlBackground As Image = Nothing

        Private ReadOnly Property TileControlBackgroundImage As Image
            Get
                If tileControlBackground Is Nothing Then tileControlBackground = CreateBackgroundImage()
                Return tileControlBackground
            End Get
        End Property

        Private Function CreateBackgroundImage() As Image
            Dim screenBounds As Rectangle = Screen.FromControl(Me).Bounds
            Dim bottomImg As Image = GetBottomImage()
            Dim img As Bitmap = New Bitmap(screenBounds.Width, screenBounds.Height)
            Using graphics As Graphics = Graphics.FromImage(img)
                Using br As SolidBrush = New SolidBrush(Color.FromArgb(36, 0, 64))
                    graphics.FillRectangle(br, New Rectangle(Point.Empty, img.Size))
                End Using

                graphics.DrawImage(bottomImg, 0, screenBounds.Bottom - bottomImg.Height)
            End Using

            Return img
        End Function

        Private Function GetBottomImage() As Image
            Return Resources.Background
        End Function

        Public Event OnDesktopClick As EventHandler

        Private Sub itemDesktop_ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            RaiseEvent OnDesktopClick(Me, New EventArgs())
        End Sub
    End Class
End Namespace

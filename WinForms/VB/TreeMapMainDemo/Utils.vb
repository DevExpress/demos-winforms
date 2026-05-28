Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraTreeMap.Native

Namespace DevExpress.XtraTreeMap.Demos

    Public Module Utils

        Public Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            For i As Integer = 0 To 10
                Dim filePath As String = Path.Combine(dir.FullName, name)
                If File.Exists(filePath) Then Return filePath
                dir = Directory.GetParent(dir.FullName)
            Next

            Return String.Empty
        End Function

        Public Function GetRelativeDirectoryPath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            While dir IsNot Nothing
                Dim directoryPath As String = Path.Combine(dir.FullName, name)
                If Directory.Exists(directoryPath) Then Return directoryPath
                dir = Directory.GetParent(dir.FullName)
            End While

            Return String.Empty
        End Function

        Public Function CreateDataSet(ByVal xmlFileName As String) As DataTable
            Dim filePath As String = GetRelativePath(xmlFileName)
            If Not String.IsNullOrWhiteSpace(filePath) Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(filePath)
                If dataSet.Tables.Count > 0 Then Return dataSet.Tables(0)
            End If

            Return Nothing
        End Function
    End Module

    Public Module PaletteHelper

        Private ReadOnly skinPalettes As Dictionary(Of String, Palette) = New Dictionary(Of String, Palette)()

        Private _interactionDemoPalette As Palette

        Public ReadOnly Property InteractionDemoPalette As Palette
            Get
                Return _interactionDemoPalette
            End Get
        End Property

        Public ReadOnly SelectionDemoPalette As Color() = {Color.FromArgb(170, 97, 150, 211), Color.FromArgb(170, 234, 127, 56), Color.FromArgb(170, 252, 195, 25), Color.FromArgb(170, 76, 107, 194), Color.FromArgb(170, 111, 174, 73), Color.FromArgb(170, 48, 91, 143), Color.FromArgb(170, 155, 76, 26), Color.FromArgb(170, 150, 117, 10), Color.FromArgb(170, 46, 66, 119), Color.FromArgb(170, 68, 105, 47), Color.FromArgb(170, 127, 171, 220), Color.FromArgb(170, 238, 153, 92), Color.FromArgb(170, 252, 208, 58), Color.FromArgb(170, 103, 129, 195)}

        Public Sub UpdateInteractionDemoPalette(ByVal skinProvider As ISkinProvider)
            If Not skinPalettes.TryGetValue(skinProvider.SkinName, _interactionDemoPalette) Then
                _interactionDemoPalette = Palette.CreatePalette(SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette01), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette02), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette03), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette04), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette05), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette06), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette07), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette08), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette09), SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette10))
                skinPalettes(skinProvider.SkinName) = _interactionDemoPalette
            End If
        End Sub
    End Module

    Public Module DemoHelpersContainer

        Private ReadOnly helpers As Dictionary(Of SunburstControl, ArrayList) = New Dictionary(Of SunburstControl, ArrayList)()

        Public Sub AddControl(ByVal sunburstControl As SunburstControl, ByVal colorizerComboBoxEdit As ComboBoxEdit, ByVal varyColorInGroupLCI As LayoutControlItem, ByVal modeLCI As LayoutControlItem)
            Call helpers.Add(sunburstControl, New ArrayList() From {New DemoColorizerOptionsHelper(sunburstControl, colorizerComboBoxEdit, varyColorInGroupLCI, modeLCI), New SunburstRotationHelper(sunburstControl)})
        End Sub

        Public Sub AddControl(ByVal sunburstControl As SunburstControl)
            Call helpers.Add(sunburstControl, New ArrayList() From {New SunburstRotationHelper(sunburstControl)})
        End Sub

        Private Class DemoColorizerOptionsHelper

            Private ReadOnly paletteColorizer As SunburstPaletteColorizer

            Private ReadOnly gradientColorizer As SunburstGradientColorizer

            Public Sub New(ByVal sunburst As SunburstControl, ByVal colorizerCBE As ComboBoxEdit, ByVal varyColorInGroupLCI As LayoutControlItem, ByVal modeLCI As LayoutControlItem)
                paletteColorizer = New SunburstPaletteColorizer()
                gradientColorizer = New SunburstGradientColorizer()
                InitailizeEditors(sunburst, colorizerCBE, varyColorInGroupLCI, modeLCI)
            End Sub

            Private Sub InitailizeEditors(ByVal sunburst As SunburstControl, ByVal colorizerCBE As ComboBoxEdit, ByVal varyColorInGroupLCI As LayoutControlItem, ByVal modeLCI As LayoutControlItem)
                AddHandler colorizerCBE.SelectedIndexChanged, Sub(s, e) UpdateColorizer(sunburst, colorizerCBE.SelectedIndex, varyColorInGroupLCI, modeLCI)
                Dim varyColorInGroupCE As CheckEdit = CType(varyColorInGroupLCI.Control, CheckEdit)
                AddHandler varyColorInGroupCE.CheckedChanged, Sub(s, e) paletteColorizer.VaryColorInGroup = varyColorInGroupCE.Checked
                Dim modeCBE As ComboBoxEdit = CType(modeLCI.Control, ComboBoxEdit)
                AddHandler modeCBE.SelectedIndexChanged, Sub(s, e) gradientColorizer.Mode = CType(modeCBE.SelectedIndex, GradientColorizerMode)
                colorizerCBE.SelectedIndex = 0
            End Sub

            Private Sub UpdateColorizer(ByVal sunburst As SunburstControl, ByVal colorizerIndex As Integer, ByVal varyColorInGroupLCI As LayoutControlItem, ByVal modeLCI As LayoutControlItem)
                If colorizerIndex = 0 Then
                    sunburst.Colorizer = paletteColorizer
                    varyColorInGroupLCI.Visibility = LayoutVisibility.Always
                    modeLCI.Visibility = LayoutVisibility.Never
                Else
                    sunburst.Colorizer = gradientColorizer
                    varyColorInGroupLCI.Visibility = LayoutVisibility.Never
                    modeLCI.Visibility = LayoutVisibility.Always
                End If
            End Sub
        End Class

        Private Class SunburstRotationHelper

            Private rotate As Boolean

            Private startPosition As Point

            Private ReadOnly sunburst As SunburstControl

            Public Sub New(ByVal sunburst As SunburstControl)
                Me.sunburst = sunburst
                AddHandler Me.sunburst.MouseDown, AddressOf Sunburst_MouseDown
                AddHandler Me.sunburst.MouseMove, AddressOf Sunburst_MouseMove
                AddHandler Me.sunburst.MouseUp, AddressOf Sunburst_MouseUp
            End Sub

            Private Sub Sunburst_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
                Dim position As Point = e.Location
                Dim hitInfo As SunburstHitInfo = sunburst.CalcHitInfo(position)
                If hitInfo IsNot Nothing AndAlso hitInfo.InSunburstItem Then
                    rotate = True
                    startPosition = position
                    sunburst.Cursor = DragCursors.HandDragCursor
                End If
            End Sub

            Private Sub Sunburst_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
                Dim position As Point = e.Location
                Dim hitInfo As SunburstHitInfo = sunburst.CalcHitInfo(position)
                If hitInfo IsNot Nothing Then
                    sunburst.Cursor = If(rotate, DragCursors.HandDragCursor, If(hitInfo.InSunburstItem, Cursors.Hand, Cursors.Default))
                    If rotate Then
                        Dim angleDelta As Double = CalcAngle(startPosition, position) * 180.0 / Math.PI
                        angleDelta *= If(sunburst.SweepDirection = SunburstSweepDirection.Clockwise, -1, 1)
                        Dim newAngle As Double = sunburst.StartAngle + angleDelta
                        If Math.Abs(newAngle) > 360 Then newAngle += -720 * Math.Sign(newAngle)
                        sunburst.StartAngle = newAngle
                        startPosition = position
                    End If
                End If
            End Sub

            Private Sub Sunburst_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
                rotate = False
            End Sub

            Private Function CalcAngle(ByVal p1 As Point, ByVal p2 As Point) As Double
                Dim center As Point = New Point(sunburst.Width \ 2, sunburst.Height \ 2)
                Return Math.Atan2(p1.Y - center.Y, p1.X - center.X) - Math.Atan2(p2.Y - center.Y, p2.X - center.X)
            End Function
        End Class
    End Module

    Public Class HeatmapDataSourceGenerator

        Const offset As Integer = 15

        Const speedRange As Integer = 7

        Const velocity As Integer = 10

        Public Const SizeX As Integer = 1000, SizeY As Integer = 1000

        Private ReadOnly random As Data.Utils.NonCryptographicRandom = New Data.Utils.NonCryptographicRandom(100)

        Private speed As Integer(,)

        Private values As Integer(,)

        Private min As Integer = 0

        Private delta As Integer = 0

        Private ReadOnly Property LengthX As Integer
            Get
                Return SizeX + offset
            End Get
        End Property

        Private ReadOnly Property LengthY As Integer
            Get
                Return SizeY + offset
            End Get
        End Property

        Public Sub New()
            InitializeMatrix()
        End Sub

        Private Sub InitializeMatrix()
            speed = New Integer(1014, 1014) {}
            values = New Integer(1014, 1014) {}
            values(0, 0) = 0
            speed(0, 0) = 0
            Dim minLength As Integer = Math.Min(LengthX, LengthY)
            For i As Integer = 1 To minLength - 1
                values(i, 0) = values(i - 1, 0) + speed(i - 1, 0)
                values(0, i) = values(0, i - 1) + speed(0, i - 1)
                speed(i, 0) = speed(i - 1, 0) + random.Next(0 - speedRange, 1 + speedRange)
                speed(0, i) = speed(0, i - 1) + random.Next(0 - speedRange, 1 + speedRange)
            Next

            For i As Integer = minLength To LengthX - 1
                values(i, 0) = values(i - 1, 0) + speed(i - 1, 0)
                speed(i, 0) = speed(i - 1, 0) + random.Next(0 - speedRange, 1 + speedRange)
            Next

            For i As Integer = minLength To LengthY - 1
                values(0, i) = values(0, i - 1) + speed(0, i - 1)
                speed(0, i) = speed(0, i - 1) + random.Next(0 - speedRange, 1 + speedRange)
            Next

            For i As Integer = 1 To LengthX - 1
                For j As Integer = 1 To LengthY - 1
                    values(i, j) =(values(i - 1, j - 1) + speed(i - 1, j - 1) + speed(i - 1, j) + speed(i, j - 1)) \ 2
                    speed(i, j) =(speed(i - 1, j) + speed(i, j - 1)) \ 2 + random.Next(0 - speedRange, 1 + speedRange)
                Next
            Next

            For i As Integer = 0 To LengthX - 1
                For j As Integer = 0 To LengthY - 1
                    If values(i, j) > delta Then delta = values(i, j)
                    If values(i, j) < min Then min = values(i, j)
                Next
            Next

            delta -= min
        End Sub

        Private Sub UpdateMatrix()
            For i As Integer = 0 To LengthX - 1
                For j As Integer = 0 To LengthY - velocity - 1
                    values(i, j) = values(i, j + velocity)
                    speed(i, j) = speed(i, j + velocity)
                Next
            Next

            For i As Integer = LengthY - velocity To LengthY - 1
                values(0, i) = values(0, i - 1) + speed(0, i - 1)
                speed(0, i) = speed(0, i - 1) + random.Next(0 - speedRange, 1 + speedRange)
                For j As Integer = 1 To LengthX - 1
                    values(j, i) =(values(j - 1, i - 1) + speed(j - 1, i - 1) + speed(j, i - 1) + speed(j - 1, i)) \ 2
                    speed(j, i) =(speed(j, i - 1) + speed(j - 1, i)) \ 2 + random.Next(0 - speedRange, 1 + speedRange)
                Next
            Next
        End Sub

        Public Shared Function GetArray(ByVal size As Integer) As Integer()
            Return New Integer(size - 1) {}.[Select](Function(v, i) i).ToArray()
        End Function

        Public Function GetMatrix() As Double(,)
            UpdateMatrix()
            Dim matrix As Double(,) = New Double(999, 999) {}
            For i As Integer = 0 To SizeX - 1
                For j As Integer = 0 To SizeY - 1
                    matrix(i, j) =(values(i + offset, j + offset) - min) * 16777216.0 / delta - 8388608
                Next
            Next

            Return matrix
        End Function
    End Class
End Namespace

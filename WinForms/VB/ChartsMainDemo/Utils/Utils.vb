Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Friend Module Utils

        Private Function GetNonAbstractSubclasses(ByVal baseType As Type) As IEnumerable(Of Type)
            Dim xtraChartsAssembly As Assembly = Assembly.GetAssembly(GetType(Legend))
            Return xtraChartsAssembly.GetTypes().Where(Function(type) Not type.IsAbstract AndAlso type.IsSubclassOf(baseType) AndAlso type.IsPublic)
        End Function

        Friend Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            For i As Integer = 0 To 10
                Dim filePath As String = Path.Combine(dir.FullName, name)
                If File.Exists(filePath) Then Return filePath
                dir = Directory.GetParent(dir.FullName)
            Next

            Return String.Empty
        End Function

        Friend Sub SetConnectionString(ByVal oleDbConnection As OleDb.OleDbConnection, ByVal path As String)
            oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
        End Sub

        Friend Function GetSeriesAnimationTypes(ByVal viewType As ViewType) As List(Of Type)
            Dim fakeSeries As Series = New Series("Fake Series", viewType)
            Dim seriesViewType As Type = fakeSeries.View.GetType()
            Dim seriesAnimationProperties As IEnumerable(Of PropertyInfo) = seriesViewType.GetProperties().Where(Function(propertyInfo) Equals(propertyInfo.Name, "SeriesAnimation") OrElse Equals(propertyInfo.Name, "MeanLineAnimation")) '"property" is a keyword in VB 
            If seriesAnimationProperties IsNot Nothing AndAlso seriesAnimationProperties.Count() = 1 Then
                Dim baseSeriesAnimationType As Type = Enumerable.First(seriesAnimationProperties).PropertyType
                Return New List(Of Type)(GetNonAbstractSubclasses(baseSeriesAnimationType))
            End If

            Return New List(Of Type)()
        End Function

        Friend Function GetPointAnimationTypes(ByVal viewType As ViewType) As List(Of Type)
            Dim fakeSeries As Series = New Series("Fake Series", viewType)
            Dim seriesViewType As Type = fakeSeries.View.GetType()
            Dim pointAnimationProperty As PropertyInfo = seriesViewType.GetProperty("SeriesPointAnimation")
            If pointAnimationProperty Is Nothing Then pointAnimationProperty = seriesViewType.GetProperty("Animation")
            If pointAnimationProperty IsNot Nothing AndAlso pointAnimationProperty.GetCustomAttribute(GetType(BrowsableAttribute)) Is Nothing Then
                Dim basePointAnimationType As Type = pointAnimationProperty.PropertyType
                Return New List(Of Type)(GetNonAbstractSubclasses(basePointAnimationType))
            End If

            Return New List(Of Type)()
        End Function

        Friend Function LoadDataTableFromXml(ByVal fileName As String, ByVal tableName As String) As DataTable
            Dim xmlStream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(Utils).Assembly, fileName, False)
            Dim xmlDataSet As DataSet = New DataSet()
            xmlDataSet.ReadXml(xmlStream)
            xmlStream.Close()
            Return xmlDataSet.Tables(tableName)
        End Function

        Friend Function SplitByWords(ByVal title As String) As String
            Dim regex As Regex = New Regex("(?<=\p{Lu})(?=\p{Lu}\P{Lu})|(?<=[\P{Lu}-[\s]])(?=\p{Lu})|(?<=[\w-[\d]])(?=[\W\d-[\s]])")
            Return regex.Replace(title, " ")
        End Function

        Friend Function CovertBoolToDefaultBoolean(ByVal value As Boolean) As DefaultBoolean
            Return If(value, DefaultBoolean.True, DefaultBoolean.False)
        End Function

        Friend Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Bitmap
            Dim destRect As Rectangle = New Rectangle(0, 0, width, height)
            Dim destImage As Bitmap = New Bitmap(width, height)
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution)
            Using g As Graphics = Graphics.FromImage(destImage)
                g.CompositingMode = CompositingMode.SourceCopy
                g.CompositingQuality = CompositingQuality.HighQuality
                g.InterpolationMode = InterpolationMode.HighQualityBicubic
                g.SmoothingMode = SmoothingMode.HighQuality
                g.PixelOffsetMode = PixelOffsetMode.HighQuality
                Using wrap As ImageAttributes = New ImageAttributes()
                    wrap.SetWrapMode(WrapMode.TileFlipXY)
                    g.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap)
                End Using
            End Using

            Return destImage
        End Function

        Friend Function ConvertCelsiusToFahrenheit(ByVal value As Double) As Double
            Return value * 1.8 + 32
        End Function
    End Module

    Friend Module PieExplodingHelper

        Private Function CreateFilter(ByVal mode As String) As SeriesPointFilter
            Return New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode)
        End Function

        Private Sub ApplyFilterMode(ByVal view As PieSeriesViewBase, ByVal mode As String)
            view.ExplodedPointsFilters.Clear()
            view.ExplodedPointsFilters.Add(CreateFilter(mode))
            view.ExplodeMode = PieExplodeMode.UseFilters
        End Sub

        Friend Const None As String = "None"

        Friend Const All As String = "All"

        Friend Const MinValue As String = "Min Value"

        Friend Const MaxValue As String = "Max Value"

        Friend Const Custom As String = "Custom"

        Friend Function CreateModeList(ByVal points As SeriesPointCollection, ByVal supportCustom As Boolean) As List(Of String)
            Dim list As List(Of String) = New List(Of String)()
            list.Add(None)
            list.Add(All)
            list.Add(MinValue)
            list.Add(MaxValue)
            For Each point As SeriesPoint In points
                list.Add(point.Argument)
            Next

            If supportCustom Then list.Add(Custom)
            Return list
        End Function

        Friend Sub ApplyMode(ByVal view As PieSeriesViewBase, ByVal mode As String)
            Select Case mode
                Case Custom
                Case None
                    view.ExplodeMode = PieExplodeMode.None
                Case All
                    view.ExplodeMode = PieExplodeMode.All
                Case MinValue
                    view.ExplodeMode = PieExplodeMode.MinValue
                Case MaxValue
                    view.ExplodeMode = PieExplodeMode.MaxValue
                Case Else
                    ApplyFilterMode(view, mode)
            End Select
        End Sub
    End Module

    Friend Module ColorUtils

#Region "class ColorHSL"
        Private Class ColorHSL

            Const minLuminanceField As Single = 0.0F

            Const maxLuminanceField As Single = 1.0F

            Private ReadOnly _hue As Single

            Private ReadOnly _saturation As Single

            Private _luminance As Single

            Public Property Luminance As Single
                Get
                    Return _luminance
                End Get

                Set(ByVal value As Single)
                    _luminance = value
                End Set
            End Property

            Public ReadOnly Property MinLuminance As Single
                Get
                    Return Math.Min(minLuminanceField, Luminance * 0.9F)
                End Get
            End Property

            Public ReadOnly Property MaxLuminance As Single
                Get
                    Return Math.Max(maxLuminanceField, Luminance + (1.0F - Luminance) * 0.15F)
                End Get
            End Property

            Public Sub New(ByVal hue As Single, ByVal saturation As Single, ByVal luminance As Single)
                _hue = hue
                _saturation = saturation
                _luminance = luminance
            End Sub

            Private Function GetComponent(ByVal q As Single, ByVal p As Single, ByVal t As Single) As Byte
                Const oneDivSix As Single = 1.0F / 6.0F
                Const twoDivThree As Single = 2.0F / 3.0F
                While t < 0.0F
                    t += 1.0F
                End While

                While t > 1.0F
                    t -= 1.0F
                End While

                Dim result As Single
                If t < oneDivSix Then
                    result = p + (q - p) * 6.0F * t
                ElseIf t < 0.5F Then
                    result = q
                ElseIf t < twoDivThree Then
                    result = p + (q - p) * (twoDivThree - t) * 6.0F
                Else
                    result = p
                End If

                Return CByte(Math.Round(result * 255.0F))
            End Function

            Friend Function ToColor() As Color
                Const oneDivThree As Single = 1.0F / 3.0F
                Dim q As Single = If(_luminance < 0.5F, Luminance * (1.0F + _saturation), _luminance + _saturation - _luminance * _saturation)
                Dim p As Single = 2.0F * Luminance - q
                Dim hueScaled As Single = _hue / 360.0F
                Return Color.FromArgb(255, GetComponent(q, p, hueScaled + oneDivThree), GetComponent(q, p, hueScaled), GetComponent(q, p, hueScaled - oneDivThree))
            End Function
        End Class

#End Region
        Private ReadOnly darSkinNames As String() = New String() {"DevExpress Dark Style", "Office 2016 Black", "Visual Studio 2013 Dark", "Darkroom"}

        Private Function ToColorHSL(ByVal color As Color) As ColorHSL
            Return New ColorHSL(color.GetHue(), color.GetSaturation(), color.GetBrightness())
        End Function

        Private Function MixChannel(ByVal fromValue As Byte, ByVal toValue As Byte, ByVal ratio As Double) As Byte
            Return CByte(fromValue * (1.0 - ratio) + toValue * ratio)
        End Function

        Private Function MakeColorDarker(ByVal color As Color, ByVal ratio As Single) As Color
            Dim colorHSL As ColorHSL = ToColorHSL(color)
            colorHSL.Luminance = Math.Min(0.95F, ratio)
            Return colorHSL.ToColor()
        End Function

        Friend Function ConvertColor(ByVal color As Color, ByVal cycleIndex As Integer, ByVal cycleCount As Integer) As Color
            Const minPercent As Single = 0.35F
            Const maxPercent As Single = 0.22F
            Dim colorHSL As ColorHSL = ToColorHSL(color)
            Dim diapason As Single = CSng(cycleCount - 1) / cycleCount
            Dim minLuminance As Single = colorHSL.Luminance - diapason * minPercent
            If minLuminance < colorHSL.MinLuminance Then minLuminance = colorHSL.MinLuminance
            Dim maxLuminance As Single = colorHSL.Luminance + diapason * maxPercent
            If maxLuminance > colorHSL.MaxLuminance Then maxLuminance = colorHSL.MaxLuminance
            Dim cycleMiddle As Single =(cycleCount - 1) / 2.0F
            Dim cycleDiff As Single = cycleIndex - cycleMiddle
            If cycleDiff < 0.0F Then
                colorHSL.Luminance = colorHSL.Luminance - (minLuminance - colorHSL.Luminance) * (cycleDiff / cycleMiddle)
            Else
                colorHSL.Luminance = colorHSL.Luminance + (maxLuminance - colorHSL.Luminance) * (cycleDiff / cycleMiddle)
            End If

            Return colorHSL.ToColor()
        End Function

        Friend Function MixColors(ByVal c1 As Color, ByVal c2 As Color) As Color
            Dim a As Double = c1.A / 255.0
            Dim r As Integer = CInt(a * c1.R + (1 - a) * c2.R)
            Dim g As Integer = CInt(a * c1.G + (1 - a) * c2.G)
            Dim b As Integer = CInt(a * c1.B + (1 - a) * c2.B)
            Return Color.FromArgb(r, g, b)
        End Function

        Friend Function InterpolateColors(ByVal fromUnit As Color, ByVal toUnit As Color, ByVal ratio As Double) As Color
            Return Color.FromArgb(MixChannel(fromUnit.A, toUnit.A, ratio), MixChannel(fromUnit.R, toUnit.R, ratio), MixChannel(fromUnit.G, toUnit.G, ratio), MixChannel(fromUnit.B, toUnit.B, ratio))
        End Function

        Friend Function ColorizerSeaIceSeries(ByVal color As Color, ByVal seriesIndex As Integer, ByVal skin As String) As Color
            Dim ratio As Single
            Dim hundredth As Integer = seriesIndex \ 100
            If Not darSkinNames.Contains(skin) Then
                ratio = If(seriesIndex <= 10, 0.2F + CSng(Math.Ceiling(seriesIndex / 2.0)) * 0.09F, 0.7F + hundredth)
            Else
                ratio = If(seriesIndex <= 10, 1.0F - CSng(Math.Ceiling(seriesIndex / 2.0)) * 0.09F, 0.5F - hundredth)
            End If

            Return MakeColorDarker(color, ratio)
        End Function

        Friend Function GetChartBackground(ByVal lf As UserLookAndFeel) As Color
            Return ChartSkins.GetSkin(lf)("Background").Color.GetBackColor()
        End Function
    End Module

    Friend Module FastFourierTransformation

        Public Sub Transform(ByVal real As Double(), ByVal imaginary As Double())
            Dim powerOf2Double As Double = Math.Log(real.Length, 2)
            Call Debug.Assert(powerOf2Double = Math.Floor(powerOf2Double))
            Dim powerOf2 As Integer = CInt(powerOf2Double)
            Dim frameLength As Integer = real.Length
            Dim j As Integer = 0
            For i As Integer = 0 To frameLength - 1 - 1
                If i < j Then
                    Dim tempReal As Double = real(i)
                    Dim tempImaginary As Double = imaginary(i)
                    real(i) = real(j)
                    imaginary(i) = imaginary(j)
                    real(j) = tempReal
                    imaginary(j) = tempImaginary
                End If

                Dim k As Integer = frameLength \ 2
                While k <= j
                    j -= k
                    k = k \ 2
                End While

                j += k
            Next

            Dim c1 As Double = -1R
            Dim c2 As Double = 0R
            Dim currentPowerOf2 As Integer = 1
            For l As Integer = 0 To powerOf2 - 1
                Dim previousPowerOf2 As Integer = currentPowerOf2
                currentPowerOf2 *= 2
                Dim u1 As Double = 1.0
                Dim u2 As Double = 0.0
                For j = 0 To previousPowerOf2 - 1
                    Dim i As Integer = j
                    While i < frameLength
                        Dim i1 As Integer = i + previousPowerOf2
                        Dim t1 As Double = u1 * real(i1) - u2 * imaginary(i1)
                        Dim t2 As Double = u1 * imaginary(i1) + u2 * real(i1)
                        real(i1) = real(i) - t1
                        imaginary(i1) = imaginary(i) - t2
                        real(i) += t1
                        imaginary(i) += t2
                        i += currentPowerOf2
                    End While

                    Dim z As Double = u1 * c1 - u2 * c2
                    u2 = u1 * c2 + u2 * c1
                    u1 = z
                Next

                c2 = -Math.Sqrt((1R - c1) / 2R)
                c1 = Math.Sqrt((1R + c1) / 2R)
            Next

            For i As Integer = 0 To frameLength - 1
                real(i) /= frameLength
                imaginary(i) /= frameLength
            Next
        End Sub
    End Module

    Public Module StackGroupHelper

        Public Sub ApplyStackedGroup(ByVal seriesCollection As SeriesCollection, ByVal labelVisibility As DefaultBoolean, ByVal groupSelectedIndex As Integer, ByVal isFullStackedView As Boolean)
            For Each series As SeriesBase In seriesCollection
                series.LabelsVisibility = labelVisibility
                Dim view As ISupportStackedGroup = TryCast(series.View, ISupportStackedGroup)
                If view IsNot Nothing Then
                    Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
                    view.StackedGroup = If(groupSelectedIndex = 0, genderAge.Gender, genderAge.Age)
                    If isFullStackedView AndAlso Equals((CStr(view.StackedGroup)), "65 years and older") Then view.StackedGroup = "65+ years"
                End If
            Next
        End Sub
    End Module
End Namespace

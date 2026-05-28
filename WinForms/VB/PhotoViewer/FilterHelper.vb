Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports DevExpress.Utils
Imports System.Reflection

Namespace PhotoViewer

    Public Module FilterHelper

        Public Delegate Function ApplyFilterDelegate(ByVal img As Image, <System.[ParamArray]> filterParams As Object()) As Image

        Private Function FilterImage(ByVal source As Image, ByVal filterMatrix As ColorMatrix) As Image
            If source Is Nothing Then Return Nothing
            Dim res As Image = New Bitmap(source.Width, source.Height)
            Using g As Graphics = Graphics.FromImage(res)
                Dim attrib As ImageAttributes = New ImageAttributes()
                attrib.SetColorMatrix(filterMatrix)
                g.Clear(Color.Transparent)
                g.DrawImage(source, New Rectangle(Point.Empty, res.Size), 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attrib)
            End Using

            Return res
        End Function

        Private Function GetRedChannelColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {1.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetGreenChannelColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 1.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetBlueChannelColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 1.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetRGB2BGRColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {0.0F, 0.0F, 1.0F, 0.0F, 0.0F}, New Single() {0.0F, 1.0F, 0.0F, 0.0F, 0.0F}, New Single() {1.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetInvertColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {-1.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, -1.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, -1.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {1.0F, 1.0F, 1.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetSepiaColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {0.393F, 0.349F, 0.272F, 0.0F, 0.0F}, New Single() {0.769F, 0.686F, 0.534F, 0.0F, 0.0F}, New Single() {0.189F, 0.168F, 0.131F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetBWColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {1.5F, 1.5F, 1.5F, 0.0F, 0.0F}, New Single() {1.5F, 1.5F, 1.5F, 0.0F, 0.0F}, New Single() {1.5F, 1.5F, 1.5F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {-1.0F, -1.0F, -1.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetWhite2AlphaColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {1.0F, 0.0F, 0.0F, -1.0F, 0.0F}, New Single() {0.0F, 1.0F, 0.0F, -1.0F, 0.0F}, New Single() {0.0F, 0.0F, 1.0F, -1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetPolaroidColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {1.438F, -0.062F, -0.062F, 0.0F, 0.0F}, New Single() {-0.122F, 1.378F, -0.122F, 0.0F, 0.0F}, New Single() {-0.016F, -0.016F, 1.483F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {-0.03F, 0.05F, -0.02F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetGrayscaleColorMatrix() As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {0.33F, 0.33F, 0.33F, 0.0F, 0.0F}, New Single() {0.59F, 0.59F, 0.59F, 0.0F, 0.0F}, New Single() {0.11F, 0.11F, 0.11F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetContrastColorMatrix(ByVal c As Single) As ColorMatrix
            Dim t As Single =(1.0F - c) / 2.0F
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {c, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, c, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, c, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {t, t, t, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetBrightnessColorMatrix(ByVal b As Single) As ColorMatrix
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {1.0F, 0.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 1.0F, 0.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 1.0F, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {b, b, b, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function GetSaturationColorMatrix(ByVal s As Single) As ColorMatrix
            Dim lumR As Single = 0.3086F
            Dim lumG As Single = 0.6094F
            Dim lumB As Single = 0.0820F
            Dim sr As Single =(1 - s) * lumR
            Dim sg As Single =(1 - s) * lumG
            Dim sb As Single =(1 - s) * lumB
            Dim m As ColorMatrix = New ColorMatrix(New Single()() {New Single() {s + sr, sr, sr, 0.0F, 0.0F}, New Single() {sg, s + sg, sg, 0.0F, 0.0F}, New Single() {sb, sb, s + sb, 0.0F, 0.0F}, New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F}, New Single() {0.0F, 0, 0F, 0.0F, 0.0F, 1.0F}})
            Return m
        End Function

        Private Function ApplyRedChannelFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetRedChannelColorMatrix())
        End Function

        Private Function ApplyGreenChannelFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetGreenChannelColorMatrix())
        End Function

        Private Function ApplyBlueChannelFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetBlueChannelColorMatrix())
        End Function

        Private Function ApplyInvertFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetInvertColorMatrix())
        End Function

        Private Function ApplyRGB2BGRFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetRGB2BGRColorMatrix())
        End Function

        Private Function ApplySepiaFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetSepiaColorMatrix())
        End Function

        Private Function ApplyBWFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetBWColorMatrix())
        End Function

        Private Function ApplyPolaroidFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetPolaroidColorMatrix())
        End Function

        Private Function ApplyGrayscaleFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetGrayscaleColorMatrix())
        End Function

        Private Function ApplyWhite2AlphaFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Return FilterImage(img, GetWhite2AlphaColorMatrix())
        End Function

        Private Function ApplyContrastFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Dim param As Single = If(filterParams Is Nothing OrElse filterParams.Length = 0, 2.0F, CSng(filterParams(0)))
            Return FilterImage(img, GetContrastColorMatrix(param))
        End Function

        Private Function ApplyBrightnessFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Dim param As Single = If(filterParams Is Nothing OrElse filterParams.Length = 0, 0.3F, CSng(filterParams(0)))
            Return FilterImage(img, GetBrightnessColorMatrix(param))
        End Function

        Private Function ApplySaturationFilter(ByVal img As Image, ParamArray filterParams As Object()) As Image
            Dim param As Single = If(filterParams Is Nothing OrElse filterParams.Length = 0, 0.3F, CSng(filterParams(0)))
            Return FilterImage(img, GetSaturationColorMatrix(param))
        End Function

        Private Function GetFilterByName(ByVal name As String) As FilterInfo
            For Each info As FilterInfo In Filters
                If Equals(info.Name, name) Then Return info
            Next

            Return Nothing
        End Function

        Public Function ApplyFilter(ByVal name As String, ByVal img As Image, ParamArray filterParams As Object()) As Image
            Dim info As FilterInfo = GetFilterByName(name)
            If info IsNot Nothing AndAlso img IsNot Nothing Then Return CType(info.FilterMethod.DynamicInvoke(img, filterParams), Image)
            Return img
        End Function

        Private filtersCore As List(Of FilterInfo)

        Public ReadOnly Property Filters As List(Of FilterInfo)
            Get
                If filtersCore Is Nothing Then
                    filtersCore = New List(Of FilterInfo)()
                    InitializeFilters(filtersCore)
                End If

                Return filtersCore
            End Get
        End Property

        Private Sub InitializeFilters(ByVal filters As List(Of FilterInfo))
            filters.Add(New FilterInfo("Invert", New ApplyFilterDelegate(AddressOf ApplyInvertFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("RGB->BGR", New ApplyFilterDelegate(AddressOf ApplyRGB2BGRFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Sepia", New ApplyFilterDelegate(AddressOf ApplySepiaFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Contrast", New ApplyFilterDelegate(AddressOf ApplyContrastFilter), GetType(ContrastFilterParams)))
            filters.Add(New FilterInfo("Brightness", New ApplyFilterDelegate(AddressOf ApplyBrightnessFilter), GetType(BrightnessFilterParams)))
            filters.Add(New FilterInfo("Saturation", New ApplyFilterDelegate(AddressOf ApplySaturationFilter), GetType(SaturationFilterParams)))
            filters.Add(New FilterInfo("Black & White", New ApplyFilterDelegate(AddressOf ApplyBWFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Polaroid", New ApplyFilterDelegate(AddressOf ApplyPolaroidFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("White -> Alpha", New ApplyFilterDelegate(AddressOf ApplyWhite2AlphaFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Grayscale", New ApplyFilterDelegate(AddressOf ApplyGrayscaleFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Red Channel", New ApplyFilterDelegate(AddressOf ApplyRedChannelFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Green Channel", New ApplyFilterDelegate(AddressOf ApplyGreenChannelFilter), GetType(SimpleFilterParams)))
            filters.Add(New FilterInfo("Blue Channel", New ApplyFilterDelegate(AddressOf ApplyBlueChannelFilter), GetType(SimpleFilterParams)))
        End Sub

        Public Function GetFiltersName() As String()
            Dim fname As String() = New String(Filters.Count - 1) {}
            Dim nameIndex As Integer = 0
            For Each info As FilterInfo In Filters
                fname(nameIndex) = info.Name
                nameIndex += 1
            Next

            Return fname
        End Function

        Public Function GetFiltersSamples(ByVal sampleImage As Image) As ImageCollection
            Dim coll As ImageCollection = New ImageCollection()
            coll.ImageSize = sampleImage.Size
            For Each info As FilterInfo In Filters
                coll.Images.Add(CType(info.FilterMethod.DynamicInvoke(sampleImage, Nothing), Image))
            Next

            Return coll
        End Function
    End Module

    Public Class FilterInfo

        Private nameCore As String

        Private filterMethodCore As [Delegate]

        Private paramsControlType As Type

        Public Sub New(ByVal name As String, ByVal filterMethod As [Delegate], ByVal paramsControlType As Type)
            nameCore = name
            filterMethodCore = filterMethod
            Me.paramsControlType = paramsControlType
        End Sub

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Public ReadOnly Property FilterMethod As [Delegate]
            Get
                Return filterMethodCore
            End Get
        End Property

        Public Function CreateParamsControl() As SimpleFilterParams
            Dim ci As ConstructorInfo = paramsControlType.GetConstructor(New Type() {})
            Dim pc As SimpleFilterParams = CType(ci.Invoke(New Object() {}), SimpleFilterParams)
            pc.Filter = Me
            Return pc
        End Function
    End Class
End Namespace

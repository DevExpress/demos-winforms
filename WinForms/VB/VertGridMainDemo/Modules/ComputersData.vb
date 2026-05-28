Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class ComputersData

        Public Shared Function InitOrdersData(ByVal fileName As String, ByVal vGridControl As VGridControl, ByVal count As Integer) As List(Of PCConfiguration)
            Dim computers = InitXMLDataCore(fileName, count)
            Dim configurations = CreatePCConfigurations(computers, computers.Count)
            vGridControl.DataSource = configurations
            Return configurations
        End Function

        Private Shared Function InitXMLDataCore(ByVal fileName As String, ByVal count As Integer) As List(Of Computer)
            Dim ds As DataSet = New DataSet()
            'var computersTable = "Computers";
            Dim gamingChassisTable = "GamingChassis"
            Dim memorySizesTable = "MemorySizes"
            Dim memoryTypesTable = "MemoryTypes"
            Dim motherboardsTable = "Motherboards"
            Dim powerSuppliesTable = "PowerSupplies"
            Dim processorsTable = "Processors"
            Dim ramsTable = "RAMs"
            Dim trademarksTable = "Trademarks"
            Dim videoCardsTable = "VideoCards"
            ds.ReadXml(fileName)
            Dim trademarks = New List(Of Trademark)()
            Dim memoryTypes = New List(Of MemoryType)()
            Dim memorySizes = New List(Of MemorySize)()
            Dim computers = New List(Of Computer)()
            Dim processors = New List(Of Processor)()
            Dim motherboards = New List(Of Motherboard)()
            Dim videoCards = New List(Of VideoCard)()
            Dim gamingChassis = New List(Of GamingChassis)()
            Dim rams = New List(Of RAM)()
            Dim powerSupplies = New List(Of PowerSupply)()
            For Each row As DataRow In ds.Tables(trademarksTable).Rows
                trademarks.Add(New Trademark() With {.Id = CInt(row("Id")), .Name = CStr(row("Name"))})
            Next

            For Each row As DataRow In ds.Tables(memorySizesTable).Rows
                memorySizes.Add(New MemorySize() With {.Id = CInt(row("Id")), .Name = CStr(row("Name"))})
            Next

            For Each row As DataRow In ds.Tables(memoryTypesTable).Rows
                memoryTypes.Add(New MemoryType() With {.Id = CInt(row("Id")), .Name = CStr(row("Name"))})
            Next

            For Each row As DataRow In ds.Tables(processorsTable).Rows
                processors.Add(New Processor() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .Socket = CStr(row("Socket")), .BaseFrequency = CStr(row("BaseFrequency")), .MaxFrequency = CStr(row("MaxFrequency")), .NumberCores = CInt(row("NumberCores")), .TDP = CStr(row("TDP")), .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            For Each row As DataRow In ds.Tables(motherboardsTable).Rows
                motherboards.Add(New Motherboard() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .Socket = CStr(row("Socket")), .Chipset = CStr(row("Chipset")), .FormFactor = CStr(row("FormFactor")), .MinMemoryFrequency = CStr(row("MinMemoryFrequency")), .MaxMemoryFrequency = CStr(row("MaxMemoryFrequency")), .NetworkAdapterChipset = CStr(row("NetworkAdapterChipset")), .AmountMemorySlots = CInt(row("AmountMemorySlots")), .SoundAdapterChipset = CStr(row("SoundAdapterChipset")), .SoundScheme = CStr(row("SoundScheme")), .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            For Each row As DataRow In ds.Tables(videoCardsTable).Rows
                videoCards.Add(New VideoCard() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .GraphicsProcessor = CStr(row("GraphicsProcessor")), .MaximumResolution = CStr(row("MaximumResolution")), .MemorySize = Enumerable.First(memorySizes, Function(x) x.Id = CInt(row("MemorySizeId"))).Name, .MemoryType = Enumerable.First(memoryTypes, Function(x) x.Id = CInt(row("MemoryTypeId"))).Name, .ConnectionInterface = CStr(row("ConnectionInterface")), .NominalFrequencyVideoChip = CStr(row("NominalFrequencyVideoChip")), .TurboFrequency = CStr(row("TurboFrequency")), .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            For Each row As DataRow In ds.Tables(gamingChassisTable).Rows
                gamingChassis.Add(New GamingChassis() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .Backlight = CStr(row("Backlight")), .Type = CStr(row("Type")), .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            For Each row As DataRow In ds.Tables(ramsTable).Rows
                rams.Add(New RAM() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .MemorySize = Enumerable.First(memorySizes, Function(x) x.Id = CInt(row("MemorySizeId"))).Name, .MemoryType = Enumerable.First(memoryTypes, Function(x) x.Id = CInt(row("MemoryTypeId"))).Name, .ClockFrequency = CStr(row("ClockFrequency")), .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            For Each row As DataRow In ds.Tables(powerSuppliesTable).Rows
                powerSupplies.Add(New PowerSupply() With {.Id = CInt(row("Id")), .Name = CStr(row("Name")), .Price = CDec(row("Price")), .Power = CStr(row("Power")), .CPUPowerConnectors = CStr(row("CPUPowerConnectors")), .VideoCardPowerConnectors = CStr(row("VideoCardPowerConnectors")), .Trademark = Enumerable.First(trademarks, Function(x) x.Id = CInt(row("TrademarkId"))).Name, .ReleaseYear = CInt(row("ReleaseYear")), .AverageRating = CSng(row("AverageRating"))})
            Next

            Dim _processorId, _motherboardId, _gamingChassisId, _videoCardId, _RAMId, _powerSupplyId As Integer
            For i As Integer = 1 To count - 1
                _processorId = TutorialConstants.Random.Next(1, 7)
                _motherboardId = TutorialConstants.Random.Next(1, 5)
                _gamingChassisId = TutorialConstants.Random.Next(1, 20)
                _videoCardId = TutorialConstants.Random.Next(1, 6)
                _RAMId = TutorialConstants.Random.Next(1, 7)
                _powerSupplyId = TutorialConstants.Random.Next(1, 5)
                Dim temp As Computer = New Computer() With {.Id = i, .ProcessorId = _processorId, .MotherboardId = _motherboardId, .GamingChassisId = _gamingChassisId, .VideoCardId = _videoCardId, .RAMId = _RAMId, .PowerSupplyId = _powerSupplyId, .Processor = processors.First(Function(x) x.Id = _processorId), .Motherboard = motherboards.First(Function(x) x.Id = _motherboardId), .VideoCard = videoCards.First(Function(x) x.Id = _videoCardId), .GamingChassis = gamingChassis.First(Function(x) x.Id = _gamingChassisId), .RAM = rams.First(Function(x) x.Id = _RAMId), .PowerSupply = powerSupplies.First(Function(x) x.Id = _powerSupplyId), .Price = 0, .AverageRating = 1}
                temp.Price = GetMinPrice(temp)
                temp.AverageRating = GetAvgRating(temp)
                computers.Add(temp)
            Next

            Return computers
        End Function

        Private Shared Function GetMinPrice(ByVal comp As Computer) As Decimal
            Return comp.Processor.Price + comp.Motherboard.Price + comp.VideoCard.Price + comp.GamingChassis.Price + comp.RAM.Price + comp.PowerSupply.Price
        End Function

        Private Shared Function GetAvgRating(ByVal comp As Computer) As Single
            Return(comp.Processor.AverageRating + comp.Motherboard.AverageRating + comp.VideoCard.AverageRating + comp.GamingChassis.AverageRating + comp.RAM.AverageRating + comp.PowerSupply.AverageRating) / 6
        End Function

        Private Shared Function CreatePCConfigurations(ByVal computers As List(Of Computer), ByVal itemCount As Integer) As List(Of PCConfiguration)
            Dim data = New List(Of PCConfiguration)(itemCount)
            For i As Integer = 0 To itemCount - 1
                data.Add(New PCConfiguration(computers(TutorialConstants.Random.Next(0, computers.Count - 1)), i + 1, TutorialConstants.Random))
            Next

            Return data
        End Function

        Public Shared Sub InitEditors(ByVal vGridControl As VGridControl)
            If vGridControl.Rows.Count = 0 Then Return
            For Each row In vGridControl.Rows
                SetRowEditorProperties(row, vGridControl)
            Next
        End Sub

        Private Shared Sub SetRowEditorProperties(ByVal row As BaseRow, ByVal vGridControl As VGridControl)
            If TypeOf row Is EditorRow Then SetEditorProperties(row.Properties, vGridControl)
            If TypeOf row Is CategoryRow Then
                Dim category = TryCast(row, CategoryRow)
                If category.HasChildren Then SetChildRowsEditorProperties(category.ChildRows, vGridControl)
            End If

            If TypeOf row Is MultiEditorRow Then
                Dim multiEditorRow = TryCast(row, MultiEditorRow)
                If multiEditorRow.HasChildren Then SetChildRowsEditorProperties(multiEditorRow.ChildRows, vGridControl)
                If multiEditorRow.PropertiesCollection.Count > 0 Then SetEditorPropertiesCollection(multiEditorRow.PropertiesCollection, vGridControl)
            End If
        End Sub

        Private Shared Sub SetEditorProperties(ByVal rowProperties As RowProperties, ByVal vGridControl As VGridControl)
            Dim item As RepositoryItem = GetEditByFielsName(rowProperties.FieldName, vGridControl.RepositoryItems)
            If item IsNot Nothing AndAlso rowProperties.RowEdit Is Nothing Then rowProperties.RowEdit = item
        End Sub

        Private Shared Sub SetChildRowsEditorProperties(ByVal childRows As VGridRows, ByVal vGridControl As VGridControl)
            For Each row In childRows
                SetRowEditorProperties(row, vGridControl)
            Next
        End Sub

        Private Shared Sub SetEditorPropertiesCollection(ByVal propertiesCollection As MultiEditorRowPropertiesCollection, ByVal vGridControl As VGridControl)
            For Each rowProperties As RowProperties In propertiesCollection
                SetEditorProperties(rowProperties, vGridControl)
            Next
        End Sub

        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each item As RepositoryItem In repositoryItemCollection
                If item.Name.IndexOf("/" & fieldName) >= 0 Then Return item
            Next

            Return Nothing
        End Function

#Region "Data"
        Public Class Computer

            Public Property Id As Integer

            Public Property ProcessorId As Integer

            Public Property MotherboardId As Integer

            Public Property GamingChassisId As Integer

            Public Property VideoCardId As Integer

            Public Property RAMId As Integer

            Public Property PowerSupplyId As Integer

            Public Property Price As Decimal

            Public Property AverageRating As Single

            Public Property Processor As Processor

            Public Property Motherboard As Motherboard

            Public Property VideoCard As VideoCard

            Public Property GamingChassis As GamingChassis

            Public Property RAM As RAM

            Public Property PowerSupply As PowerSupply
        End Class

        Public Class GamingChassis

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property Trademark As String

            Public Property Type As String

            Public Property Backlight As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class MemorySize

            Public Property Id As Integer

            Public Property Name As String
        End Class

        Public Class MemoryType

            Public Property Id As Integer

            Public Property Name As String
        End Class

        Public Class Motherboard

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property Trademark As String

            Public Property FormFactor As String

            Public Property Socket As String

            Public Property Chipset As String

            Public Property MinMemoryFrequency As String

            Public Property MaxMemoryFrequency As String

            Public Property AmountMemorySlots As Integer

            Public Property SoundAdapterChipset As String

            Public Property SoundScheme As String

            Public Property NetworkAdapterChipset As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class PowerSupply

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property Trademark As String

            Public Property Power As String

            Public Property CPUPowerConnectors As String

            Public Property VideoCardPowerConnectors As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class Processor

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property Trademark As String

            Public Property Socket As String

            Public Property BaseFrequency As String

            Public Property MaxFrequency As String

            Public Property NumberCores As Integer

            Public Property TDP As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class RAM

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property Trademark As String

            Public Property MemoryType As String

            Public Property MemorySize As String

            Public Property ClockFrequency As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class Trademark

            Public Property Id As Integer

            Public Property Name As String

            Public Property Site As String
        End Class

        Public Class VideoCard

            Public Property Id As Integer

            Public Property Name As String

            <DataType(DataType.Currency)>
            Public Property Price As Decimal

            Public Property GraphicsProcessor As String

            Public Property NominalFrequencyVideoChip As String

            Public Property TurboFrequency As String

            Public Property Trademark As String

            Public Property MemoryType As String

            Public Property MemorySize As String

            Public Property ConnectionInterface As String

            Public Property MaximumResolution As String

            Public Property ReleaseYear As Integer

            Public Property AverageRating As Single
        End Class

        Public Class PCConfiguration

            Private _ComputerId As Integer, _Discount As Double, _ModelPrice As Decimal, _AverageRating As Single, _ProcName As String, _ProcPrice As Decimal, _ProcTrademark As String, _ProcSocket As String, _ProcBaseFrequency As String, _ProcMaxFrequency As String, _ProcNumberCores As Integer, _ProcTDP As String, _ProcReleaseYear As Integer, _ProcAverageRating As Single, _MotName As String, _MotPrice As Decimal, _MotTrademark As String, _MotFormFactor As String, _MotSocket As String, _MotChipset As String, _MotMinMemoryFrequency As String, _MotMaxMemoryFrequency As String, _MotAmountMemorySlots As Integer, _MotSoundAdapterChipset As String, _MotSoundScheme As String, _MotNetworkAdapterChipset As String, _MotReleaseYear As Integer, _MotAverageRating As Single, _VidName As String, _VidPrice As Decimal, _VidTrademark As String, _VidGraphicsProcessor As String, _VidNominalFrequencyVideoChip As String, _VidTurboFrequency As String, _VidMemoryType As String, _VidMemorySize As String, _VidConnectionInterface As String, _VidMaximumResolution As String, _VidReleaseYear As Integer, _VidAverageRating As Single, _GamName As String, _GamPrice As Decimal, _GamTrademark As String, _GamType As String, _GamBacklight As String, _GamReleaseYear As Integer, _GamAverageRating As Single, _RamName As String, _RamPrice As Decimal, _RamTrademark As String, _RamMemoryType As String, _RamMemorySize As String, _RamClockFrequency As String, _RamReleaseYear As Integer, _RamAverageRating As Single, _PowName As String, _PowPrice As Decimal, _PowTrademark As String, _PowPower As String, _PowCPUPower As String, _PowVideoCard As String, _PowReleaseYear As Integer, _PowAverageRating As Single

            Public Sub New(ByVal computer As Computer, ByVal id As Integer, ByVal rnd As DevExpress.Data.Utils.NonCryptographicRandom)
                ComputerId = id
                ' Processor
                Dim processor = computer.Processor
                ProcName = processor.Name
                ProcPrice = processor.Price
                ProcTrademark = processor.Trademark
                ProcSocket = processor.Socket
                ProcBaseFrequency = processor.BaseFrequency
                ProcMaxFrequency = processor.MaxFrequency
                ProcNumberCores = processor.NumberCores
                ProcTDP = processor.TDP
                ProcReleaseYear = processor.ReleaseYear
                ProcAverageRating = processor.AverageRating
                ' Motherboard
                Dim motherboard = computer.Motherboard
                MotName = motherboard.Name
                MotPrice = motherboard.Price
                MotTrademark = motherboard.Trademark
                MotFormFactor = motherboard.FormFactor
                MotSocket = motherboard.Socket
                MotChipset = motherboard.Chipset
                MotMinMemoryFrequency = motherboard.MinMemoryFrequency
                MotMaxMemoryFrequency = motherboard.MaxMemoryFrequency
                MotAmountMemorySlots = motherboard.AmountMemorySlots
                MotSoundAdapterChipset = motherboard.SoundAdapterChipset
                MotSoundScheme = motherboard.SoundScheme
                MotNetworkAdapterChipset = motherboard.NetworkAdapterChipset
                MotReleaseYear = motherboard.ReleaseYear
                MotAverageRating = motherboard.AverageRating
                ' Video Card
                Dim videoCard = computer.VideoCard
                VidName = videoCard.Name
                VidPrice = videoCard.Price
                VidTrademark = videoCard.Trademark
                VidGraphicsProcessor = videoCard.GraphicsProcessor
                VidNominalFrequencyVideoChip = videoCard.NominalFrequencyVideoChip
                VidTurboFrequency = videoCard.TurboFrequency
                VidMemoryType = videoCard.MemoryType
                VidMemorySize = videoCard.MemorySize
                VidConnectionInterface = videoCard.ConnectionInterface
                VidMaximumResolution = videoCard.MaximumResolution
                VidReleaseYear = videoCard.ReleaseYear
                VidAverageRating = videoCard.AverageRating
                ' Gaming Chassis
                Dim gamingChassis = computer.GamingChassis
                GamName = gamingChassis.Name
                GamPrice = gamingChassis.Price
                GamTrademark = gamingChassis.Trademark
                GamReleaseYear = gamingChassis.ReleaseYear
                GamType = gamingChassis.Type
                GamBacklight = gamingChassis.Backlight
                GamAverageRating = gamingChassis.AverageRating
                ' RAM
                Dim ram = computer.RAM
                RamName = ram.Name
                RamPrice = ram.Price
                RamTrademark = ram.Trademark
                RamMemoryType = ram.MemoryType
                RamMemorySize = ram.MemorySize
                RamClockFrequency = ram.ClockFrequency
                RamReleaseYear = ram.ReleaseYear
                RamAverageRating = ram.AverageRating
                ' Power Supply
                Dim powerSupply = computer.PowerSupply
                PowName = powerSupply.Name
                PowPrice = powerSupply.Price
                PowTrademark = powerSupply.Trademark
                PowPower = powerSupply.Power
                PowCPUPower = powerSupply.CPUPowerConnectors
                PowVideoCard = powerSupply.VideoCardPowerConnectors
                PowReleaseYear = powerSupply.ReleaseYear
                PowAverageRating = powerSupply.AverageRating
                '
                Discount = Math.Round(0.1 * rnd.Next(1, 5), 2)
                ModelPrice = Decimal.Round(computer.Price - (computer.Price * CDec(Discount)), 2)
                Dim rating As Decimal = CDec(processor.AverageRating) * 10.0D + CDec(videoCard.AverageRating) * 9.0D + CDec(ram.AverageRating) * 8.0D + CDec(motherboard.AverageRating) * 7.0D + CDec(powerSupply.AverageRating) * 6.0D + CDec(gamingChassis.AverageRating) * 5.0D
                AverageRating = CSng(Math.Round(rating / 45.0D, 2))
            End Sub

            Public Property ComputerId As Integer
                Get
                    Return _ComputerId
                End Get

                Private Set(ByVal value As Integer)
                    _ComputerId = value
                End Set
            End Property

            Public Property Discount As Double
                Get
                    Return _Discount
                End Get

                Private Set(ByVal value As Double)
                    _Discount = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property ModelPrice As Decimal
                Get
                    Return _ModelPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _ModelPrice = value
                End Set
            End Property

            Public Property AverageRating As Single
                Get
                    Return _AverageRating
                End Get

                Private Set(ByVal value As Single)
                    _AverageRating = value
                End Set
            End Property

            Public Property ProcName As String
                Get
                    Return _ProcName
                End Get

                Private Set(ByVal value As String)
                    _ProcName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property ProcPrice As Decimal
                Get
                    Return _ProcPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _ProcPrice = value
                End Set
            End Property

            Public Property ProcTrademark As String
                Get
                    Return _ProcTrademark
                End Get

                Private Set(ByVal value As String)
                    _ProcTrademark = value
                End Set
            End Property

            Public Property ProcSocket As String
                Get
                    Return _ProcSocket
                End Get

                Private Set(ByVal value As String)
                    _ProcSocket = value
                End Set
            End Property

            Public Property ProcBaseFrequency As String
                Get
                    Return _ProcBaseFrequency
                End Get

                Private Set(ByVal value As String)
                    _ProcBaseFrequency = value
                End Set
            End Property

            Public Property ProcMaxFrequency As String
                Get
                    Return _ProcMaxFrequency
                End Get

                Private Set(ByVal value As String)
                    _ProcMaxFrequency = value
                End Set
            End Property

            Public Property ProcNumberCores As Integer
                Get
                    Return _ProcNumberCores
                End Get

                Private Set(ByVal value As Integer)
                    _ProcNumberCores = value
                End Set
            End Property

            Public Property ProcTDP As String
                Get
                    Return _ProcTDP
                End Get

                Private Set(ByVal value As String)
                    _ProcTDP = value
                End Set
            End Property

            Public Property ProcReleaseYear As Integer
                Get
                    Return _ProcReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _ProcReleaseYear = value
                End Set
            End Property

            Public Property ProcAverageRating As Single
                Get
                    Return _ProcAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _ProcAverageRating = value
                End Set
            End Property

            Public Property MotName As String
                Get
                    Return _MotName
                End Get

                Private Set(ByVal value As String)
                    _MotName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property MotPrice As Decimal
                Get
                    Return _MotPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _MotPrice = value
                End Set
            End Property

            Public Property MotTrademark As String
                Get
                    Return _MotTrademark
                End Get

                Private Set(ByVal value As String)
                    _MotTrademark = value
                End Set
            End Property

            Public Property MotFormFactor As String
                Get
                    Return _MotFormFactor
                End Get

                Private Set(ByVal value As String)
                    _MotFormFactor = value
                End Set
            End Property

            Public Property MotSocket As String
                Get
                    Return _MotSocket
                End Get

                Private Set(ByVal value As String)
                    _MotSocket = value
                End Set
            End Property

            Public Property MotChipset As String
                Get
                    Return _MotChipset
                End Get

                Private Set(ByVal value As String)
                    _MotChipset = value
                End Set
            End Property

            Public Property MotMinMemoryFrequency As String
                Get
                    Return _MotMinMemoryFrequency
                End Get

                Private Set(ByVal value As String)
                    _MotMinMemoryFrequency = value
                End Set
            End Property

            Public Property MotMaxMemoryFrequency As String
                Get
                    Return _MotMaxMemoryFrequency
                End Get

                Private Set(ByVal value As String)
                    _MotMaxMemoryFrequency = value
                End Set
            End Property

            Public Property MotAmountMemorySlots As Integer
                Get
                    Return _MotAmountMemorySlots
                End Get

                Private Set(ByVal value As Integer)
                    _MotAmountMemorySlots = value
                End Set
            End Property

            Public Property MotSoundAdapterChipset As String
                Get
                    Return _MotSoundAdapterChipset
                End Get

                Private Set(ByVal value As String)
                    _MotSoundAdapterChipset = value
                End Set
            End Property

            Public Property MotSoundScheme As String
                Get
                    Return _MotSoundScheme
                End Get

                Private Set(ByVal value As String)
                    _MotSoundScheme = value
                End Set
            End Property

            Public Property MotNetworkAdapterChipset As String
                Get
                    Return _MotNetworkAdapterChipset
                End Get

                Private Set(ByVal value As String)
                    _MotNetworkAdapterChipset = value
                End Set
            End Property

            Public Property MotReleaseYear As Integer
                Get
                    Return _MotReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _MotReleaseYear = value
                End Set
            End Property

            Public Property MotAverageRating As Single
                Get
                    Return _MotAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _MotAverageRating = value
                End Set
            End Property

            Public Property VidName As String
                Get
                    Return _VidName
                End Get

                Private Set(ByVal value As String)
                    _VidName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property VidPrice As Decimal
                Get
                    Return _VidPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _VidPrice = value
                End Set
            End Property

            Public Property VidTrademark As String
                Get
                    Return _VidTrademark
                End Get

                Private Set(ByVal value As String)
                    _VidTrademark = value
                End Set
            End Property

            Public Property VidGraphicsProcessor As String
                Get
                    Return _VidGraphicsProcessor
                End Get

                Private Set(ByVal value As String)
                    _VidGraphicsProcessor = value
                End Set
            End Property

            Public Property VidNominalFrequencyVideoChip As String
                Get
                    Return _VidNominalFrequencyVideoChip
                End Get

                Private Set(ByVal value As String)
                    _VidNominalFrequencyVideoChip = value
                End Set
            End Property

            Public Property VidTurboFrequency As String
                Get
                    Return _VidTurboFrequency
                End Get

                Private Set(ByVal value As String)
                    _VidTurboFrequency = value
                End Set
            End Property

            Public Property VidMemoryType As String
                Get
                    Return _VidMemoryType
                End Get

                Private Set(ByVal value As String)
                    _VidMemoryType = value
                End Set
            End Property

            Public Property VidMemorySize As String
                Get
                    Return _VidMemorySize
                End Get

                Private Set(ByVal value As String)
                    _VidMemorySize = value
                End Set
            End Property

            Public Property VidConnectionInterface As String
                Get
                    Return _VidConnectionInterface
                End Get

                Private Set(ByVal value As String)
                    _VidConnectionInterface = value
                End Set
            End Property

            Public Property VidMaximumResolution As String
                Get
                    Return _VidMaximumResolution
                End Get

                Private Set(ByVal value As String)
                    _VidMaximumResolution = value
                End Set
            End Property

            Public Property VidReleaseYear As Integer
                Get
                    Return _VidReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _VidReleaseYear = value
                End Set
            End Property

            Public Property VidAverageRating As Single
                Get
                    Return _VidAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _VidAverageRating = value
                End Set
            End Property

            Public Property GamName As String
                Get
                    Return _GamName
                End Get

                Private Set(ByVal value As String)
                    _GamName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property GamPrice As Decimal
                Get
                    Return _GamPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _GamPrice = value
                End Set
            End Property

            Public Property GamTrademark As String
                Get
                    Return _GamTrademark
                End Get

                Private Set(ByVal value As String)
                    _GamTrademark = value
                End Set
            End Property

            Public Property GamType As String
                Get
                    Return _GamType
                End Get

                Private Set(ByVal value As String)
                    _GamType = value
                End Set
            End Property

            Public Property GamBacklight As String
                Get
                    Return _GamBacklight
                End Get

                Private Set(ByVal value As String)
                    _GamBacklight = value
                End Set
            End Property

            Public Property GamReleaseYear As Integer
                Get
                    Return _GamReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _GamReleaseYear = value
                End Set
            End Property

            Public Property GamAverageRating As Single
                Get
                    Return _GamAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _GamAverageRating = value
                End Set
            End Property

            Public Property RamName As String
                Get
                    Return _RamName
                End Get

                Private Set(ByVal value As String)
                    _RamName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property RamPrice As Decimal
                Get
                    Return _RamPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _RamPrice = value
                End Set
            End Property

            Public Property RamTrademark As String
                Get
                    Return _RamTrademark
                End Get

                Private Set(ByVal value As String)
                    _RamTrademark = value
                End Set
            End Property

            Public Property RamMemoryType As String
                Get
                    Return _RamMemoryType
                End Get

                Private Set(ByVal value As String)
                    _RamMemoryType = value
                End Set
            End Property

            Public Property RamMemorySize As String
                Get
                    Return _RamMemorySize
                End Get

                Private Set(ByVal value As String)
                    _RamMemorySize = value
                End Set
            End Property

            Public Property RamClockFrequency As String
                Get
                    Return _RamClockFrequency
                End Get

                Private Set(ByVal value As String)
                    _RamClockFrequency = value
                End Set
            End Property

            Public Property RamReleaseYear As Integer
                Get
                    Return _RamReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _RamReleaseYear = value
                End Set
            End Property

            Public Property RamAverageRating As Single
                Get
                    Return _RamAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _RamAverageRating = value
                End Set
            End Property

            Public Property PowName As String
                Get
                    Return _PowName
                End Get

                Private Set(ByVal value As String)
                    _PowName = value
                End Set
            End Property

            <DataType(DataType.Currency)>
            Public Property PowPrice As Decimal
                Get
                    Return _PowPrice
                End Get

                Private Set(ByVal value As Decimal)
                    _PowPrice = value
                End Set
            End Property

            Public Property PowTrademark As String
                Get
                    Return _PowTrademark
                End Get

                Private Set(ByVal value As String)
                    _PowTrademark = value
                End Set
            End Property

            Public Property PowPower As String
                Get
                    Return _PowPower
                End Get

                Private Set(ByVal value As String)
                    _PowPower = value
                End Set
            End Property

            Public Property PowCPUPower As String
                Get
                    Return _PowCPUPower
                End Get

                Private Set(ByVal value As String)
                    _PowCPUPower = value
                End Set
            End Property

            Public Property PowVideoCard As String
                Get
                    Return _PowVideoCard
                End Get

                Private Set(ByVal value As String)
                    _PowVideoCard = value
                End Set
            End Property

            Public Property PowReleaseYear As Integer
                Get
                    Return _PowReleaseYear
                End Get

                Private Set(ByVal value As Integer)
                    _PowReleaseYear = value
                End Set
            End Property

            Public Property PowAverageRating As Single
                Get
                    Return _PowAverageRating
                End Get

                Private Set(ByVal value As Single)
                    _PowAverageRating = value
                End Set
            End Property
        End Class
#End Region
    End Class
End Namespace

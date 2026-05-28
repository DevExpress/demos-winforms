Imports System.Management
Imports System.Threading
Imports DevExpress.XtraGauges.Win.Gauges.Circular

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucSysInfo
        Inherits BaseModule

        Private buffer As PerfomanceInfo_CPU()

        Private pollingTimer As Timer

        Public Sub New()
            buffer = New PerfomanceInfo_CPU(2) {}
            InitializeComponent()
            If DataHelper.WmiService.Connected Then
                Dim processors As String() = GetProcessorNames(DataHelper.WmiService)
                DashboardGauge.Labels("processorName").Text = processors(0)
                DashboardGauge.Labels("osName").Text = GetOSName(DataHelper.WmiService)
                DashboardGauge.Scales("memoryTotal").MaxValue = GetTotalMemorySizeMB(DataHelper.WmiService)
                DashboardGauge.Scales("hddTotal").MaxValue = GetTotalHDDSizeGB(DataHelper.WmiService)
                pollingTimer = New Timer(AddressOf OnTimerCallback, Nothing, 1000, 300)
                OnTimerCallback(Nothing)
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso pollingTimer IsNot Nothing Then
                Dim pollingStopped As AutoResetEvent = New AutoResetEvent(False)
                pollingTimer.Dispose(pollingStopped)
                pollingStopped.WaitOne()
            End If

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "System Information"
            End Get
        End Property

        Private Shared stateCounter As Integer = 0

        Private Shared lockTimerCounter As Integer = 0

        Private Shared Function GetTotalMemorySizeMB(ByVal wmiService As WMIService) As Integer
            Dim collection As ManagementObject() = wmiService.GetObjects("Select TotalVisibleMemorySize From Win32_OperatingSystem", True)
            Return If(collection.Length = 1, CInt((CULng(collection(0).Properties("TotalVisibleMemorySize").Value) / 1024)), 4096)
        End Function

        Private Shared Function GetFreeMemorySizeMB(ByVal wmiService As WMIService) As Integer
            Dim collection As ManagementObject() = wmiService.GetObjects("Select FreePhysicalMemory From Win32_OperatingSystem", False)
            Return If(collection.Length = 1, CInt((CULng(collection(0).Properties("FreePhysicalMemory").Value) / 1024)), 4096)
        End Function

        Private Shared Function GetTotalHDDSizeGB(ByVal wmiService As WMIService) As Integer
            Dim collection As ManagementObject() = wmiService.GetObjects("Select Size From Win32_LogicalDisk ", True)
            Dim size As ULong = 0
            For i As Integer = 0 To collection.Length - 1
                Dim pData As PropertyData = collection(i).Properties("Size")
                size +=(If(pData IsNot Nothing AndAlso pData.Value IsNot Nothing, CULng(pData.Value), 0UI))
            Next

            Return CInt(size >> 30)
        End Function

        Private Shared Function GetFreeHDDSizeGB(ByVal wmiService As WMIService) As Integer
            Dim collection As ManagementObject() = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", False)
            Dim size As ULong = 0
            For i As Integer = 0 To collection.Length - 1
                Dim pData As PropertyData = collection(i).Properties("FreeSpace")
                size +=(If(pData IsNot Nothing AndAlso pData.Value IsNot Nothing, CULng(pData.Value), 0UI))
            Next

            Return CInt(size >> 30)
        End Function

        Private Shared Function GetOSName(ByVal wmiService As WMIService) As String
            Dim collection As ManagementObject() = wmiService.GetObjects("Select Caption From Win32_OperatingSystem", True)
            Return If(collection.Length = 1, CStr(collection(0).Properties("Caption").Value), String.Empty)
        End Function

        Private Shared Function GetProcessorNames(ByVal wmiService As WMIService) As String()
            Dim collection As ManagementObject() = wmiService.GetObjects("Select Name From Win32_Processor", True)
            Dim result As String() = New String(collection.Length - 1) {}
            For i As Integer = 0 To collection.Length - 1
                result(i) = CStr(collection(i).Properties("Name").Value)
            Next

            Return result
        End Function

        Private Shared Function GetPerfomanceInfo_CPU(ByVal wmiService As WMIService) As PerfomanceInfo_CPU()
            Dim collection As ManagementObject() = wmiService.GetObjects("SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " & "FROM Win32_PerfFormattedData_PerfOS_Processor " & "WHERE Name='_Total'", False)
            Dim result As PerfomanceInfo_CPU() = New PerfomanceInfo_CPU(collection.Length - 1) {}
            For i As Integer = 0 To collection.Length - 1
                result(i) = New PerfomanceInfo_CPU(CStr(collection(i).Properties("Name").Value), CSng(CULng(collection(i).Properties("PercentProcessorTime").Value)), CSng(CULng(collection(i).Properties("PercentPrivilegedTime").Value)), CSng(CULng(collection(i).Properties("PercentUserTime").Value)))
            Next

            Return result
        End Function

        Private Shared Function GetPerfomanceInfo_OS(ByVal wmiService As WMIService) As PerfomanceInfo_OS()
            Dim collection As ManagementObject() = wmiService.GetObjects("SELECT Name,Processes,Threads " & "FROM Win32_PerfFormattedData_PerfOS_System", False)
            Dim result As PerfomanceInfo_OS() = New PerfomanceInfo_OS(collection.Length - 1) {}
            For i As Integer = 0 To collection.Length - 1
                result(i) = New PerfomanceInfo_OS(CStr(collection(i).Properties("Name").Value), CInt(CUInt(collection(i).Properties("Processes").Value)), CInt(CUInt(collection(i).Properties("Threads").Value)))
            Next

            Return result
        End Function

        Private Sub OnTimerCallback(ByVal state As Object)
            If Interlocked.CompareExchange(lockTimerCounter, 1, 0) = 0 Then
                If DataHelper.WmiService IsNot Nothing AndAlso DashboardGauge IsNot Nothing AndAlso Not DashboardGauge.IsDisposing Then
                    UpdatePerfomanceData_CPU()
                    If stateCounter Mod 5 = 0 Then UpdatePerfomanceData_OS()
                    If stateCounter Mod 10 = 0 Then UpdatePerfomanceData_Memory()
                    If stateCounter Mod 20 = 0 Then UpdatePerfomanceData_HDD()
                End If

                stateCounter += 1
                Interlocked.Add(lockTimerCounter, -1)
            End If
        End Sub

        Private Sub UpdatePerfomanceData_CPU()
            Dim infos As PerfomanceInfo_CPU() = GetPerfomanceInfo_CPU(DataHelper.WmiService)
            If infos.Length = 1 Then
                Dim info As PerfomanceInfo_CPU = GetBufferedPerfomanceInfo(infos(0))
                DashboardGauge.Scales("cpuTotal").Value = info.Total
                DashboardGauge.Scales("cpuUser").Value = info.Kernel + info.User
                DashboardGauge.Scales("cpuKernel").Value = info.Kernel
            End If
        End Sub

        Private Sub UpdatePerfomanceData_OS()
            Dim infos As PerfomanceInfo_OS() = GetPerfomanceInfo_OS(DataHelper.WmiService)
            If infos.Length = 1 Then
                DashboardGauge.Scales("osThreads").Value = infos(0).Threads
                DashboardGauge.Scales("osProcesses").Value = infos(0).Processes
            End If
        End Sub

        Private Sub UpdatePerfomanceData_Memory()
            DashboardGauge.Scales("memoryTotal").Value = GetFreeMemorySizeMB(DataHelper.WmiService)
        End Sub

        Private Sub UpdatePerfomanceData_HDD()
            DashboardGauge.Scales("hddTotal").Value = GetFreeHDDSizeGB(DataHelper.WmiService)
        End Sub

        Private Function GetBufferedPerfomanceInfo(ByVal currentValue As PerfomanceInfo_CPU) As PerfomanceInfo_CPU
            For i As Integer = 1 To buffer.Length - 1
                buffer(i - 1) = buffer(i)
            Next

            buffer(buffer.Length - 1) = currentValue
            Dim total As Single = 0
            Dim kernel As Single = 0
            Dim user As Single = 0
            Dim n As Integer = 0
            For i As Integer = 0 To buffer.Length - 1
                If buffer(i) IsNot Nothing Then
                    total += buffer(i).Total
                    kernel += buffer(i).Kernel
                    user += buffer(i).User
                    n += 1
                End If
            Next

            Return New PerfomanceInfo_CPU(currentValue.Name, total / CSng(n), kernel / CSng(n), user / CSng(n))
        End Function

        Protected ReadOnly Property DashboardGauge As CircularGauge
            Get
                If gaugeControl1.Gauges Is Nothing Then Return Nothing
                Return TryCast(gaugeControl1.Gauges(0), CircularGauge)
            End Get
        End Property
    End Class

    Friend Class PerfomanceInfo_CPU

        Private nameCore As String

        Private totalCore As Single

        Private kernelCore As Single

        Private userCore As Single

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Public ReadOnly Property Total As Single
            Get
                Return totalCore
            End Get
        End Property

        Public ReadOnly Property Kernel As Single
            Get
                Return kernelCore
            End Get
        End Property

        Public ReadOnly Property User As Single
            Get
                Return userCore
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal total As Single, ByVal kernel As Single, ByVal user As Single)
            nameCore = name
            totalCore = total
            kernelCore = kernel
            userCore = user
        End Sub
    End Class

    Friend Class PerfomanceInfo_OS

        Private nameCore As String

        Private processesCore As Integer

        Private threadsCore As Integer

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Public ReadOnly Property Processes As Integer
            Get
                Return processesCore
            End Get
        End Property

        Public ReadOnly Property Threads As Integer
            Get
                Return threadsCore
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal processes As Integer, ByVal threads As Integer)
            nameCore = name
            processesCore = processes
            threadsCore = threads
        End Sub
    End Class

    Friend Class MemoryPerfomanceInfo

        Private nameCore As String

        Private totalCore As Integer

        Private freeCore As Integer

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Public ReadOnly Property Total As Integer
            Get
                Return totalCore
            End Get
        End Property

        Public ReadOnly Property Free As Integer
            Get
                Return freeCore
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal total As Integer, ByVal free As Integer)
            nameCore = name
            totalCore = total
            freeCore = free
        End Sub
    End Class
End Namespace

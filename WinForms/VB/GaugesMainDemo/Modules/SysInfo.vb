Imports System
Imports System.Collections.Generic
Imports System.Management
Imports System.Threading
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Gauges.Circular

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class SysInfo
        Inherits TutorialControl

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
            Dim _size As ULong = 0
            For i As Integer = 0 To collection.Length - 1
                Dim pData As PropertyData = collection(i).Properties("Size")
                _size +=(If(pData IsNot Nothing AndAlso pData.Value IsNot Nothing, CULng(pData.Value), 0UI))
            Next

            Return CInt(_size >> 30)
        End Function

        Private Shared Function GetFreeHDDSizeGB(ByVal wmiService As WMIService) As Integer
            Dim collection As ManagementObject() = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", False)
            Dim _size As ULong = 0
            For i As Integer = 0 To collection.Length - 1
                Dim pData As PropertyData = collection(i).Properties("FreeSpace")
                _size +=(If(pData IsNot Nothing AndAlso pData.Value IsNot Nothing, CULng(pData.Value), 0UI))
            Next

            Return CInt(_size >> 30)
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

        Private Shared Function GetPerfomanceInfo_CPU(ByVal wmiService As WMIService) As PerformanceInfo_CPU()
            Dim result As PerformanceInfo_CPU() = New PerformanceInfo_CPU(-1) {}
            Try
                Dim collection As ManagementObject() = wmiService.GetObjects("SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " & "FROM Win32_PerfFormattedData_PerfOS_Processor " & "WHERE Name='_Total'", False)
                result = New PerformanceInfo_CPU(collection.Length - 1) {}
                For i As Integer = 0 To collection.Length - 1
                    result(i) = New PerformanceInfo_CPU(CStr(collection(i).Properties("Name").Value), CSng(CULng(collection(i).Properties("PercentProcessorTime").Value)), CSng(CULng(collection(i).Properties("PercentPrivilegedTime").Value)), CSng(CULng(collection(i).Properties("PercentUserTime").Value)))
                Next
            Catch
            End Try

            Return result
        End Function

        Private Shared Function GetPerfomanceInfo_OS(ByVal wmiService As WMIService) As PerformanceInfo_OS()
            Dim result As PerformanceInfo_OS() = New PerformanceInfo_OS(-1) {}
            Try
                Dim collection As ManagementObject() = wmiService.GetObjects("SELECT Name,Processes,Threads " & "FROM Win32_PerfFormattedData_PerfOS_System", False)
                result = New PerformanceInfo_OS(collection.Length - 1) {}
                For i As Integer = 0 To collection.Length - 1
                    result(i) = New PerformanceInfo_OS(CStr(collection(i).Properties("Name").Value), CInt(CUInt(collection(i).Properties("Processes").Value)), CInt(CUInt(collection(i).Properties("Threads").Value)))
                Next
            Catch
            End Try

            Return result
        End Function

        Private buffer As PerformanceInfo_CPU()

        Private wmiService As WMIService

        Private pollingTimer As Timer

        Public Sub New()
            buffer = New PerformanceInfo_CPU(2) {}
            wmiService = WMIService.GetInstance(Nothing)
            InitializeComponent()
            updateSpeed.Value = 6
            If wmiService.Connected Then
                Dim processors As String() = GetProcessorNames(wmiService)
                DashboardGauge.Labels("processorName").Text = processors(0)
                DashboardGauge.Labels("osName").Text = GetOSName(wmiService)
                DashboardGauge.Scales("memoryTotal").MaxValue = GetTotalMemorySizeMB(wmiService)
                DashboardGauge.Scales("hddTotal").MaxValue = GetTotalHDDSizeGB(wmiService)
                pollingTimer = New Timer(AddressOf OnTimerCallback, Nothing, 1000, 300)
                OnTimerCallback(Nothing)
            End If
        End Sub

        Private Sub OnTimerCallback(ByVal state As Object)
            If Interlocked.CompareExchange(lockTimerCounter, 1, 0) = 0 Then
                UpdateData()
                stateCounter += 1
                Interlocked.Add(lockTimerCounter, -1)
            End If
        End Sub

        Private Sub InvokeUpdate(ByVal action As Action)
            If IsHandleCreated AndAlso DashboardGauge IsNot Nothing Then BeginInvoke(action)
        End Sub

        Private Sub UpdateData()
            If wmiService IsNot Nothing Then
                UpdatePerfomanceData_CPU()
                If stateCounter Mod 5 = 0 Then UpdatePerfomanceData_OS()
                If stateCounter Mod 10 = 0 Then UpdatePerfomanceData_Memory()
                If stateCounter Mod 20 = 0 Then UpdatePerfomanceData_HDD()
            End If
        End Sub

        Private Sub UpdatePerfomanceData_CPU()
            Dim infos As PerformanceInfo_CPU() = GetPerfomanceInfo_CPU(wmiService)
            If infos.Length = 1 Then
                Dim info As PerformanceInfo_CPU = GetBufferedPerfomanceInfo(infos(0))
                InvokeUpdate(Sub()
                    DashboardGauge.Scales("cpuTotal").Value = info.Total
                    DashboardGauge.Scales("cpuUser").Value = info.Kernel + info.User
                    DashboardGauge.Scales("cpuKernel").Value = info.Kernel
                End Sub)
            End If
        End Sub

        Private Sub UpdatePerfomanceData_OS()
            Dim infos As PerformanceInfo_OS() = GetPerfomanceInfo_OS(wmiService)
            If infos.Length = 1 Then
                InvokeUpdate(Sub()
                    DashboardGauge.Scales("osThreads").Value = infos(0).Threads
                    DashboardGauge.Scales("osProcesses").Value = infos(0).Processes
                End Sub)
            End If
        End Sub

        Private Sub UpdatePerfomanceData_Memory()
            InvokeUpdate(Sub() DashboardGauge.Scales("memoryTotal").Value = GetFreeMemorySizeMB(wmiService))
        End Sub

        Private Sub UpdatePerfomanceData_HDD()
            InvokeUpdate(Sub() DashboardGauge.Scales("hddTotal").Value = GetFreeHDDSizeGB(wmiService))
        End Sub

        Private Sub OnUpdateSpeedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim speed As Integer = 50 + (updateSpeed.Properties.Maximum - updateSpeed.Value) * 50
            If pollingTimer IsNot Nothing Then pollingTimer.Change(0, speed)
        End Sub

        Private Function GetBufferedPerfomanceInfo(ByVal currentValue As PerformanceInfo_CPU) As PerformanceInfo_CPU
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

            Return New PerformanceInfo_CPU(currentValue.Name, total / CSng(n), kernel / CSng(n), user / CSng(n))
        End Function

        Protected ReadOnly Property DashboardGauge As CircularGauge
            Get
                Return TryCast(gaugeControl1.Gauges(0), CircularGauge)
            End Get
        End Property

        Public Overrides ReadOnly Property ShowExportMenu As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As GaugeControl
            Get
                Return gaugeControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class

    Friend Class PerformanceInfo_CPU

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

    Friend Class PerformanceInfo_OS

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

    Friend Class MemoryPerformanceInfo

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

    Public NotInheritable Class WMIService
        Implements IDisposable

        Public Shared Function GetInstance(ByVal path As String) As WMIService
            Return New WMIService(If(String.IsNullOrEmpty(path), "//./root/cimv2", path))
        End Function

        Private connectedCore As Boolean = False

        Private scopeCore As ManagementScope

        Private queryCacheCore As Dictionary(Of String, ManagementObjectCollection)

        Private ReadOnly Property QueryCache As Dictionary(Of String, ManagementObjectCollection)
            Get
                Return queryCacheCore
            End Get
        End Property

        Public ReadOnly Property Connected As Boolean
            Get
                Return connectedCore
            End Get
        End Property

        Public ReadOnly Property Scope As ManagementScope
            Get
                Return scopeCore
            End Get
        End Property

        Private Sub New(ByVal path As String)
            queryCacheCore = New Dictionary(Of String, ManagementObjectCollection)()
            Dim options As ConnectionOptions = New ConnectionOptions()
            options.Impersonation = ImpersonationLevel.Impersonate
            options.Authentication = AuthenticationLevel.Packet
            scopeCore = New ManagementScope(path, options)
            Try
                Scope.Connect()
                connectedCore = Scope.IsConnected
            Catch
                connectedCore = False
            End Try
        End Sub

        Private Function GetManagementObjectCollection(ByVal queryString As String) As ManagementObjectCollection
            Dim result As ManagementObjectCollection = Nothing
            Dim query As ObjectQuery = New ObjectQuery(queryString)
            Using searcher As ManagementObjectSearcher = New ManagementObjectSearcher(Scope, query)
                result = searcher.Get()
            End Using

            Return result
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            connectedCore = False
            If queryCacheCore IsNot Nothing Then
                For Each pair As KeyValuePair(Of String, ManagementObjectCollection) In queryCacheCore
                    If pair.Value IsNot Nothing Then pair.Value.Dispose()
                Next

                queryCacheCore.Clear()
                queryCacheCore = Nothing
            End If

            scopeCore = Nothing
        End Sub

        Public Function GetObjectCollection(ByVal queryString As String, ByVal allowQueryCaching As Boolean) As ManagementObjectCollection
            Dim result As ManagementObjectCollection = Nothing
            If allowQueryCaching Then QueryCache.TryGetValue(queryString, result)
            If result Is Nothing Then
                result = GetManagementObjectCollection(queryString)
                If allowQueryCaching Then
                    If QueryCache.ContainsKey(queryString) Then
                        QueryCache(queryString) = result
                    Else
                        QueryCache.Add(queryString, result)
                    End If
                End If
            End If

            Return result
        End Function

        Public Function GetObjects(ByVal queryString As String, ByVal allowQueryCaching As Boolean) As ManagementObject()
            Dim collection As ManagementObjectCollection = GetObjectCollection(queryString, allowQueryCaching)
            Dim count As Integer = If(collection?.Count, 0)
            Dim result As ManagementObject() = New ManagementObject(count - 1) {}
            If collection IsNot Nothing AndAlso count > 0 Then collection.CopyTo(result, 0)
            Return result
        End Function
    End Class
End Namespace

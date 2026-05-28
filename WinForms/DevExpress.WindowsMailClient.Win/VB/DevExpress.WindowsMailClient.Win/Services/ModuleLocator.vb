Imports System
Imports System.Collections.Generic
Imports DevExpress.Mvvm
Imports DevExpress.WindowsMailClient.Win.Modules

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Interface IModuleLocator

        Function IsModuleLoaded(ByVal moduleType As ModuleType) As Boolean

        Function GetModule(ByVal moduleType As ModuleType) As Object

        Function CreateModule(ByVal moduleType As ModuleType) As Object

        Function GetModule(ByVal moduleType As ModuleType, ByVal viewModel As Object) As Object

        Function GetModule(ByVal moduleType As ModuleType, ByVal keyParameter As Long) As Object

        Sub ReleaseModule(ByVal [module] As Object)

    End Interface

    Public Class ModuleLocator
        Implements IModuleLocator

        Private serviceContainer As IServiceContainer

        Private modulesCache As IDictionary(Of ModuleType, WeakReference)

        Private modulesIdentityCache As IDictionary(Of ModuleType, IDictionary(Of Long, WeakReference))

        Public Sub New(ByVal serviceContainer As IServiceContainer)
            Me.serviceContainer = serviceContainer
            modulesCache = New Dictionary(Of ModuleType, WeakReference)()
            modulesIdentityCache = New Dictionary(Of ModuleType, IDictionary(Of Long, WeakReference))()
        End Sub

        Public Function IsModuleLoaded(ByVal moduleType As ModuleType) As Boolean Implements IModuleLocator.IsModuleLoaded
            Return modulesCache.ContainsKey(moduleType)
        End Function

        Public Function CreateModule(ByVal moduleType As ModuleType) As Object Implements IModuleLocator.CreateModule
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Dim resolver = serviceContainer.GetService(Of IModuleTypesResolver)()
            Return activator.CreateModule(resolver.GetTypeName(moduleType))
        End Function

        Public Function GetModule(ByVal moduleType As ModuleType, ByVal keyParameter As Long) As Object Implements IModuleLocator.GetModule
            If moduleType = ModuleType.Unknown Then Return Nothing
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Dim identityCache As IDictionary(Of Long, WeakReference) = Nothing
            If Not modulesIdentityCache.TryGetValue(moduleType, identityCache) Then
                identityCache = New Dictionary(Of Long, WeakReference)()
                modulesIdentityCache.Add(moduleType, identityCache)
            End If

            Return GetModuleCore(identityCache, keyParameter, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName), Nothing)
        End Function

        Public Function GetModule(ByVal moduleType As ModuleType, ByVal viewModel As Object) As Object Implements IModuleLocator.GetModule
            If moduleType = ModuleType.Unknown Then Return Nothing
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Return GetModuleCore(modulesCache, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName, parameter), viewModel)
        End Function

        Public Function GetModule(ByVal moduleType As ModuleType) As Object Implements IModuleLocator.GetModule
            If moduleType = ModuleType.Unknown Then Return Nothing
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Return GetModuleCore(modulesCache, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName), Nothing)
        End Function

        Public Sub ReleaseModule(ByVal [module] As Object) Implements IModuleLocator.ReleaseModule
            ClearCore(modulesCache, [module])
            For Each item In modulesIdentityCache
                ClearCore(item.Value, [module])
            Next
        End Sub

        Private Function GetModuleCore(ByVal cache As IDictionary(Of ModuleType, WeakReference), ByVal moduleType As ModuleType, ByVal activatorRoutine As Func(Of String, Object, Object), ByVal parameter As Object) As Object
            Return GetModuleCore(cache, moduleType, moduleType, activatorRoutine, parameter)
        End Function

        Private Function GetModuleCore(Of TKey)(ByVal cache As IDictionary(Of TKey, WeakReference), ByVal key As TKey, ByVal moduleType As ModuleType, ByVal activatorRoutine As Func(Of String, Object, Object), ByVal parameter As Object) As Object
            Dim moduleReference As WeakReference = Nothing
            If Not cache.TryGetValue(key, moduleReference) OrElse moduleReference.Target Is Nothing Then
                Dim resolver = serviceContainer.GetService(Of IModuleTypesResolver)()
                Dim [module] = activatorRoutine(resolver.GetTypeName(moduleType), parameter)
                If moduleReference Is Nothing Then
                    moduleReference = New WeakReference([module])
                    cache.Add(key, moduleReference)
                Else
                    moduleReference.Target = [module]
                End If
            End If

            Return moduleReference.Target
        End Function

        Private Sub ClearCore(Of TKey)(ByVal cache As IDictionary(Of TKey, WeakReference), ByVal [module] As Object)
            Dim key As TKey = Nothing
            For Each item In cache
                If Not Equals(item.Value.Target, [module]) Then Continue For
                key = item.Key
                Exit For
            Next

            cache.Remove(key)
        End Sub
    End Class
End Namespace

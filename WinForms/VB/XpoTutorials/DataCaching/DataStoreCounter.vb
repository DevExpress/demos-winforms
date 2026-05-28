Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo.DB

Namespace DevExpress.Xpo.Demos
    Public Class DataStoreCounter
        Implements IDataStore
        Private Shared _selectCounterValue As Integer
        Public Shared ReadOnly Property SelectCounterValue() As Integer
            Get
                Return _selectCounterValue
            End Get
        End Property
        Public Shared Sub ClearCounter()
            _selectCounterValue = 0
        End Sub
        Private ReadOnly dataStore As IDataStore
        Public Sub New(ByVal dataStore As IDataStore)
            Me.dataStore = dataStore
        End Sub

#Region "IDataStore Members"

        Public ReadOnly Property AutoCreateOption() As AutoCreateOption Implements IDataStore.AutoCreateOption
            Get
                Return dataStore.AutoCreateOption
            End Get
        End Property

        Public Function ModifyData(ByVal ParamArray dmlStatements() As ModificationStatement) As ModificationResult Implements IDataStore.ModifyData
            Return dataStore.ModifyData(dmlStatements)
        End Function

        Public Function SelectData(ByVal ParamArray selects() As SelectStatement) As SelectedData Implements IDataStore.SelectData
            _selectCounterValue += 1
            Return dataStore.SelectData(selects)
        End Function

        Public Function UpdateSchema(ByVal dontCreateIfFirstTableNotExist As Boolean, ByVal ParamArray tables() As DBTable) As UpdateSchemaResult Implements IDataStore.UpdateSchema
            Return dataStore.UpdateSchema(dontCreateIfFirstTableNotExist, tables)
        End Function

#End Region
    End Class
End Namespace

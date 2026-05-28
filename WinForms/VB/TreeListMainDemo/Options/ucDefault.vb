Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucDefault
        Inherits XtraUserControl

        Private treeListCore As TreeList

        Private isInitializingCore As Integer = 0

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub InitData(ByVal treeList As TreeList)
            isInitializingCore += 1
            treeListCore = treeList
            InitDataCore()
            isInitializingCore -= 1
        End Sub

        Protected ReadOnly Property TreeList As TreeList
            Get
                Return treeListCore
            End Get
        End Property

        Protected Overridable Sub InitDataCore()
        End Sub

        Protected ReadOnly Property IsInitializing As Boolean
            Get
                Return isInitializingCore > 0
            End Get
        End Property
    End Class
End Namespace

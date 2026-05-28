Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraEditors.Demos.CodeExamples

    Public Class FilteringModule
        Inherits DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase

        Shared Sub New()
            Dim type = GetType(DevExpress.Utils.Filtering.FilteringUIContext)
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides ReadOnly Property UseSameTutorialControlNameForGenerateExample As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

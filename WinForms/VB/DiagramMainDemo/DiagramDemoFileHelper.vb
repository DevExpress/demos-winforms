Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraDiagram.Demos
Imports System.Drawing
Imports System.IO

Namespace DevExpress.Diagram.Demos

    Public Module DiagramDemoFileHelper

        Public Function GetDataStream(ByVal fileName As String) As Stream
            Return File.OpenRead(DiagramTutorialControlBase.GetDataFileName(fileName))
        End Function

        Public Function GetImageResource(ByVal path As String) As Image
            Dim assembly = GetType(DiagramDemoFileHelper).Assembly
            Dim stream = AssemblyHelper.GetResourceStream(assembly, path, True)
            Return New Bitmap(stream)
        End Function

        Public Function GetSvgImageResource(ByVal path As String) As SvgImage
            Dim assembly = GetType(DiagramDemoFileHelper).Assembly
            Dim stream = AssemblyHelper.GetResourceStream(assembly, path, True)
            Return SvgImage.FromStream(stream)
        End Function
    End Module
End Namespace

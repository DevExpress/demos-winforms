Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class ImagesModule
        Inherits DocumentModuleBase

        Public Sub New()
            InitializeComponent()
            AddHandler diagramControl.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf DiagramControl_MouseClick) 'VB
        End Sub

        Protected Overrides ReadOnly Property DocumentName As String
            Get
                Return "Images.xml"
            End Get
        End Property

        Private Sub DiagramControl_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button <> System.Windows.Forms.MouseButtons.Left Then Return
            Dim imageItem = TryCast(diagramControl.CalcHitItem(New System.Drawing.PointF(e.X, e.Y)), DiagramImage)
            If imageItem Is Nothing OrElse Not Equals(imageItem.Tag, GetType(DiagramImage).Name) Then Return
            diagramControl.SelectItem(imageItem)
            diagramControl.LoadImage()
        End Sub
    End Class
End Namespace

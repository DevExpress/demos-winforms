Namespace DevExpress.ApplicationUI.Demos

    Partial Class BaseControl

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.Images = Me.svgImageCollection1
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            AddHandler Me.dockManager1.RegisterDockPanel, New DevExpress.XtraBars.Docking.DockPanelEventHandler(AddressOf Me.dockManager1_RegisterDockPanel)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("insertimage", "image://svgimages/richedit/insertimage.svg")
            Me.svgImageCollection1.Add("private", "image://svgimages/scheduling/private.svg")
            Me.svgImageCollection1.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg")
            Me.svgImageCollection1.Add("pie", "image://svgimages/spreadsheet/pie.svg")
            Me.svgImageCollection1.Add("task", "image://svgimages/outlook inspired/task.svg")
            Me.svgImageCollection1.Add("editquery", "image://svgimages/dashboards/editquery.svg")
            ' 
            ' BaseControl
            ' 
            Me.Name = "BaseControl"
            Me.Size = New System.Drawing.Size(276, 156)
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private components As System.ComponentModel.IContainer

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace

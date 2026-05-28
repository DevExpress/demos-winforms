Namespace DevExpress.XtraEditors.Demos

    Partial Class TabbedViewControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentProperties.AllowClose = False
            Me.tabbedView1.DocumentProperties.AllowFloat = False
            Me.tabbedView1.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.tabbedView1.DocumentProperties.AllowTabReordering = False
            Me.tabbedView1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            ' 
            ' TabbedViewControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TabbedViewControl"
            Me.Size = New System.Drawing.Size(585, 396)
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Public tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Public documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    End Class
End Namespace

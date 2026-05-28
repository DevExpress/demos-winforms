Namespace DevExpress.XtraLayout.Demos.Modules

    Partial Class DragDropLayoutControl

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
            Me.dragDropLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType((Me.dragDropLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dragDropLayout
            ' 
            Me.dragDropLayout.AllowDrop = True
            Me.dragDropLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dragDropLayout.Location = New System.Drawing.Point(0, 0)
            Me.dragDropLayout.Name = "dragDropLayout"
            Me.dragDropLayout.Root = Me.layoutControlGroup2
            Me.dragDropLayout.Size = New System.Drawing.Size(362, 346)
            Me.dragDropLayout.TabIndex = 5
            Me.dragDropLayout.Text = "layoutControl2"
            AddHandler Me.dragDropLayout.DragDrop, New System.Windows.Forms.DragEventHandler(AddressOf Me.layoutControl2_DragDrop)
            AddHandler Me.dragDropLayout.DragEnter, New System.Windows.Forms.DragEventHandler(AddressOf Me.layoutControl2_DragEnter)
            AddHandler Me.dragDropLayout.DragOver, New System.Windows.Forms.DragEventHandler(AddressOf Me.layoutControl2_DragOver)
            AddHandler Me.dragDropLayout.DragLeave, New System.EventHandler(AddressOf Me.layoutControl2_DragLeave)
            AddHandler Me.dragDropLayout.GiveFeedback, New System.Windows.Forms.GiveFeedbackEventHandler(AddressOf Me.layoutControl2_GiveFeedback)
            AddHandler Me.dragDropLayout.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.layoutControl2_MouseDown)
            AddHandler Me.dragDropLayout.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.layoutControl2_MouseMove)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(362, 346)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' DragDropLayoutControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dragDropLayout)
            Me.Name = "DragDropLayoutControl"
            Me.Size = New System.Drawing.Size(362, 346)
            CType((Me.dragDropLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected Friend dragDropLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace

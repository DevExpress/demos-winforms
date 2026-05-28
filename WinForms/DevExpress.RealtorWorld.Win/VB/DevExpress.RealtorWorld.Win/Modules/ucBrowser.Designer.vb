Namespace DevExpress.RealtorWorld.Win

    Partial Class ucBrowser

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
            Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' webBrowser1
            ' 
            Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webBrowser1.IsWebBrowserContextMenuEnabled = False
            Me.webBrowser1.Location = New System.Drawing.Point(2, 2)
            Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser1.Name = "webBrowser1"
            Me.webBrowser1.ScriptErrorsSuppressed = True
            Me.webBrowser1.Size = New System.Drawing.Size(1176, 563)
            Me.webBrowser1.TabIndex = 0
            AddHandler Me.webBrowser1.Navigated, New System.Windows.Forms.WebBrowserNavigatedEventHandler(AddressOf Me.webBrowser1_Navigated)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.webBrowser1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1180, 567)
            Me.panelControl1.TabIndex = 1
            ' 
            ' ucBrowser
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ucBrowser"
            Me.Size = New System.Drawing.Size(1180, 567)
            Me.Tag = ""
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private webBrowser1 As System.Windows.Forms.WebBrowser

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

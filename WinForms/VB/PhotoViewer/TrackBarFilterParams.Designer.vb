Namespace PhotoViewer

    Partial Class TrackBarFilterParams

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
        Private Overloads Sub InitializeComponent()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            CType((Me.SimpleFilterParamsConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SimpleFilterParamsConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.applyButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.SimpleFilterParamsConvertedLayout.Controls.SetChildIndex(Me.applyFilterButton, 0)
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.trackBarControl1.EditValue = 500
            Me.trackBarControl1.Location = New System.Drawing.Point(104, 51)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.trackBarControl1.Properties.AllowFocused = False
            Me.trackBarControl1.Properties.AutoSize = False
            Me.trackBarControl1.Properties.Maximum = 1000
            Me.trackBarControl1.Properties.ShowValueToolTip = True
            Me.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            AddHandler Me.trackBarControl1.Properties.BeforeShowValueToolTip, New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(AddressOf Me.OnBeforeShowTrackBarValueToolTip)
            Me.trackBarControl1.Size = New System.Drawing.Size(216, 70)
            Me.trackBarControl1.TabIndex = 1
            Me.trackBarControl1.Value = 500
            AddHandler Me.trackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.trackBarControl1_EditValueChanged)
            ' 
            ' TrackBarFilterParams
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TrackBarFilterParams"
            CType((Me.SimpleFilterParamsConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.SimpleFilterParamsConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.applyButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
    End Class
End Namespace

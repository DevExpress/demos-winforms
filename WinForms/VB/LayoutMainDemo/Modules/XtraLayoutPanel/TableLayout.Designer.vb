Namespace DevExpress.XtraLayout.Demos

    Partial Class TableLayout

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
            Me.ceShowGrid = New DevExpress.XtraEditors.CheckEdit()
            Me.liShowGrid = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowGrid.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.Controls.Add(Me.ceShowGrid)
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(880, 335, 650, 400)
            Me.layoutControl.Controls.SetChildIndex(Me.ceShowGrid, 0)
            ' 
            ' liPropertyGrid
            ' 
            Me.liPropertyGrid.Size = New System.Drawing.Size(249, 303)
            ' 
            ' lcgOptions
            ' 
            Me.lcgOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liShowGrid})
            Me.lcgOptions.Location = New System.Drawing.Point(0, 194)
            Me.lcgOptions.Size = New System.Drawing.Size(249, 392)
            ' 
            ' lcgToolbox
            ' 
            Me.lcgToolbox.Size = New System.Drawing.Size(249, 194)
            ' 
            ' liResetLayout
            ' 
            Me.liResetLayout.Location = New System.Drawing.Point(0, 334)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 360)
            Me.emptySpaceItem.Size = New System.Drawing.Size(249, 10)
            ' 
            ' ceShowGrid
            ' 
            Me.ceShowGrid.Location = New System.Drawing.Point(12, 519)
            Me.ceShowGrid.Name = "ceShowGrid"
            Me.ceShowGrid.Properties.Caption = "Show Grid"
            Me.ceShowGrid.Size = New System.Drawing.Size(225, 20)
            Me.ceShowGrid.StyleController = Me.layoutControl
            Me.ceShowGrid.TabIndex = 6
            AddHandler Me.ceShowGrid.CheckedChanged, New System.EventHandler(AddressOf Me.OnShowGridCheckedChanged)
            ' 
            ' liShowGrid
            ' 
            Me.liShowGrid.Control = Me.ceShowGrid
            Me.liShowGrid.Location = New System.Drawing.Point(0, 303)
            Me.liShowGrid.Name = "liShowGrid"
            Me.liShowGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 11)
            Me.liShowGrid.Size = New System.Drawing.Size(249, 31)
            Me.liShowGrid.TextVisible = False
            ' 
            ' TableLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TableLayout"
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liPropertyGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgToolbox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liResetLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowGrid.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ceShowGrid As DevExpress.XtraEditors.CheckEdit

        Private liShowGrid As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

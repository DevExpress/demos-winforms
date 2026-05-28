Namespace DevExpress.XtraRichEdit.Demos

    Partial Class OperationRestrictionsModule

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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.edtReadOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtReadOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.propertyGridControl1)
            Me.panelControl1.Controls.Add(Me.edtReadOnly)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(393, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(298, 429)
            Me.panelControl1.TabIndex = 1
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.propertyGridControl1.Location = New System.Drawing.Point(6, 31)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl1.OptionsView.ShowRootCategories = False
            Me.propertyGridControl1.Size = New System.Drawing.Size(292, 398)
            Me.propertyGridControl1.TabIndex = 19
            AddHandler Me.propertyGridControl1.CellValueChanged, New DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(AddressOf Me.PropertyGridControl1_CellValueChanged)
            ' 
            ' edtReadOnly
            ' 
            Me.edtReadOnly.Location = New System.Drawing.Point(6, 6)
            Me.edtReadOnly.Name = "edtReadOnly"
            Me.edtReadOnly.Properties.Caption = "ReadOnly"
            Me.edtReadOnly.Size = New System.Drawing.Size(120, 20)
            Me.edtReadOnly.TabIndex = 18
            AddHandler Me.edtReadOnly.CheckedChanged, New System.EventHandler(AddressOf Me.edtReadOnly_CheckedChanged)
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(393, 429)
            Me.richEditControl.TabIndex = 2
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
            Me.separatorControl1.Location = New System.Drawing.Point(392, 0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(1, 429)
            Me.separatorControl1.TabIndex = 3
            ' 
            ' OperationRestrictionsModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.separatorControl1)
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "OperationRestrictionsModule"
            Me.Size = New System.Drawing.Size(691, 429)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtReadOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private edtReadOnly As DevExpress.XtraEditors.CheckEdit

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace

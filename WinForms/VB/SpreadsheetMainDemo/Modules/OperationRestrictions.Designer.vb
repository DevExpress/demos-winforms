Namespace DevExpress.XtraSpreadsheet.Demos

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
        Private Overloads Sub InitializeComponent()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.edtReadOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.edtReadOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Size = New System.Drawing.Size(788, 214)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 41)
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(1037, 150)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.edtReadOnly)
            Me.sidePanel1.Controls.Add(Me.propertyGridControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(788, 191)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(249, 214)
            Me.sidePanel1.TabIndex = 9
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' edtReadOnly
            ' 
            Me.edtReadOnly.Location = New System.Drawing.Point(8, 11)
            Me.edtReadOnly.Name = "edtReadOnly"
            Me.edtReadOnly.Properties.Caption = "ReadOnly"
            Me.edtReadOnly.Size = New System.Drawing.Size(120, 20)
            Me.edtReadOnly.TabIndex = 19
            AddHandler Me.edtReadOnly.CheckedChanged, New System.EventHandler(AddressOf Me.ReadOnly_CheckedChanged)
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.propertyGridControl1.Location = New System.Drawing.Point(10, 36)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl1.Size = New System.Drawing.Size(232, 168)
            Me.propertyGridControl1.TabIndex = 18
            ' 
            ' OperationRestrictionsModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "OperationRestrictionsModule"
            Me.Size = New System.Drawing.Size(1037, 432)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.edtReadOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private edtReadOnly As DevExpress.XtraEditors.CheckEdit

        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    End Class
End Namespace

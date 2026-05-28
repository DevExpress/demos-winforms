Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class AsyncLoadingTaskBased
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.lbLoadingPersons = New DevExpress.XtraEditors.LabelControl()
            Me.gclPersons = New DevExpress.XtraGrid.GridControl()
            Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.lbLoadingProducts = New DevExpress.XtraEditors.LabelControl()
            Me.gclProducts = New DevExpress.XtraGrid.GridControl()
            Me.gridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sbCommit = New DevExpress.XtraEditors.SimpleButton()
            Me.sbLoadData = New DevExpress.XtraEditors.SimpleButton()
            Me.lbCommit = New DevExpress.XtraEditors.LabelControl()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gclPersons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gclProducts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.lbLoadingPersons)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.gclPersons)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.lbLoadingProducts)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gclProducts)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(782, 475)
            Me.splitContainerControl1.SplitterPosition = 261
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'lbLoadingPersons
            '
            Me.lbLoadingPersons.Appearance.Options.UseTextOptions = True
            Me.lbLoadingPersons.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbLoadingPersons.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbLoadingPersons.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbLoadingPersons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbLoadingPersons.Location = New System.Drawing.Point(72, 205)
            Me.lbLoadingPersons.Name = "lbLoadingPersons"
            Me.lbLoadingPersons.Size = New System.Drawing.Size(209, 94)
            Me.lbLoadingPersons.TabIndex = 3
            Me.lbLoadingPersons.Text = "Loading..."
            Me.lbLoadingPersons.Visible = False
            '
            'gclPersons
            '
            Me.gclPersons.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclPersons.Location = New System.Drawing.Point(0, 0)
            Me.gclPersons.MainView = Me.gridView4
            Me.gclPersons.Name = "gclPersons"
            Me.gclPersons.Size = New System.Drawing.Size(261, 475)
            Me.gclPersons.TabIndex = 1
            Me.gclPersons.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView4})
            '
            'gridView4
            '
            Me.gridView4.DetailHeight = 268
            Me.gridView4.GridControl = Me.gclPersons
            Me.gridView4.Name = "gridView4"
            '
            'lbLoadingProducts
            '
            Me.lbLoadingProducts.Appearance.Options.UseTextOptions = True
            Me.lbLoadingProducts.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbLoadingProducts.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbLoadingProducts.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbLoadingProducts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbLoadingProducts.Location = New System.Drawing.Point(106, 205)
            Me.lbLoadingProducts.Name = "lbLoadingProducts"
            Me.lbLoadingProducts.Size = New System.Drawing.Size(209, 94)
            Me.lbLoadingProducts.TabIndex = 4
            Me.lbLoadingProducts.Text = "Loading..."
            Me.lbLoadingProducts.Visible = False
            '
            'gclProducts
            '
            Me.gclProducts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclProducts.Location = New System.Drawing.Point(0, 0)
            Me.gclProducts.MainView = Me.gridView5
            Me.gclProducts.Name = "gclProducts"
            Me.gclProducts.Size = New System.Drawing.Size(516, 475)
            Me.gclProducts.TabIndex = 2
            Me.gclProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView5})
            '
            'gridView5
            '
            Me.gridView5.DetailHeight = 268
            Me.gridView5.GridControl = Me.gclProducts
            Me.gridView5.Name = "gridView5"
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.sbCommit)
            Me.panelControl3.Controls.Add(Me.sbLoadData)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(0, 475)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(782, 35)
            Me.panelControl3.TabIndex = 3
            '
            'sbCommit
            '
            Me.sbCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbCommit.Enabled = False
            Me.sbCommit.Location = New System.Drawing.Point(621, 5)
            Me.sbCommit.Name = "sbCommit"
            Me.sbCommit.Size = New System.Drawing.Size(75, 23)
            Me.sbCommit.TabIndex = 2
            Me.sbCommit.Text = "Commit"
            '
            'sbLoadData
            '
            Me.sbLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbLoadData.Location = New System.Drawing.Point(702, 5)
            Me.sbLoadData.Name = "sbLoadData"
            Me.sbLoadData.Size = New System.Drawing.Size(75, 23)
            Me.sbLoadData.TabIndex = 0
            Me.sbLoadData.Text = "Load Data"
            '
            'lbCommit
            '
            Me.lbCommit.Appearance.Options.UseTextOptions = True
            Me.lbCommit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbCommit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbCommit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCommit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbCommit.Location = New System.Drawing.Point(287, 208)
            Me.lbCommit.Name = "lbCommit"
            Me.lbCommit.Size = New System.Drawing.Size(209, 94)
            Me.lbCommit.TabIndex = 5
            Me.lbCommit.Text = "Committing..."
            Me.lbCommit.Visible = False
            '
            'AsyncLoadingTaskBased
            '
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lbCommit)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelControl3)
            Me.Name = "AsyncLoadingTaskBased"
            Me.Size = New System.Drawing.Size(782, 510)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gclPersons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gclProducts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents gclPersons As DevExpress.XtraGrid.GridControl
        Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
        Private WithEvents gclProducts As DevExpress.XtraGrid.GridControl
        Private gridView5 As DevExpress.XtraGrid.Views.Grid.GridView
        Private lbLoadingPersons As DevExpress.XtraEditors.LabelControl
        Private lbLoadingProducts As DevExpress.XtraEditors.LabelControl
        Private panelControl3 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbLoadData As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbCommit As DevExpress.XtraEditors.SimpleButton
        Private lbCommit As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

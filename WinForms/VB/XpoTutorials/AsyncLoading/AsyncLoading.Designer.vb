Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class AsyncLoading
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
            Me.cbXpView = New System.Windows.Forms.CheckBox()
            Me.sbCommit = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddData = New DevExpress.XtraEditors.SimpleButton()
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
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.lbLoadingPersons)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.gclPersons)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.lbLoadingProducts)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gclProducts)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1043, 621)
            Me.splitContainerControl1.SplitterPosition = 348
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'lbLoadingPersons
            '
            Me.lbLoadingPersons.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbLoadingPersons.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbLoadingPersons.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbLoadingPersons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbLoadingPersons.Location = New System.Drawing.Point(96, 268)
            Me.lbLoadingPersons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.lbLoadingPersons.Name = "lbLoadingPersons"
            Me.lbLoadingPersons.Size = New System.Drawing.Size(279, 123)
            Me.lbLoadingPersons.TabIndex = 3
            Me.lbLoadingPersons.Text = "Loading..."
            Me.lbLoadingPersons.Visible = False
            '
            'gclPersons
            '
            Me.gclPersons.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclPersons.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclPersons.Location = New System.Drawing.Point(0, 0)
            Me.gclPersons.MainView = Me.gridView4
            Me.gclPersons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclPersons.Name = "gclPersons"
            Me.gclPersons.Size = New System.Drawing.Size(465, 621)
            Me.gclPersons.TabIndex = 1
            Me.gclPersons.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView4})
            '
            'gridView4
            '
            Me.gridView4.GridControl = Me.gclPersons
            Me.gridView4.Name = "gridView4"
            '
            'lbLoadingProducts
            '
            Me.lbLoadingProducts.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbLoadingProducts.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbLoadingProducts.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbLoadingProducts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbLoadingProducts.Location = New System.Drawing.Point(141, 268)
            Me.lbLoadingProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.lbLoadingProducts.Name = "lbLoadingProducts"
            Me.lbLoadingProducts.Size = New System.Drawing.Size(279, 123)
            Me.lbLoadingProducts.TabIndex = 4
            Me.lbLoadingProducts.Text = "Loading..."
            Me.lbLoadingProducts.Visible = False
            '
            'gclProducts
            '
            Me.gclProducts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gclProducts.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclProducts.Location = New System.Drawing.Point(0, 0)
            Me.gclProducts.MainView = Me.gridView5
            Me.gclProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gclProducts.Name = "gclProducts"
            Me.gclProducts.Size = New System.Drawing.Size(573, 621)
            Me.gclProducts.TabIndex = 2
            Me.gclProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView5})
            '
            'gridView5
            '
            Me.gridView5.GridControl = Me.gclProducts
            Me.gridView5.Name = "gridView5"
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.cbXpView)
            Me.panelControl3.Controls.Add(Me.sbCommit)
            Me.panelControl3.Controls.Add(Me.sbAddData)
            Me.panelControl3.Controls.Add(Me.sbLoadData)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(0, 621)
            Me.panelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(1043, 46)
            Me.panelControl3.TabIndex = 3
            '
            'cbXpView
            '
            Me.cbXpView.AutoSize = True
            Me.cbXpView.Location = New System.Drawing.Point(7, 12)
            Me.cbXpView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbXpView.Name = "cbXpView"
            Me.cbXpView.Size = New System.Drawing.Size(73, 21)
            Me.cbXpView.TabIndex = 3
            Me.cbXpView.Text = "XPView"
            Me.cbXpView.UseVisualStyleBackColor = True
            '
            'sbCommit
            '
            Me.sbCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbCommit.Enabled = False
            Me.sbCommit.Location = New System.Drawing.Point(828, 7)
            Me.sbCommit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.sbCommit.Name = "sbCommit"
            Me.sbCommit.Size = New System.Drawing.Size(100, 30)
            Me.sbCommit.TabIndex = 2
            Me.sbCommit.Text = "Commit"
            '
            'sbAddData
            '
            Me.sbAddData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbAddData.Enabled = False
            Me.sbAddData.Location = New System.Drawing.Point(644, 7)
            Me.sbAddData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.sbAddData.Name = "sbAddData"
            Me.sbAddData.Size = New System.Drawing.Size(176, 30)
            Me.sbAddData.TabIndex = 1
            Me.sbAddData.Text = "Add Data To DataStore"
            '
            'sbLoadData
            '
            Me.sbLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.sbLoadData.Location = New System.Drawing.Point(936, 7)
            Me.sbLoadData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.sbLoadData.Name = "sbLoadData"
            Me.sbLoadData.Size = New System.Drawing.Size(100, 30)
            Me.sbLoadData.TabIndex = 0
            Me.sbLoadData.Text = "Load Data"
            '
            'lbCommit
            '
            Me.lbCommit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbCommit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbCommit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCommit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbCommit.Location = New System.Drawing.Point(383, 272)
            Me.lbCommit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.lbCommit.Name = "lbCommit"
            Me.lbCommit.Size = New System.Drawing.Size(279, 123)
            Me.lbCommit.TabIndex = 5
            Me.lbCommit.Text = "Committing..."
            Me.lbCommit.Visible = False
            '
            'AsyncLoading
            '
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lbCommit)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelControl3)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "AsyncLoading"
            Me.Size = New System.Drawing.Size(1043, 667)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gclPersons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gclProducts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.panelControl3.PerformLayout()
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
        Private WithEvents sbAddData As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbLoadData As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbCommit As DevExpress.XtraEditors.SimpleButton
        Private lbCommit As DevExpress.XtraEditors.LabelControl
        Private cbXpView As System.Windows.Forms.CheckBox
    End Class
End Namespace

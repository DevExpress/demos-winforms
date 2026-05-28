Namespace DevExpress.AI.Demos

    Partial Class SmartSearchAIModule

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
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureEdit1
            ' 
            Me.tablePanel1.SetColumn(Me.pictureEdit1, 1)
            Me.pictureEdit1.EditValue = Global.DevExpress.AI.Demos.Properties.Resources.ai_smart_search
            Me.pictureEdit1.Location = New System.Drawing.Point(89, 125)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.tablePanel1.SetRow(Me.pictureEdit1, 2)
            Me.pictureEdit1.Size = New System.Drawing.Size(602, 202)
            Me.pictureEdit1.TabIndex = 6
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.tablePanel1.Controls.Add(Me.labelControl1)
            Me.tablePanel1.Controls.Add(Me.pictureEdit1)
            Me.tablePanel1.Location = New System.Drawing.Point(2, 65)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 2F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 6F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)})
            Me.tablePanel1.Size = New System.Drawing.Size(780, 365)
            Me.tablePanel1.TabIndex = 7
            Me.tablePanel1.UseSkinIndents = True
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Appearance.FontSizeDelta = 4
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.tablePanel1.SetColumn(Me.labelControl1, 1)
            Me.labelControl1.Location = New System.Drawing.Point(89, 37)
            Me.labelControl1.Name = "labelControl1"
            Me.tablePanel1.SetRow(Me.labelControl1, 1)
            Me.labelControl1.Size = New System.Drawing.Size(602, 84)
            Me.labelControl1.TabIndex = 7
            Me.labelControl1.Text = "<b>AI-powered Smart Search</b>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Leverage the potential of Artificial Intelligen" & "ce in your DevExpress-powered App." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use the search box in the form caption to se" & "e what’s possible."
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl1.Controls.Add(Me.tablePanel1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(831, 141, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(784, 432)
            Me.layoutControl1.TabIndex = 8
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(784, 63)
            Me.ucDisclaimerPanel1.TabIndex = 8
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(784, 432)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.tablePanel1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 63)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(784, 369)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ucDisclaimerPanel1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(784, 63)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' SmartSearchAIModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "SmartSearchAIModule"
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            Me.tablePanel1.PerformLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

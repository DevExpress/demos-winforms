Namespace DevExpress.MailClient.Win
    Partial Public Class LanguageSelectorForm
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(LanguageSelectorForm))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.hebrewSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.farsiSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.arabicSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.englishSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.hebrewSimpleButton)
            Me.layoutControl1.Controls.Add(Me.farsiSimpleButton)
            Me.layoutControl1.Controls.Add(Me.arabicSimpleButton)
            Me.layoutControl1.Controls.Add(Me.englishSimpleButton)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(415, 164, 585, 534)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(255, 332)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(28, 18)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(199, 75)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "DevExpress controls support RTL locales. Please select the language and locale yo" & "u want to use."
            ' 
            ' hebrewSimpleButton
            ' 
            Me.hebrewSimpleButton.Location = New System.Drawing.Point(48, 257)
            Me.hebrewSimpleButton.Name = "hebrewSimpleButton"
            Me.hebrewSimpleButton.Size = New System.Drawing.Size(159, 22)
            Me.hebrewSimpleButton.StyleController = Me.layoutControl1
            Me.hebrewSimpleButton.TabIndex = 7
            Me.hebrewSimpleButton.Text = "Hebrew"
            ' 
            ' farsiSimpleButton
            ' 
            Me.farsiSimpleButton.Location = New System.Drawing.Point(48, 189)
            Me.farsiSimpleButton.Name = "farsiSimpleButton"
            Me.farsiSimpleButton.Size = New System.Drawing.Size(159, 22)
            Me.farsiSimpleButton.StyleController = Me.layoutControl1
            Me.farsiSimpleButton.TabIndex = 6
            Me.farsiSimpleButton.Text = "Farsi"
            ' 
            ' arabicSimpleButton
            ' 
            Me.arabicSimpleButton.Location = New System.Drawing.Point(48, 223)
            Me.arabicSimpleButton.Name = "arabicSimpleButton"
            Me.arabicSimpleButton.Size = New System.Drawing.Size(159, 22)
            Me.arabicSimpleButton.StyleController = Me.layoutControl1
            Me.arabicSimpleButton.TabIndex = 5
            Me.arabicSimpleButton.Text = "Arabic"
            ' 
            ' englishSimpleButton
            ' 
            Me.englishSimpleButton.Location = New System.Drawing.Point(48, 125)
            Me.englishSimpleButton.Name = "englishSimpleButton"
            Me.englishSimpleButton.Size = New System.Drawing.Size(159, 22)
            Me.englishSimpleButton.StyleController = Me.layoutControl1
            Me.englishSimpleButton.TabIndex = 4
            Me.englishSimpleButton.Text = "English"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(255, 332)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.labelControl1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(67, 17)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(28, 28, 18, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(255, 95)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem4, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 95)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(50, 50, 9, 9)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(255, 237)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
            Me.layoutControlItem1.Control = Me.englishSimpleButton
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(48, 48, 12, 6)
            Me.layoutControlItem1.Size = New System.Drawing.Size(255, 58)
            Me.layoutControlItem1.Text = " Left to Right"
            Me.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(63, 13)
            Me.layoutControlItem1.TextToControlDistance = 5
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = True
            Me.layoutControlItem3.Control = Me.farsiSimpleButton
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(48, 48, 18, 6)
            Me.layoutControlItem3.Size = New System.Drawing.Size(255, 64)
            Me.layoutControlItem3.Text = " Right to Left"
            Me.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(63, 13)
            Me.layoutControlItem3.TextToControlDistance = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.arabicSimpleButton
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 122)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(48, 48, 6, 6)
            Me.layoutControlItem2.Size = New System.Drawing.Size(255, 34)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.hebrewSimpleButton
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 156)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(48, 48, 6, 6)
            Me.layoutControlItem4.Size = New System.Drawing.Size(255, 34)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 190)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(255, 47)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' LanguageSelectorForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(255, 332)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "LanguageSelectorForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Select Language"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As XtraLayout.LayoutControl
        Private WithEvents hebrewSimpleButton As XtraEditors.SimpleButton
        Private WithEvents farsiSimpleButton As XtraEditors.SimpleButton
        Private WithEvents arabicSimpleButton As XtraEditors.SimpleButton
        Private WithEvents englishSimpleButton As XtraEditors.SimpleButton
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private labelControl1 As XtraEditors.LabelControl
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
    End Class
End Namespace

Namespace DevExpress.DevAV

    Partial Class ContactsControl

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
            Me.settingsLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.btnIncludeContacts = New DevExpress.XtraEditors.CheckButton()
            Me.btnExcludeContacts = New DevExpress.XtraEditors.CheckButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsLayout.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsLayout.AllowCustomization = False
            Me.settingsLayout.Controls.Add(Me.btnIncludeContacts)
            Me.settingsLayout.Controls.Add(Me.btnExcludeContacts)
            Me.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsLayout.Location = New System.Drawing.Point(0, 0)
            Me.settingsLayout.Name = "settingsLayout"
            Me.settingsLayout.Root = Me.Root
            Me.settingsLayout.Size = New System.Drawing.Size(238, 232)
            Me.settingsLayout.TabIndex = 3
            Me.btnIncludeContacts.Checked = True
            Me.btnIncludeContacts.GroupIndex = 1
            Me.btnIncludeContacts.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnIncludeContacts.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintIncludeEvaluations.svg"
            Me.btnIncludeContacts.Location = New System.Drawing.Point(0, 0)
            Me.btnIncludeContacts.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnIncludeContacts.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnIncludeContacts.Name = "btnIncludeContacts"
            Me.btnIncludeContacts.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnIncludeContacts.Size = New System.Drawing.Size(238, 40)
            Me.btnIncludeContacts.StyleController = Me.settingsLayout
            Me.btnIncludeContacts.TabIndex = 2
            Me.btnIncludeContacts.Text = "Include Contacts"
            AddHandler Me.btnIncludeContacts.CheckedChanged, New System.EventHandler(AddressOf Me.btnIncludeContacts_CheckedChanged)
            Me.btnExcludeContacts.GroupIndex = 1
            Me.btnExcludeContacts.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnExcludeContacts.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintExcludeEvaluations.svg"
            Me.btnExcludeContacts.Location = New System.Drawing.Point(0, 40)
            Me.btnExcludeContacts.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnExcludeContacts.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnExcludeContacts.Name = "btnExcludeContacts"
            Me.btnExcludeContacts.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnExcludeContacts.Size = New System.Drawing.Size(238, 40)
            Me.btnExcludeContacts.StyleController = Me.settingsLayout
            Me.btnExcludeContacts.TabIndex = 2
            Me.btnExcludeContacts.TabStop = False
            Me.btnExcludeContacts.Text = "Exclude Contacts"
            AddHandler Me.btnExcludeContacts.CheckedChanged, New System.EventHandler(AddressOf Me.btnExcludeContacts_CheckedChanged)
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(238, 232)
            Me.layoutControlItem1.Control = Me.btnIncludeContacts
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(238, 40)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.btnExcludeContacts
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(238, 192)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.settingsLayout)
            Me.Name = "ContactsControl"
            Me.Size = New System.Drawing.Size(238, 232)
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsLayout.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private settingsLayout As DevExpress.XtraLayout.LayoutControl

        Private btnIncludeContacts As DevExpress.XtraEditors.CheckButton

        Private btnExcludeContacts As DevExpress.XtraEditors.CheckButton

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

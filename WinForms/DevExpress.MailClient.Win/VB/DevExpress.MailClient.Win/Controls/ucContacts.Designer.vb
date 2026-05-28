Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucContacts
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucContacts))
            Me.ceList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAlphabetical = New DevExpress.XtraEditors.CheckEdit()
            Me.ceState = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCards = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.pcCheckControls = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.ceList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAlphabetical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceCards.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pcCheckControls, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pcCheckControls.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ceList
            ' 
            resources.ApplyResources(Me.ceList, "ceList")
            Me.ceList.Name = "ceList"
            Me.ceList.Properties.AccessibleDescription = resources.GetString("ceList.Properties.AccessibleDescription")
            Me.ceList.Properties.AccessibleName = resources.GetString("ceList.Properties.AccessibleName")
            Me.ceList.Properties.AutoHeight = (DirectCast(resources.GetObject("ceList.Properties.AutoHeight"), Boolean))
            Me.ceList.Properties.AutoWidth = True
            Me.ceList.Properties.Caption = resources.GetString("ceList.Properties.Caption")
            Me.ceList.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceList.Properties.DisplayValueChecked = resources.GetString("ceList.Properties.DisplayValueChecked")
            Me.ceList.Properties.DisplayValueGrayed = resources.GetString("ceList.Properties.DisplayValueGrayed")
            Me.ceList.Properties.DisplayValueUnchecked = resources.GetString("ceList.Properties.DisplayValueUnchecked")
            Me.ceList.Properties.RadioGroupIndex = 0
            ' 
            ' ceAlphabetical
            ' 
            resources.ApplyResources(Me.ceAlphabetical, "ceAlphabetical")
            Me.ceAlphabetical.Name = "ceAlphabetical"
            Me.ceAlphabetical.Properties.AccessibleDescription = resources.GetString("ceAlphabetical.Properties.AccessibleDescription")
            Me.ceAlphabetical.Properties.AccessibleName = resources.GetString("ceAlphabetical.Properties.AccessibleName")
            Me.ceAlphabetical.Properties.AutoHeight = (DirectCast(resources.GetObject("ceAlphabetical.Properties.AutoHeight"), Boolean))
            Me.ceAlphabetical.Properties.AutoWidth = True
            Me.ceAlphabetical.Properties.Caption = resources.GetString("ceAlphabetical.Properties.Caption")
            Me.ceAlphabetical.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceAlphabetical.Properties.DisplayValueChecked = resources.GetString("ceAlphabetical.Properties.DisplayValueChecked")
            Me.ceAlphabetical.Properties.DisplayValueGrayed = resources.GetString("ceAlphabetical.Properties.DisplayValueGrayed")
            Me.ceAlphabetical.Properties.DisplayValueUnchecked = resources.GetString("ceAlphabetical.Properties.DisplayValueUnchecked")
            Me.ceAlphabetical.Properties.RadioGroupIndex = 0
            Me.ceAlphabetical.TabStop = False
            ' 
            ' ceState
            ' 
            resources.ApplyResources(Me.ceState, "ceState")
            Me.ceState.Name = "ceState"
            Me.ceState.Properties.AccessibleDescription = resources.GetString("ceState.Properties.AccessibleDescription")
            Me.ceState.Properties.AccessibleName = resources.GetString("ceState.Properties.AccessibleName")
            Me.ceState.Properties.AutoHeight = (DirectCast(resources.GetObject("ceState.Properties.AutoHeight"), Boolean))
            Me.ceState.Properties.AutoWidth = True
            Me.ceState.Properties.Caption = resources.GetString("ceState.Properties.Caption")
            Me.ceState.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceState.Properties.DisplayValueChecked = resources.GetString("ceState.Properties.DisplayValueChecked")
            Me.ceState.Properties.DisplayValueGrayed = resources.GetString("ceState.Properties.DisplayValueGrayed")
            Me.ceState.Properties.DisplayValueUnchecked = resources.GetString("ceState.Properties.DisplayValueUnchecked")
            Me.ceState.Properties.RadioGroupIndex = 0
            Me.ceState.TabStop = False
            ' 
            ' ceCards
            ' 
            resources.ApplyResources(Me.ceCards, "ceCards")
            Me.ceCards.Name = "ceCards"
            Me.ceCards.Properties.AccessibleDescription = resources.GetString("ceCards.Properties.AccessibleDescription")
            Me.ceCards.Properties.AccessibleName = resources.GetString("ceCards.Properties.AccessibleName")
            Me.ceCards.Properties.AutoHeight = (DirectCast(resources.GetObject("ceCards.Properties.AutoHeight"), Boolean))
            Me.ceCards.Properties.AutoWidth = True
            Me.ceCards.Properties.Caption = resources.GetString("ceCards.Properties.Caption")
            Me.ceCards.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.ceCards.Properties.DisplayValueChecked = resources.GetString("ceCards.Properties.DisplayValueChecked")
            Me.ceCards.Properties.DisplayValueGrayed = resources.GetString("ceCards.Properties.DisplayValueGrayed")
            Me.ceCards.Properties.DisplayValueUnchecked = resources.GetString("ceCards.Properties.DisplayValueUnchecked")
            Me.ceCards.Properties.RadioGroupIndex = 0
            Me.ceCards.TabStop = False
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' pcCheckControls
            ' 
            resources.ApplyResources(Me.pcCheckControls, "pcCheckControls")
            Me.pcCheckControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pcCheckControls.Controls.Add(Me.ceList)
            Me.pcCheckControls.Controls.Add(Me.labelControl1)
            Me.pcCheckControls.Controls.Add(Me.ceAlphabetical)
            Me.pcCheckControls.Controls.Add(Me.ceCards)
            Me.pcCheckControls.Controls.Add(Me.ceState)
            Me.pcCheckControls.Name = "pcCheckControls"
            ' 
            ' ucContacts
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pcCheckControls)
            Me.Name = "ucContacts"
            DirectCast(Me.ceList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAlphabetical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceCards.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pcCheckControls, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pcCheckControls.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents ceList As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAlphabetical As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceState As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceCards As DevExpress.XtraEditors.CheckEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private pcCheckControls As XtraEditors.PanelControl
    End Class
End Namespace

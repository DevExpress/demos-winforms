Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraPivotGrid.Demos

    Partial Class ConditionItem

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.propertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid()
            Me.label4 = New DevExpress.XtraEditors.LabelControl()
            Me.lbVal2 = New DevExpress.XtraEditors.LabelControl()
            Me.lbVal1 = New DevExpress.XtraEditors.LabelControl()
            Me.icbCondition = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.seValue1 = New DevExpress.XtraEditors.SpinEdit()
            Me.seValue2 = New DevExpress.XtraEditors.SpinEdit()
            Me.ceCell = New DevExpress.XtraEditors.CheckEdit()
            Me.ceTotalCell = New DevExpress.XtraEditors.CheckEdit()
            Me.ceGrandTotalCell = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCustomSummaryCell = New DevExpress.XtraEditors.CheckEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.icbCondition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seValue1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seValue2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCell.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceTotalCell.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceGrandTotalCell.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCustomSummaryCell.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' propertyGrid1
            ' 
            Me.propertyGrid1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.propertyGrid1.Location = New System.Drawing.Point(12, 168)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.ShowButtons = False
            Me.propertyGrid1.ShowCategories = False
            Me.propertyGrid1.ShowDescription = False
            Me.propertyGrid1.Size = New System.Drawing.Size(274, 192)
            Me.propertyGrid1.TabIndex = 8
            ' 
            ' label4
            ' 
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline)
            Me.label4.Location = New System.Drawing.Point(8, 148)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(92, 20)
            Me.label4.TabIndex = 12
            Me.label4.Text = "Appearance:"
            Me.label4.LineLocation = DevExpress.XtraEditors.LineLocation.Left
            '= System.Drawing.ContentAlignment.MiddleLeft;
            Me.label4.BackColor = System.Drawing.Color.Transparent
            ' 
            ' lbVal2
            ' 
            Me.lbVal2.Location = New System.Drawing.Point(8, 56)
            Me.lbVal2.Name = "lbVal2"
            Me.lbVal2.Size = New System.Drawing.Size(92, 20)
            Me.lbVal2.TabIndex = 10
            Me.lbVal2.Text = "Value 2:"
            Me.lbVal2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
            Me.lbVal2.BackColor = System.Drawing.Color.Transparent
            ' 
            ' lbVal1
            ' 
            Me.lbVal1.Location = New System.Drawing.Point(8, 32)
            Me.lbVal1.Name = "lbVal1"
            Me.lbVal1.Size = New System.Drawing.Size(92, 20)
            Me.lbVal1.TabIndex = 9
            Me.lbVal1.Text = "Value 1:"
            Me.lbVal1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
            Me.lbVal1.BackColor = System.Drawing.Color.Transparent
            ' 
            ' icbCondition
            ' 
            Me.icbCondition.EditValue = "imageComboBoxEdit1"
            Me.icbCondition.Location = New System.Drawing.Point(104, 8)
            Me.icbCondition.Name = "icbCondition"
            Me.icbCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbCondition.Properties.DropDownRows = 10
            Me.icbCondition.Size = New System.Drawing.Size(132, 20)
            Me.icbCondition.TabIndex = 0
            AddHandler Me.icbCondition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbCondition_SelectedIndexChanged)
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(8, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(92, 20)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Condition:"
            Me.label1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
            Me.label1.BackColor = System.Drawing.Color.Transparent
            ' 
            ' seValue1
            ' 
            Me.seValue1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seValue1.Location = New System.Drawing.Point(124, 32)
            Me.seValue1.Name = "seValue1"
            Me.seValue1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seValue1.Size = New System.Drawing.Size(112, 20)
            Me.seValue1.TabIndex = 1
            AddHandler Me.seValue1.EditValueChanged, New System.EventHandler(AddressOf Me.seValue1_EditValueChanged)
            ' 
            ' seValue2
            ' 
            Me.seValue2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seValue2.Location = New System.Drawing.Point(124, 56)
            Me.seValue2.Name = "seValue2"
            Me.seValue2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seValue2.Size = New System.Drawing.Size(112, 20)
            Me.seValue2.TabIndex = 2
            AddHandler Me.seValue2.EditValueChanged, New System.EventHandler(AddressOf Me.seValue2_EditValueChanged)
            ' 
            ' ceCell
            ' 
            Me.ceCell.Location = New System.Drawing.Point(8, 104)
            Me.ceCell.Name = "ceCell"
            Me.ceCell.Properties.Caption = "Cell"
            Me.ceCell.Size = New System.Drawing.Size(108, 19)
            Me.ceCell.TabIndex = 4
            AddHandler Me.ceCell.CheckedChanged, New System.EventHandler(AddressOf Me.ceCell_CheckedChanged)
            ' 
            ' ceTotalCell
            ' 
            Me.ceTotalCell.Location = New System.Drawing.Point(8, 124)
            Me.ceTotalCell.Name = "ceTotalCell"
            Me.ceTotalCell.Properties.Caption = "Total Cell"
            Me.ceTotalCell.Size = New System.Drawing.Size(108, 19)
            Me.ceTotalCell.TabIndex = 5
            AddHandler Me.ceTotalCell.CheckedChanged, New System.EventHandler(AddressOf Me.ceTotalCell_CheckedChanged)
            ' 
            ' ceGrandTotalCell
            ' 
            Me.ceGrandTotalCell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.ceGrandTotalCell.Location = New System.Drawing.Point(124, 104)
            Me.ceGrandTotalCell.Name = "ceGrandTotalCell"
            Me.ceGrandTotalCell.Properties.Caption = "Grand Total Cell"
            Me.ceGrandTotalCell.Size = New System.Drawing.Size(162, 19)
            Me.ceGrandTotalCell.TabIndex = 6
            AddHandler Me.ceGrandTotalCell.CheckedChanged, New System.EventHandler(AddressOf Me.ceGrandTotalCell_CheckedChanged)
            ' 
            ' ceCustomSummaryCell
            ' 
            Me.ceCustomSummaryCell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.ceCustomSummaryCell.Location = New System.Drawing.Point(124, 124)
            Me.ceCustomSummaryCell.Name = "ceCustomSummaryCell"
            Me.ceCustomSummaryCell.Properties.Caption = "Custom Total Cell"
            Me.ceCustomSummaryCell.Size = New System.Drawing.Size(162, 19)
            Me.ceCustomSummaryCell.TabIndex = 7
            AddHandler Me.ceCustomSummaryCell.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomSummaryCell_CheckedChanged)
            ' 
            ' label2
            ' 
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline)
            Me.label2.Location = New System.Drawing.Point(8, 80)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(92, 20)
            Me.label2.TabIndex = 18
            Me.label2.Text = "Apply To:"
            Me.label2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
            Me.label2.BackColor = System.Drawing.Color.Transparent
            ' 
            ' ConditionItem
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.ceCustomSummaryCell)
            Me.Controls.Add(Me.ceGrandTotalCell)
            Me.Controls.Add(Me.ceTotalCell)
            Me.Controls.Add(Me.ceCell)
            Me.Controls.Add(Me.seValue2)
            Me.Controls.Add(Me.seValue1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.lbVal2)
            Me.Controls.Add(Me.lbVal1)
            Me.Controls.Add(Me.icbCondition)
            Me.Controls.Add(Me.label1)
            Me.Name = "ConditionItem"
            Me.Size = New System.Drawing.Size(294, 368)
            CType((Me.icbCondition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seValue1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seValue2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCell.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceTotalCell.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceGrandTotalCell.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCustomSummaryCell.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private propertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid

        Private label4 As DevExpress.XtraEditors.LabelControl

        Private lbVal2 As DevExpress.XtraEditors.LabelControl

        Private lbVal1 As DevExpress.XtraEditors.LabelControl

        Private icbCondition As DevExpress.XtraEditors.ImageComboBoxEdit

        Private label1 As DevExpress.XtraEditors.LabelControl

        Private seValue1 As DevExpress.XtraEditors.SpinEdit

        Private seValue2 As DevExpress.XtraEditors.SpinEdit

        Private ceCell As DevExpress.XtraEditors.CheckEdit

        Private ceTotalCell As DevExpress.XtraEditors.CheckEdit

        Private ceGrandTotalCell As DevExpress.XtraEditors.CheckEdit

        Private ceCustomSummaryCell As DevExpress.XtraEditors.CheckEdit

        Private label2 As DevExpress.XtraEditors.LabelControl

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace

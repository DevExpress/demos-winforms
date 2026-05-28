Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class ucProperties

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
            Me.propertyGrid = New DevExpress.DXperience.Demos.XtraPropertyGrid()
            Me.comboBox = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            CType((Me.comboBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' propertyGrid
            ' 
            Me.tablePanel1.SetColumn(Me.propertyGrid, 0)
            Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid.Location = New System.Drawing.Point(0, 23)
            Me.propertyGrid.Margin = New System.Windows.Forms.Padding(0)
            Me.propertyGrid.Name = "propertyGrid"
            Me.tablePanel1.SetRow(Me.propertyGrid, 1)
            Me.propertyGrid.Size = New System.Drawing.Size(320, 415)
            Me.propertyGrid.TabIndex = 4
            ' 
            ' comboBox
            ' 
            Me.tablePanel1.SetColumn(Me.comboBox, 0)
            Me.comboBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBox.Location = New System.Drawing.Point(5, 3)
            Me.comboBox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 0)
            Me.comboBox.Name = "comboBox"
            Me.comboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.tablePanel1.SetRow(Me.comboBox, 0)
            Me.comboBox.Size = New System.Drawing.Size(310, 20)
            Me.comboBox.TabIndex = 3
            AddHandler Me.comboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox_SelectedIndexChanged)
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)})
            Me.tablePanel1.Controls.Add(Me.comboBox)
            Me.tablePanel1.Controls.Add(Me.propertyGrid)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(3, 3)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.tablePanel1.Size = New System.Drawing.Size(320, 438)
            Me.tablePanel1.TabIndex = 5
            ' 
            ' ucProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ucProperties"
            Me.Padding = New System.Windows.Forms.Padding(3)
            Me.Size = New System.Drawing.Size(326, 444)
            CType((Me.comboBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private propertyGrid As DevExpress.DXperience.Demos.XtraPropertyGrid

        Private comboBox As DevExpress.XtraEditors.ComboBoxEdit

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel
    End Class
End Namespace

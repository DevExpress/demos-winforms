Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for Validation.
    ''' </summary>
    Public Partial Class Validation
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            gridControl1.ForceInitialize()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Validation"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Validation"
            End Get
        End Property

        Private appError As AppearanceDefault = New AppearanceDefault(Color.White, Color.LightCoral, Color.Empty, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)

        Protected Overrides ReadOnly Property PaintViews As PaintView()
            Get
                Return New PaintView() {New PaintView(gridView1, "Winter")}
            End Get
        End Property

#Region "Init"
        Private Sub Validation_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitNWindData()
            InitValidateControls()
        End Sub

        Private tblGrid As String = "Order Details"

        Private tblLookUp As String = "Products"

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            Return ds
        End Function

        Private Sub InitValidateControls()
            validationControl1.spinEdit1.EditValue = 10
            validationControl2.imageComboBoxEdit1.SelectedIndex = 4
            validationControl2.spinEdit1.EditValue = 40
            validationControl3.imageComboBoxEdit1.SelectedIndex = 1
            validationControl3.imageComboBoxEdit2.SelectedIndex = 2
            validationControl3.spinEdit2.EditValue = 0.2
        End Sub

#End Region
#Region "Validation rule"
        '<gridControl1>
        Private Sub gridView1_ValidatingEditor(ByVal sender As Object, ByVal e As XtraEditors.Controls.BaseContainerValidateEditorEventArgs)
            Dim reply As Object() = Nothing
            If Equals(gridView1.FocusedColumn.FieldName, "UnitPrice") Then reply = validationControl1.IsTrueCondition(e.Value)
            If Equals(gridView1.FocusedColumn.FieldName, "Quantity") Then reply = validationControl2.IsTrueCondition(e.Value)
            If Equals(gridView1.FocusedColumn.FieldName, "Discount") Then reply = validationControl3.IsTrueCondition(e.Value)
            If reply IsNot Nothing AndAlso Not CBool(reply(0)) Then
                e.ErrorText = reply(1).ToString()
                e.Valid = False
            End If
        End Sub

        ' ~Customize the appearance of invalid cells 
        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As Views.Grid.RowCellStyleEventArgs)
            If e.RowHandle = GridControl.AutoFilterRowHandle Then Return
            Dim val As Object = gridView1.GetRowCellValue(e.RowHandle, e.Column)
            If(Equals(e.Column.FieldName, "UnitPrice") AndAlso Not CBool(validationControl1.IsTrueCondition(val)(0))) OrElse (Equals(e.Column.FieldName, "Quantity") AndAlso Not CBool(validationControl2.IsTrueCondition(val)(0))) OrElse (Equals(e.Column.FieldName, "Discount") AndAlso Not CBool(validationControl3.IsTrueCondition(val)(0))) Then
                AppearanceHelper.Apply(e.Appearance, appError)
            End If
        End Sub

        Private Sub validationControl_ValidateCondition(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.LayoutChanged()
        End Sub

        Private Sub gridView1_ValidateRow(ByVal sender As Object, ByVal e As Views.Base.ValidateRowEventArgs)
            Dim val As Single = Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn3)) * Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, gridColumn4)) * (1 - Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn5))) 'Total Sum
            If val < 0 Then
                e.ErrorText = String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf, Properties.Resources.SubTotalGreaterEqual)
                e.Valid = False
            End If
        End Sub

        '</gridControl1>
#End Region
#Region "Edit errorValue style"
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using frm As XtraEditors.XtraForm = New XtraEditors.XtraForm()
                frm.FormBorderStyle = FormBorderStyle.SizableToolWindow
                frm.StartPosition = FormStartPosition.Manual
                frm.Text = Properties.Resources.EditStyle
                frm.Location = PointToScreen(New Point(simpleButton1.Left + simpleButton1.Width \ 2, simpleButton1.Top + simpleButton1.Height \ 2))
                Dim grid As DXperience.Demos.XtraPropertyGrid = New DXperience.Demos.XtraPropertyGrid()
                grid.ShowDescription = False
                grid.ShowCategories = False
                grid.PropertyGrid.SelectedObject = appError
                AddHandler grid.PropertyGrid.CellValueChanged, New XtraVerticalGrid.Events.CellValueChangedEventHandler(AddressOf propertyValueChanged)
                grid.Dock = DockStyle.Fill
                frm.Controls.Add(grid)
                frm.ShowDialog()
            End Using
        End Sub

        Private Sub propertyValueChanged(ByVal sender As Object, ByVal e As XtraVerticalGrid.Events.CellValueChangedEventArgs)
            gridView1.LayoutChanged()
        End Sub

#End Region
        Protected Overrides Sub OnVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Visible Then
                gridView1.HideEditor()
                gridView1.CancelUpdateCurrentRow()
            End If

            MyBase.OnVisibleChanged(sender, e)
        End Sub
    End Class
End Namespace

Imports System
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for FixedColumns.
    ''' </summary>
    Public Partial Class FixedColumns
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            InitEditing()
            InitColumns()
            InitFixedStyle()
            InitGridFixedColumnHighlightMode()
            gridView1.OptionsPrint.PrintFixedColumnsOnEveryPage = True 'TODO
            colCountry.Fixed = FixedStyle.MiddleLeft
            colAddress.Fixed = FixedStyle.MiddleLeft
            icbFixedColumnHighlightMode.EditValue = CurrentGridView.OptionsView.FixedColumnHighlightMode
            UpdateFixedLineWidth()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"FixedColumns"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "FixedColumns"
            End Get
        End Property

#Region "Init"
        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private ReadOnly Property CurrentGridView As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            dataSet.ReadXml(dataFileName)
            gridControl2.DataSource = dataSet.Tables("Customers")
            Return dataSet
        End Function

        Private Sub InitEditing()
            numFixedLineWidth1.Value = CurrentGridView.FixedLineWidth
        End Sub

        Private Sub FixedColumns_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl2.ForceInitialize()
            CurrentGridView.ExpandAllGroups()
        '<gridControl2>
        ' 
        ' ~The following properties are specified at design-time and listed here for demonstration purposes
        ' 
        ' colCompanyName.Fixed = FixedStyle.Left;
        ' 
        '</gridControl2>
        End Sub

        Private Sub InitColumns()
            icbColumn.Properties.SmallImages = gridView1.Images
            icbColumn.Properties.Sorted = True
            For Each col As GridColumn In gridView1.Columns
                If col.Visible Then icbColumn.Properties.Items.Add(New ImageComboBoxItem(col.GetTextCaption(), col, col.ImageIndex))
            Next

            icbColumn.EditValue = colCompanyName
        End Sub

        Private Sub InitFixedStyle()
            For Each style As FixedStyle In [Enum].GetValues(GetType(FixedStyle))
                icbFixedStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FixedStyle).GetTitle(style), style, -1))
            Next
        End Sub

        Private Sub InitGridFixedColumnHighlightMode()
            For Each mode As GridFixedColumnHighlightMode In [Enum].GetValues(GetType(GridFixedColumnHighlightMode))
                If mode <> GridFixedColumnHighlightMode.Default Then icbFixedColumnHighlightMode.Properties.Items.Add(New ImageComboBoxItem(mode.ToString(), mode, -1))
            Next
        End Sub

#End Region
#Region "Editing"
        '<numFixedLineWidth1>
        Private Sub numFixedLineWidth1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CurrentGridView.FixedLineWidth = CInt(numFixedLineWidth1.Value)
        End Sub

        '</numFixedLineWidth1>
#End Region
#Region "Grid events"
        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.MenuType = GridMenuType.Column Then
                Dim menu As Menu.GridViewColumnMenu = TryCast(e.Menu, Menu.GridViewColumnMenu)
                If menu.Column IsNot Nothing Then
                    menu.Items.Clear()
                    menu.Items.Add(CreateCheckItem(Properties.Resources.NotFixed, menu.Column, FixedStyle.None, svgImageCollection1("NotFixed")))
                    menu.Items.Add(CreateCheckItem(Properties.Resources.FixedLeft, menu.Column, FixedStyle.Left, svgImageCollection1("FixedLeft")))
                    menu.Items.Add(CreateCheckItem(Properties.Resources.FixedRight, menu.Column, FixedStyle.Right, svgImageCollection1("FixedRight")))
                    menu.Items.Add(CreateCheckItem(Properties.Resources.MiddleLeft, menu.Column, FixedStyle.MiddleLeft, svgImageCollection1("FixedLeft")))
                End If
            End If
        End Sub

#End Region
#Region "New column menu"
        Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal style As FixedStyle, ByVal image As SvgImage) As DXMenuCheckItem
            Dim item As DXMenuCheckItem = New DXMenuCheckItem(caption, column.Fixed = style, Nothing, New EventHandler(AddressOf OnFixedClick))
            item.ImageOptions.SvgImage = image
            item.ImageOptions.SvgImageSize = svgImageCollection1.ImageSize
            item.Tag = New MenuInfo(column, style)
            Return item
        End Function

        Private Sub OnFixedClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim info As MenuInfo = TryCast(item.Tag, MenuInfo)
            If info Is Nothing Then Return
            info.Column.Fixed = info.Style
            UpdateColumnFixed()
            UpdateFixedLineWidth()
        End Sub

        Private Class MenuInfo

            Public Sub New(ByVal column As GridColumn, ByVal style As FixedStyle)
                Me.Column = column
                Me.Style = style
            End Sub

            Public Style As FixedStyle

            Public Column As GridColumn
        End Class

#End Region
        Private Sub icbColumn_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColumnFixed()
        End Sub

        Private Sub UpdateColumnFixed()
            Dim col As GridColumn = TryCast(icbColumn.EditValue, GridColumn)
            If col Is Nothing Then Return
            icbFixedStyle.EditValue = col.Fixed
        End Sub

        '<icbFixedStyle>
        Private Sub icbFixedStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim col As GridColumn = TryCast(icbColumn.EditValue, GridColumn)
            If col Is Nothing Then Return
            col.Fixed = CType(icbFixedStyle.EditValue, FixedStyle)
        End Sub

        '</icbFixedStyle>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

#End Region
        Private Sub icbFixedColumnHighlightMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            If edit Is Nothing Then Return
            CurrentGridView.OptionsView.FixedColumnHighlightMode = CType(edit.EditValue, GridFixedColumnHighlightMode)
            UpdateFixedLineWidth()
        End Sub

        Private Sub UpdateFixedLineWidth()
            lciFixedLineWidth.Enabled = CurrentGridView.OptionsView.FixedColumnHighlightMode = GridFixedColumnHighlightMode.Line AndAlso Not IsMiddleFixedExist
            icbFixedColumnHighlightMode.Enabled = Not IsMiddleFixedExist
            sbMiddleColumns.Text = MiddleColumnCaption
        End Sub

        Private ReadOnly Property MiddleColumnCaption As String
            Get
                Return String.Concat(If(IsMiddleFixedExist, "Clear", "Apply"), " 'Fixed Left (Dynamic)' Style")
            End Get
        End Property

        Private ReadOnly Property IsMiddleFixedExist As Boolean
            Get
                For Each col As GridColumn In CurrentGridView.Columns
                    If col.Fixed = FixedStyle.MiddleLeft Then Return True
                Next

                Return False
            End Get
        End Property

        Private Sub sbMiddleColumns_Click(ByVal sender As Object, ByVal e As EventArgs)
            If IsMiddleFixedExist Then
                For Each col As GridColumn In CurrentGridView.Columns
                    If col.Fixed = FixedStyle.MiddleLeft Then col.Fixed = FixedStyle.None
                Next
            Else
                colCountry.Fixed = FixedStyle.MiddleLeft
                colAddress.Fixed = FixedStyle.MiddleLeft
            End If

            UpdateFixedLineWidth()
        End Sub
    End Class
End Namespace

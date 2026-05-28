Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Demos.VehiclesData

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for ViewStyles.
    ''' </summary>
    Public Partial Class ViewStyles
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            gridControl1.ForceInitialize()
            InitVehiclesData()
            rgViewType.SelectedIndex = 3
            AddHandler rgViewType.SelectedIndexChanged, AddressOf OnSelectedIndexChanged
            SetToolTipController(Me, gridControl1)
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ViewStyles"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ViewStyles"
            End Get
        End Property

#Region "Init"
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            VehiclesData.InitXMLData(dataFileName, gridControl1)
            InitColumnViewEditors(advBandedGridView1)
            InitColumnViewEditors(bandedGridView1)
            InitColumnViewEditors(gridView1)
            InitColumnViewEditors(cardView1)
        End Sub

#End Region
#Region "Change view"
        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridControl1.MainView
            End Get
        End Property

        Public Overrides ReadOnly Property AllowCellImagesExport As Boolean
            Get
                Return True
            End Get
        End Property

        '<rgViewType>
        Private Sub ChangeView(ByVal viewType As String)
            Select Case viewType
                Case "GridView"
                    gridControl1.MainView = gridView1
                Case "CardView"
                    gridControl1.MainView = cardView1
                Case "Banded GridView"
                    gridControl1.MainView = bandedGridView1
                    bandedGridView1.ExpandAllGroups()
                Case "Advanced Banded GridView"
                    gridControl1.MainView = advBandedGridView1
            End Select
        End Sub

        '</rgViewType>
#End Region
#Region "GridView events"
        Private Sub gridView1_DragObjectOver(ByVal sender As Object, ByVal e As DragObjectOverEventArgs)
            If TypeOf e.DragObject Is GridColumn Then
                Dim cpi As Dragging.ColumnPositionInfo = TryCast(e.DropInfo, Dragging.ColumnPositionInfo)
                If e.DropInfo.Index = 0 AndAlso Not cpi.InGroupPanel Then e.DropInfo.Valid = False
            End If
        End Sub

#End Region
        Private updateInfo As Boolean = False

        '<rgViewType>
        Private Sub OnSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateInfo Then Return
            updateInfo = True
            Dim _caption As String = rgViewType.EditValue.ToString()
            ChangeView(_caption)
            updateInfo = False
        End Sub

        '</rgViewType>
#Region "CardView events"
        Private Sub cardView1_CustomCardCaptionImage(ByVal sender As Object, ByVal e As Views.Card.CardCaptionImageEventArgs)
            Dim model As Model = TryCast(cardView1.GetRow(e.RowHandle), Model)
            e.Image = model.GetSmallTrademarkImage()
        End Sub

        Private Sub cardView1_ValidatingEditor(ByVal sender As Object, ByVal e As XtraEditors.Controls.BaseContainerValidateEditorEventArgs)
            If Equals(cardView1.FocusedColumn.FieldName, "Trademark") Then BeginInvoke(New MethodInvoker(Sub() cardView1.LayoutChanged()))
        End Sub
#End Region
    End Class
End Namespace

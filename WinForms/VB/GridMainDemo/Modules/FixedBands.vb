Imports System
Imports System.Data
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class FixedBands
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            gridControl1.ForceInitialize()
            gridControl2.ForceInitialize()
            FillDataSetWithData()
            InitEditing()
            InitBands()
            InitFixedStyle()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"FixedBands"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "FixedBands"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                If xtraTabControl1.SelectedTabPageIndex = 0 Then Return bandedGridView1
                Return bandedGridView2
            End Get
        End Property

        Private Sub FillDataSetWithData()
            Const YearsCount As Integer = 9
            Const ModelCount As Integer = 20
            Dim ModuleNames As String() = New String() {"Chrysler", "Dodge", "Plymouth", "Ford", "Mercury", "Buick", "Cadillac", "Chevrolet", "Oldsmobile", "Pontiac", "Saturn", "Toyota Cavalier", "EV1", "Mazda", "BMW", "Honda", "Mitsubishi", "Nissan", "Subaru", "Toyota"}
            Dim CarProductionData As Integer(,) = New Integer(,) {{132155, 84189, 75104, 120864, 55852, 41814, 45800, 49532, 86432}, {285186, 258680, 330007, 313281, 303831, 236880, 239497, 279121, 321319}, {145254, 169717, 172509, 119659, 190607, 164260, 136874, 124977, 52748}, {996614, 1118788, 1329567, 1106175, 939905, 996300, 960420, 943098, 964880}, {432321, 470985, 464539, 351663, 371702, 400808, 351482, 318321, 288466}, {401788, 433977, 526446, 388949, 325411, 288322, 223764, 229007, 195857}, {208798, 207337, 220692, 177937, 163872, 174709, 167530, 142838, 173306}, {664253, 721183, 657402, 605347, 529933, 709334, 517030, 668193, 541080}, {377049, 405496, 487333, 417432, 292801, 296579, 263887, 282608, 246217}, {615182, 502841, 653874, 622519, 579364, 657030, 519354, 597615, 611748}, {193656, 280406, 277192, 324835, 312461, 253285, 263933, 267002, 286984}, {0, 0, 0, 1949, 10964, 11499, 4645, 9837, 1144}, {0, 0, 0, 0, 0, 0, 0, 329, 0}, {183648, 201746, 265527, 162281, 124196, 105580, 155515, 177330, 116151}, {0, 0, 0, 12166, 53120, 63668, 54115, 48150, 40420}, {496834, 393621, 473790, 552359, 695859, 664968, 707314, 709096, 712122}, {148733, 129336, 186472, 237403, 195842, 170293, 170100, 154661, 210053}, {170758, 283968, 317610, 321226, 282898, 302273, 236775, 182360, 163058}, {53838, 48036, 48949, 87610, 88903, 107018, 104630, 93458, 114998}, {370956, 343831, 433744, 566859, 595104, 599394, 562283, 548336, 582986}}
            For i As Integer = 0 To ModelCount - 1
                Dim newRow As DataRow = dataTable.NewRow()
                newRow(dcMaker) = ModuleNames(i)
                For year As Integer = 0 To YearsCount - 1
                    newRow(year + 1) = CarProductionData(i, year)
                Next

                dataTable.Rows.Add(newRow)
            Next

            gcTotal.Expression = "Year1992+Year1993+Year1994+Year1995+Year1996+Year1997+Year1998+Year1999+Year2000"
            InitCustomersPaymentData(dsContacts1)
        End Sub

        Private Sub InitEditing()
            For Each mode As GroupFooterShowMode In [Enum].GetValues(GetType(GroupFooterShowMode))
                cbShowMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GroupFooterShowMode).GetTitle(mode), mode, -1))
            Next

            cbShowMode.EditValue = bandedGridView2.OptionsView.GroupFooterShowMode
            numFixedLineWidth.Value = bandedGridView2.FixedLineWidth
        End Sub

        Private Sub InitFixedStyle()
            For Each style As FixedStyle In [Enum].GetValues(GetType(FixedStyle))
                icbFixedStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FixedStyle).GetTitle(style), style, -1))
            Next
        End Sub

        Private Sub InitBands()
            icbBand.Properties.SmallImages = bandedGridView1.Images
            icbBand.Properties.Sorted = True
            For Each band As GridBand In bandedGridView1.Bands
                If band.Visible Then icbBand.Properties.Items.Add(New ImageComboBoxItem(band.GetTextCaption(), band, band.ImageIndex))
            Next

            icbBand.EditValue = gbManufacture
        End Sub

        Private Sub FixedBands_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl2.ForceInitialize()
            bandedGridView2.ExpandAllGroups()
        '<gridControl1>
        ' 
        ' ~The following properties are specified at design-time and listed here for demonstration purposes
        ' 
        ' gridBand1.Fixed = Columns.FixedStyle.Left;
        ' gridBand2.Fixed = Columns.FixedStyle.None;
        ' gridBand3.Fixed = Columns.FixedStyle.Right;
        ' 
        '</gridControl1>
        End Sub

        '<numFixedLineWidth>
        Private Sub numFixedLineWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            bandedGridView2.FixedLineWidth = CInt(numFixedLineWidth.Value)
        End Sub

        '</numFixedLineWidth>
        '<cbShowMode>
        Private Sub cbShowMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If cbShowMode.SelectedItem IsNot Nothing Then bandedGridView2.OptionsView.GroupFooterShowMode = CType(cbShowMode.EditValue, GroupFooterShowMode)
        End Sub

        '</cbShowMode>
        Private Sub bandedGridView2_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs)
            If e.Column.FieldName.IndexOf("Row") <> -1 Then e.Appearance.Font = New Font("Arial", 8, FontStyle.Bold)
        End Sub

        Private Sub icbBand_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim band As GridBand = TryCast(icbBand.EditValue, GridBand)
            If band Is Nothing Then Return
            icbFixedStyle.EditValue = band.Fixed
            icbFixedStyle.Enabled = band IsNot gbYear
        End Sub

        '<icbFixedStyle>
        Private Sub icbFixedStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim band As GridBand = TryCast(icbBand.EditValue, GridBand)
            If band Is Nothing Then Return
            band.Fixed = CType(icbFixedStyle.EditValue, FixedStyle)
        End Sub
    '</icbFixedStyle>
    End Class
End Namespace

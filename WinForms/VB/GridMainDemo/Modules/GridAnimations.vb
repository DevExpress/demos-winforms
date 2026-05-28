Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Imaging
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for GridAnimations.
    ''' </summary>
    Public Partial Class GridAnimations
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GridAnimations"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GridAnimations"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private Sub GridAnimations_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = OutlookData.CreateDataTable(4)
            gridView1.ExpandAllGroups()
            For Each mode As GridAnimationType In [Enum].GetValues(GetType(GridAnimationType))
                icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GridAnimationType).GetTitle(mode), mode, -1))
            Next

            icbAnimation.EditValue = gridView1.OptionsView.AnimationType
            OnStyleChanged()
        End Sub

        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs)
            Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
            If info Is Nothing Then Return
            info.GroupText = info.GroupText.Replace("1 " & Properties.Resources.Items, "1 " & Properties.Resources.Item)
        End Sub

        Private ht As Hashtable = New Hashtable()

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.IsGetData Then
                Dim row As DataRow = CType(e.Row, DataRowView).Row
                Dim key As Integer = CInt(row("Priority"))
                If key <> 1 Then
                    If Not ht.ContainsKey(key) Then ht.Add(key, GetImage(key))
                    e.Value = ht(key)
                End If
            End If
        End Sub

        Private Function GetImage(ByVal key As Integer) As Byte()
            Dim img As Image = Utils.ResourceImageHelperCore.CreateImageFromResourcesEx(String.Format("DevExpress.XtraGrid.Demos.Images.{0}.gif", GetPictureName(key)), GetType(GridAnimations).Assembly)
            Return ByteImageConverter.ToByteArray(img, ImageFormat.Gif)
        End Function

        Private Function GetPictureName(ByVal key As Integer) As String
            If key = 0 Then
                Return "low"
            Else
                Return "high"
            End If
        End Function

        Private Sub gridView1_ShowFilterPopupListBox(ByVal sender As Object, ByVal e As FilterPopupListBoxEventArgs)
            If e.Column IsNot colPriority Then Return
            For i As Integer = e.ComboBox.Items.Count - 1 To 0 Step -1
                Dim item As FilterItem = TryCast(e.ComboBox.Items(i), FilterItem)
                If item Is Nothing Then Continue For
                If Equals(item.Text, GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom)) Then e.ComboBox.Items.RemoveAt(i)
            Next

            e.ComboBox.Items.Add(New FilterItem(Properties.Resources.LowPriority, New ColumnFilterInfo("[Priority] = 0", Properties.Resources.LowPriority)))
            e.ComboBox.Items.Add(New FilterItem(Properties.Resources.HighPriority, New ColumnFilterInfo("[Priority] = 2", Properties.Resources.HighPriority)))
        End Sub

        '<icbAnimation>
        Private Sub icbAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsView.AnimationType = CType(icbAnimation.EditValue, GridAnimationType)
        End Sub

        '</icbAnimation>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace

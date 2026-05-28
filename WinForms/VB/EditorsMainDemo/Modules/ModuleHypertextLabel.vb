Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleHypertextLabel
        Inherits TutorialControl

#Region "HTMLPatterns"
        Const DefaultHtmlPattern As String = "
<size=+4><href={0}>R{0}</href> <image={1}></size>

<font='Times New Roman' color=green size=+2><b>{2}</b><sup><href=mailto:{4}>[1]</href></sup>
<i><color=@DisabledText>{3}</i></font>

<size=+3></size>
{6}
{7}
 "

        Const CompactHTMLPattern As String = "
<size=+2><image={1}> <href={0}>R{0}</href> - <i><color=@DisabledText>{3}</i></color></size>

<b>{5}<sup><href=mailto:{4}>[1]</href></sup></b> - {7} , {6}
 "

        Const LargeHTMLPattern As String = "
<size=+10>Invoice: <href={0}>R{0}</href> <image={1}></size>
<size=+5><i><color=@DisabledText>{3}</color></i></size>

<size=+6>{5} - {2}</size>
<size=+4><href={4}>{4}</href></size>
<size=+3><i><color=@DisabledText>{6}
{7}</color></i></size>
 "

#End Region
        Private repositoryItemHypertextLabel As RepositoryItemHypertextLabel

        Private CurrentDefaultHTMLPattern As String = DefaultHtmlPattern

        Public HTMLPattern As String = DefaultHtmlPattern

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            invoiceBindingSource.DataSource = GetData()
            repositoryItemHypertextLabel = New RepositoryItemHypertextLabel()
            repositoryItemHypertextLabel.Appearance.Options.UseTextOptions = True
            repositoryItemHypertextLabel.HtmlImages = svgImageCollection1
            AddHandler repositoryItemHypertextLabel.OpenHyperlink, AddressOf RepositoryItemHypertextLabel_OpenHyperlink
            colHtmlText.ColumnEdit = repositoryItemHypertextLabel
            gridControl1.RepositoryItems.Add(repositoryItemHypertextLabel)
            singleClickICB.Properties.Items.Add(New ImageComboBoxItem("True", True, -1))
            singleClickICB.Properties.Items.Add(New ImageComboBoxItem("False", False, -1))
            singleClickICB.DataBindings.Add("EditValue", repositoryItemHypertextLabel, "SingleClick", True, DataSourceUpdateMode.OnPropertyChanged)
            textAlignmentICB.Properties.Items.AddEnum(Of HorzAlignment)()
            textAlignmentICB.EditValue = repositoryItemHypertextLabel.Appearance.TextOptions.HAlignment
            memoEdit1.EditValue = HTMLPattern
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.Column Is colHtmlText AndAlso e.IsGetData Then
                Dim invoice As Invoice = TryCast(e.Row, Invoice)
                If invoice Is Nothing Then Return
                e.Value = String.Format(HTMLPattern, invoice.ID, If(invoice.Approve, "Approve", "Reject"), invoice.Manager, invoice.OrderDate.ToShortDateString(), invoice.Email, invoice.Company, invoice.AddressLine, invoice.CityLine)
            End If
        End Sub

        Private Sub htmlPatternLCG_CustomButtonClick(ByVal sender As Object, ByVal e As BaseButtonEventArgs)
            memoEdit1.EditValue = CurrentDefaultHTMLPattern
        End Sub

        Private Sub memoEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                String.Format(memoEdit1.Text, "", "", "", "", "", "", "", "", "")
            Catch
                Return
            End Try

            HTMLPattern = memoEdit1.Text
            gridControl1.RefreshDataSource()
            htmlPatternLCG.CustomHeaderButtons("Reset").Properties.Enabled = Not Equals(HTMLPattern, CurrentDefaultHTMLPattern)
        End Sub

        Private Sub RepositoryItemHypertextLabel_OpenHyperlink(ByVal sender As Object, ByVal e As OpenHyperlinkEventArgs)
            If e.Link.StartsWith("mailto") Then Return
            e.Handled = True
            XtraMessageBox.Show("Link ID - " & e.Link, "Invoice")
        End Sub

        Private Sub textAlignmentICB_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            repositoryItemHypertextLabel.Appearance.TextOptions.HAlignment = CType(textAlignmentICB.EditValue, HorzAlignment)
            colHtmlText.AppearanceCell.TextOptions.HAlignment = CType(textAlignmentICB.EditValue, HorzAlignment)
        End Sub

#Region "Data"
        Public Shared Function GetData() As BindingList(Of Invoice)
            Dim bindingList As BindingList(Of Invoice) = New BindingList(Of Invoice)()
            bindingList.Add(New Invoice() With {.ID = 238912, .Manager = "John Smith", .OrderDate = TutorialConstants.Now - New TimeSpan(15, 4, 0, 0), .Company = "ElectrixMax", .AddressLine = "Naperville, IL 60563", .CityLine = "263 Shuman Blvd", .Email = "electrixmax@devav.com", .Approve = True})
            bindingList.Add(New Invoice() With {.ID = 240328, .Manager = "John Smith", .OrderDate = TutorialConstants.Now - New TimeSpan(10, 0, 0, 0), .Company = "Screen Shop", .AddressLine = "Mooresville, NC 28117", .CityLine = "1000 Lowes Blvd", .Email = "screenshop@devav.com", .Approve = True})
            bindingList.Add(New Invoice() With {.ID = 250237, .Manager = "Greta Sims", .OrderDate = TutorialConstants.Now - New TimeSpan(8, 6, 0, 0), .Company = "Zony Toys", .AddressLine = "Los Angeles, CA 90034", .CityLine = "1945 S Cienega Boulevard", .Email = "zonytoys@devav.com", .Approve = True})
            bindingList.Add(New Invoice() With {.ID = 240325, .Manager = "Greta Sims", .OrderDate = TutorialConstants.Now - New TimeSpan(4, 8, 0, 0), .Company = "Store of America", .AddressLine = "Seattle, WA 98134", .CityLine = "2401 Utah Ave. South", .Email = "storeofamerica@devav.com", .Approve = False})
            bindingList.Add(New Invoice() With {.ID = 243157, .Manager = "Greta Sims", .OrderDate = TutorialConstants.Now - New TimeSpan(1, 0, 0, 0), .Company = "Super Mart of the West", .AddressLine = "Bentonville, AR 72716", .CityLine = "702 SW 8th Street", .Email = "supermart@devav.com", .Approve = False})
            Return bindingList
        End Function

        Public Class Invoice

            Public Property AddressLine As String

            Public Property Approve As Boolean

            Public Property CityLine As String

            Public Property Company As String

            Public Property Email As String

            Public Property ID As Integer

            Public Property Manager As String

            Public Property OrderDate As Date
        End Class

#End Region
        Private Sub htmlPatternLCG_CustomButtonChecked(ByVal sender As Object, ByVal e As BaseButtonEventArgs)
            If Equals(e.Button.Properties.Caption, "Compact") Then CurrentDefaultHTMLPattern = CompactHTMLPattern
            If Equals(e.Button.Properties.Caption, "Default") Then CurrentDefaultHTMLPattern = DefaultHtmlPattern
            If Equals(e.Button.Properties.Caption, "Large") Then CurrentDefaultHTMLPattern = LargeHTMLPattern
            memoEdit1.EditValue = CurrentDefaultHTMLPattern
        End Sub
    End Class
End Namespace

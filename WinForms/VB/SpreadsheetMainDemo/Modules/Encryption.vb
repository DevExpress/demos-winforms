Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class EncryptionModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Private workbook As IWorkbook

        Public Sub New()
            InitializeComponent()
            InitializeWorkbook()
            InitializeEncryptionOptions()
            workbook.History.Clear()
        End Sub

        Protected Friend Overrides ReadOnly Property SelectedRibbonPage As RibbonPage
            Get
                Return fileRibbonPage1
            End Get
        End Property

        Private Sub InitializeWorkbook()
            workbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"))
        End Sub

        Private Sub InitializeEncryptionOptions()
            passwordEdit.Text = "test"
            For Each currentValue As EncryptionType In EnumHelper.GetValues(Of EncryptionType)()
                typeEdit.Properties.Items.Add(currentValue.ToString())
            Next

            typeEdit.SelectedItem = EncryptionType.Strong.ToString()
        End Sub

        Private Sub TypeEdit_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            workbook.DocumentSettings.Encryption.Type = CType([Enum].Parse(GetType(EncryptionType), typeEdit.Text), EncryptionType)
        End Sub

        Private Sub PasswordEdit_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            workbook.DocumentSettings.Encryption.Password = passwordEdit.Text
        End Sub

        Private Sub BtnExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As SaveFileDialog = New SaveFileDialog With {.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel Binary Workbook (*.xlsb)|*.xlsb|Excel 97-2003 Workbook (*.xls)|*.xls", .FileName = "Document.xlsx"}
            If dialog.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = dialog.FileName
                workbook.SaveDocument(fileName)
                If chbOpenResultingFile.Checked Then Data.Utils.SafeProcess.Start(fileName)
            End If
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheetControl1.Focus()
        End Sub
    End Class
End Namespace

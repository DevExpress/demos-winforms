Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class RowsCreator

        Private Shared Sub AddComboBoxItems(ByVal cb As RepositoryItemComboBox, ByVal s As String())
            For i As Integer = 0 To s.Length - 1
                cb.Items.Add(s(i))
            Next

            cb.TextEditStyle = TextEditStyles.DisableTextEditor
        End Sub

        Private Shared Sub CreateOpenFileButtonDialog(ByVal be As RepositoryItemButtonEdit)
            AddHandler be.ButtonClick, New ButtonPressedEventHandler(AddressOf button_click)
        End Sub

        Private Shared Sub button_click(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Executable Files|*.exe;*.com|All Files|*.*"
            If dlg.ShowDialog() = DialogResult.OK Then
                Dim be As ButtonEdit = TryCast(sender, ButtonEdit)
                be.Text = dlg.FileName
            End If
        End Sub

        Public Shared Sub CreateRows(ByVal vg As VGridControl, ByVal rows As Object())
            vg.CloseEditor()
            vg.Rows.Clear()
            vg.RepositoryItems.Clear()
            vg.RepositoryItems.Add(New RepositoryItemCheckEdit())
            vg.RepositoryItems.Add(New RepositoryItemSpinEdit())
            vg.RepositoryItems.Add(New RepositoryItemComboBox())
            vg.RepositoryItems.Add(New RepositoryItemComboBox())
            vg.RepositoryItems.Add(New RepositoryItemButtonEdit())
            CType(vg.RepositoryItems(1), RepositoryItemSpinEdit).IsFloatValue = False
            Call AddComboBoxItems(TryCast(vg.RepositoryItems(2), RepositoryItemComboBox), New String() {"Warning level 0", "Warning level 1", "Warning level 2", "Warning level 3", "Warning level 4"})
            Call AddComboBoxItems(TryCast(vg.RepositoryItems(3), RepositoryItemComboBox), New String() {"Project", "Program", "URL", "Wait to Attach to an External Process"})
            Call CreateOpenFileButtonDialog(TryCast(vg.RepositoryItems(4), RepositoryItemButtonEdit))
            For i As Integer = 0 To rows.Length - 1
                Dim name As String = CType(rows(i), Object())(0).ToString()
                Dim cRow As CategoryRow = New CategoryRow(name)
                Dim names As String() = TryCast(CType(rows(i), Object())(1), String())
                Dim editorInd As Integer() = TryCast(CType(rows(i), Object())(2), Integer())
                Dim values As Object() = TryCast(CType(rows(i), Object())(3), Object())
                Dim enabled As Boolean() = Nothing
                Try
                    enabled = TryCast(CType(rows(i), Object())(4), Boolean())
                Catch
                End Try

                For j As Integer = 0 To names.Length - 1
                    Dim eRow As EditorRow = New EditorRow()
                    eRow.Properties.Caption = names(j)
                    If editorInd(j) <> -1 Then
                        eRow.Properties.RowEdit = vg.RepositoryItems(editorInd(j))
                    End If

                    eRow.Properties.Value = values(j)
                    eRow.Tag = values(j)
                    If enabled IsNot Nothing Then
                        eRow.Enabled = CBool(enabled(j))
                    End If

                    cRow.ChildRows.Add(eRow)
                Next

                vg.Rows.Add(cRow)
            Next
        End Sub

        Public Shared Sub CreateRows(ByVal i As Integer, ByVal vg As VGridControl)
            If i = 0 Then CreateRows(vg, New Object() {New Object() {"Code Generation", New String() {"Conditional Compilation Constants", "Optimize code", "Check for Arithmetic Overflow/Underflow", "Allow unsafe code blocks"}, New Integer() {-1, 0, 0, 0}, New Object() {"DEBUG;TRACE", False, False, False}}, New Object() {"Errors and Warnings", New String() {"Warning Level", "Treat Warnings As Errors"}, New Integer() {2, 0}, New Object() {"Warning level 4", False}}, New Object() {"Outputs", New String() {"Output Path", "XML Documentation File", "Generate Debugging Information", "Register for COM interop"}, New Integer() {-1, -1, 0, 0}, New Object() {"bin\Debug\", "", True, False}, New Boolean() {True, True, True, False}}})
            If i = 1 Then CreateRows(vg, New Object() {New Object() {"Debuggers", New String() {"Enable ASP Debugging", "Enable ASP.Net Debugging", "Enable Unmanaged Debugging", "Enable SQL Debugging"}, New Integer() {0, 0, 0, 0}, New Object() {False, False, False, False}}, New Object() {"Start Action", New String() {"Debug Mode", "Start Application", "Start URL", "Start Page"}, New Integer() {3, 4, -1, -1}, New Object() {"Project", "", "", ""}}, New Object() {"Start Options", New String() {"Command Line Arguments", "Working Directory", "Always use Internet Explorer", "Enable remote debugging", "Remote debug machine"}, New Integer() {-1, -1, 0, 0, -1}, New Object() {"", "", False, True, ""}}})
            If i = 2 Then Call CreateRows(vg, New Object() {New Object() {"General", New String() {"Incremental build", "Base Address", "File Alignment"}, New Integer() {0, 1, 1}, New Object() {True, CDec(285212672), CDec(4096)}}})
        End Sub
    End Class
End Namespace

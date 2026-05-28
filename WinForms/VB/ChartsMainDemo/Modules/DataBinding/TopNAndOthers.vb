Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class TopNAndOthersDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property Options As TopNOptions
            Get
                Return If(ChartControl.Series.Count > 0, ChartControl.Series(0).TopNOptions, Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            BindChartToData()
        End Sub

        Private Sub comboBOxEditMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options Is Nothing Then Return
            Dim mode As TopNMode = CType(comboBoxEditMode.SelectedIndex, TopNMode)
            Options.Mode = mode
            layoutControlItemCount.Text = CStr(comboBoxEditMode.SelectedItem) & ":"
            spinEditCount.Properties.BeginInit()
            Select Case mode
                Case TopNMode.Count
                    spinEditCount.Properties.IsFloatValue = False
                    spinEditCount.Properties.MinValue = 1
                    spinEditCount.Properties.MaxValue = 20
                    spinEditCount.Properties.Increment = 1
                    spinEditCount.Properties.Mask.EditMask = "f0"
                    spinEditCount.EditValue = Options.Count
                Case TopNMode.ThresholdValue
                    spinEditCount.Properties.IsFloatValue = True
                    spinEditCount.Properties.MinValue = 2000
                    spinEditCount.Properties.MaxValue = 20000
                    spinEditCount.Properties.Increment = 500
                    spinEditCount.Properties.Mask.EditMask = "f0"
                    spinEditCount.EditValue = Options.ThresholdValue
                Case TopNMode.ThresholdPercent
                    spinEditCount.Properties.IsFloatValue = True
                    spinEditCount.Properties.MinValue = New Decimal(1.5)
                    spinEditCount.Properties.MaxValue = 100
                    spinEditCount.Properties.Increment = New Decimal(0.1)
                    spinEditCount.Properties.Mask.EditMask = "f1"
                    spinEditCount.EditValue = Options.ThresholdPercent
                Case Else
                    spinEditCount.Enabled = False
            End Select

            spinEditCount.Properties.EndInit()
        End Sub

        Private Sub checkEditCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options IsNot Nothing Then
                Select Case Options.Mode
                    Case TopNMode.Count
                        Options.Count = Convert.ToInt32(spinEditCount.EditValue)
                    Case TopNMode.ThresholdValue
                        Options.ThresholdValue = Convert.ToDouble(spinEditCount.EditValue)
                    Case TopNMode.ThresholdPercent
                        Options.ThresholdPercent = Convert.ToDouble(spinEditCount.EditValue)
                End Select
            End If
        End Sub

        Private Sub checkEditShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options Is Nothing Then Return
            Options.ShowOthers = checkEditShowOthers.Checked
            If Options.ShowOthers Then
                textEditOthersArgument.Enabled = True
                If String.IsNullOrEmpty(Options.OthersArgument) Then
                    textEditOthersArgument.EditValue = "Others"
                Else
                    textEditOthersArgument.EditValue = Options.OthersArgument
                End If
            Else
                textEditOthersArgument.Enabled = False
            End If
        End Sub

        Private Sub textEditOthersArgument_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Options IsNot Nothing Then Options.OthersArgument = CStr(textEditOthersArgument.EditValue)
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chart.Series.Count > 0 Then chart.Series(0).LabelsVisibility = CovertBoolToDefaultBoolean(checkEditLabelVisible.Checked)
        End Sub

        Private Sub BindChartToData()
            chart.DataSource = dS21.Countries
            Dim path As String = GetRelativePath("countriesDB.mdb")
            If path.Length > 0 Then
                SetConnectionString(oleDbConnection, path)
            Else
                XtraMessageBox.Show("The ""countriesDB.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                oleDbDataAdapter.Fill(dS21)
            Catch e As OleDbException
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Sub
    End Class
End Namespace

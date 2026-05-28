Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for GroupContainer.
    ''' </summary>
    Public Partial Class GroupContainer
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private Sub GroupContainer_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            radioButton1.Checked = True
            checkBox3.Checked = True
            checkBox1.Checked = checkBox3.Checked
            comboBox1.Properties.Items.AddRange(System.IO.Directory.GetLogicalDrives())
            If comboBox1.Properties.Items.Count > 1 Then comboBox1.SelectedIndex = 1
            comboBox2.SelectedIndex = 0
            dateTimePicker2.EditValue = TutorialConstants.Now
            dateTimePicker1.EditValue = dateTimePicker2.EditValue
        End Sub

        Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim rb As CheckEdit = TryCast(sender, CheckEdit)
            rb.Font = New Font(rb.Font, If(rb.Checked, FontStyle.Bold, FontStyle.Regular))
            Dim isSpecifyDates As Boolean = rb Is radioButton5 AndAlso rb.Checked
            dateTimePicker2.Enabled = isSpecifyDates
            dateTimePicker1.Enabled = dateTimePicker2.Enabled
            comboBox2.Enabled = dateTimePicker1.Enabled
        End Sub

        Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim cb As CheckEdit = TryCast(sender, CheckEdit)
            cb.Font = New Font(cb.Font, If(cb.Checked, FontStyle.Bold, FontStyle.Regular))
        End Sub
    End Class
End Namespace

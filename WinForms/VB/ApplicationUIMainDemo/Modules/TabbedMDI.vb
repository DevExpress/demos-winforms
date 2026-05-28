Imports System
Imports System.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    ''' <summary>
    ''' Summary description for frmTabbedMDI.
    ''' </summary>
    Public Partial Class frmTabbedMDI
        Inherits XtraForm

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitWindows()
            For i As Integer = 0 To 3 - 1
                AddNewForm()
            Next

            InitComboBoxes()
            barCheckItem1.Checked = xtraTabbedMdiManager1.FloatOnDoubleClick = DefaultBoolean.True
            barCheckItem2.Checked = xtraTabbedMdiManager1.FloatOnDrag = DefaultBoolean.True
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.ApplicationUI.Demos.AppIcon.ico", GetType(frmMain).Assembly)
            Text = DemoHelper.GetFormText("TabbedMDI")
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private formCount As Integer = 0

        Private Sub InitComboBoxes()
            repositoryItemImageComboBox1.Items.AddEnum(GetType(TabHeaderLocation))
            repositoryItemImageComboBox2.Items.AddEnum(GetType(TabOrientation))
            repositoryItemImageComboBox3.Items.AddEnum(GetType(TabPageImagePosition))
            repositoryItemImageComboBox4.Items.AddEnum(GetType(DefaultBoolean))
            repositoryItemImageComboBox5.Items.AddEnum(GetType(ClosePageButtonShowMode))
            repositoryItemImageComboBox6.Items.AddEnum(GetType(PinPageButtonShowMode))
            barEditItem1.EditValue = xtraTabbedMdiManager1.HeaderLocation
            barEditItem2.EditValue = xtraTabbedMdiManager1.HeaderOrientation
            barEditItem3.EditValue = xtraTabbedMdiManager1.PageImagePosition
            barEditItem4.EditValue = xtraTabbedMdiManager1.HeaderAutoFill
            barEditItem5.EditValue = xtraTabbedMdiManager1.ClosePageButtonShowMode
            barEditItem6.EditValue = xtraTabbedMdiManager1.PinPageButtonShowMode
        End Sub

        Private Sub AddNewForm()
            Dim frm As XtraForm = New XtraForm()
            frm.Text = String.Format("Form {0}", Math.Min(Threading.Interlocked.Increment(formCount), formCount - 1))
            frm.MdiParent = Me
            frm.Show()
            ColourTab()
        End Sub

        Private Sub ColourTab()
            If bCheckItem.Checked Then xtraTabbedMdiManager1.Pages(xtraTabbedMdiManager1.Pages.Count - 1).Appearance.Header.BackColor = TabColor((formCount - 1) Mod 6)
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            AddNewForm()
        End Sub

        Private Sub InitWindows()
            barMdiChildrenListItem1.Enabled = xtraTabbedMdiManager1.Pages.Count > 0
        End Sub

        Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As MdiTabPageEventArgs)
            InitWindows()
            e.Page.Image = imageCollection1.Images(TutorialConstants.Random.Next(imageCollection1.Images.Count - 1))
        End Sub

        Private Sub xtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As MdiTabPageEventArgs)
            InitWindows()
        End Sub

        Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.HeaderLocation = CType(barEditItem1.EditValue, TabHeaderLocation)
        End Sub

        Private Sub barEditItem2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.HeaderOrientation = CType(barEditItem2.EditValue, TabOrientation)
        End Sub

        Private Sub barEditItem3_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.PageImagePosition = CType(barEditItem3.EditValue, TabPageImagePosition)
        End Sub

        Private Sub barEditItem4_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.HeaderAutoFill = CType(barEditItem4.EditValue, DefaultBoolean)
        End Sub

        Private Sub barEditItem5_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.ClosePageButtonShowMode = CType(barEditItem5.EditValue, ClosePageButtonShowMode)
        End Sub

        Private Sub barEditItem6_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            xtraTabbedMdiManager1.PinPageButtonShowMode = CType(barEditItem6.EditValue, PinPageButtonShowMode)
        End Sub

        Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            xtraTabbedMdiManager1.FloatOnDoubleClick = If(barCheckItem1.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub barCheckItem2_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            xtraTabbedMdiManager1.FloatOnDrag = If(barCheckItem2.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private TabColor As Color() = New Color() {Color.FromArgb(35, 83, 194), Color.FromArgb(64, 168, 19), Color.FromArgb(245, 121, 10), Color.FromArgb(141, 62, 168), Color.FromArgb(70, 155, 183), Color.FromArgb(196, 19, 19)}

        Private Sub bCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarCheckItem = TryCast(sender, BarCheckItem)
            Dim j As Integer = 0
            If item.Checked Then
                For Each page As XtraMdiTabPage In xtraTabbedMdiManager1.Pages
                    page.Appearance.Header.BackColor = TabColor(j Mod 6)
                    j += 1
                Next
            Else
                For Each page As XtraMdiTabPage In xtraTabbedMdiManager1.Pages
                    page.Appearance.Header.BackColor = Color.Empty
                Next
            End If
        End Sub
    End Class
End Namespace

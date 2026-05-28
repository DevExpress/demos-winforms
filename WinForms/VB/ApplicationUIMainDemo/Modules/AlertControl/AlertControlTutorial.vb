Imports System
Imports System.Drawing

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class AlertControlTutorial
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            alertInfoProperties1.InitValues("Andrew Miller", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.", "<b>Jeffrey <i>W</i>  McClain", "<size=8><b>Email System. </b>What <size=12>library<size=8> are we going to use?", "<u><size=8><b>Email System. </b><color=Blue>What <size=12>library<size=8> are we going to use?")
            alertControlProperties1.InitValues(alertControl1)
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateCenteredControls(Me)
        End Sub

        Protected Overrides Sub OnScaleControl()
            MyBase.OnScaleControl()
            ceWidth.Value = ScaleHelper.ScaleHorizontal(CInt(ceWidth.Value))
            ceHeight.Value = ScaleHelper.ScaleHorizontal(CInt(ceHeight.Value))
        End Sub

        '<button1>
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            '<groupControl2>
            alertControl1.Show(FindForm(), alertInfoProperties1.Caption, alertInfoProperties1.TextInfo, alertInfoProperties1.HotTrackedText, alertInfoProperties1.Image, Nothing, alertControlProperties1.AutoCloseFormOnClick)
            '</groupControl2>
            UpdatePostponedFormCount()
        End Sub

        Private Sub UpdatePostponedFormCount()
            sePostponedFormCount.Value = alertControl1.PostponedFormList.Count
        End Sub

        '</button1>
        Private Sub alertControlProperties1_AllowHtmlTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            alertInfoProperties1.UpdateInfo(alertControl1.AllowHtmlText)
        End Sub

        '<ceHeight>
        '<ceWidth>
        Private Sub alertControl1_BeforeFormShow(ByVal sender As Object, ByVal e As XtraBars.Alerter.AlertFormEventArgs)
            e.AlertForm.Size = New Size(Convert.ToInt32(ceWidth.Value), If(alertControl1.AutoHeight, 100, Convert.ToInt32(ceHeight.Value)))
        End Sub

        '</ceWidth>
        '</ceHeight>
        Private Sub alertControl1_FormLoad(ByVal sender As Object, ByVal e As XtraBars.Alerter.AlertFormLoadEventArgs)
            UpdatePostponedFormCount()
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

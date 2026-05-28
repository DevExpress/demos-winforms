Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleRatingControl
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            UpdateRatingControl()
            ratingControlSample.AutoSizeInLayoutControl = True
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleRatingControl"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ratingControl"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub UpdateRatingControl()
            ratingControlSample.Properties.ItemCount = Convert.ToInt32(spEditItemCount.Value)
            ratingControlSample.Rating = If(ratingControlSample.Properties.ItemCount - 2 <= 0, ratingControlSample.Properties.ItemCount - 1, ratingControlSample.Properties.ItemCount - 2)
            spEditRating.Properties.MaxValue = spEditItemCount.Value
            spEditIndent.Value = ratingControlSample.Properties.TextToRatingIndent
            CalcContentCore()
        End Sub

        ' <spEditItemCount>
        Private Sub spinItemCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spEdit As SpinEdit = TryCast(sender, SpinEdit)
            ratingControlSample.Properties.ItemCount = Convert.ToInt32(spEdit.Value)
            spEditRating.Properties.MaxValue = spEditItemCount.Value
            CalcContentCore()
        End Sub

        ' </spEditItemCount>
        ' <spEditRating>
        Private Sub spEditRating_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spEdit As SpinEdit = TryCast(sender, SpinEdit)
            If spEdit.Value = ratingControlSample.Rating Then Return
            ratingControlSample.Rating = spEdit.Value
        End Sub

        ' </spEditRating>
        Private Sub ratingControlSample_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ratingControlSample.Rating = spEditRating.Value Then Return
            spEditRating.Value = ratingControlSample.Rating
        End Sub

        ' <cmbEditRatingOrientation>
        Private Sub cmbEditRatingOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cmbEdit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            If cmbEdit.SelectedIndex = 0 Then
                ratingControlSample.Properties.RatingOrientation = Orientation.Horizontal
            Else
                ratingControlSample.Properties.RatingOrientation = Orientation.Vertical
            End If

            CalcContentCore()
        End Sub

        ' </cmbEditRatingOrientation>
        ' <cmbEditFillPrecision>
        Private Sub cmbEditFillPrecision_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cmbEdit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            Select Case cmbEdit.SelectedIndex
                Case 0
                    ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Full
                    spEditRating.Properties.IsFloatValue = False
                    spEditRating.Properties.Increment = 1.0D
                Case 1
                    ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Half
                    spEditRating.Properties.IsFloatValue = True
                    spEditRating.Properties.Increment = 0.5D
                Case 2
                    ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Exact
                    spEditRating.Properties.IsFloatValue = True
                    spEditRating.Properties.Increment = 0.2D
                Case Else
            End Select

            spEditRating.Value = ratingControlSample.Rating
        End Sub

        ' </cmbEditFillPrecision>
        ' <chEditShowText>
        Private Sub chEditShowText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim chEdit As CheckEdit = TryCast(sender, CheckEdit)
            ratingControlSample.Properties.ShowText = chEdit.Checked
            EnableTextSettingControls(chEdit.Checked)
            CalcContentCore()
        End Sub

        ' </chEditShowText>
        Private Sub EnableTextSettingControls(ByVal enabled As Boolean)
            cmbEditTextLocation.Enabled = enabled
            spEditIndent.Enabled = enabled
            chEditHtmlDraw.Enabled = enabled
        End Sub

        ' <cmbEditTextLocation>
        Private Sub cmbEditRatingAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cmbEdit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            Select Case cmbEdit.SelectedIndex
                Case 0
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Bottom
                Case 1
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Default
                Case 2
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Left
                Case 3
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.None
                Case 4
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Right
                Case 5
                    ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Top
                Case Else
            End Select
        End Sub

        ' </cmbEditTextLocation>
        ' <spEditIndent>
        Private Sub spEditIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spEdit As SpinEdit = TryCast(sender, SpinEdit)
            ratingControlSample.Properties.TextToRatingIndent = Convert.ToInt32(spEdit.Value)
        End Sub

        ' </spEditIndent>
        ' <chEditHtmlDraw>
        Private Sub chEditHtmlDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim chEdit As CheckEdit = TryCast(sender, CheckEdit)
            If chEdit.Checked Then
                ratingControlSample.Properties.AllowHtmlDraw = Utils.DefaultBoolean.True
                ratingControlSample.Text = "<Color=Blue>Sample<Color=Black> <b>RatingControl</b><br>"
            Else
                ratingControlSample.Properties.AllowHtmlDraw = Utils.DefaultBoolean.False
                ratingControlSample.Text = "RatingControl"
            End If

            CalcContentCore()
        End Sub

        ' </chEditHtmlDraw>
        ' <popupContainerEditImages>
        Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
            ratingControlSample.Properties.Glyph = picEditGlyph.Image
            ratingControlSample.Properties.HoverGlyph = picEditHover.Image
            ratingControlSample.Properties.CheckedGlyph = picEditChecked.Image
            popupContainerEditImages.ClosePopup()
            CalcContentCore()
        End Sub

        Private Sub btnDefault_Click(ByVal sender As Object, ByVal e As EventArgs)
            ratingControlSample.Properties.Glyph = Nothing
            ratingControlSample.Properties.HoverGlyph = Nothing
            ratingControlSample.Properties.CheckedGlyph = Nothing
            popupContainerEditImages.ClosePopup()
            CalcContentCore()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            popupContainerEditImages.ClosePopup()
        End Sub

        ' </popupContainerEditImages>
        ' <cmbEditRatingDirection>
        Private Sub cmbEditRatingDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim combo As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
            ratingControlSample.Properties.IsDirectionReversed = combo.SelectedIndex = 1
        End Sub

        ' </cmbEditRatingDirection>
        Private Sub spEditRating_EditValueChanging(ByVal sender As Object, ByVal e As Controls.ChangingEventArgs)
            e.NewValue = Decimal.Round(Convert.ToDecimal(e.NewValue), 2)
        End Sub
    End Class
End Namespace

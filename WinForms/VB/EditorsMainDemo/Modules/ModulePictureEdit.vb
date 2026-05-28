Imports System
Imports System.ComponentModel
Imports System.Drawing
' <comboBoxSizeMode>
Imports DevExpress.XtraEditors.Controls
' </comboBoxSizeMode>
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.ImageEditor
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.Data.Utils

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModulePictureEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
            AddHandler peEditable.ImageEditorDialogShowing, AddressOf PeEditable_ImageEditorDialogShowing
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModulePictureEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "pictureEdit"
            End Get
        End Property

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
        Public Overrides ReadOnly Property ContainsTabs As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides Sub SelectTabByName(ByVal tabName As String)
            If String.IsNullOrEmpty(tabName) Then Return
            For Each page As TabNavigationPage In tabPane1.Pages
                If String.Equals(page.Caption.Replace(" ", ""), tabName, StringComparison.OrdinalIgnoreCase) Then
                    tabPane1.SelectedPage = page
                    Exit For
                End If
            Next
        End Sub

        Public Overrides Function GetSelectedTabFullName() As String
            Return tabPane1.SelectedPage.Caption
        End Function

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
            CalcLayoutControlBounds(layoutControl4)
        End Sub

        Private updateValues As Boolean = False

        Private aligns As ContentAlignment() = New ContentAlignment() {ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight, ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight, ContentAlignment.BottomLeft, ContentAlignment.BottomCenter, ContentAlignment.BottomRight}

        Private Sub ModulePictureEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            For Each mode As InterpolationMode In [Enum].GetValues(GetType(InterpolationMode))
                If mode <> InterpolationMode.Invalid Then icbInterpolationMode.Properties.Items.Add(New ImageComboBoxItem(mode.ToString(), mode, -1))
            Next

            icbShowZoomSubMenu.Properties.Items.AddEnum(GetType(DefaultBoolean))
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            ceShowScrollBars.Checked = peScrollable.Properties.ShowScrollBars
            ceAllowFocused.Checked = peScrollable.Properties.AllowFocused
            cbAllowMenu.Checked = peScrollable.Properties.ShowMenu
            cbAlignment.EditValue = peScrollable.Properties.PictureAlignment.ToString()
            seZoomPercent.Value = New Decimal(peScrollable.Properties.ZoomPercent)
            ceAllowScroll.Checked = peScrollable.Properties.AllowScrollViaMouseDrag
            icbInterpolationMode.EditValue = peScrollable.Properties.PictureInterpolationMode
            icbShowZoomSubMenu.EditValue = peScrollable.Properties.ShowZoomSubMenu
            ceShowCameraItem.Checked = peScrollable.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Always
            updateValues = False
            UpdateAllowScrollViaMouseDrag()
        End Sub

        '<ceShowScrollBars>
        Private Sub ceShowScrollBars_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            peScrollable.Properties.ShowScrollBars = ceShowScrollBars.Checked
            UpdateAllowScrollViaMouseDrag()
        End Sub

        '</ceShowScrollBars>
        Private Sub UpdateAllowScrollViaMouseDrag()
            ceAllowScroll.Enabled = peScrollable.Properties.ShowScrollBars
        End Sub

        '<ceAllowFocused>
        Private Sub ceAllowFocused_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.AllowFocused = ceAllowFocused.Checked
        End Sub

        '</ceAllowFocused>
        '<cbAlignment>
        Private Sub cbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            Dim selectedIndex As Integer = cbAlignment.SelectedIndex
            peScrollable.Properties.PictureAlignment = aligns(selectedIndex)
        End Sub

        '</cbAlignment>
        Private Sub seZoomPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ztbZoomPercent.Value = CInt(seZoomPercent.Value)
        End Sub

        Private Sub ztbZoomPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            seZoomPercent.Value = ztbZoomPercent.Value
            peScrollable.Properties.ZoomPercent = ztbZoomPercent.Value
        End Sub

        '<ceAllowScroll>
        Private Sub ceAllowScroll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            peScrollable.Properties.AllowScrollViaMouseDrag = ceAllowScroll.Checked
        End Sub

        '</ceAllowScroll>
        '<icbInterpolationMode>
        Private Sub icbInterpolationMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.PictureInterpolationMode = CType(icbInterpolationMode.EditValue, InterpolationMode)
        End Sub

        Private Sub peScrollable_ZoomPercentChanged(ByVal sender As Object, ByVal e As EventArgs)
            updateValues = True
            Try
                seZoomPercent.Value = New Decimal(peScrollable.Properties.ZoomPercent)
                ztbZoomPercent.Value = CInt(peScrollable.Properties.ZoomPercent)
            Finally
                updateValues = False
            End Try
        End Sub

        Private Sub icbShowZoomSubMenu_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.ShowZoomSubMenu = CType(icbShowZoomSubMenu.EditValue, DefaultBoolean)
        End Sub

        Private Sub pictureEditSample_Properties_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs)
            ContextItemClick(e)
        End Sub

        Private Sub peScrollable_Properties_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs)
            ContextItemClick(e)
        End Sub

        Private Sub ContextItemClick(ByVal e As ContextItemClickEventArgs)
            If Equals(e.Item.Name, "itemDownload") Then
                XtraMessageBox.Show("'Download' item clicked")
            ElseIf Equals(e.Item.Name, "itemRemove") Then
                XtraMessageBox.Show("'Remove' item clicked")
            ElseIf Equals(e.Item.Name, "itemInfo") Then
                Dim args As XtraMessageBoxArgs = New XtraMessageBoxArgs()
                args.AllowHtmlText = DefaultBoolean.True
                args.Text = LicenseToolTipController.GetLicenseInfo($"CC BY-SA 3.0|Cristianv14|devexpress.com/carimage24|Resize and crop")
                AddHandler args.HyperlinkClick, Sub(s, a) SafeProcess.Start(a.Link)
                XtraMessageBox.Show(args)
            End If
        End Sub

        Private Sub ceShowCameraItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            peScrollable.Properties.ShowCameraMenuItem = If(ceShowCameraItem.Checked, CameraMenuItemVisibility.Always, CameraMenuItemVisibility.Never)
        End Sub

        Private Sub OnMaskTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = TryCast(comboBoxEdit1.EditValue, String)
            Select Case text
                Case "Circle"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Circle
                Case "RoundedRect"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.RoundedRect
                Case "Custom"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Custom
                Case Else
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.None
            End Select

            OnMaskTypeChanged(peMasked.Properties.OptionsMask.MaskType)
        End Sub

        Protected Sub OnMaskTypeChanged(ByVal type As PictureEditMaskType)
            textEdit3.Enabled =(type <> PictureEditMaskType.None)
            textEdit1.Enabled = textEdit3.Enabled
            textEdit2.Enabled = textEdit1.Enabled
            comboBoxEdit2.Enabled = textEdit2.Enabled
            seRadius.Enabled =(type = PictureEditMaskType.RoundedRect)
            buttonEdit1.Enabled =(type = PictureEditMaskType.Custom)
        End Sub

        Protected Function GetIntArrayFromEditValue(ByVal editValue As Object) As Integer()
            If editValue Is Nothing Then Return Nothing
            Dim vals As String() = editValue.ToString().Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
            Dim res As Integer() = New Integer(vals.Length - 1) {}
            For i As Integer = 0 To vals.Length - 1
                Dim result As Integer = 0
                If Not Integer.TryParse(vals(i), result) Then Return Nothing
                res(i) = result
            Next

            Return res
        End Function

        Private Sub OnMaskOffsetChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer() = GetIntArrayFromEditValue(textEdit2.EditValue)
            If val Is Nothing OrElse val.Length <> 2 Then Return
            Me.peMasked.Properties.OptionsMask.Offset = New Point(val(0), val(1))
        End Sub

        Private Sub OnMaskSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer() = GetIntArrayFromEditValue(textEdit1.EditValue)
            If val Is Nothing OrElse val.Length <> 2 Then Return
            Dim res As Size = If(val(0) <= 0 OrElse val(1) <= 0, Size.Empty, New Size(val(0), val(1)))
            Me.peMasked.Properties.OptionsMask.Size = res
        End Sub

        Private Sub OnMaskMarginChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer() = GetIntArrayFromEditValue(textEdit3.EditValue)
            If val Is Nothing OrElse val.Length <> 4 Then Return
            Me.peMasked.Properties.OptionsMask.Margin = New Padding(val(0), val(1), val(2), val(3))
        End Sub

        Private Sub OnMaskRadiusChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.peMasked.Properties.OptionsMask.RectCornerRadius = Decimal.ToInt32(seRadius.Value)
        End Sub

        Private Sub OnMaskLayoutChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.peMasked.Properties.OptionsMask.MaskLayoutMode = GetMaskLayoutType(comboBoxEdit2.SelectedIndex)
        End Sub

        Protected Function GetMaskLayoutType(ByVal index As Integer) As PictureEditMaskLayoutMode
            Select Case index
                Case 1
                    Return PictureEditMaskLayoutMode.ZoomInside
                Case 2
                    Return PictureEditMaskLayoutMode.Stretch
                Case 3
                    Return PictureEditMaskLayoutMode.BottomCenter
                Case 4
                    Return PictureEditMaskLayoutMode.BottomLeft
                Case 5
                    Return PictureEditMaskLayoutMode.BottomRight
                Case 6
                    Return PictureEditMaskLayoutMode.MiddleCenter
                Case 7
                    Return PictureEditMaskLayoutMode.MiddleLeft
                Case 8
                    Return PictureEditMaskLayoutMode.MiddleRight
                Case 9
                    Return PictureEditMaskLayoutMode.TopCenter
                Case 10
                    Return PictureEditMaskLayoutMode.TopLeft
                Case 11
                    Return PictureEditMaskLayoutMode.TopRight
                Case Else
                    Return PictureEditMaskLayoutMode.Default
            End Select
        End Function

        Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png"
            dlg.Title = "Open"
            If dlg.ShowDialog(Me) = DialogResult.OK AndAlso Not Equals(dlg.FileName, Nothing) AndAlso Not Equals(dlg.FileName, String.Empty) Then
                Try
                    Me.peMasked.Properties.OptionsMask.CustomMask = Image.FromFile(dlg.FileName)
                    buttonEdit1.Text = dlg.FileName
                Catch
                End Try
            End If
        End Sub

        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            peEditable.ShowImageEditorDialog()
        End Sub

        Private Sub PeEditable_ImageEditorDialogShowing(ByVal sender As Object, ByVal e As ImageEditorDialogShowingEventArgs)
            AddHandler e.Form.CustomizeCropOptions, Sub(s, ea) CustomizeCropOptions(s, ea)
        End Sub

        Private Sub CustomizeCropOptions(ByVal sender As Object, ByVal e As CustomizeCropOptionsEventArgs)
            If ceCustomRatios.Checked Then
                Dim widescreen = New AspectRatioInfo(1.777F, "16:9")
                Dim standard = New AspectRatioInfo(1.333F, "4:3")
                e.AspectRatios.Clear()
                e.AspectRatios.Add(widescreen)
                e.AspectRatios.Add(standard)
                e.DefaultAspectRatio = widescreen
            End If
        End Sub

        ' <cbAllowMenu>
        Private Sub cbAllowMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            peScrollable.Properties.ShowMenu = cbAllowMenu.Checked
        End Sub
    ' </cbAllowMenu>
    End Class
End Namespace

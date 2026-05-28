Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
' <comboAlign>
Imports DevExpress.Utils
' </comboAlign>
' <checkEditRadioGroup>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraLayout
Imports System.Drawing
Imports DevExpress.XtraBars.Navigation

' </checkEditRadioGroup>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleCheckEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitializeImageListBox(True)
            CheckControlsState()
            If tabPane1 IsNot Nothing Then
                AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
                AddHandler tabPane1.VisibleChanged, AddressOf OnTabControlVisibleChanged
            End If
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then
                RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
                RemoveHandler tabPane1.VisibleChanged, AddressOf OnTabControlVisibleChanged
            End If
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleCheckEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "checkEdit"
            End Get
        End Property

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            InitializeImageListBox(False)
        End Sub

        Private Sub InitializeImageListBox(ByVal createItems As Boolean)
            lbStyle.BeginUpdate()
            Try
                Dim imageCollection As ImageCollection = TryCast(lbStyle.ImageList, ImageCollection)
                If imageCollection Is Nothing Then
                    imageCollection = New ImageCollection()
                    imageCollection.ImageSize = GetImageSize()
                Else
                    imageCollection.Clear()
                End If

                Dim imageIndex As Integer = 0
                For Each style As CheckBoxStyle In [Enum].GetValues(GetType(CheckBoxStyle))
                    Dim image As Image = GetCheckBoxImage(LookAndFeel, style)
                    If image Is Nothing Then Continue For
                    imageCollection.Images.Add(image)
                    If createItems Then lbStyle.Items.Add(style, Math.Min(Threading.Interlocked.Increment(imageIndex), imageIndex - 1))
                Next

                lbStyle.ImageList = imageCollection
            Catch
            Finally
                lbStyle.EndUpdate()
            End Try
        End Sub

        ' <lbStyle>
        Private Sub lbStyle_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim style = CType(lbStyle.SelectedValue, CheckBoxStyle)
            checkEditSample.Properties.CheckBoxOptions.Style = style
            CheckControlsState()
        End Sub

        ' </lbStyle>
        Private Sub CheckControlsState()
            Dim style = checkEditSample.Properties.CheckBoxOptions.Style
            ceIndeterminateColor.Enabled = IsSvgStyle(style)
            ceUncheckedColor.Enabled = ceIndeterminateColor.Enabled
            ceCheckedColor.Enabled = ceUncheckedColor.Enabled
        End Sub

        Private Function IsSvgStyle(ByVal style As CheckBoxStyle) As Boolean
            Return CInt(style) > CInt(CheckBoxStyle.Custom)
        End Function

        Private updateValues As Boolean = False

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Private Sub OnTabControlVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub CalcContentCore()
            If Not Visible OrElse Not IsHandleCreated Then Return
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
        End Sub

        ' <checkEditAllowGrayed>
        Private Sub checkEditAllowGrayed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkEditSample.Properties.AllowGrayed = checkEditAllowGrayed.Checked
        End Sub

        ' </checkEditAllowGrayed>
        ' <comboAlign>
        Private Sub comboAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim alignments As HorzAlignment() = New HorzAlignment() {HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far}
            Dim selectedIndex As Integer = comboAlign.SelectedIndex
            checkEditSample.Properties.GlyphAlignment = alignments(selectedIndex)
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
        End Sub

        ' </comboAlign>
        Private Sub CreateEditors()
            Dim checkEditCount As Integer = 10
            Dim checkEditDistance As Integer = checkEditSample.Font.Height + 10
            For i As Integer = 0 To checkEditCount - 1
                Dim newCheckEdit As CheckEdit = New CheckEdit()
                newCheckEdit.Text = "Check edit " & (i + 1).ToString()
                Dim item As LayoutControlItem = layoutControlGroup7.AddItem(String.Empty, newCheckEdit)
                item.TextVisible = False
            Next
        End Sub

        ' <checkEditRadioGroup>
        Private Sub checkEditRadioGroup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkEditRadioGroup.Checked Then
                SetCheckEditsRadioIndex(0)
            Else
                SetCheckEditsRadioIndex(-1)
            End If

            checkEditApplyRadioStyle.Checked = checkEditRadioGroup.Checked
        End Sub

        Private Sub SetCheckEditsRadioIndex(ByVal radioIndex As Integer)
            Dim checkEdits As ArrayList = GetCheckEditControls()
            For Each editor As CheckEdit In checkEdits
                editor.Checked = False
                editor.Properties.RadioGroupIndex = radioIndex
            Next
        End Sub

        ' </checkEditRadioGroup>
        ' <checkEditApplyRadioStyle>
        Private Sub checkEditApplyRadioStyle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkEditApplyRadioStyle.Checked Then
                SetCheckEditsStyle(CheckStyles.Radio)
            Else
                SetCheckEditsStyle(CheckStyles.Standard)
            End If
        End Sub

        Private Sub SetCheckEditsStyle(ByVal style As CheckStyles)
            Dim checkEdits As ArrayList = GetCheckEditControls()
            For Each editor As CheckEdit In checkEdits
                editor.Properties.CheckStyle = style
            Next
        End Sub

        ' </checkEditApplyRadioStyle>
        ' <btnRemoveEditors> <checkEditRadioGroup> <checkEditApplyRadioStyle>
        Private Function GetCheckEditControls() As ArrayList
            Dim checkEdits As ArrayList = New ArrayList()
            For Each item As LayoutControlItem In layoutControlGroup7.Items
                If TypeOf item.Control Is CheckEdit Then checkEdits.Add(item.Control)
            Next

            Return checkEdits
        End Function

        ' </btnRemoveEditors> </checkEditRadioGroup> </checkEditApplyRadioStyle>
        Private Sub TutorialModuleCheckEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(checkEditSample)
            CreateEditors()
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditAllowGrayed.Checked = checkEditSample.Properties.AllowGrayed
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near
            comboAlign.EditValue = checkEditSample.Properties.Appearance.TextOptions.HAlignment.ToString()
            updateValues = False
        End Sub

        '<ceCheckedColor>
        Private Sub ceCheckedColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim color As Color = CType(sender, ColorPickEdit).Color
            checkEditSample.Properties.CheckBoxOptions.SvgColorChecked = color
        End Sub

        '</ceCheckedColor>
        '<ceUncheckedColor>
        Private Sub ceUncheckedColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim color As Color = CType(sender, ColorPickEdit).Color
            checkEditSample.Properties.CheckBoxOptions.SvgColorUnchecked = color
        End Sub

        '</ceUncheckedColor>
        '<ceIndeterminateColor>
        Private Sub ceIndeterminateColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim color As Color = CType(sender, ColorPickEdit).Color
            checkEditSample.Properties.CheckBoxOptions.SvgColorGrayed = color
        End Sub
    '</ceIndeterminateColor>
    End Class

    Friend Module CheckBoxImageProvider

        Private Function GetImageSizeCore() As Size
            Return New Size(CInt(18 * DpiProvider.Default.DpiScaleFactor), CInt(18 * DpiProvider.Default.DpiScaleFactor))
        End Function

        Public Function GetImageSize() As Size
            Dim size As Size = GetImageSizeCore()
            size.Width = size.Width * 2 + ImageInterval
            Return size
        End Function

        Private ReadOnly Property ImageInterval As Integer
            Get
                Return CInt(6 * DpiProvider.Default.DpiScaleFactor)
            End Get
        End Property

        Private Function GetCheckBoxElementInfo(ByVal cache As GraphicsCache, ByVal lookAndFeel As UserLookAndFeel, ByVal style As CheckBoxStyle, ByVal state As CheckState, ByVal size As Size) As SkinElementInfo
            Dim name As String = If(style = CheckBoxStyle.Radio, EditorsSkins.SkinRadioButton, EditorsSkins.SkinCheckBox)
            Dim info As SkinElementInfo = New SkinElementInfo(EditorsSkins.GetSkin(lookAndFeel)(name), New Rectangle(Point.Empty, size))
            info.State = ObjectState.Normal
            info.ImageIndex = SkinElementPainter.Default.CalcDefaultImageIndex(info.Element.Image, ObjectState.Normal)
            info.Cache = cache
            Select Case state
                Case CheckState.Checked
                    info.ImageIndex += 4
                Case CheckState.Indeterminate
                    info.ImageIndex += 8
            End Select

            Return info
        End Function

        Public Function GetCheckBoxImage(ByVal lookAndFeel As UserLookAndFeel, ByVal style As CheckBoxStyle) As Image
            If style = CheckBoxStyle.Default OrElse style = CheckBoxStyle.Custom Then Return Nothing
            Dim checkedImage As Image = GetCheckBoxImage(style, CheckState.Checked, lookAndFeel)
            Dim uncheckedImage As Image = GetCheckBoxImage(style, CheckState.Unchecked, lookAndFeel)
            If checkedImage Is Nothing OrElse uncheckedImage Is Nothing Then Return Nothing
            Dim imageSize As Size = GetImageSize()
            Dim bmp As Bitmap = New Bitmap(imageSize.Width, imageSize.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.DrawImageUnscaled(checkedImage, 0, 0)
                g.DrawImageUnscaled(uncheckedImage, GetImageSizeCore().Width + ImageInterval, 0)
            End Using

            checkedImage.Dispose()
            uncheckedImage.Dispose()
            Return bmp
        End Function

        Private Function GetCheckBoxImage(ByVal style As CheckBoxStyle, ByVal state As CheckState, ByVal lookAndFeel As UserLookAndFeel) As Image
            If style = CheckBoxStyle.CheckBox OrElse style = CheckBoxStyle.Radio Then
                Dim imageSize As Size = GetImageSizeCore()
                Dim checkBoxBitmap As Bitmap = New Bitmap(imageSize.Width, imageSize.Height)
                Using g As Graphics = Graphics.FromImage(checkBoxBitmap)
                    Using cache As GraphicsCache = New GraphicsCache(g)
                        SkinElementPainter.Default.DrawObject(GetCheckBoxElementInfo(cache, lookAndFeel, style, state, imageSize))
                    End Using
                End Using

                Return checkBoxBitmap
            End If

            Dim resourceName As String = String.Format("DevExpress.XtraEditors.Images.SVG.CheckEdit.{0}_{1}.svg", style, state)
            Dim svgImage = ResourceImageHelperCore.CreateSvgImageFromResources(resourceName, GetType(CheckEdit).GetAssembly())
            If svgImage Is Nothing Then Return Nothing
            Dim svgBitmap = New SvgBitmap(svgImage)
            Dim palette = SvgPaletteHelper.GetSvgPalette(lookAndFeel, ObjectState.Normal)
            Return svgBitmap.Render(palette)
        End Function
    End Module
End Namespace

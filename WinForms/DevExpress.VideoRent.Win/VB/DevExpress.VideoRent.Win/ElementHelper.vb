Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Runtime.InteropServices
Imports DevExpress.XtraGrid.Views.Base
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Data.Helpers
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.IO
Imports System.Collections
Imports System.Data.SqlClient
Imports DevExpress.VideoRent.Resources
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout
Imports DevExpress.VideoRent.Win.Modules
Imports DevExpress.XtraCharts
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraGrid.Localization

Namespace DevExpress.VideoRent.Win
	Public Class ExceptionsProcesser
		Implements IExceptionProcesser
		Private owner As IWin32Window
		Public Sub New(ByVal owner As IWin32Window)
			Me.owner = owner
		End Sub
		Public Sub Process(ByVal e As Exception) Implements IExceptionProcesser.Process
			XtraMessageBox.Show(owner, e.Message, ConstStrings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Sub
	End Class
	Public Class WinApiWrapper
		Public Shared Function GetModuleHandle(ByVal moduleName As String) As Integer
			Return Import.GetModuleHandle(moduleName)
		End Function
		Public Shared Function ExtractIcon(ByVal hinstance As Integer, ByVal file As String, ByVal iconIndex As Integer) As Icon
			Return IconFromHandle(Import.ExtractIcon(hinstance, file, iconIndex))
		End Function
		Public Shared Function GetIconBySHGetFileInfo(ByVal file As String, ByVal small As Boolean) As Icon
			Dim shFileInfo As New Import.SHFILEINFO(True)
			Dim fileInfoSize As Integer = Marshal.SizeOf(shFileInfo)
			Dim flags As Import.SHGFI
			If small Then
				flags = Import.SHGFI.Icon Or (Import.SHGFI.SmallIcon)
			Else
				flags = Import.SHGFI.Icon Or (Import.SHGFI.LargeIcon)
			End If
			Import.SHGetFileInfo(file, 0, shFileInfo, CUInt(fileInfoSize), CUInt(flags))
			Return IconFromHandle(shFileInfo.Hicon)
		End Function
		Public Shared Function GetTypeNameBySHGetFileInfo(ByVal file As String) As String
			Dim shFileInfo As New Import.SHFILEINFO(True)
			Dim fileInfoSize As Integer = Marshal.SizeOf(shFileInfo)
			Dim flags As Import.SHGFI = Import.SHGFI.TypeName
			Import.SHGetFileInfo(file, 0, shFileInfo, CUInt(fileInfoSize), CUInt(flags))
			Return shFileInfo.TypeName
		End Function
		Private Shared Function IconFromHandle(ByVal hicon As IntPtr) As Icon
            If Object.Equals(hicon, IntPtr.Zero) Then
                Return Nothing
            End If
			Dim icon As Icon = Icon.FromHandle(hicon)
			Dim ret As New Icon(icon, icon.Size)
			Import.DestroyIcon(hicon)
			Return ret
		End Function
		Private Class Import
			<DllImport("Kernel32.dll")> _
			Public Shared Function GetModuleHandle(ByVal moduleName As String) As Integer
			End Function
			<DllImport("Shell32.dll")> _
			Public Shared Function ExtractIcon(ByVal hinstance As Integer, ByVal file As String, ByVal iconIndex As Integer) As IntPtr
			End Function
			<DllImport("shell32.dll")> _
			Public Shared Function SHGetFileInfo(ByVal path As String, ByVal fileAttributes As UInteger, ByRef psfi As SHFILEINFO, ByVal fileInfo As UInteger, ByVal flags As UInteger) As IntPtr
			End Function
			<DllImport("user32.dll", SetLastError:=True)> _
			Public Shared Function DestroyIcon(ByVal hicon As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
			End Function
			Public Const MAX_PATH As Integer = 260
			Public Const MAX_TYPE As Integer = 80
			<StructLayout(LayoutKind.Sequential)> _
			Public Structure SHFILEINFO
				Public Sub New(ByVal b As Boolean)
					Hicon = IntPtr.Zero
					IconIndex = 0
					Attributes = 0
					DisplayName = String.Empty
					TypeName = String.Empty
				End Sub
				Public Hicon As IntPtr
				Public IconIndex As Integer
				Public Attributes As UInteger
				<MarshalAs(UnmanagedType.ByValTStr, SizeConst := MAX_PATH)> _
				Public DisplayName As String
				<MarshalAs(UnmanagedType.ByValTStr, SizeConst := MAX_TYPE)> _
				Public TypeName As String
			End Structure
			<Flags> _
			Public Enum SHGFI As UInteger
				Icon = &H000000100
				DisplayName = &H000000200
				TypeName = &H000000400
				Attributes = &H000000800
				IconLocation = &H000001000
				ExeType = &H000002000
				SysIconIndex = &H000004000
				LinkOverlay = &H000008000
				Selected = &H000010000
				AttrSpecified = &H000020000
				LargeIcon = &H000000000
				SmallIcon = &H000000001
				OpenIcon = &H000000002
				ShellIconSize = &H000000004
				PIDL = &H000000008
				UseFileAttributes = &H000000010
				AddOverlays = &H000000020
				OverlayIndex = &H000000040
			End Enum
		End Class
	End Class
	Public Class WinHelper
		Public Shared Sub GridViewFocusObject(ByVal cView As ColumnView, ByVal obj As VideoRentBaseObject)
			If Object.Equals(obj, Nothing) Then
				Return
			End If
			For i As Integer = 0 To cView.DataRowCount - 1
				Dim rowObj As VideoRentBaseObject = TryCast(cView.GetRow(i), VideoRentBaseObject)
				If Object.Equals(rowObj, Nothing) Then
					Continue For
				End If
				If obj.Oid = rowObj.Oid Then
					cView.FocusedRowHandle = i
					Exit For
				End If
			Next i
		End Sub
		Public Shared Function ReplaceFilterText(ByVal filter As Object, ByVal sourceString As String, ByVal retString As String) As String
			Dim displayFilterText As String = String.Format("{0}", filter)
			If displayFilterText.Contains(sourceString) Then
				Return displayFilterText.Replace(sourceString, retString)
			End If
			Return Nothing
		End Function
		Private Shared Function GetBaseViewByControl(ByVal control As Control) As BaseView
			If Object.Equals(control, Nothing) Then
				Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is GridControl Then
					Return (CType(cntl, GridControl)).MainView
				End If
			Next cntl
			Return Nothing
		End Function
		Private Shared Function GetLayoutControlByControl(ByVal control As Control) As LayoutControl
			If Object.Equals(control, Nothing) Then
				Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is LayoutControl Then
					Return TryCast(cntl, LayoutControl)
				End If
			Next cntl
			Return Nothing
		End Function
		Private Shared Sub CloseElements(ByVal control As Control)
			For Each ctrl As Control In control.Controls
				CloseElements(ctrl)
			Next ctrl
			Dim view As BaseView = GetBaseViewByControl(control)
			If (Not Object.Equals(view, Nothing)) Then
				For Each bView As BaseView In view.GridControl.Views
					If TypeOf bView Is GridView Then
						CType(bView, GridView).DestroyCustomization()
					End If
				Next bView
			End If
			Dim layout As LayoutControl = GetLayoutControlByControl(control)
			If (Not Object.Equals(layout, Nothing)) Then
				layout.HideCustomizationForm()
			End If

		End Sub
		Public Shared Sub CloseCustomizationForm(ByVal control As TutorialControlBase)
			If Object.Equals(control, Nothing) Then
				Return
			End If
			CloseElements(control)
			For Each dBase As DetailBase In control.DetailModulesCollection
				CloseElements(dBase)
			Next dBase
		End Sub
		Public Shared Sub SetChartStyle(ByVal chartControl As ChartControl, ByVal manager As ChartAppearanceManager)
			If Object.Equals(chartControl, Nothing) Then
				Return
			End If
			chartControl.AppearanceName = manager.AppearanceName
			chartControl.PaletteBaseColorNumber = manager.ColorIndex
			chartControl.PaletteName = manager.PaletteName
		End Sub
		Public Shared Function GetLinkColor(ByVal lookAndFeel As UserLookAndFeel) As Color
			Dim color As Color = Color.Empty
			If lookAndFeel.ActiveStyle = DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin Then
				Dim skin As Skin = EditorsSkins.GetSkin(lookAndFeel)
				color = skin.Colors.GetColor(EditorsSkins.SkinHyperlinkTextColor)
			End If
			If color.IsEmpty Then
				color = Color.Blue
			End If
			Return color
		End Function
	End Class
	Public Class ObjectHelper
		Public Shared Sub ShowWebSite(ByVal url As String)
			If Object.Equals(url, Nothing) Then
				Return
			End If
			Dim processName As String = url.Replace(" ", String.Empty)
			If processName.Length = 0 Then
				Return
			End If
			Const protocol As String = "http://"
			Const protocol2 As String = "https://"
            If processName.IndexOf(protocol, StringComparison.InvariantCultureIgnoreCase) <> 0 AndAlso processName.IndexOf(protocol2, StringComparison.InvariantCultureIgnoreCase) <> 0 Then
                processName = protocol & processName
            End If
			StartProcess(processName)
		End Sub
        Public Shared Sub StartProcess(ByVal processName As String)
            If (Data.Utils.SafeProcess.Start(processName) Is Nothing) Then
                XtraMessageBox.Show("", ConstStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
        Public Shared Function SafeDelete(ByVal owner As IWin32Window, ByVal obj As VideoRentBaseObject, ByVal commitSession As Boolean) As Boolean
			If (Not obj.AllowDelete) Then
				XtraMessageBox.Show(owner, ConstStrings.ObjectCanNotBeDeleted, ConstStrings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Return False
			End If
			Dim uow As UnitOfWork = CType(obj.Session, UnitOfWork)
			obj.Delete()
			If commitSession Then
				SessionHelper.CommitSession(uow, New ExceptionsProcesser(owner))
			End If
			Return True
		End Function
		Public Shared Sub SetFormContainerSize(ByVal form As Form, ByVal control As Control)
			form.StartPosition = FormStartPosition.Manual
			form.Size = control.Size
			form.Location = control.FindForm().PointToScreen(control.Location)
		End Sub
		Public Shared Sub ShowFormDialog(ByVal form As Form, ByVal parent As Form)
			Try
				parent.Enabled = False
				form.ShowDialog(parent)
			Finally
				parent.Enabled = True
			End Try
		End Sub
		Public Shared Sub OpenExportedFile(ByVal fileName As String)
            If XtraMessageBox.Show(ConstStrings.ExportFileOpen, ConstStrings.Export, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Data.Utils.SafeProcess.Start(fileName)
            End If
        End Sub
		Public Shared Sub ShowExportErrorMessage()
			XtraMessageBox.Show(ConstStrings.ExportError, ConstStrings.Export, MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Sub
		Public Shared Function GetFileName(ByVal extension As String, ByVal filter As String) As String
			Using dialog As New SaveFileDialog()
				dialog.Filter = filter
				dialog.DefaultExt = extension
				If dialog.ShowDialog() = DialogResult.OK Then
					Return dialog.FileName
				End If
			End Using
			Return String.Empty
		End Function
		Public Shared Sub RemoveCustomizationItemsFromColumnMenu(ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
			If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
				For i As Integer = e.Menu.Items.Count - 1 To 0 Step -1
					If GridStringId.MenuColumnColumnCustomization.Equals(e.Menu.Items(i).Tag) OrElse GridStringId.MenuColumnRemoveColumn.Equals(e.Menu.Items(i).Tag) Then
						e.Menu.Items.RemoveAt(i)
					End If
				Next i
			End If
		End Sub

		Friend Shared Function GetArticleByWord(ByVal word As String) As String
			If String.IsNullOrEmpty(word) Then
				Return String.Empty
			End If
			Dim firstLetter As String = word.Substring(0, 1).ToLower()
			If firstLetter = "a" Then
				Return "an"
			End If
			Return "a"
		End Function
	End Class
	Public Enum ImageSize
		Small16
		Large32
	End Enum
	Public Class ElementHelper
        Private Shared _barImages As ImageCollection = Nothing
        Private Shared _personImages As ImageCollection = Nothing
        Private Shared _receiptTypeImages As ImageCollection = Nothing
        Private Shared _activeRentTypeImages As ImageCollection = Nothing
        Private Shared _ratingImages As ImageCollection = Nothing
        Private Shared _ratingLargeImages As ImageCollection = Nothing
        Private Shared _folderIcons As ImageCollection = Nothing
        Private Shared _diskIcons As ImageCollection = Nothing
        Private Shared _columnHeaderIcons As ImageCollection = Nothing
        Private Shared _AppIcon As Icon = Nothing
        Public Shared Function GetImage(ByVal name As String, ByVal size As ImageSize) As Image
            If String.IsNullOrEmpty(name) Then
                Return Nothing
            End If
            Dim prefix As String = String.Empty ' ""
            Return ResourceImageHelper.CreateImageFromResources(String.Format("{2}{0}_{1}.png", name, GetImageSizeString(size), prefix), GetType(ImagesHelper).Assembly)
        End Function
        Public Shared Function GetAboutPageImage(ByVal name As String) As Image
            If String.IsNullOrEmpty(name) Then
                Return Nothing
            End If
            Return ResourceImageHelper.CreateImageFromResources(String.Format("{0}.png", name), GetType(ImagesHelper).Assembly)
        End Function
        Public Shared Function GetGroupImage(ByVal name As String) As Image
            If Object.Equals(name, Nothing) OrElse Object.Equals(name, String.Empty) Then
                Return Nothing
            End If
            Return ResourceImageHelper.CreateImageFromResources(String.Format("Group_{0}.png", name), GetType(ImagesHelper).Assembly)
        End Function

		Private Shared Function GetImageSizeString(ByVal size As ImageSize) As String
			If size = ImageSize.Small16 Then
				Return "16x16"
			End If
			Return "32x32"
		End Function
		Public Shared ReadOnly Property BarImages() As ImageCollection
			Get
                If Object.Equals(ElementHelper._barImages, Nothing) Then
                    ElementHelper._barImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("BarImages16x16.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._barImages
			End Get
		End Property
		Public Shared ReadOnly Property PersonImages() As ImageCollection
			Get
                If Object.Equals(ElementHelper._personImages, Nothing) Then
                    ElementHelper._personImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("Persons.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._personImages
			End Get
		End Property
		Public Shared ReadOnly Property ReceiptTypeImages() As ImageCollection
			Get
                If Object.Equals(ElementHelper._receiptTypeImages, Nothing) Then
                    ElementHelper._receiptTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("ReceiptType.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._receiptTypeImages
            End Get
        End Property
        Public Shared ReadOnly Property ActiveRentTypeImages() As ImageCollection
            Get
                If Object.Equals(ElementHelper._activeRentTypeImages, Nothing) Then
                    ElementHelper._activeRentTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("ActiveRents.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._activeRentTypeImages
            End Get
        End Property
        Public Shared ReadOnly Property RatingImages() As ImageCollection
            Get
                If Object.Equals(ElementHelper._ratingImages, Nothing) Then
                    ElementHelper._ratingImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("RatingsSmall.png", GetType(ImagesHelper).Assembly, New Size(38, 16))
                End If
                Return ElementHelper._ratingImages
            End Get
        End Property
        Public Shared ReadOnly Property RatingLargeImages() As ImageCollection
            Get
                If Object.Equals(ElementHelper._ratingLargeImages, Nothing) Then
                    ElementHelper._ratingLargeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("RatingsLarge.png", GetType(ImagesHelper).Assembly, New Size(250, 37))
                End If
                Return ElementHelper._ratingLargeImages
            End Get
        End Property
        Public Shared ReadOnly Property FolderIcons() As ImageCollection
            Get
                If Object.Equals(ElementHelper._folderIcons, Nothing) Then
                    ElementHelper._folderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("FolderIcons16x16.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._folderIcons
            End Get
        End Property
        Public Shared ReadOnly Property DiskIcons() As ImageCollection
            Get
                If Object.Equals(ElementHelper._diskIcons, Nothing) Then
                    ElementHelper._diskIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DiskFormats.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
                End If
                Return ElementHelper._diskIcons
            End Get
        End Property
        Public Shared ReadOnly Property ColumnHeaderIcons() As ImageCollection
            Get
                If Object.Equals(ElementHelper._columnHeaderIcons, Nothing) Then
                    Dim prefix As String = String.Empty '""
                    ElementHelper._columnHeaderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(String.Format("{0}ColumnHeaderImages.png", prefix), GetType(ImagesHelper).Assembly, New Size(13, 13))
                End If
                Return ElementHelper._columnHeaderIcons
            End Get
        End Property
		Public Shared ReadOnly Property AppIcon() As Icon
			Get
                If Object.Equals(ElementHelper._AppIcon, Nothing) Then
                    ElementHelper._AppIcon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(ElementHelper).Assembly)
                End If
                Return ElementHelper._AppIcon
			End Get
		End Property
#If DebugTest Then
		Private Shared fimagesForTests As ImageCollection = Nothing
		Public Shared ReadOnly Property ImagesForTests() As ImageCollection
			Get
				If Object.Equals(ElementHelper.fimagesForTests, Nothing) Then
					ElementHelper.fimagesForTests = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("FolderIcons16x16.png", GetType(ImagesHelper).Assembly, New Size(16, 16))
				End If
                Return ElementHelper.fimagesForTests
			End Get
		End Property
#End If
        Public Shared FontItalic As New Font("Tahoma", 8, FontStyle.Italic)
        Public Shared FontBold As New Font("Tahoma", 8, FontStyle.Bold)
        Public Shared Function MovieItemFormatName(ByVal format As Nullable(Of MovieItemFormat)) As String
            If Object.Equals(format, Nothing) Then
                Return ConstStrings.AllFormats
            Else
                Return MasterDetailHelper.SplitPascalCaseString(format.ToString())
            End If
        End Function
        Public Shared Function GetSingleLineString(ByVal text As String) As String
            Dim index As Integer = text.IndexOf(Constants.vbCrLf)
            If index <> -1 Then
                Return text.Substring(0, index)
            End If
            Return text
        End Function
    End Class
    Public Class ValidationRulesHelper
        Private Shared fruleIsNotBlank As ConditionValidationRule = Nothing
        Private Shared fruleGreaterOrEqualZero As ConditionValidationRule = Nothing
        Public Shared ReadOnly Property RuleIsNotBlank() As ConditionValidationRule
            Get
                If Object.Equals(fruleIsNotBlank, Nothing) Then
                    fruleIsNotBlank = New ConditionValidationRule()
                    fruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank
                    fruleIsNotBlank.ErrorText = ConstStrings.RuleIsNotBlankWarning
                    fruleIsNotBlank.ErrorType = ErrorType.Critical
                End If
                Return fruleIsNotBlank
            End Get
        End Property
        Public Shared ReadOnly Property RuleGreaterOrEqualZero() As ConditionValidationRule
            Get
                If Object.Equals(fruleGreaterOrEqualZero, Nothing) Then
                    fruleGreaterOrEqualZero = New ConditionValidationRule()
                    fruleGreaterOrEqualZero.ConditionOperator = ConditionOperator.GreaterOrEqual
                    fruleGreaterOrEqualZero.Value1 = 0
                    fruleGreaterOrEqualZero.ErrorText = ConstStrings.RuleGreaterOrEqualZeroWarning
                    fruleGreaterOrEqualZero.ErrorType = ErrorType.Critical
                End If
                Return fruleGreaterOrEqualZero
            End Get
        End Property
        Public Shared Function RuleGreaterOrEqual(ByVal value As Integer) As ConditionValidationRule
            Dim ret As New ConditionValidationRule()
            ret.ConditionOperator = ConditionOperator.GreaterOrEqual
            ret.Value1 = value
            ret.ErrorText = ConstStrings.RuleGreaterOrEqualZeroWarning
            ret.ErrorType = ErrorType.Critical
            Return ret
        End Function
    End Class
	Public Class EditorHelper
		Public Shared Function CreateCardNumberTextEdit(ByVal collection As RepositoryItemCollection) As RepositoryItemTextEdit
			Return CreateCardNumberTextEdit(Nothing, collection)
		End Function
		Public Shared Function CreateCardNumberTextEdit(ByVal edit As RepositoryItemTextEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemTextEdit
			Dim ret As RepositoryItemTextEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemTextEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.Mask.EditMask = "d6"
			ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			ret.Mask.UseMaskAsDisplayFormat = True
			Return ret
		End Function
		Public Shared Function CreatePaymentTextEdit(ByVal collection As RepositoryItemCollection) As RepositoryItemTextEdit
			Dim ret As New RepositoryItemTextEdit()
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.Mask.EditMask = "c"
			ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			ret.Mask.UseMaskAsDisplayFormat = True
			Return ret
		End Function
		Public Shared Function CreateGenderImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateGenderImageComboBox(Nothing, True, collection)
		End Function
		Public Shared Function CreateGenderImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateGenderImageComboBox(edit, False, collection)
		End Function
		Public Shared Function CreateGenderImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal center As Boolean, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(PersonGender))
			ret.Items.Clear()
			For Each gender As PersonGender In arr
				ret.Items.Add(New ImageComboBoxItem(gender.ToString(), gender, GetPersonImages(gender)))
			Next gender
			ret.SmallImages = ElementHelper.PersonImages
			If center Then
				ret.GlyphAlignment = HorzAlignment.Center
			End If
			Return ret
		End Function
		Private Shared Function GetPersonImages(ByVal gender As PersonGender) As Integer
            If Object.Equals(gender, PersonGender.Female) Then
                Return 1
            End If
			Return 0
		End Function
		Public Shared Function CreateRatingImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateRatingImageComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateRatingImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(MovieRating))
			ret.Items.Clear()
			For Each rating As MovieRating In arr
				ret.Items.Add(New ImageComboBoxItem(GetRatingString(rating), rating, CInt(Fix(rating))))
			Next rating
			ret.SmallImages = ElementHelper.RatingImages
			ret.LargeImages = ElementHelper.RatingLargeImages
			ret.GlyphAlignment = HorzAlignment.Center
			Return ret
		End Function
		Public Shared Function CreateMovieItemFormatImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateMovieItemFormatImageComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateMovieItemFormatImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(MovieItemFormat))
			ret.Items.Clear()
			For Each format As MovieItemFormat In arr
				ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(format.ToString()), format, CInt(Fix(format)) - 1))
			Next format
			ret.SmallImages = ElementHelper.DiskIcons
			Return ret
		End Function
		Public Shared Function CreateMovieItemStatusImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateMovieItemStatusImageComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateMovieItemStatusImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(MovieItemStatus))
			ret.Items.Clear()
			For Each status As MovieItemStatus In arr
				ret.Items.Add(New ImageComboBoxItem(MasterDetailHelper.SplitPascalCaseString(status.ToString()), status, CInt(Fix(status))))
			Next status
			Return ret
		End Function
		Public Shared Function CreateDiscountLevelImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateDiscountLevelImageComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateDiscountLevelImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(CustomerDiscountLevel))
			ret.Items.Clear()
			For Each level As CustomerDiscountLevel In arr
				ret.Items.Add(New ImageComboBoxItem(GetStringByCustomerDiscountLevel(level), level, -1))
			Next level
			Return ret
		End Function
		Public Shared Function GetStringByCustomerDiscountLevel(ByVal level As CustomerDiscountLevel) As String
			Dim ret As String = MasterDetailHelper.SplitPascalCaseString(level.ToString())
			ret = ret.Replace(" ", "-")
			Return String.Format(ConstStrings.RenterDiscount, ret)
		End Function
		Public Shared Function CreateReceiptTypeImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Return CreateReceiptTypeImageComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateReceiptTypeImageComboBox(ByVal edit As RepositoryItemImageComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As RepositoryItemImageComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemImageComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(ReceiptType))
			ret.Items.Clear()
			For Each type As ReceiptType In arr
				ret.Items.Add(New ImageComboBoxItem(GetReceiptTypeString(type), type, CInt(Fix(type))))
			Next type
			ret.SmallImages = ElementHelper.ReceiptTypeImages
			Return ret
		End Function
		Public Shared Function CreateActiveRentTypeImageComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemImageComboBox
			Dim ret As New RepositoryItemImageComboBox()
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			Dim arr As Array = System.Enum.GetValues(GetType(ActiveRentType))
			ret.Items.Clear()
			For Each type As ActiveRentType In arr
				ret.Items.Add(New ImageComboBoxItem(type.ToString(), type, CInt(Fix(type)) - 1))
			Next type
			ret.SmallImages = ElementHelper.ActiveRentTypeImages
			ret.GlyphAlignment = HorzAlignment.Center
			Return ret
		End Function
		Public Shared Function CreateLocationComboBox(ByVal collection As RepositoryItemCollection) As RepositoryItemComboBox
			Return CreateLocationComboBox(Nothing, collection)
		End Function
		Public Shared Function CreateLocationComboBox(ByVal edit As RepositoryItemComboBox, ByVal collection As RepositoryItemCollection) As RepositoryItemComboBox
			Dim ret As RepositoryItemComboBox
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemComboBox()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.Items.Clear()
			For i As Integer = 1 To ReferenceData.ShelvesCount
				ret.Items.Add(String.Format("Shelf #{0}", i))
			Next i
			Return ret
		End Function
		Public Shared Function GetReceiptTypeString(ByVal type As ReceiptType) As String
			Return MasterDetailHelper.SplitPascalCaseString(type.ToString())
		End Function
		Public Shared Function CreateDiscountTextEdit() As RepositoryItemTextEdit
			Return CreateDiscountTextEdit(Nothing)
		End Function
		Public Shared Function CreateDiscountTextEdit(ByVal edit As RepositoryItemTextEdit) As RepositoryItemTextEdit
			Dim ret As RepositoryItemTextEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemTextEdit()
			Else
				ret = edit
			End If
			ret.Appearance.TextOptions.HAlignment = HorzAlignment.Far
			ret.Mask.EditMask = "p"
			ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			ret.Mask.UseMaskAsDisplayFormat = True
			Return ret
		End Function
		Private Shared Function GetRatingString(ByVal rating As MovieRating) As String
			Return rating.ToString().Replace("1", "-1")
		End Function
		Public Shared Function CreateCountryLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
			Return CreateCountryLookUpEdit(session, Nothing, collection, key)
		End Function
		Public Shared Function CreateCountryLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateCountryLookUpEdit(session, edit, collection, False)
		End Function
		Public Shared Function CreateCountryLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			If key Then
				ret.ValueMember = "Oid"
			Else
				ret.ValueMember = "This"
			End If
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of Country)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.NullText = String.Empty
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name"))
			ret.TextEditStyle = TextEditStyles.DisableTextEditor
			ret.ShowHeader = False
			ret.ShowFooter = False
			ret.DropDownRows = 14
			ret.AllowNullInput = DefaultBoolean.True
			Return ret
		End Function
		Public Shared Function CreateLanguageLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
			Return CreateLanguageLookUpEdit(session, Nothing, collection, key)
		End Function
		Public Shared Function CreateLanguageLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateLanguageLookUpEdit(session, edit, collection, False)
		End Function
		Public Shared Function CreateLanguageLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			If key Then
				ret.ValueMember = "Oid"
			Else
				ret.ValueMember = "This"
			End If
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of Language)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.NullText = String.Empty
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name"))
			ret.ShowHeader = False
			ret.DropDownRows = 9
			Return ret
		End Function
		Public Shared Function CreateArtistGridLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemGridLookUpEdit
			Return CreateArtistGridLookUpEdit(session, Nothing, collection)
		End Function
		Public Shared Function CreateArtistGridLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemGridLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemGridLookUpEdit
			Dim ret As RepositoryItemGridLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemGridLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.AllowNullInput = DefaultBoolean.False
			ret.ValueMember = "This"
			ret.DisplayMember = "FullName"
			ret.PopupFormSize = New Size(350, 220)
			If Object.Equals(ret.View, Nothing) Then
				ret.View = New GridView()
			End If
			Dim colFullName As New GridColumn()
			Dim colBirthDate As New GridColumn()
			Dim colGender As New GridColumn()
			'colFullName
			colFullName.FieldName = "FullName"
			colFullName.VisibleIndex = 1
			colFullName.Width = 664
			' colBirthDate
			colBirthDate.FieldName = "BirthDate"
			colBirthDate.VisibleIndex = 2
			colBirthDate.Width = 289
			' colGender
			colGender.FieldName = "Gender"
			colGender.OptionsColumn.FixedWidth = True
			colGender.VisibleIndex = 0
			colGender.Width = 57
			colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(ret.View.GridControl.RepositoryItems)
			'
			ret.View.Columns.Clear()
			ret.View.Columns.Add(colGender)
			ret.View.Columns.Add(colFullName)
			ret.View.Columns.Add(colBirthDate)
			ret.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			ret.View.OptionsSelection.EnableAppearanceFocusedCell = False
			ret.View.OptionsView.ShowGroupPanel = False
			ret.View.OptionsView.ShowIndicator = False
            ret.View.OptionsView.ShowVerticalLines = DefaultBoolean.False
            ret.DataSource = New XPCollection(Of Artist)(session, Nothing, New SortProperty("FullName", DevExpress.Xpo.DB.SortingDirection.Ascending))
            Return ret
        End Function
        Public Shared Function CreateMovieGridLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemGridLookUpEdit
            Return CreateMovieGridLookUpEdit(session, Nothing, collection)
        End Function
        Public Shared Function CreateMovieGridLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemGridLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemGridLookUpEdit
            Dim ret As RepositoryItemGridLookUpEdit
            If Object.Equals(edit, Nothing) Then
                ret = New RepositoryItemGridLookUpEdit()
            Else
                ret = edit
            End If
            If (Not Object.Equals(collection, Nothing)) Then
                collection.Add(ret)
            End If
            ret.AllowNullInput = DefaultBoolean.False
            ret.ValueMember = "This"
            ret.DisplayMember = "Title"
            ret.PopupFormSize = New Size(450, 220)
            If Object.Equals(ret.View, Nothing) Then
                ret.View = New GridView()
            End If
            Dim colTitle As New GridColumn()
            Dim colReleaseDate As New GridColumn()
            Dim colRating As New GridColumn()
            'colTitle
            colTitle.FieldName = "Title"
            colTitle.VisibleIndex = 0
            colTitle.Width = 400
            ' colReleaseDate
            colReleaseDate.FieldName = "ReleaseDate"
            colReleaseDate.VisibleIndex = 1
            colReleaseDate.Width = 120
            ' colRating
            colRating.FieldName = "Rating"
            colRating.VisibleIndex = 2
            colRating.Width = 100
            colRating.ColumnEdit = EditorHelper.CreateRatingImageComboBox(ret.View.GridControl.RepositoryItems)
            '
            ret.View.Columns.Clear()
            ret.View.Columns.Add(colTitle)
            ret.View.Columns.Add(colReleaseDate)
            ret.View.Columns.Add(colRating)
            ret.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            ret.View.OptionsSelection.EnableAppearanceFocusedCell = False
            ret.View.OptionsView.ShowGroupPanel = False
            ret.View.OptionsView.ShowIndicator = False
            ret.View.OptionsView.ShowVerticalLines = DefaultBoolean.False
            ret.DataSource = New XPCollection(Of Movie)(session, Nothing, New SortProperty("Title", DevExpress.Xpo.DB.SortingDirection.Ascending))
            Return ret
        End Function
		Public Shared Function CreateMovieArtistLineLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateMovieArtistLineLookUpEdit(session, Nothing, collection)
		End Function
		Public Shared Function CreateMovieArtistLineLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.AllowNullInput = DefaultBoolean.False
			ret.ValueMember = "This"
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of MovieArtistLine)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name"))
			ret.ShowHeader = False
			ret.DropDownRows = 14
			Return ret
		End Function
		Public Shared Function CreateCompanyLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateCompanyLookUpEdit(session, Nothing, collection)
		End Function
		Public Shared Function CreateCompanyLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.AllowNullInput = DefaultBoolean.False
			ret.ValueMember = "This"
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of Company)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name", 100, "Company"))
			ret.Columns.Add(New LookUpColumnInfo("TypeName", 70, "Type"))
			ret.NullText = String.Empty
			ret.DropDownRows = 10
			Return ret
		End Function
		Public Shared Function CreateMovieCountriesCheckedComboBox(ByVal session As Session) As RepositoryItemCheckedComboBoxEdit
			Return CreateMovieCountriesCheckedComboBox(session, Nothing)
		End Function
		Public Shared Function CreateMovieCountriesCheckedComboBox(ByVal session As Session, ByVal edit As RepositoryItemCheckedComboBoxEdit) As RepositoryItemCheckedComboBoxEdit
			Dim ret As RepositoryItemCheckedComboBoxEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemCheckedComboBoxEdit()
			Else
				ret = edit
			End If
			ret.ValueMember = "Acronym"
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of Country)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.DropDownRows = 10
			Return ret
		End Function
		Public Shared Function CreateMovieCategoryLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateMovieCategoryLookUpEdit(session, Nothing, collection)
		End Function
		Public Shared Function CreateMovieCategoryLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.ValueMember = "This"
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of MovieCategory)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name"))
			ret.DropDownRows = 10
			Return ret
		End Function
		Public Shared Function CreateCompanyTypeLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection) As RepositoryItemLookUpEdit
			Return CreateCompanyTypeLookUpEdit(session, edit, collection, False)
		End Function
		Public Shared Function CreateCompanyTypeLookUpEdit(ByVal session As Session, ByVal edit As RepositoryItemLookUpEdit, ByVal collection As RepositoryItemCollection, ByVal key As Boolean) As RepositoryItemLookUpEdit
			Dim ret As RepositoryItemLookUpEdit
			If Object.Equals(edit, Nothing) Then
				ret = New RepositoryItemLookUpEdit()
			Else
				ret = edit
			End If
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			If key Then
				ret.ValueMember = "Oid"
			Else
				ret.ValueMember = "This"
			End If
			ret.DisplayMember = "Name"
			ret.DataSource = New XPCollection(Of CompanyType)(session, Nothing, New SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending))
			ret.Columns.Clear()
			ret.Columns.Add(New LookUpColumnInfo("Name"))
			ret.TextEditStyle = TextEditStyles.DisableTextEditor
			ret.ShowHeader = False
			ret.ShowFooter = False
			ret.DropDownRows = 7
			ret.AllowNullInput = DefaultBoolean.True
			Return ret
		End Function
		Public Shared Function CreateCustomerGridLookUpEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemGridLookUpEdit
			Dim ret As New RepositoryItemGridLookUpEdit()
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.ValueMember = "This"
			ret.DisplayMember = "FullName"
			ret.DataSource = New XPCollection(Of Customer)(session, Nothing, New SortProperty("FullName", DevExpress.Xpo.DB.SortingDirection.Ascending))
			Return ret
		End Function
		Public Shared Function CreateMovieItemPriceSpinEdit(ByVal session As Session, ByVal collection As RepositoryItemCollection) As RepositoryItemSpinEdit
			Dim ret As New RepositoryItemSpinEdit()
			If (Not Object.Equals(collection, Nothing)) Then
				collection.Add(ret)
			End If
			ret.Mask.EditMask = "c"
			ret.Mask.UseMaskAsDisplayFormat = True
			ret.MinValue = 0
			ret.MaxValue = 100000
			Return ret
		End Function
	End Class
	Public Class ColorHelper
		Public Shared Sub UpdateColor(ByVal collection As ImageCollection, ByVal lf As UserLookAndFeel)
			For i As Integer = 0 To collection.Images.Count - 1
				collection.Images(i) = SetColor(TryCast(collection.Images(i), Bitmap), GetHeaderForeColor(lf))
			Next i
		End Sub
		Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
			Dim ret As Color = SystemColors.ControlText
			If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
				Return ret
			End If
			Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
		End Function
		Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
			For i As Integer = 0 To bmp.Width - 1
				For j As Integer = 0 To bmp.Height - 1
					If bmp.GetPixel(i, j).Name <> "0" Then
						bmp.SetPixel(i, j, color)
					End If
				Next j
			Next i
			Return bmp
		End Function
	End Class
	Public Class ImageCreator
		Public Shared Function CreateImage(ByVal srcImage As Image, ByVal maxWidth As Integer, ByVal maxHeight As Integer) As Image
			If Object.Equals(srcImage, Nothing) Then
				Return Nothing
			End If
			Dim size As Size = GetPhotoSize(srcImage, maxWidth, maxHeight)
			Dim ret As Image = New Bitmap(size.Width, size.Height)
			Using gr As Graphics = Graphics.FromImage(ret)
				gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
				gr.DrawImage(srcImage, New Rectangle(0, 0, size.Width, size.Height))
			End Using
			Return ret
		End Function
		Private Shared Function GetPhotoSize(ByVal image As Image, ByVal maxWidth As Integer, ByVal maxHeight As Integer) As Size
			Dim width As Integer = Math.Min(maxWidth, image.Width), height As Integer = width * image.Height \ image.Width
			If height > maxHeight Then
				height = maxHeight
				width = height * image.Width \ image.Height
			End If
			Return New Size(width, height)
		End Function
		Public Shared Function GetZoomDestRectangle(ByVal r As Rectangle, ByVal img As Image) As Rectangle
			Dim horzRatio As Single = Math.Min(CSng(r.Width) / img.Width, 1)
			Dim vertRatio As Single = Math.Min(CSng(r.Height) / img.Height, 1)
			Dim zoomRatio As Single = Math.Min(horzRatio, vertRatio)

            Return New Rectangle(r.Left + CInt(Fix(r.Width - img.Width * zoomRatio) / 2), r.Top + CInt(Fix(r.Height - img.Height * zoomRatio) / 2), CInt(Fix(img.Width * zoomRatio)), CInt(Fix(img.Height * zoomRatio)))
		End Function
	End Class
	Public Class DateHelper
		Public Shared Function GetStartDateForMonths(ByVal count As Integer) As DateTime
			Dim dt As DateTime = DateTime.Now.AddMonths(count)
			Return New DateTime(dt.Year, dt.Month, 1)
		End Function
	End Class
End Namespace

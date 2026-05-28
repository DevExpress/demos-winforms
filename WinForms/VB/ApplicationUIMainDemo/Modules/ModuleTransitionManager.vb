Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Linq
Imports System.Reflection
Imports System.Security
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ModuleTransitionManager
        Inherits TutorialControl

        Private EasingFunction As String() = New String() {"BackEase", "ElasticEase", "PowerEase", "QuadraticEase", "SineEase", "ExponentialEase", "CircleEase", "BounceEase", "CubicEase"}

        Private Images As String() = New String() {"TransitionManagerData\(Athens)-Academy-of-Athens.jpg", "TransitionManagerData\(Barcelona)-Camp-Nou.jpg", "TransitionManagerData\(Berlin)-Brandenburg-Gate.jpg", "TransitionManagerData\(Cairo)-Cairo-Citadel.jpg", "TransitionManagerData\(Los-Angeles)-Downtown.jpg", "TransitionManagerData\(London)-St-Paul's-Cathedral.jpg", "TransitionManagerData\(Los-Angeles)-Downtown.jpg", "TransitionManagerData\(Moscow)-Bolshoi-Theatre.jpg", "TransitionManagerData\(New-York)-Brooklyn-Bridge.jpg", "TransitionManagerData\(Paris)-Arc-de-Triomphe.jpg"}

        Private switchTimer As Timer

        Private delayTimer As Timer

        Private Locked As Boolean

        Private isTransition As Boolean

        Private functions As Dictionary(Of String, IEasingFunction) = New Dictionary(Of String, IEasingFunction)()

        Public Sub New()
            InitializeComponent()
            Init()
            isTransition = False
            switchTimer = New Timer()
            delayTimer = New Timer()
            switchTimer.Interval = 1000
            delayTimer.Interval = 1000
            AddHandler switchTimer.Tick, AddressOf OnSwitchTimerTick
            AddHandler delayTimer.Tick, AddressOf OnDelayTimerTick
            AddHandler pictureEdit.PopupMenuShowing, AddressOf OnPopupMenuShowing
            AddHandler transitionManager.AfterTransitionEnds, AddressOf transitionManager_AfterTransitionEnds
            InitImages()
            InitEasyFunctions()
            pictureEdit.Image = galleryControl1.Gallery.GetAllItems()(0).Image
            AddHandler galleryControl1.Gallery.ItemCheckedChanged, AddressOf galleryControl1_Gallery_ItemCheckedChanged
            switchTimer.Start()
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            Dim form = FindForm()
            If form IsNot Nothing Then
                AddHandler form.Deactivate, AddressOf OnDeactivate
                AddHandler form.Activated, AddressOf OnActivated
            End If
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            MyBase.OnHandleDestroyed(e)
            Dim form = FindForm()
            If form IsNot Nothing Then
                RemoveHandler form.Deactivate, AddressOf OnDeactivate
                RemoveHandler form.Activated, AddressOf OnActivated
            End If
        End Sub

        Private isDeactivated As Boolean = False

        Private Sub OnDeactivate(ByVal sender As Object, ByVal e As EventArgs)
            If Not isDeactivated Then switchTimer.Stop()
            isDeactivated = True
        End Sub

        Private Sub OnActivated(ByVal sender As Object, ByVal e As EventArgs)
            If isDeactivated AndAlso Visible Then switchTimer.Start()
            isDeactivated = False
        End Sub

        Private Sub OnPopupMenuShowing(ByVal sender As Object, ByVal e As XtraEditors.Events.PopupMenuShowingEventArgs)
            e.Cancel = True
        End Sub

        Private Sub InitImages()
            Dim galleryGroup = galleryControl1.Gallery.Groups(0)
            For count As Integer = 0 To Images.Count() - 1
                Dim path As String = GetRelativePath(Images(count))
                Dim image As Image = Nothing
                If Not String.IsNullOrEmpty(path) Then
                    image = Image.FromFile(path)
                    Call NormalizeImageAlpha(CType(image, Bitmap))
                End If

                galleryGroup.Items.Add(New GalleryItem(image, String.Empty, String.Empty))
            Next

            galleryGroup.Items(0).Checked = True
        End Sub

        <SecuritySafeCritical>
        Private Shared Sub NormalizeImageAlpha(ByVal bitmap As Bitmap)
            Dim rect = New Rectangle(0, 0, bitmap.Width, bitmap.Height)
            Dim bmpData As BitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb)
            Try
                NormalizeBitmapDataAlpha(rect, bmpData)
            Finally
                bitmap.UnlockBits(bmpData)
            End Try
        End Sub

        Private Shared Sub NormalizeBitmapDataAlpha(ByVal rect As Rectangle, ByVal bmpData As BitmapData)
            Dim offset As Integer = 0
            Dim length As Integer = rect.Width * rect.Height
            Dim intSize As Integer = 4 ' sizeof(int);
            For i As Integer = 0 To length - 1
                NormalizeAlpha(bmpData, offset)
                offset += intSize
            Next
        End Sub

        <SecuritySafeCritical>
        Private Shared Sub NormalizeAlpha(ByVal bmpData As BitmapData, ByVal offset As Integer)
            Dim argb As Integer = Runtime.InteropServices.Marshal.ReadInt32(bmpData.Scan0, offset)
            Dim color As Color = Color.FromArgb(argb)
            If color.A < 255 Then
                color = Color.FromArgb(255, color)
                Runtime.InteropServices.Marshal.WriteInt32(bmpData.Scan0, offset, color.ToArgb())
            End If
        End Sub

        Private Sub transitionManager_AfterTransitionEnds(ByVal transition As ITransition, ByVal e As EventArgs)
            isTransition = False
        End Sub

        Private Sub OnDelayTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If DemoHelper.IsTesting Then Return
            pictureEdit.Image = galleryControl1.Gallery.GetCheckedItem().Image
            delayTimer.Stop()
            If isTransition Then
                transitionManager.EndTransition()
            End If

            If Visible AndAlso Not isDeactivated AndAlso Not customIndicatorActive Then switchTimer.Start()
        End Sub

        Private Sub Init()
            cbEasingMode.Properties.Items.AddEnum(GetType(EasingMode))
            cbEasingMode.SelectedIndex = 0
            cbShowWaitIndicator.Properties.Items.AddEnum(GetType(Utils.DefaultBoolean))
            cbShowWaitIndicator.SelectedIndex = 2
            cbTransitionType.Properties.Items.AddEnum(GetType(Transitions))
            cbTransitionType.SelectedIndex = 0
            cbEasingFunction.Properties.Items.AddRange(EasingFunction)
            cbEasingFunction.SelectedIndex = 0
            cbWaitingIndicatorType.Properties.Items.AddEnum(GetType(WaitingAnimatorType))
            cbWaitingIndicatorType.SelectedIndex = 0
        End Sub

        Private Sub InitEasyFunctions()
            functions.Add("BackEase", New BackEase())
            functions.Add("ElasticEase", New ElasticEase())
            functions.Add("PowerEase", New PowerEase(1))
            functions.Add("QuadraticEase", New QuadraticEase())
            functions.Add("QuinticEase", New QuinticEase())
            functions.Add("SineEase", New SineEase())
            functions.Add("ExponentialEase", New ExponentialEase())
            functions.Add("CircleEase", New CircleEase())
            functions.Add("BounceEase", New BounceEase())
            functions.Add("CubicEase", New CubicEase())
        End Sub

        Private Sub transitionManager_CustomTransition(ByVal transition As ITransition, ByVal e As CustomTransitionEventArgs)
            If transition.Control Is pictureEdit Then e.EasingFunction = functions(cbEasingFunction.Text)
        End Sub

        Private Sub OnSwitchTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If DemoHelper.IsTesting Then Return
            switchTimer.Interval = 4000
            If Not isTransition Then
                Dim galleryItems As List(Of GalleryItem) = galleryControl1.Gallery.GetAllItems()
                Dim currentIndex As Integer = galleryItems.IndexOf(galleryControl1.Gallery.GetCheckedItem())
                Dim nextIndex As Integer = If(currentIndex = galleryItems.Count - 1, 0, currentIndex + 1)
                galleryControl1.Gallery.SetItemCheck(galleryItems(nextIndex), True)
            End If
        End Sub

        Private Sub galleryControl1_Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            switchTimer.Stop()
            transitionManager.StartTransition(pictureEdit)
            isTransition = True
            delayTimer.Start()
        End Sub

        Private Sub InitTransitionParameters()
            Locked = True
            checkVertical.Enabled = EnableParametrs("Vertical")
            checkInward.Enabled = EnableParametrs("Inward")
            checkUnCover.Enabled = EnableParametrs("UnCover")
            seStripeCount.Enabled = EnableParametrs("StripeCount")
            ceBackground.Enabled = EnableParametrs("Background")
            cbEffectOptions.Enabled = EnableParametrs("EffectOptions")
            ResetTransitionParameters()
            Locked = False
        End Sub

        Private Sub ResetTransitionParameters()
            checkUnCover.Checked = False
            checkInward.Checked = checkUnCover.Checked
            checkVertical.Checked = checkInward.Checked
            seFrameInterval.Value = 0
            seFrameCount.Value = seFrameInterval.Value
            seStripeCount.Value = seFrameCount.Value
            ceBackground.Color = Color.Empty
            cbEffectOptions.Properties.Items.Clear()
            Dim info As PropertyInfo = AnimationParameters.GetType().GetProperty("EffectOptions")
            If info IsNot Nothing Then
                cbEffectOptions.Properties.Items.AddEnum(info.PropertyType)
                cbEffectOptions.SelectedIndex = 0
            End If
        End Sub

        Private Function EnableParametrs(ByVal propertyName As String) As Boolean
            Dim info As PropertyInfo = AnimationParameters.GetType().GetProperty(propertyName)
            Return info IsNot Nothing
        End Function

        Private ReadOnly Property AnimationParameters As IAnimationParameters
            Get
                If Transition Is Nothing Then Return Nothing
                Return Transition.TransitionType.Parameters
            End Get
        End Property

        Private ReadOnly Property Transition As ITransition
            Get
                Return transitionManager.Transitions(pictureEdit)
            End Get
        End Property

        Private Sub cbShowWaitIndicator_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Locked Then Return
            Transition.ShowWaitingIndicator = CType(cbShowWaitIndicator.SelectedIndex, Utils.DefaultBoolean)
            If delayTimer IsNot Nothing Then
                If CType(cbShowWaitIndicator.SelectedIndex, Utils.DefaultBoolean) = Utils.DefaultBoolean.False Then
                    delayTimer.Interval = 1
                Else
                    delayTimer.Interval = 1000
                End If
            End If
        End Sub

        Private Sub cbEasingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Locked Then Return
            Transition.EasingMode = CType(cbEasingMode.SelectedIndex, EasingMode)
        End Sub

        Private Sub cbTransitionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Locked Then Return
            Transition.TransitionType = CreateInstance(CType(cbTransitionType.SelectedIndex, Transitions))
            InitTransitionParameters()
        End Sub

        Private Sub seFrameInterval_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("FrameInterval", CType(seFrameInterval.Value, Integer?))
        End Sub

        Private Sub seFrameCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("FrameCount", CType(seFrameCount.Value, Integer?))
        End Sub

        Private Sub cbEffectOptions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("EffectOptions", cbEffectOptions.SelectedIndex)
        End Sub

        Private Sub ceBackground_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("Background", ceBackground.Color)
        End Sub

        Private Sub seStripeCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("StripeCount", CInt(seStripeCount.Value))
        End Sub

        Private Sub checkVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("Vertical", checkVertical.Checked)
        End Sub

        Private Sub checkInward_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("Inward", checkInward.Checked)
        End Sub

        Private Sub checkUnCover_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TransitionParameterChange("UnCover", checkUnCover.Checked)
        End Sub

        Private Sub TransitionParameterChange(ByVal paramName As String, ByVal value As Object)
            SetTransitionParameter(AnimationParameters, paramName, value)
        End Sub

        Private Sub SetTransitionParameter(ByVal parameters As IAnimationParameters, ByVal propertyName As String, ByVal value As Object)
            If Locked OrElse parameters Is Nothing Then Return
            Dim info As PropertyInfo = parameters.GetType().GetProperty(propertyName)
            If info Is Nothing Then Return
            info.SetValue(parameters, value, Nothing)
        End Sub

        Private Function CreateInstance(ByVal transition As Transitions) As BaseTransition
            Select Case transition
                Case Transitions.Dissolve
                    Return New DissolveTransition()
                Case Transitions.Fade
                    Return New FadeTransition()
                Case Transitions.Shape
                    Return New ShapeTransition()
                Case Transitions.Clock
                    Return New ClockTransition()
                Case Transitions.SlideFade
                    Return New SlideFadeTransition()
                Case Transitions.Cover
                    Return New CoverTransition()
                Case Transitions.Comb
                    Return New CombTransition()
                Case Else
                    Return New PushTransition()
            End Select
        End Function

        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            MyBase.OnVisibleChanged(e)
            If Not Visible Then
                switchTimer.Stop()
                If customIndicatorActive Then
                    StopWaitingIndicator()
                End If
            Else
                switchTimer.Start()
            End If
        End Sub

        Private customIndicatorActive As Boolean = False

        Private Sub btnCustomIndicator_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not customIndicatorActive Then
                switchTimer.Stop()
                If isTransition Then transitionManager.EndTransition()
                StartWaitingIndicator()
            Else
                switchTimer.Start()
                StopWaitingIndicator()
            End If
        End Sub

        Private Sub StopWaitingIndicator()
            transitionManager.StopWaitingIndicator()
            galleryControl1.Enabled = True
            customIndicatorActive = False
            btnWaitingIndicator.Text = "Show waiting indicator"
        End Sub

        Private Sub StartWaitingIndicator()
            StartAnimator(cbWaitingIndicatorType.Text)
            galleryControl1.Enabled = False
            customIndicatorActive = True
            btnWaitingIndicator.Text = "Hide waiting indicator"
        End Sub

        Private Sub cbCustomIndicatorType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If customIndicatorActive Then
                transitionManager.StopWaitingIndicator()
                StartAnimator(cbWaitingIndicatorType.Text)
            End If

            Transition.WaitingAnimatorType = GetAnimatorType()
            If Transition.WaitingAnimatorType = WaitingAnimatorType.Line Then Transition.LineWaitingIndicatorProperties.ContentAlignment = ContentAlignment.TopCenter
            If Transition.WaitingAnimatorType = WaitingAnimatorType.Ring Then Transition.RingWaitingIndicatorProperties.ContentAlignment = ContentAlignment.MiddleCenter
        End Sub

        Private Function GetAnimatorType() As WaitingAnimatorType
            Return CType(cbWaitingIndicatorType.EditValue, WaitingAnimatorType)
        End Function

        Private Sub StartAnimator(ByVal typeString As String)
            Select Case CType(cbWaitingIndicatorType.EditValue, WaitingAnimatorType)
                Case WaitingAnimatorType.Line
                    transitionManager.StartWaitingIndicator(pictureEdit, New LineWaitingIndicatorProperties() With {.ContentAlignment = ContentAlignment.TopCenter, .Caption = "", .Description = ""})
                Case WaitingAnimatorType.Ring
                    transitionManager.StartWaitingIndicator(pictureEdit, New RingWaitingIndicatorProperties() With {.ContentAlignment = ContentAlignment.MiddleCenter, .Caption = "", .Description = ""})
                Case Else
                    transitionManager.StartWaitingIndicator(pictureEdit, New WaitingIndicatorProperties() With {.Caption = "", .Description = ""})
            End Select
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            RemoveHandler switchTimer.Tick, AddressOf OnSwitchTimerTick
            RemoveHandler delayTimer.Tick, AddressOf OnDelayTimerTick
            RemoveHandler pictureEdit.PopupMenuShowing, AddressOf OnPopupMenuShowing
            RemoveHandler transitionManager.AfterTransitionEnds, AddressOf transitionManager_AfterTransitionEnds
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

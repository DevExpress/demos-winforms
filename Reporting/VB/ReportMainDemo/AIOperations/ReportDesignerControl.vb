Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports RibbonReportDesigner

Namespace XtraReportsDemos.AIOperations

    Public Class AIReportDesignerControl
        Inherits ReportDesignerModuleBase

#Region "fields"
        Private ucDisclaimerPanel1 As ucDisclaimerPanel

#End Region
        Protected Overrides ReadOnly Property Title As String
            Get
                Return "AI-powered Report Designer"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            UpdateBottomSpacings()
        End Sub

        Protected Overrides Function GetFeatureInfos() As IEnumerable(Of FeatureTileInfo)
            Return {New FeatureTileInfo() With {.Caption = "Localization", .Description = "Use AI-powered localization to translate report content to a different language with a single click.
<href=https://docs.devexpress.com/XtraReports/405435>Learn More</href>", .Image = GetImage("LocalizationThumb")}, New FeatureTileInfo() With {.Caption = "Report Creation", .Description = "Run the Report Wizard to generate a new report layout based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405460>Learn More</href>", .Image = GetImage("WizardThumb")}, New FeatureTileInfo() With {.Caption = "Report Modification", .Description = "Chat with an AI Assistant to make adjustments to your report layout (available for .NET 8+).
<href=https://docs.devexpress.com/XtraReports/405498>Learn More</href>", .Image = GetImage("ChatThumb")}, New FeatureTileInfo() With {.Caption = "Test Data Preview", .Description = "Preview your report with AI-generated test data before connecting to a live source.
<href=https://docs.devexpress.com/XtraReports/405566>Learn More</href>", .Image = GetImage("FakeDataThumb")}, New FeatureTileInfo() With {.Caption = "Prompt-to-Expression", .Description = "Generate a data binding expression or a filter condition based on a natural language prompt.
<href=https://docs.devexpress.com/XtraReports/405646>Learn More</href>", .Image = GetImage("ExpressionsThumb")}}
        End Function

        Protected Overrides Function CreateDesignerForm() As MainFormBase
            Call RegisterIfNeeded()
            Return New AIReportDesignerForm()
        End Function

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateBottomSpacings()
        End Sub

        Protected Overrides Sub DoDpiChangeAfterParent()
            MyBase.DoDpiChangeAfterParent()
            UpdateBottomSpacings()
        End Sub

        Private Sub UpdateBottomSpacings()
            lciHeader.Spacing = New DevExpress.XtraLayout.Utils.Padding(lciHeader.Spacing.Left, lciHeader.Spacing.Right, lciHeader.Spacing.Top, -ucDisclaimerPanel1.RoundedPanelOffset \ 2)
        End Sub

        Private Shared Function GetImage(ByVal name As String) As Image
            Return ResourceImageHelperCore.CreateImageFromResources(String.Format("XtraReportsDemos.Resources.AI.{0}.png", name), GetType(AIReportDesignerForm).Assembly)
        End Function

#Region "Windows Form Designer generated code"
        Private Overloads Sub InitializeComponent()
            ucDisclaimerPanel1 = New ucDisclaimerPanel()
            CType(lcc, System.ComponentModel.ISupportInitialize).BeginInit()
            lcc.SuspendLayout()
            CType(lcgRoot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lciHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            ' lcc
            '
            lcc.Controls.Add(ucDisclaimerPanel1)
            lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1698, 338, 1687, 1183)
            lcc.Controls.SetChildIndex(ucDisclaimerPanel1, 0)
            '
            ' lciHeader
            '
            lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(255))))), (CInt(((CByte(192))))), (CInt(((CByte(192))))))
            lciHeader.AppearanceItemCaption.Options.UseBackColor = True
            lciHeader.Control = ucDisclaimerPanel1
            '
            ' ucDisclaimerPanel1
            '
            ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            ucDisclaimerPanel1.Size = New System.Drawing.Size(1568, 220)
            ucDisclaimerPanel1.TabIndex = 5
            '
            ' AIReportDesignerControl
            '
            Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Appearance.Options.UseFont = True
            Name = "AIReportDesignerControl"
            CType(lcc, System.ComponentModel.ISupportInitialize).EndInit()
            lcc.ResumeLayout(False)
            CType(lcgRoot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lciHeader, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace

Namespace DevExpress.HTML.Demos

    Partial Class PreviewToolTip

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.PreviewToolTip))
            Me.htmlTemplateCollection1 = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.templateSimpleToolTip = New DevExpress.Utils.Html.HtmlTemplate()
            Me.templateSimpleToolTipWithButton = New DevExpress.Utils.Html.HtmlTemplate()
            Me.templateStandardToolTip = New DevExpress.Utils.Html.HtmlTemplate()
            Me.SuspendLayout()
            ' 
            ' htmlTemplateCollection1
            ' 
            Me.htmlTemplateCollection1.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.templateSimpleToolTip, Me.templateSimpleToolTipWithButton, Me.templateStandardToolTip})
            ' 
            ' templateSimpleToolTip
            ' 
            Me.templateSimpleToolTip.Name = "templateSimpleToolTip"
            Me.templateSimpleToolTip.Styles = resources.GetString("templateSimpleToolTip.Styles")
            Me.templateSimpleToolTip.Tag = "Simple ToolTip"
            Me.templateSimpleToolTip.Template = "<div class=""container"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""item title"">${Title}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""it" & "em text"">${ToolTip}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            ' 
            ' templateSimpleToolTipWithButton
            ' 
            Me.templateSimpleToolTipWithButton.Name = "templateSimpleToolTipWithButton"
            Me.templateSimpleToolTipWithButton.Styles = resources.GetString("templateSimpleToolTipWithButton.Styles")
            Me.templateSimpleToolTipWithButton.Tag = "Simple ToolTip With Button"
            Me.templateSimpleToolTipWithButton.Template = resources.GetString("templateSimpleToolTipWithButton.Template")
            ' 
            ' templateStandardToolTip
            ' 
            Me.templateStandardToolTip.Name = "templateStandardToolTip"
            Me.templateStandardToolTip.Styles = resources.GetString("templateStandardToolTip.Styles")
            Me.templateStandardToolTip.Tag = "Standard Template"
            Me.templateStandardToolTip.Template = resources.GetString("templateStandardToolTip.Template")
            ' 
            ' PreviewToolTip
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "PreviewToolTip"
            Me.Size = New System.Drawing.Size(726, 462)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlTemplateCollection1 As DevExpress.Utils.Html.HtmlTemplateCollection

        Private templateSimpleToolTipWithButton As DevExpress.Utils.Html.HtmlTemplate

        Private templateSimpleToolTip As DevExpress.Utils.Html.HtmlTemplate

        Private templateStandardToolTip As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

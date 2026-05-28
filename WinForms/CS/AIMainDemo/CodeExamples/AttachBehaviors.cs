namespace DevExpress.AI.Demos {
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.AIIntegration;
    using DevExpress.AIIntegration.Extensions;
    using DevExpress.AIIntegration.WinForms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.Utils.Behaviors;
    using DevExpress.XtraEditors;

    [CodeExampleClass("Attach Behavior", "AttachBehaviors.cs")]
    public static class AttachBehaviors {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MemoEdit memoEdit = new MemoEdit();
            memoEdit.Dock = DockStyle.Fill;
            memoEdit.Parent = sampleHost;
            memoEdit.Text = "DevExpress engineers feature-complete Presentation Controls, IDE Productivity Tools, Business Application Frameworks, and Reporting Systems for Visual Studio, Delphi, HTML5 or iOS & Android development. Whether using WPF, ASP.NET, WinForms, HTML5 or Windows 10, DevExpress tools help you build and deliver your best in the shortest time possible.";
            BehaviorManager behaviorManager = new BehaviorManager();
            List<IDisposable> disposables = new List<IDisposable>();
            disposables.Add(behaviorManager);
            sampleHost.Tag = disposables;
            return new object[] { memoEdit, behaviorManager, disposables };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var disposables = sampleHost.Tag as List<IDisposable>;
            if(disposables != null) {
                foreach(var disposable in disposables)
                    disposable.Dispose();
            }
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Attach simple behaviors in runtime")]
        [CodeExampleHighlightTokens("Attach", "ExplainBehavior", "ShortenBehavior", "ExpandBehavior", "ChangeToneBehavior", "ProofreadBehavior", "ChangeStyleBehavior")]
        public static void AttachSimpleBehavior(MemoEdit memoEdit, BehaviorManager behaviorManager, List<IDisposable> disposables) {
            behaviorManager.Attach<ExplainBehavior>(memoEdit);
            behaviorManager.Attach<ShortenBehavior>(memoEdit);
            behaviorManager.Attach<ExpandBehavior>(memoEdit);
            behaviorManager.Attach<ChangeToneBehavior>(memoEdit);
            behaviorManager.Attach<ProofreadBehavior>(memoEdit);
            behaviorManager.Attach<ChangeStyleBehavior>(memoEdit);
        }

        [CodeExampleCase("Attach translation behavior in runtime")]
        [CodeExampleHighlightTokens("Attach", "TranslateBehavior", "Languages", "LanguageInfo")]
        public static void AttachConfigurableBehavior(MemoEdit memoEdit, BehaviorManager behaviorManager, List<IDisposable> disposables) {
            behaviorManager.Attach<TranslateBehavior>(memoEdit, b => b.Properties.Languages = new LanguageInfo[] {
                new LanguageInfo("en"),
                new LanguageInfo("es"),
                new LanguageInfo("fr")
            });
        }

        [CodeExampleCase("Configure AIExtensions composition", new Type[] { typeof(ErnestHemingwayStyleExtension) })]
        [CodeExampleHighlightTokens("ProofreadRequest", "ProofreadBehavior", "ErnestHemingwayStyleExtension")]
        [CodeExampleUnderlineTokens("QueryIAIExtensionsContainer", "Container")]
        public static void UsingCompositionRoot(MemoEdit memoEdit, BehaviorManager behaviorManager, List<IDisposable> disposables) {
            // attach simple behaviors in runtime
            behaviorManager.Attach<ProofreadBehavior>(memoEdit);
            // prepare a local AIExtensionsContainer with customized
            var localContainer = new AIExtensionsContainerLocal(AIExtensionsContainerDesktop.Default);
            var disposable = localContainer.Register<ProofreadRequest, ErnestHemingwayStyleExtension>();
            disposables.Add(disposable);
            // configure AIExtensionsContainer's composition for specific control
            AIExtensionsContainerDesktop.QueryIAIExtensionsContainer += (s, e) => {
                if(e.Source == memoEdit)
                    e.Container = localContainer;
            };
        }

        [CodeExampleNestedClass]
        public class ErnestHemingwayStyleExtension : ProofreadExtension {
            public ErnestHemingwayStyleExtension(IServiceProvider serviceProvider)
                : base(serviceProvider) { }
            protected override string GetSystemPrompt(ProofreadRequest request) {
                return "Rewrite this text in the Ernest Hemingway style.";
            }
        }
    }
}

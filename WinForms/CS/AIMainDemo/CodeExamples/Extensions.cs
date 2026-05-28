#pragma warning disable CRR0033, CRR0029
namespace DevExpress.AI.Demos {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.AIIntegration;
    using DevExpress.AIIntegration.Extensions;
    using DevExpress.AIIntegration.WinForms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.Utils.Behaviors;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraEditors;

    [CodeExampleClass("Work with Extensions", "Extensions.cs")]
    public static class Extensions {
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
        [CodeExampleCase("Modify default extension", new Type[] { typeof(WilliamShakespeareStyleExtension) })]
        [CodeExampleHighlightTokens("ProofreadRequest", "ProofreadBehavior", "WilliamShakespeareStyleExtension")]
        [CodeExampleUnderlineTokens("Register")]
        public static void ModifyDefaultExtension(MemoEdit memoEdit, BehaviorManager behaviorManager, List<IDisposable> disposables) {
            var defaultContainer = AIExtensionsContainerDesktop.Default;
            var disposableToken = defaultContainer.Register<ProofreadRequest, WilliamShakespeareStyleExtension>();
            // Here we store the token to dispose at later stage
            disposables.Add(disposableToken); 
            behaviorManager.Attach<ProofreadBehavior>(memoEdit);
        }

        [CodeExampleCase("Create custom extension", new Type[] { typeof(AuthoredStyleExtension), typeof(AuthoredStyleRequest) })]
        [CodeExampleHighlightTokens("AuthoredStyleRequest", "AuthoredStyleRequest", "AIOverlayForm")]
        [CodeExampleUnderlineTokens("Register", "GetExtension")]
        public static void CreateCustomExtension(MemoEdit memoEdit, BehaviorManager behaviorManager, List<IDisposable> disposables) {
            var defaultContainer = AIExtensionsContainerDesktop.Default;
            var disposableToken = defaultContainer.Register<AuthoredStyleRequest, AuthoredStyleExtension>();
            // Here we store the token to dispose at later stage
            disposables.Add(disposableToken);
            string MenuCaption = "Authored Style";
            memoEdit.Properties.BeforeShowMenu += (s, e) => {
                var menuItem = e.Menu.Items.FirstOrDefault(x => x.Caption == MenuCaption) as DXSubMenuItem;
                if(menuItem == null) {
                    menuItem = new DevExpress.Utils.Menu.DXSubMenuItem(MenuCaption);
                    string[] authors = new string[] { "Mark Twain", "Ernest Hemingway", "Maya Angelou" };
                    foreach(string author in authors) {
                        menuItem.Items.Add(new DXMenuItem(author, async (ss, ee) => {
                            var extension = (AuthoredStyleExtension)defaultContainer.GetExtension(typeof(AuthoredStyleRequest));
                            var request = new AuthoredStyleRequest(author, memoEdit.SelectedText);
                            string result = await AIOverlayFormHelper.Execute(memoEdit, extension, request);
                            memoEdit.SelectedText = result;
                        }));
                    }
                    e.Menu.Items.Add(menuItem);
                }
            };
        }
        //
        [CodeExampleNestedClass]
        public class WilliamShakespeareStyleExtension : ProofreadExtension {
            public WilliamShakespeareStyleExtension(IServiceProvider serviceProvider)
                : base(serviceProvider) { }
            protected override string GetSystemPrompt(ProofreadRequest request) {
                return "Rewrite this text in the William Shakespeare style.";
            }
        }
        //
        [CodeExampleNestedClass]
        public class AuthoredStyleExtension : ChangeTextExtension<AuthoredStyleRequest> {
            public AuthoredStyleExtension(IServiceProvider serviceProvider)
                : base(serviceProvider) { }
            protected override string GetSystemPrompt(AuthoredStyleRequest request) {
                return String.Format("Rewrite this text in the {0} style", request.Author);
            }
        }
        // Custom text processing request
        [CodeExampleNestedClass]
        public class AuthoredStyleRequest : TextRequest {
            public AuthoredStyleRequest(string Author, string Text)
                : base(Text) {
                this.Author = Author;
            }
            public string Author { get; set; }
        }
    }
}
#pragma warning restore CRR0033, CRR0029

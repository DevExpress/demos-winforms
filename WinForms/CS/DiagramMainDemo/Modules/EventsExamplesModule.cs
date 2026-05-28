using System;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraDiagram.Demos {
    public class EventsExamplesModule : CodeTutorialControlBase {
        static EventsExamplesModule() {
            using(new DiagramControl()) { }
        }
        protected override ExampleLanguage CurrentExampleLanguage { get { return DemoHelper.GetLanguageString(typeof(CodeFirstModule).Assembly) == "CS" ? ExampleLanguage.Csharp : ExampleLanguage.VB; } }
        protected override string[] FileNamesForModule { get { return new[] { "EventsExamples.cs" }; } }
    }
}

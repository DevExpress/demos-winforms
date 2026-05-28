using System.Collections.Generic;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos.CodeExamples {
    public class HtmlFile : CodeExampleResourceFile {
        readonly bool allowModify;
        public HtmlFile(string fileName, bool allowModify = true)
            : base(typeof(HtmlFile).Assembly.FullName, GetResourceName(fileName)) {
            this.allowModify = allowModify;
            Name = "[HTML]";
        }
        public HtmlFile(params string[] fileNames)
            : base(typeof(HtmlFile).Assembly.FullName, string.Empty) {
            List<string> res = new List<string>();
            foreach(var item in fileNames)
                res.Add(GetResourceName(item));
            this.allowModify = false;
            this.ResourceNames = res.ToArray();
        }
        protected override bool AllowModify {
            get { return allowModify; }
        }
        static string GetResourceName(string fileName) {
            const string resourcePath = "DevExpress.HTML.Demos.CodeExamples.html.";
            if(DemoHelper.IsCSharp)
#pragma warning disable DX0025 // not a path but resource
                return resourcePath + fileName + ".html";
            else
                return fileName.Split('.').Last() + ".html";
#pragma warning restore DX0025
        }
    }
}

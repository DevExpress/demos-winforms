using System.Collections.Generic;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos.CodeExamples {
    public class CssFile : CodeExampleResourceFile {
        readonly bool allowModify;
        public CssFile(string fileName, bool allowModify = true)
            : base(typeof(CssFile).Assembly.FullName, GetResourceName(fileName)) {
            this.allowModify = allowModify;
            Name = "[CSS]";
        }
        public CssFile(params string[] fileNames)
            : base(typeof(CssFile).Assembly.FullName, string.Empty) {
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
            const string resourcePath = "DevExpress.HTML.Demos.CodeExamples.css.";
            if(DemoHelper.IsCSharp)
#pragma warning disable DX0025 // not a path but resource
                return resourcePath + fileName + ".css";
            else
                return fileName.Split('.').Last() + ".css";
#pragma warning restore DX0025
        }
    }
}

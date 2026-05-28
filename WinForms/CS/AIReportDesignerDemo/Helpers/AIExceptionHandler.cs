using System;
using DevExpress.AIIntegration;

namespace DevExpress.AI.ReportDesigner.Demo.Helpers {
    public class AIExceptionHandler : IAIExceptionHandler {
        public void ProcessException(AIExceptionArgs args) {
            if(!(args.Exception is AIDemoException))
                args.Exception = new Exception("Something went wrong.", args.Exception);
        }
    }
    //
    public class AIDemoException : Exception {
        public AIDemoException(string message) : base(message) {
        }
    }
}

using System;
using DevExpress.AIIntegration;

namespace XtraReportsDemos.AIOperations {
    public class AIExceptionHandler : IAIExceptionHandler {
        public void ProcessException(AIExceptionArgs args) {
            if(!(args.Exception is AIDemoException))
                args.Exception = new Exception("Something went wrong.", args.Exception);
        }
    }
}

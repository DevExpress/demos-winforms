#if NET
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.Demos.AITools {
    public static class SimpleTools {
        public static List<AITool> Tools { get; } = new List<AITool> {
            AIFunctionFactory.Create(() => DateTime.UtcNow.ToString("O"), "GetCurrentUtcTime", "Returns the current UTC time in ISO 8601 format."),
            AIFunctionFactory.Create((int a, int b) => a + b, "SumNumbers", "Returns the sum of two integers."),
            AIFunctionFactory.Create((string text) => string.Concat(text.Reverse()), "ReverseText", "Reverses the supplied text."),
        };
    }
}
#endif

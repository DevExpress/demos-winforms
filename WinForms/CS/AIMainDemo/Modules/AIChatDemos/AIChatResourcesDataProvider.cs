using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.AI;
using DevExpress.Data.Utils;
using DevExpress.Security;


#if NET
using DevExpress.AIIntegration.Blazor.Chat;
#endif

namespace DevExpress.AI.Demos {
    public static class AIChatResourcesDataProvider {
#if NET
        static Dictionary<string, AIChatResource> _resources;

        static AIChatResourcesDataProvider() {
            var accessLog = new AIChatResource("access.txt", "Access Log", GetLogResource, "text/plain", "Web server access log for the past 24 hours.");
            var dashboardImage = new AIChatResource("dashboard.jpg", "Dashboard (Screenshot)", GetImageResource, "image/jpeg", "Latest dashboard screenshot for real-time data analysis.");
            var chatDocumentation = new AIChatResource("dxaichat.md", "AI Chat Documentation", GetDocsResource, "text/markdown", "Reference guide for AI Chat functionality and usage.");

            _resources = new Dictionary<string, AIChatResource> {
                { accessLog.Uri, accessLog },
                { dashboardImage.Uri, dashboardImage },
                { chatDocumentation.Uri, chatDocumentation }
            };
        }

        static string GetFilePath(string fileName) {
            if(_resources.TryGetValue(fileName, out var resource)) {
                string root = SafeEnvironment.CurrentDirectory;
                if(string.IsNullOrEmpty(root))
                    throw new InvalidOperationException("Cannot find the current directory.");
                string path = Path.Combine(root, "Resources", "AIChat", resource.Uri);
                if(!SafePath.IsRooted(root, path))
                    throw new InvalidOperationException($"Resource '{fileName}' path '{path}' is outside the allowed root directory '{root}'.");
                return path;
            }

            throw new InvalidOperationException($"Resource '{fileName}' not found.");
        }

        static async Task<IList<AIContent>> GetLogResource(AIChatResource resource, CancellationToken ct) {
            var text = await File.ReadAllTextAsync(GetFilePath(resource.Uri), ct);
            return new List<AIContent> { new TextContent(text) };
        }
        static async Task<ReadOnlyMemory<byte>> GetImageResource(AIChatResource resource, CancellationToken ct) => await File.ReadAllBytesAsync(GetFilePath(resource.Uri), ct);
        static async Task<string> GetDocsResource(AIChatResource resource, CancellationToken ct) => await File.ReadAllTextAsync(GetFilePath(resource.Uri), ct);

        public static List<AIChatResource> GetData() => _resources.Values.ToList();
#endif
    }
}

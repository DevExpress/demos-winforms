#if NET
using Microsoft.AspNetCore.Components;
using DevExpress.AIIntegration.Blazor.Chat;

namespace DevExpress.AI.Demos {
    public partial class MessageTemplate : ComponentBase {
        [Parameter] public BlazorChatMessage Context { get; set; } = default!;
        
        string GetMessageClasses(BlazorChatMessage message) {
            if(message.Role == ChatMessageRole.Assistant) {
                return "demo-chat-message demo-assistant-message";
            } else if(message.Role == ChatMessageRole.User) {
                return "demo-chat-message demo-user-message";
            } else if(message.Role == ChatMessageRole.Error) {
                return "demo-chat-message demo-error-message";
            }
            return "demo-chat-message";
        }
    }
}
#endif

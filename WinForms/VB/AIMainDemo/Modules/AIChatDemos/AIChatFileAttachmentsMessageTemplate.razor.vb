#If NET
using Microsoft.AspNetCore.Components;
using DevExpress.AIIntegration.Blazor.Chat;
using System;
using System.Collections.Generic;

namespace DevExpress.AI.Demos {
    public enum FileTypes {
        Images,
        Documents,
        Tables
    }

    public partial class AIChatFileAttachmentsMessageTemplate : ComponentBase {
        [Parameter] public BlazorChatMessage Context { get; set; } = default!;
        [Parameter] public List<string> ImageExtensions  { get; set; } = default!;
        [Parameter] public string FileIconBase64 { get; set; } = default!;

        string GetImageSrc(AIChatUploadFileInfo file) {
            var base64 = Convert.ToBase64String(file.Data.ToArray());
            return $"data:{file.Type};base64,{base64}";
        }

        string GetMessageClasses(BlazorChatMessage message) {
            return DevExpress.Blazor.Internal.Utils.CombineCssClasses("dxbl-chatui-message", message.Role switch {
                ChatMessageRole.User => "dxbl-chatui-message-user",
                ChatMessageRole.System => "dxbl-chatui-message-system",
                ChatMessageRole.Assistant => "dxbl-chatui-message-assistant",
                ChatMessageRole.Tool => "dxbl-chatui-message-assistant",
                ChatMessageRole.Error => "dxbl-chatui-message-error",
                _ => string.Empty
            });
        }
    }
}
#End If

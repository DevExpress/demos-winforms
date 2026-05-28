#If NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Agents.AI;
using Microsoft.Agents.AI.Workflows;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.Demos.Agents.Publishing {
    public sealed class PublishingGroupChatManager : GroupChatManager {
        readonly IReadOnlyList<AIAgent> agents;

        public PublishingGroupChatManager(IReadOnlyList<AIAgent> agents) {
            this.agents = agents ?? throw new ArgumentNullException(nameof(agents));
        }

        protected override ValueTask<AIAgent> SelectNextAgentAsync(
            IReadOnlyList<ChatMessage> history,
            CancellationToken cancellationToken = default) {
            if(history.Count == 0)
                throw new InvalidOperationException("Conversation is empty; cannot select next speaker.");

            if(IterationCount == 0)
                return new ValueTask<AIAgent>(agents.First(a => a.Name == "ContentReviewer"));

            return new ValueTask<AIAgent>(agents.First(a => a.Name == "Publisher"));
        }
    }
}
#End If

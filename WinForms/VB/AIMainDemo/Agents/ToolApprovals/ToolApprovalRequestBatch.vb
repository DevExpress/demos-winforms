#If NET
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.Demos.Agents.ToolApprovals {
    enum ToolApprovalRequestState {
        Pending,
        Approved,
        Rejected
    }
    public class ToolApprovalRequestBatch {
        readonly List<ToolApprovalRequestContent> requests;
        readonly Dictionary<string, ToolApprovalRequestState> states = new Dictionary<string, ToolApprovalRequestState>();

        ToolApprovalRequestState GetState(string requestId) {
            if(states.TryGetValue(requestId, out var state)) return state;
            throw new InvalidOperationException($"Request with id {requestId} not found.");
        }

        void SetState(string requestId, ToolApprovalRequestState state) {
            if(!states.ContainsKey(requestId))
                throw new InvalidOperationException($"Request with id {requestId} not found.");
            states[requestId] = state;
        }

        public ToolApprovalRequestBatch(List<ToolApprovalRequestContent> requests) {
            this.requests = new List<ToolApprovalRequestContent>(requests);
            this.requests.ForEach(r => states[r.RequestId] = ToolApprovalRequestState.Pending);
        }

        public bool IsRequestResolved(string requestId) =>
            GetState(requestId) != ToolApprovalRequestState.Pending;
        public bool IsRequestRejected(string requestId) =>
            GetState(requestId) == ToolApprovalRequestState.Rejected;
        public void ApproveRequest(string requestId) =>
            SetState(requestId, ToolApprovalRequestState.Approved);
        public void RejectRequest(string requestId) =>
            SetState(requestId, ToolApprovalRequestState.Rejected);

        public List<AIContent> GenerateResponses() {
            return requests
                .FindAll(r => states[r.RequestId] != ToolApprovalRequestState.Pending)
                .Select(r => states[r.RequestId] == ToolApprovalRequestState.Approved
                    ? r.CreateResponse(true)
                    : r.CreateResponse(false, "The user rejected this operation. Confirm cancellation and reassure them no changes were made.")
                )
                .ToList<AIContent>();
        }

        public int CountPendingRequests() =>
            requests.Count(r => states[r.RequestId] == ToolApprovalRequestState.Pending);
    }
}
#End If

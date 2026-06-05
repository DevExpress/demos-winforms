#If NET
using System;
using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.Demos.Agents.ToolApprovals {
    public static class ToolApprovalAIFunctions {
        public static AIFunction UpdateAccountTierTool => new ApprovalRequiredAIFunction(
            AIFunctionFactory.Create(UpdateAccountTier,
                description: "Updates the account tier for CRM accounts matching the specified state and active status. Use this when users ask to change, update, or set the tier level of accounts.")
        );

        public static AIFunction SendBulkEmailTool => new ApprovalRequiredAIFunction(
            AIFunctionFactory.Create(SendBulkEmail,
                description: "Sends a bulk email to recipients based on a filter criteria. Use this when users ask to send emails, reminders, or notifications to a group of people.")
        );

        public static AIFunction ArchiveOrdersTool => new ApprovalRequiredAIFunction(
            AIFunctionFactory.Create(ArchiveOrders,
                description: "Archives or deletes orders older than a specified date threshold. Use this when users ask to clean up, archive, or remove old orders.")
        );

        [Description("Updates the account tier for all CRM accounts matching the given state and active status.")]
        static string UpdateAccountTier(
            [Description("The full state name, e.g. 'Texas', 'California', 'New York'")] string state,
            [Description("Whether to target active (true) or inactive (false) accounts")] bool isActive,
            [Description("The new tier level to assign, e.g. 'Tier 1', 'Tier 2', 'Tier 3'")] string newTier,
            [Description("Number of accounts that will be updated (e.g. 8)")] int accountCount) {
            return $"All {accountCount} {(isActive ? "active" : "inactive")} accounts in {state} have been moved to the {newTier} service level.";
        }

        [Description("Sends a bulk email notification to recipients matching the specified filter.")]
        static string SendBulkEmail(
            [Description("The filter for selecting recipients, e.g. 'overdue invoices', 'unpaid accounts'")] string recipientFilter,
            [Description("The email template to use, e.g. 'Friendly Nudge', 'Overdue Notice', 'Payment Reminder'")] string template,
            [Description("The email subject line")] string subject,
            [Description("Number of clients who will receive the email (e.g. 4)")] int clientCount,
            [Description("Total outstanding balance across selected clients (e.g. '$321.00')")] string totalBalance) {
            return $"All {clientCount} clients have been successfully nudged regarding their unpaid balances. Total balance: {totalBalance}.";
        }

        [Description("Archives orders older than the specified date threshold.")]
        static string ArchiveOrders(
            [Description("The cutoff year — orders before this year will be archived, e.g. 2020")] int year,
            [Description("The earliest year to include in the archive range (e.g. 1999)")] int startYear,
            [Description("Number of order records to be archived (e.g. 1234)")] int recordCount,
            [Description("Archive destination name (e.g. 'Secure archive vault')")] string destination) {
            return $"{recordCount:N0} records from {startYear}–{year} have been moved to the {destination}.";
        }
    }
}
#End If

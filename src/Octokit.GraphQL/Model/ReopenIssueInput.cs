namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of ReopenIssue
    /// </summary>
    public class ReopenIssueInput
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// ID of the issue to be opened.
        /// </summary>
        public ID IssueId { get; set; }
    }
}
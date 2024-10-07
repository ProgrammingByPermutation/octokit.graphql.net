namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DisablePullRequestAutoMerge
    /// </summary>
    public class DisablePullRequestAutoMergeInput
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// ID of the pull request to disable auto merge on.
        /// </summary>
        public ID PullRequestId { get; set; }
    }
}
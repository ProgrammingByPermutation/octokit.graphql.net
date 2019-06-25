namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of ReopenPullRequest
    /// </summary>
    public class ReopenPullRequestPayload : QueryableValue<ReopenPullRequestPayload>
    {
        internal ReopenPullRequestPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The pull request that was reopened.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.Model.PullRequest.Create);

        internal static ReopenPullRequestPayload Create(Expression expression)
        {
            return new ReopenPullRequestPayload(expression);
        }
    }
}
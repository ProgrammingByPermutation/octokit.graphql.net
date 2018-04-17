namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DismissPullRequestReview
    /// </summary>
    public class DismissPullRequestReviewPayload : QueryableValue<DismissPullRequestReviewPayload>
    {
        public DismissPullRequestReviewPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The dismissed pull request review.
        /// </summary>
        public PullRequestReview PullRequestReview => this.CreateProperty(x => x.PullRequestReview, Octokit.GraphQL.Model.PullRequestReview.Create);

        internal static DismissPullRequestReviewPayload Create(Expression expression)
        {
            return new DismissPullRequestReviewPayload(expression);
        }
    }
}
namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of CreateSponsorsListing
    /// </summary>
    public class CreateSponsorsListingPayload : QueryableValue<CreateSponsorsListingPayload>
    {
        internal CreateSponsorsListingPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The new GitHub Sponsors profile.
        /// </summary>
        public SponsorsListing SponsorsListing => this.CreateProperty(x => x.SponsorsListing, Octokit.GraphQL.Model.SponsorsListing.Create);

        internal static CreateSponsorsListingPayload Create(Expression expression)
        {
            return new CreateSponsorsListingPayload(expression);
        }
    }
}
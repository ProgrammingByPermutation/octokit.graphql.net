namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateSponsorshipPreferences
    /// </summary>
    public class UpdateSponsorshipPreferencesPayload : QueryableValue<UpdateSponsorshipPreferencesPayload>
    {
        internal UpdateSponsorshipPreferencesPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The sponsorship that was updated.
        /// </summary>
        public Sponsorship Sponsorship => this.CreateProperty(x => x.Sponsorship, Octokit.GraphQL.Model.Sponsorship.Create);

        internal static UpdateSponsorshipPreferencesPayload Create(Expression expression)
        {
            return new UpdateSponsorshipPreferencesPayload(expression);
        }
    }
}
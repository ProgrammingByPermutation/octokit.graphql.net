namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of TransferEnterpriseOrganization
    /// </summary>
    public class TransferEnterpriseOrganizationPayload : QueryableValue<TransferEnterpriseOrganizationPayload>
    {
        internal TransferEnterpriseOrganizationPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The organization for which a transfer was initiated.
        /// </summary>
        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.GraphQL.Model.Organization.Create);

        internal static TransferEnterpriseOrganizationPayload Create(Expression expression)
        {
            return new TransferEnterpriseOrganizationPayload(expression);
        }
    }
}
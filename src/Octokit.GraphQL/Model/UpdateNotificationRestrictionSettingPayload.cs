namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateNotificationRestrictionSetting
    /// </summary>
    public class UpdateNotificationRestrictionSettingPayload : QueryableValue<UpdateNotificationRestrictionSettingPayload>
    {
        internal UpdateNotificationRestrictionSettingPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The owner on which the setting was updated.
        /// </summary>
        public VerifiableDomainOwner Owner => this.CreateProperty(x => x.Owner, Octokit.GraphQL.Model.VerifiableDomainOwner.Create);

        internal static UpdateNotificationRestrictionSettingPayload Create(Expression expression)
        {
            return new UpdateNotificationRestrictionSettingPayload(expression);
        }
    }
}
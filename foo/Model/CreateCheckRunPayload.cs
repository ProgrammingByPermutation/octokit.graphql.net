namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of CreateCheckRun
    /// </summary>
    public class CreateCheckRunPayload : QueryableValue<CreateCheckRunPayload>
    {
        internal CreateCheckRunPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The newly created check run.
        /// </summary>
        public CheckRun CheckRun => this.CreateProperty(x => x.CheckRun, Octokit.GraphQL.Model.CheckRun.Create);

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        internal static CreateCheckRunPayload Create(Expression expression)
        {
            return new CreateCheckRunPayload(expression);
        }
    }
}
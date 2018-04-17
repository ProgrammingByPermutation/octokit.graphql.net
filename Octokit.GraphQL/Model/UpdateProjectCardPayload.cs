namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateProjectCard
    /// </summary>
    public class UpdateProjectCardPayload : QueryableValue<UpdateProjectCardPayload>
    {
        public UpdateProjectCardPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated ProjectCard.
        /// </summary>
        public ProjectCard ProjectCard => this.CreateProperty(x => x.ProjectCard, Octokit.GraphQL.Model.ProjectCard.Create);

        internal static UpdateProjectCardPayload Create(Expression expression)
        {
            return new UpdateProjectCardPayload(expression);
        }
    }
}
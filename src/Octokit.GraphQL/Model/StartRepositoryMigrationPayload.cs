namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of StartRepositoryMigration
    /// </summary>
    public class StartRepositoryMigrationPayload : QueryableValue<StartRepositoryMigrationPayload>
    {
        internal StartRepositoryMigrationPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The new repository migration.
        /// </summary>
        public RepositoryMigration RepositoryMigration => this.CreateProperty(x => x.RepositoryMigration, Octokit.GraphQL.Model.RepositoryMigration.Create);

        internal static StartRepositoryMigrationPayload Create(Expression expression)
        {
            return new StartRepositoryMigrationPayload(expression);
        }
    }
}
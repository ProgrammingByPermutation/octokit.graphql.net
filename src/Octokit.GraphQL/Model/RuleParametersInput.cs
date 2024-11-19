namespace Octokit.GraphQL.Model
{
    using Core.Serializers;

    /// <summary>
    /// Specifies the parameters for a `RepositoryRule` object. Only one of the fields should be specified.
    /// </summary>
    public class RuleParametersInput
    {
        /// <summary>
        /// Parameters used for the `update` rule type
        /// </summary>
        [SerializeIfNotNull]
        public UpdateParametersInput Update { get; set; }

        /// <summary>
        /// Parameters used for the `required_deployments` rule type
        /// </summary>
        [SerializeIfNotNull]
        public RequiredDeploymentsParametersInput RequiredDeployments { get; set; }

        /// <summary>
        /// Parameters used for the `pull_request` rule type
        /// </summary>
        [SerializeIfNotNull]
        public PullRequestParametersInput PullRequest { get; set; }

        /// <summary>
        /// Parameters used for the `required_status_checks` rule type
        /// </summary>
        [SerializeIfNotNull]
        public RequiredStatusChecksParametersInput RequiredStatusChecks { get; set; }

        /// <summary>
        /// Parameters used for the `commit_message_pattern` rule type
        /// </summary>
        [SerializeIfNotNull]
        public CommitMessagePatternParametersInput CommitMessagePattern { get; set; }

        /// <summary>
        /// Parameters used for the `commit_author_email_pattern` rule type
        /// </summary>
        [SerializeIfNotNull]
        public CommitAuthorEmailPatternParametersInput CommitAuthorEmailPattern { get; set; }

        /// <summary>
        /// Parameters used for the `committer_email_pattern` rule type
        /// </summary>
        [SerializeIfNotNull]
        public CommitterEmailPatternParametersInput CommitterEmailPattern { get; set; }

        /// <summary>
        /// Parameters used for the `branch_name_pattern` rule type
        /// </summary>
        [SerializeIfNotNull]
        public BranchNamePatternParametersInput BranchNamePattern { get; set; }

        /// <summary>
        /// Parameters used for the `tag_name_pattern` rule type
        /// </summary>
        [SerializeIfNotNull]
        public TagNamePatternParametersInput TagNamePattern { get; set; }

        /// <summary>
        /// Parameters used for the `workflows` rule type
        /// </summary>
        [SerializeIfNotNull]
        public WorkflowsParametersInput Workflows { get; set; }
    }
}